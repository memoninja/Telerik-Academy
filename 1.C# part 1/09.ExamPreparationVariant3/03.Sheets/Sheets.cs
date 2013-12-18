using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            /*This program are made only to practice, so there are not enough comments!
              The programs are made just to score 100 points!
              No additional optimization were made!
              Sorry if the code is unreadable!!!
              Do not have time to make it readable!
            */

            // 100 Points

            int inputNumber = int.Parse(Console.ReadLine());
            int currentSum = inputNumber;

            int[] set = { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            bool[] usedPapers = { false, false, false, false, false, false, false, false, false, false, false };

            for (int i = 0; i < set.Length; i++)
            {
                if (currentSum >= set[i])
                {
                    usedPapers[i] = true;
                    currentSum -= set[i];
                    if (currentSum == 0)
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < set.Length; i++)
            {
                if (!usedPapers[i])
                {
                    Console.WriteLine("A{0}", i);
                }
            }
        }
    }
}
