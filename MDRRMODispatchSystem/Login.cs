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
            //mainFrm frm2 = new mainFrm();
            //frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string username = "admin";
            const string password = "mdrrmo2022!";

            if(txtUsername.Text == username && txtPass.Text == password)
            {
                //show main form after successful login
                mainFrm frm2 = new mainFrm();
                frm2.Show();

                //clear textbox
                txtUsername.Text = String.Empty;
                txtPass.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Sorry wrong Username or Password! Please try again!");

                //clear textbox
                txtUsername.Text = String.Empty;
                txtPass.Text = String.Empty;
            }
        }

        private void btnAboutUs_Click_1(object sender, EventArgs e)
        {
            About frm2 = new About();
            frm2.Show();
        }
    }
}
