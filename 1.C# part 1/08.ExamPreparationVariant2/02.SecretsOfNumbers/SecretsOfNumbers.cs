using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SecretsOfNumbers
{
    class SecretsOfNumbers
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

            BigInteger inputN = BigInteger.Parse(Console.ReadLine());
            int indexCounter = 1;
            BigInteger specialSum = 0;
            int alphaSequenceLength;
            int R;
            int alphabetCounter;

            if (inputN < 0)
            {
                inputN *= -1;
            }

            char[] digitsArray = inputN.ToString().ToCharArray();

            for (int i = digitsArray.Length - 1; i >= 0; i--)
            {
                if ((indexCounter & 1) == 1)
                {
                    specialSum += (indexCounter * indexCounter) * (digitsArray[i] - '0');
                }
                else
                {
                    specialSum += indexCounter * ((digitsArray[i] - '0') * (digitsArray[i] - '0'));
                }

                indexCounter++;
            }

            alphaSequenceLength = (int)specialSum % 10;

            R = (int)specialSum % 26;
            alphabetCounter = R + 65;

            Console.WriteLine(specialSum);

            if (alphaSequenceLength > 0)
            {
                for (int i = 1; i <= alphaSequenceLength; i++)
                {
                    Console.Write((char)alphabetCounter);

                    alphabetCounter++;
                    if (alphabetCounter == 91)
                    {
                        alphabetCounter = 65;
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", inputN);
            }
        }
    }
}
