// 05. Write a program that reads a text file containing a square matrix of numbers and
//     finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//     The first line in the input file contains the size of matrix N.
//      Each of the next N lines contain N numbers separated by space.
//     The output should be a single number in a separate text file. Example:
//      4
//      2 3 3 4
//      0 2 3 4		->	17
//      3 7 1 2
//      4 3 3 2

using System;
using System.Text;
using System.IO;

namespace _05.FindMaxSumOfMatrixOf2By2
{
    class FindMaxSumOfMatrixOf2By2
    {
        static void Main()
        {
            // First way: store the matrix in two dimensional array and find maximum sum

            // Second way calculating sum, while reading the matrix
            // We can change the size of the matrix, but it always have to square (length == height)
            // If we change all "int" variable to "double", we can work with floating point numbers

            string matrixPath = @"..\..\Text files\Matrix.txt";
            string maxSumFilePath = @"..\..\Text files\MaxSum.txt";
            int maxSum;

            // Find max sum, using method "CalcMaxSumOfMatrix2By2(string filePath)"
            maxSum = CalcMaxSumOfMatrix2By2(matrixPath);

            // Write the max sum to a file, using method "WriteMaxNumber(string filePath, int number)"
            WriteMaxNumber(maxSumFilePath, maxSum);

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// Find max sum of submatrix 2 by 2
        /// </summary>
        /// <param name="filePath">Path to the file</param>
        /// <returns>Max sum</returns>
        private static int CalcMaxSumOfMatrix2By2(string filePath)
        {
            int currentSum = 0;
            int maxSum = 0;

            StreamReader reader = new StreamReader(filePath); // We have only digits, so we don't need encoding

            using (reader)
            {
                int matrixSize = int.Parse(reader.ReadLine());
                string[] currentLine;
                string[] nextLine = reader.ReadLine().Split(' '); // Split the string by spaces. This way we have only numers in the array elements

                for (int row = 0; row < matrixSize - 1; row++)
                {
                    // On each iteration we store the "nextLine" in "currentLine" and read another line from the file. We only use references, so this is not slow operation
                    currentLine = nextLine;
                    nextLine = reader.ReadLine().Split(' ');

                    for (int col = 0; col < matrixSize - 1; col++)
                    {
                        // On each iteration parse the numbers and sum them, for 2 by 2 matrix
                        currentSum = (int.Parse(currentLine[col]) + int.Parse(currentLine[col + 1]));
                        currentSum += (int.Parse(nextLine[col]) + int.Parse(nextLine[col + 1]));

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                        }
                    }
                }
            }

            return maxSum;
        }

        /// <summary>
        /// Write number into a file
        /// </summary>
        /// <param name="filePath">Path to file</param>
        /// <param name="number">Number to write</param>
        private static void WriteMaxNumber(string filePath, int number)
        {
            StreamWriter writer = new StreamWriter(filePath); // We have only digits, so we don't need encoding

            using (writer)
            {
                writer.Write(number);
            }
        }
    }
}
