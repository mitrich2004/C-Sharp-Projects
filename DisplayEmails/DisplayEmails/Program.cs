using System;

namespace DisplayEmails
{
    internal class Program
    {
        static string externalDomain = "hayworth.com";
        static string internalDomain = "contoso.com";
        static void Main(string[] args)
        {
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            DisplayEmailAddresses(corporate, true);
            DisplayEmailAddresses(external, false);
        }
        static void DisplayEmailAddresses(string[,] names, bool isCorporate)
        {
            for (int i = 0; i < names.GetLength(0); ++i)
            {
                string address = names[i, 0].ToLower().Substring(0, 2);
                address += names[i, 1].ToLower();

                if (isCorporate)
                {
                    address += $"@{internalDomain}";
                }
                else
                {
                    address += $"@{externalDomain}";
                }

                Console.WriteLine(address);
            }
        }
    }
}
