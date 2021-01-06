using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double quiz, vize, final, ort;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_quiz_TextChanged(object sender, EventArgs e)
        {            
            quiz = Convert.ToInt32(txt_quiz.Text);
            quiz = quiz * 0.1;
            ort += quiz;
            txt_ort.Text = Convert.ToString(ort);
        }

        private void txt_vize_TextChanged(object sender, EventArgs e)
        {
            vize = Convert.ToInt32(txt_vize.Text);
            vize = vize * 0.3;
            ort += vize;
            txt_ort.Text = Convert.ToString(ort);
        }

        private void txt_final_TextChanged(object sender, EventArgs e)
        {
            final = Convert.ToInt32(txt_final.Text);
            final = final * 0.6;
            ort += final;
            txt_ort.Text = Convert.ToString(ort);
        }

    }
}
