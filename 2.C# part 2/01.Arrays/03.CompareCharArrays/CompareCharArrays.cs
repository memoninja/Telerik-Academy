// 03. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        // The program can be made directly with strings, without char[]. String is a char array(char[])
        // This program compare chars according to the ASCII table!
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        char[] firstArray = new char[firstInput.Length];
        char[] secondArray = new char[secondInput.Length];

        int smallerArrayLength;
        bool isFirstArrayLengthSmaller = false;
        bool isSecondArrayLengthSmaller = false;

        bool isFirstArray = false;
        bool isSecondArray = false;


        for (int i = 0; i < firstArray.Length; i++) // Assigning value to first char array
        {
            firstArray[i] = firstInput[i];
        }

        for (int i = 0; i < secondArray.Length; i++) // Assigning value to second char array
        {
            secondArray[i] = secondInput[i];
        }

        if (firstArray.Length > secondArray.Length) // Check for which one is with smaller length
        {
            isFirstArrayLengthSmaller = true;
            smallerArrayLength = secondArray.Length;
        }
        else // in this case the arrays can have the same length, but this will not change the logic!
        {
            isFirstArrayLengthSmaller = true;
            smallerArrayLength = firstArray.Length;
        }

        for (int i = 0; i < smallerArrayLength; i++)
        {
            if (firstArray[i] < secondArray[i]) // Check if some of the symbols is lower, according to the ASCII table
            {
                isFirstArray = true;
                break;
            }
            else if (firstArray[i] > secondArray[i]) // Check if some of the symbols is lower, according to the ASCII table
            {
                isSecondArray = true;
                break;
            }
        }

        if (isFirstArray)
        {
            Console.WriteLine(new string(firstArray)); // Using "new string(char[] array)" to transform the char[] into a string
        }
        else if (isSecondArray)
        {
            Console.WriteLine(new string(secondArray)); // Using "new string(char[] array)" to transform the char[] into a string
        }
        else
        {
            if (firstArray.Length == secondArray.Length) // if it is not the first array or the second array and their length is equal the have to be the same
            {
                Console.WriteLine("The arrays are the same!");
            }
            else if (isFirstArrayLengthSmaller)
            {
                Console.WriteLine(new string(firstArray));
            }
            else if (isSecondArrayLengthSmaller)
            {
                Console.WriteLine(new string(secondArray));
            }
        }
    }
}