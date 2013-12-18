using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NeuronMappingWithArray
{
    class NeuronMappingWithArray
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

            long[] numbersArray = new long[100];
            int i = 0;

            while (true)
            {
                numbersArray[i] = long.Parse(Console.ReadLine());

                if (numbersArray[i] == -1)
                {
                    break;
                }
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                if (numbersArray[j] == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    string inputNumberToBinary = Convert.ToString(numbersArray[j], 2);

                    int first1 = 0;

                    for (int m = 0; m < inputNumberToBinary.Length; m++)
                    {
                        if (first1 + 1 < inputNumberToBinary.Length && inputNumberToBinary[first1] == inputNumberToBinary[first1 + 1]) //first1 < inputNumberToBinary.Length && 
                        {
                            first1++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int second1 = inputNumberToBinary.IndexOf('1', (first1 + 1));

                    if (second1 - first1 > 0)
                    {
                        if (second1 == -1)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            int countOfZeroes = inputNumberToBinary.Length - second1;
                            int countOfOnes = second1 - first1 - 1;

                            string ones = new string('1', countOfOnes);
                            string zeroes = new string('0', countOfZeroes);
                            string finalNumToString = string.Concat(ones, zeroes);

                            Console.WriteLine(Convert.ToInt32(finalNumToString, 2).ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }
    }
}
