namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.rBKadin = new System.Windows.Forms.RadioButton();
            this.rBErkek = new System.Windows.Forms.RadioButton();
            this.cBS = new System.Windows.Forms.CheckBox();
            this.CBH = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kilo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet:";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(49, 205);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(0, 26);
            this.lblKilo.TabIndex = 4;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(49, 252);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 26);
            this.lblDurum.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(269, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 110);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(148, 94);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 32);
            this.txtKilo.TabIndex = 8;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(148, 56);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 32);
            this.txtYas.TabIndex = 9;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(148, 16);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 32);
            this.txtBoy.TabIndex = 10;
            // 
            // rBKadin
            // 
            this.rBKadin.AutoSize = true;
            this.rBKadin.Checked = true;
            this.rBKadin.Location = new System.Drawing.Point(148, 144);
            this.rBKadin.Name = "rBKadin";
            this.rBKadin.Size = new System.Drawing.Size(86, 30);
            this.rBKadin.TabIndex = 11;
            this.rBKadin.TabStop = true;
            this.rBKadin.Text = "Kadın";
            this.rBKadin.UseVisualStyleBackColor = true;
            // 
            // rBErkek
            // 
            this.rBErkek.AutoSize = true;
            this.rBErkek.Location = new System.Drawing.Point(240, 144);
            this.rBErkek.Name = "rBErkek";
            this.rBErkek.Size = new System.Drawing.Size(86, 30);
            this.rBErkek.TabIndex = 12;
            this.rBErkek.Text = "Erkek";
            this.rBErkek.UseVisualStyleBackColor = true;
            // 
            // cBS
            // 
            this.cBS.AutoSize = true;
            this.cBS.Location = new System.Drawing.Point(54, 183);
            this.cBS.Name = "cBS";
            this.cBS.Size = new System.Drawing.Size(189, 30);
            this.cBS.TabIndex = 13;
            this.cBS.Text = "Spor Yapıyorum";
            this.cBS.UseVisualStyleBackColor = true;
            // 
            // CBH
            // 
            this.CBH.AutoSize = true;
            this.CBH.Location = new System.Drawing.Point(269, 183);
            this.CBH.Name = "CBH";
            this.CBH.Size = new System.Drawing.Size(152, 30);
            this.CBH.TabIndex = 14;
            this.CBH.Text = "Hareketliyim";
            this.CBH.UseVisualStyleBackColor = true;
            this.CBH.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.CBH);
            this.Controls.Add(this.cBS);
            this.Controls.Add(this.rBErkek);
            this.Controls.Add(this.rBKadin);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.RadioButton rBKadin;
        private System.Windows.Forms.RadioButton rBErkek;
        private System.Windows.Forms.CheckBox cBS;
        private System.Windows.Forms.CheckBox CBH;
    }
}

