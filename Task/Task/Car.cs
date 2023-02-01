using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Car:Vehicle
    {
        public double CurrentFuel;
        public double FuelFor1km;
        public override void Drive(double km)
        {
            Mileage += km;
            CurrentFuel -= km * FuelFor1km;
        }
    }
}
