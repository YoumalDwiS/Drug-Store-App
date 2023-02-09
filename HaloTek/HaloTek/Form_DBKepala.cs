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
    public partial class Form_DBKepala : Form
    {
        public Form_DBKepala()
        {
            InitializeComponent();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            /*FORM_LPPenjualan penjualan = new FORM_LPPenjualan();
            this.Hide();
            penjualan.Show(); */
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            Form_LPPembelian pembelian = new Form_LPPembelian();
            this.Hide();
            pembelian.Show();
        }

        private void btnPendapatan_Click(object sender, EventArgs e)
        {
            /*Form_LPPendapatan form = new Form_LPPendapatan();
            this.Hide();
            form.Show(); */
        }
    }
}
