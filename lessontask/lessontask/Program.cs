using System;

namespace lessontask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                FullName = "Hikmet",
                GroupNo = "P123",
                
            };
            Student student2 = new Student()
            {
                FullName = "Nezrin",
                GroupNo = "P123",

            };
            Student student3 = new Student()
            {
                FullName = "Abbas",
                GroupNo = "P123",

            };

            Console.WriteLine(student1.No);
            Console.WriteLine("Total Students:"+Student.TotalCount);

            Student.CheckGroupNo();
        }
    }
}
