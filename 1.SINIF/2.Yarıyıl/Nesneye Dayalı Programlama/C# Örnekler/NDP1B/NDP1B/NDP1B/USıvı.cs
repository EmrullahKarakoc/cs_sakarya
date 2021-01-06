using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDP1B
{
    class USıvı : IUrun
    {
        private string Ad;
        private const double Carpan = 1.0;
    
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

            sonuc = Convert.ToInt32(tonaj * turCarpani * km);


            return sonuc;
        }
    
    }
}
