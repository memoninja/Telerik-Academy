// 01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

namespace _01.ReadFileAndPrintIt
{
    class ReadFileAndPrintIt
    {
        static void Main()
        {
            string filePath = @"..\..\Text files\Numerated lines.txt";

            PrintOddLinesOfFile(filePath); // Print the odd lines of a file, by using method "PrintOddLinesOfFile(string filePath)"
        }

        private static void PrintOddLinesOfFile(string filePath)
        {
            // Set the location of the file to read and the encoding
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("windows-1251"));

            using (reader)
            {
                int lineCounter = 1;
                string line;

                // Read file until it reaches the end("null")
                while ((line = reader.ReadLine()) != null)
                {
                    // Check if counter is odd
                    if ((lineCounter & 1) != 0)
                    {
                        Console.WriteLine("{0}: {1}", lineCounter, line);
                    }

                    lineCounter++; // Track the number of the current line, by incrementing the line counter on each iteration
                }
            }
        }
    }
}
