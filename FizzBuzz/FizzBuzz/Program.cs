using System;

namespace FizzBuzz
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(
                "==========\nFizzBuzz\n==========\n" +
                "This program shows the numbers from 1 to a user specified limit (e.g. 100).\n" +
                "1. For multiples of 3, \"Fizz\" will be returned.\n" +
                "2. For Multiples of 5, \"Buzz\" will be returned.\n" +
                "3. For multiples of 3 and 5, \"FizzBuzz\" will be returned.\n" +
                "4. If none of the other rules apply, the number itself will be returned.\n\n" + 
                "Input a limit: "
            );
            
            // Converting the input into an int32 because ReadLine reads the input as a string.
            int limit = Convert.ToInt32(Console.ReadLine());
            
            // This would result in the limit being 20.
            // int limit = 20;

            // Creating a new instance of the FizzBuzz type.
            FizzBuzz fizzBuzz = new FizzBuzz();

            // Looping from 1 to the limit (including the limit).
            for (int i = 1; i <= limit; i++)
            {
                // Console.Writeline() will output a string to the console.
                // "fizzBuzz.FizzAndBuzz()" will call the "FizzAndBuzz()" method from the "fizzBuzz" instance.
                Console.WriteLine(fizzBuzz.FizzAndBuzz(i));
            }

            // This Console.ReadLine() is used to make sure the console app stays open after running.
            Console.ReadLine();
        }
    }
}
