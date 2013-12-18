// 5. Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class SymbolInUnicode
{
    static void Main()
    {
        char unicodeSymbol = '\u0048';  //This is "H" symbol in unicode

        Console.WriteLine("Unicode symbol 72 is {0}", unicodeSymbol);
    }
}