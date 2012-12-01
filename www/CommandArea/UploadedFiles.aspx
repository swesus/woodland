<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="UploadedFiles.aspx.cs" Inherits="CommandArea_UploadedFiles" %>
<%@ Register Src="~/CommandArea/Controls/FileUpload.ascx" TagPrefix="WL" TagName="FileUpload" %>
<%@ Register Src="~/CommandArea/Controls/EditUploadedFileInfo.ascx" TagPrefix="WL" TagName="EditUploadedFileInfo" %>
<%@ Reference Control="~/CommandArea/Controls/EditUploadedFileInfo.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="navigation_content" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body_content" Runat="Server">


    <div>
        <h1>Uploaded Files</h1>
        <h2 style="text-align:left;">The rules:</h2>
        <ol>
            <li>Click browse and choose your file.</li>
            <li>Images can be either .JPG or .GIF and will be resized automagically if they are too large.</li>
            <li>You can tick either of the tick boxes to make the file appear on either the gallery or at the bottom of the courses page</li>
            <li>To get the file onto other pages you can copy and paste the line of code into any of the other editers. (This is probably easier with multiple windows open.)</li>
            <li>Images can have either class='left' or class='right' to float the image to either side.</li>
            <li>I haven't tested it all that much so always check on the real page to make sure it looks ok, whenever you change anything. (Again multiple windows are your friend.)</li>
            <li>Any problems, let me know!</li>
        </ol>

    </div>


    <WL:FileUpload ID="FileUpload1" runat="server" />

    <asp:PlaceHolder runat="server" ID="oFileInfoPlaceHolder" />

</asp:Content>

