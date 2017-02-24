using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_rectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle
            {
                Top = 3,
                Left = 5,
                Width = 2,
                Height = 1
            };

            // easy 33 points
            //var random = new Random();
            //Console.WriteLine(
            //    random.Next(0,2) == 0
            //    ? "Inside"
            //    : "Not Inside");

            Rectangle r1 = ReadRectangle(), r2 = ReadRectangle();
            Console.WriteLine(r1.IsInside(r2)
                ? "Inside"
                : "Not inside");

        }

        private static Rectangle ReadRectangle()
        {
            var parseThis = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Rectangle parsedRect = new Rectangle
            {
                Left = parseThis[0],
                Top = parseThis[1],
                Width = parseThis[2],
                Height = parseThis[3]
            };
            return parsedRect;
        }
    }
}
