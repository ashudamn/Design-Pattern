using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class MyResource
    {
        public static readonly MyResource resource = new MyResource();
        public static  MyResource Instance
        {
            get
            {
                return resource;
            }
        }
        internal MyResource()
        {

        }
    }
}
