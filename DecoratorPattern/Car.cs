using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract void GetFeatures();
        public abstract void GetPrice();
        
    }
}
