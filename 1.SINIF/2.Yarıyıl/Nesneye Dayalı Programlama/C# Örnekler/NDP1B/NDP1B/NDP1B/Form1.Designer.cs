namespace NDP1B
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
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_iletisim = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_iletisim = new System.Windows.Forms.Label();
            this.cmb_urun = new System.Windows.Forms.ComboBox();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.btn_ucret = new System.Windows.Forms.Button();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_th = new System.Windows.Forms.TextBox();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_th = new System.Windows.Forms.Label();
            this.lbl_agirlik = new System.Windows.Forms.Label();
            this.txt_agrilik = new System.Windows.Forms.TextBox();
            this.btn_kyıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(96, 31);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(88, 13);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "  Müsteri   Bilgileri";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(99, 65);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(99, 109);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_iletisim
            // 
            this.txt_iletisim.Location = new System.Drawing.Point(99, 153);
            this.txt_iletisim.Name = "txt_iletisim";
            this.txt_iletisim.Size = new System.Drawing.Size(100, 20);
            this.txt_iletisim.TabIndex = 3;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(13, 65);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(22, 13);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "AD";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(16, 109);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(44, 13);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "SOYAD";
            // 
            // lbl_iletisim
            // 
            this.lbl_iletisim.AutoSize = true;
            this.lbl_iletisim.Location = new System.Drawing.Point(16, 159);
            this.lbl_iletisim.Name = "lbl_iletisim";
            this.lbl_iletisim.Size = new System.Drawing.Size(46, 13);
            this.lbl_iletisim.TabIndex = 6;
            this.lbl_iletisim.Text = "TEL NO";
            // 
            // cmb_urun
            // 
            this.cmb_urun.FormattingEnabled = true;
            this.cmb_urun.Items.AddRange(new object[] {
            "SIVI",
            "KATI",
            "GAZ",
            "DEGERLİ"});
            this.cmb_urun.Location = new System.Drawing.Point(342, 31);
            this.cmb_urun.Name = "cmb_urun";
            this.cmb_urun.Size = new System.Drawing.Size(121, 21);
            this.cmb_urun.TabIndex = 7;
            // 
            // lbl_deger
            // 
            this.lbl_deger.AutoSize = true;
            this.lbl_deger.Location = new System.Drawing.Point(266, 31);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(39, 13);
            this.lbl_deger.TabIndex = 8;
            this.lbl_deger.Text = "URUN";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(237, 264);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(44, 13);
            this.lbl_sonuc.TabIndex = 9;
            this.lbl_sonuc.Text = "UCRET";
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Location = new System.Drawing.Point(291, 261);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(290, 20);
            this.txt_sonuc.TabIndex = 10;
            // 
            // btn_ucret
            // 
            this.btn_ucret.Location = new System.Drawing.Point(360, 190);
            this.btn_ucret.Name = "btn_ucret";
            this.btn_ucret.Size = new System.Drawing.Size(121, 43);
            this.btn_ucret.TabIndex = 11;
            this.btn_ucret.Text = "Ucret Hesabı";
            this.btn_ucret.UseVisualStyleBackColor = true;
            this.btn_ucret.Click += new System.EventHandler(this.btn_ucret_Click);
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(360, 87);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(100, 20);
            this.txt_km.TabIndex = 12;
            // 
            // txt_th
            // 
            this.txt_th.Enabled = false;
            this.txt_th.Location = new System.Drawing.Point(360, 114);
            this.txt_th.Name = "txt_th";
            this.txt_th.Size = new System.Drawing.Size(100, 20);
            this.txt_th.TabIndex = 13;
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(284, 87);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(21, 13);
            this.lbl_km.TabIndex = 14;
            this.lbl_km.Text = "km";
            // 
            // lbl_th
            // 
            this.lbl_th.AutoSize = true;
            this.lbl_th.Location = new System.Drawing.Point(284, 114);
            this.lbl_th.Name = "lbl_th";
            this.lbl_th.Size = new System.Drawing.Size(63, 13);
            this.lbl_th.TabIndex = 15;
            this.lbl_th.Text = "tonaj/hacim";
            // 
            // lbl_agirlik
            // 
            this.lbl_agirlik.AutoSize = true;
            this.lbl_agirlik.Location = new System.Drawing.Point(288, 140);
            this.lbl_agirlik.Name = "lbl_agirlik";
            this.lbl_agirlik.Size = new System.Drawing.Size(34, 13);
            this.lbl_agirlik.TabIndex = 17;
            this.lbl_agirlik.Text = "ağırlık";
            // 
            // txt_agrilik
            // 
            this.txt_agrilik.Enabled = false;
            this.txt_agrilik.Location = new System.Drawing.Point(360, 140);
            this.txt_agrilik.Name = "txt_agrilik";
            this.txt_agrilik.Size = new System.Drawing.Size(100, 20);
            this.txt_agrilik.TabIndex = 16;
            // 
            // btn_kyıt
            // 
            this.btn_kyıt.Location = new System.Drawing.Point(388, 58);
            this.btn_kyıt.Name = "btn_kyıt";
            this.btn_kyıt.Size = new System.Drawing.Size(75, 22);
            this.btn_kyıt.TabIndex = 18;
            this.btn_kyıt.Text = "Kaydet";
            this.btn_kyıt.UseVisualStyleBackColor = true;
            this.btn_kyıt.Click += new System.EventHandler(this.btn_kyıt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 312);
            this.Controls.Add(this.btn_kyıt);
            this.Controls.Add(this.lbl_agirlik);
            this.Controls.Add(this.txt_agrilik);
            this.Controls.Add(this.lbl_th);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.txt_th);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.btn_ucret);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_deger);
            this.Controls.Add(this.cmb_urun);
            this.Controls.Add(this.lbl_iletisim);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_iletisim);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lblBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_iletisim;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_iletisim;
        private System.Windows.Forms.ComboBox cmb_urun;
        private System.Windows.Forms.Label lbl_deger;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.Button btn_ucret;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_th;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_th;
        private System.Windows.Forms.Label lbl_agirlik;
        private System.Windows.Forms.TextBox txt_agrilik;
        private System.Windows.Forms.Button btn_kyıt;
    }
}

