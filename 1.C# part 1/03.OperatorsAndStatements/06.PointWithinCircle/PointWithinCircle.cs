// 6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinCircle
{
    //This method is used to parse the double number entered from the user
    static double TryParseInputDoubleNumber(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(textToDisplay);

        //Trying to parse double until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct double number!!!\n{0}", new string('-', 40));
        }
        // inputNumber is being returned from the method
        return inputNumber;
    }
    
    static void Main()
    {
        double xCoordinate;
        double yCoordinate;
        double radius;
        double pointDistanceFromCenter;
        bool isPointInCircle;

        //Using method "TryParseInputDoubleNumber(string textToDisplay)" to validate the number entered from the user.
        radius = TryParseInputDoubleNumber("Please enter radius of the circle.");
        xCoordinate = TryParseInputDoubleNumber("Please enter point coordinates on axis X.");
        yCoordinate = TryParseInputDoubleNumber("Please enter point coordinates on axis Y.");
        
        //Calculating the distance from the point to the center, via Pythagorean theorem
        pointDistanceFromCenter = Math.Sqrt((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate));

        //Check if the distance from the point to the center is less than the radius
        isPointInCircle = pointDistanceFromCenter <= radius;

        Console.WriteLine("\nIs point with coordinates ({0} : {1}) within circle K(0, {2})? -> {3}", xCoordinate, yCoordinate, radius, isPointInCircle);
    }
}