using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {

            string formula = "(1+9)%6-(7%2)*8";
            int sum = 0;
            int i = 0;
            bool isInBrackets = false;
            bool isOutBrackets = true;


            while (i < formula.Length - 1)
            {

                if (formula[i] == '+')
                {
                    if (formula[i + 1] != '(' && formula[i + 1] != ')' && formula[i - 1] != '(' && formula[i - 1] != ')')
                    {
                        sum += (formula[i - 1] - 48) + (formula[i + 1] - 48);
                    }

                }
                if (formula[i] == '-')
                {
                    if (formula[i + 1] != '(' && formula[i + 1] != ')' && formula[i - 1] != '(' && formula[i - 1] != ')')
                    {
                        sum += (formula[i - 1] - 48) - (formula[i + 1] - 48);
                    }
                }


                Console.WriteLine(sum);
                //sum += (formula[i] - 48);



                i++;
            }



        }
    }
}
