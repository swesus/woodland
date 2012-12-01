using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class CommandArea_Controls_FileUpload : System.Web.UI.UserControl
{
    #region Properties

    public string Label { get { return oLabel.Text; } set { oLabel.Text = value; } }

    private string Message
    {
        set
        {
            oMessage.Visible = true;
            oMessage.InnerText = value;
        }
    }

    #endregion

    protected void Upload_Click(object sender, EventArgs e)
    {
        //Check that we are happy with the state of the page:

        if (!oAspFileUpload.HasFile)
        {
            return;
        }

        FileType fileType = GetTypeOfFile();

        if (fileType == FileType.NotRecognised)
        {
            return;
        }


        //Go ahead and save the file:

        try
        {
            SaveFileToDisk(fileType);
            SaveToDB(oAspFileUpload.FileName);
            
            //Success:
            string p = this.Page.AppRelativeVirtualPath;
            Server.Transfer(this.Page.AppRelativeVirtualPath, false);
        }
        catch (Exception ex)
        {
            Message = "File upload failed. <!-- ex.Message was : " + ex.Message + " -->";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // Clear the message:
        oMessage.InnerText = "";
        oMessage.Visible = false;
    }

    private void SaveFileToDisk(FileType fileType)
    {
        if (fileType == FileType.Image)
        {
            //Save orgional:
            string completePath = Server.MapPath("~/UploadedFiles/UneditedOriginals/") + oAspFileUpload.FileName;
            oAspFileUpload.PostedFile.SaveAs(completePath);

            //Edit for web and then save:
            using (
                JuggleDrumManager.Image editedImage =
                new JuggleDrumManager.Image(
                    oAspFileUpload.PostedFile.InputStream, 
                    oAspFileUpload.FileName, 
                    Server.MapPath("~/UploadedFiles/"))
            )
            {
                editedImage.MaxHeight = 300;
                editedImage.MaxWidth = 300;
                editedImage.SaveToDisk();
            }
        }
        else
        {
            //Just save staight to the web directory:
            string completePath = Server.MapPath("~/UploadedFiles/") + oAspFileUpload.FileName;
            oAspFileUpload.PostedFile.SaveAs(completePath);
        }
    }


    private FileType GetTypeOfFile()
    {
        String fileExtension = System.IO.Path.GetExtension(oAspFileUpload.FileName).ToLower();

        switch(fileExtension)
        {
            case ".gif":
            case ".jpg": 
                return FileType.Image;

            case ".doc":
            case ".docx": 
            case ".pdf":
                return FileType.Text;

            default:
                Message = "The only allowed file types are : .gif, .jpg, .doc, .docx, .pdf";
                return FileType.NotRecognised;
        }
    }

    private enum FileType { NotRecognised, Image, Text }




    #region DB methods

    private void SaveToDB(string fileName)
    {
        Guid fileId = Guid.NewGuid();
        string description = oDescription.Text;
        string page = string.Empty;
        bool displayInGallery = oDisplayInGallery.Checked;
        bool displayOnCoursesPage = oDisplayOnCoursesPage.Checked;

        SaveToDB(fileId, fileName, description, page, displayInGallery, displayOnCoursesPage);
    }

    private void SaveToDB(Guid fileId, string fileName, string description, string page, bool displayInGallery, bool displayOnCoursesPage)
    {
        string sql_Insert = string.Format(
            "INSERT INTO TBL_WoodlandLife_Files (FileID, FileName, Description, Page, DisplayInGallery, DisplayOnCoursesPage) VALUES ( {0}, {1}, {2}, {3}, {4}, {5} );",
            JuggleDrumManager.SqlInject.Guid(fileId),
            JuggleDrumManager.SqlInject.String(fileName),
            JuggleDrumManager.SqlInject.String(description),
            JuggleDrumManager.SqlInject.String(page),
            JuggleDrumManager.SqlInject.Bool(displayInGallery),
            JuggleDrumManager.SqlInject.Bool(displayOnCoursesPage)
        );

        JuggleDrumManager.DB.NonQuery(sql_Insert);
    }

    #endregion


}
