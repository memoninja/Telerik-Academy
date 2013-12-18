// 4. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class Program
{
    //This method validate the number entered by the user
    static int ValidateInputInteger(string textToDisplay)
    {
        int inputNumber;

        Console.Write(textToDisplay);

        while (true)
        {
            //Try to parse integer until a correct number is entered by the user
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter a correct integer!");
            }

            if (inputNumber > 1)
            {
                break;
            }
        }

        return inputNumber; //The method returns "inputNumber"
    }

    static void Main()
    {
        int nSequence;
        int kSequence;
        int answer = 1;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        nSequence = ValidateInputInteger("Please enter N! sequence: ");
        kSequence = ValidateInputInteger("Please enter K! sequence: ");

        Console.WriteLine(new string('=', 30));

        if (nSequence <= kSequence) //Check if 1<K<N, if not, program is terminated
        {
            Console.WriteLine("1 < K < N");
            return;
        }

        for (int i = kSequence + 1; i <= nSequence; i++) // Loop to calculate the answer
        {
            answer *= i;
        }

        Console.WriteLine("{0}! / {1}! = {2}", nSequence, kSequence, answer);

        //Another way to make the program, maybe more understandable!
        //-----------------------------------------------------------
        //int nFact = 1;
        //int kFact = 1;

        //for (int i = nSequence; i > 1; i--)
        //{
        //    nFact *= i;
        //}

        //for (int i = kSequence; i > 0; i--)
        //{
        //    kFact *= i;
        //}

        //Console.WriteLine(nFact / kFact);
    }
}