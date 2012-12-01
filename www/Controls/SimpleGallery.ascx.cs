using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Controls_SimpleGallery : System.Web.UI.UserControl
{
    public IEnumerable<string> ListItems
    {
        get
        {
            string sql_Select = "SELECT * FROM TBL_WoodlandLife_Files WHERE DisplayInGallery=1 ";
            DataRowCollection rows = JuggleDrumManager.DB.Query(sql_Select).Rows;

            List<string> items = new List<string>();

            foreach (DataRow r in rows)
            {
                items.Add(FormatImageTag(r));
            }

            return items;
        }
    }

    private string FormatImageTag(DataRow row)
    {
        return string.Format(
            "<li><img src='UploadedFiles/{0}' alt='{1}' /><span>{1}</span></li>",
            row["FileName"],
            row["Description"]
        );
    }



}