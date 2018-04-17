<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TransactionHistory.aspx.cs" Inherits="TransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Transactions</h1>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>No Filter</asp:ListItem>
            <asp:ListItem>Customer ID</asp:ListItem>
            <asp:ListItem>Transaction ID</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="searchtxt" runat="server" Width="169px"></asp:TextBox>
        <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="1190px" DataKeyNames="transactionId" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="transactionId" HeaderText="transactionId" SortExpression="transactionId" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                <asp:BoundField DataField="TransactionTime" HeaderText="TransactionTime" SortExpression="TransactionTime" />
                <asp:BoundField DataField="BeneficiaryID" HeaderText="BeneficiaryID" SortExpression="BeneficiaryID" />
                <asp:TemplateField>
                <ItemTemplate>
                  <asp:Button ID="UndoButton" runat="server" CommandName="Undo" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
      Text="Undo" />
  </ItemTemplate> 
</asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [transactions]" InsertCommand="INSERT INTO transactions ( payer, amount, payee) Values (@cust,@amt,@Pay)"  >
            <InsertParameters>
                <asp:FormParameter FormField="payer" Name="cust" />
                <asp:FormParameter FormField="amount" Name="amt" />
                <asp:FormParameter FormField="payee" Name="Pay" />
            </InsertParameters>
            <UpdateParameters>
                <asp:FormParameter FormField="amount" Name="amt" />
                <asp:FormParameter FormField="payer" Name="id" />
                <asp:FormParameter FormField="payee" Name="payeeid" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="BtnHistoryBack" runat="server" OnClick="BtnHistoryBack_Click" Text="Back" Width="94px" />
&nbsp;&nbsp;&nbsp; </p>
    <p>&nbsp; &nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>

