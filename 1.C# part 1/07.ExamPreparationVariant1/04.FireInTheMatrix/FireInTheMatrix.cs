using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FireInTheMatrix
{
    class FireInTheMatrix
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
            if (inputN < 0)
            {
                inputN *= -1;
            }
            int sideSpaces = (inputN - 2) / 2;
            int insideSpaces = 0;
            int slashes = inputN / 2;

            for (int i = 1; i <= inputN / 2; i++)
            {
                Console.Write(new string('.', sideSpaces));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', insideSpaces));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', sideSpaces));
                Console.WriteLine();

                if (sideSpaces >= 1)
                {
                    sideSpaces--;
                }

                insideSpaces += 2;
            }

            insideSpaces -= 2;

            for (int i = 1; i <= inputN / 4; i++)
            {
                Console.Write(new string('.', sideSpaces));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', insideSpaces));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', sideSpaces));
                Console.WriteLine();

                sideSpaces++;
                insideSpaces -= 2;
            }

            Console.WriteLine(new string('-', inputN));

            for (int i = 0; i < inputN / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('\\', slashes));
                Console.Write(new string('/', slashes));
                Console.Write(new string('.', i));
                Console.WriteLine();
                slashes--;
            }
        }
    }
}
