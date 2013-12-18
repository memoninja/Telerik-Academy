using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            // 100 Points

            int inputK = int.Parse(Console.ReadLine());
            char[] digitsArray = inputK.ToString().ToCharArray();

            for (int i = digitsArray.Length - 1; i >= 0; i--)
            {
                if (digitsArray[i] != '6')
                {
                    digitsArray[i] = (char)(digitsArray[i] + 1);
                    break;
                }
                else
                {
                    digitsArray[i] = '0';
                }
            }


            if (digitsArray[0] == '0')
            {
                Console.WriteLine("1{0}", new string(digitsArray));
            }
            else
            {
                Console.WriteLine(new string(digitsArray));
            }
        }
    }
}
