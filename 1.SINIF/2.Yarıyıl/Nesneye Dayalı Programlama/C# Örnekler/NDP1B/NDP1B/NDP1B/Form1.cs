using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDP1B
{
    public partial class Form1 : Form
    {

        private void btn_ucret_Click(object sender, EventArgs e)
        {
             
            MusteriBilgileri musteri = new MusteriBilgileri();
           
            musteri.MusteriBilgGir(txt_ad.Text, txt_soyad.Text, Convert.ToInt32(txt_iletisim.Text));
            UrunOlustur();
            UrunDegerileri();
            int ucret = urun.UcretHesap(tonaj,agirlik,km);
            txt_sonuc.Text =musteri.musteriAd+musteri.musteriSoyad+"'lı musterinin"+ Convert.ToString(ucret)+"  lira toplam ücreti";

        }
        private void UrunOlustur()
        {
            if (cmb_urun.Text == "SIVI")
            {
                urun = new USıvı();
            }
            else if (cmb_urun.Text == "KATI")
            {
                urun=new UKatı();
            }
            else if (cmb_urun.Text == "GAZ")
            {
                urun=new UGaz();
            }
            else if (cmb_urun.Text == "DEGERLİ")
            {
               urun=new UDegerli();
            }
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void UrunDegerileri()
        {
            if (cmb_urun.Text == "DEGERLİ")
            {
               
                agirlik = Convert.ToDouble(txt_agrilik.Text);
                km = Convert.ToDouble(txt_km.Text);

            }
            else
            {
                km = Convert.ToDouble(txt_km.Text);
               tonaj = Convert.ToDouble(txt_th.Text);
            }
        }
        

    
       
           IUrun urun;
           private double tonaj=0;
           private double km=0;
           private double agirlik=0;

           private void btn_kyıt_Click(object sender, EventArgs e)
           {
               if (cmb_urun.Text == "DEGERLİ")
               {
                   txt_agrilik.Enabled = true;
                   txt_th.Enabled = true;

               }
               else
               {
                   txt_th.Enabled = true;
                   txt_agrilik.Enabled = false;
               }

           }

         
    }
}
