<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TransactionHistory.aspx.cs" Inherits="TransactionHistory" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <h1>Application Transactions</h1>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="TransactionTime" HeaderText="TransactionTime" SortExpression="TransactionTime" />
                    <asp:BoundField DataField="BeneficiaryID" HeaderText="BeneficiaryID" SortExpression="BeneficiaryID" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [CustomerId], [Amount], [TransactionTime], [BeneficiaryID] FROM [transactions]"></asp:SqlDataSource>
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="BtnHistoryBack" runat="server" OnClick="BtnHistoryBack_Click" Text="Back" Width="94px" /> &nbsp;&nbsp;&nbsp; </p>
        <p>&nbsp; &nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </asp:Content>