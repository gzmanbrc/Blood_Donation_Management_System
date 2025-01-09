﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void lblContinueAsAdmin_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "ali")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if (txtAdminPassword.Text == "password")
            {
                frmEmployee Emp = new frmEmployee();
                Emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password. Contact the System Admin!");
                txtAdminPassword.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
