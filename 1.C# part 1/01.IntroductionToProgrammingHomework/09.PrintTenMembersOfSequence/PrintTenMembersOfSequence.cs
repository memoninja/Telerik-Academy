// 9. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintTenMembersOfSequence
{
    static void Main()
    {
        byte startNumber = 2;
        byte lastNumber = 11;
        while (startNumber <= lastNumber)
        {
            //Check if number is odd or even
            if (startNumber % 2 != 0)
            {
                //Check if it is the last one of the sequence and do Not put comma after it
                if (startNumber == lastNumber)
                {
                    Console.WriteLine("{0}", lastNumber * (-1));
                    return;
                }
                Console.Write("{0}, ", startNumber * (-1));
            }
            else
            {
                //Check if it is the last one of the sequence and do Not put comma after it
                if (startNumber == lastNumber)
                {
                    Console.WriteLine("{0}", lastNumber);
                    return;
                }
                Console.Write("{0}, ", startNumber);
            }
            startNumber++;
        }
    }
}