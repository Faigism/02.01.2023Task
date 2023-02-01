using System;
using System.Collections.Generic;
using System.Text;

namespace Student1
{
    internal class Student
    {
        static int _totalcount;

        static Student()
        {
            _totalcount = 100;
        }
        public Student()
        {
            _totalcount++;
            No = _totalcount;
        }

        public int No;
        public string Fullname;
        public byte Point;
    }
}
