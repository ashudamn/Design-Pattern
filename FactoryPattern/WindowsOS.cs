using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WindowsOS:IOperatingSystem
    {
        public WindowsOS()
        {
            Console.WriteLine("Windows os created");
        }
    }
}
