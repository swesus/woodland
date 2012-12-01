<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SimpleGallery.ascx.cs" Inherits="Controls_SimpleGallery" %>

<ul class="SimpleGallery">
    <%foreach( string li in this.ListItems) { %>
    <%= li %>
    <%} %>
</ul>