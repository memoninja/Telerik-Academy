using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToFallRocks
{
    class Program
    {
        static string dwarf = "(0)";
        static int dwarfPosition;
        static int rocksPerRow = 0;
        static Random randomizer = new Random();
        static char[,] rocksCoord = new char[Console.WindowHeight, Console.WindowWidth];
        static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static Queue<StringBuilder> rocksCoords = new Queue<StringBuilder>(Console.WindowHeight - 1);
        static string currentRowOfRocks;
        static StringBuilder strBuild = new StringBuilder();

        static int num;
        static char ch;

        static void RandomizeRoksPerRow(int rocksPerRow)
        {
            strBuild.Clear();
            //Loop to assign values to array of rocks(chars) - only to one row
            for (int i = 0; i < rocksPerRow; i++)
            {
                //Use randomizer to set random rock at random position
                //rocksCoord[0, randomizer.Next(Console.WindowWidth)] = rocks[randomizer.Next(rocks.Length)];
                num = randomizer.Next(Console.WindowWidth - 1);
                ch = rocks[randomizer.Next(rocks.Length)];
                for (int j = 0; j < Console.WindowWidth - rocksPerRow - 1; j++)
                {
                    
                    if (j == num)
                    {
                        strBuild.Append(ch);
                    }
                    else
                    {
                        strBuild.Append(' ');
                    }
                }
            }
        }

        static void DrawFallingRocks()
        {
            //foreach (StringBuilder line in rocksCoords)
            //{
            //    Console.WriteLine(line);
            //}
        }



        static void Main(string[] args)
        {
            RandomizeRoksPerRow(2);

            DrawFallingRocks();


        }
    }
}
