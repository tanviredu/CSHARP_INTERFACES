using System;
using System.Collections.Generic;
using System.Text;

namespace myapp.library
{


    // this class will override the GetArea Method
    public class IregularPolygon : ConcreteRegularPolygon
    {
        

        // so we inherit the concreate class
        // so we need to fill the base class constructor
        // this is the super method
        public IregularPolygon(int sideLength) : base(4, sideLength)
        {
            // this is how you fill the base constructor class
            // square class has 4 number of slides 
            // and we feed the sideLength
           
        }

        // now we instantiate a class with square propertise
        // we need to Get the area
        // to inherit the concreate class
        // and make this thing suitable for nthe purpose
        // you need to override the class
        public override double GetArea()
        {
            // this is by default call the base class
            //return base.GetArea();
            return SideLength * SideLength;
        }
    }
}
