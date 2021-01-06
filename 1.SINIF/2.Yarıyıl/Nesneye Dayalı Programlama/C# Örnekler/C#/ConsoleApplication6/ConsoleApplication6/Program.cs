using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Alan
    {
        protected int Hesapla(int genislik, int yukseklik)
        {
            return genislik * yukseklik;
        }
    }
    class Yazdir : Alan
    {
        public void Yaz(int g, int y)
        {
            Console.WriteLine("Dikdortgenin Alani...: {0}", Hesapla(g, y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int genislik, yukseklik;
            Console.Write("Genislik giriniz..: ");
            genislik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yukseklik giriniz..: ");
            yukseklik = Convert.ToInt32(Console.ReadLine());
            Yazdir obj = new Yazdir();
            obj.Yaz(genislik, yukseklik);
            Console.ReadKey();
        }
    }
}
