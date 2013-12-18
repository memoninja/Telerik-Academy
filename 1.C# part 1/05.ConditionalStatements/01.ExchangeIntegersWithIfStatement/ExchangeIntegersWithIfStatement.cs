// 1. Write an if statement that examines two integer variables 
// and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeIntegersWithIfStatement
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
        int firstNumber;
        int secondNumber;
        int buffer;

        //Using method "ValidateInputInteger(string textToDisplay)" to get validated integer from the user
        firstNumber = ValidateInputInteger("Please enter first integer number.");
        secondNumber = ValidateInputInteger("Please enter second integer number.");

        Console.WriteLine(new string('=', 40));

        if (firstNumber > secondNumber) // Check if the first number is greather than the second number
        {
            //if is true, exchange the values of the numbers
            buffer = firstNumber;
            firstNumber = secondNumber;
            secondNumber = buffer;

            Console.WriteLine("First number after the exchange is: {0}", firstNumber);
            Console.WriteLine("Second number after the exchange is: {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("First number: {0} is not greather than the second number: {1}!", firstNumber, secondNumber);
        }
        
    }
}