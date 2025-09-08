using Xunit;
using GeometryLib;

namespace GeometryLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleArea_Correct()
        {
            var t = new Triangle(3, 4, 5);
            double area = t.GetArea();
            Assert.Equal(6, area, 6);
        }

        [Fact]
        public void Triangle_IsRightAngled_True()
        {
            var t = new Triangle(3, 4, 5);
            Assert.True(t.IsRightAngled());
        }

        [Fact]
        public void Triangle_IsRightAngled_False()
        {
            var t = new Triangle(3, 4, 6);
            Assert.False(t.IsRightAngled());
        }

        [Fact]
        public void Triangle_InvalidSides_Throws()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }
    }
}