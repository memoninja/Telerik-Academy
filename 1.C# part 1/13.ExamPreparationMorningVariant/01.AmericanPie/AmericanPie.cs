using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AmericanPie
{
    class AmericanPie
    {
        static void Main()
        {
            // ??? Points ???

            int inputA = int.Parse(Console.ReadLine());
            int inputB = int.Parse(Console.ReadLine());
            int inputC = int.Parse(Console.ReadLine());
            int inputD = int.Parse(Console.ReadLine());

            int nominator;
            int denominator;

            decimal drob = 0M;

            nominator = (inputA * inputD) + (inputB * inputC);
            denominator = inputB * inputD;

            drob = (decimal)nominator / denominator;

            if (drob >= 1)
            {
                Console.WriteLine("{0}", nominator / denominator);
            }
            else
            {
                Console.WriteLine("{0:F20}", drob);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
