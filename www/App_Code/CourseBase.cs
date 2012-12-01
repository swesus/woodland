using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using JuggleDrumManager;

public abstract class CourseBase
{
    private const string PathToImage = "/UploadedFiles/CourseImages/";
    public enum CourseTypes { Rural = 1, Bush, Outdoor, Corporate };
    public enum CourseLocations { OffSite = 1, OnSchool, Either, None };

    #region Members

    private Guid _Id;
    public Guid Id
    {
        get
        {
            if (_Id == new Guid())
            {
                _Id = Guid.NewGuid();
            }
            return _Id;
        }
        set { _Id = value; }
    }

    private string _Title;
    public string Title { get { return _Title; } set { _Title = value; } }
    public string TitleEncoded 
    { 
        get 
        {
            string titleEncoded =  _Title.Trim().Replace("_", "-").Replace(" ", "-");
            titleEncoded = System.Text.RegularExpressions.Regex.Replace(titleEncoded, @"[^\w\-]", "");
            return titleEncoded;
        }
    }


    private CourseTypes _CourseType;
    public CourseTypes CourseType { get { return _CourseType; } set { _CourseType = value; } }


    private List<string> _ImageUrls;
    public List<string> ImageUrls { get { return _ImageUrls; } set { _ImageUrls = value; } }

    private string _ContentHtml;
    public string ContentHtml { get { return _ContentHtml; } set { _ContentHtml = value; } }

    private bool _Published;
    public bool Published { get { return _Published; } set { _Published = value; } }

    private string _Length;
    public string Length { get { return _Length; } set { _Length = value; } }

    private CourseLocations _Location;
    public CourseLocations Location { get { return _Location; } set { _Location = value; } }

    private int _Order;
    public int Order { get { return _Order; } set { _Order = value; } }

    #endregion



    //private void PopulateImageUrls()
    //{

    //    string sql = string.Format(
    //        "SELECT * FROM TBL_WoodlandLife_CourseImages WHERE CourseId={0} OR CourseId=NULL",
    //        Id
    //    );

    //    DataTable table = JuggleDrumManager.DB.Query(sql);
    //    foreach (DataRow row in table.Rows)
    //    {
    //        ImageUrls.Add(PathToImage + row["FileName"].ToString());
    //    }
    //}

    protected void PopulateFromTblCourses(DataRow row)
    {
        this.ContentHtml = row["ContentHtml"].ToString();
        this.CourseType = (CourseTypes)(int)row["Type"];
        this.Id = (Guid)row["Id"];
        this.Length = row["Length"].ToString();
        this.Location = (CourseLocations)(int)row["Location"];
        this.Published = (bool)row["Published"];
        this.Title = row["Title"].ToString();
        this.Order = (int)row["Order"];
    }

    public void Save()
    {
        string sql = "SELECT Id FROM TBL_WoodlandLife_Courses WHERE [ID]=" + SqlInject.Guid(Id);

        if (DB.Query(sql).Rows.Count > 0)
        {
            SaveExisting();
        }
        else
        {
            SaveNew();
        }
    }

    protected void SaveExisting()
    {
        string sql = string.Format(
            " UPDATE TBL_WoodlandLife_Courses " +
            " SET [Published]={1}, [Title]={2}, [TitleEncoded]={3}, [ContentHtml]={4}, [Length]={5}, [Type]={6}, [Location]={7}, [Order]={8} " +
            " WHERE [ID]={0} ",
            SqlInject.Guid(Id),
            SqlInject.Bool(Published),
            SqlInject.String(Title),
            SqlInject.String(TitleEncoded),
            SqlInject.String(ContentHtml),
            SqlInject.String(Length),
            SqlInject.Int((int)CourseType),
            SqlInject.Int((int)Location),
            SqlInject.Int(Order)
        );

        JuggleDrumManager.DB.NonQuery(sql);
    }

    protected void SaveNew()
    {
        string sqlGetMaxOrder = " SELECT MAX([Order]) AS MaxOrder FROM TBL_WoodlandLife_Courses ";
        try
        {
            Order = 10 + int.Parse(DB.Query(sqlGetMaxOrder).Rows[0]["MaxOrder"].ToString());
        }
        catch { }

        string sql = string.Format(
            " INSERT INTO TBL_WoodlandLife_Courses " +
            " ( [ID], [Published], [Title], [TitleEncoded], [ContentHtml], [Length], [Type], [Location], [Order] ) " +
            " VALUES " +
            " ( {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8} ) ",
            SqlInject.Guid(Id),
            SqlInject.Bool(Published),
            SqlInject.String(Title),
            SqlInject.String(TitleEncoded),
            SqlInject.String(ContentHtml),
            SqlInject.String(Length),
            SqlInject.Int((int)CourseType),
            SqlInject.Int((int)Location),
            SqlInject.Int(Order)
        );

        JuggleDrumManager.DB.NonQuery(sql);
    }

    public void OrderMove(bool up)
    {
        string sqlSelect = string.Format(
            " SELECT TOP 1 [Id], [Order] " +
            " FROM TBL_WoodlandLife_Courses " +
            " WHERE [Order] {0} {1} " +
            " AND [Type] = {2} " +
            " ORDER BY [Order] {3} ",

            up ? "<" : ">",
            SqlInject.Int(Order),
            SqlInject.Int((int)CourseType),
            up ? "DESC" : "ASC"
        );

        DataTable table = DB.Query(sqlSelect);

        if (table.Rows.Count == 1)
        {

            DataRow swapRow = table.Rows[0];

            string sqlSwap = string.Format(
                " UPDATE TBL_WoodlandLife_Courses SET [Order]={0} WHERE ID={1}; " +
                " UPDATE TBL_WoodlandLife_Courses SET [Order]={2} WHERE ID={3}; ",
                SqlInject.Int(this.Order),
                SqlInject.String( swapRow["Id"].ToString()),
                SqlInject.Int(int.Parse(swapRow["Order"].ToString())),
                SqlInject.Guid(this.Id)
            );

            DB.NonQuery(sqlSwap);
            
        }

    }


    //public static void Debug(string value)
    //{
    //    HttpContext.Current.Response.Write("<p style='color:orange'>" + value + "</p>");
    //}
}