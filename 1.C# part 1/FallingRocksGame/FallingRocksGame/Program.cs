using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocksGame
{
    class Program
    {
        static string dwarf = "(0)";
        static int dwarfPosition;
        static int rocksPerRow;
        static Random randomizer = new Random();
        static char[,] rocksCoord = new char[Console.WindowHeight, Console.WindowWidth];
        static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static Queue<StringBuilder> rocksCoords = new Queue<StringBuilder>(Console.WindowHeight - 1);
        static StringBuilder strBuild;


        static void DrawDwarfInitialPosition()
        {
            dwarfPosition = (Console.WindowWidth - dwarf.Length) / 2;
            Console.SetCursorPosition(dwarfPosition, Console.WindowHeight - 1);
            Console.Write(dwarf);
        }

        static void DrawDwarf()
        {
            Console.SetCursorPosition(dwarfPosition, Console.WindowHeight - 1);
            Console.Write(dwarf);
        }

        static void MoveDwarfLeft()
        {
            if (dwarfPosition > 0)
            {
                dwarfPosition--;
            }
        }

        static void MoveDwarfRight()
        {
            if (dwarfPosition < Console.WindowWidth - dwarf.Length - 1)
            {
                dwarfPosition++;
            }
        }

        static void RandomizeRoksPerRow(int rocksPerRow)
        {
            strBuild.Clear();
            //Loop to assign values to array of rocks(chars) - only to one row
            for (int i = 0; i < rocksPerRow; i++)
            {
                //Use randomizer to set random rock at random position
                //rocksCoord[0, randomizer.Next(Console.WindowWidth)] = rocks[randomizer.Next(rocks.Length)];

                strBuild.Insert(randomizer.Next(Console.WindowWidth), rocks[randomizer.Next(rocks.Length)]);
            }
            rocksCoords.Enqueue(strBuild);
        }

        static void DrawFallingRocks()
        {
            foreach (StringBuilder line in rocksCoords)
            {
                Console.WriteLine(line);
            }
        }



        static void Main()
        {
            Console.Title = "Falling Rocks";
            Console.WindowWidth = 50;
            Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;


            Console.CursorVisible = false;

            DrawDwarfInitialPosition();

            // Loop for falling rocks
            while (true)
            {
                // Moving dwarf
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key.Equals(ConsoleKey.LeftArrow))
                    {
                        MoveDwarfLeft();
                    }
                    else if (pressedKey.Key.Equals(ConsoleKey.RightArrow))
                    {
                        MoveDwarfRight();
                    }
                }

                RandomizeRoksPerRow(2);

                //Loop to move the chars one row down
                for (int i = Console.WindowHeight - 1; i > 0; i--)
                {
                    for (int j = Console.WindowWidth - 1; j > 0; j--)
                    {
                        rocksCoord[i, j] = rocksCoord[i - 1, j];

                        //If i == 1 clear first row
                        //&& rocksCoord[0, j] != (char)32
                        if (i == 1)
                        {
                            rocksCoord[0, j] = (char)32;
                        }
                    }
                }

                

                //Loop to display the assigned rocks to the char array, top down
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    for (int j = 0; j < Console.WindowWidth - 1; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(rocksCoord[i, (char)j]);
                    }
                }

                
                DrawDwarf();
                Thread.Sleep(150);
                Console.Clear();
            }
        }
    }
}
