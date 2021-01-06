namespace IdealKilo
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
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.txt_dogumTarihi = new System.Windows.Forms.TextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.idealKilo = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_boy
            // 
            this.txt_boy.Location = new System.Drawing.Point(167, 12);
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.Size = new System.Drawing.Size(100, 20);
            this.txt_boy.TabIndex = 0;
            // 
            // txt_dogumTarihi
            // 
            this.txt_dogumTarihi.Location = new System.Drawing.Point(167, 53);
            this.txt_dogumTarihi.Name = "txt_dogumTarihi";
            this.txt_dogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.txt_dogumTarihi.TabIndex = 1;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Seçim yapınız",
            "Bay",
            "Bayan"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(167, 93);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmb_cinsiyet.TabIndex = 2;
            this.cmb_cinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(164, 131);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(100, 20);
            this.txt_kilo.TabIndex = 3;
            // 
            // idealKilo
            // 
            this.idealKilo.Location = new System.Drawing.Point(164, 174);
            this.idealKilo.Name = "idealKilo";
            this.idealKilo.Size = new System.Drawing.Size(100, 20);
            this.idealKilo.TabIndex = 4;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(67, 247);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_son
            // 
            this.btn_son.Location = new System.Drawing.Point(167, 247);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(75, 23);
            this.btn_son.TabIndex = 6;
            this.btn_son.Text = "Son";
            this.btn_son.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Boy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kilo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "İdeal Kilo";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(44, 217);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 282);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.idealKilo);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.txt_dogumTarihi);
            this.Controls.Add(this.txt_boy);
            this.Name = "Form1";
            this.Text = "İdeal Kilo Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.TextBox txt_dogumTarihi;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox idealKilo;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_son;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_msg;
    }
}

