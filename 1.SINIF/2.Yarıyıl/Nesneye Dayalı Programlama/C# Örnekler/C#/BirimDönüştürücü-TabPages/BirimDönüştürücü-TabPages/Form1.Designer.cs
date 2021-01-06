namespace BirimDönüştürücü_TabPages
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmb_birim = new System.Windows.Forms.ComboBox();
            this.cmb_birim2 = new System.Windows.Forms.ComboBox();
            this.lbl_birim1 = new System.Windows.Forms.Label();
            this.lbl_birim2 = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(46, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_sonuc);
            this.tabPage1.Controls.Add(this.txt_value);
            this.tabPage1.Controls.Add(this.lbl_birim2);
            this.tabPage1.Controls.Add(this.lbl_birim1);
            this.tabPage1.Controls.Add(this.cmb_birim2);
            this.tabPage1.Controls.Add(this.cmb_birim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uzunluk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Güç";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(489, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Basınç";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmb_birim
            // 
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.Items.AddRange(new object[] {
            "metre",
            "inch",
            "foot",
            "yarda",
            "kara mili"});
            this.cmb_birim.Location = new System.Drawing.Point(17, 39);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(121, 21);
            this.cmb_birim.TabIndex = 0;
            this.cmb_birim.SelectedIndexChanged += new System.EventHandler(this.cmb_birim_SelectedIndexChanged);
            // 
            // cmb_birim2
            // 
            this.cmb_birim2.FormattingEnabled = true;
            this.cmb_birim2.Items.AddRange(new object[] {
            "metre",
            "inch",
            "foot",
            "yarda",
            "kara mili"});
            this.cmb_birim2.Location = new System.Drawing.Point(277, 39);
            this.cmb_birim2.Name = "cmb_birim2";
            this.cmb_birim2.Size = new System.Drawing.Size(121, 21);
            this.cmb_birim2.TabIndex = 1;
            this.cmb_birim2.SelectedIndexChanged += new System.EventHandler(this.cmb_birim2_SelectedIndexChanged);
            // 
            // lbl_birim1
            // 
            this.lbl_birim1.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_birim1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_birim1.ForeColor = System.Drawing.Color.Snow;
            this.lbl_birim1.Location = new System.Drawing.Point(17, 94);
            this.lbl_birim1.Name = "lbl_birim1";
            this.lbl_birim1.Size = new System.Drawing.Size(100, 23);
            this.lbl_birim1.TabIndex = 2;
            // 
            // lbl_birim2
            // 
            this.lbl_birim2.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_birim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_birim2.ForeColor = System.Drawing.Color.Snow;
            this.lbl_birim2.Location = new System.Drawing.Point(17, 149);
            this.lbl_birim2.Name = "lbl_birim2";
            this.lbl_birim2.Size = new System.Drawing.Size(100, 23);
            this.lbl_birim2.TabIndex = 3;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(277, 97);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 20);
            this.txt_value.TabIndex = 4;
            this.txt_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_sonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sonuc.ForeColor = System.Drawing.Color.Snow;
            this.lbl_sonuc.Location = new System.Drawing.Point(277, 149);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(100, 23);
            this.lbl_sonuc.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(249, 336);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Çıkış";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 396);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmb_birim;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmb_birim2;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lbl_birim2;
        private System.Windows.Forms.Label lbl_birim1;
        private System.Windows.Forms.Button btn_close;
    }
}

