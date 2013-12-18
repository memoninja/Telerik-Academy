// 12. Write a program that creates an array containing all letters from the alphabet (A-Z).
//     Read a word from the console and print the index of each of its letters in the array.

using System;

class LettersIndexFromAlphabet
{

    static void Main(string[] args)
    {
        char[] alphabet = new char[26];
        string alphabetToString;
        string givenWord = ValidateInputString(); // Using method "ValidateInputString()"
        int currentIndexOfAlphabet;

        //Main logic of the exercise

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65); // Assign the letter of the alphabet to the char array, using the ASCII table
        }

        alphabetToString = new string(alphabet); //Using "new string()" to convert the char array into a string, and assign it to a new variable

        Console.WriteLine(new string('=', 40)); // This is just for better visual output

        for (int i = 0; i < givenWord.Length; i++) // loop to print the indices
        {
            //Using "IndexOf()" to get the index of the current letter of the word, from the alphabet
            currentIndexOfAlphabet = alphabetToString.IndexOf(givenWord[i]);
            Console.Write(currentIndexOfAlphabet);

            if (i < givenWord.Length - 1)
            {
                Console.Write(", "); // Check if the current letter is not the last of the word, and put comma and space
            }
        }
        Console.WriteLine();
    }

    //======================================================================================
    //Method to validate the input word. Only letters are allowed (A-Z, a-z)
    static string ValidateInputString()
    {
        string givenWord;

        Console.WriteLine("Please enter word to be checked!");

        while (true)
        {
            bool isCorrect = true; //Using this variable as a flag, if the word is not correct

            givenWord = Console.ReadLine();
            givenWord = givenWord.ToUpper(); //Set all letters to upper. It easier to work if there are only one type of letters

            for (int i = 0; i < givenWord.Length; i++)
            {
                if (givenWord[i] < 65 || givenWord[i] > 90) //If some of the symbols is not a letter, the loop goes again
                {
                    isCorrect = false;
                    break; // break, because if some of the symbols is not a letter there is no need to check the others. Thw whole word is invalid
                }
            }

            if (isCorrect)
            {
                return givenWord; //If word is valid, it is returned
            }
            else
            {
                Console.WriteLine("Only letters ara allowed!!!");
            }
        }
    }
}