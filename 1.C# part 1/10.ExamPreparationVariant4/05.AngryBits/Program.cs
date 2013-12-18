using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AngryBits
{
    class Program
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

            string[] byteGrid = new string[8];
            int[] inputNumbers = new int[8];
            int colsCounter = 7;
            bool isUp = true;
            int currentScore = 0;
            int totalScore = 0;
            int movesCounter = 0;
            string win = "Yes";

            for (int i = 0; i < 8; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
            {
                byteGrid[i] = Convert.ToString(inputNumbers[i], 2).PadLeft(16, '0');
            }

            for (int i = byteGrid.Length - 1; i >= 0; i--)
            {
                for (int n = 0; n < byteGrid.Length; n++)
                {
                    if (byteGrid[n][i] == '1')
                    {
                        colsCounter = i;
                        int row = n;
                        if (row > 0)
                        {
                            isUp = true;
                        }
                        if (row == 0)
                        {
                            isUp = false;
                        }
                        while (true)
                        {
                            if (isUp)
                            {
                                row--;
                            }
                            else
                            {
                                row++;
                            }
                            if (row == 8)
                            {
                                break;
                            }
                            if (row == 0)
                            {
                                isUp = false;
                            }

                            if (colsCounter == 15)
                            {
                                break;
                            }
                            movesCounter++;
                            colsCounter++;

                            if (colsCounter > 7)
                            {
                                if (byteGrid[row][colsCounter] == '1')
                                {
                                    currentScore++;
                                    char[] currentCharArray = byteGrid[row].ToCharArray();
                                    currentCharArray[colsCounter] = '0';
                                    byteGrid[row] = new string(currentCharArray);

                                    //Score!!!!!!!!!
                                    if (row > 0) // Top
                                    {
                                        if (byteGrid[row - 1][colsCounter] == '1')
                                        {
                                            currentScore++;
                                            char[] currentCharArray1 = byteGrid[row - 1].ToCharArray();
                                            currentCharArray1[colsCounter] = '0';
                                            byteGrid[row - 1] = new string(currentCharArray1);
                                        }

                                        if (colsCounter < 15) // Right side
                                        {
                                            if (byteGrid[row - 1][colsCounter + 1] == '1')
                                            {
                                                currentScore++;
                                                char[] currentCharArray2 = byteGrid[row - 1].ToCharArray();
                                                currentCharArray2[colsCounter + 1] = '0';
                                                byteGrid[row - 1] = new string(currentCharArray2);
                                            }
                                        }

                                        if (colsCounter > 8) // Left side
                                        {
                                            if (byteGrid[row - 1][colsCounter - 1] == '1')
                                            {
                                                currentScore++;
                                                char[] currentCharArray3 = byteGrid[row - 1].ToCharArray();
                                                currentCharArray3[colsCounter - 1] = '0';
                                                byteGrid[row - 1] = new string(currentCharArray3);
                                            }
                                        }
                                    }

                                    if (row < 7) // Bottom
                                    {
                                        if (byteGrid[row + 1][colsCounter] == '1')
                                        {
                                            currentScore++;
                                            char[] currentCharArray1 = byteGrid[row + 1].ToCharArray();
                                            currentCharArray1[colsCounter] = '0';
                                            byteGrid[row + 1] = new string(currentCharArray1);
                                        }

                                        if (colsCounter < 15) // Right side
                                        {
                                            if (byteGrid[row + 1][colsCounter + 1] == '1')
                                            {
                                                currentScore++;
                                                char[] currentCharArray2 = byteGrid[row + 1].ToCharArray();
                                                currentCharArray2[colsCounter + 1] = '0';
                                                byteGrid[row + 1] = new string(currentCharArray2);
                                            }
                                        }

                                        if (colsCounter > 8) // Left side
                                        {
                                            if (byteGrid[row + 1][colsCounter - 1] == '1')
                                            {
                                                currentScore++;
                                                char[] currentCharArray3 = byteGrid[row + 1].ToCharArray();
                                                currentCharArray3[colsCounter - 1] = '0';
                                                byteGrid[row + 1] = new string(currentCharArray3);
                                            }
                                        }
                                    }

                                    if (colsCounter < 15) // Right side
                                    {
                                        if (byteGrid[row][colsCounter + 1] == '1')
                                        {
                                            currentScore++;
                                            char[] currentCharArray1 = byteGrid[row].ToCharArray();
                                            currentCharArray1[colsCounter + 1] = '0';
                                            byteGrid[row] = new string(currentCharArray1);
                                        }
                                    }

                                    if (colsCounter > 8) // Left side
                                    {
                                        if (byteGrid[row][colsCounter - 1] == '1')
                                        {
                                            currentScore++;
                                            char[] currentCharArray1 = byteGrid[row].ToCharArray();
                                            currentCharArray1[colsCounter - 1] = '0';
                                            byteGrid[row] = new string(currentCharArray1);
                                        }
                                    }

                                    totalScore += (currentScore * movesCounter);
                                    currentScore = 0;
                                    movesCounter = 0;
                                    break;
                                }
                            }
                            
                            if (colsCounter == 15 || row == 7)
                            {
                                movesCounter = 0;
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int n = 8; n < 16; n++)
                {
                    if (byteGrid[i][n] == '1')
                    {
                        win = "No";
                    }
                }
            }

            Console.WriteLine("{0} {1}", totalScore, win);
        }
    }
}
