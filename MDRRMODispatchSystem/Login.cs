using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRRMOperationsIMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void secretLogin_Click(object sender, EventArgs e)
        {
            mainFrm frm2 = new mainFrm();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click_1(object sender, EventArgs e)
        {
            About frm2 = new About();
            frm2.Show();
        }
    }
}
