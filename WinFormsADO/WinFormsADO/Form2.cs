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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HastakayitDB;Persist Security Info=True;User ID=sa;Password=1");

        SqlCommand cmdSelect = new SqlCommand("SELECT HastaID, AdSoyad, Adres, Telefon, Sikayetler, Tarih, AktifMi, BorcTutari FROM Hastalar WHERE AktifMi = 0");

        SqlDataAdapter adapter = new SqlDataAdapter();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Height = 400;
            this.Width = 750;

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            cmdSelect.Connection = conn;
            adapter.SelectCommand = cmdSelect;

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgwPasifListesi.DataSource = dt;
        }


    }
}
