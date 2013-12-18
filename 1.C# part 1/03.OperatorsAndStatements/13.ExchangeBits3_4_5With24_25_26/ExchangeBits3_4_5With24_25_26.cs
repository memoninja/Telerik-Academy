// 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits3_4_5With24_25_26
{
    static void Main()
    {
        uint bitValue = 1;      //This variable is used because it is not good practise to directly put numbers(magic numbers)!
        uint inputNumber;       //Number to exchange the bits, put from the user
        uint changingInputNumber;
        uint maskSmallBits;     //Mask for bit 3, 4, 5
        uint maskBigBits;       //Mask for bit 24, 25, 26
        byte currentSmallBit;   //Value of current bit 3, 4 or 5
        byte currentBigBit;     //Value of current bit 24, 25 or 26

        Console.WriteLine("Please enter integer number to exchange the bits to.");

        //Trying to parse unsigned integer until a correct number is entered
        while (!uint.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct integer number!");
        }

        //I want to keep input value, that's why I use variable "changingInputNumber"
        changingInputNumber = inputNumber;

        for (int i = 3, j = 24; i <= 5; i++, j++)
        {
            //Set the bit to the wanted position. This is used for bit 3, 4, 5.
            maskSmallBits = bitValue << i;

            //Check the value of the current bit and assign it to variable. This is used for bit 3, 4, 5.
            if ((changingInputNumber & maskSmallBits) == 0)
            {
                currentSmallBit = 0;
            }
            else
            {
                currentSmallBit = 1;
            }

            //Set the bit to the wanted position. This is used for bit 24, 25, 26.
            maskBigBits = bitValue << j;

            //Check the value of the current bit and assign it to variable. This is used for bit 3, 4, 5
            if ((changingInputNumber & maskBigBits) == 0)
            {
                currentBigBit = 0;
            }
            else
            {
                currentBigBit = 1;
            }

            //Check if the values of current bits(3-24, 4-25, 5-26) are not equal.
            if (currentSmallBit != currentBigBit)
            {
                //Used operator "exclusive-OR" to set the current bit to the wanted value
                changingInputNumber = (changingInputNumber ^ maskSmallBits);
                changingInputNumber = (changingInputNumber ^ maskBigBits);
            }
        }

        Console.WriteLine("\nNumber before switch operations: {0}", Convert.ToString(inputNumber, 2).PadLeft(27, '0'));
        Console.WriteLine("Number after switch operations : {0}", Convert.ToString(changingInputNumber, 2).PadLeft(27, '0'));
    }
}