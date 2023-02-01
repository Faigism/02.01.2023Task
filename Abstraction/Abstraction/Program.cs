using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "mestan";
            cat.Age = 1;

            Dog dog = new Dog();
            dog.Name = "Artur";
            dog.Age = 2;

            cat.MakeSound();
            dog.MakeSound();
            
        }
    }
}
