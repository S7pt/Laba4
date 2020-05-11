using _4._1.models;
using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            student1.setRating(95);
            student2.setRating(78);
            student3.setRating(60);
            Console.Write("Student 1: ");
            Console.WriteLine(student1.studentRating(student1.getRating()));
            Console.Write("Student 2: ");
            Console.WriteLine(student2.studentRating(student2.getRating()));
            Console.Write("Student 3: ");
            Console.WriteLine(student3.studentRating(student3.getRating()));
        }
    }

}
