using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaireAlani
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double alan, cevre;
            int r;
            Console.Write("Yarıcap giriniz = ");
            r = Convert.ToInt32(Console.ReadLine());
            cevre = 2 * pi * r;
            // Math.Pow üs alma 
            // Math.PI pi sayısı
            alan = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Alan = " + alan);
            Console.WriteLine("Çevre = " + cevre);
            Console.ReadLine();
        }
    }
}
