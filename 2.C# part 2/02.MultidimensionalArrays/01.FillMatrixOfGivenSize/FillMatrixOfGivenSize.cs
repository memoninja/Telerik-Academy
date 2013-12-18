// 01. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;
using System.Linq;

class FillMatrixOfGivenSize
{
    //If you enter greather matrix sizes(like 10) and you can't see the separate number, enlarge "spaceBetweenNumber"
    static int spaceBetweenNumber = 3;

    static void Main()
    {
        int matrixSize;

        matrixSize = ValidateInputInteger();//Using method to validate the input data

        PrintMatrixA(matrixSize); //Using method "PrintMatrixA(int matrixSize)" to print matrix of type "A"
        Console.WriteLine();

        PrintMatrixB(matrixSize); //Using method "PrintMatrixB(int matrixSize)" to print matrix of type "B"
        Console.WriteLine();

        PrintMatrixC(matrixSize); //Using method "PrintMatrixC(int matrixSize)" to print matrix of type "C"
        Console.WriteLine();

        PrintMatrixD(matrixSize); //Using method "PrintMatrixD(int matrixSize)" to print matrix of type "D"
    }

    static void PrintMatrixA(int matrixSize) //Directly print the wanted matrix
    {
        Console.WriteLine("Matrix of type \"A\"");

        //Two nested loops to iterate through the matrix indeces.
        for (int row = 0; row < matrixSize; row++) //Print a)
        {
            int currentNumber = row + 1; //Adding 1 to the row index, because we want to start from 1, not 0

            for (int col = 0; col < matrixSize; col++)
            {
                //Format the output for better visualization
                Console.Write(Convert.ToString(currentNumber).PadLeft(spaceBetweenNumber, ' '));

                //There is dependence, every next element in a single row(column after column) is greather with exactly the size of the matrix, from the previuos
                currentNumber += matrixSize; // so we add that size. This way we do Not need neither matrix nor array!
            }

            Console.WriteLine();
        }
    }

    static void PrintMatrixB(int matrixSize) //Fill matrix of type "B"
    {
        int[,] matrixToFill = new int[matrixSize, matrixSize]; //Write the ascending sequence of numbers into matrix
        int colCounter = 0;
        int rowCounter = 0;
        int numberCounter = 1;
        bool isDown = true;

        while (colCounter < matrixSize)
        {
            //Track the index direction. If it goes "Up" and reaches the "top"(0), we start to increment that index(going "Down")
            if (rowCounter < 0)
            {
                isDown = true;
                rowCounter++;
            }
            //Track the index direction. If it goes "Down" and reaches the "Bottom"(matriz size), we start to decrement that index(going "Up")
            else if (rowCounter > matrixSize - 1)
            {
                isDown = false;
                rowCounter--;
            }

            //Loop goes while we are in the array bounds
            while (rowCounter < matrixSize && rowCounter > -1)
            {
                matrixToFill[rowCounter, colCounter] = numberCounter;

                if (isDown) //If we go "down", increment the row index
                {
                    rowCounter++;
                }
                else if (!isDown) //If we go "up", decrement the row index
                {
                    rowCounter--;
                }

                numberCounter++; //On each iteration we increment the current number. We want ascending sequence
            }

            //The col index is increment after we reaches the "Top" or the "Bottom" of the array. Goes to the next column.
            colCounter++;
        }

        //Using method "PrintMatrix(int[,] matrixToPrint, string textToDisplay)" to print the matrix
        PrintMatrix(matrixToFill, "Matrix of type \"B\"");
    }

