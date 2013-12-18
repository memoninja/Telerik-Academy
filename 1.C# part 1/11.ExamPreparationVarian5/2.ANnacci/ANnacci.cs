using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ANnacci
{
    class ANnacci
    {
        static void Main(string[] args)
        {
            // 100 Points

            char firstSequenceChar = char.Parse(Console.ReadLine());
            char secondSequenceChar = char.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            char nextSequenceChar;

            Console.WriteLine(firstSequenceChar);

            if ((firstSequenceChar + secondSequenceChar - 128) < 27)
            {
                nextSequenceChar = (char)(firstSequenceChar + secondSequenceChar - 64);
            }
            else
            {
                nextSequenceChar = (char)((firstSequenceChar + secondSequenceChar - 128) % 26 + 64);
            }

            if (numberOfLines > 1)
            {
                Console.WriteLine("{0}{1}", secondSequenceChar, nextSequenceChar);
            }

            firstSequenceChar = secondSequenceChar;
            secondSequenceChar = nextSequenceChar;

            for (int i = 3; i <= numberOfLines; i++)
            {
                for (int m = 0; m < 2; m++)
                {
                    if ((firstSequenceChar + secondSequenceChar - 128) < 27)
                    {
                        nextSequenceChar = (char)(firstSequenceChar + secondSequenceChar - 64);
                    }
                    else
                    {
                        nextSequenceChar = (char)((firstSequenceChar + secondSequenceChar - 128) % 26 + 64);
                    }
                    firstSequenceChar = secondSequenceChar;
                    secondSequenceChar = nextSequenceChar;

                    Console.Write(nextSequenceChar);
                    if (m == 0)
                    {
                        Console.Write(new string(' ', i - 2));
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
