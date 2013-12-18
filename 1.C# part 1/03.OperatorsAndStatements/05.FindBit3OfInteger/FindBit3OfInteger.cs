// 5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class FindBit3OfInteger
{
    static void Main()
    {
        byte bitPosition = 3;
        int numberToCheck;

        Console.WriteLine("Please enter an integer to check the value of the third bit");
        
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out numberToCheck))
        {
            Console.WriteLine("Please enter a correct integer!");
        }

        Console.WriteLine("{0}\nThe number you entered converted to binary number is:\n{1}", new string('-', 60), Convert.ToString(numberToCheck, 2));

        //Set mask to 1000 - the position of bit 3
        int mask = 1 << bitPosition;
        
        //Compare bits 3 with "&" and check if result is not 0
        bool isThirdBit1 = (mask & numberToCheck) != 0;

        Console.WriteLine("{0}\nIs bit 3 equals 1? -> {1}\n", new string('-', 60), isThirdBit1);
    }
}