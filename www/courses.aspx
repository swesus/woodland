<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/page.master" AutoEventWireup="true" CodeFile="courses.aspx.cs" Inherits="courses" %>
<%@ Register TagPrefix="WL" TagName="CoursesMenu" Src="Controls/CoursesMenu.ascx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="main_content" Runat="Server">

    <WL:CoursesMenu runat="server" />

	<div class="box pdf">
		<h2>Downloads:</h2>
		
        <ul>
            <%= GetListItems() %>
        </ul>
		
		<div class="cb"><!--  --></div>
	</div>
	
</asp:Content>

