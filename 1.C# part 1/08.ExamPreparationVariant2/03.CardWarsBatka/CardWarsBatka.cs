using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardWarsBatka
{
    class CardWarsBatka
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

            int inputN;
            string[] playersCards;
            BigInteger totalScorePlayerOne = 0;
            BigInteger totalScorePlayerTwo = 0;

            int gamesWonPlayerOne = 0;
            int gamesWonPlayerTwo = 0;

            inputN = int.Parse(Console.ReadLine());
            

            playersCards = new string[inputN * 6];

            for (int i = 0; i < playersCards.Length; i++)
            {
                playersCards[i] = Console.ReadLine();
            }


            int currentScorePlayerOne = 0;
            int currentScorePlayerTwo = 0;

            bool xCardPlayerOne = false;
            bool xCardPlayerTwo = false;



            string[] cards = { "A", "10", "9", "8", "7", "6", "5", "4", "3", "2", "J", "Q", "K", "Z", "Y", "X" };

            int n = 0;

            for (int j = 0; j < inputN; j++)
            {
                xCardPlayerOne = false;
                xCardPlayerTwo = false;

                currentScorePlayerOne = 0;
                currentScorePlayerTwo = 0;

                if ((n + 3) <= playersCards.Length)
                {

                    for (int m = n; m < n + 3; m++)
                    {
                        for (int i = 0; i < cards.Length; i++)
                        {
                            if (playersCards[m].Equals(cards[i]))
                            {
                                if (playersCards[m].Equals("Z"))
                                {
                                    totalScorePlayerOne *= 2;
                                }
                                else if (playersCards[m].Equals("Y"))
                                {
                                    totalScorePlayerOne -= 200;
                                }
                                else if (playersCards[m].Equals("X"))
                                {
                                    xCardPlayerOne = true;
                                }
                                else
                                {
                                    currentScorePlayerOne += (i + 1);
                                }
                            }
                        }
                    }
                }


                n += 3;

                if ((n + 3) <= playersCards.Length)
                {
                    for (int m = n; m < n + 3; m++)
                    {
                        for (int i = 0; i < cards.Length; i++)
                        {
                            if (playersCards[m].Equals(cards[i]))
                            {
                                if (playersCards[m].Equals("Z"))
                                {
                                    totalScorePlayerTwo *= 2;
                                }
                                else if (playersCards[m].Equals("Y"))
                                {
                                    totalScorePlayerTwo -= 200;
                                }
                                else if (playersCards[m].Equals("X"))
                                {
                                    xCardPlayerTwo = true;
                                }
                                else
                                {
                                    currentScorePlayerTwo += (i + 1);
                                }
                            }
                        }
                    }
                }

                n += 3;


                if (xCardPlayerOne && xCardPlayerTwo)
                {
                    totalScorePlayerOne += 50;
                    totalScorePlayerTwo += 50;
                }

                if (xCardPlayerOne && !xCardPlayerTwo)
                {
                    gamesWonPlayerOne++;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (xCardPlayerTwo && !xCardPlayerOne)
                {
                    gamesWonPlayerTwo++;
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }
                else
                {
                    if (currentScorePlayerOne > currentScorePlayerTwo)
                    {
                        gamesWonPlayerOne++;
                        totalScorePlayerOne += currentScorePlayerOne;
                    }
                    else if (currentScorePlayerTwo > currentScorePlayerOne)
                    {
                        gamesWonPlayerTwo++;
                        totalScorePlayerTwo += currentScorePlayerTwo;
                    }
                }
            }


            if (totalScorePlayerOne > totalScorePlayerTwo)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", totalScorePlayerOne);
                Console.WriteLine("Games won: {0}", gamesWonPlayerOne);
            }
            else if (totalScorePlayerTwo > totalScorePlayerOne)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", totalScorePlayerTwo);
                Console.WriteLine("Games won: {0}", gamesWonPlayerTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", totalScorePlayerOne);
            }

        }
    }
}
