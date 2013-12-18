// 07. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSortAlgorithm
{
    
    static void Main(string[] args)
    {
        int[] inputArray;
        int inputArrayLength;

        Console.WriteLine("Please enter array's length.\nNote the it must be positive integer number!");
        while (true) //Loop to validate the input number. It must be positive integer number!
        {
            inputArrayLength = ValidateInputInteger(); //Using method "ValidateInputInteger()" to assign correct values

            if (inputArrayLength > 0) //Validate that the input number is positive and greather than 0
            {
                break; // If the integer is correct, the loop stops and the program continue
            }
            else
            {
                Console.WriteLine("Please enter positive integer number!");
            }
            
        }

        inputArray = new int[inputArrayLength];

        for (int i = 0; i < inputArray.Length; i++) // Assigning values to the array elements
        {
            Console.Write("Enter element {0}:  ", i);
            inputArray[i] = ValidateInputInteger();
        }

        //Logic of the exercise
        //Sorting algorithm - "Selection sort"
        for (int i = 0; i < inputArray.Length - 1; i++) //Here we can use directly "inputArrayLength", but is good practise to work with the array's length
        {
            int currentMinimalElement = i;

            for (int j = i + 1; j < inputArray.Length; j++)
            {
                if (inputArray[j] < inputArray[currentMinimalElement])
                {
                    currentMinimalElement = j;
                }
            }

            // Using buffer to swap the values of current minimal elements and current index element
            //int buffer = inputArray[currentMinimalElement];
            //inputArray[currentMinimalElement] = inputArray[i];
            //inputArray[i] = buffer;

            // Using bitwise operator "^" to swap the values of current minimal elements and current index element
            inputArray[i] ^= inputArray[currentMinimalElement];
            inputArray[currentMinimalElement] ^= inputArray[i];
            inputArray[i] ^= inputArray[currentMinimalElement];
        }

        //Printing output
        Console.WriteLine(new string('=', 30)); // This is just for better visual output

        for (int i = 0; i < inputArray.Length; i++)//Loop to print the sorted array elements
        {
            Console.WriteLine("Array element {0}: {1}", i, inputArray[i]);
        }
    }

    static int ValidateInputInteger() //Method to validate the input data(integer)
    {
        int inputNumber;

        while (!int.TryParse(Console.ReadLine(), out inputNumber)) //Loop to parse the input data from the user to integer number
        {
            Console.WriteLine("Please enter correct integer number!");
        }

        return inputNumber; //The method returns "inputNumber"
    }
}