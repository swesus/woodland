using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ThinkTankForm : System.Web.UI.UserControl
{
    protected void SubmitButton_Click(Object s, EventArgs e)
    {
        if (Page.IsValid)
        {
            SendEmail();
            ThinkTankPanel.Visible = false;
            SuccessMessage.Visible = true;
        }
    }



    private void SendEmail()
    {
        string body = string.Format(@"

Someone wants to sign up to the think-tank mailing list.

From: {0}
Email: {1}
Phone: {2}

Message:

{3}",

        Name.Text,
        EmailAddress.Text,
        Phone.Text,
        Message.Text);

        
        JuggleDrumManager.Email email = new JuggleDrumManager.Email("Think Tank Message", body);
        email.Send();
    }




    public void CustomValidation_Server_EmailPhone(object source, ServerValidateEventArgs args)
    {
        //try
        //{
            // Test that either the phone or the email address has been entered:   
            args.IsValid = !string.IsNullOrEmpty(EmailAddress.Text + Phone.Text);
        //}
        //catch (Exception ex)
        //{
        //    args.IsValid = true;
        //}
    }
}