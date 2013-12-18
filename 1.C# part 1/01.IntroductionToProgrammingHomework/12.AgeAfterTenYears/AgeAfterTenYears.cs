// 12. * Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        byte age;
        byte yearsToAdd = 10;
        Console.WriteLine("Please enter your age!");

        //Trying to parse the string entered in the console
        while (!byte.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Please enter correct age!!!");
        }
        Console.WriteLine("Your age after 10 years will be {0}", age += yearsToAdd);
    }
}
