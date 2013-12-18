// 1. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Read3IntegersFromConsole
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
        int firstInputInteger;
        int secondInputInteger;
        int thirdInputInteger;

        //Using method "ValidateInputInteger(string textToDisplay)" to get validated integer from the user
        firstInputInteger = ValidateInputInteger("Please enter first integer.");
        secondInputInteger = ValidateInputInteger("Please enter second integer.");
        thirdInputInteger = ValidateInputInteger("Please enter third integer.");

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The integer you entered are:\n{0}\n{1}\n{2}", firstInputInteger, secondInputInteger, thirdInputInteger);
    }
}