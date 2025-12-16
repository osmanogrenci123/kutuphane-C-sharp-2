using MySql.Data.MySqlClient;
using Mysqlx.Session;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string connection_string = "Server=localhost;Database=kutuphane;Uid=root;Pwd='';";
        private int selectedKitapId = -1;
        private int selectedKullaniciId = -1;

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadKitaplar();
            LoadKullanicilar();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnyenile_Click(object sender, EventArgs e)
        {

        }

        private void btnSilKitap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout", "Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }

        }

        private void btnadmincikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadKullanicilar()
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

        // ekle buttonu
        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKitapAdi.Text))
            {
                MessageBox.Show("Please enter your book name", "warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "INSERT INTO kullanicilar_tablosu (isim,yazar,yayin_evi,basim_yilli,tur)" +
                        "VALUES (@isim,@yazar,@yayin_evi)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@isim", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yayin_evi", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@basim_yili", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@tur", txtKitapAdi.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book added", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKitaplar();
                    TemizleTextBoxlar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelleKitap_Click(object sender, EventArgs e)
        {
            if (selectedKitapId == -1)
            {
                MessageBox.Show("Please pick a book to update", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKitapId.Text)) {
                MessageBox.Show("Please enter the book name", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "UPDATE kullanicilar_tablosu SET isim=@isim, yazar=@yazar, yayin_evi=@yayin_evi, basim_yilli=@basim_yilli, tur=@tur, WHERE kitap_id=@kitap_id)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@isim", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazarAdi.Text);
                    cmd.Parameters.AddWithValue("@yayin_evi", txtYayinEvi.Text);
                    cmd.Parameters.AddWithValue("@basim_yili", txtBasimYili.Text);
                    cmd.Parameters.AddWithValue("@tur", txtTur.Text);
                    cmd.Parameters.AddWithValue("@kitap_id", selectedKitapId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book updated succesfully", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKitaplar();
                    TemizleTextBoxlar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
