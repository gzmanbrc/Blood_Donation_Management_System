using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Employees
    {
        DB dB = new DB();

        #region Fields
        private int _EmployeeID;
        private string _EmployeeName;
        private string _EmployeePassword;
        #endregion
        #region Properties
        public int EmployeeID { get => _EmployeeID; set => _EmployeeID = value; }
        public string EmployeeName { get => _EmployeeName; set => _EmployeeName = value; }
        public string EmployeePassword { get => _EmployeePassword; set => _EmployeePassword = value; }
        #endregion

        public bool AddEmployee(Employees employee)
        {
            bool result = false;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Insert Into tblEmployee(EmployeeName, EmployeePassword) Values(@EmployeeName, @EmployeePassword)", sqlConnection);

            cmd.Parameters.Add("EmployeeName", SqlDbType.VarChar).Value = employee._EmployeeName;
            cmd.Parameters.Add("EmployeePassword", SqlDbType.VarChar).Value = employee._EmployeePassword;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            sqlConnection.Close();

            return result;
        }

        public bool EditEmployee(Employees employee, int employeeID)
        {
            bool result = false;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Update tblEmployee Set EmployeeName=@EmployeeName, EmployeePassword=@EmployeePassword Where ID=@employeeID", sqlConnection);

            cmd.Parameters.Add("employeeID", SqlDbType.Int).Value = employeeID;
            cmd.Parameters.Add("EmployeeName", SqlDbType.VarChar).Value = employee._EmployeeName;
            cmd.Parameters.Add("EmployeePassword", SqlDbType.VarChar).Value = employee._EmployeePassword;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            sqlConnection.Close();

            return result;
        }

        public void GetEmployeeLW(ListView lw)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Select * From tblEmployee Where EmployeeStatus = 1", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();

            int counter = 0;
            while (reader.Read())
            {
                lw.Items.Add(reader["ID"].ToString());
                lw.Items[counter].SubItems.Add(reader["EmployeeName"].ToString());
                lw.Items[counter].SubItems.Add(reader["EmployeePassword"].ToString());

                counter++;
            }
            reader.Close();
            sqlConnection.Close();
        }

        public bool DeleteEmployee(int employeeID)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(dB.connectionString);

            SqlCommand cmd = new SqlCommand("Update tblEmployee Set EmployeeStatus = 0 Where ID=@employeeID", connection);
            //SqlCommand cmd = new SqlCommand("Delete From tblEmployee Where ID = @employeeID", connection);

            cmd.Parameters.Add("employeeID", SqlDbType.Int).Value = employeeID;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();

            return result;
        }
    }
}
