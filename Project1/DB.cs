using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class DB
    {
        public string connectionString = (@"Server=LAPTOP-4RO49L97; Database=BloodBankDB; Trusted_Connection=True; TrustServerCertificate=True;");

        public string sp_GetTransfersByStatus_Active = "sp_GetTransfersByStatus_Active";
        public string sp_GetTransfersByStatus_Passive = "sp_GetTransfersByStatus_Passive";

    }
}
