using System;

namespace ValidateIpAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength;
            bool validZeroes;
            bool validRange;

            foreach (string ip in ipv4Input)
            {
                address = ip.Split('.');
                validLength = ValidateLength(ip, address);
                validZeroes = ValidateZeroes(ip, address);
                validRange = ValidateRange(ip, address);

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }
        }

        static bool ValidateLength(string ipv4Input, string[] address)
        {
            return address.Length == 4;
        }

        static bool ValidateZeroes(string ipv4Input, string[] address)
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidateRange(string ipv4Input, string[] address)
        {
            foreach (string number in address)
            {
                if (number == "" || int.Parse(number) > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
