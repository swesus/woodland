<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThinkTankForm.ascx.cs" Inherits="Controls_ThinkTankForm" %>

<asp:Panel runat="server" ID="ThinkTankPanel" CssClass="ThinkTankPanel">

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" 
            ErrorMessage="<em>Please enter your name</em><br/>" 
            ControlToValidate="Name" 
            MaxLength="100" 
            Display="Dynamic"  
            EnableClientScript="false"
            />
            
    <asp:CustomValidator ID="CustomValidator1" 
           runat="server"
           OnServerValidate="CustomValidation_Server_EmailPhone"
           Display="Dynamic"
           ErrorMessage="<em>Please enter either an email address or a phone number so we can contact you.</em><br/>"  />

    <div class="firstRow">
            
        <!-- NAME -->
        <p>
            <asp:Label ID="Label1" runat="server" AssociatedControlID="Name" Text="Name:" />
	        <asp:TextBox runat="server" ID="Name" CssClass="text" />
	    </p>

        <!-- EMAIL ADDRESS -->
        <p>
            <asp:Label ID="Label2" runat="server" AssociatedControlID="EmailAddress" Text="E-Mail:" />
            <asp:TextBox runat="server" ID="EmailAddress" MaxLength="100" CssClass="text" />
	    </p>

        <!-- PHONE -->
        <p>
            <asp:Label ID="Label3" runat="server" AssociatedControlID="Phone" Text="Phone:" />
            <asp:TextBox runat="server" ID="Phone" MaxLength="100" CssClass="text" />
	    </p>

        <div class="cb"><!-- --></div>
    </div>

    <p>
        <asp:Label ID="Label4" runat="server" AssociatedControlID="Message" Text="Your message:" />
        <br />
	    <asp:TextBox runat="server" ID="Message" cols="40" rows="10" TextMode="multiline" />
	</p>

    <asp:Button runat="server" ID="SubmitButton" Text="Send Message" CssClass="submit" OnClick="SubmitButton_Click" />
            
</asp:Panel>

<p runat="server" id="SuccessMessage" visible="false" class="text" style="color:Red;text-align:center;"><em>Thank-you for signing up to the mailing list.</em></p>
