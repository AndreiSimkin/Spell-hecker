using System;
using System.Collections.Generic;
using System.Text;

namespace SpellСhecker
{
    public class Dictonory
    {
        public class Letter
        {
            public Letter(char character)
            {
                Сharacter = character;
                Letters = new List<Letter>();
            }

            public char Сharacter { get; set; }
            List<Letter> Letters { get; set; }
        }
    }
}
