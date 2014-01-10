// 03. Write a program that reads a text file and inserts line numbers in front of each of its lines.
//     The result should be written to another text file.

using System;
using System.Text;
using System.IO;

namespace _03.InsertNumberOnEachLine
{
    class InsertNumberOnEachLine
    {
        static void Main()
        {
            // Path to files to read and write to
            string fileToRead = @"..\..\Text files\SomeText.txt";
            string fileToWriteTo = @"..\..\Text files\NumberedText.txt";

            // Insert line number in front of each line and write to "fileToWriteTo", using method "InsertLineNumbers(string fileToReadPath, string fileToWritePath)"
            InsertLineNumbers(fileToRead, fileToWriteTo);

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// Insert line number in front of each line and write to another file
        /// </summary>
        /// <param name="fileToReadPath">Path of file to read</param>
        /// <param name="fileToWritePath">Path of file to write</param>
        private static void InsertLineNumbers(string fileToReadPath, string fileToWritePath)
        {
            StreamReader reader = new StreamReader(fileToReadPath, Encoding.GetEncoding("windows-1251"));

            using (reader)
            {
                int lineCounter = 1;
                string lineText;
                StreamWriter writer = new StreamWriter(fileToWritePath, false, Encoding.GetEncoding("windows-1251"));

                using (writer)
                {
                    // On each iteration check if file lines are over.
                    // Insert line number
                    // Every time increment the lines counter, to track the lines
                    while ((lineText = reader.ReadLine()) != null)
                    {
                        writer.WriteLine("{0}: {1}", lineCounter, lineText);

                        lineCounter++;
                    }
                }
            }
        }
    }
}
