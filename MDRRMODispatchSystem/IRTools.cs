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
    public partial class IRTools : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTableReader dt;
        public IRTools()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    "Insert into tbl_ir (DOI,TOI,NatureOfIncident,PlaceOfIncident,NoOfCasualty,Hospital,IsItCollision,VehicleInvolved,RespondedBy)" +
                    "values" +
                    "('" + dateTimePicker1.Text + "','" + txtTime.Text + "','" + cmbNOI.Text + "','" + cmbPOI.Text + "'," + txtCasualty.Text + ",'" + cmbHospital.Text + "','" + cmbCollision.Text + "','" + txtVehicles.Text + "','" + txtResponded.Text + "')", con
                );

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfully Recorded!");
        }

        private void txtIRNum_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIRNum.Text))
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }

            else
            {
                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbl_ir WHERE [ID] = " + txtIRNum.Text + " ", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dateTimePicker1.Text = dr["DOI"].ToString();
                    txtTime.Text = dr["TOI"].ToString();
                    cmbNOI.Text = dr["NatureOfIncident"].ToString();
                    cmbPOI.Text = dr["PlaceOfIncident"].ToString();
                    txtCasualty.Text = dr["NoOfCasualties"].ToString();
                    cmbHospital.Text = dr["Hospital"].ToString();
                    cmbCollision.Text = dr["IsItCollision"].ToString();
                    txtVehicles.Text = dr["VehicleInvolved"].ToString();
                    txtResponded.Text = dr["RespondedBy"].ToString();
                }
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    //"Update tbl_ir set DOI='" + dateTimePicker1.Text + "',TOI='" + txtTime.Text + "',PatientName='" + tbPname.Text + "',Age='" + tbAge.Text + "',Origin='" + tbOrigin.Text + "',Destination='" + tbDestination.Text + "',ReferredBy='" + tbRef.Text + "',Transport='" + cbTransport.Text + "',Dispatcher='" + cbDispatcher.Text + "' where ID=" + tbID.Text + " ", con
                );
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
