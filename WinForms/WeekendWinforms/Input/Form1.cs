using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input
{
    public partial class frmInput : Form
    {




        public frmInput()
        {
            InitializeComponent();
        }

        private void lblFiyat_Click(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            this.txtUrunAd.Text = DateTime.Now.ToString();

            MessageBox.Show("Hoşgeldiniz...");
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
          DialogResult result =  fileDialogDosyaSec.ShowDialog();

            if (result == DialogResult.OK) 
                imgFoto.Image = Image.FromFile(fileDialogDosyaSec.FileName);
 
        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOzellik_TextChanged(object sender, EventArgs e)
        {

        }

        private void numFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMagaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInput_Activated(object sender, EventArgs e)
        {

        }

        private void fileDialogDosyaSec_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void frmInput_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmInput_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult cevap = MessageBox.Show("Çıkmak istediğinize emin misiniz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show("Çıkış iptal edildi.");
            }
            else
            {
                MessageBox.Show("Hoşçakalın...");
            }


        }

        private void frmInput_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("sdfsdfsd");
        }
    }
}
