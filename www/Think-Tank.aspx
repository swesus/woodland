<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life" %>
<%@ Register Src="~/Controls/JuggleDrumContentManager/BasicTextContent.ascx" TagPrefix="WL" TagName="BasicTextContent" %>
<%@ Register Src="~/Controls/ThinkTankForm.ascx" TagPrefix="WL" TagName="ThinkTankForm" %>


<asp:Content  ContentPlaceHolderID="main_content" Runat="Server">

	<div class="box">
	 	<h2>Think Tank</h2>
        <WL:BasicTextContent runat="server"  ContentID="ThinkTank" />
        <WL:ThinkTankForm runat="server" />
	</div>

</asp:Content>
