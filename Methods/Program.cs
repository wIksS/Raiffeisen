using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("1 - sum 2 - sub 3 - divide");
                string command = Console.ReadLine();
                int result = 44;
                if (command == "1")
                {
                    result = Sum(a, b);
                }
                if (command == "2")
                {
                    result = Multiply(a, b);
                }
                if (command == "3")
                {
                    result = Substract(a, b);
                }

                Console.WriteLine(result);
            }
         
        }

        static int Sum(int baipesho, int b)
        {
            int sum = baipesho + b;
            return sum;
        }

        static int Multiply(int baipesho, int b)
        {
            int sum = baipesho * b;
            return sum;
        }

        static int Division(int baipesho, int b)
        {
            int sum = baipesho / b;
            return sum;
        }

        static int Substract(int baipesho, int b)
        {
            int sum = baipesho - b;
            return sum;
        }
    }
}
