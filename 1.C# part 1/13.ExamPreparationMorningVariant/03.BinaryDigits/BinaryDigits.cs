using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BinaryDigits
{
    class BinaryDigits
    {
        static void Main(string[] args)
        {
            // ??? Points ???

            uint number = uint.Parse(Console.ReadLine());
            string binaryNum;

            string[] one = new string[4];
            string[] zero = new string[4];

            one[0] = ".#.";
            one[1] = "##.";
            one[2] = ".#.";
            one[3] = "###";

            zero[0] = "###";
            zero[1] = "#.#";
            zero[2] = "#.#";
            zero[3] = "###";

            binaryNum = Convert.ToString(number, 2).PadLeft(32, '0');

            for (int m = 0; m < 4; m++)
            {
                for (int i = 16; i < binaryNum.Length; i++)
                {
                    if (binaryNum[i].Equals('0'))
                    {
                        Console.Write(zero[m]);
                    }
                    else
                    {
                        Console.Write(one[m]);
                    }

                    if (i < binaryNum.Length - 1)
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
