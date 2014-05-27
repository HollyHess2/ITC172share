<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="loginOrRegister.aspx.cs" Inherits="loginOrRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>User Name:  </td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password:  </td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text="i'm here"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Register</asp:LinkButton></td>
        </tr>

    </table>
</asp:Content>


