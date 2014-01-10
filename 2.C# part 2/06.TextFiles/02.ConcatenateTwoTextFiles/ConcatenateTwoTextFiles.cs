// 02. Write a program that concatenates two text files into another text file.

using System;
using System.Text;
using System.IO;

namespace _02.ConcatenateTwoTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main()
        {
            string fileOneoPath = @"..\..\Text files\FileOne.txt";
            string fileTwoPath = @"..\..\Text files\FileTwo.txt";
            string fileToWrite = @"..\..\Text files\ConcatenatedFiles.txt";

            // Concatenate the two files, using method "ConcatenateFiles(string fileOneToReadPath, string fileTwoToReadPath, string fileToWritePath)"
            ConcatenateFiles(fileOneoPath, fileTwoPath, fileToWrite);

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// Concatenate two files into another text file
        /// </summary>
        /// <param name="fileOneToReadPath">First file to concatenate</param>
        /// <param name="fileTwoToReadPath">Second file to concatenate</param>
        /// <param name="fileToWritePath">File to concatenate the two files</param>
        private static void ConcatenateFiles(string fileOneToReadPath, string fileTwoToReadPath, string fileToWritePath)
        {
            string fileOneText;
            string fileTwoText;

            // Call method "ReadFile(string filePath)" two time to read both files
            fileOneText = ReadFile(fileOneToReadPath);
            fileTwoText = ReadFile(fileTwoToReadPath);

            // Call method "WriteToFile(string fileOneText, string fileTwoText, string fileToWritePath)" to concatenate the two files
            WriteToFile(fileOneText, fileTwoText, fileToWritePath);
        }

        /// <summary>
        /// Read whole file
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <returns>String with file text</returns>
        private static string ReadFile(string filePath)
        {
            // In this scenario, I read the whole file and assign it to a string. If file is too big this can cause "OutOfMemoryException".
            // If this happens, we have to read and write the files line by line

            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("windows-1251"));

            using (reader)
            {
                string text = reader.ReadToEnd();

                return text;
            }
        }

        /// <summary>
        /// Write given strings to a file
        /// </summary>
        /// <param name="fileOneText"></param>
        /// <param name="fileTwoText"></param>
        private static void WriteToFile(string fileOneText, string fileTwoText, string fileToWritePath)
        {
            StreamWriter writer = new StreamWriter(fileToWritePath, true, Encoding.GetEncoding("windows-1251"));

            // One "writer" is used to write the two files into another text file.
            using (writer)
            {
                writer.Write(fileOneText);
                writer.WriteLine();
                writer.Write(fileTwoText);
            }
        }
    }
}
