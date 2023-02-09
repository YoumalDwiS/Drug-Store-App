using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HaloTek
{
    public partial class Form_TRPembelian : Form
    {

        //  string kode;
        int i = 0;
        int qty;
        public Form_TRPembelian()
        {
            InitializeComponent();
        }

        private void Form_TRPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetSupplier.sp_LoadSupplier' table. You can move, or remove it, as needed.
            this.sp_LoadSupplierTableAdapter.Fill(this.datasetSupplier.sp_LoadSupplier);
            // TODO: This line of code loads data into the 'datasetObat.mObat' table. You can move, or remove it, as needed.
            this.mObatTableAdapter.Fill(this.datasetObat.mObat);

            LoadData1();


        }

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = dbHalotek";
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(4, '0');
            return result;
        }

        public double split(String x)
        {
            String[] a = x.Split('.');
            // String[] b = a[1].Split('.');
            // String[] c = b[1].Split(',');
            String Total = a[0];
            double total = Double.Parse(separate(Total));

            return total;
        }

        public String separate(String a)
        {
            string[] test = a.Split(',');
            string x = "";
            foreach (string tst in test)
            {
                if (tst.Trim() != "")
                {
                    x = x + tst;
                    Console.Write(tst);
                }
            }
            return x;
        }
        void LoadData1()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
               
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                connection.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadObat", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dataGridView1.Columns[0].HeaderCell.Value = "ID Obat";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Obat";
                dataGridView1.Columns[2].HeaderCell.Value = "Kategori";
                dataGridView1.Columns[3].HeaderCell.Value = "Kandungan";
                dataGridView1.Columns[4].HeaderCell.Value = "Jenis";
                dataGridView1.Columns[5].HeaderCell.Value = "Dosis";
                dataGridView1.Columns[6].HeaderCell.Value = "Expired Date";
                dataGridView1.Columns[7].HeaderCell.Value = "Stok";
                dataGridView1.Columns[8].HeaderCell.Value = "Harga";
                dataGridView1.Columns[8].DefaultCellStyle.Format = "Rp ###,##0.00";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            double HT2 = 0.0;
            if (cbObat.SelectedIndex == -1)
            {
                MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = string.Empty;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    data = row.Cells[1].Value.ToString();
                    if (cbObat.SelectedItem.ToString().Equals(data))
                    {
                        MessageBox.Show("Data sudah pernah ditambahkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (tbJumlah.Text == "")
                {
                    MessageBox.Show("Isikan kuantitas Obat!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbJumlah.Text == "0")
                {
                    MessageBox.Show("Minimal pembelian adalah 1 buah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int stck = Convert.ToInt32(tbSisa.Text);
                    int jl = Convert.ToInt32(tbJumlah.Text);
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView3.DataSource;
                    DataTable st = new DataTable();
                    SqlCommand cb = new SqlCommand("sp_CariObat1", con);

                    cb.CommandType = CommandType.StoredProcedure;
                    cb.Parameters.AddWithValue("nama", cbObat.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter(cb);
                    adapter.Fill(st);

                    string id = cbObat.SelectedValue.ToString();
                    string nama = cbObat.Text;
                    double harga = Convert.ToDouble(tbHarga.Text);
                    double hargaak = Convert.ToDouble(tbTotalHarga.Text);
                    string supplier = cbSupplier.Text;
                    string kuantitas = tbJumlah.Text;
                    int kw = stck + Convert.ToInt32(tbJumlah.Text);
                    string[] row = { id, nama, supplier, harga.ToString(), hargaak.ToString(), kw.ToString(), kuantitas };
                    dataGridView3.Rows.Add(row);
                    i = i + 1;
                    btnCheckout.Text = "Checkout (" + i + ")";
                    foreach (DataGridViewRow rows in dataGridView3.Rows)
                    {
                        double HT1 = split(rows.Cells[4].Value.ToString());
                        HT2 = HT2 + HT1;
                    }
                    lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                     clear();
                }
            }
        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {
            if (tbJumlah.Text == "")
            {
                tbTotalHarga.Text = "0";
                return;
            }
            else
            {
                try
                {
                    double qt = Convert.ToDouble(tbJumlah.Text);
                    double harga = Convert.ToDouble(tbHarga.Text);
                    double hargaAkhir = (harga * qt);
                    tbTotalHarga.Text = string.Format("{0:n0}", Double.Parse(hargaAkhir.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //double harga = split(tbHarga.Text);
                string connectionString = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from mObat where id_obat='" + cbObat.SelectedValue + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                tbHarga.Text = string.Format("{0:n0}",Double.Parse(dt.Rows[0]["harga"].ToString()));
                tbSisa.Text = dt.Rows[0]["stok"].ToString();
             

                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnCheckout.Enabled)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                int jml = Convert.ToInt32(row.Cells[6].Value.ToString());
                int stok = Convert.ToInt32(row.Cells[5].Value.ToString());
                double hrg = Convert.ToDouble(row.Cells[3].Value.ToString());
                double HA;
                double HT2 = 0.0;
                string colname = dataGridView3.Columns[e.ColumnIndex].Name;
                if (colname == "Tambah")
                {
                    jml = jml + 1;
                    stok = stok + 1;
                    if (row.Cells[5].Value.ToString() == "0")
                    {
                        MessageBox.Show("Stock Obat kurang!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HA = (hrg * jml);
                        row.Cells[6].Value = jml;
                        row.Cells[5].Value = stok;
                        row.Cells[4].Value = HA;
                    }
                }
                else if (colname == "Kurang")
                {
                    jml = jml - 1;
                    stok = stok - 1;
                    if (jml == 0)
                    {
                        DialogResult d;
                        d = MessageBox.Show("Hapus item ini?", "Hapus item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            dataGridView3.Rows.Remove(row);
                            i--;
                            btnCheckout.Text = "Checkout (" + i + ")";
                        }
                        else
                        {
                            jml = 1;
                        }
                    }
                    else
                    {
                        HA = hrg * jml;
                        row.Cells[6].Value = jml;
                        row.Cells[5].Value = stok;
                        row.Cells[4].Value = HA;
                    }
                }
                dataGridView3.Columns[4].DefaultCellStyle.Format = "###,##0";
                dataGridView1.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                foreach (DataGridViewRow rows in dataGridView3.Rows)
                {
                    double HT1 = Convert.ToDouble(rows.Cells[4].Value.ToString());
                    HT2 = HT2 + HT1;
                }
                lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", HT2);
            }
            else
            {
                return;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult d;
                double HT2 = 0.0;
                d = MessageBox.Show("Checkout keranjang ini?", "Checkout item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        double HT1 = split(row.Cells[4].Value.ToString());
                        HT2 = HT2 + HT1;
                    }
                    tbTotal.Text = string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                    btnCheckout.Text = "Checked out";
                    btnCheckout.Enabled = false;
                    btnTambah.Enabled = false;
                    btnBatal.Enabled = false;
                    btnTambah.Enabled = true;
                     clear();
                    cbObat.Enabled = false;
                    tbJumlah.Enabled = false;
                    enable();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_pembelian FROM tbTrPembelian ORDER BY id_pembelian DESC";
            string id = autogenerateID("TRB", query);
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                double hargatotal = Convert.ToDouble(tbTotal.Text);

                DateTime now = DateTime.Now;
                string supplier = cbSupplier.SelectedValue.ToString();
                int status = 1;
                //insert Ke tabel Transaksi Pelanggan
                SqlCommand insert = new SqlCommand("sp_InputTransaksiBeli1", con);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_pembelian", id);
                insert.Parameters.AddWithValue("id_supplier", supplier);
                insert.Parameters.AddWithValue("tgl_pembelian", now);
                insert.Parameters.AddWithValue("total_harga_beli", hargatotal);

                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
                //ubah stock pakaian yang direturn+qty baju yang direturn
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    con.Open();
                    string idp = row.Cells["ID"].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells["Kuantitas"].Value);
                    SqlCommand ustock = new SqlCommand("sp_UpdateStock1", con);
                    ustock.CommandType = CommandType.StoredProcedure;
                    ustock.Parameters.AddWithValue("id1", id);
                    ustock.Parameters.AddWithValue("id2", idp);
                    ustock.Parameters.AddWithValue("qty", qty);
                    try
                    {
                        ustock.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to saved stock obat1: " + ex.Message);
                    }
                    con.Close();
                }
                MessageBox.Show("Data berhasil disimpan dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                batalll();
                i = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved stock obat: " + ex.Message);
            }
        }

        private void tbTotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void clear()
        {
            cbSupplier.SelectedValue = -1;
            cbObat.SelectedValue = -1;
            tbHarga.Text = "";
            tbSisa.Text = "";
            tbTotalHarga.Text = "";
            tbJumlah.Text = "";
        }

        private void disable()
        {
            tbTotal.Enabled = false;
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
            btnCheckout.Text = "Checkout (0)";
            btnTambah.Enabled = false;
        }

        private void batalll()
        {
            clear();
            dataGridView3.Rows.Clear();
            disable();
            tbTotal.Text = "0";
            btnCheckout.Enabled = true;
            btnCheckout.Text = "Checkout (0)";
            lblSubTotal.Text = "Subtotal : Rp.0";
            cbObat.Enabled = true;
            tbJumlah.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = true;
            btnSimpan.Enabled = false;
            cbSupplier.Enabled = true;
           
        }
        private void enable()
        {
            btnBatal.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            batalll();
        }
    }
}
