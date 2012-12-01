<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DateTextBox.ascx.cs" Inherits="CommandArea_Controls_DateTextBox" %>

<div class="DateTextBox">
    <table>
        <tr>
            <th></th>
            <th>Day:</th>
            <th>Month:</th>
            <th>Year:</th>
            <th></th>
            <th>Hour:</th>
            <th>Minute:</th>
        </tr>
        <tr>
            <td>Date:</td>
            <td>
                <asp:TextBox runat="server" ID="oDay"       /> /
            </td>
            <td>
                <asp:TextBox runat="server" ID="oMonth"    /> /
            </td>
            <td>
                <asp:TextBox runat="server" ID="oYear"      /> 
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="oHour"   /> :
            </td>
            <td>
                <asp:TextBox runat="server" ID="oMinute"    />
            </td>
        </tr>
    </table>
    <p runat="server" id="oErrorMessage" visible="false">
        <em style="color:Red;">Please check that the date is valid.</em>
    </p>
</div>
