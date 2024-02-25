namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public int Number { get; set; }
        public FizzBuzz(int number)
        {
            Number = number;
        }
        public string Check()
        {
            if (Number % 3 == 0 && Number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (Number % 3 == 0)
            {
                return "Fizz";
            }
            else if (Number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "Not divisible by 3 or 5";
            }
        }
    }
}