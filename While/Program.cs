using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter algorithm: ");

                string algorithm = Console.ReadLine();
                int result = 0;

                if (algorithm == "+")
                {
                    result = a + b;
                }
                if (algorithm == "-")
                {
                    result = a - b;
                }
                if (algorithm == "/")
                {
                    result = a / b;
                }
                if (algorithm == "*")
                {
                    result = a * b;
                }

                Console.WriteLine(a + " " + algorithm + b + "  = " + result);
            }
        }
    }
}
