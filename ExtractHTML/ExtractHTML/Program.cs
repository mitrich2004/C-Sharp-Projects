using System;

namespace ExtractHTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            const string openingSpan = "<span>";
            const string closingSpan = "</span>";

            int openingPosition = input.IndexOf(openingSpan);
            int closingPosition = input.IndexOf(closingSpan);

            openingPosition += openingSpan.Length;
            int length = closingPosition - openingPosition;
            quantity = input.Substring(openingPosition, length);

            const string openingDiv = "<div>";
            const string closingDiv = "</div>";

            openingPosition = input.IndexOf(openingDiv);
            closingPosition = input.IndexOf(closingDiv);

            openingPosition += openingDiv.Length;
            length = closingPosition - openingPosition;
            output = input.Substring(openingPosition, length);
            output = output.Replace("trade", "reg");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }
    }
}
