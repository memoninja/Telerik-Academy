// 3. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
// age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyAndManagerInfo
{
    //This method parse input data from the user to ulong
    private static ulong parseUlongNumber(string textToDisplay)
    {
        ulong inputNumber;

        Console.WriteLine(new string('-', 50));
        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct number is entered
        while (!ulong.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        //This method return "inputNumber"
        return inputNumber;
    }

    //This method validate the input string from the user
    private static string validateInputString(string textToDisplay)
    {
        string inputString;
        char spaceSymbol = ' ';

        Console.WriteLine(new string('-', 50));
        Console.WriteLine(textToDisplay);

        //Endless cycle for validation of the input string
        while (true)
        {
            inputString = Console.ReadLine();

            //Check if the string length is bigger than 2 characters and if the first and second character is "space"
            if (inputString.Length >= 2 && inputString[0] != spaceSymbol && inputString[1] != spaceSymbol)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter correct name!");
            }
        }
        //This method returns the string "inputString"
        return inputString;
    }



    static void Main()
    {
        string companyName;
        string companyAdress;
        ulong companyPhoneNumber;
        ulong companyFaxNumber;
        string companyWebSite;
        string managerFirstName;
        string managerLastName;
        byte managerAge;
        ulong managerPhoneNumber;

        //Company info
        //Using method "validateInputString(string textToDisplay)" to validate the input data
        companyName = validateInputString("Please enter company name.\nNote that first two characters must not be \"space\"");
        companyAdress = validateInputString("Please enter company adress.\nNote that first two characters must not be \"space\"");
        //Using method "parseUlongNumber(string textToDisplay)" to parse the input string from the user to a ulong variable
        companyPhoneNumber = parseUlongNumber("Please enter company phone number.");
        companyFaxNumber = parseUlongNumber("Please enter company fax number.");

        //Cycle for validation of a web site
        while (true)
        {
            //Using method "validateInputString(string textToDisplay)" check if the first two symbols are "space"
            companyWebSite = validateInputString("Please enter company web site.\nNote that first two characters must not be \"space\"");

            //Check if the string contains "."
            if (companyWebSite.Contains("."))
            {
                //Check if "." is not the first character of the string and check if after "." are less than 2 symbols
                if ((companyWebSite.IndexOf('.', 0) > 0) && ((companyWebSite.Length - 2) > companyWebSite.IndexOf('.', 0)))
                {
                    //break the cycle if the upper conditions are "True"
                    break;
                }
            }
            Console.WriteLine("You did Not enter a correct web site!!!");
        }

        //Manager info
        //Using method "validateInputString(string textToDisplay)" to validate the input data
        managerFirstName = validateInputString("Please enter manager's first name.\nNote that first two characters must not be \"space\"");
        managerLastName = validateInputString("Please enter manager's last name.\nNote that first two characters must not be \"space\"");

        Console.WriteLine("{0}\nPlease enter manger's age", new string('-', 50));
        //Cycle for validation of manger's age
        while (true)
        {
            //Cycle is trying to parse manger's age until a correct number(byte) is entered
            while (!byte.TryParse(Console.ReadLine(), out managerAge))
            {
                Console.WriteLine("Please enter correct age");
            }

            //Check if the entered age is over 18 and less than 85
            if (managerAge > 18 && managerAge < 85)
            {
                //break the cycle if the upper conditions are "True"
                break;
            }
            else
            {
                Console.WriteLine("Manager must be over 20 years and less than 85!");
            }
        }

        //Using method "parseUlongNumber(string textToDisplay)" to parse the input string from the user to a ulong variable
        managerPhoneNumber = parseUlongNumber("Please enter manager phone number.");

        Console.WriteLine(new string('=', 50));

        //Company info
        Console.WriteLine("{0,25} : {1}", "Company name", companyName);
        Console.WriteLine("{0,25} : {1}", "Company adress", companyAdress);
        Console.WriteLine("{0,25} : {1}", "Company phone number", companyPhoneNumber);
        Console.WriteLine("{0,25} : {1}", "Company fax number", companyFaxNumber);
        Console.WriteLine("{0,25} : {1}", "Company web site", companyWebSite);

        //Manager info
        Console.WriteLine("{0,25} : {1}", "Manager first name", managerFirstName);
        Console.WriteLine("{0,25} : {1}", "Manager last name", managerLastName);
        Console.WriteLine("{0,25} : {1}", "Manager age", managerAge);
        Console.WriteLine("{0,25} : {1}", "Manager phone number", managerPhoneNumber);

    }
}