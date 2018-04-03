<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DepositForm.aspx.cs" Inherits="DepositForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <h1>Enter Bank Details:</h1><br/>
    <table>
        <tr>
           <td>
             <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxName" runat="server"></asp:TextBox><br/>
           </td>
        </tr>


        <tr>
           <td>
             <asp:Label ID="Label2" runat="server" Text="Bank Account"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxCcNo" runat="server"></asp:TextBox><br/>
           </td>
        </tr>




        <tr>
           <td>
              <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
           </td>
           <td>
                 <asp:TextBox ID="TxtBoxAmount" runat="server"></asp:TextBox>
           </td>
            
        </tr>


        <tr>
            <asp:Label ID="LabelStatus" runat="server"></asp:Label>
        </tr>
         </table>
     <asp:Label ID="Label6" runat="server"></asp:Label>
     <br/>
        
           <asp:Button ID="BtnNext" class="button" runat="server" Text="Next" Height="32px" OnClick="BtnConfirmDeposit_Click" Width="83px" />
        


        
           <asp:Button ID="BtnBack" CssClass="button" runat="server" Height="30px" OnClick="BtnBack_Click" Text="Back" Width="74px" />
       

        
</asp:Content>


