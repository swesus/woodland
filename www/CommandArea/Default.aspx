<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CommandArea_Default" %>
<%@ Register TagPrefix="WL" TagName="Login" Src="Controls/Login.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>







<asp:Content ID="Content2" ContentPlaceHolderID="body_content" Runat="Server">
        

        
        <WL:Login runat="server" />

</asp:Content>

