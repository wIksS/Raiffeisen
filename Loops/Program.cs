using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                for (int j = i; j < n / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                stars += 2;
                Console.WriteLine();
            }

        }
    }
}
