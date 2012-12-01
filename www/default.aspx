<%@ Page Title="Woodland Life" Language="C#" MasterPageFile="~/MasterPages/main.master" %>
<%@ Register TagPrefix="WL" TagName="Navigation" Src="Controls/Navigation.ascx" %>
<%@ Register TagPrefix="WL" TagName="HomePageLinks" Src="Controls/HomePageLinks.ascx" %>
<%@ Register TagPrefix="WL" TagName="socialMedia" Src="Controls/socialMedia.ascx" %>

<asp:Content ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" Runat="Server">

	<div id="home_banner">
	    <WL:Navigation runat="server" CssClass="flow" />
		<div class="cb"><!-- --></div>
        <a id="ExeterForestSchool_logo" href="http://www.exeterforestschool.co.uk/">
		    <img src="images/logos/Exeter_Forest_School_Logo.png" alt="Exeter Forest School" />
        </a>
        <div id="forum-advert-wrapper">
            <a id="forum-advert" href="discussion/">
                <span>Our Forum</span>
                <img src="images/default_aspx/forum_screenshot.png" alt="Forum" />
                Join the discussion
            </a>
        </div>
		<img src="images/logos/logo_x2.gif" alt="Woodland Life" id="Img1" />
		<h2>The Business of Bushcraft Survival, Traditional Woodland Crafts and Sustainably Living Off The Land</h2>
	</div><!-- banner -->
    
    <div id="twitter-feed">
        <h2>Twitter</h2>
        <div class="tweets"></div>
        <script src="http://connect.facebook.net/en_US/all.js#xfbml=1"></script>
        <fb:like-box href="http://www.facebook.com/pages/Woodland-Life/166080293427005" width="150" height="150" show_faces="false" stream="false" header="false"></fb:like-box>
        
    </div>


    <%--
    <div id="YouTubeVideo" style="float:left; width:240px; margin:10px;">
        <div >  http://www.youtube.com/custom_player?player_id=FiElnifnIfw&ytsession=SxpY1IL3JJJs6F0ep6xUXUDLEiMOVwl2frzUEWHQaURsAY1chZFovIrlJHDj6hyJXt5ufLJs2ayL_EanS7mRz9r7NWD0QgYb6PcXwQwxRN-spKSGJJyUPyjxjxETvEpzmPuCHIPX_5AcLf4-23jljTvK34_8V4OPUFUMRJ_pQfs24maXCHYI64UqMCnutiJHGOvz8bg-VozbwleYp6oYFcMYEkOGNBQTTCFoZlO4N18UU3xBQ2rdwWLO-G2xOf0Z
            <object>
                <param name="movie" value="http://www.youtube.com/cp/vjVQa1PpcFNptUW7v8_IVy_lrw0USs95f4An3XJS9N4="></param>
                <embed src="http://www.youtube.com/cp/vjVQa1PpcFNptUW7v8_IVy_lrw0USs95f4An3XJS9N4=" 
                    type="application/x-shockwave-flash">
                </embed>
            </object>
        </div>
    
        <object>
			<param name="movie" value="http://www.youtube.com/cp/vjVQa1PpcFNptUW7v8_IVwIbmOfB2gpMMICG_M8x_Vc="></param>
			<embed src="http://www.youtube.com/cp/vjVQa1PpcFNptUW7v8_IVwIbmOfB2gpMMICG_M8x_Vc=" 
				type="application/x-shockwave-flash"></embed>
		</object>
    </div>
    --%>
    
    
    
	<WL:HomePageLinks runat="server" />

</asp:Content>


<asp:Content ContentPlaceHolderID="footer_content" Runat="Server">
		<div id="partners">
			<em>In partnership with</em>
			<a href="http://www.unep.org/billiontreecampaign/"><img src="images/logos/BTC_logo_smaller.gif" alt="The Billion Tree Campaign - Growing Green" /></a>
			<a href="http://www.itcfirstaid.org.uk/"><img src="images/logos/it_logo.jpg" alt="ITC First Aid Ltd" /></a>
			<a href="http://www.outdoor-learning.org/"><img src="images/logos/IOL_logo.jpg" alt="Institute for Outdoor Learning" /></a>
			<a href="http://www.carbonsquash.co.uk/"><img src="images/logos/squash_logo.png" alt="Carbon Squash" /></a>
			<a href="http://www.greenwave.cbd.int/"><img src="images/logos/greenwave_logo.gif" alt="" /></a>
			<a href="http://www.lotc.org.uk/"><img src="images/logos/learning_outside_logo.jpg" alt="" /></a>
		</div>
        
        <WL:socialMedia ID="SocialMedia1" runat="server" />

</asp:Content>
