using System;

namespace EGNGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                EGN egn = new EGN();
                string realEgn = Console.ReadLine();
                egn.CreateNewEGN(realEgn);
                Console.WriteLine("Fake egn: " + egn.NewEGN);
            }

        }
    }
}
