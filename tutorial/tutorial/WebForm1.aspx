<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tutorial.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: aqua;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Tutorial Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTutorialId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTutorialName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtTutorialDesc" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Published"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPublished" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>

                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />

                    </td>
                </tr>
            </table>



            <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
            <h2>Tutorial Details</h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>
        </div>
    </form>
   
</body>
</html>
