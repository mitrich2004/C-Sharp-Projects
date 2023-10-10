using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; ++i)
            {
                string postfix = "";

                if (i % 3 == 0)
                    postfix += "Fizz";

                if (i % 5 == 0)
                    postfix += "Buzz";

                Console.WriteLine($"{i} {postfix}");
            }
        }
    }
}
