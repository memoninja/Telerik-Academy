// 02. Write a program that reads a rectangular matrix of size N x M
//     and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;

class FindMaximal3x3SquareSumInMatrix
{
    //You cna change the size of the submatrix, by changing the value of "subMatrixSize"
    static int subMatrixSize = 2;

    //If you can't see the separate number, enlarge "spaceBetweenNumber"
    static int spaceBetweenNumber = 4;

    static void Main()
    {
        //Note that if the size of the matrix is less than the size of the submatrix, the sum will be 0!

        int sizeN;
        int sizeM;
        int[,] matrixToSearchIn;
        int maxSum;

        //Using method "ValidateInputInteger(string textToDisplay)", to validate the input data
        sizeN = ValidateInputInteger("Please enter size N: ");
        sizeM = ValidateInputInteger("Please enter size M: ");

        matrixToSearchIn = new int[sizeN, sizeM]; //Set the size of the matrix

        SetValuesToMatrix(matrixToSearchIn); //Using method "SetValuesToMatrix(int[,] matrix)" to assign random values to the matrix

        Console.WriteLine(new string('=', 50)); //This is for better visualization
        PrintMatrix(matrixToSearchIn, "Current matrix with random values!"); //Method to print the generated matrix with random values

        //Using method "FindMaximalSumOfSubMatrix(int[,] matrix)", to find the maximal sum of submatrix
        maxSum = FindMaximalSumOfSubMatrix(matrixToSearchIn);

        Console.WriteLine();
        //Print the maximal sum
        Console.WriteLine("The maximal sum of submatrix {0}x{0} is: {1}", subMatrixSize, maxSum);
    }

    static int FindMaximalSumOfSubMatrix(int[,] matrix)
    {
        int maximalSum = 0;

        //Iterate thtough the matrix with two nested loop. Set the bounds of the matrix by subtracting the submatrix dimensions.
        //Matrix length - submatrix length
        for (int row = 0; row < matrix.GetLength(0) - subMatrixSize + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - subMatrixSize + 1; col++)
            {
                int currentSum = 0;

                //Start to iterate through the submatrix at current "col" and "row" indeces, and sum the values in the submatrix.
                for (int subRow = row; subRow < row + subMatrixSize; subRow++)
                {
                    for (int subCol = col; subCol < col + subMatrixSize; subCol++)
                    {
                        currentSum += matrix[subRow, subCol]; //Sum the values in the submatrix
                    }
                }

                if (currentSum > maximalSum) //If current sum is greather than the maximal sum, assign it as maximal sum
                {
                    maximalSum = currentSum;
                }
            }
        }

        return maximalSum; //Return tha maximal found sum;
    }

    static void SetValuesToMatrix(int[,] matrix) //This method assign random values between 1 and 50, to the matrix
    {
        Random randomizer = new Random(); //Using "Random" class to initialize a variable of type random, which will generate random numbers

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = randomizer.Next(1, 51); // Generate random values between 1 and 50, and assign them
            }
        }
    }

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input data
    {
        int validatedInteger;

        Console.Write(textToDisplay);

        while (true)
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

    static void PrintMatrix(int[,] matrixToPrint, string textToDisplay) //Print given matrix
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
}
