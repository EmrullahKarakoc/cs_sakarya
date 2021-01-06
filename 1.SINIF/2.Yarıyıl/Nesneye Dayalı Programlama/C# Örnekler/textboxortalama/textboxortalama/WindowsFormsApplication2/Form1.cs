using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text.Length < 1)
            {
                lblSonuc.Text = "Hata : En az bir rakam olmalıdır.";
                lblSonuc.Text = "";
            }
            else if (txtSayi.Text.Length > 1)
            {
                txtSayi.Clear();
                lblSonuc.Text = "Hata : En fazla bir rakam olmalıdır.";
            }
            else
            {
                if (txtSayilar.Text.Length == 0)
                    txtSayilar.Text = txtSayi.Text;
                else 
                    txtSayilar.Text += ","+txtSayi.Text;
                lblSonuc.Text = "";
                btnOrtalama.Show();
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            if (txtSayilar.Text.Length == 0)
                lblSonuc.Text = "Hata : Ortalama hesabı içim en az bir rakam olmaldır.";
            else
            {
                string[] sayilar = txtSayilar.Text.Split(',');
                int toplam = 0;
                foreach (var deger in sayilar)
                    toplam += int.Parse(deger);
                lblSonuc.Text = "Sayıların ortalaması :" + ((double)toplam / sayilar.Length);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOrtalama.Hide();
            txtSayilar.Enabled = false;
        }
    }
}
