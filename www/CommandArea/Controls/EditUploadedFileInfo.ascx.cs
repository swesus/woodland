using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CommandArea_Controls_EditUploadedFileInfo : System.Web.UI.UserControl
{
    public void BindToRow(DataRow row)
    {
        string fileName = row["FileName"].ToString();

        oFileId.Value = row["FileID"].ToString();
        oLabel.Text = fileName;
        oDescription.Text = row["Description"].ToString();
        //row["Page"].ToString();
        oDisplayInGallery.Checked = bool.Parse(row["DisplayInGallery"].ToString());
        oDisplayOnCoursesPage.Checked = bool.Parse(row["DisplayOnCoursesPage"].ToString());



        string src = "/UploadedFiles/" + fileName;

        if (fileName.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) || fileName.EndsWith(".gif", StringComparison.InvariantCultureIgnoreCase))
        {
            oImageRow.Visible = true;
            oImage.ImageUrl = src;

            oHtmlOutput.Text = string.Format(
                "<img src='{0}' alt='{1}' class='left' />",
                Server.HtmlEncode(src),
                Server.HtmlEncode(oDescription.Text)
            );
        }
        else
        {
            oHtmlOutput.Text = string.Format(
                "<a href='{0}'>{1}</a>",
                Server.HtmlEncode(src),
                string.IsNullOrEmpty(oDescription.Text) ? "Download" : Server.HtmlEncode(oDescription.Text)
            );
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region Save methods

    protected void Save_Click(object sender, EventArgs e)
    {
        SaveToDB();
    }


    private void SaveToDB()
    {
        Guid fileId = new Guid(oFileId.Value);
        string description = oDescription.Text;
        bool displayInGallery = oDisplayInGallery.Checked;
        bool displayOnCoursesPage = oDisplayOnCoursesPage.Checked;

        SaveToDB(fileId, description, displayInGallery, displayOnCoursesPage);
    }


    private void SaveToDB(Guid fileId, string description, bool displayInGallery, bool displayOnCoursesPage)
    {
        string sql_Update = string.Format(
            " UPDATE TBL_WoodlandLife_Files SET " +
            " Description={0}, DisplayInGallery={1}, DisplayOnCoursesPage={2} " +
            " WHERE FileID={3} ",

            JuggleDrumManager.SqlInject.String(description),
            JuggleDrumManager.SqlInject.Bool(displayInGallery),
            JuggleDrumManager.SqlInject.Bool(displayOnCoursesPage),

            JuggleDrumManager.SqlInject.Guid(fileId)
        );

        JuggleDrumManager.DB.NonQuery(sql_Update);
    }

    #endregion
}