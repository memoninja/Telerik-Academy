// 13. * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class MergeSortAlgorithm
{

    static void Main(string[] args)
    {
        //The elements of the array can be entered sepated by space, comma or both!

        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array
        

        //This part is for entering the elements of the array!
        //===========================================================================================

        Console.WriteLine("Please enter a sequence of numbers to sort");
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
        
        //Using method "MergeSort(int[] arrayToSort)". This is where the magic happens :)
        arrayOfIntegers = MergeSort(arrayOfIntegers);

        Console.WriteLine(new string('=', 40));

        Console.Write('{');
        for (int i = 0; i < arrayOfIntegers.Length; i++) //Loop to print the elements of the array
        {
            Console.Write(arrayOfIntegers[i]);

            if (i < arrayOfIntegers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine('}');
    }

    static int[] MergeSort(int[] arrayToSort) //Method "MergeSort(int[] arrayToSort)". It returns array of ints
    {
        //Using method "MergeSortList(List<int> listToSort)"
        return (MergeSortList(arrayToSort.ToList<int>())).ToArray<int>();
    }

    static List<int> MergeSortList(List<int> listToSort) //Method "MergeSortList(List<int> listToSort)". It returns "List" of ints
    {
        //This is "bottom" of recursion
        if (listToSort.Count <= 1) // Check if the input list have more than 1 elements. Otherwise there is nothing to sort on one element
        {
            return listToSort;
        }

        //Initialize new lists for left and right part, and for result
        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();
        List<int> resultList = new List<int>();

        int middleIndex = listToSort.Count / 2; //Calculate the current middle index

        for (int i = 0; i < middleIndex; i++)
        {
            leftList.Add(listToSort[i]); //Adding values to the left list
        }

        for (int i = middleIndex; i < listToSort.Count; i++)
        {
            rightList.Add(listToSort[i]); //Adding values to the right list
        }

        //Use debugger and breakpoints on key places to undestand the recursion. Watch "Call Stack" too!
        leftList = MergeSortList(leftList); // This is the recursion. Method call itself. I can't explain it. You have to understand it on your own :)
        rightList = MergeSortList(rightList); // This is the recursion Method call itself. I can't explain it. You have to understand it on your own :)
        resultList = MergeLists(leftList, rightList); // Using method "MergeList(List<int> leftList, List<int> rightList)", to merge left and right half
        
        return resultList; //return the result after we merge both halfs
    }

    static List<int> MergeLists(List<int> leftList, List<int> rightList) // This method returns "List" of ints
    {
        List<int> resultList = new List<int>(); //Initialize new lists for result

        while (leftList.Count > 0 || rightList.Count > 0) //while some of both lists have elements go on
        {
            if (leftList.Count > 0 && rightList.Count > 0) // if both lists have elements, compare which one is less and add it to result list
            {
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]); // Add current lement using ".Add()" at last position of the result list
                    leftList.RemoveAt(0); // After adding, remove the element that we just add, because we don't need it any more. Now on his place (index 0) is the next one. That way the lists lork
                }
                else
                {
                    resultList.Add(rightList[0]); // Add current lement using ".Add()" at last position of the result list
                    rightList.RemoveAt(0); // After adding, remove the element that we just add, because we don't need it any more. Now on his place (index 0) is the next one. That way the lists lork
                }
            }
            else if (leftList.Count > 0) // If only one of the lists have elements just add it's element/s to the result list
            {
                resultList.Add(leftList[0]); // Add current lement using ".Add()" at last position of the result list
                leftList.RemoveAt(0); // After adding, remove the element that we just add, because we don't need it any more. Now on his place (index 0) is the next one. That way the lists lork
            }
            else if (rightList.Count > 0) // If only one of the lists have elements just add it's element/s to the result list
            {
                resultList.Add(rightList[0]); // Add current lement using ".Add()" at last position of the result list
                rightList.RemoveAt(0); // After adding, remove the element that we just add, because we don't need it any more. Now on his place (index 0) is the next one. That way the lists lork
            }
        }

        return resultList;
    }
}