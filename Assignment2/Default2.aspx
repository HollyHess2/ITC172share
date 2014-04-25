<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Confirmation</h2>
    <p>Please make sure the following data is correct and then submit</p>
     <table>
        <tr>
            <td>First Name:</td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Street Address:</td>
            <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>City:</td>
            <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>State:</td>
            <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Postal Code:</td>
            <td><asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Home Phone:</td>
            <td><asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSumbit" runat="server" Text="Submit" 
                OnClick="btnSumbit_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text="" CssClass="error">
                </asp:Label></td>
            <td>&nbsp;</td>
        </tr>
     
    </table>
</asp:Content>

