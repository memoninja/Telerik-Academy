//4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class CheckThirdDigit
{
    static void Main()
    {
        int inputNumber;
        
        Console.WriteLine("Please enter an integer.");

        //Trying to parse integer until a correct number is entered
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Enter a correct integer!");
        }
        
        //The number is divided by 100 to find the third digit
        int numberToCheck = inputNumber / 100;

        //Divide the number by 10 to get the remainder. Math.Abs() is used because negative integer is possible to be entered from the user
        int thirdDigit = Math.Abs(numberToCheck % 10);
        
        //Check if third digit is 7
        bool isThirdDigit7 = (thirdDigit == 7);
       
        Console.WriteLine("{0}\nIs third digit 7? -> {1}", new string('-', 25), isThirdDigit7);
    }
}