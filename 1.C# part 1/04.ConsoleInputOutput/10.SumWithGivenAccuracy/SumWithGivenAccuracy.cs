// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumWithGivenAccuracy
{
    static void Main()
    {
        float sum = 1.0f;   //float is enough for the required accuracy
        uint endOfSequence; //using uint because we need only positive integer numbers

        Console.WriteLine("Please enter end number of the sequence.");

        // Loop to parse the integer number entered from the user.
        while (!uint.TryParse(Console.ReadLine(), out endOfSequence))
        {
            Console.WriteLine("Please enter a correct integer number!\nNote that the integer must be positive!");
        }

        // Loop for calculating the sequence
        for (int i = 2; i <= endOfSequence; i++)
        {
            // Bitwise check if number is odd
            if ((i & 1) != 0)
            {
                sum += (-1.0f / i);
            }
            else
            {
                sum += (1.0f / i);
            }
        }

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("The sum of the sequence \"1 + 1/2 - 1/3 + 1/4 - 1/5 + ...\" is:\n-> {0:F3}\n", sum);
    }
}