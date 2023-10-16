using System;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

            Console.WriteLine("Is it a palindrome?");
            foreach (string word in words)
            {
                Console.WriteLine($"{word}: {IsPalindrome(word)}");
            }
        }
        static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
