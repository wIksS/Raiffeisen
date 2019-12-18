using System;
using System.Linq;

namespace SumAndBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("The sum is: " + sum);

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            Console.WriteLine("The biggest element is: " + max);
        }
    }
}
