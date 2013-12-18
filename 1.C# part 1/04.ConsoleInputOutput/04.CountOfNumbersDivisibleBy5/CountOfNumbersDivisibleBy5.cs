// 4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class CountOfNumbersDivisibleBy5
{
    //This method parse input data from the user to integer
    private static uint parseUintNumber(string textToDisplay)
    {
        uint inputNumber;

        Console.WriteLine(new string('-', 30));
        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct number is entered
        while (!uint.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        //This method return "inputNumber"
        return inputNumber;
    }

    static void Main()
    {
        uint lowerNumber;
        uint greatherNumber;
        uint buffer;
        uint countNumbersDivisibleBy5 = 0;

        //Using method "parseUintNumber(string textToDisplay)" to validate the input data
        lowerNumber = parseUintNumber("Please enter first number.");
        greatherNumber = parseUintNumber("Please enter second number.");

        //Check if lowerNumber is greather than greatherNumber and exchange thier values
        if (lowerNumber > greatherNumber)
        {
            buffer = greatherNumber;
            greatherNumber = lowerNumber;
            lowerNumber = buffer;
        }
        //Check if the two entered numbers from the user are equal and stop the program if so!
        else if (lowerNumber == greatherNumber)
        {
            Console.WriteLine("The two numbers must not be the equal!");
            return;
        }

        //Cycle to count the numbers that are divisible by 5
        for (uint i = lowerNumber; i <= greatherNumber; i++)
        {
            if (i % 5 == 0)
            {
                countNumbersDivisibleBy5++;
            }
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("p({0}, {1}) = {2}", lowerNumber, greatherNumber, countNumbersDivisibleBy5);
    }
}