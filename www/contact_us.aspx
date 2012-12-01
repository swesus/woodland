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
			72 High St<br />
			Halberton<br />
			Devon<br />
			EX16 7AG
        </p>

		<h6>Tom Lowday:</h6>
		<p>
			07773 545136
			<br />
			Tom_Lowday@woodlandlife.co.<!-- no spam -->uk
		</p>

		<h6>Shevek Pring:</h6>
		<p>
			07863 339715
			<br />
			Shevek_Pring@woodlandlife.co.<!-- no spam -->uk
		</p>

		<h6>Chris White:</h6>
		<p>
			07878 642169
			<br />
			info@exeterforestschool.co.<!-- no spam -->uk
		</p>
	</div>

	<div class="cb"><!-- --></div>

</asp:Content>





