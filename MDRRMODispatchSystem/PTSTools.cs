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
    public partial class PTSTools : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTableReader dt;
        public PTSTools()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    "Insert into tbl_disp (_Date,_Case,PatientName,Age,Origin,Destination,ReferredBy,Transport,Dispatcher)values('"+dateTimePicker1.Text+"','"+ tbCase.Text+ "','" + tbPname.Text+ "','" + tbAge.Text+"','"+tbOrigin.Text+"','"+tbDestination.Text+ "','" + tbRef.Text + "','" + cbTransport.Text+"','"+cbDispatcher.Text+"')", con
                );

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfully Recorded!");
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            mainFrm frm = new mainFrm();
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    "Update tbl_disp set _Date='"+dateTimePicker1.Text+"',_Case='"+tbCase.Text+ "',PatientName='" + tbPname.Text+ "',Age='" + tbAge.Text+"',Origin='"+tbOrigin.Text+"',Destination='"+tbDestination.Text+ "',ReferredBy='" + tbRef.Text + "',Transport='" + cbTransport.Text+"',Dispatcher='"+cbDispatcher.Text+"' where ID="+tbID.Text+" ", con
                );
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text)) 
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }

            else
            {
                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbl_disp WHERE [ID] = " + tbID.Text + " ", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dateTimePicker1.Text = dr["_Date"].ToString();
                    tbCase.Text = dr["_Case"].ToString();
                    tbPname.Text = dr["PatientName"].ToString();
                    tbAge.Text = dr["Age"].ToString();
                    tbOrigin.Text = dr["Origin"].ToString();
                    tbDestination.Text = dr["Destination"].ToString();
                    tbRef.Text = dr["ReferredBy"].ToString();
                    cbTransport.Text = dr["Transport"].ToString();
                    cbDispatcher.Text = dr["Dispatcher"].ToString();
                }
            }
            
            con.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    "Delete from tbl_disp where ID=" + tbID.Text + " ", con
                );
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            mainFrm frm = new mainFrm();
            frm.Show();
            this.Hide();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
