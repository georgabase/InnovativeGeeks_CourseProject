<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmationForm.aspx.cs" Inherits="ConfirmationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
<br/>
<br/> 
<table><tr><td>
<asp:Label ID="LabelCurrentBalance" runat="server" Text=""></asp:Label><br/><br/>
<table><tr><td>
<asp:Label ID="Label1" runat="server" Text="Amount deducted is: "></asp:Label>
</td><td>
<asp:Label ID="Label2" runat="server" Text="Your Current Balance is: "></asp:Label>
</td><td>
<asp:Label ID="Label3" runat="server" Text="Your updated balance is: "></asp:Label>
</td><td>
<asp:Label ID="LabelUpdatedBalance" runat="server" Text=" "></asp:Label><br/><br/>
</td></tr><tr><td></table>
<asp:Label ID="LabelUpdatedBalance" runat="server" Text=" "></asp:Label>
<asp:Button class="button" ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
</td></tr>
</table>
</center>
</asp:Content>
