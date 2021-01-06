using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    class Dikdortgen
    {
        private double uzunluk;
        private double genislik;

        /*public Dikdortgen()
        {
            uzunluk = 1;
            genislik = 1;
        }*/
        public Dikdortgen(double uzun, double genis)
        {
            uzunluk = uzun;
            genislik = genis;
        }

        public double UZUNLUK
        {
            get
            {
                return uzunluk;
            }
            set
            {
                if ((uzunluk > 0) && (uzunluk < 20))
                {
                    uzunluk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Uzunluk degerini ", value, " girdiniz. Uzunluk 0-20 arasinda olmalidir...");
                }
            }
        }

        public double GENISLIK
        {
            get
            {
                return genislik;
            }
            set
            {
                if ((genislik > 0) && (genislik < 20))
                {
                    genislik = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Genislik degerini ", value, " girdiniz. Genislik 0-20 arasinda olmalidir...");
                }
            }
        }

        private double ALAN
        {
            get
            {
                return UZUNLUK * GENISLIK;
            }
        }

        private double CEVRE
        {
            get
            {
                return 2 * (UZUNLUK + GENISLIK);
            }
        }

        public void Yazdir()
        {
            Console.WriteLine("Alan : " + ALAN);
            Console.WriteLine("Cevre : " + CEVRE);
        }
        public override string ToString()
        {
            string sonuc = "Alan..: " + ALAN + "\nCevre..: " + CEVRE;
            return sonuc;
        }
    }
}
