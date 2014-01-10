// 05. Write a method that checks if the element at given position in given array of integers
//     is bigger than its two neighbors (when such exist).

using System;

class CompareNeighborElements
{
    static void Main()
    {
        int givenIndex;
        int[] givenArray;
        bool isGreather;

        givenArray = ValidateInputIntegerArray(); //Using method "ValidateInputIntegerArray();" to validate the entered array of integers
        givenIndex = ValidateInputInteger("Please eneter index to check: "); //Using method "ValidateInputInteger(string textToPrint)" to validate the input integer number

        if (givenIndex >= givenArray.Length)
        {
            Console.WriteLine(new string('=', 65));
            Console.WriteLine("The input array index is greather than array's length!");
            return;
        }

        isGreather = CompareNeighboringElements(givenIndex, givenArray); // Usign method "CompareNeighboringElements(int arrayIndex, int[] arrayToSearch)" to compare neighboring elements

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Is {0} greather than its neighbors? -> {1}", givenArray[givenIndex], isGreather);
    }

    //Method to compare neighboring elements in an array
    //If given index is at the start of the array or at its end, the program will return false
    //Return type is "bool"
    private static bool CompareNeighboringElements(int arrayIndex, int[] arrayToSearch) //Mathod is with two parameters
    {
        if (arrayIndex == 0 || arrayIndex == arrayToSearch.Length - 1) //Check if given index is at the start of the array or at its end
        {
            return false;
        }
        //If one of the neighboring elements is greather, "false" is returned
        else if (arrayToSearch[arrayIndex] <= arrayToSearch[arrayIndex - 1] || arrayToSearch[arrayIndex] <= arrayToSearch[arrayIndex + 1])
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Method is private, because we do not want to be used anywhere else
    //Return type is "int"
    private static int ValidateInputInteger(string textToPrint) //Check if input number is correct integer
    {
        int givenInteger;

        Console.Write(textToPrint);

        //Two nested loops to validate the input number
        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out givenInteger))
            {
                Console.Write("Please enter correct integer: ");
            }

            if (givenInteger < 0) //Index can not be less than 0. Message is shown and the program keeps going intul a correct integer is entered
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Index can Not be less than 0!");
                Console.Write(textToPrint);
            }
            else
            {
                return givenInteger; //The method returns the input integer, after it is validated
            }
        }
    }

    //Method is private, because we do not want to be used anywhere else
    //Return type is "int[]"
    private static int[] ValidateInputIntegerArray() //Method to validate the input array of integers
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

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

        return arrayOfIntegers; //Return array of integer after they are validate
    }
}
