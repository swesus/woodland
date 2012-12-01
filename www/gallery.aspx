<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life"  %>
<%@ Register TagPrefix="WL" TagName="SimpleGallery" Src="~/Controls/SimpleGallery.ascx" %>

<asp:Content ContentPlaceHolderID="main_content" Runat="Server">

<%--  
<ul id="pikame">	
	<li><img src='images/gallery/tom_course_2.jpg' alt='Tom at the shelter' /><span>Tom at the shelter</span></li>
	<li><img src='images/gallery/shev_rockpool_l.jpg' alt='Shevek at a rock pool' /><span>Shevek at a rock pool</span></li>
	<li><img src='images/gallery/grass_snake_2_l.jpg' alt='A grasssnake' /><span>A grasssnake</span></li>
	<li><img src='images/gallery/tom_and_shev_l.jpg' alt='Tom and Shevek at the beach' /><span>Tom and Shevek at the beach</span></li>
	<li><img src='images/gallery/tom_course_3.jpg' alt='Tom at the campfire' /><span>Tom at the campfire</span></li>
	<li><img src='images/gallery/buttercups.jpg' alt='Buttercups' /><span>Buttercups</span></li>
	<li><img src='images/gallery/grass_snake_4.jpg' alt='A grasssnake' /><span>A grasssnake</span></li>
	<li><img src='images/gallery/group_fire.jpg' alt='Group fire' /><span>Group fire</span></li>
	<li><img src='images/gallery/naomi_course_1.jpg' alt='Naomi' /><span>Naomi</span></li>
</ul>
--%>

<WL:SimpleGallery runat="server" />


</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="head_content" Runat="Server">
<%-- 
	<link rel="stylesheet" type="text/css"  href="style/PikaChoose.css" />
    --%>
</asp:Content>
