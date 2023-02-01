using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Student
    {
        public Student()
        {
            TotalCount++;
        }
        static public int TotalCount; 
        public string FullName;
        public byte Point;
        

        static public void Show()
        {
            Console.WriteLine();
        }
    }
}
