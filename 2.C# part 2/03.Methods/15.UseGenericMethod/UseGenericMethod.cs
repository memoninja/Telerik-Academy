// 15. * Modify your last program and try to make it work for any number type, not just integer
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;

class UseGenericMethod
{

    static void Main()
    {
        dynamic minNumber;
        dynamic maxNumber;
        dynamic averageNumber;
        dynamic sumOfNumbers;
        dynamic productOfNumbers;
        
        int _int = 134534;
        short _short = 9;
        float _float = 1.3F;
        double _double = 2.0;
        long _long = 123223L;

        decimal dec1 = 134534M;
        decimal dec2 = 9M;
        decimal dec3 = 1.3M;
        decimal dec4 = 2.0M;
        decimal dec5 = 123223M;
        decimal dec6 = 122.9M;
        decimal dec7 = 19M;
        decimal dec8 = 83M;

        //You can specify the variable type in angle brackets "<variable type>".
        //If you try to put "decimal" type along with other types, mwthod will not work, "decimal" can not be converted like other number types
        //You can use decimal, only if all variables are "decimal"
        minNumber = FindMinimumNumber<double>(_int, _short, _float, _double, _long, 122.9, 19, 83);
        maxNumber = FindMaximumNumber<decimal>(dec1, dec2, dec3, dec4, dec5, dec6, dec7, dec8);

        //If you want, you can not specify the variable type explicitly in angle brackets
        averageNumber = CalculateAverageNum(_int, _short, _float, _double, _long, 122.9, 19, 83);
        sumOfNumbers = CalculateSum(dec1, dec2, dec3, dec4, dec5, dec6, dec7, dec8);

        //You can put directly numbers
        productOfNumbers = CalculateProduct(11, 69, 1, 2.3, 13, 122.9, 19, 83);

        Console.WriteLine("Minimum number: {0}".PadLeft(25), minNumber);
        Console.WriteLine("Maximum number: {0}".PadLeft(25), maxNumber);
        Console.WriteLine("Average number: {0}".PadLeft(25), averageNumber);
        Console.WriteLine("Sum of numbers: {0}".PadLeft(25), sumOfNumbers);
        Console.WriteLine("Product of numbers: {0}".PadLeft(25), sumOfNumbers);
    }

    /// <summary>
    /// Find the minimum number in an array
    /// </summary>
    /// <typeparam name="T">Can be different type of variable(byte, int, float, double...)</typeparam>
    /// <param name="numbers">Numbers to search in</param>
    /// <returns>Correspondint type of variable</returns>
    private static T FindMinimumNumber<T>(params T[] numbers)
    {
        return numbers.Min();
    }

    /// <summary>
    /// Find the maximum number in an array
    /// </summary>
    /// <typeparam name="T">Can be different type of variable(byte, int, float, double...)</typeparam>
    /// <param name="numbers">Numbers to search in</param>
    /// <returns>Correspondint type of variable</returns>
    private static T FindMaximumNumber<T>(params T[] numbers)
    {
        return numbers.Max();
    }

    /// <summary>
    /// Calculate the sum of given numbers
    /// </summary>
    /// <typeparam name="T">Can be different type of variable(byte, int, float, double...)</typeparam>
    /// <param name="numbers">Numbers to sum</param>
    /// <returns>Correspondint type of variable</returns>
    private static T CalculateSum<T>(params T[] numbers)
    {
        dynamic sum = 0; //Use type of variable "dynamic". It is handled during execution

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    /// <summary>
    /// Calculate the average numbers
    /// </summary>
    /// <typeparam name="T">Can be different type of variable(byte, int, float, double...)</typeparam>
    /// <param name="numbers">Numbers to calculate</param>
    /// <returns>Correspondint type of variable</returns>
    private static T CalculateAverageNum<T>(params T[] numbers)
    {
        dynamic averageSum = 0; //Use type of variable "dynamic". It is handled during execution

        for (int i = 0; i < numbers.Length; i++)
        {
            averageSum += numbers[i];
        }

        averageSum /= numbers.Length; //Divide the sum to the count of the elements, to get average number

        return averageSum;
    }

    /// <summary>
    /// Calculate product of given numbers
    /// </summary>
    /// <typeparam name="T"Can be different type of variable(byte, int, float, double...)></typeparam>
    /// <param name="numbers">Numbers to multiply</param>
    /// <returns>Correspondint type of variable</returns>
    private static T CalculateProduct<T>(params T[] numbers)
    {
        dynamic product = 1; //Use type of variable "dynamic". It is handled during execution

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
}
