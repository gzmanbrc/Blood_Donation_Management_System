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

namespace Project1
{
    public partial class frmDonateBlood : Form
    {
        public frmDonateBlood()
        {
            InitializeComponent();
        }
        private void frmDonateBlood_Load(object sender, EventArgs e)
        {
            Bloods blood = new Bloods();
            blood.ListingBloodStocksLW(lwBloodStock);

            Donors donor = new Donors();
            donor.ListingDonorsLW(lwDonor);

            BloodGroups bloodGroups = new BloodGroups();
            bloodGroups.GetBloodGroupCBX(cbxBloodGroup);
            cbxBloodGroup.Items.Insert(0, "Blood Groups");
            cbxBloodGroup.SelectedIndex = 0;
        }
        
        private void lwDonor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwDonor.SelectedItems.Count > 0)
            {
                txtDonorID.Text = lwDonor.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lwDonor.SelectedItems[0].SubItems[3].Text;
                cbxBloodGroup.Text = lwDonor.SelectedItems[0].SubItems[1].Text;
                txtBloodGroupID.Text = lwDonor.SelectedItems[0].SubItems[7].Text;
                txtBloodStock.Text = lwDonor.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Select a Donor");
            }
            else
            {
                try
                {
                    Transfers transfer = new Transfers();
                    transfer.TransferDonorID = Convert.ToInt32(txtDonorID.Text);
                    transfer.TransferBloodGroupID = Convert.ToInt32(txtBloodGroupID.Text);
                    transfer.TransferBloodAmount = Convert.ToInt32(txtBloodAmount.Text);
                    int result2 = transfer.AddTransfer(transfer);

                    Bloods blood = new Bloods();
                    blood.BloodGroupID = Convert.ToInt32(txtBloodGroupID.Text);
                    blood.BloodStock = Convert.ToInt32(txtBloodStock.Text);
                    blood.BloodAmount = Convert.ToInt32(txtBloodAmount.Text);
                    int result = blood.UpdateBloodStock_DB(blood);

                    if (result > 0)
                    {
                        MessageBox.Show("Stok başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result2 > 0)
                        {
                            MessageBox.Show("Transfer gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Transfer gerçekleşemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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

            frmDonateBlood newForm = new frmDonateBlood();
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
