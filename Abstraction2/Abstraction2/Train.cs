using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    internal class Train:IVehicle
    {
        double _mileage;
        public void Drive(double km)
        {
            _mileage += km;
        }
    }
}
