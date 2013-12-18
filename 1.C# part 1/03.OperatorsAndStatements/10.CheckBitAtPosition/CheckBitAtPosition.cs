// 10. Write a boolean expression that returns if the bit at position p (counting from 0) 
// in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int inputNumber;
        byte bitToCheck;
        int mask;
        bool hasValue1;

        Console.WriteLine("This program check if bit at given position is 1!\nReturn \"True\" if it is 1 and \"False if it is 0\" \n{0}", new string('-', 50));

        Console.WriteLine("Please enter integer number.");
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }

        Console.WriteLine("{0}\nPlease enter bit position(counting from 0) to check.", new string('-', 50));
        //Trying to parse byte until a correct number is entered
        while (!byte.TryParse(Console.ReadLine(), out bitToCheck))
        {
            Console.WriteLine("Please enter correct number!");
        }

        Console.WriteLine("{0}\nThe binary representation of the number is:\n{1}\n{0}", new string('-', 50), Convert.ToString(inputNumber, 2).PadLeft(32, '0'));

        //Set the bit at the position we want to chek to 1
        mask = 1 << bitToCheck;

        //Check if a bit at given position has value different from 0
        hasValue1 = (inputNumber & mask) != 0;
        
        Console.WriteLine("v={0}; p={1} -> {2}\n", inputNumber, bitToCheck, hasValue1);
    }
}