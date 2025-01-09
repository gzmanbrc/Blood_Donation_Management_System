using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Genders
    {
        DB db = new DB();

        #region Fields
        private int _GenderID;
        private string _GenderName;
        #endregion
        #region Properties
        public int GenderID { get => _GenderID; set => _GenderID = value; }
        public string GenderName { get => _GenderName; set => _GenderName = value; }
        #endregion

        public void GetGenderCBX(ComboBox cbx)
        {
            cbx.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(db.connectionString);
            SqlCommand cmd = new SqlCommand("Select * From tblGender", sqlConnection);

            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Genders gender = new Genders();
                    gender._GenderID = Convert.ToInt32(reader["ID"]);
                    gender._GenderName = reader["Gender"].ToString();

                    cbx.Items.Add(gender);
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                reader.Close();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        public override string ToString()
        {
            return GenderName;
        }
    }
}
