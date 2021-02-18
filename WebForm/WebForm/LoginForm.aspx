<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Submit1 {
            height: 27px;
            width: 84px;
        }
        #Reset1 {
            height: 29px;
            width: 89px;
        }
        .auto-style1 {
            width: 136px;
        }
        .auto-style2 {
            height: 55px;
        }
        .auto-style3 {
            width: 136px;
            height: 55px;
        }
        .auto-style4 {
            height: 55px;
            width: 248px;
        }
        .auto-style5 {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1061px; height: 319px">
    <table align="Center" style="height: 285px; width: 578px">
        <tr>
            <td colspan="2" align="Center" style="background-color: #FF00FF; font-size: large; text-decoration: underline;">Registration</td>
        </tr>
        <tr>
            <td style="background-color: #00FFFF" class="auto-style2">User's ID:</td>
            <td style="background-color: #00FFFF" class="auto-style4">
                <asp:TextBox ID="TextBox1" runat="server" Width="222px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Enter User's ID*" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="background-color: #00FFFF">Password:</td>
            <td style="background-color: #00FFFF" class="auto-style5">
                <asp:TextBox ID="TextBox2" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter Password*" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: #FF99CC">&nbsp;<asp:Button ID="Button2" runat="server" BackColor="Yellow" Text="EnterOnDataBase" Width="149px" OnClick="Button2_Click1" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Reset1" style="background-color: #FFFF00" type="reset" value="Reset" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="Yellow" Height="31px" OnClick="Button1_Click" Text="DataGridView" Width="116px" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
