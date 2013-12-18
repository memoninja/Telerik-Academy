// Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input.
// If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
// if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
//		Use a switch statement and at the end print the calculated new value in the console.

using System;

class ApplyBonusScores
{

    static void Main()
    {
        byte inputDigit;

        //If user enter something different from number 0 to 255 the program report error and stop
        if (!byte.TryParse(Console.ReadLine(), out inputDigit))
        {
            Console.WriteLine("Error report!!!");
            return;
        }

        Console.WriteLine(new string('=', 30));

        switch (inputDigit)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine("You get bonus {0}*10 = {1}", inputDigit, inputDigit * 10); break;
            case 4:
            case 5:
            case 6: Console.WriteLine("You get bonus {0}*100 = {1}", inputDigit, inputDigit * 100); break;
            case 7:
            case 8:
            case 9: Console.WriteLine("You get bonus {0}*1000 = {1}", inputDigit, inputDigit * 1000); break;
            case 0:
            default: Console.WriteLine("Error report!!!");
                break;
        }
    }
}