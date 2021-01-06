namespace SınavTakvimi_DateTimePicker
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
            this.cmb_dersler = new System.Windows.Forms.ComboBox();
            this.dtp_takvim = new System.Windows.Forms.DateTimePicker();
            this.list_liste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_dersler
            // 
            this.cmb_dersler.FormattingEnabled = true;
            this.cmb_dersler.Items.AddRange(new object[] {
            "Nesneye Dayalı Programlama",
            "Ayrık İşlemsel Yapılar",
            "Programlama Dillerinin Prensipleri",
            "Olasılık ve İstatistik",
            "Matematik II",
            "Bilgisayar Organizasyonu"});
            this.cmb_dersler.Location = new System.Drawing.Point(50, 30);
            this.cmb_dersler.Name = "cmb_dersler";
            this.cmb_dersler.Size = new System.Drawing.Size(345, 21);
            this.cmb_dersler.TabIndex = 0;
            // 
            // dtp_takvim
            // 
            this.dtp_takvim.Location = new System.Drawing.Point(50, 78);
            this.dtp_takvim.Name = "dtp_takvim";
            this.dtp_takvim.Size = new System.Drawing.Size(345, 20);
            this.dtp_takvim.TabIndex = 1;
            this.dtp_takvim.ValueChanged += new System.EventHandler(this.dtp_takvim_ValueChanged);
            // 
            // list_liste
            // 
            this.list_liste.FormattingEnabled = true;
            this.list_liste.Location = new System.Drawing.Point(50, 128);
            this.list_liste.Name = "list_liste";
            this.list_liste.Size = new System.Drawing.Size(345, 173);
            this.list_liste.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 402);
            this.Controls.Add(this.list_liste);
            this.Controls.Add(this.dtp_takvim);
            this.Controls.Add(this.cmb_dersler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_dersler;
        private System.Windows.Forms.DateTimePicker dtp_takvim;
        private System.Windows.Forms.ListBox list_liste;
    }
}

