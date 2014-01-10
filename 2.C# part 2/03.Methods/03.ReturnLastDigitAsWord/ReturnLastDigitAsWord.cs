// 03. Write a method that returns the last digit of given integer as an English word.
//     Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

    class ReturnLastDigitAsWord
    {
        static void Main()
        {
            //Usign method "ValidateInputInteger(string textToPrint)" to validate the input integer
            int givenNumber = ValidateInputInteger("Please enter integer number: ");

            //Using method "GetLastDigit(int numberToPrint)" to take the last digit as word
            string lastDigit = GetLastDigit(givenNumber);

            Console.WriteLine(new string('=', 35));
            Console.WriteLine("{0} -> \"{1}\"", givenNumber, lastDigit);
        }

        //Method is private, because we do not want to be used anywhere else
        //Method to take the last digit as string
        private static string GetLastDigit(int numberToPrint) //Method have one parameter
        {
            int lastDigit;

            //If the given number is negative, will cause an error, so we make it positive
            if (numberToPrint < 0)
            {
                numberToPrint = -numberToPrint;
            }

            lastDigit = numberToPrint % 10;

            //return string corresponding to the given digit
            switch (lastDigit)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "Error";
            }
        }

        //Method is private, because we do not want to be used anywhere else
        //Check if input number is correct integer
        private static int ValidateInputInteger(string textToPrint) //Method have one parameter
        {
            int givenInteger;

            Console.Write(textToPrint);

            while (!int.TryParse(Console.ReadLine(), out givenInteger))
            {
                Console.Write("Please enter correct integer: ");
            }

            return givenInteger; //The method returns the input integer, after it is validated
        }
    }
