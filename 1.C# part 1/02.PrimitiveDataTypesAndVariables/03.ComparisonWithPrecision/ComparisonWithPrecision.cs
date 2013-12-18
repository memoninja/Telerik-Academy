// 3. Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

using System;

class ComparisonWithPrecision
{
    static void Main()
    {
        decimal precision = 0.000001m;
        decimal firstNumber;
        decimal secondNumber;
        bool areEqual = false;
        Console.WriteLine("This program safely compares two numbers.\n");

        //Trying to parse string to decimal until a correct number is entered
        Console.WriteLine("Please enter first number!");
        while (!decimal.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("Please enter only digits!");
        }
        
        //Trying to parse string to decimal until a correct number is entered
        Console.WriteLine("{0}\nPlease enter second number!", new string('-', 30));
        while (!decimal.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Please enter only digits!");
        }

        if (Math.Abs(firstNumber - secondNumber) < precision)
        {
            areEqual = true;
        }
        else if (firstNumber > secondNumber)
        {
            areEqual = false;
        }
        Console.WriteLine("\n{0}\n({1}; {2}) are equal? \u2192 {3} \n", new string('-', 30), firstNumber, secondNumber, areEqual);
    }
}