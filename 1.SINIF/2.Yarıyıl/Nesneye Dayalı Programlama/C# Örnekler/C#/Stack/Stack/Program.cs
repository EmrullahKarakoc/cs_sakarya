using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            obj.Push("Galatasaray");
            obj.Push("Fenerbahçe");
            obj.Push("Beşiktaş");
            obj.Push("Trabzonspor");
            obj.Push("Bursaspor");

            foreach (object key in obj)
            {
                Console.WriteLine(key);
            }
            Console.ReadKey();
        }
    }
}
