using System;
using System.Collections.Generic;
using System.Text;

namespace myapp.library
{
    public abstract class abstractPolygon
    {
        protected abstractPolygon(int numberOfSide, int sideLength)
        {
            NumberOfSide = numberOfSide;
            SideLength = sideLength;
        }

        // you must implement this method in the 
        // inherited class
        // but you can write some method 
        // here 

        public int NumberOfSide { get; set; }
        public int SideLength { get; set; }


        // write get perimeter

        public double GetPerimeter()
        {
            return NumberOfSide * SideLength;
        }

        // make a abstract method that user must implement

        public abstract double GetArea();


    }


    public class AbstractPolySquare : abstractPolygon
    {
        public AbstractPolySquare(int sideLength) : base(4, sideLength)
        {
        }

        // this is becayse the base class 
        // has a constructor




        // this have to be done either 
        // it will show error
        public override double GetArea()
        {
            // now implement this class
            return SideLength * SideLength;
        }
    }




}
