using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            long sum = 0;
            int currentDigit = 0;
            uint counter = 0;


            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (text[i] >= 48 && text[i] <= 57)
                    {
                        currentDigit = text[i] - 48;
                    
                    sum += currentDigit;
                    counter++;
                    }
                    
                }
            }

            Console.WriteLine("{0} {1}", counter,sum);
        }
    }
}
