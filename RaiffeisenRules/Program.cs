using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
       
            int thousands = (n / 100) % 10;
            int decimals = (n / 10) % 10;
            int ones = n % 10;
            Console.WriteLine("Thousands: {0}, Deicamls: {1}, Ones: {2}",thousands,decimals,ones);
   
            if (decimals == 2)
            {
                Console.Write("twenty ");
            }
            if (decimals == 3)
            {
                Console.Write("thirty ");
            }
            if (decimals == 4)
            {
                Console.Write("forty ");
            }
            if (decimals == 5)
            {
                Console.Write("fifty ");
            }
            if (ones == 0)
            {
                Console.WriteLine("zero");
            }
            if (ones == 1)
            {
                Console.WriteLine("one");
            }
            if (ones == 2)
            {
                Console.WriteLine("two");
            }
            if (ones == 3)
            {
                Console.WriteLine("three");
            }
            if (ones == 4)
            {
                Console.WriteLine("four");
            }
            if (ones == 5)
            {
                Console.WriteLine("five");
            }
            if (ones == 6)
            {
                Console.WriteLine("six");
            }
            if (ones == 7)
            {
                Console.WriteLine("seven");
            }
            if (ones == 8)
            {
                Console.WriteLine("eight");
            }
            if (ones == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}