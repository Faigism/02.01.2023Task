using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Student std1= new Student();
            Student std2 = new Student();
            Student std3 = new Student();
            Student std4 = new Student();

            std1.FullName = "Hikmet";
            std2.FullName = "Faiq";
            std3.FullName = "Aynur";
            std4.FullName = "Nermin";
            Student.Show();

            Console.WriteLine(Student.TotalCount);


        }
    }
}
