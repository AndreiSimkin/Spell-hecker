using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace SpellСhecker
{
    public class Dictonory
    {
        public class Letter : IEquatable<char>
        {
            public Letter(char character, bool end)
            {
                Character = character;
                End = end;
                Letters = new List<Letter>();
            }

            public char Character { get; set; }
            public bool End { get; set; }
            public List<Letter> Letters { get; set; }

            public bool Equals(char other) => Character == other;

            public override string ToString() => Character.ToString();
        }

        List<Letter> Letters { get; set; }

        public Dictonory()
        {
            Letters = new List<Letter>();
        }

        public void AddWord(string word)
        {
            word = word.ToLower();
            List<Letter> letters = Letters;
            for (int c = 0; c < word.Length; c++)
            {
                int index = -1;
                for (int i = 0; i < letters.Count && index == -1; i++)
                    if (letters[i].Equals(word[c]))
                        index = i;

                if (index != -1)
                    if (c == word.Length - 1)
                        letters[index].End = true;
                    else
                        letters = letters[index].Letters;
                else
                {
                    letters.Add(new Letter(word[c], c == word.Length - 1));
                    letters = letters.Last().Letters;
                }
            }
        }

        public void AddWords(string[] words)
        {
            foreach (string w in words)
                AddWord(w);
        }
    }
}
