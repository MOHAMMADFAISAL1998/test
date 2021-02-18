using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newprogram
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a, b;
            a = TextBox1.Text;
            b = TextBox2.Text;
            if (a == "hera" && b == "hera")
                Response.Redirect("WebForm2.aspx");
            if (a == "bhaiya" && b == "bhaiya")
                Response.Redirect("WebForm3.aspx");
               
        }
    }
}