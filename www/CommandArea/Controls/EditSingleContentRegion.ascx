<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSingleContentRegion.ascx.cs" Inherits="CommandArea_Controls_EditSingleContentRegion" %>

        <p>
            <asp:Label   runat="server" AssociatedControlID="oTextbox" ID="oLabel" />
            <asp:Button ID="oButton"  runat="server" OnClick="oButton_Click" Text="Save" />
            <asp:Literal runat="server" Visible="false" Text="<em>Saved!</em>" ID="oSuccessMessage" />
            <asp:TextBox runat="server" ID="oTextbox" CssClass="text" TextMode="MultiLine" />
        </p>

        <hr style="margin:20px;" />
