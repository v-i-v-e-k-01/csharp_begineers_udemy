using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength)
        {
            if (sentence.Length < maxLength)
            {
                return sentence;
            }

            Console.WriteLine(sentence.Substring(0, maxLength));

            //to avoid word cuts (incomplete words)
            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
                summaryWords.Add(word);
            }

            var summary = String.Join(" ", summaryWords) + "...";
            return summary;

        }
    }
}
