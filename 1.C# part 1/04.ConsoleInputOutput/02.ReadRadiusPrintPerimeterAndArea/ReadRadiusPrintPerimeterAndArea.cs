// 2. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class ReadRadiusPrintPerimeterAndArea
{
    static void Main()
    {
        double inputRadius;
        double circleArea;
        double circlePerimeter;
        
        Console.WriteLine("Please enter radius of a circle.");

        //Try to parse integer until a correct number is entered by the user
        while (!double.TryParse(Console.ReadLine(), out inputRadius))
        {
            Console.WriteLine("Please enter correct number!");
        }

        //Calculate the area of the circle. Using Math.Pi instead of directly to put 3.14
        //The method Math.Pow() is slow so I directly multiply the radius on itself
        circleArea = Math.PI * inputRadius * inputRadius;
        //Claculate the perimeter of the circle.
        circlePerimeter = Math.PI * inputRadius * 2;

        Console.WriteLine("The area of the circle is: {0}", circleArea);
        Console.WriteLine("The perimeter of the circle is : {0}", circlePerimeter);


    }
}