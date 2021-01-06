using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaStandartSapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int toplam;
        public double ort,sapma,sapmaToplam;
        private void txt_sayi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_sayi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                list_dizi.Items.Add(txt_sayi.Text);
                txt_sayi.Text = "";
                txt_sayi.Focus();
                lbl_ort.Text = "";
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_dizi.Items.Count; i++)
            {
                toplam += Convert.ToInt32(list_dizi.Items[i]);
            }

            ort = toplam / list_dizi.Items.Count;

            for (int i = 0; i < list_dizi.Items.Count; i++)
            {
                sapmaToplam += (Convert.ToInt32(list_dizi.Items[i]) - ort) * (Convert.ToInt32(list_dizi.Items[i]) - ort); 
            }

            sapma = sapmaToplam / list_dizi.Items.Count;

            lbl_ort.Text = Convert.ToString(ort);
            lbl_stdSapma.Text = Convert.ToString(sapma);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            list_dizi.Items.Clear();
        }

        private void btn_son_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
