<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        #Reset1 {
            height: 41px;
            width: 89px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <table align="Center" style="height: 299px; width: 628px">
        <tr>
            <td colspan ="2" align="Center" style="text-decoration: underline; font-style: normal; font-size: large; background-color: #00FFFF; font-weight: bold;">Registration Form</td>
        </tr>
        <tr>
            <td style="background-color: #00FF00">UserName:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td style="background-color: #00FF00">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Enter User Name*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="background-color: #00FF00">Education:</td>
            <td style="background-color: #00FF00">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter Password*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="background-color: #00FF00">Location:</td>
            <td class="auto-style1" style="background-color: #00FF00">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Enter Email ID*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan ="2" style="background-color: #00FF00">
                &nbsp; &nbsp;
                <asp:Button ID="Button1" runat="server" Height="41px" Text="InsertIntoDatabase" Width="151px" BackColor="Yellow" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;
                <input id="Reset1" style="background-color: #FFFF00" type="reset" value="reset" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="43px" Text="DataGridView" Width="142px" BackColor="Yellow" OnClick="Button2_Click" />
            </td>
            <td></td>
            
        </tr>
    </table>
        <br />
    </form>
</body>
</html>
