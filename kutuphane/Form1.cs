using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cms;
using Mysqlx.Session;


namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connection_string = "Server=localhost;Database=kutuphane;Uid=root;Pwd='';";

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string isim = textBox_kullanici_adi.Text.Trim();
            string sifre = textBox_sifre.Text.Trim();

            if (String.IsNullOrEmpty(isim) || String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Please enter your username and password", "uyari",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(isim, sifre))
            {
                MessageBox.Show("Login succesfull", "uyari",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                form2 form2 = new form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "uyari",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_sifre.Clear();
                textBox_kullanici_adi.Focus();
            }
        }

        private bool AuthenticateUser(string isim, string sifre)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "SELECT rol FROM kullanicilar_tablosu WHERE isim = @isim AND sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@sifre", isim);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            return false;
                        }

                        string rol = result.ToString();

                        if (rol.ToLower() == "kullanici")
                        {
                            return true;
                        }
                        else if (rol.ToLower() == "admin")
                        {
                            MessageBox.Show("You do not have access", "uyari",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid user role", "uyari",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("database conntection error " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Form1_FormClosing(string sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan cikmak istediginizde eminmisiniz", "Cikis",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }

        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string admin_isim = txtAdminKadi.Text.Trim();
            string admin_sifre = txtAdminsifre.Text.Trim();

            if (string.IsNullOrEmpty(admin_isim) || string.IsNullOrEmpty(admin_sifre))
            {
                MessageBox.Show("Please enter your username and password", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateAdmin(admin_isim, admin_sifre))
            {
                MessageBox.Show("Admin Login succesfull", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Admin username or password", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_sifre.Clear();
                textBox_kullanici_adi.Focus();
            }
        }

        private bool AuthenticateAdmin(string admin_isim, string admin_sifre)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "SELECT rol FROM kullanicilar_tablosu WHERE isim = @isim AND sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isim", admin_isim);
                        cmd.Parameters.AddWithValue("@sifre", admin_sifre);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            return false;
                        }

                        string rol = result.ToString();

                        if (rol.ToLower() == "admin")
                        {
                            return true;
                        }
                        if (rol.ToLower() == "kullanici")
                        {
                            MessageBox.Show("You do not have access", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid user role", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("database conntection error " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
