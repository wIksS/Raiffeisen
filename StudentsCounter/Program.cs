using System;
using System.Collections.Generic;

namespace StudentsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            bool isOver = false;
            while (!isOver)
            {
                Console.WriteLine("Enter a student name or -1 to end day");
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    isOver = true;
                }
                else
                {
                    students.Add(input);
                }
            }

            for (int i = 0; i < students.Count; i++)
            {
                Console.Write("Array[{0}]=",i);
                Console.WriteLine(students[i]);
            }
        }
    }
}
