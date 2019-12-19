using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP
{
    public class Student
    {
        public string Name { get; set; }

        public string EGN { get; set; }

        public int Score { get; set; }

        public void Print()
        {
            Console.WriteLine("Student -----> ");
                Console.WriteLine("Name --> " + this.Name);
            Console.WriteLine("EGN --> " + this.EGN);
            Console.WriteLine("Score --> " + this.Score);
            Console.WriteLine("\n------------------------\n");
        }

        public void Read()
        {
            Console.WriteLine("Enter yourself: ");
            Console.Write("Your name is = ");
            this.Name = Console.ReadLine();

            Console.Write("Your EGN is = ");
            this.EGN = Console.ReadLine();

            Console.Write("How good are you = ");
            this.Score = int.Parse(Console.ReadLine());
        }

    }
}
