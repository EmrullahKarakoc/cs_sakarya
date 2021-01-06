using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                if ((sayi % 2) == 0)
                {
                    Console.WriteLine("Pozitif Çift Sayı");
                }
                else
                {
                    Console.WriteLine("Pozitif Tek Sayı");
                }
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayı 0 dır");
            }
            else
            {
                Console.WriteLine("Sayı Negatif");
            }
            Console.ReadLine();
        }
    }
}
