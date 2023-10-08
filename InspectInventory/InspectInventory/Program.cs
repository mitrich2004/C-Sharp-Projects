using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inventory = { 200, 450, 700, 175, 250 };

            int sum = 0;
            int bin = 0;

            foreach (int items in inventory)
            {
                ++bin;
                sum += items;

                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in inventory");
        }
    }
}
