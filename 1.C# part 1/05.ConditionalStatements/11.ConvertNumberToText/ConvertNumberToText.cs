/*  Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
 *	0  "Zero"
 *	273  "Two hundred seventy three"
 *	400  "Four hundred"
 *	501  "Five hundred and one"
 *	711  "Seven hundred and eleven"
 */
using System;

class ConvertNumberToText
{
    static void OnesToString(int digit) //This method prints digits from 1 to 9 by a given digit
    {
        string numberToString;

        switch (digit)
        {
            case 1: numberToString = "one"; break;
            case 2: numberToString = "two"; break;
            case 3: numberToString = "three"; break;
            case 4: numberToString = "four"; break;
            case 5: numberToString = "five"; break;
            case 6: numberToString = "six"; break;
            case 7: numberToString = "seven"; break;
            case 8: numberToString = "eight"; break;
            case 9: numberToString = "nine"; break;
            default: numberToString = "OnesToString Error!"; break;
        }

        Console.Write(numberToString);
    }

    static void NineToNineteenToString(int digit) //This method printsnumbers from 10 to 19 by a given number
    {
        string numberToString;

        switch (digit)
        {
            case 0: numberToString = "ten"; break;
            case 1: numberToString = "eleven"; break;
            case 2: numberToString = "twelve"; break;
            case 3: numberToString = "thirteen"; break;
            case 4: numberToString = "fourteen"; break;
            case 5: numberToString = "fifteen"; break;
            case 6: numberToString = "sixteen"; break;
            case 7: numberToString = "seventeen"; break;
            case 8: numberToString = "eighteen"; break;
            case 9: numberToString = "nineteen"; break;
            default: numberToString = "NineToNineteenToString Error!"; break;
        }

        Console.Write(numberToString);
    }

    static void TensToString(int digit) // This method prints 10, 20, 30... by a given number
    {
        string numberToString;

        switch (digit)
        {
            case 2: numberToString = "twenty "; break;
            case 3: numberToString = "thirty "; break;
            case 4: numberToString = "forty "; break;
            case 5: numberToString = "fifty "; break;
            case 6: numberToString = "sixty "; break;
            case 7: numberToString = "seventy "; break;
            case 8: numberToString = "eighty "; break;
            case 9: numberToString = "ninety "; break;
            default: numberToString = "TensToString Error!"; break;
        }

        Console.Write(numberToString);
    }

    static void Main()
    {
        string inputText;
        int inputNumber;
        int currentNumber;
        int[] numberDigits;

        Console.WriteLine("Please enter an integer number between 1 and 999");

        while (true) //Loop to parse a correct integer number from the user
        {
            inputText = Console.ReadLine();

            if (int.TryParse(inputText, out inputNumber))
            {
                if (inputNumber >= 0 && inputNumber <= 999)
                {
                    break;
                }
            }

            Console.WriteLine("Please enter a correct integer between 1 and 999!");
        }

        currentNumber = inputNumber;
        numberDigits = new int[inputText.Length]; //Using array to store the digits of the given number. The array's length depends of the inputText.Length

        for (int i = 0; i < inputText.Length; i++) //Loop to assign values to the array. Extracting the digits from the input number.
        {
            numberDigits[i] = currentNumber % 10;
            currentNumber /= 10;
        }

        Console.WriteLine(new string('=', 25));

        if (inputNumber >= 100) //First check if number have hundreds. If so, print them first
        {
            OnesToString(numberDigits[2]); //Using method "OnesToString(int digit)" to print the needed digit
            Console.Write(" hundred ");

            if (numberDigits[1] == 1) //Check is second digit of the number is 1. If so, we need different numbers(teens - ten, eleven, twelve...)
            {
                Console.Write("and ");
                NineToNineteenToString(numberDigits[0]); //Using method "NineToNineteenToString(int digit)" to print the need number
                Console.WriteLine();
                return;
            }
            else if (numberDigits[0] == 0 && numberDigits[1] != 0) // If second digit is different from 0 and first equals 0, we need twenty, thirty, forty...
            {
                Console.Write("and ");
            }
            else if (numberDigits[1] == 0 && numberDigits[0] != 0)
            {
                Console.Write("and ");
            }
        }

        if (inputNumber >= 20) //If number is bigger than 20 and if second digit is not 0 prints twenty, thirty...
        {
            if (numberDigits[1] != 0)
            {
                TensToString(numberDigits[1]);
            }
        }
        else if (inputNumber >= 10 && inputNumber < 20) //If number is between 10 and 19 prints separate method
        {
            NineToNineteenToString(numberDigits[0]);
        }

        if (numberDigits[0] != 0 && (inputNumber < 10 || inputNumber > 20)) //If number is not 0 and is not 10 to 19 prints the ones(one, two, three...)
        {
            OnesToString(numberDigits[0]);
        }
        else if (inputNumber == 0)
        {
            Console.Write("zero");
        }

        Console.WriteLine("");
    }
}