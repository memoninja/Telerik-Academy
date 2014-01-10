// 03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//     reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//     Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Text;
using System.IO;

namespace _03.ReadFileContentAndPrintIt
{
    class ReadFileContentAndPrintIt
    {
        static void Main()
        {
            try
            {
                string fileText = ReadFile(); // Call method "ReadFile()" in try-catch, because it can throw exceptions
                Console.WriteLine("File text: \n{0}", fileText);
            }
            // List of possible exceptions
            //Microsoft messages are friendly enough, I suppose
            catch (ArgumentNullException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (PathTooLongException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (UnauthorizedAccessException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (OutOfMemoryException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Something went wrong, really wrong!?!");
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }

        /// <summary>
        /// Read text file by given source path
        /// </summary>
        /// <returns>Text of the file</returns>
        private static string ReadFile()
        {
            string text = string.Empty;
            string filePath = Console.ReadLine();

            ////First way to read file. This way cyrillic symbols do not appear
            //text = System.IO.File.ReadAllText(filePath);

            // Second way to read file. If characters don't appear correct, change encoding
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("windows-1251"));

            using (reader) //"using" is used, to free the used resources
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

    }
}
