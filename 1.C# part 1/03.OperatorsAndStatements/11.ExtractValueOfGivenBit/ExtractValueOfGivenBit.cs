// 11. Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2-> value=1.

using System;

class ExtractValueOfGivenBit
{
    static void Main()
    {
        int inputNumber;
        byte bitToExtract;
        int mask;
        byte bitValue = 1;

        Console.WriteLine("This program extract bit at given position!\n{0}", new string('-', 50));

        Console.WriteLine("Please enter integer number.");
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }

        Console.WriteLine("{0}\nPlease enter bit position(counting from 0) to extract.", new string('-', 50));
        //Trying to parse byte until a correct number is entered
        while (!byte.TryParse(Console.ReadLine(), out bitToExtract))
        {
            Console.WriteLine("Please enter correct number!");
        }

        Console.WriteLine("{0}\nThe binary representation of the number is:\n{1}\n{0}", new string('-', 50), Convert.ToString(inputNumber, 2).PadLeft(32, '0'));

        //Set the bit at the position we want to chek to 1
        mask = 1 << bitToExtract;

        //Check if the value of a bit at given position is 0
        if ((inputNumber & mask) == 0)
        {
            bitValue = 0;
        }

        Console.WriteLine("i={0}; b={1} -> value = {2}\n", inputNumber, bitToExtract, bitValue);
    }
}