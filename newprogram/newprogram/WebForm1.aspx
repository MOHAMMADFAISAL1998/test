<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="newprogram.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <Center><u><h1>LOGIN FOR KNOW SOMETHING ABOUT YOU</h1></u></Center>
        <br />
    <table align="center">
        <tr>
  
                      <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Login ID: "></asp:Label>

            </td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="258px"></asp:TextBox>

            </td>
            <td class="auto-style1">

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter_ID" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
  
                      <td>
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>

            </td>
            <td>

                <asp:TextBox ID="TextBox2" runat="server" Width="256px" TextMode="Password"></asp:TextBox>

            </td>
            <td>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter_Password" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
            
        </tr>
        <tr>
  
            <td colspan ="2">
            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="RESET" OnClick="Button2_Click" />
            
            </td>
            
           
        </tr>


    </table>
  
    </div>
    </form>
    </body>
</html>
