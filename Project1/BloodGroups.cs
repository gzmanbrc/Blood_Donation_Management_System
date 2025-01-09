using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class BloodGroups
    {
        DB db = new DB();

        #region Fields
        private int _BloodGroupID;
        private string _BloodGroupName;
        #endregion
        #region Properties
        public int BloodGroupID { get => _BloodGroupID; set => _BloodGroupID = value; }
        public string BloodGroupName { get => _BloodGroupName; set => _BloodGroupName = value; }
        #endregion

        public void GetBloodGroupCBX(ComboBox cbx)
        {
            cbx.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(db.connectionString);
            SqlCommand cmd = new SqlCommand("Select * From tblBloodGroup", sqlConnection);

            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    BloodGroups bloodGroups = new BloodGroups();
                    bloodGroups._BloodGroupID = Convert.ToInt32(reader["ID"]);
                    bloodGroups._BloodGroupName = reader["BloodGroup"].ToString();

                    cbx.Items.Add(bloodGroups);
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

        public void ListingBloodGroupsLW_ID(ListView lw, int bloodGroupID)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(db.connectionString);
            SqlCommand cmd = new SqlCommand("Select b.ID as BID, b.BloodGroupID AS BGI, bg.BloodGroup BG, b.BloodStock AS BS From tblBlood b JOIN tblBloodGroup bg ON b.BloodGroupID = bg.ID Where BloodGroupID = @bloodGroupID", sqlConnection);

            SqlDataReader reader = null;
            cmd.Parameters.Add("@bloodGroupID", SqlDbType.Int).Value = bloodGroupID;

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
                    lw.Items.Add(reader["BID"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BGI"].ToString());
                    lw.Items[counter].SubItems.Add(reader["BG"].ToString());
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

        public override string ToString()
        {
            return BloodGroupName;
        }
    }
}
