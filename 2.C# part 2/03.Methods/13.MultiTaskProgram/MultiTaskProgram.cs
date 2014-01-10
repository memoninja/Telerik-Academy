/* 13. Write a program that can solve these tasks:
           - Reverses the digits of a number
           - Calculates the average of a sequence of integers
           - Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
           - The decimal number should be non-negative
           - The sequence should not be empty
           - a should not be equal to 0
 */

using System;

class MultiTaskProgram
{
    static void Main()
    {
        Console.WriteLine("Enter \"1\" to reverse digits of a number");
        Console.WriteLine("Enter \"2\" to calculate the average of a sequence of integers");
        Console.WriteLine("Enter \"3\" to solve a linear equation: a * x + b = 0");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();

        Console.WriteLine(new string('=', 60));

        switch (choice) //Depending on the user's choice, different method is called
        {
            case "1": ReversDigits(); break;
            case "2": CalculateAverageOfSequence(); break;
            case "3": SolveLinearEquation(); break;
            default: Console.WriteLine("Error! Wrong input!"); break;
        }
    }

    /// <summary>
    /// Solve linear equation: a * x + b = 0
    /// </summary>
    private static void SolveLinearEquation()
    {
        double answer;
        double aCoeff = ValidateCoeffA(); //Using method "ValidateCoeffA()" to validate coefficient "a"
        double bCoeff = ValidateCoeffB(); //Using method "ValidateCoeffB()" to validate coefficient "b"

        answer = (-1 * bCoeff) / aCoeff; //Solve the linear equation and find "x"

        Console.WriteLine(new string('=', 20));
        Console.Write("{0}*x", aCoeff);

        if (bCoeff < 0)
        {
            Console.WriteLine(" + ({0}) = 0", bCoeff);
        }
        else
        {
            Console.WriteLine(" + {0} = 0", bCoeff);
        }

        Console.WriteLine("x = {0}", answer);
    }

    /// <summary>
    /// Validate coefficient 'b' to solve linear equation
    /// </summary>
    /// <returns>Validated coefficient</returns>
    private static double ValidateCoeffB()
    {
        double bCoeff;

        Console.Write("Enter coeff \"b\": ");

        while (!double.TryParse(Console.ReadLine(), out bCoeff)) //Loop goes on, until a correct double is entered
        {
            Console.Write("Enter correct double!: ");
        }

        return bCoeff; //Return the coefficient after it is validated
    }

    /// <summary>
    /// Validate coefficient 'a' to solve linear equation
    /// </summary>
    /// <returns>Validated coefficient</returns>
    private static double ValidateCoeffA()
    {
        double aCoeff;

        while (true)
        {
            Console.Write("Enter coeff \"a\": ");

            while (!double.TryParse(Console.ReadLine(), out aCoeff)) //Loop goes on, until a correct double is entered
            {
                Console.WriteLine("Enter correct double!");
            }

            if (aCoeff == 0) //"a" can not be 0, because we divide "b" by "a"
            {
                Console.Write("Coefficient \"a\" can Not be 0!");
            }
            else
            {
                return aCoeff; //Return the coefficient after it is validated
            }
        }
    }

    /// <summary>
    /// Calculate the average sum of array of integers
    /// </summary>
    private static void CalculateAverageOfSequence()
    {
        int[] ArrayOfIntegers = ValidateInputIntegerArray();
        int averageSum = 0;

        //Loop to calculate the total sum of the values in the array
        for (int i = 0; i < ArrayOfIntegers.Length; i++)
        {
            averageSum += ArrayOfIntegers[i];
        }

        //Divide by count of the element in the array, to find the average sum
        averageSum /= ArrayOfIntegers.Length;

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Average sum is: {0}", averageSum);
    }

    /// <summary>
    /// Reverse digits of input number
    /// </summary>
    private static void ReversDigits()
    {
        char[] numberToCharArray;

        //Assign the value returned from the method "ValidateInputInteger(string textToPrint)"
        int numberToReverse = ValidateInputInteger("Enter number to reverse: ");

        //Check if number is negative, and make it positive if so. Use a boolena for a flag, if number is negative, so we can make it negative again
        bool isNegative = false;

        if (numberToReverse < 0)
        {
            numberToReverse *= -1;

            isNegative = true;
        }

        numberToCharArray = numberToReverse.ToString().ToCharArray(); //Convert number to char array

        Array.Reverse(numberToCharArray); //Use "Array.Reverse()" to reverse the order of the elements(digits) in the array

        numberToReverse = int.Parse(new string(numberToCharArray)); //Convert char array back to integer

        if (isNegative) //If given number was negative, make it back to negative
        {
            numberToReverse *= -1;
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Reversed number: {0}", numberToReverse);
    }

    /// <summary>
    /// Validate integer, input from the user. It must be greather than or equal 0
    /// </summary>
    /// <param name="textToPrint">Message to be printed</param>
    /// <returns>Validated integer</returns>
    private static int ValidateInputInteger(string textToPrint) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        //Two nested loops to validate the input number
        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out givenInteger))
            {
                Console.Write("Enter correct integer: ");
            }

            if (givenInteger < 0) //Number can not be less than 0. Message is shown and the program keeps going intul a correct integer is entered
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Number can Not be less than 0!");
                Console.Write(textToPrint);
            }
            else
            {
                return givenInteger; //The method returns the input integer, after it is validated
            }
        }
    }

    /// <summary>
    /// Validate input integer array. Array is entered on one row
    /// </summary>
    /// <returns>Validated integer array</returns>
    private static int[] ValidateInputIntegerArray() //Method have no parameters
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        while (true)
        {
            Console.WriteLine("Please enter a sequence of numbers to be checked.");
            Console.WriteLine("It is allowed to separate the numbers with comma and/or space \", \"");

            givenArray = Console.ReadLine();

            //Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array that will be left after split() method
            givenArrayToNumbers = givenArray.Split(sequenceCharsToRemove, StringSplitOptions.RemoveEmptyEntries);

            arrayOfIntegers = new int[givenArrayToNumbers.Length];

            for (int i = 0; i < givenArrayToNumbers.Length; i++) //Loop to assign the input numbers to a int array (int[])
            {
                //This is a validation of the input string. If the user type something different for a number, comma or space, the program will be terminated!
                if (!int.TryParse(givenArrayToNumbers[i], out arrayOfIntegers[i]))
                {
                    Console.WriteLine(new string('=', 40));
                    Console.WriteLine("Incorrect input integer!!!");
                    Environment.Exit(1);
                }
            }

            if (arrayOfIntegers.Length < 1)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Array can Not be empty!");
            }
            else
            {
                return arrayOfIntegers; //Return array of integer after they are validated
            }
        }
    }
}
