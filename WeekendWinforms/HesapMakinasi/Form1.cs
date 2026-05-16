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
        public double _sayi1 { get; set; }
        public double _sayi2 { get; set; }
        public double _sonuc { get; set; }
        public string _islem { get; set; }
        public bool _islemSecildi { get; set; } = false;
        public bool _islemTekrar { get; set; } = false;


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
            if (txtEkran.Text == "0" || _islemSecildi)
            {
                txtEkran.Text = string.Empty;
                _islemSecildi = false;
            }

            txtEkran.Text += ((Button)sender).Text;
        }

        private void Oprt(object sender, EventArgs e)
        {      
            Button btn = (Button)sender;          

            if (_islemTekrar && !_islemSecildi)
            {
                btnEsittir_Click(sender, e);
                _islemSecildi = true;
            }
            else
            {
                _sayi1 = Convert.ToDouble(txtEkran.Text);
                _islem = btn.Text;
               _islemSecildi = true;
            }

            _islemTekrar = true;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (!_islemSecildi)
            {
                _sayi2 = Convert.ToDouble(txtEkran.Text);

                switch (_islem)
                {
                    case "+":
                        _sonuc = _sayi1 + _sayi2;
                        break;
                    case "-":
                        _sonuc = _sayi1 - _sayi2;
                        break;
                    case "x":
                        _sonuc = _sayi1 * _sayi2;
                        break;
                    case "÷":
                        if (_sayi2 != 0)
                            _sonuc = _sayi1 / _sayi2;
                        else
                            _sonuc = 0;

                            break;
                    default:
                        break;
                }

                txtEkran.Text = _sonuc.ToString();
                _sayi1 = _sonuc;
                _islemSecildi = true;
                _islemTekrar = false;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.Length > 1)
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
            else
                txtEkran.Text = "0";          
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            _sayi1 = 0;
            _sayi2 = 0;
            _sonuc = 0;
            _islem = "";
            _islemSecildi = false;
            _islemTekrar = false;
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0" || _islemSecildi)
            {
                txtEkran.Text = "0";
                _islemSecildi = false;
            }

            if (!txtEkran.Text.Contains(","))
                txtEkran.Text += ((Button)sender).Text;

            //if (txtEkran.Text.IndexOf(",")<0)
            //    txtEkran.Text += ((Button)sender).Text;
        }

        private void btnArtiEksi_Click(object sender, EventArgs e)
        {
            string deger = txtEkran.Text.Substring(0,1);

            if (deger == "-")
                txtEkran.Text = txtEkran.Text.Substring(1, txtEkran.Text.Length - 1);
            else 
                txtEkran.Text = "-" + txtEkran.Text;
        }

        private void frmHesapMAk_KeyPress(object sender, KeyPressEventArgs e)
        {
            var bilgi = sender;

           // MessageBox
        }

        private void frmHesapMAk_KeyDown(object sender, KeyEventArgs e)
        {
            var bilgi = sender;
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            var bilgi = sender;
        }

        private void frmHesapMAk_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show(ActiveControl.Text);
        }

        private void btnCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            var bilgi = sender;
            Button btn;

            if ( (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                switch ((int)e.KeyChar)
                {
                    case 48:
                        btn = this.btn0;
                        break;
                    case 49:
                        btn = this.btn1;
                        break;
                    case 50:
                        btn = this.btn2;
                        break;
                    case 51:
                        btn = this.btn3;
                        break;
                    case 52:
                        btn = this.btn4;
                        break;
                    case 53:
                        btn = this.btn5;
                        break;
                    case 54:
                        btn = this.btn6;
                        break;
                    case 55:
                        btn = this.btn7;
                        break;
                    case 56:
                        btn = this.btn8;
                        break;
                    case 57:
                        btn = this.btn9;
                        break;

                    default:
                        btn = this.btnSil;
                        break;
                }

                RakamGoster(btn,e);
            }


        }
    }
}
