using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy = int.Parse(txtBoy.Text);
            int yas = int.Parse(txtYas.Text);
            int kilo = int.Parse(txtKilo.Text);
            double ikilo = 0;
            if (rBKadin.Checked)
                ikilo = (boy - 100) * 0.8 + (yas / 10.0);
            else
                ikilo = (boy - 100) * 0.9 + (yas / 10.0);
            ikilo = Math.Round(ikilo);
            if (cBS.Checked) ikilo += 2;
            if (CBH.Checked) ikilo += 1;
            lblKilo.Text = "İdeal Kilonuz : " + ikilo;

            double fark = kilo - ikilo;
            if (fark > 0)
                lblDurum.Text = fark + " kilo vermelisiniz.";
            else if (fark < 0)
                lblDurum.Text = Math.Abs(fark) + " kilo almalısınız.";
            else
                lblDurum.Text = "Tebrikler... İdeal Kilodasınız.";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
