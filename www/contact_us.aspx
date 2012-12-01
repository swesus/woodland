<%@ Page Language="C#" MasterPageFile="~/MasterPages/page.master" Title="Woodland Life" %>
<%@ Register TagPrefix="WL" TagName="ContactUsForm" Src="Controls/ContactUs.ascx" %>


<asp:Content  ContentPlaceHolderID="main_content" Runat="Server">

	<div class="box form">
		<WL:ContactUsForm runat="server" />
	</div>



	<div class="box alternative">


		<p>Alternatively, <a href="discussion">join in with our forum</a>, or contact us directly using any of the methods below:</p>

		<h6>General Enquiries:</h6>
		<p>info@woodlandlife.co.<!-- no spam -->uk</p>

        <p>
            Woodland Life<br />
            Moyses Lane<br />
            Okehampton<br />
            EX20 1JT
        </p>

		<h6>Tom Lowday:</h6>
		<p>
			+44 7773 545136
			<br />
			Tom_Lowday@woodlandlife.co.<!-- no spam -->uk
		</p>

		<h6>Shevek Pring:</h6>
		<p>
			+44 7863 339715
			<br />
			Shevek_Pring@woodlandlife.co.<!-- no spam -->uk
		</p>
	</div>

	<div class="cb"><!-- --></div>

</asp:Content>





