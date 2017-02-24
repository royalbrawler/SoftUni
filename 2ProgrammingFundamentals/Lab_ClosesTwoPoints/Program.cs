using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts =
                    Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point() {
                X = currentPointParts[0],
                Y = currentPointParts[1]
                });
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secPointMax = null;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int k = i + 1; k < points.Count; k++) //i + 1
                {
                    var firstPoint = points[i];
                    var secPoint = points[k];

                    var currentDistance = CalculateDistance(firstPoint, secPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secPointMax = secPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistanceSoFar:f3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secPointMax.X}, {secPointMax.Y})");

        }

        public static double CalculateDistance(Point first, Point second)
        {
            var diffX = first.X - second.X;
            var diffY = first.Y - second.Y;

            var powX = Math.Pow(diffX, 2); // na kvadrat ^2 = Math.Pow
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
