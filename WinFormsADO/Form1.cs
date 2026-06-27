using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HastakayitDB;Persist Security Info=True;User ID=sa;Password=1");

        SqlCommand cmdSelect = new SqlCommand("SELECT HastaID, AdSoyad, Adres, Telefon, Sikayetler, Tarih, AktifMi, BorcTutari FROM Hastalar WHERE AktifMi = 1");

        SqlCommand cmdInsert = new SqlCommand("INSERT INTO Hastalar (AdSoyad, Adres, Telefon, Sikayetler, Tarih, AktifMi, BorcTutari) VALUES (@AdSoyad, @Adres, @Telefon, @Sikayetler, @Tarih, @AktifMi, @BorcTutari)");

        SqlCommand cmdUpdate = new SqlCommand("UPDATE Hastalar SET AdSoyad=@AdSoyad, Adres=@Adres, Telefon=@Telefon, Sikayetler=@Sikayetler, Tarih=@Tarih, AktifMi=@AktifMi, BorcTutari=@BorcTutari WHERE HastaID = @HastaID");

        SqlCommand cmdDelete = new SqlCommand("DELETE FROM Hastalar WHERE HastaID = @HastaID");

        SqlDataAdapter adapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dugme = MessageBox.Show("Kaydı Güncellemek istediğinize emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dugme == DialogResult.Yes)
            {
                cmdUpdate.Connection = conn;
                cmdUpdate.Parameters.Clear();

                cmdUpdate.Parameters.AddWithValue("@HastaID", txtHastaNo.Text);
                cmdUpdate.Parameters.AddWithValue("@AdSoyad", txtHastaAd.Text);
                cmdUpdate.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmdUpdate.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmdUpdate.Parameters.AddWithValue("@Sikayetler", txtSikayet.Text);
                cmdUpdate.Parameters.AddWithValue("@Tarih", dtpTarih.Value);
                cmdUpdate.Parameters.AddWithValue("@AktifMi", chkAktif.Checked);
                cmdUpdate.Parameters.AddWithValue("@BorcTutari", nuBorc.Value);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmdUpdate.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();

                ListeyiYenile();
                FormuTemizle();
                DugmeResetle();

                MessageBox.Show("Kayıt güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncelleme komutu iptal edildi.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            this.Width = 900;

            ListeyiYenile();
            DugmeResetle();
        }

        private void DugmeResetle()
        {
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void ListeyiYenile()
        {
            cmdSelect.Connection = conn;
            adapter.SelectCommand = cmdSelect;

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgwListe.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dugme = MessageBox.Show("Kaydı Eklemek istediğinize emin misiniz?", "Kayıt Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dugme == DialogResult.Yes)
            {

                cmdInsert.Connection = conn;
                cmdInsert.Parameters.Clear();
                cmdInsert.Parameters.AddWithValue("@AdSoyad", txtHastaAd.Text);
                cmdInsert.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmdInsert.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmdInsert.Parameters.AddWithValue("@Sikayetler", txtSikayet.Text);
                cmdInsert.Parameters.AddWithValue("@Tarih", dtpTarih.Value);
                cmdInsert.Parameters.AddWithValue("@AktifMi", chkAktif.Checked);
                cmdInsert.Parameters.AddWithValue("@BorcTutari", nuBorc.Value);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                cmdInsert.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                ListeyiYenile();
                FormuTemizle();
                DugmeResetle();

                MessageBox.Show("Kayıt eklendi.");
            }
            else
            {
                MessageBox.Show("Kayıt ekleme komutu iptal edildi.");
            }
        }

        private void dgwListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("tıklandı");
        }

        private void dgwListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());

            DataGridViewRow row = new DataGridViewRow();

            row = dgwListe.Rows[e.RowIndex];

            row.Selected = true;

            if (row.Cells[0].Value.ToString() != string.Empty && row.Cells[0].Value != null)
            {
                this.txtHastaNo.Text = row.Cells[0].Value.ToString();
                this.txtHastaAd.Text = row.Cells[1].Value.ToString();
                this.txtAdres.Text = row.Cells[2].Value.ToString();
                this.txtTelefon.Text = row.Cells[3].Value.ToString();
                this.txtSikayet.Text = row.Cells[4].Value.ToString();
                this.dtpTarih.Value = (DateTime)row.Cells[5].Value;
                this.chkAktif.Checked = (bool)row.Cells[6].Value;
                this.nuBorc.Value = (decimal)row.Cells[7].Value;

                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           DialogResult dugme = MessageBox.Show("Silmek istediğinize emin misiniz?","Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dugme == DialogResult.Yes)
            {
                cmdDelete.Connection = conn;
                cmdDelete.Parameters.Clear();
                cmdDelete.Parameters.AddWithValue("@HastaID", txtHastaNo.Text);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmdDelete.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();

                ListeyiYenile();
                FormuTemizle();
                DugmeResetle();

                MessageBox.Show("Kayıt Silindi.");
            }
            else
            {
                MessageBox.Show("Silme komutu iptal edildi.");
            }

        }

        public void FormuTemizle()
        { 
            txtHastaNo.Text = string.Empty;
            txtHastaAd.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtSikayet.Text = string.Empty;
            dtpTarih.Value = DateTime.Now;
            chkAktif.Checked = true;
            nuBorc.Value = 0;
        }

        private void btnPasifleriGoster_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.ShowDialog();
        }
    }
}
