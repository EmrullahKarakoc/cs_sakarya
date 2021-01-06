using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceClass
{
    class temel_sinif
    {
        protected void method1()
        {
            Console.WriteLine("ben temel sınıf methoduyum");
        }
    }
    class tureyen_sinif:temel_sinif
    {
        public void method2()
        {
            Console.WriteLine("ben tureyen sinif methoduyum");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            tureyen_sinif obj = new tureyen_sinif();
            obj.method2();
        }
    }
}
