// 8. Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisorGCD
{
    //This method validate the number entered by the user
    static uint ValidateInputInteger(string textToDisplay)
    {
        uint inputNumber;

        Console.Write(textToDisplay);

        while (true)
        {
            //Try to parse integer until a correct number is entered by the user
            while (!uint.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter a correct integer number!");
            }

            if (inputNumber > 1) //Check, if number is greather than 1 the loop stops and the program continue
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a correct integer, note that it must be greather than 1!");
            }
        }

        return inputNumber; //The method returns "inputNumber"
    }

    static void Main()
    {
        uint inputA;
        uint inputB;
        uint buffer;
        uint remainder1;
        uint divider;
        uint division;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        inputA = ValidateInputInteger("Please enter first number: ");
        inputB = ValidateInputInteger("Please enter second number: ");

        if (inputA < inputB) //Check which number is greather and switch if needed
        {
            buffer = inputA;
            inputA = inputB;
            inputB = buffer;
        }

        division = inputA % inputB;
        divider = inputB % division;

        while (true) //Loop to calculate the GCD
        {
            remainder1 = division % divider;

            if (remainder1 == 0) //Check if remainder is 0, if so we got GCD
            {
                break;
            }
            division = divider;
            divider = remainder1;
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("GCD of {0} and {1} is: {2}", inputA, inputB, divider);
    }
}