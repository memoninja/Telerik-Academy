using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ApplesOrOrangesOrBoth
{
    class ApplesOrOrangesOrBoth
    {
        static void Main(string[] args)
        {
            // ??? Points ???

            long N = long.Parse(Console.ReadLine());
            long ost;
            long currentN = N;
            long oddSum = 0;
            long evenSum = 0;

            for (int i = 0; i < N.ToString().Length; i++)
            {
                ost = currentN % 10;
                currentN /= 10;

                if (ost % 2 == 0)
                {
                    evenSum += ost;
                }
                else
                {
                    oddSum += ost;
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("apples {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("oranges {0}", oddSum);
            }
            else
            {
                Console.WriteLine("both {0}", evenSum);
            }
            
        }
    }
}
