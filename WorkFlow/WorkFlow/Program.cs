using System;

namespace WorkFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] userEnteredValues = new string[][]
            {
                new string[] { "1", "2", "3"},
                new string[] { "1", "two", "3"},
                new string[] { "0", "1", "2"}
            };

            try
            {
                Workflow1(userEnteredValues); 
                Console.WriteLine("'Workflow1' completed successfully.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }
        }

        static void Workflow1(string[][] userEnteredValues)
        {
            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    Process1(userEntries);
                    Console.WriteLine("'Process1' completed successfully.\n");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message + '\n');
                }
            }
        }

        static void Process1(String[] userEntries)
        {
            foreach (string userValue in userEntries)
            {
                try
                {
                    int valueEntered = int.Parse(userValue);

                    checked
                    {
                        int calculatedValue = 4 / valueEntered;
                    }
                }
                catch  (FormatException)
                {
                    FormatException formatException = new FormatException("Invalid data. User input values must be valid integers.");
                    throw formatException;
                }
                catch (DivideByZeroException)
                {
                    DivideByZeroException divideByZeroException = new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                    throw divideByZeroException;
                }
            }
        }
    }
}
