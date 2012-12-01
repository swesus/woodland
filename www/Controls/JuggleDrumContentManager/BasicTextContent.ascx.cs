using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Controls_JuggleDrumContentManager_BasicTextContent : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string contentID = JuggleDrumManager.SqlInject.String(this.ContentID);

            string sql_Select = string.Format(
                "SELECT Content1 FROM TBL_WoodlandLife_Content WHERE ContentID={0};",
                contentID
            );

            DataTable table = JuggleDrumManager.DB.Query(sql_Select);
            oLiteral.Text = table.Rows[0]["Content1"].ToString();
        }
    }

    public string ContentID { get; set; }
}
