<%@ Page Title="" Language="C#" MasterPageFile="~/Banking.Master" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="atmsystem.customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    body, html {
  height: 100%;
  margin: 0;
}

    ul{
        list-style:none;
    }
.bg {
    text-align:center;
  /* The image used */
  background-image: url('https://securecdn.pymnts.com/wp-content/uploads/2019/11/South-Korea-Open-Banking-1000x600.jpg');
  /* Full height */
  height: 620px; 

  /* Center and scale the image nicely */
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
      padding-top:100px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  class="bg" align="center">
         
            
          <asp:Label ID="lblBank" runat="server" Font-Bold="True"  Font-Size="50px"  Text="ATM Banking"></asp:Label>
      <br />
              <br />
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="login_Click"/>
    <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Register_Click" />
            
         </div>
</asp:Content>
