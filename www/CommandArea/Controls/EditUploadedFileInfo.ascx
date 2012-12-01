<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditUploadedFileInfo.ascx.cs" Inherits="CommandArea_Controls_EditUploadedFileInfo" %>

<fieldset class="fileUpload">
    <div>
        <strong>
            <asp:HiddenField runat="server" ID="oFileId" />
            <asp:Label runat="server" ID="oLabel" />
        </strong>
    </div>
    <div runat="server" id="oImageRow" visible="false">
        <asp:Image runat="server" ID="oImage" />
    </div>
    <div>
        Copy and paste onto other pages:<br />
        <asp:TextBox runat="server" ID="oHtmlOutput" />
    </div>
    <div>
        <asp:Label runat="server" AssociatedControlID="oDescription" Text="Description:" />
        <asp:TextBox runat="server" ID="oDescription" />
    </div>
    <div>
        <asp:Label runat="server" AssociatedControlID="oDisplayInGallery" Text="Display In Gallery:" />
        <asp:CheckBox runat="server" ID="oDisplayInGallery" />
    </div>
    <div>
        <asp:Label runat="server" AssociatedControlID="oDisplayOnCoursesPage" Text="Display On Courses Page:" />
        <asp:CheckBox runat="server" ID="oDisplayOnCoursesPage" />
    </div>
    <div>
        <asp:Button runat="server" OnClick="Save_Click" Text="Save changes" />
    </div>
    <p runat="server" id="oMessage" />
</fieldset>
