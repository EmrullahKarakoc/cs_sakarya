namespace OrtalamaStandartSapma
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
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_dizi = new System.Windows.Forms.ListBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_stdSapma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(26, 46);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi.TabIndex = 0;
            this.txt_sayi.TextChanged += new System.EventHandler(this.txt_sayi_TextChanged);
            this.txt_sayi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sayi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı Giriniz";
            // 
            // list_dizi
            // 
            this.list_dizi.FormattingEnabled = true;
            this.list_dizi.Location = new System.Drawing.Point(26, 110);
            this.list_dizi.Name = "list_dizi";
            this.list_dizi.Size = new System.Drawing.Size(120, 186);
            this.list_dizi.TabIndex = 2;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(322, 46);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 3;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(322, 99);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_son
            // 
            this.btn_son.Location = new System.Drawing.Point(322, 156);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(75, 23);
            this.btn_son.TabIndex = 5;
            this.btn_son.Text = "Son";
            this.btn_son.UseVisualStyleBackColor = true;
            this.btn_son.Click += new System.EventHandler(this.btn_son_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ortalama";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(319, 248);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(0, 13);
            this.lbl_ort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Standart Sapma";
            // 
            // lbl_stdSapma
            // 
            this.lbl_stdSapma.AutoSize = true;
            this.lbl_stdSapma.Location = new System.Drawing.Point(319, 332);
            this.lbl_stdSapma.Name = "lbl_stdSapma";
            this.lbl_stdSapma.Size = new System.Drawing.Size(0, 13);
            this.lbl_stdSapma.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 402);
            this.Controls.Add(this.lbl_stdSapma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.list_dizi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_dizi;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_son;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stdSapma;
    }
}

