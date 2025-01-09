using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Patients
    {
        DB dB = new DB();

        #region Fields
        private int _PatientID;
        private int _PatientGenderID;
        private int _PatientBloodGroupID;
        private string _PatientBloodGroupName;
        private string _PatientName;
        private int _PatientAge;
        private string _PatientPhone;
        private string _PatientAddress;
        private bool _PatientStatus;
        private int _PatientBloodStock;
        #endregion
        #region Properties
        public int PatientID { get => _PatientID; set => _PatientID = value; }
        public int PatientGenderID { get => _PatientGenderID; set => _PatientGenderID = value; }
        public int PatientBloodGroupID { get => _PatientBloodGroupID; set => _PatientBloodGroupID = value; }
        public string PatientName { get => _PatientName; set => _PatientName = value; }
        public int PatientAge { get => _PatientAge; set => _PatientAge = value; }
        public string PatientPhone { get => _PatientPhone; set => _PatientPhone = value; }
        public string PatientAddress { get => _PatientAddress; set => _PatientAddress = value; }
        public bool PatientStatus { get => _PatientStatus; set => _PatientStatus = value; }
        public string PatientBloodGroupName { get => _PatientBloodGroupName; set => _PatientBloodGroupName = value; }
        public int PatientBloodStock { get => _PatientBloodStock; set => _PatientBloodStock = value; }
        #endregion

        public void GetPatientNameCBX(ComboBox cbx)
        {
            cbx.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Select p.ID, p.PatientName, bg.BloodGroup, bg.ID as BGID, b.BloodStock AS BStock From tblPatient p JOIN tblBloodGroup bg ON p.PatientBloodGroupID = bg.ID JOIN tblBlood b ON b.BloodGroupID = bg.ID Where PatientStatus = 1", sqlConnection);

            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Patients patient = new Patients();
                    patient._PatientID = Convert.ToInt32(reader["ID"]);
                    patient._PatientName = reader["PatientName"].ToString();
                    patient._PatientBloodGroupID = Convert.ToInt32(reader["BGID"]);
                    patient._PatientBloodGroupName = reader["BloodGroup"].ToString();
                    patient._PatientBloodStock = Convert.ToInt32(reader["BStock"]);

                    cbx.Items.Add(patient);
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

        public int AddPatient(Patients patient)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Insert Into tblPatient (PatientGenderID, PatientBloodGroupID, PatientName, PatientAge, PatientPhone, PatientAddress) Values (@PatientGenderID, @PatientBloodGroupID, @PatientName, @PatientAge, @PatientPhone, @PatientAddress)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@PatientGenderID", SqlDbType.Int).Value = patient._PatientGenderID;
                cmd.Parameters.Add("@PatientBloodGroupID", SqlDbType.Int).Value = patient._PatientBloodGroupID;
                cmd.Parameters.Add("@PatientName", SqlDbType.VarChar).Value = patient._PatientName;
                cmd.Parameters.Add("@PatientAge", SqlDbType.Int).Value = patient._PatientAge;
                cmd.Parameters.Add("@PatientPhone", SqlDbType.VarChar).Value = patient._PatientPhone;
                cmd.Parameters.Add("@PatientAddress", SqlDbType.VarChar).Value = patient._PatientAddress;
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
            return result;
        }

        public void ListingPatientsLW(ListView lw)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT p.ID AS ID, p.PatientName, p.PatientAge, p.PatientPhone, p.PatientAddress, bg.BloodGroup AS BGN, g.Gender AS GN FROM tblPatient p JOIN tblBloodGroup bg ON p.PatientBloodGroupID = bg.ID JOIN tblGender g ON p.PatientGenderID = g.ID Where PatientStatus = 1", sqlConnection);

            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                reader = cmd.ExecuteReader();

                int counter = 0;
                while (reader.Read())
                {
                    lw.Items.Add(reader["ID"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BGN"].ToString());
                    lw.Items[counter].SubItems.Add(reader["GN"].ToString());
                    lw.Items[counter].SubItems.Add(reader["PatientName"].ToString());
                    lw.Items[counter].SubItems.Add(reader["PatientAge"].ToString());
                    lw.Items[counter].SubItems.Add(reader["PatientPhone"].ToString());
                    lw.Items[counter].SubItems.Add(reader["PatientAddress"].ToString());

                    counter++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                reader.Close();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        public int UpdatePatient(Patients patient)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Update tblPatient Set PatientGenderID=@PatientGenderID, PatientBloodGroupID=@PatientBloodGroupID, PatientName=@PatientName, PatientAge=@PatientAge, PatientPhone=@PatientPhone, PatientAddress=@PatientAddress Where ID=@patientID", sqlConnection);

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                cmd.Parameters.Add("@PatientGenderID", SqlDbType.Int).Value = patient._PatientGenderID;
                cmd.Parameters.Add("@PatientBloodGroupID", SqlDbType.Int).Value = patient._PatientBloodGroupID;
                cmd.Parameters.Add("@PatientName", SqlDbType.VarChar).Value = patient._PatientName;
                cmd.Parameters.Add("@PatientAge", SqlDbType.Int).Value = patient._PatientAge;
                cmd.Parameters.Add("@PatientPhone", SqlDbType.VarChar).Value = patient._PatientPhone;
                cmd.Parameters.Add("@PatientAddress", SqlDbType.VarChar).Value = patient._PatientAddress;
                cmd.Parameters.Add("@patientID", SqlDbType.Int).Value = patient._PatientID;
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
            return result;
        }

        public bool DeletePatient(int patientID)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(dB.connectionString);

            SqlCommand cmd = new SqlCommand("Update tblPatient Set PatientStatus = 0 Where ID=@patientID", connection);
            //SqlCommand cmd = new SqlCommand("Delete From Personeller Where ID = @perId", connection);

            cmd.Parameters.Add("patientID", SqlDbType.Int).Value = patientID;

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

        public override string ToString()
        {
            return PatientName;
        }
    }
}
