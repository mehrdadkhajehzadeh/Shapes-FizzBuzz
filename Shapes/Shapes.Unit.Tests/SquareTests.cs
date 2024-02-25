using FluentAssertions;

namespace Shapes.Unit.Tests
{
    public class SquareTests
    {
        [Fact]
        public void Area_Calculate_Area_Of_Square()
        {
            var length = 4;
            var square = new Shapes.Square(length);
            var expected = 16;

            var actual = square.Area();

            actual.Should().Be(expected);
        }
    }
}