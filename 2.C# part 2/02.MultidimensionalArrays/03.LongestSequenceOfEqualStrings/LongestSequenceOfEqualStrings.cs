// 03. We are given a matrix of strings of size N x M.
//     Sequences in the matrix we define as sets of several neighbor elements
//     located on the same line, column or diagonal.
//     Write a program that finds the longest sequence of equal strings in the matrix. 

using System;
using System.Collections.Generic;
using System.Linq;

class LongestSequenceOfEqualStrings
{
    //If you can't see the separate number, enlarge "spaceBetweenNumber"
    static int spaceBetweenNumber = 3;

    static void Main()
    {
        //This program is made to generate random "chars" from A to C, for given matrix
        //If I made it to generate random strings, there will be very few equal strings
        //You can manually enter matrix of trings below

        int sizeN;
        int sizeM;
        string[,] matrixOfStrings;
        string[] longestSequenceLengthAndString = new string[2];

        //Using method "ValidateInputInteger(string textToDisplay)", to validate the input data
        sizeN = ValidateInputInteger("Please enter size N: ");
        sizeM = ValidateInputInteger("Please enter size M: ");

        matrixOfStrings = new string[sizeN, sizeM];
        GenerateRandomCharsMatrix(matrixOfStrings);

        //You can use this to manually enter a matrix of strings
        //matrixOfStrings = new string[,]{
        //{ "aaa", "aaa", "bb" },
        //{ "abb", "aaa", "bb" },
        //{ "abb", "bb", "aaa" }
        //};

        //If you want to manually enter a matrix of string, you have to comment the following line!
        PrintMatrix(matrixOfStrings, "Generated random chars matrix");//This is a method for generating a random chars from A to C

        //Isung method "SearchForMaxSequence(string[,] matrixToSearchIn)" to find the maximum seqence
        longestSequenceLengthAndString = SearchForMaxSequence(matrixOfStrings);

        //Loop to print the longest found sequence
        for (int i = 0; i < longestSequenceLengthAndString.Length; i++)
        {
            Console.WriteLine(longestSequenceLengthAndString[i]);
        }
    }

