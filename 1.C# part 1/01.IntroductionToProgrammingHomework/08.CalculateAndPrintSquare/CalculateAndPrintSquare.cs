// 8. Create a console application that calculates and prints the square of the number 12345.

using System;

class CalculateAndPrintSquare
{
    static void Main()
    {
        int numberToCalculate = 12345;
        byte power = 2;
        Console.WriteLine("The square of {0} is {1}.", numberToCalculate, Math.Pow(numberToCalculate, power));
    }
}
