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
    public partial class Form_DBKasir : Form
    {
        public Form_DBKasir()
        {
            InitializeComponent();
        }

        private void Form_DBKasir_Load(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Form_TRPenjualan form = new Form_TRPenjualan();
            this.Hide();
            form.Show();
        }
    }
}
