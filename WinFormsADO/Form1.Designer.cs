namespace WinFormsADO
{
    partial class Form1
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
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.txtHastaNo = new System.Windows.Forms.TextBox();
            this.lblHastaNo = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.lblAktif = new System.Windows.Forms.Label();
            this.lblBorc = new System.Windows.Forms.Label();
            this.nuBorc = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPasifleriGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBorc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListe
            // 
            this.dgwListe.AllowUserToAddRows = false;
            this.dgwListe.AllowUserToOrderColumns = true;
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(44, 614);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.RowHeadersWidth = 102;
            this.dgwListe.RowTemplate.Height = 40;
            this.dgwListe.Size = new System.Drawing.Size(2269, 607);
            this.dgwListe.TabIndex = 0;
            this.dgwListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellClick);
            this.dgwListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellContentClick);
            // 
            // txtHastaNo
            // 
            this.txtHastaNo.Enabled = false;
            this.txtHastaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaNo.Location = new System.Drawing.Point(269, 56);
            this.txtHastaNo.Name = "txtHastaNo";
            this.txtHastaNo.Size = new System.Drawing.Size(167, 45);
            this.txtHastaNo.TabIndex = 1;
            // 
            // lblHastaNo
            // 
            this.lblHastaNo.AutoSize = true;
            this.lblHastaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaNo.Location = new System.Drawing.Point(75, 55);
            this.lblHastaNo.Name = "lblHastaNo";
            this.lblHastaNo.Size = new System.Drawing.Size(159, 39);
            this.lblHastaNo.TabIndex = 2;
            this.lblHastaNo.Text = "Hasta No";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAd.Location = new System.Drawing.Point(75, 126);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(165, 39);
            this.lblHastaAd.TabIndex = 4;
            this.lblHastaAd.Text = "Hasta Adı";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaAd.Location = new System.Drawing.Point(269, 127);
            this.txtHastaAd.MaxLength = 50;
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(398, 45);
            this.txtHastaAd.TabIndex = 3;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(75, 198);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(106, 39);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(269, 199);
            this.txtAdres.MaxLength = 500;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(696, 146);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(75, 375);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(131, 39);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(269, 376);
            this.txtTelefon.Mask = "(000) 000 00 00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(398, 45);
            this.txtTelefon.TabIndex = 9;
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.Location = new System.Drawing.Point(75, 439);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(175, 39);
            this.lblSikayet.TabIndex = 11;
            this.lblSikayet.Text = "Şikayetleri";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSikayet.Location = new System.Drawing.Point(269, 440);
            this.txtSikayet.MaxLength = 5000;
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSikayet.Size = new System.Drawing.Size(696, 146);
            this.txtSikayet.TabIndex = 10;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(1581, 67);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(182, 39);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "Giriş Tarihi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(1826, 63);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(465, 45);
            this.dtpTarih.TabIndex = 13;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(1826, 135);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(34, 33);
            this.chkAktif.TabIndex = 14;
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktif.Location = new System.Drawing.Point(1581, 132);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(147, 39);
            this.lblAktif.TabIndex = 15;
            this.lblAktif.Text = "Aktif mi?";
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorc.Location = new System.Drawing.Point(1581, 195);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(106, 39);
            this.lblBorc.TabIndex = 16;
            this.lblBorc.Text = "Borcu";
            // 
            // nuBorc
            // 
            this.nuBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuBorc.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nuBorc.Location = new System.Drawing.Point(1826, 198);
            this.nuBorc.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nuBorc.Name = "nuBorc";
            this.nuBorc.Size = new System.Drawing.Size(465, 45);
            this.nuBorc.TabIndex = 17;
            this.nuBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuBorc.ThousandsSeparator = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(1501, 294);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(237, 228);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1777, 294);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(237, 228);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(2054, 294);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(237, 228);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPasifleriGoster
            // 
            this.btnPasifleriGoster.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPasifleriGoster.Location = new System.Drawing.Point(1501, 548);
            this.btnPasifleriGoster.Name = "btnPasifleriGoster";
            this.btnPasifleriGoster.Size = new System.Drawing.Size(812, 55);
            this.btnPasifleriGoster.TabIndex = 21;
            this.btnPasifleriGoster.Text = "Pasif Hastaları Göster";
            this.btnPasifleriGoster.UseVisualStyleBackColor = false;
            this.btnPasifleriGoster.Click += new System.EventHandler(this.btnPasifleriGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2359, 1252);
            this.Controls.Add(this.btnPasifleriGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nuBorc);
            this.Controls.Add(this.lblBorc);
            this.Controls.Add(this.lblAktif);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSikayet);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.lblHastaNo);
            this.Controls.Add(this.txtHastaNo);
            this.Controls.Add(this.dgwListe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBorc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.TextBox txtHastaNo;
        private System.Windows.Forms.Label lblHastaNo;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Label lblAktif;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.NumericUpDown nuBorc;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPasifleriGoster;
    }
}

