using FluentAssertions;

namespace Shapes.Unit.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Area_Claculate_Area_of_Circle()
        {
            var radius = 3;
            var circle = new Shapes.Circle(radius);
            double expected = 28.274333882308138;

            var actual = circle.Area();

            actual.Should().Be(expected);
        }
    }
}