using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CoursePage : System.Web.UI.Page
{
    private Course course = new Course(true);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(course.Title))
        {
         //   Response.Redirect("Courses.aspx");
        }

        Init();
    }

    protected void Init()
    {
        oHeader.InnerText = course.Title;
        oContent.Text = course.ContentHtml;

        switch (course.CourseType)
        {
            case CourseBase.CourseTypes.Bush:
                oCourseType.ImageUrl = "~/images/courses_aspx/Wilderness.gif";
                break;
            case CourseBase.CourseTypes.Outdoor:
                oCourseType.ImageUrl = "~/images/courses_aspx/TeamBuilding.gif";
                break;
            case CourseBase.CourseTypes.Rural:
                oCourseType.ImageUrl = "~/images/courses_aspx/Crafts.gif";
                break;
            default:
                oCourseType.Visible = false;
                break;
        }

        
        //switch (course.Location)
        //{
        //    case CourseBase.CourseLocations.Either:
        //        oLocation.InnerHtml = "Can be run on or off site";
        //        break;
        //    case CourseBase.CourseLocations.OffSite:
        //        oLocation.InnerHtml = "Off Site";
        //        break;
        //    case CourseBase.CourseLocations.OnSchool:
        //        oLocation.InnerHtml = "Can be run on a school site etc.";
        //        break;
        //    case CourseBase.CourseLocations.None:
        //        oLocation.Visible = false;
        //        break;
        //}
    }
}