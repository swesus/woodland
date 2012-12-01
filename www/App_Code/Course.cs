using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

public class Course : CourseBase
{
    private Guid? RequestId 
    { 
        get 
        {
            try
            {
                string courseId = HttpContext.Current.Request.QueryString["CourseId"].ToString();
                
                if (string.IsNullOrEmpty(courseId))
                {
                    throw new Exception("empty");
                }
                else
                {
                    return new Guid(courseId);
                }
            }
            catch
            {
                return null;
            }
        }
    }

    private string RequestTitle 
    { 
        get 
        {
            try
            {
                return HttpContext.Current.Request.QueryString["Course"].ToString();
            }
            catch
            {
                return null;
            }
        } 

    }

    #region Contructors

    
    public Course(bool onlyPublished)
    {
        if (RequestId.HasValue)
        {
            Constructor(RequestId.Value, onlyPublished);
        }
        else if (!string.IsNullOrEmpty(RequestTitle))
        {
            Constructor(RequestTitle, onlyPublished);
        }
    }

    public Course(Guid id, bool onlyPublished)
    {
        Constructor(id, onlyPublished);
    }

    public Course(string titleEncoded, bool onlyPublished)
    {
        Constructor(titleEncoded, onlyPublished);
    }

    private void Constructor(Guid id, bool onlyPublished)
    {
        string sql = "SELECT * FROM TBL_WoodlandLife_Courses " +
            " WHERE Id=" + JuggleDrumManager.SqlInject.Guid(id);

        if (onlyPublished) sql += " AND Published=1 ";

        try
        {
            DataTable table = JuggleDrumManager.DB.Query(sql);
            this.PopulateFromTblCourses(table.Rows[0]);
        }
        catch { }
    }

    private void Constructor(string titleEncoded, bool onlyPublished)
    {
        string sql = "SELECT * FROM TBL_WoodlandLife_Courses " +
            " WHERE [TitleEncoded]=" + JuggleDrumManager.SqlInject.String(titleEncoded);
 
        if (onlyPublished) sql += " AND Published=1 ";

        try
        {
            DataTable table = JuggleDrumManager.DB.Query(sql);

            this.PopulateFromTblCourses(table.Rows[0]);
        }
        catch { }
    } 

    public Course(DataRow row, bool onlyPublished)
    {
        if (onlyPublished && !(bool)row["Published"])
        {
            return;
        }
        else
        {
            this.PopulateFromTblCourses(row);
        }
    }

    #endregion






    #region GetCoursesList

    public static List<Course> GetCoursesList(bool onlyPublished)
    {
        if (onlyPublished)
        {
            return GetCoursesList(" WHERE Published=1 ", onlyPublished);
        }
        else
        {
            return GetCoursesList("", onlyPublished);
        }
    }

    public static List<Course> GetCoursesList(CourseTypes courseType, bool onlyPublished)
    {
        string where = " WHERE Type=" + (int)courseType;
        if (onlyPublished)
        {
            where += " AND  Published=1 ";
        }
        return GetCoursesList(where, onlyPublished);
    }

    private static List<Course> GetCoursesList(string where, bool onlyPublished)
    {
        string sql = string.Format(
            "SELECT * FROM TBL_WoodlandLife_Courses {0} ORDER BY Type, [Order]",
            where
        );

        DataTable table = JuggleDrumManager.DB.Query(sql);

        List<Course> courseList = new List<Course>();

        foreach (DataRow row in table.Rows)
        {
            courseList.Add(new Course(row, onlyPublished));
        }

        return courseList;
    }
    #endregion


}