using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.KaspichaniaBoats
{
    class KaspichaniaBoats
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int width = number * 2 + 1;
            int height = ((number - 3) / 2) * 3 + 6;
           
            int sailsH = (2 * height) / 3;
            int baseBoat = (height * 1) / 3;

            int innerDotsCounter = 1;

            Console.Write(new string('.', number));
            Console.Write('*');
            Console.Write(new string('.', number));
            Console.WriteLine();
            Console.Write(new string('.', number - 1));
            Console.Write(new string('*', 3));
            Console.Write(new string('.', number - 1));
            Console.WriteLine();

            for (int i = 2; i < number; i++)
            {
                Console.Write(new string('.', number - i));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', number - i));
                Console.WriteLine();
                innerDotsCounter++;
            }

            Console.WriteLine(new string('*', width));

            for (int i = 1; i < baseBoat; i++)
            {
                innerDotsCounter--;
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', innerDotsCounter));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            Console.Write(new string('.', baseBoat));
            Console.Write(new string('*', number));
            Console.Write(new string('.', baseBoat));
        }
    }
}
