using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVirtualClass
{
    class Otomobil
    {
        public int model;
        public string renk;
        public virtual void Ozellik()
        {
            Console.WriteLine("Model : {0} Renk : {1}", model, renk);
        }
    }
    class Klasik : Otomobil
    {
        public int kapiSayisi;
        public override void Ozellik()
        {
            Console.WriteLine("Model : {0} Renk : {1} Kapi Sayisi : {2}", model, renk, kapiSayisi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil otoObj1 = new Otomobil();
            otoObj1.model = 2010;
            otoObj1.renk = "Kirmizi";
            otoObj1.Ozellik();

            Klasik otoObj2 = new Klasik();
            otoObj2.model = 1978;
            otoObj2.renk = "Mavi";
            otoObj2.kapiSayisi = 1;
            otoObj2.Ozellik();
        }
    }
}
