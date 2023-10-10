using System;

namespace ProcessStringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

            int periodLocation;

            foreach (string myString in myStrings)
            {
                string str = myString;
                periodLocation = myString.IndexOf('.');

                while (periodLocation > -1)
                {
                    Console.WriteLine(str.Substring(0, periodLocation));
                    str = str.Remove(0, periodLocation + 2);
                    periodLocation = str.IndexOf('.');
                }

                Console.WriteLine(str);
            }
        }
    }
}
