//2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        int numToDivide;
        bool isDivisible;

        Console.WriteLine("Enter an integer to be checked if it can be dividen by 7 and 5");
        
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out numToDivide))
        {
            Console.WriteLine("Please enter an integer");
        }

        //Check if the number can be divided by 7 and 5 in the same time
        if ((numToDivide % 7 == 0) && (numToDivide % 5) == 0)
        {
            isDivisible = true;
        }
        else
        {
            isDivisible = false;
        }
        Console.WriteLine("{0}\n{1} can be divided by 7 and 5? -> {2}", new string('-', 30), numToDivide, isDivisible);
    }
}