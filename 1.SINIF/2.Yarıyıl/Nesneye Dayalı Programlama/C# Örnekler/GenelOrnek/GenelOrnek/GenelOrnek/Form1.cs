using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[] txtler;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(numericUpDown1.Value.ToString());
            txtler = new TextBox[sayi];
            for(int i=0;i<sayi;i++)
            {
                TextBox txt = new TextBox();
                txt.Text = "" + i;
                txt.Top = i * 30 + 30;
                txt.Left = 300;
                this.Controls.Add(txt);
                txtler[i] = txt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (var deger in txtler)
                toplam += int.Parse(deger.Text);
            label1.Text = "Ortalama : " + ((double)toplam / txtler.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (var deger in listBox1.Items)
                toplam+=int.Parse(deger.ToString());
            label2.Text = "Ortalama :" + ((double)toplam / listBox1.Items.Count);
        }
        string[,] kitaplar = { { "cin ali", "5" }, { "pinokyo", "7" }, { "Hobbit", "20" }, { "Kaşağı", "10" } };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                listBox2.Items.Add(kitaplar[i, 0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox2.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ucret = 0;
            foreach(var deger in listBox3.Items)
            {
                for (int i = 0; i < 4; i++)
                    if (deger.ToString() == kitaplar[i, 0])
                        ucret += int.Parse(kitaplar[i, 1]);
            }
            label3.Text = "Ücret : " + ucret;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                button7.Text = "Sıfırla";
                button7.BackColor = Color.Red;
                bayrak = 3;
            }               
            else
                progressBar1.Value += 5;
        }
        int bayrak = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (bayrak == 0)
            {
                button7.BackColor = Color.Yellow;
                button7.Text = "Durdur";
                timer1.Enabled = true;
                bayrak = 1;
            }
            else if(bayrak==1)
            {
                timer1.Enabled = false;
                button7.Text = "Devam Et";
                button7.BackColor = Color.Orange;
                bayrak = 0;
            }
            else if(bayrak==3)
            {
                button7.BackColor = Color.Lime;
                button7.Text = "Başlat";
                progressBar1.Value = 0;
                bayrak = 0;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int kirmizi = int.Parse(numericUpDown2.Value.ToString());
            int yesil = int.Parse(vScrollBar1.Value.ToString());
            int mavi = int.Parse(trackBar1.Value.ToString());
            button8.BackColor = Color.FromArgb(kirmizi, yesil, mavi);

        }
    }
}
