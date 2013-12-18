// 10. A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
// first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables 
// needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender; //M - Male; F - Female
        ulong IDNumber;
        uint employeeNumber;

        Console.WriteLine("Please enter your first name.");
        firstName = Console.ReadLine();
        Console.WriteLine("{0}\nPlease enter your family name.", new string('-', 30));
        familyName = Console.ReadLine();

        //Trying to parse until a correct age is entered
        Console.WriteLine("{0}\nPlease enter your age", new string('-', 30));
        while (!byte.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("You did not entered a correct age!\nPlease try again!");
        }

        //Cycle for entering a correct gender
        while (true)
        {
            Console.WriteLine("{0}\nPlease enter your gender.\n\"M\" for male\n\"F\" for female", new string('-', 30));
            ConsoleKeyInfo genderKey = Console.ReadKey();
            if (genderKey.Key == ConsoleKey.M || genderKey.Key == ConsoleKey.F)
            {
                gender = genderKey.KeyChar;
                break;
            }
            Console.WriteLine("\nPlease enter \"M\" or \"F\"");
        }

        //Trying to parse until a correct ID is entered
        Console.WriteLine("\n{0}\nPlease enter your ID number", new string('-', 30));
        while (!ulong.TryParse(Console.ReadLine(), out IDNumber))
        {
            Console.WriteLine("You did not entered a correct ID number!\nPlease try again!");
        }

        //Trying to parse until a correct unique number is entered
        Console.WriteLine("{0}\nPlease enter your unique number!", new string('-', 30));
        while (!uint.TryParse(Console.ReadLine(), out employeeNumber) || true)
        {
            if (employeeNumber >= 27560000 && employeeNumber <= 27569999)
            {
                break;
            }
            Console.WriteLine("Please enter a correct unique number!");
        }
        
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Your name is: {0} {1}", firstName, familyName);
        Console.WriteLine("Your gender is: {0}", char.ToUpper(gender));
        Console.WriteLine("Your ID number is: {0}", IDNumber);
        Console.WriteLine("Your employee number is: {0}", employeeNumber);
    }
}