<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="bobs_class.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


  
    <br />


  
    <asp:Label ID="Label1" runat="server" Text="Please enter user ID"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="UserID_bx" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Idbtn" runat="server" Text="Search" OnClick="Idbtn_Click" Width="80px" />
    <asp:Label ID="srch_lbl" runat="server" Text=""></asp:Label>
    
    
    <div id="mydiv" runat="server" visible="false" >
           <p>
    <asp:Label ID="fnamelbl" runat="server" Text="Please enter First Name"></asp:Label>
    <asp:TextBox ID="fnametxt" runat="server" Height="25px" Width="115px" Wrap="False"></asp:TextBox></p>
                   <p>
    <asp:Label ID="lnamelbl" runat="server" Text="Please enter Last Name"></asp:Label>
    <asp:TextBox ID="lnametxt" runat="server" Height="30px" Width="115px" Wrap="False"></asp:TextBox></p>
                           <p>
    <asp:Label ID="emaillbl" runat="server" Text="Please enter your Email  "></asp:Label>
    <asp:TextBox ID="emailtxt" runat="server" Width="115px" Height="30px" OnTextChanged="emailtxt_TextChanged"></asp:TextBox></p>
                           <p>
    <asp:Label ID="phonelbl" runat="server" Text="Please enter Phone    "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="phonetxt" runat="server" Height="30px" Width="115px" Wrap="False"></asp:TextBox></p>
        <asp:Button ID="submit" runat="server" Text="Update" OnClick="submit_Click" />
    </div>

    <asp:RegularExpressionValidator ID="emailregex" runat="server"     
                                    ErrorMessage="Please enter a email address." 
                                    ControlToValidate="emailtxt"     
                                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
    <br />
    <asp:RegularExpressionValidator ID="phoneregex" runat="server"     
                                    ErrorMessage="please enter a phone number." 
                                    ControlToValidate="phonetxt"     
                                    ValidationExpression="^[0-9]{10}$" />
</asp:Content>
