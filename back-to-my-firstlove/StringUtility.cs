using System;
using System.Collections.Generic;

namespace back_to_my_firstlove
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;


            var words = text.Split(' ');
            Console.WriteLine(words.Length);
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            var count = 0;
            foreach (var word in words)
            {
                count++;
                summaryWords.Add(word);
                //Console.WriteLine(summaryWords.Count);

                totalCharacters += word.Length + 1;

                if (totalCharacters > maxLength)
                    break;
            }
            Console.WriteLine(count);

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
