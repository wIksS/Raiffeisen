using System;
using System.Collections.Generic;
using System.Text;

namespace EGNGenerator
{
    public class EGN
    {
        private int[] weights = new int[] { 2,4,8,5,10,9,7,3,6};
        private int[] even = new int[] {0, 2, 4, 6,8};
        private int[] odds = new int[] { 1,3,5,7,9 };


        public string NewEGN { get; set; }

        public void CreateNewEGN(string realEGN)
        {
            Random random = new Random();
            StringBuilder newEgn = new StringBuilder(realEGN);

            newEgn[6] = (char)(random.Next(0, 10) + 48);
            newEgn[7] = (char)(random.Next(0, 10) + 48);
            if (int.Parse(newEgn[8].ToString()) % 2 ==0)
            {
                newEgn[8] = (char)(even[random.Next(0,5)] + 48);
            }
            else
            {
                newEgn[8] = (char)(odds[random.Next(0, 5)] + 48);
            }

            int sumWeights = 0;
            for (int i = 0; i < newEgn.Length-1; i++)
            {
                int current = int.Parse(newEgn[i].ToString());
                sumWeights += current * weights[i];
            }


            int last = int.Parse(newEgn[9].ToString());
            int newLast = sumWeights % 11;
            if (newLast == 10)
            {
                newLast = 0;
            }
          

            newEgn[9] = (char)(newLast + 48);
            NewEGN = newEgn.ToString();
        }
    }
}
