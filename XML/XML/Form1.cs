using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.TableName = "XMLTABLE";
            DataColumn dc1 = new DataColumn("Name");
            DataColumn dc2 = new DataColumn("Course");
            DataColumn dc3 = new DataColumn("University");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Rows.Add("Akash","BCA","MCRPV");
            dt.Rows.Add("Faisal","BCA","MCRPV");
           //dt.Rows.Add("Sachin","BCA","MCRPV");
            DataSet ds = new DataSet();
            ds.DataSetName = "XMLDATASET";
            ds.Tables.Add(dt);
            ds.WriteXml("XMLTABLE");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("XMLTABLE");
            dgView1.DataSource = ds.Tables[0];


        }
    }
}
