using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Student
    {
        static byte count;
        public Student()
        {
            count++;
            this.No = count;
        }
        public byte No;
        public string Name;
        string _groupNo;
        public string GroupNo
        {
            set
            {
                if(CheckGroupNo(value))
                    _groupNo = value;
            }
            get
            {
                return _groupNo;
            }
        }

        public static bool CheckGroupNo(string str)
        {
            if(string.IsNullOrEmpty(str))
            if (!char.IsUpper(str[0]))
                    return false;
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
    }
}
