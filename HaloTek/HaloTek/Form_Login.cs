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
    public partial class Form_Login : Form
    {
        string returnValue = "";
        string returnValueJabatan = "";
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "integrated security = true; data source =.; initial catalog = dbHalotek";

                SqlConnection connection1 = new SqlConnection(connectionString);
                SqlConnection connection2 = new SqlConnection(connectionString);
                SqlCommand com1 = new SqlCommand();
                SqlCommand com2 = new SqlCommand();

                com1.Connection = connection1;
                com1.CommandText = "sp_login1";
                // Mengatur tipe command yang akan digunakan
                com1.CommandType = CommandType.StoredProcedure;

                //Parameter yang akan dikirimkan ke sp di basis data
                com1.Parameters.AddWithValue("@username", txtUsername.Text);
                com1.Parameters.AddWithValue("@password", txtPassword.Text);

                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connection1.Open();
                    returnValue = (string)com1.ExecuteScalar();
                    connection1.Close();
                }

               /* connection1.Open();
                returnValue = (string)com1.ExecuteScalar();
                connection1.Close(); */


                returnValue = returnValue.Trim(); //Remove whitespace pada isi variable
              //  MessageBox.Show("" + returnValue);


                com2.Connection = connection2;
                com2.CommandText = "sp_LoginRole1";
                // Mengatur tipe command yang akan digunakan
                com2.CommandType = CommandType.StoredProcedure;

                //Parameter yang akan dikirimkan ke sp di basis data
                com2.Parameters.AddWithValue("@jabatan", returnValue);

                connection2.Open();
                returnValueJabatan = (string)com2.ExecuteScalar();
                //returnValueJabatan = returnValueJabatan.Trim();
                connection2.Close();

                //


                if (String.IsNullOrEmpty(returnValue))
                {
                   // MessageBox.Show("Username atau Password salah!" );
                    return;
                }
                else
                {
                    MessageBox.Show("Selamat Datang " + returnValueJabatan, "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Username atau Password salah!" , "Peringatan !",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (returnValueJabatan == "Manager" || returnValueJabatan == "manager")
            {
                //BUKA FORM UNTUK MANAGER NYA
                Form_DBKepala fm = new Form_DBKepala();
                fm.Show();
                this.Hide();
            }

            if (returnValueJabatan == "Admin" || returnValueJabatan == "admin")
            {
                //BUKA FORM UNTUK MANAGER NYA
                Form_DBAdmin fa = new Form_DBAdmin();
                this.Hide();
                fa.Show();
            }
            if (returnValueJabatan == "Kasir" || returnValueJabatan == "kasir")
            {
                //BUKA FORM UNTUK MANAGER NYA
                Form_DBKasir fa = new Form_DBKasir();
                this.Hide();
                fa.Show();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
