using System;
using System.Collections.Generic;
using System.Text;

namespace Task02._01._2023
{
    internal interface IFurniture
    {
        string Name { get; }
        double Price { get; set; }
        double Size { get; set; }
        string Suitable { get; set; }

        void Convenience();
    }
}
