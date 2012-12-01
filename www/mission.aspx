<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life" %>
<%@ Register Src="~/Controls/JuggleDrumContentManager/BasicTextContent.ascx" TagPrefix="WL" TagName="BasicTextContent" %>

<script runat="server">
/*
    protected void Page_Load(object sender,EventArgs e)
    {
        string sql = "DELETE FROM TBL_WoodlandLife_Files";
        JuggleDrumManager.DB.NonQuery(sql);
        Response.Write("DONE");
    }
    */
</script>



<asp:Content ID="Content2" ContentPlaceHolderID="main_content" Runat="Server">

	<div id="jSlide_top" class="box">
		<h1>Mission Statement</h1>
        <WL:BasicTextContent runat="server"  ContentID="Mission_Top" />
	</div><!-- jSlide_top -->

	<img src="images/mission_aspx/mission_deer.jpg" alt="deer" id="jSlide_image" />

	<div id="jSlide_bottom" class="box">
		<h1>Vision Statement</h1>
        <WL:BasicTextContent runat="server"  ContentID="Mission_Bottom" />
	</div><!-- jSlide_bottom -->


</asp:Content>

