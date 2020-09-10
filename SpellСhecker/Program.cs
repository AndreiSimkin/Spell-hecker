using System;

namespace SpellСhecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonory dictonory = new Dictonory();
            dictonory.AddWords("main mainly".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
