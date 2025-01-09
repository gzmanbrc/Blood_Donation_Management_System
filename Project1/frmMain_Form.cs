using System;
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
    public partial class frmMain_Form : Form
    {
        public frmMain_Form()
        {
            InitializeComponent();
        }

        #region LABELS
        private void label10_Click(object sender, EventArgs e)
        {
            frmDonor donor = new frmDonor();
            donor.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            frmDonateBlood DB = new frmDonateBlood();
            DB.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            frmViewDonor VD = new frmViewDonor();
            VD.Show();
            this.Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            frmViewPatient VP = new frmViewPatient();
            VP.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            frmBloodStock BS = new frmBloodStock();
            BS.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            frmBloodTransfert BT = new frmBloodTransfert();
            BT.Show();
            this.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Will be exited !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
