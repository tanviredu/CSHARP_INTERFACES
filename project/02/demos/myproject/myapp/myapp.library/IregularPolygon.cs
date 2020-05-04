using System.Collections.Generic;
using System.Text;

namespace myapp.library
{
    interface IRegularPolygon
    {
        // only the method goes here

        int NumberOfSides { get; set; }
        int SideLength { get; set; }
        double GetPerimeter();
        double GetArea();

    }
}
