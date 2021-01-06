using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDP1B
{
    class MusteriBilgileri:IBilgi
    {
       private string ad;
       private string soyad;
       private int iletisim;
 
       public void MusteriBilgGir(string ad, string soyad, int iletisim)
       {
           this.ad = ad;
           this.soyad = soyad;
           this.iletisim = iletisim;
       
       }
       public string musteriAd
       {

           get
           {
               return ad;
           }
          
       
       }
       public string musteriSoyad
       {

           get
           {
               return soyad;
           }


       }
       public int musteriIletisim
       {

           get
           {
               return iletisim;
           }


       }


    }
}
