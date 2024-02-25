using FluentAssertions;

namespace FizzBuzzGame.Unit.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData("Fizz", 9)]
        [InlineData("Buzz", 10)]
        [InlineData("FizzBuzz", 15)]
        [InlineData("Not divisible by 3 or 5", 11)]

        public void Check_Check_Number_Divisible_By_Three_Or_Five_Or_Both_Number(string expected, int number)
        {
            var a = new FizzBuzzGame.FizzBuzz(number);

            var actual = a.Check();

            actual.Should().Be(expected);


        }
    }
}