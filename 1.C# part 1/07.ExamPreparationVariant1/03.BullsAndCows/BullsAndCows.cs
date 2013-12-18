using System;
using System.Text;
using System.Collections.Generic;

class BullsAndCows
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

        int secretNumber = int.Parse(Console.ReadLine());
        int wantedBulls = int.Parse(Console.ReadLine());
        int wantedCows = int.Parse(Console.ReadLine());

        int foundBulls;
        int foundCows;

        char charFoundBull = '=';
        char charFoundCow = '+';

        List<int> foundNumbers = new List<int>();

        for (int searchNumbers = 1111; searchNumbers <= 9999; searchNumbers++)
        {
            char[] searchNumbersChars = searchNumbers.ToString().ToCharArray();

            if (searchNumbersChars[0] >= '1' && searchNumbersChars[1] >= '1' && searchNumbersChars[2] >= '1' && searchNumbersChars[3] >= '1')
            {
                foundBulls = 0;
                foundCows = 0;

                char[] secretNumberChars = secretNumber.ToString().ToCharArray();

                for (int i = 0; i < secretNumberChars.Length; i++)
                {
                    if (secretNumberChars[i] == searchNumbersChars[i])
                    {
                        foundBulls++;
                        secretNumberChars[i] = charFoundBull;
                        searchNumbersChars[i] = charFoundCow;
                    }
                }

                for (int m = 0; m < secretNumberChars.Length; m++)
                {
                    for (int n = 0; n < secretNumberChars.Length; n++)
                    {
                        if (searchNumbersChars[n] == secretNumberChars[m])
                        {
                            foundCows++;
                            secretNumberChars[m] = charFoundBull;
                            searchNumbersChars[n] = charFoundCow;
                        }
                    }
                }

                if (foundBulls == wantedBulls && foundCows == wantedCows)
                {
                    foundNumbers.Add(searchNumbers);
                }
            }
        }

        if (foundNumbers.Count >= 1)
        {
            foreach (int foundNnumber in foundNumbers)
            {
                Console.Write("{0} ", foundNnumber);
            }
        }
        else
        {
            Console.WriteLine("No");
        }

        
    }
}