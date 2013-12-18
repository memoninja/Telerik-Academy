// 01. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

using System;

class ArrayOf20Integers
{
    static void Main(string[] args)
    {
        int[] integerArray = new int[20]; // Declaring array of 20 integers

        for (int i = 0; i < integerArray.Length; i++) // Loop for assigning a value.
        {
            integerArray[i] = i * 5;
            //Console.WriteLine("{0} ", integerArray[i]); // This loop can be used to print the values too!
        }

        foreach (int value in integerArray) // Loop for printing the values
        {
            Console.Write("{0} ",value);
        }
    }
}