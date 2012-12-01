using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class courses : System.Web.UI.Page
{
    protected string GetListItems()
    {
        string sql_Select = "SELECT * FROM TBL_WoodlandLife_Files WHERE DisplayOnCoursesPage=1";

        var rows = JuggleDrumManager.DB.Query(sql_Select).Rows;

        StringBuilder html = new StringBuilder();

        foreach (DataRow row in rows)
        {
            html.AppendFormat(
                "<li><a href='/UploadedFiles/{0}'>{1}</a></li>",
                row["FileName"],
                row["Description"]
            );
        }

        return html.ToString();
    }
}
