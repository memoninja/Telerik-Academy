//3. Write an expression that calculates rectangle’s area by given width and height.

using System;

class CalculateRectangleArea
{
    //This method is used to parse the double number entered from the user
    static double TryParseInputDoubleNumber(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(textToDisplay);

        //Trying to parse double until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct double number!!!");
        }
        // inputNumber is being returned from the method
        return inputNumber;
    }
    
    static void Main()
    {
        double width;
        double height;
        double rectangleArea;

        Console.WriteLine("This program calculates rectangle’s area by given width and height.\n");

        //Using method "TryParseInputDoubleNumber(string textToDisplay)" to validate the number entered from the user.
        width = TryParseInputDoubleNumber("Please enter width.");
        height = TryParseInputDoubleNumber("Please enter height.");

        //Calculate the rectangle’s area
        rectangleArea = width * height;

        Console.WriteLine("{0}\nThe rectangle’s area is {1}", new string('-', 30), rectangleArea);
    }
}