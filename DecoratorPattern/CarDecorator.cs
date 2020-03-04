using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CarDecorator : Car
    {
        private Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }
        public override void GetFeatures()
        {
            _car.GetFeatures();
        }

        public override void GetPrice()
        {
            _car.GetPrice();
        }
    }
}
