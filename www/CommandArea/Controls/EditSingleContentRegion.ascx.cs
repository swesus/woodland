using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CommandArea_Controls_EditSingleContentRegion : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        oSuccessMessage.Visible = false;

        if (!Page.IsPostBack)
        {
            string contentID = JuggleDrumManager.SqlInject.String(this.ContentID);

            string sql_Select = string.Format(
                "SELECT Content1 FROM TBL_WoodlandLife_Content WHERE ContentID={0};",
                contentID
            );

            DataTable table = JuggleDrumManager.DB.Query(sql_Select);
            oTextbox.Text = table.Rows[0]["Content1"].ToString();
        }
    }

    public string ContentID { get; set; }
    public string Label { get { return oLabel.Text; } set { oLabel.Text = value; } }

    protected void oButton_Click(object sender, EventArgs e)
    {
        Save();
        this.Focus();
    }

    public void Save()
    {
        string newContent = JuggleDrumManager.SqlInject.String(oTextbox.Text);
        string contentID = JuggleDrumManager.SqlInject.String(this.ContentID);

        string sql_Update = string.Format(
            "UPDATE TBL_WoodlandLife_Content SET Content1={0} WHERE ContentID={1};",
            newContent,
            contentID
        );

        JuggleDrumManager.DB.NonQuery(sql_Update);

        oSuccessMessage.Visible = true;
    }

    public override void Focus()
    {
        base.Focus();
        oTextbox.Focus();
    }
}
