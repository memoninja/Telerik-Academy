// 9. Write an expression that checks for given point (x, y) if it is  
// within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleOutRectangle
{
    //This method validate the entered double number from the user
    static double ValidateEnteredDoubleNumber(string textToDisplay)
    {
        double inputDoubleNumber;

        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct double number is entered
        while (!double.TryParse(Console.ReadLine(), out inputDoubleNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        // inputDoubleNumber is being returned from the method
        return inputDoubleNumber;
    }

    static void Main()
    {
        double xCoordinate;
        double yCoordinate;
        double currentXCoordinate;
        double currentYCoordinate;
        double radius = 3;
        double pointDistanceFromCenter;
        bool isPointInCircle;
        bool isPointInRectangle = true;

        //Using method "ValidateEnteredDoubleNumber(string textToDisplay)" to validate the entered number from the user
        xCoordinate = ValidateEnteredDoubleNumber("Please enter point coordinates on axis X.");
        yCoordinate = ValidateEnteredDoubleNumber("Please enter point coordinates on axis Y.");
        
        // Subtract -1, because the center of the circle is moved with +1 on both axis.
        // Assign the result to new variables, only for the circle validation.
        currentXCoordinate = xCoordinate - 1;
        currentYCoordinate = yCoordinate - 1;

        //Calculating the distance from the point to the center, via Pythagorean theorem
        pointDistanceFromCenter = Math.Sqrt((currentXCoordinate * currentXCoordinate) + (currentYCoordinate * currentYCoordinate));

        //Check if the distance from the point to the center is less than the radius
        isPointInCircle = pointDistanceFromCenter <= radius;

        //Check if point is within the rectangle.
        //If one of the coordinates is bigger(or lower) than the corresponding rectangle's coordinate, this point is out of the rectangle.
        if (xCoordinate < -1 || yCoordinate < -1 || xCoordinate > 5 || yCoordinate > 1)
        {
            isPointInRectangle = false;
        }

        Console.WriteLine(new string('-', 70));
        Console.WriteLine("Is point with coordinates ({0} : {1}) within circle K((1,1), 3)? -> {2}\n", xCoordinate, yCoordinate, isPointInCircle);
        Console.WriteLine("Is point with coordinates ({0} : {1}) within rectangle -> {2}\n", xCoordinate, yCoordinate, isPointInRectangle);

        //Chech if the point is within the circle and out of the rectangle in the same time
        if (isPointInCircle && !isPointInRectangle)
        {
            Console.WriteLine("Is the point within the circle and out of the rectangle! -> YES\n");
        }
        else
        {
            Console.WriteLine("Is the point within the circle and out of the rectangle! -> NO\n");
        }

    }
}