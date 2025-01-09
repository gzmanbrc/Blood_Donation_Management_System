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
    public partial class frmViewPatient : Form
    {
        public frmViewPatient()
        {
            InitializeComponent();
        }

        private void frmViewPatient_Load(object sender, EventArgs e)
        {
            Genders gender = new Genders();
            gender.GetGenderCBX(cbxGender);

            BloodGroups bloodGroups = new BloodGroups();
            bloodGroups.GetBloodGroupCBX(cbxBloodGroup);

            Patients patient = new Patients();
            patient.ListingPatientsLW(lwPatientList);
        }

        private void lwPatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwPatientList.SelectedItems.Count > 0)
            {
                txtPatientID.Text = lwPatientList.SelectedItems[0].SubItems[0].Text;
                cbxGender.Text = lwPatientList.SelectedItems[0].SubItems[2].Text;
                cbxBloodGroup.Text = lwPatientList.SelectedItems[0].SubItems[1].Text;
                txtName.Text = lwPatientList.SelectedItems[0].SubItems[3].Text;
                txtAge.Text = lwPatientList.SelectedItems[0].SubItems[4].Text;
                txtPhone.Text = lwPatientList.SelectedItems[0].SubItems[5].Text;
                txtAddress.Text = lwPatientList.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtAge.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Gıda adı, fiyatı ve kategori seçilmemiştir.", "Dikkat bilgiler eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patients patient = new Patients();
                patient.PatientGenderID = cbxGender.SelectedIndex + 1;
                patient.PatientBloodGroupID = cbxBloodGroup.SelectedIndex + 1;
                patient.PatientName = txtName.Text;
                patient.PatientAge = Convert.ToInt32(txtAge.Text);
                patient.PatientPhone = txtPhone.Text;
                patient.PatientAddress = txtAddress.Text;
                patient.PatientID = Convert.ToInt32(txtPatientID.Text);
                int sonuc = patient.UpdatePatient(patient);

                if (sonuc != 0)
                {
                    MessageBox.Show("Record update successfully");
                    patient.ListingPatientsLW(lwPatientList);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lwPatientList.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Patients patient = new Patients();
                    bool result = patient.DeletePatient(Convert.ToInt32(lwPatientList.SelectedItems[0].Text));
                    if (result)
                    {
                        MessageBox.Show("Kayıt silme başarılı");
                        patient.ListingPatientsLW(lwPatientList);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken hata oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt seçiniz");
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
            txtPatientID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            cbxGender.SelectedIndex = -1;
            cbxBloodGroup.SelectedIndex = -1;
            txtAddress.Text = "";
        }

        #region LABELS
        private void label7_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
            this.Hide();

        }
        private void label10_Click(object sender, EventArgs e)
        {
            frmDonor donor = new frmDonor();
            donor.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label7_Click_1(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
        #endregion
    }
}
