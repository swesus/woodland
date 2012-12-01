<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSingleEvent.ascx.cs" Inherits="CommandArea_Controls_EditSingleEvent" %>
<%@ Register Src="~/CommandArea/Controls/DateTextBox.ascx" TagPrefix="WL" TagName="DateTextBox" %>

<p>
    <asp:HiddenField runat="server" ID="oEventId" />

    <div runat="server" id="oMessageInThePast" style="color:Orange; font-weight:bold;" Visible="false" >
        This event has already happened.
    </div>


    Title:
    <asp:TextBox runat="server" ID="oTitle" CssClass="text" />
    <br />

    <WL:DateTextBox runat="server" ID="oDate" />
    <br />

    Detail:
    <asp:TextBox runat="server" ID="oContentHtml" CssClass="text" TextMode="MultiLine" 
        style="height:200px;"
    />
    <br />
    
    <asp:Button  runat="server" ID="oDelete"  OnClick="oDelete_Click" Text="Delete" style="float:right;" />
    <asp:Button  runat="server" ID="oButton"  OnClick="oButton_Click" Text="Save" />
    <asp:Literal runat="server" Visible="false" Text="<em>Saved!</em>" ID="oSuccessMessage" />
</p>

<hr style="margin:20px;" />
