using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cms;
using Mysqlx.Session;

namespace kutuphane
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();

            LoadKitaplar();
        }

        string connection_string = "Server=localhost;Database=kutuphane;Uid=root;Pwd='';";

        private void form2_Load(object sender, EventArgs e)
        {

        }
        private void LoadKitaplar()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "SELECT rol FROM kullanicilar_tablosu WHERE isim = @isim AND sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataGridView_kitaplar.DataSource = dt;

                        DataGridView_kitaplar.Columns["kitap_id"].HeaderText = "ID";
                        DataGridView_kitaplar.Columns["isim"].HeaderText = "Kitap Adi";
                        DataGridView_kitaplar.Columns["yazar"].HeaderText = "Yazar";
                        DataGridView_kitaplar.Columns["yayin_evi"].HeaderText = "Yayin Evi";
                        DataGridView_kitaplar.Columns["basim_yili"].HeaderText = "Basim yili";
                        DataGridView_kitaplar.Columns["tur"].HeaderText = "Tur";

                        DataGridView_kitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yuklenmedi " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            LoadKitaplar();
            MessageBox.Show("refreshed", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtara.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadKitaplar();
                return;
            }

            if (combatur.SelectedItem == null)
            {
                MessageBox.Show("bir tur sec", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchField = combatur.SelectedItem.ToString();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "SELECT rol FROM kullanicilar_tablosu WHERE isim = @isim AND sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" +  searchText + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataGridView_kitaplar.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yuklenmedi " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combatur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
