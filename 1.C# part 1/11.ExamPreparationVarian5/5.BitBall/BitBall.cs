using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitBall
{
    class BitBall
    {
        static void Main(string[] args)
        {
            int[] topTeam = new int[8];
            int[] bottomTeam = new int[8];
            int mask = 0;
            bool isScore = true;
            int topTeamScore = 0;
            int bottomTeamScore = 0;

            for (int i = 0; i < topTeam.Length; i++)
            {
                topTeam[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < topTeam.Length; i++)
            {
                bottomTeam[i] = int.Parse(Console.ReadLine());
            }


            for (int row = 0; row < topTeam.Length; row++)
            {
                for (int col = 0; col < topTeam.Length; col++)
                {
                    mask = 1 << col;
                    if ((topTeam[row] & mask) != 0 && (bottomTeam[row] & mask) != 0)
                    {
                        topTeam[row] = topTeam[row] ^ mask;
                        bottomTeam[row] = bottomTeam[row] ^ mask;
                    }
                }
            }

            for (int topRow = 0; topRow < topTeam.Length; topRow++)
            {
                for (int col = 0; col < topTeam.Length; col++)
                {
                    isScore = true;
                    mask = 1 << col;
                    if ((topTeam[topRow] & mask) != 0)
                    {
                        for (int bottomRow = topRow + 1; bottomRow < bottomTeam.Length; bottomRow++)
                        {
                            if ((bottomTeam[bottomRow] & mask) != 0 || (topTeam[bottomRow] & mask) != 0)
                            {
                                isScore = false;
                            }
                        }
                        if (isScore)
                        {
                            topTeamScore++;
                        }
                    }
                }
            }

            for (int topRow = 0; topRow < topTeam.Length; topRow++)
            {
                for (int col = 0; col < topTeam.Length; col++)
                {
                    isScore = true;
                    mask = 1 << col;
                    if ((bottomTeam[topRow] & mask) != 0)
                    {
                        for (int bottomRow = topRow - 1; bottomRow >= 0; bottomRow--)
                        {
                            if ((topTeam[bottomRow] & mask) != 0 || (bottomTeam[bottomRow] & mask) != 0)
                            {
                                isScore = false;
                            }
                        }
                        if (isScore)
                        {
                            bottomTeamScore++;
                        }
                    }
                }
            }

            Console.WriteLine("{0}:{1}",topTeamScore, bottomTeamScore);
        }
    }
}
