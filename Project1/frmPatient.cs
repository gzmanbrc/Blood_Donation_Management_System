using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            BloodGroups bloodGroups = new BloodGroups();
            bloodGroups.GetBloodGroupCBX(cbxBloodGroup);
            cbxBloodGroup.Items.Insert(0, "Blood Groups");
            cbxBloodGroup.SelectedIndex = 0;

            Genders genders = new Genders();
            genders.GetGenderCBX(cbxGender);
            cbxGender.Items.Insert(0, "Genders");
            cbxGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtAge.Text == "" ||
                cbxGender.SelectedIndex == -1 || cbxBloodGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Patients patient = new Patients();
                patient.PatientGenderID = cbxGender.SelectedIndex;
                patient.PatientBloodGroupID = cbxBloodGroup.SelectedIndex;
                patient.PatientName = txtName.Text;
                patient.PatientAge = Convert.ToInt32(txtAge.Text);
                patient.PatientPhone = txtPhone.Text;
                patient.PatientAddress = txtAddress.Text;
                patient.PatientStatus = true;
                int result = patient.AddPatient(patient);

                if (result != 0)
                {
                    MessageBox.Show("Successfully", "Record added", MessageBoxButtons.OK);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Record not added");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Will be exited !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Reset()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            cbxGender.SelectedIndex = -1;
            cbxBloodGroup.SelectedIndex = -1;
            txtAddress.Text = "";
        }

        #region LABELS
        private void label4_Click(object sender, EventArgs e)
        {
            frmViewPatient viewPatient = new frmViewPatient();
            this.Hide();
            viewPatient.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmBloodTransfert Bt = new frmBloodTransfert();
            Bt.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label4_Click_1(object sender, EventArgs e)
        {
            frmViewPatient VP = new frmViewPatient();
            VP.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmBloodStock BS = new frmBloodStock();
            BS.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
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
    }
}
