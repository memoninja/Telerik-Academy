using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.QuadronacciRectangle
{
    class QuadronacciRectangle
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

            long inputA = long.Parse(Console.ReadLine());
            long inputB = long.Parse(Console.ReadLine());
            long inputC = long.Parse(Console.ReadLine());
            long inputD = long.Parse(Console.ReadLine());
            long sumOfFourNUmbers = 0;
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            long[] sequenceNumbers = new long[rows * cols];
            sequenceNumbers[0] = inputA;
            sequenceNumbers[1] = inputB;
            sequenceNumbers[2] = inputC;
            sequenceNumbers[3] = inputD;
            byte currentRow = 1;

            for (int i = 4; i < rows * cols; i++)
            {
                sumOfFourNUmbers = sequenceNumbers[i - 4] + sequenceNumbers[i - 3] + sequenceNumbers[i - 2] + sequenceNumbers[i - 1];
                sequenceNumbers[i] = sumOfFourNUmbers;
            }

            for (int i = 0; i < rows * cols; i++)
            {
                if (i == cols * currentRow)
                {
                    currentRow++;
                    Console.WriteLine();
                }
                Console.Write("{0} ", sequenceNumbers[i]);
            }
        }
    }
}
