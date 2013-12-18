// 10. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class CardsFromDeck
{
    //Using "enumeration"
    //enum CardValues : byte { Ace, Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
    //enum CardSigns : byte { Clubs, Diamonds, Hearts, Spades };

    static void Main()
    {
        // First way to do the exercise, using enumeration
        //-----------------------------------------------------------------
        //foreach (string cardValue in Enum.GetNames(typeof(CardValues)))
        //{
        //    foreach (string cardSign in Enum.GetNames(typeof(CardSigns)))
        //    {
        //        Console.WriteLine("{0} - {1}", cardValue, cardSign);
        //    }

        //    Console.WriteLine(new string('-', 15));
        //}
        //-----------------------------------------------------------------


        //Second way to do the exercise
        //-----------------------------------------------------------------

        string[] cardValues = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] CardSigns = { "Clubs", "Diamonds", "Hearts", "Spades" };

        foreach (string cardValue in cardValues) //Print all strings in "cardValues"
        {
            foreach (string cardSign in CardSigns) //For every string in "cardValues" prints all strings in "CardSigns"
            {
                Console.WriteLine("{0} - {1}", cardValue, cardSign);
            }

            Console.WriteLine(new string('-', 15));
        }


    }
}