<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="CommandArea_Controls_Login" %>


    <asp:Panel runat="server" ID="oPanel" CssClass="login form">

        <img src="images/logo.gif" alt="Command Area" />
	
        <p>
            <asp:Label runat="server" Text="Username: " AssociatedControlID="oUsername" />
            <asp:TextBox runat="server" ID="oUsername" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oUsername" ErrorMessage="<br /><em>Please enter a username.</em>" Display="Dynamic" />
        </p>
        
        <p>
            <asp:Label runat="server" Text="Password: " AssociatedControlID="oPassword" />
            <asp:TextBox runat="server" ID="oPassword" TextMode="Password" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oPassword" ErrorMessage="<br /><em>Please enter a password.</em>" Display="Dynamic" />
        </p>

        <p>
            <asp:Button runat="server" Text="Login" OnClick="oButton_Click" ID="oButton" />
        </p>

        <p runat="server" visible="false" id="oErrorMessage" />

	</asp:Panel>
	

