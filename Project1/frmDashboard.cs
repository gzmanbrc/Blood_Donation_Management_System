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
    public partial class frmDashboard : Form
    {
        public string connectionString = ("Server=LAPTOP-4RO49L97; Database=BloodBankDB; Trusted_Connection=True; TrustServerCertificate=True;");
        public frmDashboard()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from tblDonor", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblDonor.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda1 = new SqlDataAdapter("Select count (*) from tblTransfer", sqlConnection);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                lblTransfer.Text = dt1.Rows[0][0].ToString();

                SqlDataAdapter sda2 = new SqlDataAdapter("Select count (*) from tblEmployee", sqlConnection);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                lblEmployee.Text = dt2.Rows[0][0].ToString();

                SqlDataAdapter sda3 = new SqlDataAdapter("Select Sum(BloodStock) from tblBlood", sqlConnection);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                int BloodStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
                lblTotal.Text = "" + BloodStock;

                // 0+ group
                SqlDataAdapter sda4 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "7" + "'", sqlConnection);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                lbl0plusNum.Text = dt4.Rows[0][0].ToString();
                double plus0Percentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBar0plus.Value = Convert.ToInt32(plus0Percentage);

                // AB+ group
                SqlDataAdapter sda5 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "3" + "'", sqlConnection);
                DataTable dt5 = new DataTable();
                sda5.Fill(dt5);
                lblABplusNum.Text = dt5.Rows[0][0].ToString();
                double ABplusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarABplus.Value = Convert.ToInt32(ABplusPercentage);

                // 0- group
                SqlDataAdapter sda6 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "8" + "'", sqlConnection);
                DataTable dt6 = new DataTable();
                sda6.Fill(dt6);
                lbl0MinusNum.Text = dt6.Rows[0][0].ToString();
                double Minus0Percentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBar0Minus.Value = Convert.ToInt32(Minus0Percentage);

                // AB- group
                SqlDataAdapter sda7 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "6" + "'", sqlConnection);
                DataTable dt7 = new DataTable();
                sda7.Fill(dt7);
                lblABminusNum.Text = dt7.Rows[0][0].ToString();
                double ABminusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarABminus.Value = Convert.ToInt32(ABminusPercentage);

                // A+
                SqlDataAdapter sda8 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "1" + "'", sqlConnection);
                DataTable dt8 = new DataTable();
                sda8.Fill(dt8);
                lblAplusNum.Text = dt8.Rows[0][0].ToString();
                double AplusPercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarAplus.Value = Convert.ToInt32(AplusPercentage);

                // A-
                SqlDataAdapter sda9 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "4" + "'", sqlConnection);
                DataTable dt9 = new DataTable();
                sda9.Fill(dt9);
                lblAminusNum.Text = dt9.Rows[0][0].ToString();
                double AminusPercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarAminus.Value = Convert.ToInt32(AminusPercentage);

                // B+
                SqlDataAdapter sda10 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "2" + "'", sqlConnection);
                DataTable dt10 = new DataTable();
                sda10.Fill(dt10);
                lblBplusNum.Text = dt10.Rows[0][0].ToString();
                double BplusPercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarBplus.Value = Convert.ToInt32(BplusPercentage);

                // B-
                SqlDataAdapter sda11 = new SqlDataAdapter("Select BloodStock from tblBlood where BloodGroupID='" + "5" + "'", sqlConnection);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                lblBminusNum.Text = dt11.Rows[0][0].ToString();
                double BminusPercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / BloodStock) * 100;
                prgBarBminus.Value = Convert.ToInt32(BminusPercentage);

                sqlConnection.Close();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            GetData();
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

        private void label7_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            frmBloodTransfert BT = new frmBloodTransfert();
            BT.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Will be exited !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
