// 12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

using System;

class PrintACIITable
{
    static void Main()
    {
        Console.Title = "ASCII Table";

        char symbol;
        
        //Cycle to print the ASCII table
        for (byte i = 0; i <= 127; i++)
        {
            symbol = (char)i;
            Console.WriteLine(symbol);
        }
    }
}