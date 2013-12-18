using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BittrisSecond
{
    class BittrisSecond
    {
        static int ValidateInputBitSequence(uint inputNumber)
        {
            /*This program are made only to practice, so there are not enough comments!
              The programs are made just to score 100 points!
              No additional optimization were made!
              Sorry if the code is unreadable!!!
              Do not have time to make it readable!
            */

            // 33 Points

            int mask;
            int bitOneCounter = 0;
            bool isZero = false;

            for (int i = 0; i < 8; i++) //Check for correct Piece(sequence of '1')
            {

                mask = 1 << i;
                bool isOne = (inputNumber & mask) != 0;

                if (isOne)
                {
                    bitOneCounter++;
                }
                else if (!isOne && bitOneCounter > 0)
                {
                    isZero = true;
                }

                if (isOne && isZero)
                {
                    bitOneCounter = 0;
                }
            }

            return bitOneCounter;
        }

        static uint ScoreCounter(uint inputNumber)
        {
            int mask;
            uint scoreCurrentNumber = 0;

            for (int i = 0; i < 32; i++) //Count the score
            {
                mask = 1 << i;
                bool isOne = (inputNumber & mask) != 0;

                if (isOne)
                {
                    scoreCurrentNumber++;
                }
            }

            return scoreCurrentNumber;
        }

        static uint MoveLeftRight(string command, uint currentNumber)
        {
            long mask;

            if (command.Equals("L") || command.Equals("l"))
            {
                mask = 1 << 7;

                if ((currentNumber & mask) == 0)
                {
                    currentNumber = currentNumber << 1;
                }
            }
            else if (command.Equals("R") || command.Equals("r"))
            {
                if ((currentNumber & 1) == 0)
                {
                    currentNumber = currentNumber >> 1;
                }
            }

            return currentNumber;
        }


        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture("en-GB");

            uint commandsNumber;
            uint inputNumber = 0;
            uint previousNumber = 0;
            uint scoreTotal = 0;
            uint previousScoreTotal = 0;
            int row = 4;
            bool flag = false;
            uint beforePreviousNumber = 0;

            commandsNumber = uint.Parse(Console.ReadLine());

            for (int m = 0; m < commandsNumber / 4; m++)
            {
                int mask;
                int currentRow = 1;
                flag = false;

                //uint scoreCurrentNumber = 0;

                inputNumber = uint.Parse(Console.ReadLine());

                uint currentNumber = (inputNumber & 255);

                if (ValidateInputBitSequence(currentNumber) > 0)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        //uint scoreCurrentNumber = 0;
                        string command = Console.ReadLine();

                        if ((row > 1 && currentRow == row) || flag)
                        {
                            continue;
                        }
                        //flag = false; /////

                        uint scoreCurrentNumber = 0;

                        currentNumber = MoveLeftRight(command, currentNumber);

                        if (row > 1)
                        {
                            currentRow++;
                        }
                        else
                        {
                            flag = true;
                        }


                        if (currentRow == row) //Bottom row
                        {
                            scoreCurrentNumber = ScoreCounter(inputNumber);

                            //beforePreviousNumber = previousNumber;

                            if ((previousNumber & currentNumber) == 0) //Check if there is a place for next Piece, if so combine the two numbers
                            {

                                previousNumber = (previousNumber | currentNumber);

                                if ((previousNumber & 255) == 255) //Check for full row of '1'
                                {
                                    scoreCurrentNumber *= 10;
                                    //previousNumber = 0;

                                    flag = true;
                                }
                                else
                                {
                                    beforePreviousNumber = previousNumber;
                                }

                                row++;
                            }
                            previousScoreTotal = scoreTotal;
                            scoreTotal += scoreCurrentNumber;
                        }

                        //currentRow++;
                    }

                    if (scoreTotal - previousScoreTotal > 8)     ////?????
                    {                                            ////?????
                        if (row > 4)
                        {
                            previousNumber = 0;
                        }
                        else
                        {
                            previousNumber = beforePreviousNumber;
                        }

                    }

                    else
                    {
                        beforePreviousNumber = previousNumber;
                        previousNumber = currentNumber;
                    }
                }

                row--;
            }

            Console.WriteLine(scoreTotal);
        }
    }
}
