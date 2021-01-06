using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Yamuk
    {
        public int taban;
        public int tavan;
        public int yukseklik;

        public Yamuk()
        {
            taban = 4;
            tavan = 6;
            yukseklik = 8;

        }

        public Yamuk(int tb,int tv,int yu)
        {
            taban = tb;
            tavan = tv;
            yukseklik = yu;

        }
        public int Alan()
        {
            return (taban + tavan) / 2 * yukseklik;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Yamuk ym1 = new Yamuk();
            

            Console.WriteLine("Alan=" + ym1.Alan());

            Yamuk ym2 = new Yamuk(6,2,9);
           

            Console.WriteLine("Alan=" + ym2.Alan());
        }
    }
}
