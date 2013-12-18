using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApplication1
{
    class Program
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

            
            string str = new string(array);
            
            int sum = Evaluate(str);

            Console.WriteLine("{0:F3}", sum);



        }
    }
}
