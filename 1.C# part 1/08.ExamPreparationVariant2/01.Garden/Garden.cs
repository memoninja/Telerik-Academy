using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Garden
{
    class Garden
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

            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());

            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());

            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());

            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());

            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());

            int beansSeeds = int.Parse(Console.ReadLine());

            int totalArea = 250;
            int remainingArea;
            double totalSeedsCost;

            totalSeedsCost = tomatoSeeds * 0.5 + cucumberSeeds * 0.4 + potatoSeeds * 0.25 + carrotSeeds * 0.6 + cabbageSeeds * 0.3 + beansSeeds * 0.4;
            Console.WriteLine("Total costs: {0:F2}", totalSeedsCost);

            remainingArea = totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

            if (remainingArea > 0)
            {
                Console.WriteLine("Beans area: {0}", remainingArea);
            }
            else if (remainingArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }

        }
    }
}