    static void PrintMatrixC(int matrixSize) //Fill matrix of type "C"
    {
        int[,] matrixToFill = new int[matrixSize, matrixSize]; //Write the ascending sequence of numbers into matrix
        int currentNumber = 1;
       
        //Set the position to the lower left corner(col = 0 and row = matrixSize - 1)
        int row = matrixSize - 1;
        int col = 0;

        //Track the position of the "diagonally" movement
        int currentRow;
        int currentCol;

        //The loop always goes "down" and "right"(diagonally), after each diagonal set the position to one row up, or one column right
        while (row >= 0 && col <= matrixSize - 1)
        {
            currentRow = row;
            currentCol = col;

            //Check only if row and col are greather than matrix size, because we always goes "down" and "right"(diagonally)
            while (currentRow < matrixSize && currentCol < matrixSize)
            {
                matrixToFill[currentRow, currentCol] = currentNumber;

                //After we set the current position, we start to move "down" and "right"(diagonally), until we reach the bounds of the matrix
                currentRow++;
                currentCol++;
                currentNumber++;
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

        //Using method "PrintMatrix(int[,] matrixToPrint, string textToDisplay)" to print the matrix
        PrintMatrix(matrixToFill, "Matrix of type \"C\"");
    }

    static void PrintMatrixD(int matrixSize) //Fill matrix of type "D"
    {
        int[,] matrixToFill = new int[matrixSize, matrixSize]; //Write the ascending sequence of numbers into matrix
        int currentSize = matrixSize;
        int maxNumber = (int)Math.Pow(matrixSize, 2);
        int currentNumber = 0;

        //Track the movement across the matrix by indeces
        int currentRow = 0;
        int currentCol = 0;

        //Track the movement across the matrix by seting the directions
        bool isRight = false;
        bool isLeft = false;
        bool isUp = false;
        bool isDown = true;

        while (currentNumber < maxNumber) //Loop goes until we reach the maximal number (N^2)
        {
            while (true)
            {
                currentNumber++; //Increment the current number on each iteration

                matrixToFill[currentRow, currentCol] = currentNumber; //Assign the current number in the current position on the matrix

                //The following checks are for the direction we have to keep. If we reach the bounds of the matrix, inner loop breaks.
                //Note that the bounds of the matrix are shrinking(decrement), as soon as we start to go "Left"
                if (isDown)
                {
                    currentRow++;

                    if (currentRow == currentSize) //If upper bounds are reached, break the loop
                    {
                        break;
                    }
                }
                else if (isRight)
                {
                    currentCol++;

                    if (currentCol == currentSize) //If upper bounds are reached, break the loop
                    {
                        break;
                    }
                }
                else if (isUp)
                {
                    currentRow--;

                    if (currentRow == (matrixSize - 1) - currentSize) //If lower bounds are reached, break the loop
                    {
                        break;
                    }
                }
                else if (isLeft)
                {
                    currentCol--;

                    if (currentCol == (matrixSize - 1) - currentSize) //If lower bounds are reached, break the loop
                    {
                        break;
                    }
                }
            }

            //The following checks are for setting the direction, after we reach the bounds of the matrix
            if (currentRow == currentSize && !isRight)
            {
                currentRow--;
                currentCol++;

                isRight = true; //Set wanted direction to "true"
                //Set other directions to "false"
                isDown = false; 
                isLeft = false;
                isUp = false;
            }
            else if (currentCol == currentSize && !isUp)
            {
                currentCol--;
                currentRow--;

                isUp = true; //Set wanted direction to "true"
                //Set other directions to "false"
                isRight = false;
                isDown = false;
                isLeft = false;
            }
            else if (currentRow == ((matrixSize - 1) - currentSize) && !isLeft)
            {
                currentRow++;
                currentCol--;

                isLeft = true; //Set wanted direction to "true"
                //Set other directions to "false"
                isUp = false;
                isRight = false;
                isDown = false;

                currentSize--; //This variable track the free cells in the matrix and shrink it, so we do not override other values
            }
            else if (currentCol == ((matrixSize - 1) - currentSize) && !isDown)
            {
                currentCol++;
                currentRow++;

                isDown = true; //Set wanted direction to "true"
                //Set other directions to "false"
                isUp = false;
                isRight = false;
                isLeft = false;
            }
        }

        //Using method "PrintMatrix(int[,] matrixToPrint, string textToDisplay)" to print the matrix
        PrintMatrix(matrixToFill, "Matrix of type \"D\"");
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

    static int ValidateInputInteger() //Method to validate the input data
    {
        int validatedInteger;

        Console.Write("Please eneter matrix size: ");

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
}
