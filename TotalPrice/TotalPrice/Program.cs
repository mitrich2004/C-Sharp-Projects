using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalPrice
{
    internal class Program
    {
        static double total = 0;
        static double minimumSpend = 30.00;

        static double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
        static double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

        static void Main(string[] args)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                total += GetDiscountedPrice(i);
            }

            if (TotalMeetsMinimum())
            {
                total -= 5.00;
            }

            Console.WriteLine($"Total: {FormatDecimal(total)}");
        }

        static double GetDiscountedPrice(int itemIndex)
        {
            double price = items[itemIndex];
            double discount = discounts[itemIndex];

            return price - (price * discount);
        }

        static bool TotalMeetsMinimum()
        {
            return total >= minimumSpend;
        }

        static string FormatDecimal(double input)
        {
            return $"{input:C2}";
        }
    }
}
