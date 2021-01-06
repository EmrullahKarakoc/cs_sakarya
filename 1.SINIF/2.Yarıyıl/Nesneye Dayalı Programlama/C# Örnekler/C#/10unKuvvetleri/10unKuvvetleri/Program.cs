using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10unKuvvetleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("N sayısını giriniz = ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nN\t10*N\t100*N\t1000*N\n");
            for (int i = N; i < N + 5; i++)
            {
                Console.Write(i + "\t" + (10 * i) + "\t" + (100 * i) + "\t" + (1000 * i) + "\n");
            }
            Console.ReadKey();
        }
    }
}
