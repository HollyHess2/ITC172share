<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome!  Would you like to donate or apply for a grant?</h1>
        <asp:Button ID="btnDonate" runat="server" Text="Donate" OnClick="btnDonate_Click" />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
    </div>
    </form>
</body>
</html>
