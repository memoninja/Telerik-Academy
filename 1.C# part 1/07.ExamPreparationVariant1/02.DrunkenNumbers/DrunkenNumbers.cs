using System;

class DrunkenNumbers
{
    static void Main()
    {
        /*This program are made only to practice, so there are not enough comments!
          The programs are made just to score 100 points!
          No additional optimization were made!
          Sorry if the code is unreadable!!!
          Do not have time to make it readable!
         */

        // 100 Points

        int inputNumber;
        string currentNumber;
        int totalSumFirst = 0;
        int totalSumSecond = 0;

        int sequenceLength = int.Parse(Console.ReadLine());
        string[] numbersArray = new string[sequenceLength];



        for (int i = 0; i < sequenceLength; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < 0)
            {
                inputNumber *= -1;
            }
            numbersArray[i] = inputNumber.ToString();
        }



        int firstLength;
        int secondLength;

        for (int i = 0; i < sequenceLength; i++)
        {
            int currentSumFirst = 0;
            int currentSumSecond = 0;

            currentNumber = numbersArray[i];
            firstLength = (currentNumber.Length + 1) / 2;
            secondLength = currentNumber.Length / 2;

            for (int m = 0; m < firstLength; m++) //first
            {
                switch (currentNumber[m])
                {
                    case '0': currentSumFirst += 0; break;
                    case '1': currentSumFirst += 1; break;
                    case '2': currentSumFirst += 2; break;
                    case '3': currentSumFirst += 3; break;
                    case '4': currentSumFirst += 4; break;
                    case '5': currentSumFirst += 5; break;
                    case '6': currentSumFirst += 6; break;
                    case '7': currentSumFirst += 7; break;
                    case '8': currentSumFirst += 8; break;
                    case '9': currentSumFirst += 9; break;
                    default:
                        break;
                }
            }

            for (int n = secondLength; n < currentNumber.Length; n++) //second
            {
                switch (currentNumber[n])
                {
                    case '0': currentSumSecond += 0; break;
                    case '1': currentSumSecond += 1; break;
                    case '2': currentSumSecond += 2; break;
                    case '3': currentSumSecond += 3; break;
                    case '4': currentSumSecond += 4; break;
                    case '5': currentSumSecond += 5; break;
                    case '6': currentSumSecond += 6; break;
                    case '7': currentSumSecond += 7; break;
                    case '8': currentSumSecond += 8; break;
                    case '9': currentSumSecond += 9; break;
                    default:
                        break;
                }
            }

            totalSumFirst += currentSumFirst;
            totalSumSecond += currentSumSecond;

        }
        if (totalSumFirst > totalSumSecond)
        {

            Console.WriteLine("M {0}", totalSumFirst - totalSumSecond);
        }
        else if (totalSumFirst < totalSumSecond)
        {
            Console.WriteLine("V {0}", totalSumSecond - totalSumFirst);
        }
        else
        {
            Console.WriteLine("No {0}", totalSumFirst + totalSumSecond);
        }

    }
}