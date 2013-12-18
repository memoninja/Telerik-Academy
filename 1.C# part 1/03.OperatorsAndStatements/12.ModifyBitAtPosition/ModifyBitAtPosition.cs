// 12. We are given integer number n, value v (v=0 or 1) and a position p.
//      Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//      Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//      n = 5 (00000101), p=2, v=0 -> 1 (00000001)

using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        int inputNumber;
        byte bitToPosition;
        byte lengthOfInputNumberInBinary;
        int mask;
        byte bitValue;
        int changedInputNumber;

        Console.WriteLine("This program modifies bit at given position!\n{0}", new string('-', 50));

        Console.WriteLine("Please enter integer number, n:");
        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }

        Console.WriteLine("{0}\nPlease enter bit position(counting from 0) to modify, p:", new string('-', 50));
        while (true)
        {
            //Trying to parse byte until a correct number is entered
            while (!byte.TryParse(Console.ReadLine(), out bitToPosition))
            {
                Console.WriteLine("Please enter correct number!");
                continue;
            }
            
            //Convert the input number in binary system and get its length(number of bits)
            lengthOfInputNumberInBinary = (byte)Convert.ToString(inputNumber, 2).Length;

            //Check if the entered bit position is greather than the length(number of bits) of the input number in binary system
            if (bitToPosition >= lengthOfInputNumberInBinary)
            {
                Console.WriteLine("The bit position you have entered is greather than the count of the bits of the input number!!!");
                Console.WriteLine("Please enter correct bit position!");
                continue;
            }
            else
            {
                //break the cycle if the bit position is lower than the number of bits if the input number
                break;
            }
        }

        Console.WriteLine("{0}\nPlease enter bit value(0 or 1) to modify to, v:", new string('-', 50));
        while (true)
        {
            //Trying to parse byte until a correct number is entered
            while (!byte.TryParse(Console.ReadLine(), out bitValue))
            {
                Console.WriteLine("Please enter correct number!");
            }
            
            //Check if the entered value is 0 or 1, if it is not the cycle goes on until a correct value is entered
            if (bitValue == 0 || bitValue == 1)
            {
                break;
            }

            Console.WriteLine("Please enter 0 or 1");
        }

        //Check if bit value is 1
        if (bitValue == 1)
        {
            //Bit at given position is set to 1 and all other bits are 0
            mask = (1 << bitToPosition);
            //The bitwise operatos "or" is used to change the bit
            changedInputNumber = (inputNumber | mask);
        }
        else
        {
            //Bit at given position is set to 0 and all other bits are 1
            mask = ~(1 << bitToPosition);
            //The bitwise operatos "and" is used to change the bit
            changedInputNumber = inputNumber & mask;
        }

        Console.WriteLine("{0}\nThe binary representation of the number you entered is:\n{1}\n{0}", new string('-', 50), Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("n={0}; p={1}; v={2}", inputNumber, bitToPosition, bitValue);
        Console.WriteLine(Convert.ToString(changedInputNumber, 2).PadLeft(32, '0'));
    }
}