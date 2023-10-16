using System;

namespace TwoCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = 30;
            int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                Console.WriteLine("Change found at positions:");

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (result[i, 0] == -1)
                    {
                        break;
                    }

                    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
                }
            }
        }
        static int[,] TwoCoins(int[] coins, int target)
        {
            int [,] result = { { -1,-1},{ -1,-1},{ -1,-1},{ -1,-1},{ -1,-1} };
            int counter = 0;

            for (int i = 0; i < coins.Length; ++i)
            {
                for (int j = i + 1; j < coins.Length; ++j)
                {
                    if (coins[j] + coins[i] == target)
                    {
                        result[counter, 0] = i;
                        result[counter, 1] = j;
                        ++counter;
                    }

                    if (counter == result.GetLength(0))
                    {
                        return result;
                    }
                }
            }

            return (counter > 0) ? result : new int[0,0];
        }
    }
}
