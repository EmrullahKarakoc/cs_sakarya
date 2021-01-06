using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int enbuyuk = 0;
            int ikinci = 0;
            int sayi = 0;
            int sayac = 0;

            Console.Write("sayı giriniz :  ");
            enbuyuk = Convert.ToInt32(Console.ReadLine());

            Console.Write("sayı giriniz :  ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > enbuyuk)
            {
                enbuyuk = sayi;
                ikinci = enbuyuk;
            }
            else
                ikinci = sayi;
            sayac = 2;

            while (sayac < 10)
            {
                Console.Write("sayı giriniz :  ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > enbuyuk)
                {
                    enbuyuk = sayi;
                }
                else if (sayi > ikinci)
                {
                    ikinci = sayi;
                }
                sayac++;
            }
            Console.WriteLine("en büyük sayı : {0} , ikinci büyük sayı : {1}", enbuyuk, ikinci);
            Console.ReadKey();

        }
    }
}
