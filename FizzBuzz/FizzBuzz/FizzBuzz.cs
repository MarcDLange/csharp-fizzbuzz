namespace FizzBuzz
{
    public class FizzBuzz
    {
        /// <summary>
        /// Tests if a number is a Fizz, a Buzz, a FizzBuzz or not.
        /// </summary>
        /// <param name="number">The <paramref name="number"/> that will be tested.</param>
        /// <returns>Fizz for multiples of three, Buzz for multiples of five,
        /// FizzBuzz for multiples of three and five
        /// OR the number itself (as a string) if non of the previous conditions are true.</returns>
        public string FizzAndBuzz(int number)
        {
            // Using constant values to make sure they don't change after declaration which would falsify the conditions.
            const int Three = 3;
            const int Five = 5;

            if (IsMultipleOf(number, Three) && IsMultipleOf(number, Five))
            {
                return "FizzBuzz";
            }
            else if (IsMultipleOf(number, Three))
            {
                return "Fizz";
            }
            else if (IsMultipleOf(number, Five))
            {
                return "Buzz";
            }
            else
            {
                // Converting the integer to a string, because FizzAndBuzz returns strings.
                return number.ToString();
            }
        }

        /// <summary>
        /// Tests if <paramref name="number"/> is a multiple of <paramref name="multipleOf"/>.
        /// </summary>
        /// <param name="number">The number that will be tested.</param>
        /// <param name="multipleOf">The number that will be tested against.</param>
        /// <returns><see langword="True"/> if <paramref name="number"/> is a multiple of <paramref name="multipleOf"/>. Otherwise returns <see langword="false"/>.</returns>
        public bool IsMultipleOf(int number, int multipleOf)
        {
            if (number % multipleOf == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
