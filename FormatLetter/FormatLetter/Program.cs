using System;

namespace FormatLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage += $"{currentProduct.PadRight(20)}";
            comparisonMessage += $"{currentReturn:P2}".PadRight(10);
            comparisonMessage += $"{currentProfit:C}\n";

            comparisonMessage += $"{newProduct.PadRight(20)}";
            comparisonMessage += $"{newReturn:P2}".PadRight(10);
            comparisonMessage += $"{newProfit:C}\n";

            Console.WriteLine(comparisonMessage);
        }
    }
}
