﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LeatherSeats:CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }

    }
}
