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
    public partial class Form_MKategori : Form
    {
        
        public Form_MKategori()
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
                tbKeterangan.Text = "";

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
                    SqlCommand view = new SqlCommand("sp_LoadKategori", connection);
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

                dataGridView1.Columns[0].HeaderCell.Value = "ID Kategori";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Kategori";
                dataGridView1.Columns[2].HeaderCell.Value = "Keterangan";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT TOP 1 id_kategori FROM mKategori ORDER BY id_kategori DESC";
            string id = autogenerateID("KT", query);
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
                tbKeterangan.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_kategori FROM mKategori ORDER BY id_kategori DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            string id = autogenerateID("KT", query);
            SqlCommand insert = new SqlCommand("sp_InputKategori", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_kategori", id);
            insert.Parameters.AddWithValue("nama_kategori", tbNama.Text);
            insert.Parameters.AddWithValue("keterangan", tbKeterangan.Text);


            string nama = tbNama.Text;
            string keterangan = tbKeterangan.Text;

            if (nama == "" || keterangan == "")
            {
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Kategori Obat Berhasil Ditambahkan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Data Kategori Obat Gagal Ditambahkan: " + ex.Message);
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
                com.CommandText = "sp_DeleteKategori";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_kategori", tbCari.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data Kategori Obat berhasil!", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                else
                {
                    MessageBox.Show("Delete data Kategori Obat gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string query = "SELECT TOP 1 id_kategori FROM mKategori ORDER BY id_kategori DESC";
                string id = autogenerateID("KT", query);
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = "sp_UpdateKategori";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_kategori", tbCari.Text);
                com.Parameters.AddWithValue("@nama_kategori", tbNama.Text);
                com.Parameters.AddWithValue("@keterangan", tbKeterangan.Text);

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Update Data Kategori Obat Berhasil");
                    clear();
                }
                else
                {
                    MessageBox.Show("Update Data Kategori Obat Gagal !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            
        }

        private void btnCari_Click(object sender, EventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariKategori", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID Kategori";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Kategori";
                dataGridView1.Columns[2].HeaderCell.Value = "Keterangan";

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

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Nama Kategori Tidak Boleh Kosong !");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else 
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "Betul !");
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form_DBAdmin admin = new Form_DBAdmin();
            this.Hide();
            admin.Show();
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            tbCari.Text = "";
            tbNama.Text = "";
            tbKeterangan.Text = "";
        }
    }
}

