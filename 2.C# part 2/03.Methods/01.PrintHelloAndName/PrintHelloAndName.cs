// 01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//     Write a program to test this method.

using System;

class PrintHelloAndName
{
    static void Main()
    {
        PrintGivenName(); //Using method "PrintGivenName()" to print given name
    }

    /// <summary>
    /// Method to ask for a name and print it
    /// </summary>
    static void PrintGivenName() //Method is with no parameters
    {
        string inputName;

        Console.Write("Please enter your name: ");
        inputName = Console.ReadLine(); //Save the name in variable "inputName"

        Console.WriteLine("Hello, {0}!", inputName); //Print: Hello + inputName
    }
}
