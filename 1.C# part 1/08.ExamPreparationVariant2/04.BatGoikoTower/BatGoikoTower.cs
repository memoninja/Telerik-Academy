using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BatGoikoTower
{
    class BatGoikoTower
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

            int inputHeight;
            int sideDots;
            int insideDashesRow = 1;
            int insideDots = 0;
            int dashCounter = 2;

            inputHeight = int.Parse(Console.ReadLine());
            sideDots = inputHeight - 1;

            for (int i = 0; i < inputHeight; i++)
            {
                Console.Write(new string('.', sideDots));
                Console.Write('/');
                if (i == insideDashesRow)
                {
                    Console.Write(new string('-', insideDashesRow * 2));
                    insideDashesRow += dashCounter;
                    dashCounter++;
                }
                else
                {
                    Console.Write(new string('.', insideDots));
                }

                Console.Write('\\');
                Console.Write(new string('.', sideDots));
                Console.WriteLine();
                
                insideDots += 2;
                sideDots--;
            }
        }
    }
}
