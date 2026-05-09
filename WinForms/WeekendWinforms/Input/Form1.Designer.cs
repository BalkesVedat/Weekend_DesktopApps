namespace Input
{
    partial class frmInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lbMagaza = new System.Windows.Forms.ListBox();
            this.lblMagaza = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.lblKdvOran = new System.Windows.Forms.Label();
            this.chkBeyaz = new System.Windows.Forms.CheckBox();
            this.chkPembe = new System.Windows.Forms.CheckBox();
            this.chkKirmizi = new System.Windows.Forms.CheckBox();
            this.chkGri = new System.Windows.Forms.CheckBox();
            this.chkMavi = new System.Windows.Forms.CheckBox();
            this.chkSiyah = new System.Windows.Forms.CheckBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblOzellik = new System.Windows.Forms.Label();
            this.txtOzellik = new System.Windows.Forms.TextBox();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.fileDialogDosyaSec = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(260, 78);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(395, 38);
            this.txtUrunAd.TabIndex = 0;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(65, 84);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(124, 32);
            this.lblUrunAd.TabIndex = 1;
            this.lblUrunAd.Text = "Ürün Adı";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(65, 140);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(113, 32);
            this.lblMarka.TabIndex = 3;
            this.lblMarka.Text = "Markası";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(260, 135);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(395, 38);
            this.txtMarka.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(65, 196);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(99, 32);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Modeli";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(260, 192);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(395, 38);
            this.txtModel.TabIndex = 4;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(65, 252);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(83, 32);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyatı";
            this.lblFiyat.Click += new System.EventHandler(this.lblFiyat_Click);
            // 
            // numFiyat
            // 
            this.numFiyat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFiyat.Location = new System.Drawing.Point(260, 249);
            this.numFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(395, 38);
            this.numFiyat.TabIndex = 8;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Temel Gıda",
            "Elektronik",
            "Temizlik Ürünü",
            "Tekstil",
            "Kozmetik",
            "Ayakkabı",
            "Vasıta",
            "Bilgisayar"});
            this.cmbKategori.Location = new System.Drawing.Point(260, 306);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(395, 39);
            this.cmbKategori.TabIndex = 9;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(65, 308);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(121, 32);
            this.lblKategori.TabIndex = 10;
            this.lblKategori.Text = "Kategori";
            // 
            // lbMagaza
            // 
            this.lbMagaza.FormattingEnabled = true;
            this.lbMagaza.ItemHeight = 31;
            this.lbMagaza.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Adana",
            "Erzurum",
            "Diyarbakır",
            "Kayseri",
            "Bursa",
            "Antalya",
            "Trabzon",
            "Bodrum"});
            this.lbMagaza.Location = new System.Drawing.Point(260, 364);
            this.lbMagaza.Name = "lbMagaza";
            this.lbMagaza.Size = new System.Drawing.Size(395, 190);
            this.lbMagaza.TabIndex = 11;
            // 
            // lblMagaza
            // 
            this.lblMagaza.AutoSize = true;
            this.lblMagaza.Location = new System.Drawing.Point(65, 364);
            this.lblMagaza.Name = "lblMagaza";
            this.lblMagaza.Size = new System.Drawing.Size(115, 32);
            this.lblMagaza.TabIndex = 12;
            this.lblMagaza.Text = "Mağaza";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(260, 582);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(92, 36);
            this.rb1.TabIndex = 13;
            this.rb1.TabStop = true;
            this.rb1.Text = "%1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(387, 582);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(108, 36);
            this.rb10.TabIndex = 14;
            this.rb10.TabStop = true;
            this.rb10.Text = "%10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(531, 582);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(108, 36);
            this.rb20.TabIndex = 15;
            this.rb20.TabStop = true;
            this.rb20.Text = "%20";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // lblKdvOran
            // 
            this.lblKdvOran.AutoSize = true;
            this.lblKdvOran.Location = new System.Drawing.Point(65, 586);
            this.lblKdvOran.Name = "lblKdvOran";
            this.lblKdvOran.Size = new System.Drawing.Size(122, 32);
            this.lblKdvOran.TabIndex = 16;
            this.lblKdvOran.Text = "KDV (%)";
            // 
            // chkBeyaz
            // 
            this.chkBeyaz.AutoSize = true;
            this.chkBeyaz.Location = new System.Drawing.Point(260, 650);
            this.chkBeyaz.Name = "chkBeyaz";
            this.chkBeyaz.Size = new System.Drawing.Size(131, 36);
            this.chkBeyaz.TabIndex = 17;
            this.chkBeyaz.Text = "Beyaz";
            this.chkBeyaz.UseVisualStyleBackColor = true;
            // 
            // chkPembe
            // 
            this.chkPembe.AutoSize = true;
            this.chkPembe.Location = new System.Drawing.Point(513, 734);
            this.chkPembe.Name = "chkPembe";
            this.chkPembe.Size = new System.Drawing.Size(142, 36);
            this.chkPembe.TabIndex = 18;
            this.chkPembe.Text = "Pembe";
            this.chkPembe.UseVisualStyleBackColor = true;
            // 
            // chkKirmizi
            // 
            this.chkKirmizi.AutoSize = true;
            this.chkKirmizi.Location = new System.Drawing.Point(260, 734);
            this.chkKirmizi.Name = "chkKirmizi";
            this.chkKirmizi.Size = new System.Drawing.Size(138, 36);
            this.chkKirmizi.TabIndex = 19;
            this.chkKirmizi.Text = "Kırmızı";
            this.chkKirmizi.UseVisualStyleBackColor = true;
            // 
            // chkGri
            // 
            this.chkGri.AutoSize = true;
            this.chkGri.Location = new System.Drawing.Point(513, 692);
            this.chkGri.Name = "chkGri";
            this.chkGri.Size = new System.Drawing.Size(90, 36);
            this.chkGri.TabIndex = 20;
            this.chkGri.Text = "Gri";
            this.chkGri.UseVisualStyleBackColor = true;
            // 
            // chkMavi
            // 
            this.chkMavi.AutoSize = true;
            this.chkMavi.Location = new System.Drawing.Point(513, 650);
            this.chkMavi.Name = "chkMavi";
            this.chkMavi.Size = new System.Drawing.Size(112, 36);
            this.chkMavi.TabIndex = 21;
            this.chkMavi.Text = "Mavi";
            this.chkMavi.UseVisualStyleBackColor = true;
            // 
            // chkSiyah
            // 
            this.chkSiyah.AutoSize = true;
            this.chkSiyah.Location = new System.Drawing.Point(260, 692);
            this.chkSiyah.Name = "chkSiyah";
            this.chkSiyah.Size = new System.Drawing.Size(124, 36);
            this.chkSiyah.TabIndex = 22;
            this.chkSiyah.Text = "Siyah";
            this.chkSiyah.UseVisualStyleBackColor = true;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(67, 650);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(80, 32);
            this.lblRenk.TabIndex = 23;
            this.lblRenk.Text = "Renk";
            // 
            // lblOzellik
            // 
            this.lblOzellik.AutoSize = true;
            this.lblOzellik.Location = new System.Drawing.Point(65, 808);
            this.lblOzellik.Name = "lblOzellik";
            this.lblOzellik.Size = new System.Drawing.Size(140, 32);
            this.lblOzellik.TabIndex = 25;
            this.lblOzellik.Text = "Özellikleri";
            // 
            // txtOzellik
            // 
            this.txtOzellik.Location = new System.Drawing.Point(260, 802);
            this.txtOzellik.Multiline = true;
            this.txtOzellik.Name = "txtOzellik";
            this.txtOzellik.Size = new System.Drawing.Size(395, 255);
            this.txtOzellik.TabIndex = 24;
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(961, 78);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(701, 390);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFoto.TabIndex = 26;
            this.imgFoto.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(968, 495);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(179, 71);
            this.btnResimSec.TabIndex = 27;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // fileDialogDosyaSec
            // 
            this.fileDialogDosyaSec.FileName = "openFileDialog1";
            this.fileDialogDosyaSec.Title = "Resim Seçimi";
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1137);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.lblOzellik);
            this.Controls.Add(this.txtOzellik);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.chkSiyah);
            this.Controls.Add(this.chkMavi);
            this.Controls.Add(this.chkGri);
            this.Controls.Add(this.chkKirmizi);
            this.Controls.Add(this.chkPembe);
            this.Controls.Add(this.chkBeyaz);
            this.Controls.Add(this.lblKdvOran);
            this.Controls.Add(this.rb20);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblMagaza);
            this.Controls.Add(this.lbMagaza);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.txtUrunAd);
            this.Name = "frmInput";
            this.Text = "Ürün Kayıt Formu";
            this.Load += new System.EventHandler(this.frmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ListBox lbMagaza;
        private System.Windows.Forms.Label lblMagaza;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb20;
        private System.Windows.Forms.Label lblKdvOran;
        private System.Windows.Forms.CheckBox chkBeyaz;
        private System.Windows.Forms.CheckBox chkPembe;
        private System.Windows.Forms.CheckBox chkKirmizi;
        private System.Windows.Forms.CheckBox chkGri;
        private System.Windows.Forms.CheckBox chkMavi;
        private System.Windows.Forms.CheckBox chkSiyah;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblOzellik;
        private System.Windows.Forms.TextBox txtOzellik;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.OpenFileDialog fileDialogDosyaSec;
    }
}

