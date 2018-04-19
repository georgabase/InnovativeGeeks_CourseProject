<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>This is the mobile wallet about page</h3>
    <hr />
    <p>This is a COMP313 project for an online mobile wallet.</p>
    <a>Mobile wallet can:</a>
    <ul>
        <li>Deposit Money</li>
        <li>Withdraw Money</li>
        <li>Transfer money between accounts</li>
    </ul>
    <p>
        Make sure to <a href="Register.aspx">create an account</a> to get started!
    </p>
</asp:Content>
