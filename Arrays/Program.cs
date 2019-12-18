using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = (i + 1) * 5;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
