using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanveCevreHesaplama_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            lbl_yaricap.BackColor = Color.Blue;
            lbl_cevre.BackColor = Color.Red;
            lbl_alan.BackColor = Color.Red;
            btn_hesapla.BackColor = Color.Green;
            btn_son.BackColor = Color.Green;
            txt_alan.ReadOnly = true;
            txt_cevre.ReadOnly = true;
            txt_alan.BackColor = Color.Yellow;
            txt_cevre.BackColor = Color.Yellow;
            txt_cevre.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txt_r.Text);
            double cevre = 2 * 3.14 * r;
            double alan = r * r * 3.14;
            txt_cevre.Text = Convert.ToString(cevre);
            txt_alan.Text = Convert.ToString(alan);
        }

        private void btn_son_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
