using System;
using Xunit;
using myapp.library;
namespace myapp.Test
{
    public class SquareTest
    {
        [Fact]
        public void PeremeterCheck()
        {
            // arrange
            IregularPolygon square = new IregularPolygon(100);
            // act
            double expected = square.GetPerimeter();
            double actual = 400;
            //assert

            Assert.Equal(expected, actual);


        }


        [Fact]
        public void AreaCheck()
        {
            IregularPolygon square = new IregularPolygon(4);
            // act
            double expected = square.GetArea();
            double actual = 16;
            //assert

            Assert.Equal(expected, actual);

        }
    }
}
