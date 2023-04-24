using System;

namespace Stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] words = text.Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].ToLower() == "например")
                {
                    if (j != words[j].Length - 1)
                    {
                        words[j] = words[j] + ",";
                    }
                }
            }

            string newText = string.Join(" ", words);

            Console.WriteLine(newText);

            string sentence = Console.ReadLine();
            string[] word = sentence.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    word[i] = "";
                }
                else if (word[i].Length > 1)
                {
                    char[] charArray = word[i].ToCharArray();
                    Array.Reverse(charArray);
                    word[i] = new string(charArray);
                }
            }

                string newSentence = string.Join(" ", word);

                Console.WriteLine(newSentence);
        }
    }
}
