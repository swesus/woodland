<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life" %>
<%@ Register Src="~/Controls/JuggleDrumContentManager/BasicTextContent.ascx" TagPrefix="WL" TagName="BasicTextContent" %>


<asp:Content ContentPlaceHolderID="main_content" Runat="server">
	<div class="box">
		<h1>How To Find Us</h1>
        
        <WL:BasicTextContent  runat="server"  ContentID="HowToFindUs" />

	</div>
</asp:Content>
