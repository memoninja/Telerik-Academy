//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbersInInterval
{
    static void Main()
    {
        int numberN;
        
        Console.WriteLine("Please enter limit of the interval.");
        
        // Loop to parse the integer number entered from the user.
        while (!int.TryParse(Console.ReadLine(), out numberN))
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Numbers in the interval [1..{0}] are:", numberN);
        
        // Loop to print all numbers in interval [1..n], each on a single line.
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine("-> {0, 3}", i);
        }
    }
}