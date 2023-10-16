using System;

namespace DiceMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            if (ShouldPlay())
            {
                PlayGame();
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = random.Next(1, 6);
                    var roll = random.Next(1, 7);

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }
        }

        static bool ShouldPlay()
        {
            string answer = "";

            do
            {
                Console.WriteLine("Would you like to play? (Y/N)");
                answer = Console.ReadLine();

                if (answer != null)
                {
                    answer = answer.Trim().ToLower();
                }

            } while (answer != "n" && answer != "y");

            return answer == "y";
        }

        static string WinOrLose(int roll, int target)
        {
            return (roll > target) ? "You win!" : "You lose!";
        }
    }
}
