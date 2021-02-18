using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;

namespace WebForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataGridView.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Files\WebFormDatabase.accdb";
            cmd.Connection = con;
            String qurrySql = "insert into DbTable values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            try
            {
                con.Open();
                cmd.CommandText = qurrySql;
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        
        }
    }
}