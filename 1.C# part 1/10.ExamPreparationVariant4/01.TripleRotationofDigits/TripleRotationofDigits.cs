using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TripleRotationofDigits
{
    class TripleRotationofDigits
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

            int inputK = int.Parse(Console.ReadLine());

            char[] kDigits = inputK.ToString().ToCharArray();
            char buffer;
            int numberToRemoveZero;

            for (int i = 0; i < 3; i++)
            {
                buffer = kDigits[kDigits.Length - 1]; // Take last digit
                for (int m = kDigits.Length - 1; m > 0; m--)
                {
                    kDigits[m] = kDigits[m - 1];
                }
                kDigits[0] = buffer;

                if (buffer.Equals('0'))
                {
                    string removeZero = new string(kDigits);
                    numberToRemoveZero = int.Parse(removeZero);
                    kDigits = numberToRemoveZero.ToString().ToCharArray();
                }
            }

            for (int i = 0; i < kDigits.Length; i++)
            {
                Console.Write(kDigits[i]);
            }
        }
    }
}
