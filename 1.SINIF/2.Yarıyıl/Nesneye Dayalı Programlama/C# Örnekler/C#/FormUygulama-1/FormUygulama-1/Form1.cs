using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_deneme.Text = "Çıkış";
            btn_deneme.BackColor = Color.Azure;
        }

        private void btn_deneme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
