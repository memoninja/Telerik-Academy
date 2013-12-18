// 9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class PrintIsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyRight = '\u00A9';
        char space = '\u00A0';
        byte numberOfSymbols;
        byte rows = 0;
        byte printedSymbolsPerRow = 1;

        Console.WriteLine("Please enter number of symbols to draw a isosceles triangle");
        //Check if a correct number is entered
        if (!byte.TryParse(Console.ReadLine(), out numberOfSymbols))
        {
            Console.WriteLine("You did not entered a correct number!");
            return;
        }
        
        //Returns the largest byte less than or equal to the square root of the entered number
        rows = (byte)Math.Floor(Math.Sqrt(numberOfSymbols));
        Console.WriteLine("The closest possible number of symbols to draw a isosceles triangle is {0}", Math.Pow(rows, 2));
        Console.WriteLine(new string('-', 73));
        
        //Cycle for printing the isosceles triangle
        for (int i = 1; i <= rows; i++)
        {
            Console.Write(new string(space, rows - i));
            Console.Write(new string(copyRight, printedSymbolsPerRow));
            Console.WriteLine("");
            printedSymbolsPerRow += 2;
        }
        
        Console.WriteLine(new string('-', 73));
    }
}