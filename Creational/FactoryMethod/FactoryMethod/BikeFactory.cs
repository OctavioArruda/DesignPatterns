﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class BikeFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
