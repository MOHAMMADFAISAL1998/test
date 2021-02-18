<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <table align="Center">
       <tr>
           <td><b>First Number: </b></td>
           <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td><b>Second Number: </b></td>
           <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td colspan="2" align="Center">
               <asp:Button ID="Button1" runat="server" Text="SUM" OnClick="Button1_Click" /></td>
       </tr>
       
       <tr>
           <td><b>Result: </b></td>
           <td>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           </td>
       </tr>
   </table>
    </form>
</body>
</html>
