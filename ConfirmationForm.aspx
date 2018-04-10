<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmationForm.aspx.cs" Inherits="ConfirmationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
 <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="LabelAcknowledgement" runat="server" Text="Acknowledgement"></asp:Label>
<br />
<br />
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
