// 8. Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleStringChoice
{
    static void Main()
    {
        byte userDataChoice;
        int intChoice;
        double doubleChoice;
        string stringChoice;

        Console.WriteLine("Please enter what type of data you want to enter!");
        Console.WriteLine("1 - int\n2 - double\n3 - string");

        while (true) //Loop to validate the input number
        {
            while (!byte.TryParse(Console.ReadLine(), out userDataChoice))
            {
                Console.WriteLine("Please enter 1, 2 or 3");
            }

            if (userDataChoice > 0 && userDataChoice < 4) //If a correct number is entered the loop is terminated
            {
                break;
            }

            Console.WriteLine("Please enter 1, 2 or 3");
        }

        switch (userDataChoice) //switch-case to modify the entered type of data
        {
            case 1:
                Console.WriteLine("Please enter integer number");

                intChoice = int.Parse(Console.ReadLine());

                Console.WriteLine(new string('=', 30));
                Console.WriteLine(intChoice + 1);
                break;
            case 2:
                Console.WriteLine("Please enter double number");

                doubleChoice = double.Parse(Console.ReadLine());

                Console.WriteLine(new string('=', 30));
                Console.WriteLine(doubleChoice + 1);
                break;
            case 3:
                Console.WriteLine("Please enter string");

                stringChoice = Console.ReadLine();

                Console.WriteLine(new string('=', 30));
                Console.WriteLine(string.Concat(stringChoice, '*'));
                break;
            default: Console.WriteLine("Not correct input data!"); break;
        }
    }
}