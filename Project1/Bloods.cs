using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Project1
{
    internal class Bloods
    {
        DB dB = new DB();

        #region Fields
        private int _BloodID;
        private int _BloodGroupID;
        private int _BloodStock;
        private int _BloodAmount;
        #endregion
        #region Properties
        public int BloodID { get => _BloodID; set => _BloodID = value; }
        public int BloodGroupID { get => _BloodGroupID; set => _BloodGroupID = value; }
        public int BloodStock { get => _BloodStock; set => _BloodStock = value; }
        public int BloodAmount { get => _BloodAmount; set => _BloodAmount = value; }
        #endregion

        public void ListingBloodStocksLW(ListView lw)
        {
            lw.Items.Clear();

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Select b.ID as ID, b.BloodGroupID as BGI, bg.BloodGroup as BG, b.BloodStock as BS From tblBlood b JOIN tblBloodGroup bg ON b.BloodGroupID = bg.ID", sqlConnection);

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

        public int UpdateBloodStock_BT(Bloods blood)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Update tblBlood SET BloodStock = @BloodStock - 1 WHERE ID = @BloodGroupID", sqlConnection);

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                cmd.Parameters.Add("@BloodGroupID", SqlDbType.Int).Value = blood._BloodGroupID;
                cmd.Parameters.Add("@BloodStock", SqlDbType.Int).Value = blood._BloodStock;
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

        
        public int UpdateBloodStock_DB(Bloods blood)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Update tblBlood SET BloodStock = @BloodStock + @BloodAmount WHERE ID = @BloodGroupID", sqlConnection);

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                cmd.Parameters.Add("@BloodGroupID", SqlDbType.Int).Value = blood._BloodGroupID;
                cmd.Parameters.Add("@BloodStock", SqlDbType.Int).Value = blood._BloodStock;
                cmd.Parameters.Add("@BloodAmount", SqlDbType.Int).Value = blood._BloodAmount;
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

    }
}
