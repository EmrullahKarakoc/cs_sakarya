using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDP1B
{
    class UDegerli:IUrun
    {
        private string Ad;
        private const  double Carpan=1.5;
      
        public int sonuc;

      
        public double turCarpani 
        {
            get { return Carpan; }
        }
        public string turAdi 
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public int UcretHesap(double tonaj, double agirlik, double km)
        {
            if ((agirlik / tonaj) > 0.5)
            { 
                sonuc=Convert.ToInt32(((agirlik+100)*turCarpani)+(km*1.5));
            }
            else
                sonuc = Convert.ToInt32((tonaj * turCarpani) + (km * 1.5));


            return sonuc;
        }
  
    }
}
