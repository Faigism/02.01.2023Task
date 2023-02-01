using System;

namespace Abstraction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.MakeSound();
            dog.MakeSound();
        }
    }
}
