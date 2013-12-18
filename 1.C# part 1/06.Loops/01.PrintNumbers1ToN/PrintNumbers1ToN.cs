// 1. Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers1ToN
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

        for (uint i = 1; i <= countNumbersToPrint; i++) //Loop to print the numbers from 1 to countNumbersToPrint
        {
            Console.WriteLine(i);
        }
    }
}