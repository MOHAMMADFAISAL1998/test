<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="validate.Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 156px;
        }
        .auto-style2 {
            width: 247px;
        }
        .auto-style3 {
            width: 156px;
            height: 34px;
        }
        .auto-style4 {
            width: 247px;
            height: 34px;
        }
        .auto-style5 {
            height: 34px;
        }
        .auto-style6 {
            width: 156px;
            height: 48px;
        }
        .auto-style7 {
            width: 247px;
            height: 48px;
        }
        .auto-style8 {
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <u>&#60; Back</u> 
    <table align="center">
        <tr>
          <td colspan="2" align="Center" style="background-color: #FFFF66; border: medium solid #FF9900"><h1>REGISTRATION</h1></td>
        </tr>
        <tr>
            <td class="auto-style1" style="background-color: #CC99FF; border: medium inset #9900CC">Name:</td>
            <td class="auto-style2" style="background-color: #FFCCCC; margin-left: 120px;">
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="301px"></asp:TextBox>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Please Enter  Name*" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CC99FF; border: medium inset #9900CC">Password:</td>
            <td class="auto-style4" style="background-color: #FFCCCC">
                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Width="301px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ControlToValidate="TextBox2" ErrorMessage="*Please Enter Password*"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style1" style="background-color: #CC99FF; border: medium inset #9900CC">Confirm Password:</td>
            <td class="auto-style2" style="background-color: #FFCCCC">
                <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 1px" Width="301px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*Please Enter  Confirm Password*" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*Password does not Match*" ForeColor="#FF6600" ControlToCompare="TextBox2" ControlToValidate="TextBox3"></asp:CompareValidator>
            </td>
            <td>
                &nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="auto-style1" style="background-color: #CC99FF; border: medium inset #9900CC">City:</td>
            <td class="auto-style2" style="background-color: #FFCCCC">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" style="margin-left: 0px" Width="307px">
                    <asp:ListItem> [ Default ]</asp:ListItem>
                    <asp:ListItem>Ahmadabad</asp:ListItem>
                    <asp:ListItem>Aligarh</asp:ListItem>
                    <asp:ListItem>Allahabad</asp:ListItem>
                    <asp:ListItem>Azamgar</asp:ListItem>
                    <asp:ListItem>Agra</asp:ListItem>
                    <asp:ListItem>Bangalore</asp:ListItem>
                    <asp:ListItem>Bareilly</asp:ListItem>
                    <asp:ListItem>Baroda</asp:ListItem>
                    <asp:ListItem> Bhopal</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Ghaziabad</asp:ListItem>
                    <asp:ListItem>Greated Noida</asp:ListItem>
                    <asp:ListItem>Gurgaon</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Jaipur</asp:ListItem>
                    <asp:ListItem>Jammu</asp:ListItem>
                    <asp:ListItem>Kanpur</asp:ListItem>
                    <asp:ListItem>Kolkata</asp:ListItem>
                    <asp:ListItem>Lucknow</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Noida</asp:ListItem>
                    <asp:ListItem>Pune</asp:ListItem>
                    <asp:ListItem>Patna</asp:ListItem>
                    <asp:ListItem>Raipur</asp:ListItem>
                    <asp:ListItem>Varanasi</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Please Select City*" ForeColor="Red" ControlToValidate="DropDownList1" InitialValue=" [ Default ]"></asp:RequiredFieldValidator>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style1" style="background-color: #CC99FF; border: medium inset #9900CC">Gender:</td>
            <td style="background-color: #FFCCCC" class="auto-style2">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName ="a" />
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName ="a" />
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td></td>
        </tr>
        <tr>
             <td class="auto-style1" style="background-color: #CC99FF; border: medium inset #9900CC">Date of Birth: </td>
            <td class="auto-style2" style="background-color: #FFCCCC">
                <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 0px" Width="260px" Height="25px" TextMode="Date"></asp:TextBox>
             </td>
        <td>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" style="background-color: #CC99FF; border: medium inset #9900CC">G-mail:</td>
            <td class="auto-style7" style="background-color: #FFCCCC">
                <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 0px" Width="301px" TextMode="Email"></asp:TextBox>
            </td>
            <td class="auto-style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Please Enter G-Mail ID*" ForeColor="Red" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                <br />
&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*You must enter the valid E-mail ID" ForeColor="#009900" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox4"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td colspan ="2" style="background-color: #00FFFF">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="SUBMIT" BackColor="#99FF99" OnClick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="16px" OnTextChanged="TextBox6_TextChanged" TextMode="Color" BackColor="#99FF99"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="RESET" BackColor="#99FF99" OnClick="Button2_Click" />
            </td>
            
           
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
