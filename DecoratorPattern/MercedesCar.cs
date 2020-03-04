using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MercedesCar : Car
    {

        public override void GetFeatures()
        {
            Console.WriteLine("Basic Mercedes");
        }

        public override void GetPrice()
        {
            Console.WriteLine("The Price of basic is 10000");
        }
    }
}
