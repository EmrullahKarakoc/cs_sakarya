using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dikdortgen obj = new Dikdortgen();
            Dikdortgen obj2 = new Dikdortgen(5,10);

            /*Console.Write("Uzunluk giriniz..: ");
            obj.UZUNLUK = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genislik giriniz..: ");
            obj.GENISLIK = Convert.ToInt32(Console.ReadLine());*/
            Console.Write(obj2.ToString());
            Console.ReadKey();
        }
    }
}
