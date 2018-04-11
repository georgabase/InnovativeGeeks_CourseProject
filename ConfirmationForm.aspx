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
<asp:Label ID="LabelUpdatedBalance" runat="server" Text=" "></asp:Label>
</td></tr></table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
<br />
<br />
<br />
<br />
<center>
<table style="width:100%;" > <tr><td style="height: 40px"></td></tr>
<tr><td>
<asp:Label ID="LabelAcknowledgement" runat="server" Text="Acknowledgement"></asp:Label></td></tr>
<tr><td></td></tr><tr><td>
<asp:Button class="button" ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
</td></tr>
</table>
</center>
</asp:Content>
