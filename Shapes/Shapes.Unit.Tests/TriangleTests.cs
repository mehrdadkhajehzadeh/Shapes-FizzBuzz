using FluentAssertions;

namespace Shapes.Unit.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_Calculate_Area_Of_Triangle()
        {
            var triangleBase = 6;
            var triangleHeight = 4;
            var triangle = new Shapes.Triangle(triangleHeight,triangleBase);
            var expected = 12;

            var actual = triangle.Area();

            actual.Should().Be(expected);
        }
    }
}