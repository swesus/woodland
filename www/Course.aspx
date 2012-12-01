<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/page.master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="CoursePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" Runat="Server">
    <div class="box">
        
        <h2 runat="server" id="oHeader" />
        
        <asp:Image runat="server" ID="oCourseType" CssClass="CourseType" />
        
        <%--
        <p style="font-family:'Showcard Gothic'; float:right; width:150px; color:#1F6DCD;" runat="server" id="oLocation" />
        <p style="font-family:'Showcard Gothic'; float:left; width:150px; color:#D81688;" runat="server" id="oCourseType_" />
        --%>

        <asp:Literal runat="server" ID="oContent" />
        <div class="cb"><!-- --></div>
    </div>
</asp:Content>

