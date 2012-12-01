<%@ Page Title="Woodland Life" Language="C#" MasterPageFile="~/MasterPages/page.master" AutoEventWireup="true" CodeFile="events.aspx.cs" Inherits="Events" %>
<%@ Register Src="~/Controls/JuggleDrumContentManager/BasicTextContent.ascx" TagPrefix="WL" TagName="BasicTextContent" %>
<%@ Register Src="~/Controls/DisplayEvents.ascx" TagPrefix="WL" TagName="DisplayEvents" %>

<asp:Content  ContentPlaceHolderID="main_content" Runat="Server">
	
	<div class="box">
		<h2 runat="server" id="oHeader">Events</h2>
        <WL:BasicTextContent  runat="server"  ContentID="Events" />

        <WL:DisplayEvents    runat="server"  />
        
        <div runat="server" id="oMessagePrevious" visible="false">
            <hr />
            <p>
                Why not take a look though some of our
                <asp:HyperLink  runat="server" NavigateUrl="~/events.aspx?Previous=show" Text="past events" style="color:#18612a;font-weight:bold;" />?
            </p>
        </div>

	</div>

</asp:Content>

