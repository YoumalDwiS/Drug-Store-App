using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloTek
{
    public partial class Form_DBAdmin1 : Form
    {
        public Form_DBAdmin1()
        {
            InitializeComponent();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Form_TRPembelian pembelian = new Form_TRPembelian();
            this.Hide();
            pembelian.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_DBAdmin admin = new Form_DBAdmin();
            this.Hide();
            admin.Show();
        }
    }
}
