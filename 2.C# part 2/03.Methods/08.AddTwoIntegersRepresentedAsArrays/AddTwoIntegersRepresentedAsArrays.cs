// 08. Write a method that adds two positive integer numbers represented as arrays of digits
//     (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//     Each of the numbers that will be added could have up to 10 000 digits.


using System;

class AddTwoIntegersRepresentedAsArrays
{
    static void Main()
    {
        string firstNumber;
        string secondNumber;

        int[] firstNumberToArray;
        int[] secondNumberToArray;
        int[] sumOfTwoArrays;

        Console.Write("Please enter first number: ");
        firstNumber = Console.ReadLine();

        Console.Write("Please enter second number: ");
        secondNumber = Console.ReadLine();

        //Convert the input string into array of digits, using method "ConvertStringToArrayOfDigits(string stringToConvert)"
        firstNumberToArray = ConvertStringToArrayOfDigits(firstNumber);
        secondNumberToArray = ConvertStringToArrayOfDigits(secondNumber);

        //Add the arrays of digits, using method "AddTwoArraysOfDigits(int[] firsArray, int[] secondArray)"
        sumOfTwoArrays = AddTwoArraysOfDigits(firstNumberToArray, secondNumberToArray);

        //Print the addition of the arrays with method "private static void PrintArray(int[] arrayToPrint)"
        PrintArray(sumOfTwoArrays);
    }

    //Method to add two given arrays of digits
    //Return type is "int[]" - array
    private static int[] AddTwoArraysOfDigits(int[] firsArray, int[] secondArray)
    {
        int oneToAdd = 0;
        int[] sumOfTwoArrays;
        int[] longerArrayToAdd;

        //Check which array is longer
        //Make the length of the array where we will add the digits, equal length + 1, because the sum can be number with one more digit
        //Copy the shorter array to "sumOfTwoArrays", because we will add the longer array to it
        //Set "longerArrayToAdd" reference pointing at the longer array
        if (firsArray.Length > secondArray.Length)
        {
            sumOfTwoArrays = new int[firsArray.Length + 1];
            secondArray.CopyTo(sumOfTwoArrays, 0);

            longerArrayToAdd = firsArray;
        }
        else
        {
            sumOfTwoArrays = new int[secondArray.Length + 1];
            firsArray.CopyTo(sumOfTwoArrays, 0);

            longerArrayToAdd = secondArray;
        }

        //Loop to iterate through the longer array of digits
        //If the addition of the current digits is 10 or greather we have to add 1 to the next sum of digits - "oneToAdd" variable
        //If the addition of the current digits is 9 or less set "oneToAdd" variable to 0
        //Assign, to "sumOfTwoArrays" current index, the remainder by division of 10. This is thw way to take the last digit if sum is 10 or greather
        for (int i = 0; i < longerArrayToAdd.Length; i++)
        {
            if (sumOfTwoArrays[i] + longerArrayToAdd[i] + oneToAdd >= 10)
            {
                sumOfTwoArrays[i] = (sumOfTwoArrays[i] + longerArrayToAdd[i] + oneToAdd) % 10;

                oneToAdd = 1;
            }
            //if (sumOfTwoArrays[i] + longerArrayToAdd[i] + oneToAdd <= 9)
            else
            {
                sumOfTwoArrays[i] = sumOfTwoArrays[i] + longerArrayToAdd[i] + oneToAdd;

                oneToAdd = 0;
            }
        }

        //Check if we still have to add one(oni in mind) adn if so, set the last index of the array to 1
        if (oneToAdd == 1)
        {
            sumOfTwoArrays[sumOfTwoArrays.Length - 1] = 1;
        }

        return sumOfTwoArrays; //Finaly return the sum of the two arrays
    }

    //Method to convert a given string into array of digits
    //Return type is "int[]" - array
    private static int[] ConvertStringToArrayOfDigits(string stringToConvert)
    {
        int[] convertedNumber = new int[stringToConvert.Length];
        int index = stringToConvert.Length - 1;

        //Using numeration of ASCII table to set a digit to current index. Subtract the number of '0' in ASCII table to get the value of the digit
        while (index >= 0)
        {
            if (stringToConvert[stringToConvert.Length - index - 1] > '9' || stringToConvert[stringToConvert.Length - index - 1] < '0')
            {
                Console.WriteLine("Incorrect input number! Program is terminated!");
                Environment.Exit(1);
            }

            convertedNumber[index] = stringToConvert[stringToConvert.Length - index - 1] - '0';

            index--;
        }

        return convertedNumber; //return the given string converted into array of digits
    }

    //Method to print a given array
    //Return type is "void" - return nothing
    private static void PrintArray(int[] arrayToPrint)
    {
        Console.WriteLine(new string('=', 70));
        Console.Write("Sum of the two numbers is: ");

        //Check for the value of the last index. It will be the first digit to print, because the array is reversed
        if (arrayToPrint[arrayToPrint.Length - 1] == 1)
        {
            Console.Write(arrayToPrint[arrayToPrint.Length - 1]);
        }

        //Start from the last index minus 1, because we already checked the last index. The array is reversed!
        for (int i = arrayToPrint.Length - 2; i >= 0; i--)
        {
            Console.Write(arrayToPrint[i]);
        }
        
        Console.WriteLine();
    }
}
