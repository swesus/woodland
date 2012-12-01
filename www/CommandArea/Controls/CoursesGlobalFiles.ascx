<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CoursesGlobalFiles.ascx.cs" Inherits="CommandArea_Controls_CoursesGlobalFiles" %>
<%@ Register TagPrefix="WL" TagName="FileUpload" Src="FileUpload.ascx" %>

<WL:FileUpload runat="server" ID="oFileUpload" PageName="CoursesGlobalFiles" />
<br />
<asp:TextBox runat="server" ID="oFileUploadText" />
<br />
<asp:Button ID="Button1" runat="server" />
<br />
