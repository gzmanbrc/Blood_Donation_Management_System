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
using System.Xml.Linq;

namespace Project1
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.GetEmployeeLW(lwEmployeeList);
        }

        private void lwEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwEmployeeList.SelectedItems.Count > 0)
            {
                txtEmployeeID.Text = lwEmployeeList.SelectedItems[0].SubItems[0].Text;
                txtEmployeeName.Text = lwEmployeeList.SelectedItems[0].SubItems[1].Text;
                txtEmployeePassword.Text = lwEmployeeList.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeePassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Employees employee = new Employees();
                employee.EmployeeName = txtEmployeeName.Text;
                employee.EmployeePassword = txtEmployeePassword.Text;
                bool result = employee.AddEmployee(employee);

                if (result)
                {
                    MessageBox.Show("Kayıt ekleme başarılı");
                    Reset();
                    employee.GetEmployeeLW(lwEmployeeList);
                }
                else
                {
                    MessageBox.Show("Kayıt eklenirken hata oluştu");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lwEmployeeList.SelectedItems.Count > 0)
            {
                if (txtEmployeeName.Text != "" || txtEmployeePassword.Text != "")
                {
                    Employees employee = new Employees();
                    employee.EmployeeName = txtEmployeeName.Text;
                    employee.EmployeePassword = txtEmployeePassword.Text;
                    bool result = employee.EditEmployee(employee, Convert.ToInt32(txtEmployeeID.Text));

                    if (result)
                    {
                        MessageBox.Show("Adding record successful");
                        Reset();
                        employee.GetEmployeeLW(lwEmployeeList);
                    }
                    else
                    {
                        MessageBox.Show("Error adding record !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave empty space !?!");
                }
            }
            else
            {
                MessageBox.Show("Select record ???");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lwEmployeeList.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Employees employee = new Employees();
                    bool sonuc = employee.DeleteEmployee(Convert.ToInt32(lwEmployeeList.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Record deletion successful");
                        Reset();
                        employee.GetEmployeeLW(lwEmployeeList);
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while deleting record");
                    }
                }
                else
                {
                    MessageBox.Show("Select record");
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

        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void Reset()
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeePassword.Text = "";
        }
    }
}
