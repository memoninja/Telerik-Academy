using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poker
{
    class Poker
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

            char[] givenCards = new char[5];
            int[] pairsCount = new int[2];
            int counter = 0;
            char[] buffers = new char[2];
            char bufferTwo;
            int pairCounter = 0;
            char takenCard1 = '*';
            bool isStraight = true;
            string inputString;

            for (int i = 0; i < givenCards.Length; i++)
            {
                inputString = Console.ReadLine();
                if (inputString.Equals("10"))
                {
                    inputString = ":";
                }

                givenCards[i] = inputString[0];
            }


            for (int i = 0; i < givenCards.Length; i++)
            {
                if (givenCards[i] == 65)
                {
                    givenCards[i] = (char)49;
                }
                else if (givenCards[i] == 74)
                {
                    givenCards[i] = (char)59;
                }
                else if (givenCards[i] == 81)
                {
                    givenCards[i] = (char)60;
                }
                else if (givenCards[i] == 75)
                {
                    givenCards[i] = (char)61;
                }
            }

            Array.Sort(givenCards);

            for (int i = 0; i < givenCards.Length - 1; i++)
            {
                if (givenCards[i] + 1 != givenCards[i + 1])
                {
                    isStraight = false;
                }
            }

            if (isStraight == false)
            {
                isStraight = true;
                for (int i = 0; i < givenCards.Length; i++)
                {
                    if (givenCards[i] == 49)
                    {
                        givenCards[i] = (char)62;
                    }
                }
                Array.Sort(givenCards);
                for (int i = 0; i < givenCards.Length - 1; i++)
                {
                    if (givenCards[i] + 1 != givenCards[i + 1])
                    {
                        isStraight = false;
                    }
                }
            }

            for (int i = 0; i < givenCards.Length; i++)
            {
                pairCounter = 0;
                bufferTwo = givenCards[i];
                givenCards[i] = takenCard1;
                for (int m = 0; m < givenCards.Length; m++)
                {
                    if (!bufferTwo.Equals(takenCard1) && bufferTwo.Equals(givenCards[m]))
                    {
                        givenCards[m] = takenCard1;
                        pairCounter++;
                    }
                }

                if (pairCounter > 0)
                {
                    buffers[counter] = bufferTwo;
                    pairsCount[counter] = pairCounter;
                    counter++;
                }
            }

            if (isStraight == true)
            {
                Console.WriteLine("Straight");
            }
            else if ((pairsCount[0] == 1 && pairsCount[1] == 2) || (pairsCount[1] == 1 && pairsCount[0] == 2))
            {
                Console.WriteLine("Full House");
            }
            else if (pairsCount[0] == 4 || pairsCount[1] == 4)
            {
                Console.WriteLine("Impossible");
            }
            else if (pairsCount[0] == 3 || pairsCount[1] == 3)
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (pairsCount[0] == 2 || pairsCount[1] == 2)
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (pairsCount[0] == 1 && pairsCount[1] == 1)
            {
                Console.WriteLine("Two Pairs");
            }
            else if (pairsCount[0] == 1 || pairsCount[1] == 1)
            {
                Console.WriteLine("One Pair");
            }
            else if (pairsCount[0] == 0 || pairsCount[1] == 0)
            {
                Console.WriteLine("Nothing");
            }
            else
            {
                Console.WriteLine("Error!!!");
            }

        }
    }
}
