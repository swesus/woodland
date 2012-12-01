using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommandArea_CourseEdit : System.Web.UI.Page
{
    private Course course = new Course(false);


    protected void Page_Load(object sender, EventArgs e)
    {
        oSuccessMessage.Visible = false;

        if (!Page.IsPostBack)
        {
            PopulateOLocations();
            PopulateOTypes();
            PopulateFromCourse();
        }
    }

    private void PopulateOTypes()
    {
        oType.Items.Add(new ListItem(Course.CourseTypes.Rural.ToString(), ((int)Course.CourseTypes.Rural).ToString(), true));
        oType.Items.Add(new ListItem(Course.CourseTypes.Bush.ToString(), ((int)Course.CourseTypes.Bush).ToString()));
        oType.Items.Add(new ListItem(Course.CourseTypes.Outdoor.ToString(), ((int)Course.CourseTypes.Outdoor).ToString()));
        oType.Items.Add(new ListItem(Course.CourseTypes.Corporate.ToString(), ((int)Course.CourseTypes.Corporate).ToString()));
    }

    private void PopulateOLocations()
    {
        oLocations.Items.Add(new ListItem(Course.CourseLocations.OffSite.ToString(), ((int)Course.CourseLocations.OffSite).ToString(), true));
        oLocations.Items.Add(new ListItem(Course.CourseLocations.OnSchool.ToString(), ((int)Course.CourseLocations.OnSchool).ToString()));
        oLocations.Items.Add(new ListItem(Course.CourseLocations.Either.ToString(), ((int)Course.CourseLocations.Either).ToString()));
        oLocations.Items.Add(new ListItem(Course.CourseLocations.None.ToString(), ((int)Course.CourseLocations.None).ToString()));
    }
    
    private void PopulateFromCourse()
    {
        oTitle.Text = course.Title;
        oType.SelectedValue = ((int)course.CourseType).ToString();
        oLocations.SelectedValue = ((int)course.Location).ToString();
        oLength.Text = course.Length;
        oPublished.Checked = course.Published;
        oContentHtml.Text = course.ContentHtml;
    }

    protected void oButton_Click(object sender, EventArgs e)
    {
        /*
        string imgFileName = oImageUploadField.SaveImageAndReturnFileName();
        string imgTag = "";
        if (imgFileName != null)
        {
            imgTag = string.Format("<img src='/{0}' alt='' />", imgFileName);
        }*/

        course.Title = oTitle.Text;
        course.CourseType = (CourseBase.CourseTypes)int.Parse(oType.SelectedValue);
        //course.ImageUrls
        course.ContentHtml = oContentHtml.Text;
        course.Published = oPublished.Checked;
        course.Length = oLength.Text;
        course.Location = (CourseBase.CourseLocations)int.Parse(oLocations.SelectedValue);

        course.Save();

        oSuccessMessage.Visible = true;
    }

}
