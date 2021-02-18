using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;


namespace WebApplication1
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Files\Sampledb.accdb";
            cmd.Connection = con;
            string sql = "insert into userdetails values('" + TextBox4.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            try
            {
                con.Open();
                cmd.CommandText = sql; 
               // cmd.ExecuteNonQuery();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Your Registration is Unsuccessful");
                con.Close();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("manager.aspx");
        }
    }
}