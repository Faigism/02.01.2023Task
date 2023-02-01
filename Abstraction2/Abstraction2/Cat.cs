using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    internal class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow...");
        }
    }
}
