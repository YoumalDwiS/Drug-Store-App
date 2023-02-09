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
    public partial class Form_MUser : Form
    {
        public Form_MUser()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT TOP 1 id_user FROM mUser1 ORDER BY id_user DESC";
            string id = autogenerateID("US", query);
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
                tbUsername.Text = row.Cells[2].Value.ToString();
                cbJabatan.SelectedItem = row.Cells[3].Value.ToString();
                tbNoTelp.Text = row.Cells[4].Value.ToString();

            }
        }

        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbNama.Text = "";
                tbUsername.Text = "";
                tbPassword.Text = "";
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
                    SqlCommand view = new SqlCommand("sp_LoadUser1", connection);
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

                dataGridView1.Columns[0].HeaderCell.Value = "ID User";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama User";
                dataGridView1.Columns[2].HeaderCell.Value = "Username";
                dataGridView1.Columns[3].HeaderCell.Value = "Jabatan";
                dataGridView1.Columns[4].HeaderCell.Value = "No Telepon";
              
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=dbHalotek;Integrated Security=True";
            string query = "SELECT TOP 1 id_user FROM mUser1 ORDER BY id_user DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            string id = autogenerateID("US", query);
            SqlCommand insert = new SqlCommand("sp_InputUser1", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_user", id);
            insert.Parameters.AddWithValue("nama_user", tbNama.Text);
            insert.Parameters.AddWithValue("username", tbUsername.Text);
            insert.Parameters.AddWithValue("password", tbPassword.Text);
            insert.Parameters.AddWithValue("jabatan", cbJabatan.SelectedItem);
            insert.Parameters.AddWithValue("telp_user", tbNoTelp.Text);
            insert.Parameters.AddWithValue("status_user", "");



            if (tbPassword.Text != tbRePassword.Text)
            {
                MessageBox.Show("Password tidak sesuai !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbNama.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || cbJabatan.SelectedItem.ToString() == "" 
                || tbNoTelp.Text == "")
            {
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data User Berhasil Ditambahkan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                     clear();
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
                string query = "SELECT TOP 1 id_user FROM mUser1 ORDER BY id_user DESC";
                string id = autogenerateID("US", query);
                string connectionString = "integrated security=true; data source=.; initial catalog=dbHalotek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = "sp_UpdateUser1";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_user", tbCari.Text);
                com.Parameters.AddWithValue("@nama_user", tbNama.Text);
                com.Parameters.AddWithValue("@username", tbUsername.Text);
                com.Parameters.AddWithValue("@password", tbPassword.Text);
                com.Parameters.AddWithValue("@jabatan", cbJabatan.SelectedItem);
                com.Parameters.AddWithValue("@telp_user", tbNoTelp.Text);

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
                com.CommandText = "sp_HapusUser1";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_user", tbCari.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data user berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                else
                {
                    MessageBox.Show("Delete data user gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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
                    SqlCommand view = new SqlCommand("sp_CariUser1", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID User";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama User";
                dataGridView1.Columns[2].HeaderCell.Value = "Username";
                dataGridView1.Columns[3].HeaderCell.Value = "Jabatan";
                dataGridView1.Columns[4].HeaderCell.Value = "No Telepon";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Form_MUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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
        void clear()
        {
            tbCari.Text = "";
            tbNama.Text = "";
            tbNoTelp.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbRePassword.Text = "";
            cbJabatan.SelectedItem = -1;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
