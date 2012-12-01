<%@ Control Language="c#" %>

<script runat="server">
    public string CssClass
    {
        get { return oCssClass.Text; }
        set { oCssClass.Text = value; }
    }
</script>

<%--
<ul class='nav <asp:literal runat="server" ID="oCssClass" />'>
	<li class="nav_gallery"><a href="gallery.aspx"><img src="images/nav/gallery.gif" alt="Picture Gallery" /></a></li>
	<li class="nav_courses"><a href="courses.aspx"><img src="images/nav/Courses.gif" alt="Courses" /></a></li>
	<li class="nav_events" ><a href="events.aspx"><img src="images/nav/Events.gif" alt="Events" /></a></li>
	<li class="nav_thinktank" ><a href="think-tank.aspx"><img src="images/nav/thinktank.gif" alt="Think Tank" /></a></li>
	<li class="nav_who"    ><a href="who_are_we.aspx"><img src="images/nav/whoarewe.gif" alt="Who Are We?" /></a></li>
	<li class="nav_about"  ><a href="mission.aspx"><img src="images/nav/about.gif" alt="About The Business" /></a></li>
	<li class="nav_contact"><a href="contact_us.aspx"><img src="images/nav/Contact.gif" alt="Contact Us" /></a></li>
	<li class="nav_how"    ><a href="how_to_find_us.aspx"><img src="images/nav/Howtofindus.gif" alt="How To Find Us" /></a></li>
</ul>
--%>

<ul class='nav <asp:literal runat="server" ID="oCssClass" />'>
	<li class="nav_gallery"  ><span><a href="gallery.aspx">         Picture Gallery     </a></span></li>
	<li class="nav_courses"  ><span><a href="courses.aspx">         Courses             </a></span></li>
	<li class="nav_events"   ><span><a href="events.aspx">          Events              </a></span></li>
	<li class="nav_thinktank"><span><a href="think-tank.aspx">      Think Tank          </a></span></li>
	<li class="nav_who"      ><span><a href="who_are_we.aspx">      Who Are We?         </a></span></li>
	<li class="nav_about"    ><span><a href="mission.aspx">         About The Business  </a></span></li>
	<li class="nav_contact"  ><span><a href="contact_us.aspx">      Contact Us          </a></span></li>
	<li class="nav_how"      ><span><a href="how_to_find_us.aspx">  How To Find Us      </a></span></li>
</ul>