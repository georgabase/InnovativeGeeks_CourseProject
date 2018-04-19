<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <%--    &nbsp;<div class="jumbotron">
       <%-- <h1>EWALLET</h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
  </div>
    
    &nbsp;--%>
            
        <div class="jumbotron">
        <ul>
            <li style="width:800px"><asp:Button ID="BtnTransfer"   Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/transfer.png'); background-size:cover; cursor:hand;" Width="200px" Height="200px" runat="server" Text="Transfer " OnClick="BtnTransfer_Click" /></li>
            <li style="width:800px"><asp:Button ID="BtnDeposit" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/deposit.png'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Deposit " OnClick="BtnDeposit_Click" /></li>
            <li style="width:800px"><asp:Button ID="BtnWithdraw" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/withdraw.png'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" /></li>
            <!--<li style="width:800px"><asp:Button ID="BtnHistory" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/history.png'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="History" OnClick="BtnHistory_Click" /></li>-->
            <!--<li style="width:800px"><asp:Button ID="BtnEdit" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/history.png'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Edit" OnClick="BtnEdit_Click" /></li>-->
  
            </ul>
            <center>
            <asp:Label ID="msg" ForeColor="Red" runat="server" />
                </center>
    </div>

</asp:Content>
