// 3. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfIntegers
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
        //------------------------------------------------------------------------------------------
        //This program can be made much better, but the description says "using nested if statements.
        //------------------------------------------------------------------------------------------

        int firstNumber;
        int secondNumber;
        int thirdNumber;
        int biggestNumber;

        //Using method "ValidateInputInteger(string textToDisplay)" to get validated integer from the user
        firstNumber = ValidateInputInteger("Please enter first number!");
        secondNumber = ValidateInputInteger("Please enter second number!");
        thirdNumber = ValidateInputInteger("Please enter third number!");

        Console.WriteLine(new string('=', 40));

        //Check if first number is greather than second number
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                biggestNumber = firstNumber;
            }
            else if (firstNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
            }
            else //If first number is not greather than third number and the reverse, they must be equal
            {
                Console.WriteLine("Both numbers {0} are bigger than {1}", firstNumber, secondNumber);
                return; // Using "return" to stop the program
            }
        }
        //Check if second number is greather than first number
        else if (secondNumber > firstNumber)
        {
            if (secondNumber > thirdNumber)
            {
                biggestNumber = secondNumber;
            }
            else if (secondNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
            }
            else //If second number is not greather than third number and the reverse, they must be equal
            {
                Console.WriteLine("Both numbers {0} are bigger than {1}", secondNumber, firstNumber);
                return; // Using "return" to stop the program
            }
        }
        else
        {
            //If first number is not greather than second number and the reverse, they must be equal
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Both numbers {0} are bigger than {1}", firstNumber, thirdNumber);
                return; // Using "return" to stop the program
            }
            else if (firstNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
            }
            //If first(second is equal to first) number is not greather than third number and the reverse, all three must be equal
            else
            {
                Console.WriteLine("The three numbers {0} are equal.", firstNumber);
                return; // Using "return" to stop the program
            }
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}