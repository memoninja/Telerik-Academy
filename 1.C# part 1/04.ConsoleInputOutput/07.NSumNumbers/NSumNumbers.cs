//  7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class NSumNumbers
{
    static void Main()
    {
        int countNumbersToRead;
        double[] numbersToSum;
        double sum = 0;

        //This program could be written much more simple if we do not display the entered numbers from the user at the end.
        //If so we do not need the array.

        Console.WriteLine("Please enter count of numbers you want to sum.");
        
        // Loop to parse the integer number entered from the user. The number is the count of numbers to sum
        while (!int.TryParse(Console.ReadLine(), out countNumbersToRead))
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        //Assigning array length - the count of the number we want to sum
        numbersToSum = new double[countNumbersToRead];

        // Loop for assigning
        for (int i = 0; i < countNumbersToRead; i++)
        {
            Console.WriteLine("Please enter number {0} to sum.", i + 1);
            
            // Loop to parse the double number entered from the user.
            while (!double.TryParse(Console.ReadLine(), out numbersToSum[i]))
            {
                Console.WriteLine("Please enter a correct double number!");
            }
            //Sum the input numbers
            sum += numbersToSum[i];
        }

        Console.WriteLine(new string('-', 40));
        
        // Loo to display the numbers in the array, that the user entered
        for (int i = 0; i < numbersToSum.Length; i++)
        {
            Console.WriteLine("Number {0} is {1}", (i + 1), numbersToSum[i]);
        }

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}