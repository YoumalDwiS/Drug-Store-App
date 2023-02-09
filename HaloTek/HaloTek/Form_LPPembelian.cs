using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace HaloTek
{
    public partial class Form_LPPembelian : Form
    {
        public Form_LPPembelian()
        {
            InitializeComponent();
        }

        private void Form_LPPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLaporanPembelian.LaporanPembelian' table. You can move, or remove it, as needed.
          //this.LaporanPembelianTableAdapter.Fill(this.DataSetLaporanPembelian.LaporanPembelian);

//            this.reportViewer1.RefreshReport();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLaporanPembelian.LaporanPembelian' table.You can move, or remove it, as needed.
            this.LaporanPembelianTableAdapter.filterDate(this.DataSetLaporanPembelian.LaporanPembelian, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            this.reportViewer1.RefreshReport();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form_DBKepala kepala = new Form_DBKepala();
            this.Hide();
            kepala.Show();
        }
    }
}
