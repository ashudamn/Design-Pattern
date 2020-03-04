using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyResource myResource1 = MyResource.Instance;
            MyResource myResource2 = MyResource.Instance;
            if (myResource1 == myResource2)
            {
                Console.WriteLine("resources are equal");
            }
            Console.ReadLine();
        }
    }
}
