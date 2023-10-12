using System;

namespace SeparateStringsAndNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string message = "";
            decimal total = 0.0m;
            decimal tmp;

            foreach (string value in values)
            {
                if (decimal.TryParse(value, out tmp))
                {
                    total += tmp;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }
    }
}
