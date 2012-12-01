<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="CourseEdit.aspx.cs" Inherits="CommandArea_CourseEdit" %>
<%@ Register Src="~/CommandArea/Controls/ImageUploadField.ascx" TagPrefix="JD" TagName="ImageUploadField" %>


<asp:Content ContentPlaceHolderID="navigation_content" Runat="Server">  
</asp:Content>


<asp:Content ContentPlaceHolderID="body_content" Runat="Server">

    <fieldset class="form courseEdit">

        <p>
            <asp:Label runat="server" AssociatedControlID="oTitle" Text="Title" />
            <asp:TextBox runat="server" ID="oTitle" CssClass="text" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oTitle" ErrorMessage="<br /><em>Please enter a title</em>" />
        </p>

        <p>
            <asp:RadioButtonList runat="server" ID="oType" RepeatDirection="Horizontal" RepeatLayout="Flow" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oType" ErrorMessage="<br /><em>Please choose a type</em>" />
        </p>

        <p>
            <asp:RadioButtonList runat="server" ID="oLocations" RepeatDirection="Horizontal" RepeatLayout="Flow" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oLocations" ErrorMessage="<br /><em>Please choose a location</em>" />
        </p>

        <p>
            <asp:Label runat="server" AssociatedControlID="oLength" Text="Length" />
            <asp:TextBox runat="server" ID="oLength" CssClass="text" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oLength" ErrorMessage="<br /><em>Please enter a length (e.g. 2 days)</em>" />
        </p>
    

        <p>
            <asp:Label runat="server" AssociatedControlID="oContentHtml" Text="Content" />
            <br />
            <asp:TextBox runat="server" ID="oContentHtml" TextMode="MultiLine" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="oContentHtml" ErrorMessage="<br /><em>Please enter some content</em>" />
        </p>


        <p>
            <asp:Label runat="server" AssociatedControlID="oPublished" Text="Publish" />
            <asp:CheckBox runat="server" ID="oPublished" Checked="false" />
        </p>

        <p>
            <asp:Button runat="server" OnClick="oButton_Click" Text="Save" />
            <asp:Literal runat="server" Visible="false" Text="<em>Saved!</em>" ID="oSuccessMessage" />
        </p>


    </fieldset>

</asp:Content>

