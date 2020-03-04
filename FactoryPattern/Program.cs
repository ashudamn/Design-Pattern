using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperatingSystemFactory operatingSystemFactory = new OperatingSystemFactory();
            operatingSystemFactory.getOperatingSystem("WINDOWS");
            operatingSystemFactory.getOperatingSystem("LINUX");
        }
    }
}