    static void GenerateRandomCharsMatrix(string[,] matrix) //Generate random chars and put them into the current matrix
    {
        Random generateRandomStrings = new Random(); //Using class "Random"

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = ((char)generateRandomStrings.Next('A', 'D')).ToString();
            }
        }
    }

    static string[] SearchForMaxSequence(string[,] matrixToSearchIn) //This method searches among the given arrays, to find the longest sequence
    {
        string[] sequenceLengthAndString = new string[2];
        string[][] someString = new string[3][];
        int longestSequenceIndex = 0;
        int currentSequenceLength = 0;

        // Using array of arrays
        // On each of the arrays is assigned values, returned from the methods
        someString[0] = SearchByRows(matrixToSearchIn);
        someString[1] = SearchByColumns(matrixToSearchIn);
        someString[2] = SearchByDiagonals(matrixToSearchIn);

        //Loop to search in the arrays. Note that we look only ot someString[i][0]. In index 0 is assigned the length of the sequence
        for (int i = 0; i < someString.GetLength(0); i++)
        {
            if (int.Parse(someString[i][0]) > currentSequenceLength)
            {
                currentSequenceLength = int.Parse(someString[i][0]);
                longestSequenceIndex = i;
            }
        }

        return someString[longestSequenceIndex];
    }

    static string[] SearchByRows(string[,] matrixToSearch) //Method to seqrch for sequences in rows
    {
        string[] sequenceLengthAndString = new string[2];
        int longestSequenceLength = 0;
        string stringOfMaxSequence = "";

        //Search for sequences in a row
        for (int row = 0; row < matrixToSearch.GetLength(0); row++)
        {
            int currentSequenceLength = 1;

            for (int col = 0; col < matrixToSearch.GetLength(1) - 1; col++)
            {
                //Check if current element equals the next one and if so, increment the current sequence length
                if (matrixToSearch[row, col].Equals(matrixToSearch[row, col + 1]))
                {
                    currentSequenceLength++;

                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        stringOfMaxSequence = matrixToSearch[row, col];
                    }
                }
                else
                {
                    currentSequenceLength = 1; //If current element do not equals the next one, set "currentSequenceLength" to 1
                }
            }
        }

        //Assign the found longest sequence length and it string(char) to an array, and return it to the method, to compare
        sequenceLengthAndString[0] = (longestSequenceLength).ToString();
        sequenceLengthAndString[1] = stringOfMaxSequence;
        return sequenceLengthAndString;
    }

    static string[] SearchByColumns(string[,] matrixToSearch) //Method to seqrch for sequences in rows
    {
        string[] sequenceLengthAndString = new string[2];
        int longestSequenceLength = 0;
        string stringOfMaxSequence = "";

        //Search for sequences in a columns
        for (int col = 0; col < matrixToSearch.GetLength(1); col++)
        {
            int currentSequenceLength = 1;

            for (int row = 0; row < matrixToSearch.GetLength(0) - 1; row++)
            {
                //Check if current element equals the next one and if so, increment the current sequence length
                if (matrixToSearch[row, col].Equals(matrixToSearch[row + 1, col]))
                {
                    currentSequenceLength++;

                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        stringOfMaxSequence = matrixToSearch[row, col];
                    }
                }
                else
                {
                    currentSequenceLength = 1; //If current element do not equals the next one, set "currentSequenceLength" to 1
                }
            }
        }

        //Assign the found longest sequence length and it string(char) to an array, and return it to the method, to compare
        sequenceLengthAndString[0] = (longestSequenceLength).ToString();
        sequenceLengthAndString[1] = stringOfMaxSequence;
        return sequenceLengthAndString;
    }

    static string[] SearchByDiagonals(string[,] matrixToSearch) //Search in diagonal
    {
        string[] sequenceLengthAndString = new string[2];
        int longestSequenceLength = 0;
        string stringOfMaxSequence = "";

        int row = matrixToSearch.GetLength(0) - 1;
        int col = 0;

        //Track the position of the "diagonally" movement
        int currentRow;
        int currentCol;

        //The loop always goes "down" and "right"(diagonally), after each diagonal set the position to one row up, or one column right
        while (row >= 0 && col <= matrixToSearch.GetLength(1) - 1)
        {
            currentRow = row;
            currentCol = col;
            int currentSequenceLength = 1;

            //Check only if row and col are greather than matrix size, because we always goes "down" and "right"(diagonally). Otherwise it will give us "out of bounds exeption"
            while (currentRow < matrixToSearch.GetLength(0) - 1 && currentCol < matrixToSearch.GetLength(1) - 1)
            {
                //Check if current element equals the next one and if so, increment the current sequence length
                if (matrixToSearch[currentRow, currentCol].Equals(matrixToSearch[currentRow + 1, currentCol + 1]))
                {
                    currentSequenceLength++;

                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        stringOfMaxSequence = matrixToSearch[currentRow, currentCol];
                    }
                }
                else
                {
                    currentSequenceLength = 1; //If current element do not equals the next one, set "currentSequenceLength" to 1
                }

                //After we set the current position, we start to move "down" and "right"(diagonally), until we reach the bounds of the matrix
                currentRow++;
                currentCol++;
            }

            if (row == 0) //If row reaches "Top" start to move to the right, column by column
            {
                col++;
            }

            if (row > 0) //While we are not on "Top", we are moving up, row by row
            {
                row--;
            }
        }

        //Assign the found longest sequence length and it string(char) to an array, and return it to the method, to compare
        sequenceLengthAndString[0] = (longestSequenceLength).ToString();
        sequenceLengthAndString[1] = stringOfMaxSequence;
        return sequenceLengthAndString;
    }

    static void PrintMatrix(string[,] matrixToPrint, string textToDisplay) //Print given matrix
    {
        Console.WriteLine(textToDisplay);

        //Two nested loop to print the matrix
        for (int row = 0; row < matrixToPrint.GetLength(0); row++)
        {
            for (int col = 0; col < matrixToPrint.GetLength(1); col++)
            {
                //Format the output for better visualization
                Console.Write(Convert.ToString(matrixToPrint[row, col]).PadLeft(spaceBetweenNumber, ' '));
            }

            Console.WriteLine();
        }
    }

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input data
    {
        int validatedInteger;

        Console.Write(textToDisplay);

        while (true) //If number is invalide or is less than 1, the input will no be accepted
        {
            while (!int.TryParse(Console.ReadLine(), out validatedInteger))
            {
                Console.WriteLine("Please enter a correct integer number!");
            }

            if (validatedInteger > 0) //Matrix index can Not be negative! Also there is no point to set 0
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter positive integer, greather than 0!");
            }
        }

        return validatedInteger;
    }
}