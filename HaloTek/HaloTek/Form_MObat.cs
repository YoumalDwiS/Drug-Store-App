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
    public partial class Form_MObat : Form
    {
        
        
        public Form_MObat()
        {
            InitializeComponent();
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

        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbNama.Text = "";
                tbHarga.Text = "";
                tbStok.Text = "";
                cbDosis.SelectedIndex = -1;
                cbJenis.SelectedIndex = -1;
                cbKategori.SelectedIndex = -1;
                tbKandungan.Text = "";
                dtExpDate.Format = DateTimePickerFormat.Custom;
                tbCari.Text = "";

                btnUbah.Enabled = false;
                btnHapus.Enabled = false;
                btnSimpan.Enabled = true;
                // DataTable st = new DataTable();
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
        public double split(String x)
        {
            String[] a = x.Split('.');
            //String[] b = a[1].Split('.');
            //String[] c = b[1].Split(',');
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_obat FROM mObat ORDER BY id_obat DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            string id = autogenerateID("OB", query);
            SqlCommand insert = new SqlCommand("sp_InputObat", connection);

            double harga = Convert.ToDouble(tbHarga.Text);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_obat", id);
            insert.Parameters.AddWithValue("nama_obat", tbNama.Text);
            insert.Parameters.AddWithValue("id_kategori", cbKategori.SelectedValue.ToString());
            insert.Parameters.AddWithValue("kandungan", tbKandungan.Text);
            insert.Parameters.AddWithValue("jenis", cbJenis.SelectedItem.ToString());
            insert.Parameters.AddWithValue("dosis", cbDosis.SelectedItem.ToString());
            insert.Parameters.AddWithValue("exp_date", dtExpDate.Value);
            insert.Parameters.AddWithValue("stok", tbStok.Text);
            insert.Parameters.AddWithValue("harga", harga);

            string kategori = cbKategori.SelectedValue.ToString();
            string jenis = cbJenis.SelectedItem.ToString();
            string dosis = cbDosis.SelectedItem.ToString();


            if (tbNama.Text == "" || kategori == "" || tbKandungan.Text == "" || jenis == "" || 
                dosis == "" || dtExpDate.Value == null || tbStok.Text == "" || tbHarga.Text == "" )
            {
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Obat Berhasil Ditambahkan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(@connectionString);
                SqlCommand com = new SqlCommand();

                com.Connection = connection;
                com.CommandText = "sp_HapusObat";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_obat", tbCari.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data obat berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                else
                {
                    MessageBox.Show("Delete data obat gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT TOP 1 id_obat FROM mObat ORDER BY id_obat DESC";
                string id = autogenerateID("OB", query);
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = "sp_UpdateObat";
                com.CommandType = CommandType.StoredProcedure;

                double harga = split(tbHarga.Text);

                com.Parameters.AddWithValue("id_obat", tbCari.Text);
                com.Parameters.AddWithValue("nama_obat", tbNama.Text);
                com.Parameters.AddWithValue("id_kategori", cbKategori.SelectedValue.ToString());
                com.Parameters.AddWithValue("kandungan", tbKandungan.Text);
                com.Parameters.AddWithValue("jenis", cbJenis.SelectedItem.ToString());
                com.Parameters.AddWithValue("dosis", cbDosis.SelectedItem.ToString());
                com.Parameters.AddWithValue("exp_date", dtExpDate.Value.Date);
                com.Parameters.AddWithValue("stok", tbStok.Text);
                com.Parameters.AddWithValue("harga", harga);

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Update data berhasil");
                    clear();
                }
                else
                {
                    MessageBox.Show("Update data gagal");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbCari.Text;

                try
                {
                    string connectionString = "integrated security = true; data source =.; initial catalog = dbHalotek";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariObat", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    con.Close();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form_MObat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetKategori.mKategori' table. You can move, or remove it, as needed.
            this.mKategoriTableAdapter.Fill(this.datasetKategori.mKategori);

            try
            {

                LoadData();
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT TOP 1 id_obat FROM mObat ORDER BY id_obat DESC";
            string id = autogenerateID("OB", query);
            btnSimpan.Enabled = false;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
          
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                id = row.Cells[0].Value.ToString();
                tbCari.Text = id;
               
                tbNama.Text = row.Cells[1].Value.ToString();
                cbKategori.SelectedValue = row.Cells[2].Value.ToString();
                tbKandungan.Text = row.Cells[3].Value.ToString();
                cbJenis.SelectedItem = row.Cells[4].Value.ToString();
                cbDosis.SelectedItem = row.Cells[5].Value.ToString();
                dtExpDate.Value = Convert.ToDateTime(row.Cells[6].Value);
                tbStok.Text = row.Cells[7].Value.ToString();
                tbHarga.Text =row.Cells[8].Value.ToString();
                


            }
        }

        private void tbStok_Leave(object sender, EventArgs e)
        {
           if(tbStok.Text == "")
           {
                MessageBox.Show("Stok Obat Tidak Boleh Kosong !", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form_DBAdmin admin = new Form_DBAdmin();
            this.Hide();
            admin.Show();
        }

        private void tbStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void clear()
        {
            tbCari.Text = "";
            tbNama.Text = "";
            cbKategori.SelectedValue = -1;
            tbKandungan.Text = "";
            cbJenis.SelectedValue = -1;
            cbDosis.SelectedValue = -1;
            dtExpDate.Value = DateTime.Now;
            tbStok.Text = "";
            tbHarga.Text = "";
            

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            if(tbHarga.Text == "")
            {
                return;
            }
            else
            {
                tbHarga.Text = string.Format("{0:n0}", double.Parse(tbHarga.Text));
                tbHarga.SelectionStart = tbHarga.Text.Length;
            }
        }
    }
}
