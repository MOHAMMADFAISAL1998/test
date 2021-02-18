<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
        .auto-style2 {
            height: 28px;
            width: 270px;
        }
        .auto-style3 {
            width: 270px;
        }
        .auto-style4 {
            width: 353px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border ="1" align="center" style="border:inherit; height: 335px; width: 547px">

           <tr >
                            <td colspan ="2" align="center" style="border-color: #CC33FF; background-color: #CC99FF">Registration</td>
               
           </tr>

            <tr>
                <td class="auto-style1" style="border-color: #3333CC; background-color: #6699FF">Name:</td>
                <td class="auto-style2" style="border-color: #3333CC; background-color: #6699FF">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Name required*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td style="border-color: #3333CC; background-color: #6699FF">Gender:</td>
                <td style="border-color: #3333CC; background-color: #6699FF" class="auto-style3">
                     <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="a" />&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="a"/>
                </td>
              <td class="auto-style4">

                  &nbsp;</td>
                 
            </tr>
             
                <tr>
                    <td style="border-color: #3333CC; background-color: #6699FF">Password</td>
                    <td style="border-color: #3333CC; background-color: #6699FF" class="auto-style3"><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
             <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Password required*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                                    </tr>
            <tr>
                <td style="border-color: #3333CC; background-color: #6699FF">Confirm Password</td>
                <td style="border-color: #3333CC; background-color: #6699FF" class="auto-style3"><asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style4">

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Re-Enter your paasword*" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="*password do not match*" ForeColor="Maroon"></asp:CompareValidator>
                
            </td>
            </tr>
                <tr>
                    <td class="auto-style1" style="border-color: #3333CC; background-color: #6699FF">DOB</td>
                    <td class="auto-style2" style="border-color: #3333CC; background-color: #6699FF">
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Range do not sapport*" ForeColor="#009900" MaximumValue="01-01-2018" MinimumValue="01-01-2000" Type="Date"></asp:RangeValidator>
                    </td>
                </tr>    
            <tr>
                <td style="border-color: #3333CC; background-color: #6699FF">City</td>
                <td style="border-color: #3333CC; background-color: #6699FF" class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="170px">
                        <asp:ListItem>None</asp:ListItem>
                        <asp:ListItem>ghazipur</asp:ListItem>
                        <asp:ListItem>VNS</asp:ListItem>
                        <asp:ListItem>LKO</asp:ListItem>
                        <asp:ListItem>LD</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*City Name required*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>               
                       </table>
    
    </div>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
