// 9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
// Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class FindIfSumIs0
{
    //This method validate the number entered by the user
    static int ValidateInputInteger(string textToDisplay)
    {
        int inputNumber;

        Console.WriteLine(textToDisplay);

        //Try to parse integer until a correct number is entered by the user
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct integer!");
        }
        //The method returns "inputNumber"
        return inputNumber;
    }

    static void Main()
    {
        int[] inputNumbers = { -2, -6, 4, 6, -3 }; //Using array to keep the input numbers

        //Loop fors assigning values to the array
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            Console.Write("Please enter number {0}", i + 1);
            //Using method "ValidateInputInteger(string textToDisplay)" to validated input integers from the user
            inputNumbers[i] = ValidateInputInteger("");
        }

        Console.WriteLine(new string('=', 30));

        //Loop to print the possible combinations than equals 0
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            for (int j = i + 1; j < inputNumbers.Length; j++)
            {
                if ((inputNumbers[i] + inputNumbers[j]) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", inputNumbers[i], inputNumbers[j]);
                }

                for (int k = j + 1; k < inputNumbers.Length; k++)
                {
                    if ((inputNumbers[i] + inputNumbers[j] + inputNumbers[k]) == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", inputNumbers[i], inputNumbers[j], inputNumbers[k]);
                    }

                    for (int l = k + 1; l < inputNumbers.Length; l++)
                    {
                        if ((inputNumbers[i] + inputNumbers[j] + inputNumbers[k] + inputNumbers[l]) == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", inputNumbers[i], inputNumbers[j], inputNumbers[k], inputNumbers[l]);
                        }

                        for (int m = l + 1; m < inputNumbers.Length; m++)
                        {
                            if ((inputNumbers[i] + inputNumbers[j] + inputNumbers[k] + inputNumbers[l] + inputNumbers[m]) == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", inputNumbers[i], inputNumbers[j], inputNumbers[k], inputNumbers[l], inputNumbers[m]);
                            }
                        }
                    }
                }
            }
        }
    }
}