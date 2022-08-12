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
    public partial class mainFrm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTable dt;
        public mainFrm()
        {
            InitializeComponent();
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            PTSTools frm = new PTSTools();
            frm.Show();
            this.Hide();
        }
        private void mainFrm_Load(object sender, EventArgs e)
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

            viewLatestIR();
            viewLatestPTS();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PTSDashboard frm = new PTSDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PTSDashboard frm = new PTSDashboard() { TopLevel = false, TopMost = true };
            this.tablePanel.Controls.Clear();
            this.tablePanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnAdmintools_Click(object sender, EventArgs e)
        {
            //PTSDashboard frm = new PTSDashboard();
            PTSTools frm1 = new PTSTools() { TopLevel = false, TopMost = true };
            this.tablePanel.Controls.Clear();
            this.tablePanel.Controls.Add(frm1);
            frm1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            IRDashboard frm = new IRDashboard() { TopLevel = false, TopMost = true };
            this.tablePanel.Controls.Clear();
            this.tablePanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnIRTools_Click(object sender, EventArgs e)
        {
            IRTools frm1 = new IRTools() { TopLevel = false, TopMost = true };
            this.tablePanel.Controls.Clear();
            this.tablePanel.Controls.Add(frm1);
            frm1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalPTS_Click(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard frm1 = new Dashboard() { TopLevel = false, TopMost = true };
            this.panMain.Controls.Clear();
            this.panMain.Controls.Add(frm1);
            frm1.Show();
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewLatestIR()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbl_ir ORDER BY DOI ASC", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbIncidentType.Text = reader["NatureOfIncident"].ToString();
                lbLocation.Text = reader["PlaceOfIncident"].ToString();
                lbDate.Text = reader["DOI"].ToString();
                lbIncidentTime.Text = reader["TOI"].ToString();
                lbRespondedBy.Text = reader["RespondedBy"].ToString();
            }
            con.Close();
        }

        private void viewLatestPTS()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbl_disp ORDER BY [_Date] ASC", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbCase.Text = reader["_Case"].ToString();
                lbPatientName.Text = reader["PatientName"].ToString();
                lbOrigin.Text = reader["Origin"].ToString();
                lbDestination.Text = reader["Destination"].ToString();
                lbAssignedTransport.Text = reader["Transport"].ToString();
            }
            con.Close();
        }
    }
}