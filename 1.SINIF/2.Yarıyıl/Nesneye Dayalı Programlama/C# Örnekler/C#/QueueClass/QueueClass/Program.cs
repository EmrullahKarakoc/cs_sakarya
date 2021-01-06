using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = {"Ali","Beyza","Hayri"};
            Queue obj = new Queue(dizi);
            Console.WriteLine("Dizinin Eleman Sayisi : " + obj.Count);

            while (obj.Count != 0)
            {
                Console.WriteLine(obj.Dequeue());
            }
        }
    }
}
