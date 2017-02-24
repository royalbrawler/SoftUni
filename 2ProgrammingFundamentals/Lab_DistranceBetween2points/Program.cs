using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_DistranceBetween2points
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointParts = Console.ReadLine()
                .Split();

            Point first = new Point
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1])
            };

            var secondPointParts = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new Point()
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var result = CalculateDistance(
                first,
                secondPoint);

            Console.WriteLine($"{result:F3}");

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
