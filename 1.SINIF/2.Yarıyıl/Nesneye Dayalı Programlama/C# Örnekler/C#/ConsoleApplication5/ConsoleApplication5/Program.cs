using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Random rnd = new Random();
            int[] dizi = new int[5];
            for (i = 0; i < 5; i++)
            {
                dizi[i] = rnd.Next(1, 10);
            }
            for (j = 0; j < 5; j++)
            {
                Console.Write(dizi[j]);
            }
            Console.ReadKey();
        }
    }
}
