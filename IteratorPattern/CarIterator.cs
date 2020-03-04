using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class CarIterator : Iiterator
    {
        private string[] Cars =
        {
            "Mercedes","Lamborgini","Audi","Bmw"
        };
        private int currentIndex=0;
        public object current()
        {
            return Cars[currentIndex];
        }

        public object first()
        {
            return Cars[0];
        }

        public bool isDone()
        {
            return Cars.Length == currentIndex;
        }

        public object next()
        {
            var item = Cars[currentIndex];
            currentIndex++;
            return item;
        }
    }
}
