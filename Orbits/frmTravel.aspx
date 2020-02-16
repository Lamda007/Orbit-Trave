<%@ Page Title="Travel Plan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmTravel.aspx.cs" Inherits="Orbits.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblWeather" runat="server" Text="Weather"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWeather" runat="server" ToolTip="Enter Weather Condition"></asp:TextBox>

            </td>
    
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblOrbit1" runat="server" Text="Orbit 1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOrbit1" runat="server" ToolTip="Enter Speed in MegaMiles"></asp:TextBox>

            </td>
    
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblOrbit2" runat="server" Text="Orbit 2"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOrbit2" runat="server" ToolTip="Enter Speed in MegaMiles"></asp:TextBox>

            </td>
    
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="View Trip" OnClick="btnSave_Click" ToolTip="Click here to View Orbit to use" />

            </td>

        </tr>
    
    </table>

</asp:Content>
