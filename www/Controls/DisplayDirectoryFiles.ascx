<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DisplayDirectoryFiles.ascx.cs" Inherits="Controls_DisplayDirectoryFiles" %>

<ul>
    <% foreach (string file in this.FileNames)
       { %>
        <% = FormatListItem(file)%>
    <%} %>

    <!--
    <li><a href="downloads/company_code_of_practice.pdf">Company Code of Practice</a></li>
    <li><a href="downloads/company_complaints_procedure.pdf">Company Complaints Procedure</a></li>
    <li><a href="downloads/complaints_form.pdf">Company Complaints Form</a></li>
    <li><a href="downloads/woodland_life_volunteer_policy.pdf">Woodland Life Volunteer Policy</a></li>
    <li><a href="downloads/equal_opportunities_policy.pdf">Equal Opportunities Policy</a></li>
    <li><a href="downloads/abuse_report_form.pdf">Young and Vulnerable People Abuse Report Form</a></li> -->
</ul>
