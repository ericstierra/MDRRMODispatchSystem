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
    public partial class Dashboard : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTable dt;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void txtTotalPTS_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Count all entries and display in Dashboard
            con.Open();
            OleDbCommand pts = new OleDbCommand("SELECT count(*) from tbl_disp", con);
            OleDbCommand ir = new OleDbCommand("SELECT count(*) from tbl_ir", con);
            int totalPTS = (int)pts.ExecuteScalar();
            int totalIR = (int)ir.ExecuteScalar();
            con.Close();

            txtTotalPTS.Text = totalPTS.ToString();
            txtTotalIR.Text = totalIR.ToString();
        }

        private void panelPTS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
