<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactUs.ascx.cs" Inherits="Controls_ContactUs" %>

<asp:Panel runat="server" ID="ContactUsPanel">

	<p class="text">If you would like more information send us your e-mail address and query and we will get back to you as soon as possible:</p>

    <!-- NAME -->
    <p>
        <asp:Label runat="server" AssociatedControlID="Name" Text="Name:" />
	    <asp:TextBox runat="server" ID="Name" CssClass="text" />
        <asp:RequiredFieldValidator 
            runat="server" 
            ErrorMessage="<br /><em>Please enter your name</em>" 
            ControlToValidate="Name" 
            MaxLength="100" 
            Display="Dynamic" />
	</p>

    <!-- EMAIL ADDRESS -->
    <p>
        <asp:Label runat="server" AssociatedControlID="EmailAddress" Text="E-Mail:" />
        <asp:TextBox runat="server" ID="EmailAddress" MaxLength="100" CssClass="text" />
        <asp:RegularExpressionValidator 
            runat="server" 
            ValidationExpression="^.+@.+\..+$" 
            ErrorMessage="<br /><em>Please enter a valid email address</em>" 
            ControlToValidate="EmailAddress" 
            Display="Dynamic" />
	</p>

    <!-- PHONE -->
    <p>
        <asp:Label runat="server" AssociatedControlID="Phone" Text="Phone:" />
        <asp:TextBox runat="server" ID="Phone" MaxLength="100" CssClass="text" />
        <asp:CustomValidator 
           runat="server"
           OnServerValidate="CustomValidation_Server_EmailPhone"
           Display="Dynamic"
           ErrorMessage="<br /><em>Please enter either an email address or a phone number so we can contact you.</em>"  />
	</p>
    
    <p>
        <asp:Label ID="Label2" runat="server" AssociatedControlID="Message" Text="Your message:" />
	    <asp:TextBox runat="server" ID="Message" cols="40" rows="20" TextMode="multiline" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" 
            ErrorMessage="<br /><em>Please enter a message</em>" 
            ControlToValidate="Message" 
            Display="Dynamic"  />
	</p>

	<p class="text">Would you like us to put you on our mailing list to recieve updates on courses and products?</p>

    <p class="radio">
	    <asp:RadioButtonList runat="server" ID="MailingList" RepeatDirection="Horizontal" RepeatLayout="Flow" >
	       <asp:ListItem>Yes</asp:ListItem>
	       <asp:ListItem selected="true">No</asp:ListItem>
	    </asp:RadioButtonList>
    </p>

    <asp:Button runat="server" ID="SubmitButton" Text="Send Message" CssClass="submit" OnClick="SubmitButton_Click" />

</asp:Panel>

<p runat="server" id="SuccessMessage" visible="false" class="text"><em>Thank-you.  We will get back to you shortly.</em></p>
