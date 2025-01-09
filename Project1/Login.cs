using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Login
    {
        DB db = new DB();

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

        public bool EmployeeEntry(string employeeName, string employeePassword)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(db.connectionString);
            SqlCommand cmd = new SqlCommand("Select * From tblEmployee Where EmployeeName=@EmployeeName AND EmployeePassword=@EmployeePassword AND EMployeeStatus = 1", connection);

            cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = employeeName;
            cmd.Parameters.Add("@EmployeePassword", SqlDbType.VarChar).Value = employeePassword;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            return result;
        }
    }
}
