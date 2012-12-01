<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SingleImage.ascx.cs" Inherits="SingleImage" %>


<asp:Image runat="server" ID="DisplayImage" />

<asp:Panel runat="server" ID="EditPanel" visible="false" DefaultButton="SubmitButton">

	<asp:FileUpLoad runat="server" ID="FileUpLoad" />

	<asp:TextBox runat="server" ID="AltText" />

	<asp:Button runat="server" ID="SubmitButton" Text="Upload Image" OnClick="SubmitButton_Click" />

	<asp:Literal runat="server" ID="UserMessage" />

</asp:Panel>
