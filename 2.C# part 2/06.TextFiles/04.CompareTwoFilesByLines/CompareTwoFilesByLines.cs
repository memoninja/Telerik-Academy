// 04. Write a program that compares two text files line by line
//     and prints the number of lines that are the same and the number of lines that are different.
//     Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;

namespace _04.CompareTwoFilesByLines
{
    class CompareTwoFilesByLines
    {
        static void Main()
        {
            int[] equalAndDiffLinesCount;

            // Path to files to read
            string fileOne = @"..\..\Text files\FileOne.txt";
            string fileTwo = @"..\..\Text files\FileTwo.txt";

            // Get count of equal and different lines, by using method "CompareFilesByLines(string fileOnePath, string fileTwoPath)"
            equalAndDiffLinesCount = CompareFilesByLines(fileOne, fileTwo);

            Console.WriteLine("Equal lines count: {0}".PadLeft(26), equalAndDiffLinesCount[0]);
            Console.WriteLine("Different lines count: {0}", equalAndDiffLinesCount[1]);
        }

        /// <summary>
        /// Compare two for equal lines
        /// </summary>
        /// <param name="fileOnePath">First file to compare</param>
        /// <param name="fileTwoPath">Second file to compare</param>
        /// <returns>Array, on index 0 is the count of equal lines and on index 1 is the count of different lines</returns>
        private static int[] CompareFilesByLines(string fileOnePath, string fileTwoPath)
        {
            int[] equalAndDiffLines = new int[2];
            int equalLinesCount = 0;
            int diffLinesCount = 0;

            // We need two readers to compare the files line by line
            StreamReader readerOne = new StreamReader(fileOnePath, Encoding.GetEncoding("windows-1251"));
            StreamReader readerTwo = new StreamReader(fileTwoPath, Encoding.GetEncoding("windows-1251"));

            // Two nested "using" statements for the two readers
            using (readerOne)
            {
                using (readerTwo)
                {
                    string fileOneLine;
                    string fileTwoLine;

                    while ((fileOneLine = readerOne.ReadLine()) != null)
                    {
                        fileTwoLine = readerTwo.ReadLine();

                        // Compare the lines and increment the corresponding variable
                        if (fileOneLine.Equals(fileTwoLine))
                        {
                            equalLinesCount++;
                        }
                        else
                        {
                            diffLinesCount++;
                        }
                    }
                }
            }

            equalAndDiffLines[0] = equalLinesCount;
            equalAndDiffLines[1] = diffLinesCount;

            return equalAndDiffLines;
        }
    }
}
