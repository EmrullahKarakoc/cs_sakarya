using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi, max_Sayi, min_Sayi;
            min_Sayi = 0;
            max_Sayi = 0;
            for (i = 0; i < 4; i++)
            {
                Console.Write((i + 1) + ".Sayiyi giriniz..:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > max_Sayi)
                {
                    max_Sayi = sayi;
                    Console.WriteLine("En buyuk sayi..:" + max_Sayi);
                    Console.WriteLine("2. Buyuk sayi...:" + min_Sayi);
                }
                else if ((sayi < max_Sayi) && (sayi > min_Sayi))
                {
                    min_Sayi = sayi;
                    Console.WriteLine("En buyuk sayi..:" + max_Sayi);
                    Console.WriteLine("2. Buyuk sayi...:" + min_Sayi);
                }
                else if ((sayi < max_Sayi) && (min_Sayi > max_Sayi))
                {
                    min_Sayi = max_Sayi;
                    Console.WriteLine("En buyuk sayi..:" + max_Sayi);
                    Console.WriteLine("2. Buyuk sayi...:" + min_Sayi);
                }
            }
            //Console.WriteLine("En buyuk sayi..:" + max_Sayi);
            //Console.WriteLine("2. Buyuk sayi...:" + min_Sayi);
            Console.ReadKey();
        }
    }
}
