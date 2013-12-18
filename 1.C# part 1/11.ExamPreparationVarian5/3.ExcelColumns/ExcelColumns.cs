using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExcelColumns
{
    class ExcelColumns
    {
        static void Main(string[] args)
        {
            // 100 Points

            int linesCount = int.Parse(Console.ReadLine());
            char[] charArray = new char[linesCount];

            for (int i = linesCount - 1; i >= 0; i--)
            {
                charArray[i] = char.Parse(Console.ReadLine());
            }

            ulong number = 1U;

            if (linesCount == 1)
            {
                Console.WriteLine((ulong)charArray[0] - 64);
                return;
            }

            for (ulong i = 0; i < (ulong)charArray.Length; i++)
            {
                ulong power = 1;

                if (i > 0)
                {
                    for (ulong m = i; m > 0; m--)
                    {
                        power *= 26;
                    }
                    number += (((ulong)charArray[i] - 64) * power);
                }

            }
            
            Console.WriteLine(number + ((ulong)charArray[0] - 64 - 1));

        }
    }
}
