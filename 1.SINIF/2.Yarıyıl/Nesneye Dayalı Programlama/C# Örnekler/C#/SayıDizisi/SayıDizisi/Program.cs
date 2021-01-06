using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıDizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            int i = 0;
            int j = 0;
            int sayi;
            while (i < 5)
            {
                Console.Write((i + 1) + ". sayiyi giriniz..:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi < 10) || (sayi > 100))
                {
                    Console.WriteLine("Hatali giris! 10-100 arasinda sayi giriniz...");
                }
                else 
                {
                    for (j = 0; j <= i; j++)
                    {
                        if (sayi == dizi[j])
                        {
                            Console.WriteLine("Bu sayi daha once girilmistir...");
                        }
                        else
                        {
                            dizi[j] = sayi;
                        }
                    }
                    i++;
                }
            }          
            Console.WriteLine("Dizi Elemanlari");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ". sayi..:" + dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
