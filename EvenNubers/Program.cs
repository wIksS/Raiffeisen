using System;

namespace EvenNubers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter: Array[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2==0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
