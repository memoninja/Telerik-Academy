/** 
 * Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right 
 * (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
 * Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows;

class FallingRocks
{
    static void Main()
    {
        string dwarf = "(0)";
        //int coordX;
        //int coordY;
        //Console.WindowHeight = 45;
        //Console.WindowWidth = 80;
        ////Console.CursorSize = 1;
        //Console.CursorVisible = true;
        ////Console.SetCursorPosition(14, 20);
        //Console.SetCursorPosition(Console., coordY);

        //Console.WriteLine("Hello");

        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;

        //int x = Console.CursorLeft;
        //int y = Console.CursorTop;
        //Console.CursorTop = Console.WindowTop + Console.WindowHeight - 1;

        //ConsoleKeyInfo pressedKey;

        //while (true)
        //{

        //    pressedKey = Console.ReadKey();

        //    if (pressedKey.Key.Equals(ConsoleKey.RightArrow))
        //    {
        //        Console.Clear();
        //        x++;
        //        Console.CursorLeft = x;
        //        Console.CursorTop = Console.WindowHeight - 1;
        //        //Console.Write(new string(((char)32), Console.WindowWidth));
                
        //        Console.Write(dwarf);

        //    }
        //    else if (pressedKey.Key.Equals(ConsoleKey.LeftArrow))
        //    {
        //        Console.Clear();
        //        x--;
        //        Console.CursorLeft = x;
        //        Console.CursorTop = Console.WindowHeight - 1;
        //        //Console.Write(new string(((char)32), Console.WindowWidth));
        //        Console.Write(dwarf);

        //    }
        //    else
        //    {
        //        continue;
        //    }

        //}

        int[][] rocksCoord;
        byte rowCounter = 0;
        char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';'};

        Random randRockSymbol = new Random(10);
        Random randCursorPosition = new Random(Console.BufferWidth);

        //while (true)
        //{
        //    Console.SetCursorPosition(randCursorPosition.Next(Console.BufferWidth), 0);
        //    //Console.CursorLeft = randCursor.Next(Console.BufferWidth);
        //    Console.WriteLine(rocks[randRockSymbol.Next(11)]);
        //    //Thread.Sleep(150);
        //    rowCounter++;
        //}
        //string r = new string((char)32, Console.BufferWidth);
        StringBuilder sb = new StringBuilder((char)32, Console.BufferWidth);
        sb.Insert(3, "a");
        //Console.KeyAvailable
        Console.WriteLine(sb);
        //Console.WriteLine(r);
        
        while (true)
        {
            if (Console.KeyAvailable)
            {
                Console.WriteLine("KeyAvailable");
                Console.ReadKey(false);
            }
        }

    }
}