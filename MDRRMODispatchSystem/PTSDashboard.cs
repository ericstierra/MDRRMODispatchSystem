using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace DRRMOperationsIMS
{
    public partial class PTSDashboard : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTable dt;
        public PTSDashboard()
        {
            InitializeComponent();
        }

        void datasearch()
        {
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter
                (
                    "Select * from tbl_disp ORDER by [_Date] desc", con
                );
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            DataView dv = new DataView(dt);

            //Check if SearchBox is Empty or Not
            if (String.IsNullOrEmpty(txtSearch.Text))
             {
                 con.Close();
                 datasearch();
             }
             else
             {
                 dv.RowFilter = string.Format("PatientName like '%{0}%'", txtSearch.Text);
                 dataGridView1.DataSource = dv;
                 con.Close();
             } 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datasearch();
        }
    }
}
