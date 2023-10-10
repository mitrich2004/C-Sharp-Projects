using System;

namespace RPGBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random attackRandomizer = new Random();
            int heroHealth = 10;
            int monsterHealth = 10;
            int attack;
            bool heroTurn = true;

            while (heroHealth > 0 && monsterHealth > 0)
            {
                attack = attackRandomizer.Next(1, 11);

                if (heroTurn)
                {
                    monsterHealth -= attack;
                    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
                }
                else
                {
                    heroHealth -= attack;
                    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
                }

                heroTurn = !heroTurn;
            }

            Console.WriteLine(heroHealth > 0 ? "Hero wins!" : "Monster wins!");
        }
    }
}
