/*Task 14: A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
associated with the account. Declare the variables needed to keep the information for a 
single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccount
{
    //This method check if a name contains only letters!
    static string validateName(string messageToBePrinted)
    {
        while (true)
        {
            Console.WriteLine("{0}\n{1}", new string('-', 70), messageToBePrinted);
            string nameToValidate = Console.ReadLine();
            if (nameToValidate.Length < 1)
            {
                Console.WriteLine("This name is not correct! Note that only letters are allowed!\n{0}", new string('-', 60));
                continue;
            }

            //Lower all letters in the string
            string nameToLower = nameToValidate.ToLower();
           
            //Cycle to check if the entered string consist only of letters(a-z)
            for (int i = 0; i < nameToLower.Length; i++)
            {
                if (nameToLower[i] < 97 || nameToLower[i] > 122)
                {
                    Console.WriteLine("This name is not correct! Note that only letters are allowed!\n{0}", new string('-', 60));
                    break;
                }
                if (nameToLower.Length - 1 == i)
                {
                    return nameToValidate;
                }
            }
        }

    }

    //This method check if a string contains spaces
    static string checkIfContainSpace(string messageToBePrinted)
    {
        while (true)
        {
            Console.WriteLine("{0}\n{1}", new string('-', 70), messageToBePrinted);
            string checkedString = Console.ReadLine();
            
            //Check if any letters are entered
            if (checkedString.Length < 1)
            {
                Console.WriteLine("Please enter minimum 1 symbol!\n{0}", new string('-', 40));
                continue;
            }
            
            //Check if the string contains space
            if (checkedString.Contains(" "))
            {
                Console.WriteLine("Note that no spaces are allowed!\n{0}", new string('-', 40));
                continue;
            }
            
            return checkedString;
        }

    }

    //This method check if a string contains only digits
    static ulong validateCreditCardNumber(string messageToBePrinted)
    {
        ulong creditCardNumber;
        Console.WriteLine("{0}\n{1}", new string('-', 70), messageToBePrinted);
        
        //Tryibg to parse the enterd string
        while (!ulong.TryParse(Console.ReadLine(), out creditCardNumber))
        {
            Console.WriteLine("Please enter correct number! Note that only digits are allowed!\n{0}", new string('-', 64));
        }
        return creditCardNumber;
    }

    static void Main()
    {
        string firstName = "";
        string middleName = "";
        string lastName = "";
        decimal amountOfMoney = 0;
        string bankName = "";
        string iban = "";
        string bicCode = "";
        //ulong is used because it is easier and faster than string
        ulong creditCardNumber1 = 0;
        ulong creditCardNumber2 = 0;
        ulong creditCardNumber3 = 0;

        //Using method "validateName()" to validate that the entered name contains only letters
        firstName = validateName("Please enter first name.");
        middleName = validateName("Please enter middle name.");
        lastName = validateName("Please enter last name.");

        //Cycle for trying to parse entered amount of money
        Console.WriteLine("{0}\nPlease enter your amount of money.", new string('-', 70));
        while (!decimal.TryParse(Console.ReadLine(), out amountOfMoney))
        {
            Console.WriteLine("Please enter a correct digit.");
        }

        Console.WriteLine("{0}\nPlease enter your bank name.", new string('-', 70));
        //Assigning bank name directly from the console without validation
        bankName = Console.ReadLine();

        // Using method "checkIfContainSpace()" to ensure that there is no space in the entered string
        iban = checkIfContainSpace("Please enter IBAN");
        bicCode = checkIfContainSpace("Please enter BIC code");

        //Using method "validateCreditCardNumber()" to validate the entered credit card number
        creditCardNumber1 = validateCreditCardNumber("Please enter the number of the first credit card!");
        creditCardNumber2 = validateCreditCardNumber("Please enter the number of the second credit card!");
        creditCardNumber3 = validateCreditCardNumber("Please enter the number of the third credit card!");

        Console.WriteLine(new string('-', 70));
        Console.WriteLine("{0,30} {1,4} {2} {3}", "Holder full name :", firstName, middleName, lastName);
        Console.WriteLine("{0,30} {1,4}", "Amount of money is :", amountOfMoney);
        Console.WriteLine("{0,30} {1,4}", "Bank :", bankName);
        Console.WriteLine("{0,30} {1,4}", "IBAN :", iban);
        Console.WriteLine("{0,30} {1,4}", "BIC :", bicCode);
        Console.WriteLine("{0,30} {1,4}", "First credit card number :", creditCardNumber1);
        Console.WriteLine("{0,30} {1,4}", "Second credit card number :", creditCardNumber2);
        Console.WriteLine("{0,30} {1,4}", "Third credit card number :", creditCardNumber3);
    }
}