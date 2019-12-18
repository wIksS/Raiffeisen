using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> raifaizenList = new List<int>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                raifaizenList.Add(i);
            }

            for (int i = 0; i < raifaizenList.Count; i++)
            {
                Console.WriteLine(raifaizenList[i]);
            }
        }
    }
}
