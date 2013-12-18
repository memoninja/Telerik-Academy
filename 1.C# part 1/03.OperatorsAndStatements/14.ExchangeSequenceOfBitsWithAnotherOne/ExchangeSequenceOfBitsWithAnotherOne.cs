// 14. * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeSequenceOfBitsWithAnotherOne
{
    //This method is used to parse the integer value entered from the user
    static uint TryParseInputIntegerNumber(string textToDisplay)
    {
        uint inputNumber;

        Console.WriteLine(new string('-', 75));
        Console.WriteLine(textToDisplay);

        //Trying to parse unsigned integer until a correct number is entered
        while (!uint.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct integer number!!!\n{0}", new string('-', 40));
        }
        // inputNumber is being returned from the method
        return inputNumber;
    }

    static void Main()
    {
        uint bitValue = 1;              //This variable is used because it is not good practise to directly put numbers(magic numbers)!
        uint inputNumber;               //Number to exchange the bits, put from the user
        uint changingInputNumber;
        byte startBitOfFirstSequence;   //The starting bit of the first sequence of bits
        byte startBitOfSecondSequence;  //The starting bit of the second sequence of bits
        byte sequencesLength;           //Length of the both sequences of bits
        uint maskFirstSequence;         //Mask for the first dequence of bits
        uint maskSecondSequence;        //Mask for the second dequence of bits
        byte currentBitFirstSequence;   //Value of current bit for the first dequence of bits
        byte currentBitSecondSequence;  //Value of current bit for the second dequence of bits
        byte lengthOfInputNumberInBinary;
        byte biggerStartBitOfSequence;  //This variables are used to check if the two sequences overlap
        byte lowerStartBitOfSequence;   //and if the sequence length is bigger than the length of the input number in binary system

        inputNumber = TryParseInputIntegerNumber("Please enter integer number to exchange the bits to.");

        //Using method "TryParseInputIntegerNumber(string textToDisplay)" to validate the number entered from the user.
        startBitOfFirstSequence = (byte)TryParseInputIntegerNumber("Please enter start bit(counting from 0) of the first sequence of bits you want to exchange.\nNote that the two sequences of bits must not overlap!");
        startBitOfSecondSequence = (byte)TryParseInputIntegerNumber("Please enter start bit(counting from 0) of the second sequence of bits you want to exchange.\nNote that the two sequences of bits must not overlap!");
        sequencesLength = (byte)TryParseInputIntegerNumber("Please enter length of the two sequences of bits.\nNote that sequences length must not be bigger than the count of bits of the number!");

        //Chechk which start bit of the sequences is bigger and which is lower
        if (startBitOfSecondSequence > startBitOfFirstSequence)
        {
            biggerStartBitOfSequence = startBitOfSecondSequence;
            lowerStartBitOfSequence = startBitOfFirstSequence;
        }
        else
        {
            biggerStartBitOfSequence = startBitOfFirstSequence;
            lowerStartBitOfSequence = startBitOfSecondSequence;
        }

        //Checks(validations) of the input data:

        // 1.Cycle to check if the two sequences overlap and if so, the program stops.
        for (int i = 1; i <= sequencesLength; i++, lowerStartBitOfSequence++)
        {
            if (biggerStartBitOfSequence == lowerStartBitOfSequence)
            {
                Console.WriteLine("{0}\nThe two sequences of bits must not overlap!!!", new string('-', 75));
                return;
            }
        }

        //Convert the input number in binary system and get its length
        lengthOfInputNumberInBinary = (byte)Convert.ToString(inputNumber, 2).Length;

        // 2.Check if the sum of the bigger starting bit and the sequence length is bigger than the length of the input number in binary system
        if ((biggerStartBitOfSequence + sequencesLength) >= lengthOfInputNumberInBinary)
        {
            Console.WriteLine("{0}\nThe sequence you entered goes higher than the length of the input number in binary system!!!", new string('-', 75));
            return;
        }

        //Printing the enterd data from the user
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(" Start bit of first sequence: {0}", startBitOfFirstSequence);
        Console.WriteLine("Start bit of second sequence: {0}", startBitOfSecondSequence);
        Console.WriteLine("     Length of the sequences: {0}", sequencesLength);

        //I want to keep input value, that's why I use variable "changingInputNumber"
        changingInputNumber = inputNumber;

        for (int i = 1; i <= sequencesLength; i++, startBitOfFirstSequence++, startBitOfSecondSequence++)
        {
            //Set the bit to the wanted position. This is used for bit 3, 4, 5.
            maskFirstSequence = bitValue << startBitOfFirstSequence;

            //Check the value of the current bit and assign it to variable. This is used for bit 3, 4, 5.
            if ((changingInputNumber & maskFirstSequence) == 0)
            {
                currentBitFirstSequence = 0;
            }
            else
            {
                currentBitFirstSequence = 1;
            }

            //Set the bit to the wanted position. This is used for bit 24, 25, 26.
            maskSecondSequence = bitValue << startBitOfSecondSequence;

            //Check the value of the current bit and assign it to variable. This is used for bit 3, 4, 5
            if ((changingInputNumber & maskSecondSequence) == 0)
            {
                currentBitSecondSequence = 0;
            }
            else
            {
                currentBitSecondSequence = 1;
            }

            //Check if the values of current bits(3-24, 4-25, 5-26) are not equal.
            if (currentBitFirstSequence != currentBitSecondSequence)
            {
                //Used operator "exclusive-OR" to set the current bit to the wanted value
                changingInputNumber = (changingInputNumber ^ maskFirstSequence);
                changingInputNumber = (changingInputNumber ^ maskSecondSequence);
            }
        }

        //Printing the original input number and the modified one in binary representation
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Number before switch operations: {0}", Convert.ToString(inputNumber, 2));
        Console.WriteLine("Number after switch operations : {0}", Convert.ToString(changingInputNumber, 2));
    }
}
