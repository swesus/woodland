<%@ Page Title="" Language="C#" MasterPageFile="~/CommandArea/CommandArea.master" AutoEventWireup="true" CodeFile="EditContentRegions.aspx.cs" Inherits="CommandArea_EditContentRegions" %>
<%@ Register Src="~/CommandArea/Controls/EditSingleContentRegion.ascx" TagPrefix="WL" TagName="EditSingleContentRegion" %>
<asp:Content  ContentPlaceHolderID="head_content" Runat="Server">
</asp:Content>
<asp:Content  ContentPlaceHolderID="navigation_content" Runat="Server">
</asp:Content>

<asp:Content  ContentPlaceHolderID="body_content" Runat="Server">

    <fieldset class="form editContentRgions">

        <asp:Button runat="server" Text="Save All" OnClick="SaveAll" />
    
        <WL:EditSingleContentRegion runat="server" ContentID="Events"           ID="oEvents"           Label="Events" />
        <WL:EditSingleContentRegion runat="server" ContentID="Mission_Top"      ID="oMission_Top"      Label="Mission Top" />
        <WL:EditSingleContentRegion runat="server" ContentID="Mission_Bottom"   ID="oMission_Bottom"   Label="Mission Bottom" />
        <WL:EditSingleContentRegion runat="server" ContentID="WhoAreWe_Shev"    ID="oWhoAreWe_Shev"    Label="Who Are We : Shev" />
        <WL:EditSingleContentRegion runat="server" ContentID="WhoAreWe_Tom"     ID="oWhoAreWe_Tom"     Label="Who Are We : Tom" />
        <WL:EditSingleContentRegion runat="server" ContentID="WhoAreWe_3"       ID="oWhoAreWe_3"       Label="Who Are We : Third Team Member" />
        <WL:EditSingleContentRegion runat="server" ContentID="ThinkTank"        ID="oThinkTank"        Label="Think Tank" />
        <WL:EditSingleContentRegion runat="server" ContentID="HowToFindUs"      ID="oHowToFindUs"      Label="How To Find Us" />

    </fieldset>       
</asp:Content>

