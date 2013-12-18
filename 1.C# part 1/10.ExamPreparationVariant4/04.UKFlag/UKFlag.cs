using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UKFlag
{
    class UKFlag
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

            for (int i = 0; i < inputN / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('\\');
                Console.Write(new string('.', (inputN - 3) / 2 - i));
                Console.Write('|');
                Console.Write(new string('.', (inputN - 3) / 2 - i));
                Console.Write('/');
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            Console.Write(new string('-', inputN / 2));
            Console.Write('*');
            Console.Write(new string('-', inputN / 2));
            Console.WriteLine();

            for (int i = inputN / 2; i > 0; i--)
            {
                Console.Write(new string('.', i - 1));
                Console.Write('/');
                Console.Write(new string('.', (inputN - 3) / 2 - i + 1));
                Console.Write('|');
                Console.Write(new string('.', (inputN - 3) / 2 - i + 1));
                Console.Write('\\');
                Console.Write(new string('.', i - 1));
                Console.WriteLine();
            }


        }
    }
}
