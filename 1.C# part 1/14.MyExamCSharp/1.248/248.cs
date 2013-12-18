using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._248
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong A = ulong.Parse(Console.ReadLine());
            ulong B = ulong.Parse(Console.ReadLine());
            ulong C = ulong.Parse(Console.ReadLine());
            ulong R;
            ulong x;


            if (B == 2)
            {
                R = A % C;
            }
            else if (B == 4)
            {
                R = A + C;
            }
            else// if (B == 8)
            {
                R = A * C;
            }

            if (R % 4 == 0)
            {
                x = R / 4;
                Console.WriteLine(x);
            }
            else
            {
                x = R % 4;
                Console.WriteLine(x);
            }

            Console.WriteLine(R);

        }
    }
}
