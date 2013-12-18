// 6. Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//	and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class Program
{
    //This method parse input data from the user to double
    private static double ParseDoubleNumber(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct double number!");
        }
        //This method return "inputNumber"
        return inputNumber;
    }

    static void Main()
    {
        double coeffA;
        double coeffB;
        double coeffC;
        double square1;
        double square2;
        double discriminant;

        Console.WriteLine("This program solves a quadratic equation.");

        //Using method "parseDoubleNumber(string textToDisplay)" to validate the input data
        coeffA = ParseDoubleNumber("Please enter coefficient A");
        coeffB = ParseDoubleNumber("Please enter coefficient B");
        coeffC = ParseDoubleNumber("Please enter coefficient C");

        //Calculate discriminant by the formula: D = b*b - 4ac
        discriminant = (coeffB * coeffB) - (4 * coeffA * coeffC);

        //Check if discriminant is lower than 0
        if (discriminant < 0)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The equation has no square. It is linear equation!");
        }
        //Check if discriminant equals 0
        else if (discriminant == 0)
        {
            //Calculate the square by the formula x=-b/(2*a)
            square1 = -coeffB / (2 * coeffA);

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The equation has one square : {0}", square1);
        }
        //If discriminant is greather than 0, the equation has two answers(squares)
        else
        {
            //Calculate the both squares of the equation
            square1 = (-coeffB + Math.Sqrt(discriminant)) / (2 * coeffA);
            square2 = (-coeffB - Math.Sqrt(discriminant)) / (2 * coeffA);

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Square 1 is : {0}", square1);
            Console.WriteLine("Square 2 is : {0}\n", square2);
        }
    }
}