using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class OperatingSystemFactory : IOperatingSystemFactory
    {
        public IOperatingSystem getOperatingSystem(string osType)
        {
            IOperatingSystem operatingSystem;
            if (osType.Equals("LINUX"))
            {
                operatingSystem = new WindowsOS();
            }
            else if (osType.Equals("WINDOWS"))
            {
                operatingSystem = new LinuxOS();
            }
            else
            {
                operatingSystem = null;
            }
            return operatingSystem;
        }
    }
}
