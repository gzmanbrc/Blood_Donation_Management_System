using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace Project1
{
    internal class Donors
    {
        DB dB = new DB();

        #region Fields
        private int _DonorID;
        private int _DonorGenderID;
        private int _DonorBloodGroupID;
        private string _DonorName;
        private int _DonorAge;
        private string _DonorPhone;
        private string _DonorAddress;
        private bool _DonorStatus;
        #endregion
        #region Properties
        public int DonorID { get => _DonorID; set => _DonorID = value; }
        public int DonorGenderID { get => _DonorGenderID; set => _DonorGenderID = value; }
        public int DonorBloodGroupID { get => _DonorBloodGroupID; set => _DonorBloodGroupID = value; }
        public string DonorName { get => _DonorName; set => _DonorName = value; }
        public int DonorAge { get => _DonorAge; set => _DonorAge = value; }
        public string DonorPhone { get => _DonorPhone; set => _DonorPhone = value; }
        public string DonorAddress { get => _DonorAddress; set => _DonorAddress = value; }
        public bool DonorStatus { get => _DonorStatus; set => _DonorStatus = value; }
        #endregion

        public int AddDonor(Donors donor)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Insert Into tblDonor (DonorGenderID, DonorBloodGroupID, DonorName, DonorAge, DonorPhone, DonorAddress) Values (@DonorGenderID, @DonorBloodGroupID, @DonorName, @DonorAge, @DonorPhone, @DonorAddress)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@DonorGenderID", SqlDbType.Int).Value = donor._DonorGenderID;
                cmd.Parameters.Add("@DonorBloodGroupID", SqlDbType.Int).Value = donor._DonorBloodGroupID;
                cmd.Parameters.Add("@DonorName", SqlDbType.VarChar).Value = donor._DonorName;
                cmd.Parameters.Add("@DonorAge", SqlDbType.Int).Value = donor._DonorAge;
                cmd.Parameters.Add("@DonorPhone", SqlDbType.VarChar).Value = donor._DonorPhone;
                cmd.Parameters.Add("@DonorAddress", SqlDbType.VarChar).Value = donor._DonorAddress;
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

        public void ListingDonorsLW(ListView lw)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT d.ID AS ID, d.DonorName, d.DonorAge, d.DonorPhone, d.DonorAddress, bg.BloodGroup AS BGN, g.Gender AS GN, bg.ID AS BGID, b.BloodStock AS BS FROM tblDonor d JOIN tblBloodGroup bg ON d.DonorBloodGroupID = bg.ID JOIN tblBlood b ON bg.ID = b.BloodGroupID JOIN tblGender g ON d.DonorGenderID = g.ID Where DonorStatus = 1", sqlConnection);

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
                    lw.Items[counter].SubItems.Add(reader["DonorName"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorAge"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorPhone"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorAddress"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BGID"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BS"].ToString());

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

        public void DonorsSearchLW(ListView lw, string search)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT b.ID AS ID, b.DonorName, b.DonorAge, b.DonorPhone, b.DonorAddress, bg.BloodGroup AS BGN, g.Gender AS GN FROM tblDonor b JOIN tblBloodGroup bg ON b.DonorBloodGroupID = bg.ID JOIN tblGender g ON b.DonorGenderID = g.ID Where DonorStatus = 1 AND b.DonorName LIKE '%' + @search + '%'", sqlConnection);

            SqlDataReader reader = null;
            cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = search;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)

                    sqlConnection.Open();

                reader = cmd.ExecuteReader();

                int counter = 0;
                while (reader.Read())
                {
                    lw.Items.Add(reader["ID"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BGN"].ToString());
                    lw.Items[counter].SubItems.Add(reader["GN"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorName"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorAge"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorPhone"].ToString());
                    lw.Items[counter].SubItems.Add(reader["DonorAddress"].ToString());

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
    }
}
