using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormulaBit1
{
    class FormulaBit1
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

            int[] trackNumbers = new int[8];
            int countTurns = 0;
            int trackLength = 0;
            int currentNumber = 0;
            int currentBit = 0;

            for (int i = 0; i < trackNumbers.Length; i++)
            {
                trackNumbers[i] = int.Parse(Console.ReadLine());
            }



            while (true)
            {
                int mask = 1 << 0;
                if ((trackNumbers[0] & mask) != 0)
                {
                    trackLength -= 1;
                    break;
                }

                mask = 1 << currentBit;
                while (true) // Move Down
                {
                    if (currentNumber == 7 && currentBit == 7)
                    {
                        Console.WriteLine("{0} {1}", (trackLength + 1), countTurns);
                        return;
                    }

                    if ((currentNumber < trackNumbers.Length - 1) && (trackNumbers[currentNumber + 1] & mask) == 0)
                    {
                        currentNumber++;
                        trackLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentBit < 7)
                {
                    mask = 1 << (currentBit + 1);
                    if ((trackNumbers[currentNumber] & mask) != 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

                countTurns++;
                //-------------------------------------------------------------
                while (true) // Move Left
                {
                    if (currentNumber == 7 && currentBit == 7)
                    {
                        Console.WriteLine("{0} {1}", (trackLength + 1), countTurns);
                        return;
                    }

                    if (currentBit < 7)
                    {
                        mask = 1 << (currentBit + 1);
                        if ((trackNumbers[currentNumber] & mask) == 0)
                        {
                            currentBit++;
                            trackLength++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                mask = 1 << currentBit;
                if (!(currentNumber > 0) || (trackNumbers[currentNumber - 1] & mask) != 0)
                {
                    break;
                }

                countTurns++;
                //-------------------------------------------------------------
                while (true) // Move Up
                {
                    mask = 1 << currentBit;
                    if ((currentNumber > 0) && (trackNumbers[currentNumber - 1] & mask) == 0)
                    {
                        currentNumber--;
                        trackLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentBit < 7)
                {
                    mask = 1 << (currentBit + 1);
                    if ((trackNumbers[currentNumber] & mask) != 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

                countTurns++;
                //-------------------------------------------------------------
                while (true) // Move Left
                {
                    if (currentNumber == 7 && currentBit == 7)
                    {
                        Console.WriteLine("{0} {1}", (trackLength + 1), countTurns);
                        return;
                    }
                    if (currentBit < 7)
                    {
                        mask = 1 << (currentBit + 1);
                        if ((trackNumbers[currentNumber] & mask) == 0)
                        {
                            currentBit++;
                            trackLength++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                mask = 1 << currentBit;
                if (!(currentNumber < trackNumbers.Length - 1) || (trackNumbers[currentNumber + 1] & mask) != 0)
                {
                    break;
                }

                countTurns++;
                //-------------------------------------------------------------

            }

            if (currentNumber == 7 && currentBit == 7)
            {
                Console.WriteLine("{0} {1}", (trackLength + 1), countTurns);
            }
            else
            {
                Console.WriteLine("No {0}", (trackLength + 1));
            }
        }
    }
}
