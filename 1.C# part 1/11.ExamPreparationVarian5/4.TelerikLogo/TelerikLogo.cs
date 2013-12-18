using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            // 100 Points

            int inputX = int.Parse(Console.ReadLine());
            int middleDots = 1;
            int middleDotsCounter;
            int innerDotsCounter = 1;
            int width;

            for (int i = 1; i < inputX - 1; i++)
            {
                middleDots += 2;
            }

            middleDotsCounter = middleDots;

            Console.Write(new string('.', inputX / 2));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.Write(new string('.', inputX / 2));
            Console.WriteLine();

            middleDotsCounter -= 2;

            for (int i = 1; i < inputX - 1; i++)
            {
                if (middleDotsCounter < 0)
                {
                    break;
                }

                if (inputX / 2 - i >= 0)
                {
                    Console.Write(new string('.', inputX / 2 - i));
                    Console.Write('*');
                }
                
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', middleDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));

                if (inputX / 2 - i >= 0)
                {
                    Console.Write('*');
                    Console.Write(new string('.', inputX / 2 - i));
                }
                
                Console.WriteLine();

                middleDotsCounter -= 2;

                if (innerDotsCounter >= inputX)
                {
                    innerDotsCounter += 1;
                }
                else
                {
                    innerDotsCounter += 2;
                }
            }

            Console.Write(new string('.', (inputX + middleDots) / 2));
            Console.Write('*');
            Console.Write(new string('.', (inputX + middleDots) / 2));
            Console.WriteLine();

            width = ((inputX + middleDots) / 2) - 1;
            innerDotsCounter = 1;

            for (int i = 1; i <= inputX - 1; i++)
            {
                Console.Write(new string('.', width));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', width));
                Console.WriteLine();
                
                width -= 1;
                innerDotsCounter += 2;
            }

            width += 1;
            innerDotsCounter -= 2;

            for (int i = 1; i < inputX - 1; i++)
            {
                width += 1;
                innerDotsCounter -= 2;

                Console.Write(new string('.', width));
                Console.Write('*');
                if (innerDotsCounter > 0)
                {
                    Console.Write(new string('.', innerDotsCounter));
                }
                
                Console.Write('*');
                Console.Write(new string('.', width));
                Console.WriteLine();
            }

            Console.Write(new string('.', (inputX + middleDots) / 2));
            Console.Write('*');
            Console.Write(new string('.', (inputX + middleDots) / 2));
        }
    }
}
