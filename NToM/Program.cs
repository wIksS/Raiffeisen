using System;

namespace NToM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i <= m; i++)
            {
                result *= n;
            }

            Console.WriteLine(result);

        }
    }
}
