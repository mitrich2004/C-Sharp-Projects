using System;

namespace ReverseSentence
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "snake";
            string sentence = "there are snakes at the zoo";

            Console.WriteLine(word);
            Console.WriteLine(ReverseWord(word));
            Console.WriteLine(sentence);
            Console.WriteLine(ReverseSentence(sentence));
        }

        static string ReverseWord(string word)
        {
            string result = "";

            for (int i = word.Length - 1; i >= 0; --i)
            {
                result += word[i];
            }

            return result;
        }

        static string ReverseSentence(string sentence)
        {
            string result = "";
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                result += ReverseWord(word) + ' ';
            }

            return result.Trim();
        }
    }
}
