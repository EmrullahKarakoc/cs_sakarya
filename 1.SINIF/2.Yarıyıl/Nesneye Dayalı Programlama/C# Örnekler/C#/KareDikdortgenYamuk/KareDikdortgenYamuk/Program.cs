using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdortgenYamuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Yazdir(new Kare(5));
            Yazdir(new Dikdortgen(2, 3));
            Yazdir(new Yamuk(2, 3, 6));
        }

        static void Yazdir(Sekil s)
        {
            Console.WriteLine(s.AlanHesapla());
        }
    }
}
