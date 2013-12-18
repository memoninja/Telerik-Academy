// 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        uint inputNumber;
        uint checkCount;
        bool isPrime = true;

        //This program works for all integer number(up to uint.MaxValue), not only up to 100

        Console.WriteLine("Please enter positive integer number.");
        //Trying to parse integer until a correct number is entered
        while (!uint.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }

        //We only need to check the numbers to the "sqrt" of the given number
        checkCount = (uint)Math.Sqrt(inputNumber);

        //Check if the input number is 2. 2 is prime.
        if (inputNumber == 2)
        {
            isPrime = true;
        }
        //Check if number is 1 or is even. One is not prime and if number is not 2 and is even, it is not prime too.
        else if (inputNumber == 1 || (inputNumber & 1) == 0)
        {
            isPrime = false;
        }
        else
        {
            //We need only to check odd numbers
            for (uint i = 3; i <= checkCount; i += 2)
            {
                if (inputNumber % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        Console.WriteLine("Is {0} prime number -> {1}", inputNumber, isPrime);
    }
}