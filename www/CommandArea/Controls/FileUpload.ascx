<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FileUpload.ascx.cs" Inherits="CommandArea_Controls_FileUpload" %>

<fieldset class="fileUpload">
    <div>
        <strong>
            <asp:Label runat="server" AssociatedControlID="oAspFileUpload" ID="oLabel" Text="Upload new file:" />
        </strong>
    </div>
    <div>
        <asp:FileUpload runat="server" ID="oAspFileUpload" />
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
        <asp:Button runat="server" OnClick="Upload_Click" Text="Upload" />
    </div>
    <p runat="server" id="oMessage" />
</fieldset>
