using System;

namespace TextInBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            char[] openSymbols = { '[', '{', '(' };

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1)
                {
                    break;
                }

                char openingBracket = message[openingPosition];
                char closingBracket = ' ';

                switch (openingBracket)
                {
                    case '[':
                        closingBracket = ']';
                        break;
                    case '(':
                        closingBracket = ')';
                        break;
                    case '{':
                        closingBracket = '}';
                        break;
                }

                openingPosition += 1;
                closingPosition = message.IndexOf(closingBracket, openingPosition);
                int length = closingPosition - openingPosition;

                Console.WriteLine(message.Substring(openingPosition, length));
            }
        }
    }
}
