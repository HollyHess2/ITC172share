<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>First Name:  </td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Last Name:  </td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                    ErrorMessage="Last Name Required" ControlToValidate="txtLastName" 
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Email:  </td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Email Required" ControlToValidate="txtEmail"
                    CssClass="error"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regExpValEmail" runat="server" 
                    ErrorMessage="Must enter a valid email" ControlToValidate="txtEmail"
                    ValidateRequestMode="Enabled" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    CssClass="error">
                    </asp:RegularExpressionValidator>
            </td>

        </tr>
        <tr>
            <td>Street Address:  </td>
            <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Address Required" ControlToValidate="txtAddress"
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>City:  </td>
            <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="City Required" ControlToValidate="txtCity"
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>State:  </td>
            <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Postal Code:  </td>
            <td><asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Postal Code Required" ControlToValidate="txtPostalCode"
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Home Phone:  </td>
            <td><asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="Home Phone Required" ControlToValidate="txtHomePhone"
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Password:  </td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                    ErrorMessage="Password Required" ControlToValidate="txtPassword"
                    CssClass="error"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Confirm Password:  </td>
            <td><asp:TextBox ID="txtPasswordConfirm" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPasswordConfirm" runat="server" 
                    ErrorMessage="Must Confirm Password" ControlToValidate="txtPasswordConfirm"
                    CssClass="error"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="compareValPasswordConfirm" runat="server" 
                    ErrorMessage="The password must match" ControlToValidate="txtPasswordConfirm"
                    ControlToCompare="txtPassword"
                    CssClass="error"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label></td>
        </tr>

    </table>
</asp:Content>

