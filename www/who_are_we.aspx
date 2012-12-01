<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life" %>
<%@ Register Src="~/Controls/JuggleDrumContentManager/BasicTextContent.ascx" TagPrefix="WL" TagName="BasicTextContent" %>

<asp:Content ContentPlaceHolderID="main_content" Runat="Server">

	<div class="box" id="profile_shevek">
	 	<h2>Shevek Pring:</h2>
        <img src="images/ShevTom/profile_shevek_pring.jpg" alt="Shevek" />
        <WL:BasicTextContent runat="server"  ContentID="WhoAreWe_Shev" />
	</div>

	<div class="box" id="profile_tom">
	 	<h2>Tom Lowday:</h2>
        <img src="images/ShevTom/profile_tom_lowday.jpg" alt="Tom" />
        <WL:BasicTextContent runat="server"  ContentID="WhoAreWe_Tom" />
	</div>

	<div class="box" id="profile_3">
        <WL:BasicTextContent runat="server"  ContentID="WhoAreWe_3" />
	</div>

</asp:Content>
