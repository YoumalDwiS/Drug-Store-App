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
    public partial class Form_DBAdmin : Form
    {
        public Form_DBAdmin()
        {
            InitializeComponent();
           // this.Size = new Size(1920,1080);
        }
        

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form_MUser user = new Form_MUser();
            this.Close();
            user.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Form_MSupplier supplier = new Form_MSupplier();
            this.Hide();
            supplier.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            Form_MCustomer customer = new Form_MCustomer();
            this.Hide();
            customer.Show(); 
          
        }
        

        private void btnObat_Click(object sender, EventArgs e)
        {
            Form_MObat obat = new Form_MObat();
            this.Hide();
            obat.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Form_MKategori kategori = new Form_MKategori();
            this.Hide();
            kategori.Show();
        }

        private void btnResep_Click(object sender, EventArgs e)
        {
            Form_MResep resep = new Form_MResep();
            this.Hide();
            resep.Show();
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            Form_MUser user = new Form_MUser();
            this.Close();
            user.Show();
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            Form_MSupplier supplier = new Form_MSupplier();
            this.Hide();
            supplier.Show();
        }

        private void btnObat_Click_1(object sender, EventArgs e)
        {
            Form_MObat obat = new Form_MObat();
            this.Hide();
            obat.Show();
        }

        private void btnKategori_Click_1(object sender, EventArgs e)
        {
            Form_MKategori kategori = new Form_MKategori();
            this.Hide();
            kategori.Show();
        }

        private void btnResep_Click_1(object sender, EventArgs e)
        {
            Form_MResep resep = new Form_MResep();
            this.Hide();
            resep.Show();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Form_TRPembelian form = new Form_TRPembelian();
            this.Hide();
            form.Show();
        }
    }
}
