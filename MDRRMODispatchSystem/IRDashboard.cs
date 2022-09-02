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
    public partial class IRDashboard : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTable dt;
        public IRDashboard()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        void datasearch()
        {
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter
                (
                    "Select * from tbl_ir ORDER by [DOI] desc", con
                );
            dt = new DataTable();
            adapt.Fill(dt);

            //Set AutoGenerateColumns False
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.ColumnCount = 11;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Columns List
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].HeaderText = "IR No.";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].Name = "DOI";
            dataGridView1.Columns[1].HeaderText = "Date Occured";
            dataGridView1.Columns[1].DataPropertyName = "DOI";
            dataGridView1.Columns[1].Width = 80;

            dataGridView1.Columns[2].Name = "TOI";
            dataGridView1.Columns[2].HeaderText = "Time Occured";
            dataGridView1.Columns[2].DataPropertyName = "TOI";
            dataGridView1.Columns[2].Width = 80;

            dataGridView1.Columns[3].Name = "NatureOfIncident";
            dataGridView1.Columns[3].HeaderText = "Nature Of Incident";
            dataGridView1.Columns[3].DataPropertyName = "NatureOfIncident";
            dataGridView1.Columns[3].Width = 90;

            dataGridView1.Columns[4].Name = "PlaceOfIncident";
            dataGridView1.Columns[4].HeaderText = "Place Of Incident";
            dataGridView1.Columns[4].DataPropertyName = "PlaceOfIncident";
            dataGridView1.Columns[4].Width = 90;

            dataGridView1.Columns[5].Name = "NoOfCasualties";
            dataGridView1.Columns[5].HeaderText = "No. Of Victim/s";
            dataGridView1.Columns[5].DataPropertyName = "NoOfCasualties";
            dataGridView1.Columns[5].Width = 60;

            dataGridView1.Columns[6].Name = "IsItCollision";
            dataGridView1.Columns[6].HeaderText = "Is It Collision?";
            dataGridView1.Columns[6].DataPropertyName = "IsItCollision";
            dataGridView1.Columns[6].Width = 60;

            dataGridView1.Columns[7].Name = "VehicleInvolved";
            dataGridView1.Columns[7].HeaderText = "Involved Vehicle/s";
            dataGridView1.Columns[7].DataPropertyName = "VehicleInvolved";
            dataGridView1.Columns[7].Width = 150;

            dataGridView1.Columns[8].Name = "RespondedBy";
            dataGridView1.Columns[8].HeaderText = "Responded By";
            dataGridView1.Columns[8].DataPropertyName = "RespondedBy";
            dataGridView1.Columns[8].Width = 150;

            dataGridView1.Columns[9].Name = "Hospital";
            dataGridView1.Columns[9].HeaderText = "Hospital";
            dataGridView1.Columns[9].DataPropertyName = "Hospital";
            dataGridView1.Columns[9].Width = 70;

            dataGridView1.Columns[10].Name = "Remarks";
            dataGridView1.Columns[10].HeaderText = "Additional Info/Remarks";
            dataGridView1.Columns[10].DataPropertyName = "Remarks";
           // dataGridView1.Columns[10].Width = 250;

            //Show Data in GridView
            dataGridView1.DataSource = dt;

            //Close Connection
            con.Close();
        }

        private void IRDashboard_Load(object sender, EventArgs e)
        {
            datasearch();
        }
    }
}
