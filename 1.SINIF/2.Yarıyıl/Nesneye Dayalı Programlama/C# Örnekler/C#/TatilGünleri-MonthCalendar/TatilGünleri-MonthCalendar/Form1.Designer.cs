namespace TatilGünleri_MonthCalendar
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
            this.cmb_tatil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.list_tatilListesi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Cikar = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_tatil
            // 
            this.cmb_tatil.FormattingEnabled = true;
            this.cmb_tatil.Items.AddRange(new object[] {
            "Yılbaşı",
            "Ulusal Egemenlik ve Çocuk Bayramı",
            "İşçi Bayramı",
            "Zafer Bayramı",
            "Cumhuriyet Bayramı",
            "Ramazan Bayramı",
            "Kurban Bayramı"});
            this.cmb_tatil.Location = new System.Drawing.Point(14, 29);
            this.cmb_tatil.Name = "cmb_tatil";
            this.cmb_tatil.Size = new System.Drawing.Size(121, 21);
            this.cmb_tatil.TabIndex = 0;
            this.cmb_tatil.SelectedIndexChanged += new System.EventHandler(this.cmb_tatil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resmi Tatiller";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // list_tatilListesi
            // 
            this.list_tatilListesi.FormattingEnabled = true;
            this.list_tatilListesi.Location = new System.Drawing.Point(349, 81);
            this.list_tatilListesi.Name = "list_tatilListesi";
            this.list_tatilListesi.Size = new System.Drawing.Size(278, 160);
            this.list_tatilListesi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resmi Tatil Günleri";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(260, 81);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Cikar
            // 
            this.btn_Cikar.Location = new System.Drawing.Point(260, 127);
            this.btn_Cikar.Name = "btn_Cikar";
            this.btn_Cikar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cikar.TabIndex = 6;
            this.btn_Cikar.Text = "Çıkar";
            this.btn_Cikar.UseVisualStyleBackColor = true;
            this.btn_Cikar.Click += new System.EventHandler(this.btn_Cikar_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(260, 176);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_Cikis.TabIndex = 7;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 321);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Cikar);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_tatilListesi);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tatil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tatil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox list_tatilListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Cikar;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

