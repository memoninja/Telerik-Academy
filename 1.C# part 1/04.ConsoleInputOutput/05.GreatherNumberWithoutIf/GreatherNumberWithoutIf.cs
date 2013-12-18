// 5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreatherNumberWithoutIf
{
    //This method parse input data from the user to double
    private static double parseDoubleNumber(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(new string('-', 30));
        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        //This method return "inputNumber"
        return inputNumber;
    }
    
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        bool isGreather;

        //Using method "parseDoubleNumber(string textToDisplay)" to validate the input data
        firstNumber = parseDoubleNumber("Please enter first number.");
        secondNumber = parseDoubleNumber("Please enter second number.");

        //Check if first number is greather than second number
        isGreather = firstNumber > secondNumber;
        
        //Using cycle instead of "if" statement
        while (isGreather)
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Greather number is: {0}\n", firstNumber);
            
            return; //Stop the program
        }

        //Check if second number is greather than first number
        isGreather = secondNumber > firstNumber;
        
        //Using cycle instead of "if" statement
        while (isGreather)
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Greather number is: {0}\n", secondNumber);

            return; //Stop the program
        }

        Console.WriteLine("{0}\nThe numbers are equal!\n", new string('=', 30));
    }
}