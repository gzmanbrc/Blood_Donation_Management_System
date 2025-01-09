using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmDonor : Form
    {
        public frmDonor()
        {
            InitializeComponent();
        }
        private void frmDonor_Load(object sender, EventArgs e)
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
                Donors donor = new Donors();
                donor.DonorGenderID = cbxGender.SelectedIndex;
                donor.DonorBloodGroupID = cbxBloodGroup.SelectedIndex;
                donor.DonorName = txtName.Text;
                donor.DonorAge = Convert.ToInt32(txtAge.Text);
                donor.DonorPhone = txtPhone.Text;
                donor.DonorAddress = txtAddress.Text;
                donor.DonorStatus = true;
                int result = donor.AddDonor(donor);

                if (result != 0)
                {
                    MessageBox.Show("Successfully", "Record added" , MessageBoxButtons.OK);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Record not added!");
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
    }
}
