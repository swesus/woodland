using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommandArea_Controls_Login : System.Web.UI.UserControl
{
    protected string ErrorMessage
    {
        set
        {
            oErrorMessage.Visible = true;
            oErrorMessage.InnerHtml = string.Format("<em>{0}</em>", value);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        oErrorMessage.Visible = false;
    }

    protected void oButton_Click(object sender, EventArgs e)
    {
        try
        {
            JuggleDrumManager.Login.LogIn(oUsername.Text, oPassword.Text, "menu.aspx");
        }
        catch (JuggleDrumManager.PublicMessageException ex)
        {
            ErrorMessage = ex.Message;
        }
    }
}
