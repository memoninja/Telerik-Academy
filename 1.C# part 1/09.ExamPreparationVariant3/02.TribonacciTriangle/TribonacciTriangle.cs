using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TribonacciTriangle
{
    class TribonacciTriangle
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

            // T n = (T n-1) + (T n-2) + (T n-3)

            long[] numbers = new long[3];
            byte linesCountL;
            int sequenceLength = 0;
            long currentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            linesCountL = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= linesCountL; i++)
            {
                sequenceLength += i;
            }

            Console.WriteLine(numbers[0]);
            Console.WriteLine("{0} {1}", numbers[1], numbers[2]);

            for (int i = 3; i <= linesCountL; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    currentNumber = numbers[0] + numbers[1] + numbers[2];
                    if (m == i - 1)
                    {
                        Console.Write("{0}", currentNumber);
                    }
                    else
                    {
                        Console.Write("{0} ", currentNumber);
                    }

                    numbers[0] = numbers[1];
                    numbers[1] = numbers[2];
                    numbers[2] = currentNumber;
                }
                Console.WriteLine();
            }

            

        }
    }
}
