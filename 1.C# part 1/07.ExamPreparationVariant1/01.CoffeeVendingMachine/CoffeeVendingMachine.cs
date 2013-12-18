using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        /*This program are made only to practice, so there are not enough comments!
          The programs are made just to score 100 points!
          No additional optimization were made!
          Sorry if the code is unreadable!!!
          Do not have time to make it readable!
         */

        // 100 Points

        int N1;
        int N2;
        int N3;
        int N4;
        int N5;
        double amountInMachine;
        double amountByDeveloper;
        double priceDrink;


        N1 = int.Parse(Console.ReadLine());
        N2 = int.Parse(Console.ReadLine());
        N3 = int.Parse(Console.ReadLine());
        N4 = int.Parse(Console.ReadLine());
        N5 = int.Parse(Console.ReadLine());
        amountByDeveloper = double.Parse(Console.ReadLine());
        priceDrink = double.Parse(Console.ReadLine());
        double change;

        amountInMachine = N1 * 0.05 + N2 * 0.10 + N3 * 0.20 + N4 * 0.50 + N5 * 1.00;

        if (priceDrink > amountByDeveloper)
        {

            Console.WriteLine("More {0:F2}", priceDrink - amountByDeveloper);
        }
        else
        {
            change = amountByDeveloper - priceDrink;

            if (amountInMachine >= change)
            {

                Console.WriteLine("Yes {0:F2}", amountInMachine - change);
            }
            else
            {

                Console.WriteLine("No {0:F2}", change - amountInMachine);
            }
        }
    }
}