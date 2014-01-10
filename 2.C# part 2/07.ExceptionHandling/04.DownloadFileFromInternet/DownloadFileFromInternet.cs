// 04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//     and stores it the current directory. Find in Google how to download files in C#.
//     Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

namespace _04.DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main()
        {
            string url;
            string fileName;

            try
            {
                Console.Write("Enter url: ");
                url = Console.ReadLine();

                Console.Write("Enter name to save file: ");
                fileName = Console.ReadLine();

                Console.WriteLine("Downloading...");
                //Call method "DownloadFileByUrl(string url, string fileName)" to download file over the internet. File is saved in the current directory(where is .exe of the program)
                DownloadFileByUrl(url, fileName);

                Console.WriteLine("Done!");
            }
            // List of possible exceptions
            catch (ArgumentNullException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (WebException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (ArgumentOutOfRangeException exc)
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
        /// Download file over the internet
        /// </summary>
        /// <param name="fileName">Name of the file to be saved</param>
        private static void DownloadFileByUrl(string url, string fileName)
        {
            WebClient client = new WebClient(); //Using object of type "WebClient" to download a file over the internet

            using (client)
            {
                client.DownloadFile(url, fileName);
            }
        }
    }
}
