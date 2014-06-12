<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Apply.aspx.cs" Inherits="Apply" %>

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
            <td>Enter the amount for the grant you want to apply for:  </td>
            <td><asp:TextBox ID="txtGrantAmt" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Why would you like this grant?</td>
            <td><asp:TextBox ID="txtGrantNeedExplain" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Grant Type Key:</td>
            <td><asp:TextBox ID="txtGrantTypeKey" runat="server"></asp:TextBox></td>
        </tr>
    </table>
        <asp:Button ID="btnApplyNow" runat="server" Text="Apply Now" OnClick="btnApplyNow_Click" />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
