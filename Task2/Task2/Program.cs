using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("Ad daxil edin: ");
                string name = Console.ReadLine();
                string groupNo;
                do
                {
                    Console.WriteLine("Qrup nomresi daxil edin: ");
                    groupNo = Console.ReadLine();
                } while (!Student.CheckGroupNo(groupNo));
                Student std = new Student();
                Console.WriteLine($"Ad: {name} - Qrup No: {groupNo} - №: {std.No}");
            } while (true);
            
        }
    }
}
