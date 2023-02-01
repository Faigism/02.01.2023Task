using System;
using System.Collections.Generic;
using System.Text;

namespace Task02._01._2023
{
    internal abstract class Equipment
    {
        protected double teritory_capacity;
        public Equipment(double size)
        {
            teritory_capacity= size;
        }
    }
}
