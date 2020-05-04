using System;

namespace myapp.library
{

    // this is a  concrete class
    // not a n abstracy class
    // or interface
    public class ConcreteRegularPolygon
    {

        // initialte the constructor
        public ConcreteRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        // defining the properties
        // what is polygon?
        // polygon is 2d shape build with straight 
        //line like square hexagon,pentagon,triengel
        // etc

        // setting up the getter and setter
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        // method goes here for calculating the Perimeter
        // and the method for calculating the Area

        public double GetPerimeter()
        {
            // this perimeter calculation is valid 
            // for every Polygon 
            return NumberOfSides * SideLength;
        }

        // this is the area method and we are not 
        // going to implement this because
        //this is different for different plygon


        public virtual double GetArea (){


            throw new NotImplementedException();
            // we are going to overide this method 
            //  in another class
        } 
        
       
    }
}
