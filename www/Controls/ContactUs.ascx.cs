using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ContactUs : System.Web.UI.UserControl
{
    protected void SubmitButton_Click(Object s, EventArgs e)
    {
        
        if (Page.IsValid)
        {
            SendEmail();
            ContactUsPanel.Visible = false;
            SuccessMessage.Visible = true;
        }
    }



    private void SendEmail()
    {
        string body = string.Format(@"

A message has been left on woodlandlife.co.uk.

From: {0}
Email: {1}
Phone: {2}
Add to mailing list?: {3}

Message:

{4}",

        Name.Text,
        EmailAddress.Text,
        Phone.Text,
        MailingList.SelectedValue,
        Message.Text);

        
        JuggleDrumManager.Email email = new JuggleDrumManager.Email("Contact Us Message", body);
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