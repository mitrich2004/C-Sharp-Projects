using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidIntegerInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integerValue = 0;
            string readResult;
            bool validInteger = false;

            do
            {
                Console.Write("Enter an integer value from 5 to 10: ");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    validInteger = int.TryParse(readResult, out integerValue);

                    if (validInteger)
                    {
                        if (integerValue < 5 || integerValue > 10)
                        {
                            validInteger = false;
                        }
                    }

                    if (!validInteger)
                    {
                        Console.WriteLine("Sorry, you entered an invalid number, please try again");
                    }
                }

            } while (!validInteger);

            Console.WriteLine($"Your input value ({integerValue}) has been accepted.");
        }
    }
}
