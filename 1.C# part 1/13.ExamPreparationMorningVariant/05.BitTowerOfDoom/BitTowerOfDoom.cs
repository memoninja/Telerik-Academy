using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitTowerOfDoom
{
    class BitTowerOfDoom
    {
        static void Main(string[] args)
        {
            // ??? Points ???

            int initialKnightsCount = 0;
            string currentNumber;
            string currentCommand;
            int indexOfFloor;
            int positionOnFloor;
            int survivedKnights = 0;
            bool isLeftKnight = false;
            bool isRightKnight = false;
            int sumOfSurvivedKnights = 0;

            int[] tower = new int[8];
            for (int i = 0; i < tower.Length; i++)
            {
                tower[i] = int.Parse(Console.ReadLine());
            }

            char[][] knightsArray = new char[8][];

            for (int row = 0; row < knightsArray.GetLength(0); row++) // initialize knights and count them
            {
                    currentNumber = Convert.ToString(tower[row], 2).PadLeft(8, '0');
                    knightsArray[row] = currentNumber.ToCharArray();
            }

            for (int row = 0; row < knightsArray.GetLength(0); row++) // count knights
            {
                for (int col = 0; col < knightsArray.GetLength(0); col++)
                {
                    if (knightsArray[row][col].Equals('1'))
                    {
                        initialKnightsCount++;
                    }
                }
            }

            while (true)
            {
                isLeftKnight = false;
                isRightKnight = false;

                int selectFloorIndex = 0;
                int selectPositionOnFloor = 7;

                int killFloorIndex;
                int killPositionOnFloor;

                int moveFloorIndex;
                int movePositionOnFloor;

                currentCommand = Console.ReadLine();
                if (currentCommand.Equals("end"))
                {
                    break;
                }


                indexOfFloor = int.Parse(Console.ReadLine());
                positionOnFloor = int.Parse(Console.ReadLine());

                if (currentCommand.Equals("select"))
                {
                    selectFloorIndex = indexOfFloor;
                    selectPositionOnFloor = positionOnFloor;
                    knightsArray[selectFloorIndex][selectPositionOnFloor] = '0';
                }
                else if (currentCommand.Equals("kill"))
                {
                    killFloorIndex = indexOfFloor;
                    killPositionOnFloor = positionOnFloor;

                    if (killFloorIndex <= 7 && killFloorIndex >= 0 && killPositionOnFloor <= 7 && killPositionOnFloor >= 0)
                    {
                        if (killPositionOnFloor <= 6 && knightsArray[killFloorIndex][killPositionOnFloor + 1] == '1')
                        {
                            isRightKnight = true;
                        }

                        if (killPositionOnFloor >= 1 && knightsArray[killFloorIndex][killPositionOnFloor - 1] == '1')
                        {
                            isLeftKnight = true;
                        }

                        if (isRightKnight && !isLeftKnight)
                        {
                            knightsArray[killFloorIndex][killPositionOnFloor + 1] = '0';
                        }
                        else if (!isRightKnight && isLeftKnight)
                        {
                            knightsArray[killFloorIndex][killPositionOnFloor - 1] = '0';
                        }
                        else if (!isRightKnight && !isLeftKnight)
                        {
                            knightsArray[killFloorIndex][killPositionOnFloor] = '1';
                        }
                    }
                    else
                    {
                        survivedKnights++;
                    }
                }
                else if (currentCommand.Equals("move"))
                {
                    moveFloorIndex = indexOfFloor;
                    movePositionOnFloor = positionOnFloor;

                    if (moveFloorIndex <= 7 && moveFloorIndex >= 0 && movePositionOnFloor <= 7 && movePositionOnFloor >= 0)
                    {
                        if (knightsArray[moveFloorIndex][movePositionOnFloor] == '0')
                        {
                            if (movePositionOnFloor <= 6 && knightsArray[moveFloorIndex][movePositionOnFloor + 1] == '1')
                            {
                                isRightKnight = true;
                            }

                            if (movePositionOnFloor >= 1 && knightsArray[moveFloorIndex][movePositionOnFloor - 1] == '1')
                            {
                                isLeftKnight = true;
                            }

                            if (!isRightKnight && !isLeftKnight)
                            {
                                knightsArray[moveFloorIndex][movePositionOnFloor] = '1';
                            }
                        }
                    }
                    else
                    {
                        survivedKnights++;
                    }
                }
            }


            for (int row = 0; row < knightsArray[0].Length; row++) // count knights
            {
                for (int col = 0; col < knightsArray[0].Length; col++)
                {
                    if (knightsArray[row][col].Equals('1'))
                    {
                        survivedKnights++;
                    }
                }
            }

            for (int i = 0; i < knightsArray[0].Length; i++) // Check the sum of survived knights;
            {
                string str = new string(knightsArray[i]);
                sumOfSurvivedKnights += int.Parse(Convert.ToInt32(str, 2).ToString());
            }

            Console.WriteLine(initialKnightsCount); // initial knights
            Console.WriteLine(survivedKnights); // survived knights
            Console.WriteLine(sumOfSurvivedKnights); // final integers
        }
    }
}
