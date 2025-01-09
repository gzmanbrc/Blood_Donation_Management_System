using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Transfers
    {
        DB dB = new DB();

        #region Fileds
        private int _TransferID;
        private int _TransferDonorID;
        private int _TransferBloodGroupID;
        private int _TransferBloodAmount;
        private DateTime _TransferDate;
        #endregion
        #region Properties
        public int TransferID { get => _TransferID; set => _TransferID = value; }
        public int TransferDonorID { get => _TransferDonorID; set => _TransferDonorID = value; }
        public int TransferBloodGroupID { get => _TransferBloodGroupID; set => _TransferBloodGroupID = value; }
        public int TransferBloodAmount { get => _TransferBloodAmount; set => _TransferBloodAmount = value; }
        public DateTime TransferDate { get => _TransferDate; set => _TransferDate = value; }
        #endregion

        public int AddTransfer(Transfers transfer)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString);
            SqlCommand cmd = new SqlCommand("Insert Into tblTransfer(TransferDonorID, TransferBloodGroupID, TransferBloodAmount, TransferDate) Values (@TransferDonorID, @TransferBloodGroupID, @TransferBloodAmount, @TransferDate)", sqlConnection);

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                cmd.Parameters.Add("@TransferDonorID", SqlDbType.Int).Value = transfer._TransferDonorID;
                cmd.Parameters.Add("@TransferBloodGroupID", SqlDbType.Int).Value = transfer._TransferBloodGroupID;
                cmd.Parameters.Add("@TransferBloodAmount", SqlDbType.Int).Value = transfer._TransferBloodAmount;
                cmd.Parameters.Add("@TransferDate", SqlDbType.DateTime).Value = DateTime.Now;
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

        public void SPListingActiveTransfers(ListView lw)
        {
            lw.Items.Clear(); // Clear the ListView

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString); // Connection string
            SqlCommand cmd = new SqlCommand(dB.sp_GetTransfersByStatus_Active, sqlConnection); // Call the stored procedure
            cmd.CommandType = CommandType.StoredProcedure; // Set the command type to Stored Procedure
            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open(); // Open the connection
                }

                reader = cmd.ExecuteReader(); // Get the data reader
                int counter = 0;

                while (reader.Read()) // Read all records
                {
                    lw.Items.Add(reader["ID"].ToString()); // Add the first column (ID)
                    lw.Items[counter].SubItems.Add(reader["DN"].ToString()); // DonorName
                    lw.Items[counter].SubItems.Add(reader["BG"].ToString()); // BloodGroup
                    lw.Items[counter].SubItems.Add(reader["BA"].ToString()); // TransferBloodAmount
                    lw.Items[counter].SubItems.Add(reader["DT"].ToString()); // TransferDate
                    lw.Items[counter].SubItems.Add(reader["TS"].ToString()); // TransferStatus
                    counter++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Display error message
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }
        public void SPListingPassiveTransfers(ListView lw)
        {
            lw.Items.Clear(); // Clear the ListView

            SqlConnection sqlConnection = new SqlConnection(dB.connectionString); // Connection string
            SqlCommand cmd = new SqlCommand(dB.sp_GetTransfersByStatus_Passive, sqlConnection); // Call the stored procedure
            cmd.CommandType = CommandType.StoredProcedure; // Set the command type to Stored Procedure
            SqlDataReader reader = null;

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open(); // Open the connection
                }

                reader = cmd.ExecuteReader(); // Get the data reader
                int counter = 0;

                while (reader.Read()) // Read all records
                {
                    lw.Items.Add(reader["ID"].ToString()); // Add the first column (ID)
                    lw.Items[counter].SubItems.Add(reader["DN"].ToString()); // DonorName
                    lw.Items[counter].SubItems.Add(reader["BG"].ToString()); // BloodGroup
                    lw.Items[counter].SubItems.Add(reader["BA"].ToString()); // TransferBloodAmount
                    lw.Items[counter].SubItems.Add(reader["DT"].ToString()); // TransferDate
                    lw.Items[counter].SubItems.Add(reader["TS"].ToString()); // TransferStatus
                    counter++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Display error message
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }
    }
}
