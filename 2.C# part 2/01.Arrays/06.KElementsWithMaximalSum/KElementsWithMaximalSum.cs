// 06. Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class KElementsWithMaximalSum
{

    static void Main(string[] args)
    {
        int inputN;
        int inputK;
        int[] arrayOfNElements;
        int buffer;

        //Using method "ValidateInputInteger(string textToDisplay)" to assign correct values
        inputN = ValidateInputInteger("Please enter N: ");
        inputK = ValidateInputInteger("Please enter K: ");
        Console.WriteLine(new string('-', 30));

        if (inputK > inputN) // K can not be greather than N, because N is the number of elemtents int the array and we can not print more
        {
            Console.WriteLine("K must be less or equal N");
            Console.WriteLine("Incorrect values entered!!!");
            return;
        }

        arrayOfNElements = new int[inputN]; //Assigning length of the array

        for (int i = 0; i < arrayOfNElements.Length; i++) // Assigning values to the array elements
        {
            Console.Write("Enter element {0}:  ", i);
            arrayOfNElements[i] = ValidateInputInteger("");
        }

        // Logic of the exercise
        // This sorting algorithm is not very efficient, but was the first thing that came up to me!
        for (int i = 0; i < arrayOfNElements.Length; i++) //Loop to sort the elements in the array in increasing order
        {
            for (int j = 0; j < arrayOfNElements.Length - 1; j++)
            {
                if (arrayOfNElements[j] > arrayOfNElements[j + 1])
                {
                    buffer = arrayOfNElements[j];
                    arrayOfNElements[j] = arrayOfNElements[j + 1];
                    arrayOfNElements[j + 1] = buffer;

                    //Another way to slpa the values, using bitwise operator '^', hope it works :)
                    // arrayOfNElements[j] ^= arrayOfNElements[j + 1]
                    // arrayOfNElements[j + 1] ^= arrayOfNElements[j]
                    //arrayOfNElements[j] ^= arrayOfNElements[j + 1]
                }
            }
        }

        //Printing the ouput
        Console.WriteLine(new string('=', 40)); // This is just for better visual output

        // for loop to print the last K elements(elements with maximal sum)
        Console.Write('{');
        for (int i = arrayOfNElements.Length - inputK; i < arrayOfNElements.Length; i++)
        {
            Console.Write(arrayOfNElements[i]);

            if (i < arrayOfNElements.Length - 1) // Check if the current number is not the last of the sequence, and put comma and space
            {
                Console.Write(", ");
            }
        }
        Console.Write('}');
    }

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input data(integer)
    {
        int inputNumber;

        Console.Write(textToDisplay);
        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out inputNumber)) //Loop to parse the input data from the user to integer number
            {
                Console.WriteLine("Please enter correct integer number!");
            }

            if (inputNumber > 0) //Validate that the input number is positive and greather than 0
            {
                break;
            }

            Console.WriteLine("Number must be positive and greather than 0!");
        }

        return inputNumber; //The method returns "inputNumber"
    }
}