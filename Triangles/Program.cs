using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter c: ");
            int c = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("What do you want in life");
                string algorithm = Console.ReadLine().ToLower();

                if (algorithm == "obikolka")
                {
                    int result = a + b + c;
                    Console.WriteLine("Öbikolka: " + result);
                }
                if (algorithm == "area")
                {
                    int halfResult = (a + b + c) / 2;
                    double area = Math.Sqrt(halfResult * (halfResult - a) * (halfResult - b) * (halfResult - c));
                    Console.WriteLine(area);
                }
                if (algorithm == "the most")
                {
                    Console.Write("The biggest side is: ");
                    if (a > b && a > c)
                    {
                        Console.WriteLine(a);
                    }
                    else if (b > c && b > a)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                if (algorithm == "the least")
                {
                    Console.Write("The smallest side is: ");
                    if (a < b && a < c)
                    {
                        Console.WriteLine(a);
                    }
                    else if (b < c && b < a)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
    }
}
