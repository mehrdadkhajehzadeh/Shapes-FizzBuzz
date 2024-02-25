using FluentAssertions;

namespace Shapes.Unit.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void Area_Calculate_Area_Of_Rectangle()
        {
            var length = 4;
            var width = 2;
            var rectangle = new Shapes.Rectangle(length, width);
            var expected = 8;

            var actual = rectangle.Area();

            actual.Should().Be(expected);
        }
    }
}