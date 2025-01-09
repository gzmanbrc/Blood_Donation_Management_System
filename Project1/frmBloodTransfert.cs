using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project1
{
    public partial class frmBloodTransfert : Form
    {
        public frmBloodTransfert()
        {
            InitializeComponent();
        }

        private void BloodTransfert_Load(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.GetPatientNameCBX(cbxPatientName);
        }

        private void cbxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Patients selectedPatient = (Patients)cbxPatientName.SelectedItem;
            txtPatientID.Text = selectedPatient.PatientID.ToString();
            txtBloodGroupName.Text = selectedPatient.PatientBloodGroupName.ToString();
            txtPatientBloodGroupID.Text = selectedPatient.PatientBloodGroupID.ToString();
            txtBloodStock.Text = selectedPatient.PatientBloodStock.ToString();

            btnTransfer.Visible = true;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Bloods blood = new Bloods();
                blood.BloodGroupID = Convert.ToInt32(txtPatientBloodGroupID.Text);
                blood.BloodStock = Convert.ToInt32(txtBloodStock.Text);
                int result = blood.UpdateBloodStock_BT(blood);

                if (result > 0)
                {
                    MessageBox.Show("Stok başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                }
                else
                {
                    MessageBox.Show("Stok güncellenemedi. Belirtilen ID'ye sahip kan grubu bulunamadı veya stok zaten sıfır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Will be exited !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RefreshForm()
        {
            this.Hide();

            frmBloodTransfert newForm = new frmBloodTransfert();
            newForm.Show();

            this.Close();
        }

        #region LABELS
        private void label10_Click(object sender, EventArgs e)
        {
            frmDonor donor = new frmDonor();
            donor.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmPatient Pat = new frmPatient();
            Pat.Show();
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

        private void label7_Click_1(object sender, EventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
