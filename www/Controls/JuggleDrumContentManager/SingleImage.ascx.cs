using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuggleDrumManager.Rows;


public partial class SingleImage : System.Web.UI.UserControl
{
    public Guid ContentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ImageRow imageRow = new JuggleDrumManager.Rows.ImageRow(IdType.ContentId, ContentID);
            DisplayImage.ImageUrl = imageRow.HtmlSrc;
            DisplayImage.AlternateText = imageRow.AltText;
            DisplayImage.Visible = !string.IsNullOrEmpty(DisplayImage.AlternateText);

            if (JuggleDrumManager.Login.LoggedIn)
            {
                EditPanel.Visible = true;
                AltText.Text = imageRow.HtmlSrc;
            }
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
	    if (FileUpLoad.HasFile)
        {
            //Set new image row
            ImageRow newImageRow = new JuggleDrumManager.Rows.ImageRow(IdType.ContentId, ContentID);
            newImageRow.AltText = this.AltText.Text;

            try
            {
                //Set new image object
                JuggleDrumManager.Image newImage = new JuggleDrumManager.Image(this.FileUpLoad.FileContent, this.FileUpLoad.FileName);
                newImage.MaxWidth = 400;
                newImage.SaveToDisk();

                //Set new image row
                newImageRow.HtmlSrc = System.Text.RegularExpressions.Regex.Match(newImage.Path, @"/images/uploaded/.+").Value;

                //Update page
                UserMessage.Text = "<p><em>Image uploaded successfully</em></p>";
                DisplayImage.Visible = true;
            }
            catch(JuggleDrumManager.PublicMessageException ex)
            {
                UserMessage.Text = string.Format("<p><em>{0}</em></p>", ex.Message);
            }

            newImageRow.InsertOrUpdateRow();
	    }
    }
}


