// 11. Declare two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeIntegerValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int buffer;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        Console.WriteLine(new string('-', 20));

        // Exchange the values
        Console.WriteLine("Exchanged values");
        buffer = a;
        a = b;
        b = buffer;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        Console.WriteLine(new string('-', 20));

        // Exchanege the values back to the original values
        Console.WriteLine("Exchanege the values back to the original values");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        Console.WriteLine(new string('-', 20));

        // Exchange the values again
        Console.WriteLine("Exchange the values again");
        a = a ^ b;
        b = b ^ a;
        a = a ^ b;
        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}