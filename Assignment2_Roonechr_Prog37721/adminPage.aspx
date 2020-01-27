<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Assignment2_Roonechr_Prog37721.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">UserName: </td>
                <td>
                    <asp:TextBox ID="userNameTbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password: </td>
                <td>
                    <asp:TextBox ID="passwordTbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td>
                    <asp:TextBox ID="lastNameTbox" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <asp:DropDownList ID="userNameList" runat="server" DataSourceID="SqlDataSource1" DataTextField="firstName" DataValueField="firstName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Assignment2ConnectionString %>" SelectCommand="SELECT [firstName] FROM [Users] ORDER BY [firstName]"></asp:SqlDataSource>
            <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update" />
            <asp:Button ID="deleteButton" runat="server" OnClick="deleteButton_Click" Text="Delete" />
            <asp:Button ID="loadButton" runat="server" OnClick="loadButton_Click" Text="Load Data" />
            <asp:Button ID="refreshButton" runat="server" OnClick="refreshButton_Click" Text="Refresh" />
            <asp:Button ID="homeButton" runat="server" OnClick="homeButton_Click" Text="Home" />
        </div>
    </form>
</body>
</html>
