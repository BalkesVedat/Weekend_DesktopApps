using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class frmHesapMAk : Form
    {
        public frmHesapMAk()
        {
            InitializeComponent();
        }

        private void frmHesapMAk_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 500);
        }

        private void RakamGoster(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = string.Empty;
            }

            txtEkran.Text += ((Button)sender).Text;
        }

        private void Oprt(object sender, EventArgs e)
        { 
            Button btn = (Button)sender;

            MessageBox.Show(btn.Text);
        
        }

    }
}
