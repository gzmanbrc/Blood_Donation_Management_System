using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            Transfers transfer = new Transfers();

            transfer.SPListingActiveTransfers(lwAbleToDonateList);
            transfer.SPListingPassiveTransfers(lwNotAbleToDonateList);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmViewDonor frmViewDonor = new frmViewDonor();
            this.Close();
            frmViewDonor.Show();
        }
    }
}
