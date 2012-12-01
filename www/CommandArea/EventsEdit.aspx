<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="EventsEdit.aspx.cs" Inherits="CommandArea_EventsEdit" %>
<%@ Reference Control="~/CommandArea/Controls/EditSingleEvent.ascx"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="navigation_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body_content" Runat="Server">

    <div style="width:600px;margin:0 auto;">
        <p style="font-weight:bold;">New event:</p>

        <asp:PlaceHolder runat="server" ID="oEventsListPlaceHolder" />
    </div>

</asp:Content>

