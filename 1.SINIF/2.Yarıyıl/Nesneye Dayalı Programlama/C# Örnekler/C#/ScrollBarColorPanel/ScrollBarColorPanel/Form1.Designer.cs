namespace ScrollBarColorPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vScroll_R = new System.Windows.Forms.VScrollBar();
            this.vScroll_B = new System.Windows.Forms.VScrollBar();
            this.vScroll_G = new System.Windows.Forms.VScrollBar();
            this.hScroll_R = new System.Windows.Forms.HScrollBar();
            this.hScroll_G = new System.Windows.Forms.HScrollBar();
            this.hScroll_B = new System.Windows.Forms.HScrollBar();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl_vR = new System.Windows.Forms.Label();
            this.lbl_vG = new System.Windows.Forms.Label();
            this.lbl_vB = new System.Windows.Forms.Label();
            this.lbl_hR = new System.Windows.Forms.Label();
            this.lbl_hG = new System.Windows.Forms.Label();
            this.lbl_hB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 244);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÇAĞLAYAN";
            // 
            // vScroll_R
            // 
            this.vScroll_R.Location = new System.Drawing.Point(454, 27);
            this.vScroll_R.Maximum = 255;
            this.vScroll_R.Name = "vScroll_R";
            this.vScroll_R.Size = new System.Drawing.Size(23, 244);
            this.vScroll_R.TabIndex = 2;
            // 
            // vScroll_B
            // 
            this.vScroll_B.Location = new System.Drawing.Point(618, 27);
            this.vScroll_B.Maximum = 255;
            this.vScroll_B.Name = "vScroll_B";
            this.vScroll_B.Size = new System.Drawing.Size(23, 244);
            this.vScroll_B.TabIndex = 3;
            // 
            // vScroll_G
            // 
            this.vScroll_G.Location = new System.Drawing.Point(538, 27);
            this.vScroll_G.Maximum = 255;
            this.vScroll_G.Name = "vScroll_G";
            this.vScroll_G.Size = new System.Drawing.Size(23, 244);
            this.vScroll_G.TabIndex = 4;
            // 
            // hScroll_R
            // 
            this.hScroll_R.Location = new System.Drawing.Point(30, 313);
            this.hScroll_R.Maximum = 255;
            this.hScroll_R.Name = "hScroll_R";
            this.hScroll_R.Size = new System.Drawing.Size(357, 17);
            this.hScroll_R.TabIndex = 5;
            // 
            // hScroll_G
            // 
            this.hScroll_G.Location = new System.Drawing.Point(30, 352);
            this.hScroll_G.Maximum = 255;
            this.hScroll_G.Name = "hScroll_G";
            this.hScroll_G.Size = new System.Drawing.Size(357, 17);
            this.hScroll_G.TabIndex = 6;
            // 
            // hScroll_B
            // 
            this.hScroll_B.Location = new System.Drawing.Point(30, 389);
            this.hScroll_B.Maximum = 255;
            this.hScroll_B.Name = "hScroll_B";
            this.hScroll_B.Size = new System.Drawing.Size(357, 17);
            this.hScroll_B.TabIndex = 7;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(574, 380);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            // 
            // lbl_vR
            // 
            this.lbl_vR.AutoSize = true;
            this.lbl_vR.Location = new System.Drawing.Point(451, 286);
            this.lbl_vR.Name = "lbl_vR";
            this.lbl_vR.Size = new System.Drawing.Size(0, 13);
            this.lbl_vR.TabIndex = 9;
            // 
            // lbl_vG
            // 
            this.lbl_vG.AutoSize = true;
            this.lbl_vG.Location = new System.Drawing.Point(535, 286);
            this.lbl_vG.Name = "lbl_vG";
            this.lbl_vG.Size = new System.Drawing.Size(0, 13);
            this.lbl_vG.TabIndex = 10;
            // 
            // lbl_vB
            // 
            this.lbl_vB.AutoSize = true;
            this.lbl_vB.Location = new System.Drawing.Point(614, 286);
            this.lbl_vB.Name = "lbl_vB";
            this.lbl_vB.Size = new System.Drawing.Size(0, 13);
            this.lbl_vB.TabIndex = 11;
            // 
            // lbl_hR
            // 
            this.lbl_hR.AutoSize = true;
            this.lbl_hR.Location = new System.Drawing.Point(416, 317);
            this.lbl_hR.Name = "lbl_hR";
            this.lbl_hR.Size = new System.Drawing.Size(0, 13);
            this.lbl_hR.TabIndex = 12;
            // 
            // lbl_hG
            // 
            this.lbl_hG.AutoSize = true;
            this.lbl_hG.Location = new System.Drawing.Point(416, 356);
            this.lbl_hG.Name = "lbl_hG";
            this.lbl_hG.Size = new System.Drawing.Size(0, 13);
            this.lbl_hG.TabIndex = 13;
            // 
            // lbl_hB
            // 
            this.lbl_hB.AutoSize = true;
            this.lbl_hB.Location = new System.Drawing.Point(416, 393);
            this.lbl_hB.Name = "lbl_hB";
            this.lbl_hB.Size = new System.Drawing.Size(0, 13);
            this.lbl_hB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 415);
            this.Controls.Add(this.lbl_hB);
            this.Controls.Add(this.lbl_hG);
            this.Controls.Add(this.lbl_hR);
            this.Controls.Add(this.lbl_vB);
            this.Controls.Add(this.lbl_vG);
            this.Controls.Add(this.lbl_vR);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.hScroll_B);
            this.Controls.Add(this.hScroll_G);
            this.Controls.Add(this.hScroll_R);
            this.Controls.Add(this.vScroll_G);
            this.Controls.Add(this.vScroll_B);
            this.Controls.Add(this.vScroll_R);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScroll_R;
        private System.Windows.Forms.VScrollBar vScroll_B;
        private System.Windows.Forms.VScrollBar vScroll_G;
        private System.Windows.Forms.HScrollBar hScroll_R;
        private System.Windows.Forms.HScrollBar hScroll_G;
        private System.Windows.Forms.HScrollBar hScroll_B;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_vR;
        private System.Windows.Forms.Label lbl_vG;
        private System.Windows.Forms.Label lbl_vB;
        private System.Windows.Forms.Label lbl_hR;
        private System.Windows.Forms.Label lbl_hG;
        private System.Windows.Forms.Label lbl_hB;
    }
}

