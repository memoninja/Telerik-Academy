// 11. Write a program that finds the index of given element in a sorted array of integers
//     by using the binary search algorithm (find it in Wikipedia).

using System;

class FindIndexUsingBinarySearch
{

    static void Main(string[] args)
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array
        
        int wantedNumber;
        int wantedNumberIndex = -1;
        bool isFound = false;
        int minIndex;
        int maxIndex;
        int middleIndex;


        //This part is for entering the elements of the array and number to search for!
        //===========================================================================================

        Console.WriteLine("Please enter a sequence of numbers to be checked. They may not be sorted");
        Console.WriteLine("It is allowed to separate the numbers with comma and space \", \"");

        givenArray = Console.ReadLine();

        //Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array that will be left after split() method
        givenArrayToNumbers = givenArray.Split(sequenceCharsToRemove, StringSplitOptions.RemoveEmptyEntries);

        arrayOfIntegers = new int[givenArrayToNumbers.Length];

        for (int i = 0; i < givenArrayToNumbers.Length; i++) //Loop to assign the input numbers to a int array (int[])
        {
            //This is a validation of the input string. If hte user type something different for a number, comma or space, the program will be terminated!
            if (!int.TryParse(givenArrayToNumbers[i], out arrayOfIntegers[i]))
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Incorrect input integer!!!");
                return;
            }
        }

        Console.WriteLine("Please enter number to search for!");
        while (!int.TryParse(Console.ReadLine(), out wantedNumber)) //Loopt to validate that a correct integer for sum "S" is entered.
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        //This part is for sorting the array
        //==============================================================================================

        //Insertion sort algorithm. Sort the given array in ascending order
        for (int i = 1; i < arrayOfIntegers.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (arrayOfIntegers[j + 1] < arrayOfIntegers[j])
                {
                    // Exchange the values of the current elements
                    arrayOfIntegers[j] ^= arrayOfIntegers[j + 1];
                    arrayOfIntegers[j + 1] ^= arrayOfIntegers[j];
                    arrayOfIntegers[j] ^= arrayOfIntegers[j + 1];
                }
                else //If the first element to compare is not less, there is no point to continue with the others, they are even less
                {
                    break; // Something like an optimization :)
                }
            }
        }

        minIndex = 0;
        maxIndex = arrayOfIntegers.Length - 1;
        middleIndex = 0;

        //Main logic of the exrecise. Two variants - iterative and recursive
        //==============================================================================================

        ////Binary search - recursive
        ////Using recursive method "BinarySearch(int[] array, int wantedNumber, int minIndex, int maxIndex)"
        //wantedNumberIndex = BinarySearch(arrayOfIntegers, wantedNumber, minIndex, maxIndex);

        //if (wantedNumberIndex >= 0)
        //{
        //    Console.WriteLine("Number {0} index is: {1}", wantedNumber, wantedNumberIndex);
        //}
        //else
        //{
        //    Console.WriteLine("Number Not found!");
        //}
        


        //Binary search - Iterative
        while (maxIndex >= minIndex)
        {
            middleIndex = minIndex + ((maxIndex - minIndex) / 2); //Set the middle index. If we use "(minIndex + maxIndex) / 2", the addition of minIndex and Max Index can cause overflow

            if (arrayOfIntegers[middleIndex] == wantedNumber) //If the wanted number is found the loop is breaked
            {
                isFound = true;
                wantedNumberIndex = middleIndex;
                break;
            }
            else if (arrayOfIntegers[middleIndex] > wantedNumber)
            {
                maxIndex = middleIndex - 1; //If current middle indexed number is greather than the wanted number,
            }                               //the upper bound "maxIndex" is set to the middleIndex - 1
            else
            {
                minIndex = middleIndex + 1; //If current middle indexed number is less than the wanted number,
            }                               //the lower bound "minIndex" is set to the middleIndex + 1
        }

        if (isFound)
        {
            Console.WriteLine("Number {0} index is: {1}", wantedNumber, wantedNumberIndex);
        }
        else
        {
            Console.WriteLine("Number Not found!");
        }
    }

    //Recursive method for Binary Search
    static int BinarySearch(int[] array, int wantedNumber, int minIndex, int maxIndex)
    {
        if (minIndex > maxIndex) //Check min index is greather than max index, and is so, return -1
        {
            return -1; // "-1" is used to signal that the wanted number is not found, because index can Not be negative!
        }
        else
        {
            int middleIndex = minIndex + ((maxIndex - minIndex) / 2);//Calculate and assign value to middle index, once again we are cautious about overflow

            if (wantedNumber > array[middleIndex])
            {                                                                        //This is the "recursive part".
                return BinarySearch(array, wantedNumber, middleIndex + 1, maxIndex); //We return the method itself and whole process start all over again 
            }
            else if (wantedNumber < array[middleIndex])
            {                                                                         //This is the "recursive part".
                return BinarySearch(array, wantedNumber, minIndex, middleIndex - 1);  //We return the method itself and whole process start all over again
            }
            else //If wanted number equals array[middleIndex], we return "middleIndex", and the method stops
            {
                return middleIndex;
            }
        }
    }
}