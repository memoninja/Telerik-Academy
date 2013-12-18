// 2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatOrDoubleAssignment
{
    static void Main()
    {
        double firstNumber = 34.567839023;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857;
        float fourthNumber = 3456.091f;

        Console.WriteLine("Float numbers are: {0} and {1}", secondNumber, fourthNumber);
        Console.WriteLine("Double numbers are: {0} and {1}", firstNumber, thirdNumber);
    }
}