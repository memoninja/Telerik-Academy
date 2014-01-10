// 04. Write methods that calculate the surface of a triangle by given:
//     Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

namespace _04.CalculateTriangleSurface
{
    class CalculateTriangleSurface
    {
        static void Main()
        {
            double triangleSurface;

            //Triangle surface by side and altitude to it
            triangleSurface = TriangleSurface(side: 3.1, altitude: 3.7);
            Console.WriteLine("Triangle surface by side and altitude: {0:F5}", triangleSurface);

            //Triangle surface by three sides
            triangleSurface = TriangleSurface(sideA: 2.7, sideB: 4.8, sideC: 3.1);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Triangle surface by three sides: {0:F5}", triangleSurface);

            //Triangle surface by two sides and angle between them
            triangleSurface = TriangleSurface(sideA: 3.8, sideB: 4.3, angle: 38);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Triangle surface by two sidea and angle: {0:F5}", triangleSurface);
        }

        /// <summary>
        /// Claculate triangle surface by side and altitude to it
        /// </summary>
        /// <param name="side">Side length</param>
        /// <param name="altitude">Altitude length</param>
        /// <returns>Triangle surface</returns>
        private static double TriangleSurface(double side, double altitude)
        {
            double surface = (side * altitude) / 2;

            return surface;
        }

        /// <summary>
        /// Claculate triangle surface by three sides
        /// </summary>
        /// <param name="sideA">Side A length</param>
        /// <param name="sideB">Side B length</param>
        /// <param name="sideC">Side C length</param>
        /// <returns>Triangle surface</returns>
        private static double TriangleSurface(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            return surface;
        }

        /// <summary>
        /// Claculate triangle surface by two sides and an angle between them
        /// </summary>
        /// <param name="sideA">Side A length</param>
        /// <param name="sideB">Side B length</param>
        /// <param name="angle">Angle between sides A and B</param>
        /// <returns>Triangle surface</returns>
        private static double TriangleSurface(double sideA, double sideB, int angle)
        {
            double surface = (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;

            return surface;
        }
    }
}
