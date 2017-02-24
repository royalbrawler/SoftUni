using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_rectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        int CalcArea()
        {
            return Width * Height;
        }

        //public int Bottom => Top - Height;   tarikatskoto
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
               (r.Top <= Top) && (r.Bottom >= Bottom);
        }

    }
}
