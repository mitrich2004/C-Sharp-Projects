using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string permission = "Developer";
            int level = 19;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                    Console.WriteLine("Welcome, Super Admin user.");
                else
                    Console.WriteLine("Welcome, Admin user.");
            }
            else if (permission.Contains("Manager") && level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}

