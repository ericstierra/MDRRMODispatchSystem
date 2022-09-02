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
                    "Insert into tbl_ir (DOI,TOI,NatureOfIncident,PlaceOfIncident,NoOfCasualties,Hospital,IsItCollision,VehicleInvolved,RespondedBy,Remarks)" +
                    "values" +
                    "('" + dateTimePicker1.Text + "','" + txtTime.Text + "','" + cmbNOI.Text + "','" + cmbPOI.Text + "'," + txtCasualty.Text + ",'" + cmbHospital.Text + "','" + cmbCollision.Text + "','" + txtVehicles.Text + "','" + txtResponded.Text + "','" + txtRemarks.Text + "')", con
                );

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfully Recorded!");

            clearTextbox();
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
                    txtRemarks.Text = dr["Remarks"].ToString();
                }
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand
                (
                    "Update tbl_ir set DOI='" + dateTimePicker1.Text + "',TOI='" + txtTime.Text + "',NatureOfIncident='" + cmbNOI.Text + "',PlaceofIncident='" + cmbPOI.Text + "',NoOfCasualties='" + txtCasualty.Text + "',Hospital='" + cmbHospital.Text + "',IsItCollision='" + cmbCollision.Text + "',VehicleInvolved='" + txtVehicles.Text + "',RespondedBy='" + txtResponded.Text + "',Remarks='" + txtRemarks.Text + "' where ID=" + txtIRNum.Text + " ", con
                );
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully!");

            clearTextbox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextbox();
        }

        private void clearTextbox()
        {
            dateTimePicker1.Text = String.Empty;
            txtTime.Text = String.Empty;
            cmbNOI.Text = String.Empty;
            cmbPOI.Text = String.Empty;
            txtCasualty.Text = String.Empty;
            cmbHospital.Text = String.Empty;
            cmbCollision.Text = String.Empty;
            txtVehicles.Text = String.Empty;
            txtResponded.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtIRNum.Text = String.Empty;
        }

    }
}
