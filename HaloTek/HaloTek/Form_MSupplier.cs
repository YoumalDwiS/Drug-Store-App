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
    public partial class Form_MSupplier : Form
    {
        public Form_MSupplier()
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_supplier FROM mSupplier ORDER BY id_supplier DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            string id = autogenerateID("SP", query);
            SqlCommand insert = new SqlCommand("sp_InputSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_supplier", id);
            insert.Parameters.AddWithValue("nama_supplier", tbNama.Text);
            insert.Parameters.AddWithValue("telp_supplier", tbNoTelp.Text);
            insert.Parameters.AddWithValue("alamat", tbAlamat.Text);
            insert.Parameters.AddWithValue("status_supplier", "");


            string nama = tbNama.Text;
            string telp = tbNoTelp.Text;
            string alamat = tbAlamat.Text;

            if (telp.Length > 13 || telp.Length < 8)
            {
                MessageBox.Show("Panjang digit no telepon tidak memenuhi standar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nama == "" || telp == "" || alamat == "")
            {
                MessageBox.Show("Seluruh data wajib diisi !", "Peringatan !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else{


                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Supplier Berhasil Ditambahkan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
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
                com.CommandText = "sp_HapusSupplier";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_supplier", tbCari.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data supplier berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                else
                {
                    MessageBox.Show("Delete data supplier gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string query = "SELECT TOP 1 id_supplier FROM mSupplier ORDER BY id_supplier DESC";
                string id = autogenerateID("SP", query);
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = "sp_UpdateSupplier";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_supplier", tbCari.Text);
                com.Parameters.AddWithValue("@nama_supplier", tbNama.Text);
                com.Parameters.AddWithValue("@telp_supplier", tbNoTelp.Text);
                com.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                

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
        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbNama.Text = "";
                tbAlamat.Text = "";
                tbNoTelp.Text = "";

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
                    SqlCommand view = new SqlCommand("sp_LoadSupplier", connection);
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

                dataGridView1.Columns[0].HeaderCell.Value = "ID Supplier";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Supplier";
                dataGridView1.Columns[2].HeaderCell.Value = "No Telepon";
                dataGridView1.Columns[3].HeaderCell.Value = "Alamat";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
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
                    SqlCommand view = new SqlCommand("sp_CariSupplier", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID Supplier";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Supplier";
                dataGridView1.Columns[2].HeaderCell.Value = "No Telepon";
                dataGridView1.Columns[3].HeaderCell.Value = "Alamat";
                

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

        private void Form_MSupplier_Load(object sender, EventArgs e)
        {
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
            string query = "SELECT TOP 1 id_supplier FROM mSupplier ORDER BY id_supplier DESC";
            string id = autogenerateID("SP", query);
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
                tbNoTelp.Text = row.Cells[2].Value.ToString();
                tbAlamat.Text = row.Cells[3].Value.ToString();
                
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

        
        
        

        private void tbNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
            tbNama.Text = "";
            tbCari.Text = "";
            tbNoTelp.Text = "";
            tbAlamat.Text = "";
        }

        private void tbNoTelp_Leave(object sender, EventArgs e)
        {
            if (tbNoTelp.Text == "")
            {
                MessageBox.Show("Nomor Telepon Tidak Boleh Kosong", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                MessageBox.Show("Nama Supplier Tidak Boleh Kosong", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
