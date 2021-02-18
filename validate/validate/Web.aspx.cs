using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validate
{
    public partial class Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.Text = " [Default] ";
            TextBox4.Text = "";

            TextBox5.Text = "";
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            TextBox1.Text = "";
           TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.Text = " [Default] ";
            TextBox4.Text = "";
            
            TextBox5.Text = "";
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Button2.BackColor = TextBox6.BackColor;
            Button3.BackColor = TextBox6.BackColor;
        }

      

       
    }
}