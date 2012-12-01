<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="CommandArea_menu" %>
<%@ Register TagPrefix="WL" TagName="CoursesList" Src="Controls/CoursesList.ascx" %>

<asp:Content ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>


<asp:Content ContentPlaceHolderID="body_content" Runat="Server">
    <h1>Command Area</h1>
    <h2>Menu</h2>
    
    <p style="text-align:center;">
        <a href="EditContentRegions.aspx">Edit fixed pages</a>
        <br />
        <a href="UploadedFiles.aspx">Uploaded files</a>
        <br />
        <a href="EventsEdit.aspx">Events</a>
    </p>

    <WL:CoursesList runat="server" />

    
</asp:Content>

