// 6.Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class BooleanIsFemale
{
    static void Main()
    {
        bool isFemale = true;
        string strGender;
        byte gender;

        Console.WriteLine("Please enter your gender.\n1 for male \n2 for female \n");
        strGender = Console.ReadLine();
        byte.TryParse(strGender, out gender);

        //Check if a correct number is entered
        if (gender != 1 && gender != 2)
        {
            Console.WriteLine("You have to enter \"1\" or \"2\"");
            return;
        }
        else if (gender == 1)
        {
            isFemale = false;
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Are you female? \u2192 {0}\n", isFemale); // \u2192 is "->" symbol in unicode
    }
}