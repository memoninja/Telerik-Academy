using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3.Enigmanation
{
    class Enigmanation
    {
        static int Evaluate(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(int), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (int)(loDataTable.Rows[0]["Eval"]);
        }


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char[input.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = input[i];
            }
            
            //char digit1;
            //char digit2;
            //char oper;
            string str = new string(array);
            //string input = "1+9%6";
            //array = input.Split('(', ')');
            int sum = Evaluate(str);

            Console.WriteLine("{0:F3}",sum);
            
            

            //int sum = Evaluate(input);
            //Console.WriteLine(sum);
            //char[] signs = { '(', ')', '+', '-', '*', '%' };
            //int currentIndex1 = 0;
            //int currentIndex2 = 0;
            //int currentSum = 0;
            //int sumInBrackets;
            //char lastSymbol;
            //int bracket1;
            //int bracket2;

            //currentIndex1 = input.IndexOf('(', currentIndex2);
            //currentIndex2 = input.IndexOf(')', currentIndex2);
            ////Console.WriteLine(input.IndexOf(')', 0));
            //string str = new string(input[input.IndexOf('(', 0) + 1], input[input.IndexOf(')', 0) - 1]);
            //Console.WriteLine(str);
            //currentSum = Evaluate(str);
            //Console.WriteLine(currentSum);

            //while (true)
            //{
            //    if (currentIndex + 2 < input.Length - 1)
            //    {
            //        if (!input[currentIndex].Equals('(') && !input[currentIndex].Equals(')') && !input[currentIndex + 1].Equals('(') && !input[currentIndex + 1].Equals(')'))
            //        {
            //            string str = new string(input[currentIndex], input[currentIndex + 2]);
            //            string currentString = currentSum + new string(input[currentIndex], input[currentIndex + 2]);
            //            currentSum += Evaluate(str);
                        
            //            Console.WriteLine(currentSum);
            //        }
            //    }
               



            //    currentIndex += 2;
            //}







            //while (true)
            //{
            //    char currentSign;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (input[currentIndex] <= 48 && input[currentIndex] >= 57)
            //        {
            //            digit1 = input[currentIndex] - 48;
            //        }

            //        if (input[currentIndex].Equals('+'))
            //        {
            //            currentSum += (input[currentIndex - 1] + input[currentIndex - 1]);
            //        }

            //        currentIndex++;
            //    }
                
            //}


        }
    }
}
