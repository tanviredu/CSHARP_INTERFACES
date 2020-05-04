using System;
using Xunit;
using myapp.library;

namespace myapp.Test
{
    
    public class AbstractTest
    {
        [Fact]
        public void AbstractGetAreaTest()
        {
            IregularPolygon square = new IregularPolygon(100);
            double expected = square.GetPerimeter();
            double actual = 400;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void AbstractGetPeremeterTest()
        {
            IregularPolygon square = new IregularPolygon(4);
            double expected = square.GetArea();


            Assert.Equal(16, expected);
        }
    }
}
