using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LinuxOS:IOperatingSystem
    {
        public LinuxOS()
        {
            Console.WriteLine("Linux OS is created");
        }
    }
}
