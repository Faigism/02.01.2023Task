using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Bicycle:Vehicle
    {
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}
