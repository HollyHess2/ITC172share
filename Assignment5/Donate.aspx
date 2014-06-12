<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Enter amount you want to donate:  </td>
            <td><asp:TextBox ID="txtDonateAmt" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label></tr>
    </table>

        <asp:Button ID="btnDonateNow" runat="server" Text="Donate Now" OnClick="btnDonateNow_Click" />

    </div>
    </form>
</body>
</html>
