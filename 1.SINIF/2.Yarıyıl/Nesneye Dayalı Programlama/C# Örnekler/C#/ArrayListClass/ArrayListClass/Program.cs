using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ali");
            list.Add(5);
            list.Add(8.5);
            //list.Insert(2, 6);
            list.RemoveAt(1);
            foreach (object value in list)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
