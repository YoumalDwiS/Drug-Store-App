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
    public partial class Form_LPPenjualan : Form
    {
        public Form_LPPenjualan()
        {
            InitializeComponent();
        }

        private void Form_LPPenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLaporanPenjualan.LaporanPendapatan' table. You can move, or remove it, as needed.
            this.LaporanPendapatanTableAdapter.Fill(this.DataSetLaporanPenjualan.LaporanPendapatan);

            this.reportViewer1.RefreshReport();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.LaporanPendapatanTableAdapter.filterDate(this.DataSetLaporanPenjualan.LaporanPendapatan, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
