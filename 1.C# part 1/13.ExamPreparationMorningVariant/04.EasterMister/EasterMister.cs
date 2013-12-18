using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EasterMister
{
    class EasterMister
    {
        static void Main(string[] args)
        {
            // ??? Points ???

            int numberN = int.Parse(Console.ReadLine());
            int innerDotsCounter = numberN + 1;
            int countInnerDots = (numberN * 3 + 1) - 4;

            Console.Write(new string('.', numberN + 1)); // Top of egg
            Console.Write(new string('*', numberN - 1));
            Console.Write(new string('.', numberN + 1));
            Console.WriteLine();

            for (int i = numberN - 1; i >= 3; i -= 2) // diagonals
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine();
                innerDotsCounter += 4;
            }

            for (int i = 0; i < (numberN - 2) / 2; i++)
            {
                Console.Write(".*");
                Console.Write(new string('.', countInnerDots));
                Console.Write("*.");
                Console.WriteLine();
            }

            Console.Write(".*");
            for (int i = 1; i <= countInnerDots; i++) // middle
            {
                if (i % 2 != 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }
            }
            Console.Write("*.");
            Console.WriteLine();

            Console.Write(".*");
            for (int i = 1; i <= countInnerDots; i++) // middle
            {
                if (i % 2 != 0)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.Write("*.");
            Console.WriteLine();

            for (int i = 0; i < (numberN - 2) / 2; i++)
            {
                Console.Write(".*");
                Console.Write(new string('.', countInnerDots));
                Console.Write("*.");
                Console.WriteLine();
            }

            for (int i = 3; i < numberN + 1; i += 2) // diagonals
            {
                innerDotsCounter -= 4;
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            Console.Write(new string('.', numberN + 1)); // Bottom of egg
            Console.Write(new string('*', numberN - 1));
            Console.Write(new string('.', numberN + 1));
        }
    }
}
