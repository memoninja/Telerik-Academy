// 02. Write a program that reads two arrays from the console and compares them element by element.

using System;

class ComparesElementsOfTwoArrays
{

    static void Main(string[] args)
    {
        // Variant 1
        // This solution will NOT work only if the user enter "-0" and "0", because they are practicly equal!!!
        // In this solution we do not need to know the length of the input array

        //string firstInputArray = Console.ReadLine(); // string is array of chars(char[]),
        //string secondInputArray = Console.ReadLine(); // so we just compare the two strings
        //bool areEqual = false;

        //if (firstInputArray.Equals(secondInputArray))
        //{
        //    areEqual = true;
        //}

        //Console.WriteLine("Are two arrays equal? -> {0}", areEqual);


        // Variant 2
        int[] firstArray;
        int[] secondArray;
        int firstArrayLength;
        int secondArrayLength;
        bool areEqual = true;

        //Using method "ValidateInputInteger()" to assign value to "firstArrayLength" and "secondArrayLength"
        firstArrayLength = ValidateInputInteger();
        secondArrayLength = ValidateInputInteger();

        if (firstArrayLength != secondArrayLength)
        {
            areEqual = false;
            Console.WriteLine("Are both arrays equal? -> {0}", areEqual);
            return; // stop the execution of the program
        }

        firstArray = new int[firstArrayLength];
        secondArray = new int[secondArrayLength];

        Console.WriteLine("Please enter {0} values for the first array", firstArrayLength);
        //Both array have the same length, but is good practise to work with their own lengths!
        for (int i = 0; i < firstArray.Length; i++) // assign values to the first array
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Please enter {0} values for the second array", secondArrayLength);
        //Both array have the same length, but is good practise to work with their own lengths!
        for (int i = 0; i < secondArray.Length; i++) // assign values to the second array
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < firstArray.Length; i++) // Loop to compare the values of both arrays
        {
            if (firstArray[i] != secondArray[i]) // If some of the values are not equal, the loop stops
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Are both arrays equal? -> {0}", areEqual);
    }

    static int ValidateInputInteger() //Method to parse the input data to integer
    {
        int inputNumber;

        Console.WriteLine("Please enter integer number");

        while (!int.TryParse(Console.ReadLine(), out inputNumber)) //Loop to parse the input data from the user to integer number
        {
            Console.WriteLine("Please enter correct integer number!");
        }

        return inputNumber; //The method returns "inputNumber"
    }
}