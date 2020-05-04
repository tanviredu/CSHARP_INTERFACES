using System;

namespace myapp.library
{

    // this is the implementation
    // of the I regular plly gon
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get ; set ; }

        public double GetArea()
        {
            //implement the octagon Aread
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
