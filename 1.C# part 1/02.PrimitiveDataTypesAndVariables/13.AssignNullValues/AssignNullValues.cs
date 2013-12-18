// 13. Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class AssignNullValues
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;

        Console.WriteLine("This is int?: {0} \nThis is double?: {1}", intNull, doubleNull);

        intNull += null;
        Console.WriteLine("This is int? after adding null literal: {0}", intNull);

        doubleNull += 10;
        Console.WriteLine("This is double? after adding 10: {0}", doubleNull);

        doubleNull = 15;
        Console.WriteLine("This is double? after assigning 15: {0}", doubleNull);
    }
}