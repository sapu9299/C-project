<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="firstform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>webform</title>
   <style>
       #btnsave
       {
           background-color:forestgreen;
         }
       #btnReset{
           background-color:red;
       }
       </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:antiquewhite;width:1000px;height:1000px;text-align:center;padding-top:100px;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="salesman_id:"></asp:Label>
                        </td>
                    <td><asp:TextBox ID="txtSalesmanId" runat="server"></asp:TextBox>
                       </td>
                 </tr>

                
              <tr>
                  <td>
             <asp:Label ID="Label2" runat="server" Text="salesman_name:"></asp:Label>
                      </td>
                  <td>
           <asp:TextBox ID="txtsalesman_name" runat="server"></asp:TextBox>
                      </td>
                  </tr>
            
                <tr>
                    <td>
            <asp:Label ID="Label3" runat="server" Text="city:"></asp:Label>
                        </td>
                    <td>
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
                        </td>
                    </tr>
            
                <tr>
                    <td>
            <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" />
                        </td>
                    </tr>
                </table>
            <hr />
            <asp:Label ID="lblResult" runat="server" Text="result"></asp:Label>
            <hr />
            <h2>Salesman Details</h2>
            <asp:GridView ID="gvSalesmanDetails" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
