// 8. Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings.

using System;

class QuotationString
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string noQuotedString = "The use of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", quotedString, noQuotedString);

        Console.WriteLine(new string('-', 44));

        //This is another way to write exactly what you want
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
    }
}