// 1. Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class AppropriateVariables
{
    static void Main()
    {
        byte _byte = 97;
        sbyte _sbyte = -115;
        short _short = -10000;
        ushort _ushort = 52130;
        int _int = 4825932;

        Console.WriteLine("byte: {0} \nsbyte: {1} \nshort: {2} \nushort: {3} \nuint: {4}", _byte, _sbyte, _short, _ushort, _int);
    }

}