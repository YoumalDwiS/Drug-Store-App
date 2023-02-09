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
    public partial class Form_MResep : Form
    {
        public Form_MResep()
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
                cbCustomer.SelectedIndex = -1;
                tbNamaDokter.Text = "";
                tbKandungan.Text = "";
                tbPraktek.Text = "";

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
                    SqlCommand view = new SqlCommand("sp_LoadResep", connection);
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

                dataGridView1.Columns[0].HeaderCell.Value = "ID Resep";
                dataGridView1.Columns[1].HeaderCell.Value = "ID Customer";
                dataGridView1.Columns[2].HeaderCell.Value = "Nama Dokter";
                dataGridView1.Columns[3].HeaderCell.Value = "Tempat Praktek";
                dataGridView1.Columns[4].HeaderCell.Value = "Deskripsi";
                dataGridView1.Columns[5].HeaderCell.Value = "Tanggal Input";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_resep FROM mResep ORDER BY id_resep DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            string id = autogenerateID("RSP", query);
            SqlCommand insert = new SqlCommand("sp_InputResep", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_resep", id);
            insert.Parameters.AddWithValue("id_customer", cbCustomer.SelectedValue);
            insert.Parameters.AddWithValue("nama_dokter", tbNamaDokter.Text);
            insert.Parameters.AddWithValue("praktek", tbPraktek.Text);
            insert.Parameters.AddWithValue("kandungan", tbKandungan.Text);
            insert.Parameters.AddWithValue("tgl_input", dtTglInput.Value);




            if (cbCustomer.SelectedValue.ToString() == "" || tbNamaDokter.Text == "" || tbPraktek.Text == "" || tbKandungan.Text == "" ||
                dtTglInput.Value == null)
            {
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Resep Berhasil Ditambahkan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT TOP 1 id_resep FROM mResep ORDER BY id_resep DESC";
                string id = autogenerateID("RSP", query);
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = "sp_UpdateResep";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_resep", tbCari.Text);
                com.Parameters.AddWithValue("@id_customer", cbCustomer.SelectedValue);
                com.Parameters.AddWithValue("@nama_dokter", tbNamaDokter.Text);
                com.Parameters.AddWithValue("@praktek", tbPraktek.Text);
                com.Parameters.AddWithValue("@kandungan", tbKandungan.Text);
                com.Parameters.AddWithValue("@tgl_input", dtTglInput.Value);

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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(@connectionString);
                SqlCommand com = new SqlCommand();

                com.Connection = connection;
                com.CommandText = "sp_HapusResep";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_resep", tbCari.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data resep berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     clear();

                }
                else
                {
                    MessageBox.Show("Delete data resep gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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
                    SqlCommand view = new SqlCommand("sp_CariResep", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID Resep";
                dataGridView1.Columns[1].HeaderCell.Value = "ID Customer";
                dataGridView1.Columns[2].HeaderCell.Value = "Nama Dokter";
                dataGridView1.Columns[3].HeaderCell.Value = "Tempat Praktek";
                dataGridView1.Columns[4].HeaderCell.Value = "Deskripsi";
                dataGridView1.Columns[5].HeaderCell.Value = "Tanggal Input";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Form_MResep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetCustomer.sp_LoadCustomer' table. You can move, or remove it, as needed.
            this.sp_LoadCustomerTableAdapter.Fill(this.datasetCustomer.sp_LoadCustomer);

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
            string query = "SELECT TOP 1 id_resep FROM mResep ORDER BY id_resep DESC";
            string id = autogenerateID("RSP", query);
            btnSimpan.Enabled = false;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                id = row.Cells[0].Value.ToString();
                tbCari.Text = id;
                cbCustomer.SelectedValue = row.Cells[1].Value.ToString();
                tbNamaDokter.Text = row.Cells[2].Value.ToString();
                tbPraktek.Text = row.Cells[3].Value.ToString();
                tbKandungan.Text = row.Cells[4].Value.ToString();
                dtTglInput.Value = Convert.ToDateTime(row.Cells[5].Value);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form_DBKasir kasir = new Form_DBKasir();
            this.Close();
            kasir.Show();
        }

        private void tbNamaDokter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPraktek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void clear()
        {
            tbCari.Text = "";
            tbKandungan.Text = "";
            tbPraktek.Text = "";
            cbCustomer.SelectedValue = -1;
            dtTglInput.Value = DateTime.Now;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
 }
        
    

