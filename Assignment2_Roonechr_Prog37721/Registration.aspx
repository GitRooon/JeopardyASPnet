<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Assignment2_Roonechr_Prog37721.Registration" %>

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
        <div>
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
                    <td class="auto-style2">Re-Type Password</td>
                    <td>
                        <asp:TextBox ID="passwordConfTbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name:</td>
                    <td>
                        <asp:TextBox ID="lastNameTbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
        <p>
            <asp:Label ID="AcctCreated" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
