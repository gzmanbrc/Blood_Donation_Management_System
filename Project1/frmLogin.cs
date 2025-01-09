using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Project1
{
    public partial class frmLogin : Form
    {
        DB db = new DB();

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblContinueAsAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin Adm = new frmAdminLogin();
            Adm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            bool result = login.EmployeeEntry(txtUserName.Text, txtPassword.Text);

            if (result)
            {
                this.Hide();
                frmMain_Form mainForm = new frmMain_Form();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Check 'UserName' and/or 'Password' fields !");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
