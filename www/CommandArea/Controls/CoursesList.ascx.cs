using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class CommandArea_Controls_CoursesList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ChangeOrder();
        InitOContent();
    }

    protected void ChangeOrder()
    {
        try
        {
            string direction = HttpContext.Current.Request["CourseChangeOrder"].ToString().ToUpper();
            Guid courseId = new Guid(HttpContext.Current.Request["CourseId"].ToString());
            Course course = new Course(courseId, false);
            
            if(direction == "UP")
            {
                course.OrderMove(true);
            }
            else if(direction == "DOWN")
            {
                course.OrderMove(false);
            }
        }
        catch { }
    }


    
    protected void InitOContent()
    {
        CourseTypeList currentCourseTypeList = null;
        StringBuilder html = new StringBuilder();

        foreach(Course course in Course.GetCoursesList(false))
        {
            if(currentCourseTypeList == null)
            {
                currentCourseTypeList = new CourseTypeList(course);
            }
            else if(currentCourseTypeList.currentType != course.CourseType)
            {
                html.Append(currentCourseTypeList.ToString());
                currentCourseTypeList = new CourseTypeList(course);
            }

            currentCourseTypeList.Add(course);
        }
        
        html.Append(currentCourseTypeList.ToString());

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
                    @"
        <li {1}>
            <a href='?CourseId={2}&CourseChangeOrder=up'><img src='images/ArrowUp.gif' alt='Up' /></a>
            <a href='?CourseId={2}&CourseChangeOrder=down'><img src='images/ArrowDown.gif' alt='Down' /></a>
            <a href='CourseEdit.aspx?CourseId={2}'>{0}</a>
        </li>",
                    course.Title,
                    course.Published ? "" : " class='unpublished' ",
                    course.Id
                );
        }

        public override string ToString()
        {
            return string.Format(@"
<div class='list'><div>
    <h4>{0}</h4>
    <ul>
    {1}
    </ul>
</div></div>",
                currentType,
                ListItems
            );
        }
    }    
}