using Xunit;
using GeometryLib;

namespace GeometryLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleArea_Correct()
        {
            var circle = new Circle(10);
            double area = circle.GetArea();
            Assert.Equal(Math.PI * 100, area, 6);
        }

        [Fact]
        public void Circle_InvalidRadius_Throws()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}