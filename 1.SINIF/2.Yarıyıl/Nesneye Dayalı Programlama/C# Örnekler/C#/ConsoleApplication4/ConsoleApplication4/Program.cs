using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int urun = 0;
            double kar = 0;
            int adet = 0;
            urun++;
            while (urun < 5)
            {
                Console.Write("{0}. ürün adedini giriniz", urun);
                adet = Convert.ToInt32(Console.ReadLine());

                if (urun == 1)
                {
                    kar += ((240 * adet) * 9 / 100) + 200;
                }
                else if (urun == 2)
                {
                    kar += ((130 * adet) * 9 / 100) + 200;
                }
                else if (urun == 3)
                {
                    kar += ((100 * adet) * 9 / 100) + 200;
                }
                else if (urun == 4)
                {
                    kar += ((350 * adet) * 9 / 100) + 200;
                }
                urun++;
            }
            Console.WriteLine("toplam kar=  {0}", kar);
            Console.ReadKey();

        }
    }
}
