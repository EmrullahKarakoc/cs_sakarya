using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            int i = 1;
            //for (int i = 1; i <= 10; i+=2)
            //{
            //    Console.WriteLine("i = " + i);
            //    sonuc = sonuc + i;
            //}
            //Console.WriteLine("Sonuc = " + sonuc);
            //Console.ReadLine();
            //while (i <= 10)
            //{
            //    Console.WriteLine("i = " + i);
            //    sonuc = sonuc + i;
            //    i++;
            //}
            do
            {
                Console.WriteLine("i = " + i);
                sonuc = sonuc + i;
                i++;
            }
            while (i < 11);
            Console.WriteLine("Sonuc = " + sonuc);
            Console.ReadLine();
        }
    }
}
