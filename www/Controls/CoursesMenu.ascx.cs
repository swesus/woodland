using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Controls_CoursesMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InitOContent();
    }

    protected void InitOContent()
    {
        CourseTypeList currentCourseTypeList = null;
        StringBuilder html = new StringBuilder();

        foreach (Course course in Course.GetCoursesList(true))
        {
            if (currentCourseTypeList == null)
            {
                currentCourseTypeList = new CourseTypeList(course);
            }
            else if (currentCourseTypeList.currentType != course.CourseType)
            {
                html.Append(currentCourseTypeList.ToString());
                currentCourseTypeList = new CourseTypeList(course);
            }
            currentCourseTypeList.Add(course);
        }

        if (currentCourseTypeList != null)
        {
            html.Append(currentCourseTypeList.ToString());
        }

        oContent.Text = html.ToString();
    }


    public class CourseTypeList
    {
        public CourseTypeList(Course course)
        {
            this.currentType = course.CourseType;
        }

        public Course.CourseTypes currentType { get; set; }

        private StringBuilder ListItems = new StringBuilder();

        public void Add(Course course)
        {
            ListItems.AppendFormat(
                "<li><a href='Course.aspx?Course={1}'>{0}</a></li>",
                course.Title,
                course.TitleEncoded
            );
        }

        public override string ToString()
        {
            string headerText;

            switch (currentType)
            {
                case CourseBase.CourseTypes.Bush:
                    headerText = "Bush Craft &amp; Wilderness Experiances";
                    break;


                case CourseBase.CourseTypes.Outdoor:
                    headerText = "Outdoor Leisure &amp; Team Building";
                    break;

                case CourseBase.CourseTypes.Rural:
                    headerText = "Rural Crafts";
                    break;

                case CourseBase.CourseTypes.Corporate:
                    headerText = "Corporate, Inset &amp; CPD";
                    break;

                default:
                    headerText = null;
                    break;
            }

            return string.Format(@"
<div class='list {0}'><div>
    <h4>{1}</h4>
    <ul>
    {2}
    </ul>
</div></div>",
                currentType,
                headerText,
                ListItems
            );
        }
    }
}