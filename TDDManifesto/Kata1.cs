
namespace TDDManifesto
{
    public class Kata1
    {
        const string Fizz = "Fizz";
        const string Buzz = "Buzz";

        public string FizzBuzz(int number)
        {
            var isMultipleOfThree = number % 3 == 0;
            var isMultipleOfFive = number % 5 == 0;

            if (number != 0 && isMultipleOfThree && isMultipleOfFive)
            {
                return string.Concat(Fizz, Buzz);
            }
            else if (number != 0 && isMultipleOfThree)
            {
                return Fizz;
            }
            else if (number != 0 && isMultipleOfFive)
            {
                return Buzz;
            }
            else 
            {
                return number.ToString();
            }
        }
    }
}