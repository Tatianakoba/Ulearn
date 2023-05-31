using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentences
{
    internal class Program
    {
        public static List<List<string>> ParseSentences(string text, string[] sentences)
        {
            var sentencesList = new List<List<string>>();

            
            //Разделение предложений на слова методом SplitIntoWords
            foreach (string sentence in sentences)
            {
                //Проверка на пустую строку
                if (!string.IsNullOrWhiteSpace(sentence) && SplitIntoWords(sentence).Capacity > 0)
                {
                    sentencesList.Add(SplitIntoWords(sentence));
                }
            }
            return sentencesList;
        }
        //Разделение предложения на слова
        public static List<string> SplitIntoWords(string sentence)
        {
            var words = new List<string>();
            var wordsBuilder = new StringBuilder();

            //Составление слов из букв и '
            foreach (char ch in sentence)
            {
                if (char.IsLetter(ch) || ch == '\'')
                    wordsBuilder.Append(ch);
                else
                    wordsBuilder.Append(' ');
            }
            string[] stringsOfWords = wordsBuilder.ToString()
            .Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in stringsOfWords)
            {
                words.Add(word);
            }
            return words;
        }
        static void Main(string[] args)
        {
            var text = "My husband is a QA engeneer, he likes codding. He spend all the time with his computer.";
            string[] separatorsOfSentences = { ".", "!", "?", ";", ":", "(", ")" };
            string[] sentences = text.ToLower().Split(separatorsOfSentences, System.StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("[{0}]", string.Join(", ", sentences));
            Console.WriteLine("[{0}]", string.Join(", ", ParseSentences(text, sentences)));
            


            Console.ReadKey();
        }
    }
}
