using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealKilo
{
    public partial class Form1 : Form
    {
        public int boy, kilo, yas, dogumTarihi,cinsiyet;
        public double idealKg;
        public double t;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_cinsiyet.SelectedIndex=0;
            //idealKilo.Text = "";
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            boy = Convert.ToInt32(txt_boy.Text);
            kilo = Convert.ToInt32(txt_kilo.Text);
            dogumTarihi = Convert.ToInt32(txt_dogumTarihi);
            yas = 2013 - dogumTarihi;
            cinsiyet = cmb_cinsiyet.SelectedIndex;
            if (cinsiyet == 1) t = 0.9;
            else if (cinsiyet == 2) t = 0.8;
            else MessageBox.Show("Cinsiyet seçiniz");
            idealKg = (boy -100+yas/100)*t;

            idealKilo.Text = Convert.ToString(idealKg);
        }
    }
}
