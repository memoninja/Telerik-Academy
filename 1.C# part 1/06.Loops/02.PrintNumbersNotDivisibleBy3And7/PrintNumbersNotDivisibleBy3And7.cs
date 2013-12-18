// 2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        uint countNumbersToPrint;

        Console.WriteLine("Please enter positive integer.");

        //Loop to parese the input data from the user to integer number
        while (!uint.TryParse(Console.ReadLine(), out countNumbersToPrint))
        {
            Console.WriteLine("Please enter a correct positive integer number!");
        }

        Console.WriteLine(new string('=', 30));

        //Loop to print the numbers from 1 to countNumbersToPrint thath are Not divisible by 3 and 7
        for (uint i = 1; i <= countNumbersToPrint; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}