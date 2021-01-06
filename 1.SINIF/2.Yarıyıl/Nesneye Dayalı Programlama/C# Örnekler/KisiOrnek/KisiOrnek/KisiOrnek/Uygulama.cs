using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiOrnek
{
    class Uygulama
    {
        private Kisi kisi;
        private int secim;
        public Uygulama()
        {
            kisi = new Kisi();
        }
        public void Calistir()
        {            
            do
            {
                Console.WriteLine("1-Veri Gir");
                Console.WriteLine("2-Veri Listele");
                Console.WriteLine("3-Çıkış");
                Console.WriteLine("-------------");
                Console.Write("Seçiminiz : ");
                secim = int.Parse(Console.ReadLine());
                if (secim == 1) kisi.bilgiGir();
                else if (secim == 2) kisi.bilgiYaz();
                else if (secim == 3) break;
                else Console.WriteLine("Hatalı Seçim");
            } while (secim != 3);
        }
    }
}
