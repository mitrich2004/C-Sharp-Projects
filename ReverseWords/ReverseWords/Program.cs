using System;

namespace ReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(' ');

            for (int i = 0; i < words.Length; ++i)
            {
                char[] letters = words[i].ToCharArray();
                Array.Reverse(letters);
                words[i] = new string(letters);
            }

            string reversedPangram = String.Join(" ", words);
            Console.WriteLine(reversedPangram);
        }
    }
}
