<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="navigation_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body_content" Runat="Server">


    <div style="width:500px;margin:300px auto;">
        
        <asp:Login runat="server" DestinationPageUrl="~/CommandArea/menu.aspx" />

    </div>
	


</asp:Content>

