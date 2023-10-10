using System;

namespace ValidStringInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult = "";
            bool validRole = false;
            string formattedResult;
            
            do
            {
                Console.Write("Enter your role name (Administrator, Manager, or User): ");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    formattedResult = readResult.Trim().ToLower();
                    if (formattedResult == "administrator" || formattedResult == "manager" || formattedResult == "user")
                    {
                        validRole = true;
                    }
                }

                if (!validRole)
                {
                    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid.");
                }

            } while (!validRole);

            Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
        }
    }
}
