using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirimDönüştürücü_TabPages
{
    public partial class Form1 : Form
    {
        string[] birim = { "metre", "inch", "foot", "yarda", "kara mili" };
        double[] deger = { 1, 39.3707, 3.28084, 1.09361, 0.00062137 };
        int b1, b2;
        double d1, d2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_birim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_birim1.Text = cmb_birim.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b1 = cmb_birim.SelectedIndex;
            b2 = cmb_birim2.SelectedIndex;
            d1 = deger[b1];
            d2 = deger[b2];

            lbl_sonuc.Text = Convert.ToString(Convert.ToDouble(txt_value.Text) * d2 / d1);
        }

        private void cmb_birim2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_birim2.Text = cmb_birim2.SelectedItem.ToString();
        }
    }
}
