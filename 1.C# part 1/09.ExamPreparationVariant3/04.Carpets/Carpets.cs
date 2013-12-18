using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Carpets
{
    class Carpets
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

            int inputN = int.Parse(Console.ReadLine());
            int currentRow = inputN;
            int topsCount = 0;

            for (int i = 1; i <= inputN / 2; i++)
            {
                Console.Write(new string('.', currentRow / 2 - 1));
                Console.Write('/');

                if (i != 1 && i % 2 != 0)
                {
                    topsCount++;
                }

                for (int m = 0; m < topsCount; m++)
                {
                    Console.Write(" /");
                }

                if (i % 2 == 0)
                {
                    Console.Write("  ");
                }

                for (int n = 0; n < topsCount; n++)
                {
                    Console.Write("\\ ");
                }

                Console.Write('\\');
                Console.Write(new string('.', currentRow / 2 - 1));

                Console.WriteLine();
                currentRow -= 2;
            }

            currentRow = 0;

            for (int i = inputN / 2; i >= 1; i--)
            {
                Console.Write(new string('.', currentRow));
                Console.Write('\\');

                for (int m = topsCount; m > 0; m--)
                {
                    Console.Write(" \\");
                }

                if (i % 2 == 0)
                {
                    Console.Write("  ");
                }

                for (int n = topsCount; n > 0; n--)
                {
                    Console.Write("/ ");
                }

                Console.Write('/');
                Console.Write(new string('.', currentRow));

                Console.WriteLine();
                currentRow++;

                if (i % 2 != 0)
                {
                    topsCount--;
                }
            }
        }
    }
}
