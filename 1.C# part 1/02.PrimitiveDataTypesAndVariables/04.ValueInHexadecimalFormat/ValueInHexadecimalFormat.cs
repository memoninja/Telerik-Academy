// 4. Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.

using System;

class ValueInHexadecimalFormat
{
    static void Main()
    {
        int hexNumber = 0xFE;

        Console.WriteLine("\"{0:X}\" is the hexadecimal representation of the number {0}", hexNumber);
    }
}