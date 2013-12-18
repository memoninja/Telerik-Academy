using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());

            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());

            int h = int.Parse(Console.ReadLine());

            int[] catapultsCoordinates = new int[6];
            for (int i = 0; i < catapultsCoordinates.Length; i++)
            {
                catapultsCoordinates[i] = int.Parse(Console.ReadLine());
            }

            //catapultsCoordinates[0] = -9;
            //catapultsCoordinates[1] = -3;

            //catapultsCoordinates[2] = -12;
            //catapultsCoordinates[3] = -4;

            //catapultsCoordinates[4] = -6;
            //catapultsCoordinates[5] = -1;


            //int Cx1 = -6; //-9;
            //int Cy1 = -1; //-3;

            //int Cx2 = -12;
            //int Cy2 = -4;

            //int Cx3 = -6;
            //int Cy3 = -1;

            int score = 0;

            // Calculate projectile of catapults(only on axis "Y")

            catapultsCoordinates[1] = Math.Abs(catapultsCoordinates[1]) + Math.Abs(h);
            catapultsCoordinates[3] = Math.Abs(catapultsCoordinates[3]) + Math.Abs(h);
            catapultsCoordinates[5] = Math.Abs(catapultsCoordinates[5]) + Math.Abs(h);


            //int projectileCy1 = Math.Abs(Cy1) + Math.Abs(h);
            //int projectileCy2 = Math.Abs(Cy2) + Math.Abs(h);
            //int projectileCy3 = Math.Abs(Cy3) + Math.Abs(h);

            //Console.WriteLine(projectileCy1);

            for (int i = 0; i < catapultsCoordinates.Length / 2; i += 2)
            {
                if (catapultsCoordinates[i + 1] < (Math.Abs(Sy1) - Math.Abs(h)) && catapultsCoordinates[i + 1] > (Math.Abs(Sy2) - Math.Abs(h)) && Math.Abs(catapultsCoordinates[i]) < Math.Abs(Sx1) && Math.Abs(catapultsCoordinates[i]) > Math.Abs(Sx2))
                {
                    //if (true)
                    //{
                        
                    //}
                    score += 100;
                }
                else if ((catapultsCoordinates[i] == Math.Abs(Sx1) || catapultsCoordinates[i] == Math.Abs(Sx2)) && catapultsCoordinates[i + 1] <= (Math.Abs(Sy1) - Math.Abs(h)) && catapultsCoordinates[i + 1] >= (Math.Abs(Sy2) - Math.Abs(h)))
                {

                    score += 25;
                }
                else if ((catapultsCoordinates[i + 1] == (Math.Abs(Sy1) - Math.Abs(h)) || catapultsCoordinates[i + 1] == (Math.Abs(Sy2) - Math.Abs(h)) && catapultsCoordinates[i] <= Math.Abs(Sx1) && Math.Abs(catapultsCoordinates[i]) >= Math.Abs(Sx2)))
                {
                    score += 25;
                }
            }

            Console.WriteLine("{0}%",score);
        }
    }
}
