using System;
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
    public partial class viewprofile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DIMS-DB\dispatch_db.accdb");
        DataTable dt;
        public viewprofile()
        {
            InitializeComponent();
            BindGrind();
        }

        private void testGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

            private void BindGrind()
        {
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter
                (
                    "Select test_barangay.barangay_name, test_purok.purok_name, test_population.p_population FROM (test_barangay INNER JOIN test_purok ON test_barangay.ID = test_purok.barangay_id) INNER JOIN test_population ON test_purok.ID = test_population.purok_id", con
                );
            dt = new DataTable();
            adapt.Fill(dt);

            //Set AutoGenerateColumns False
            testGridView.AutoGenerateColumns = false;

            //Set Columns Count
            testGridView.ColumnCount = 3;
            testGridView.Rows.Add(10);
            this.testGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Add Columns
            testGridView.Columns[0].Name = "purok_name";
            testGridView.Columns[0].HeaderText = "Purok";
            testGridView.Columns[0].DataPropertyName = "purok_name";

            testGridView.Columns[1].Name = "barangay_name";
            testGridView.Columns[1].HeaderText = "Barangay";
            testGridView.Columns[1].DataPropertyName = "barangay_name";

            testGridView.Columns[2].Name = "p_population";
            testGridView.Columns[2].HeaderText = "Purok Population";
            testGridView.Columns[2].DataPropertyName = "p_population";

            testGridView.DataSource = dt;
        }
    }
}
