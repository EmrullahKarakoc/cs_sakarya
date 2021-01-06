namespace NotHesaplama
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
            this.txt_quiz = new System.Windows.Forms.TextBox();
            this.txt_vize = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.txt_quizTitle = new System.Windows.Forms.TextBox();
            this.txt_finalTitle = new System.Windows.Forms.TextBox();
            this.txt_vizeTitle = new System.Windows.Forms.TextBox();
            this.txt_ort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_quiz
            // 
            this.txt_quiz.Location = new System.Drawing.Point(157, 23);
            this.txt_quiz.Name = "txt_quiz";
            this.txt_quiz.Size = new System.Drawing.Size(100, 20);
            this.txt_quiz.TabIndex = 0;
            this.txt_quiz.TextChanged += new System.EventHandler(this.txt_quiz_TextChanged);
            // 
            // txt_vize
            // 
            this.txt_vize.Location = new System.Drawing.Point(157, 66);
            this.txt_vize.Name = "txt_vize";
            this.txt_vize.Size = new System.Drawing.Size(100, 20);
            this.txt_vize.TabIndex = 1;
            this.txt_vize.TextChanged += new System.EventHandler(this.txt_vize_TextChanged);
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(157, 109);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(100, 20);
            this.txt_final.TabIndex = 2;
            this.txt_final.TextChanged += new System.EventHandler(this.txt_final_TextChanged);
            // 
            // txt_quizTitle
            // 
            this.txt_quizTitle.Location = new System.Drawing.Point(26, 23);
            this.txt_quizTitle.Name = "txt_quizTitle";
            this.txt_quizTitle.ReadOnly = true;
            this.txt_quizTitle.Size = new System.Drawing.Size(100, 20);
            this.txt_quizTitle.TabIndex = 3;
            this.txt_quizTitle.Text = "QUIZ";
            // 
            // txt_finalTitle
            // 
            this.txt_finalTitle.Location = new System.Drawing.Point(26, 109);
            this.txt_finalTitle.Name = "txt_finalTitle";
            this.txt_finalTitle.ReadOnly = true;
            this.txt_finalTitle.Size = new System.Drawing.Size(100, 20);
            this.txt_finalTitle.TabIndex = 5;
            this.txt_finalTitle.Text = "FİNAL";
            // 
            // txt_vizeTitle
            // 
            this.txt_vizeTitle.Location = new System.Drawing.Point(26, 66);
            this.txt_vizeTitle.Name = "txt_vizeTitle";
            this.txt_vizeTitle.ReadOnly = true;
            this.txt_vizeTitle.Size = new System.Drawing.Size(100, 20);
            this.txt_vizeTitle.TabIndex = 4;
            this.txt_vizeTitle.Text = "VİZE";
            // 
            // txt_ort
            // 
            this.txt_ort.Location = new System.Drawing.Point(157, 148);
            this.txt_ort.Name = "txt_ort";
            this.txt_ort.Size = new System.Drawing.Size(100, 20);
            this.txt_ort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ORTALAMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ort);
            this.Controls.Add(this.txt_finalTitle);
            this.Controls.Add(this.txt_vizeTitle);
            this.Controls.Add(this.txt_quizTitle);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_vize);
            this.Controls.Add(this.txt_quiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_quiz;
        private System.Windows.Forms.TextBox txt_vize;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.TextBox txt_quizTitle;
        private System.Windows.Forms.TextBox txt_finalTitle;
        private System.Windows.Forms.TextBox txt_vizeTitle;
        private System.Windows.Forms.TextBox txt_ort;
        private System.Windows.Forms.Label label1;
    }
}

