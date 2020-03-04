using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarIterator carIterator = new CarIterator();
            Console.WriteLine(carIterator.current());
            carIterator.next();
            Console.WriteLine(carIterator.current());
            Console.WriteLine("Is it the end ?"+carIterator.isDone());
            Console.ReadLine();
        }
    }
}
