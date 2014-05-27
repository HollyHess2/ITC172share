<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" MasterPageFile="~/MasterPage.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="txtWelcome" runat="server" Text="Welcome!"></asp:Label>
            <br />
            <br />

            <asp:Label ID="lblPrevDonate" runat="server" Text="The following lists your previous donations:"></asp:Label>
            <br />

            <asp:Table ID="tblPrevDonate" runat="server"></asp:Table>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DonationKey" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="DonationKey" HeaderText="DonationKey" InsertVisible="False" ReadOnly="True" SortExpression="DonationKey" />
                    <asp:BoundField DataField="DonationDate" HeaderText="DonationDate" SortExpression="DonationDate" />
                    <asp:BoundField DataField="DonationAmount" HeaderText="DonationAmount" SortExpression="DonationAmount" />
                    <asp:BoundField DataField="PersonKey" HeaderText="PersonKey" SortExpression="PersonKey" />
                    <asp:BoundField DataField="EmployeeKey" HeaderText="EmployeeKey" SortExpression="EmployeeKey" />
                    <asp:BoundField DataField="DonationConfirmDate" HeaderText="DonationConfirmDate" SortExpression="DonationConfirmDate" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CommunityAssistConnectionString2 %>" SelectCommand="SELECT * FROM [Donation] WHERE ([PersonKey] = @PersonKey)">
                <SelectParameters>
                    <asp:SessionParameter Name="PersonKey" SessionField="person" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />

            <asp:Label ID="lblDonateNow" runat="server" Text="Would you like to make a donation today?"></asp:Label>
            &nbsp;
            &nbsp;
            &nbsp;
            <asp:Button ID="btnDonateNow" runat="server" Text="Donate Now!" />
</asp:Content>