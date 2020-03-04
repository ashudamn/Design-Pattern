using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface Iiterator
    {
        object current();
        object next();
        bool isDone();
        object first();

    }
}
