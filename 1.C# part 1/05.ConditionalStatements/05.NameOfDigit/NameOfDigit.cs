// 5.Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class NameOfDigit
{
    //This method validate the digit entered by the user
    static byte ValidateInputDigit(string textToDisplay)
    {
        byte inputDigit;

        Console.WriteLine(textToDisplay);
        while (true)
        {
            //Try to parse integer until a correct number is entered by the user
            while (!byte.TryParse(Console.ReadLine(), out inputDigit))
            {
                Console.WriteLine("Please enter correct positive digit!");
            }

            if (inputDigit > 9 || inputDigit < 0) //Digits are only from 0 to 9. In this case negative digits are not allowed
            {
                Console.WriteLine("Please enter correct positive digit!");
                continue;
            }
            //The method returns "inputNumber"
            return inputDigit;
        }
    }

    static void Main()
    {
        byte inputDigit;

        //Using method "ValidateInputInteger(string textToDisplay)" to get validated integer from the user
        inputDigit = ValidateInputDigit("Please enter a digit!");

        Console.WriteLine(new string('=', 30));

        switch (inputDigit) //Using switch-case to print the name of the input digit
        {
            case 0: Console.WriteLine("0 -> Zero"); break;
            case 1: Console.WriteLine("1 -> One"); break;
            case 2: Console.WriteLine("2 -> Two"); break;
            case 3: Console.WriteLine("3 -> Three"); break;
            case 4: Console.WriteLine("4 -> Four"); break;
            case 5: Console.WriteLine("5 -> Five"); break;
            case 6: Console.WriteLine("6 -> Six"); break;
            case 7: Console.WriteLine("7 -> Seven"); break;
            case 8: Console.WriteLine("8 -> Eight"); break;
            case 9: Console.WriteLine("9 -> Nine"); break;
            default: Console.WriteLine("Not correct digit entered!"); break;
        }
    }
}