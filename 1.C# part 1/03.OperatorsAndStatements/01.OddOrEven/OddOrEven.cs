//1. Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        int numberToCheck;

        Console.WriteLine("Please enter an integer to be checked if it is odd or even.\n{0}", new string('-', 30));
        
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out numberToCheck))
        {
            Console.WriteLine("Please enter an integer");
        }

        //Bitwise operator is used to check if number is odd or even.
        //If the last bit of number is 1 then that number is odd.
        if ((numberToCheck & 1) == 1)
        {
            Console.WriteLine("{0}\n{1} is Odd", new string('-', 30), numberToCheck);
        }
        else
        {
            Console.WriteLine("{0}\n{1} is Even", new string('-', 30), numberToCheck);
        }
    }
}