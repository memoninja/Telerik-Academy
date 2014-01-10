// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//     Use variable number of arguments.

using System;
using System.Linq;

class CalculateMinMaxAverageSumAndProduct
{
    static void Main()
    {
        //Using the corresponding method to find wanted number
        int minNumber = CalculateMinimumNumber(2, 4, 6, 8);
        int maxNumber = CalculateMaximumNumber(2, 4, 6, 8);
        int averageNumber = CalculateAverageNum(2, 4, 6, 8);
        int sum = CalculateSum(2, 4, 6, 8);
        long product = CalculateProduct(2, 4, 6, 8);

        Console.WriteLine("Minimum number: {0}", minNumber);
        Console.WriteLine("Maximum number: {0}", maxNumber);
        Console.WriteLine("Average number: {0}", averageNumber);
        Console.WriteLine("Sum of numbers: {0}", sum);
        Console.WriteLine("Product of numbers: {0}", product);
    }

    /// <summary>
    /// Calculate minimum number in array
    /// </summary>
    /// <param name="numbers">Numbers where to find the minimum number</param>
    /// <returns>Minimum number of the array</returns>
    private static int CalculateMinimumNumber(params int[] numbers)
    {
        //Simple way to find minimum element is:
        //Array.Sort(number);
        //int minNumber = numbers[0];
        //Or this:
        //numbers.Min(); - this needs you to add "using System.Linq;"
        
        int minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++) //Loop to iterate through the elements in the array
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        return minNumber;
    }

    /// <summary>
    /// Calculate maximum number in array
    /// </summary>
    /// <param name="numbers">Numbers where to find the maximum number</param>
    /// <returns>Maximum number of the array</returns>
    private static int CalculateMaximumNumber(params int[] numbers)
    {
        //Simple way to find maximum element is:
        //Array.Sort(number);
        //int maxNumber = numbers[number.Length - 1];
        //Or this:
        //numbers.Max(); - this needs you to add "using System.Linq;"
        
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++) //Loop to iterate through the elements in the array
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        return maxNumber;
    }

    /// <summary>
    /// Calculate the sum of numbers
    /// </summary>
    /// <param name="numbers">Numbers to sum</param>
    /// <returns>Sum of number in the array</returns>
    private static int CalculateSum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++) //Loop to iterate through the elements in the array
        {
            sum += numbers[i];
        }

        return sum;
    }

    /// <summary>
    /// Calculate the average number in the array
    /// </summary>
    /// <param name="numbers">Numbers to calculate the average number</param>
    /// <returns>Average number of the array</returns>
    private static int CalculateAverageNum(params int[] numbers)
    {
        int averageSum = CalculateSum(numbers);//Use method "CalculateSum(params int[] numbers)" and then divide by the count of the elements in the array

        averageSum /= numbers.Length;

        return averageSum;
    }

    /// <summary>
    /// Calculate the product of the numbers in the array
    /// </summary>
    /// <param name="numbers">Numbers to multiply</param>
    /// <returns>Product of numbers in the array</returns>
    private static long CalculateProduct(params int[] numbers)
    {
        long product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            //Check for overflow
            try
            {
                product *= numbers[i];
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
        }

        return product;
    }
}
