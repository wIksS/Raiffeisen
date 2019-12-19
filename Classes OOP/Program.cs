using System;
using System.Collections.Generic;

namespace Classes_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("1 for new student, -1 to print all students");
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                Student student = new Student();
                student.Read();
                students.Add(student);
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Print();
            }
        }
    }
}






