// 15. Write a program that finds all prime numbers in the range [1...10 000 000].
//     Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class PrimeNumbersWithSieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int numbersToCheck;
        bool[] isComposite;
        int currentNumber = 1;
        int multiplier;

        numbersToCheck = ValidateInputNumber(); //Using method "ValidateInputNumber()" to validate the input integer number

        //By default bools are false
        isComposite = new bool[numbersToCheck + 1]; //Set the bool array length to the etered range of numbers

        //Main logic of the exercise
        for (int i = 2; i < numbersToCheck; i++) //Loop to iterate trought the array of bools
        {
            multiplier = 2;

            while (true)
            {
                currentNumber = i;
                currentNumber *= multiplier; //multiply every number of the range with 2, 3, 4 ,5 an so on, to find the numbers that are not Pirme(Composite)

                if (currentNumber <= numbersToCheck) //Check if we are still in range of the array's length
                {
                    isComposite[currentNumber] = true; //assign true to every composite number
                }
                else
                {
                    break; //If we are out of the array's range the loop breaks
                }

                multiplier++; // increment the multiplyer with 1 on every iteration. That's how all numbers are multiplied with 2, 3, 4 ,5...
            }
        }

        //Output
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("Prime numbers in range of {0} are:", numbersToCheck);

        for (int i = 2; i <= numbersToCheck; i++)
        {
            if (isComposite[i] == false) // Print the elements of the array that are "false" - prime numbers
            {
                Console.Write("{0} ", i);
            }
        }
    }

    static int ValidateInputNumber() //Method to validate the input number
    {
        int inputNumber;

        Console.Write("Please enter range to check for prime numbers: ");

        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter correct integer number!");
            }

            if (inputNumber < 2) //Check if number is less than 3. It can not be negative and 1 is not prime number!
            {
                Console.WriteLine("Number must be positive and greather than 1!");
            }
            else //If the number is in correct range, break the loop and return the number
            {
                break;
            }
        }

        return inputNumber; //This method returns inputNumber
    }
}