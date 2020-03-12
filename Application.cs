using System;
using System.Collections.Generic;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("test.txt");
            var wordslist = new List<string>();
            var charslist = new List<string>();
            int how_many_chars = 0;
            int how_many_words = 0;
            FileContent fcont = new FileContent(text);
            
            Iterator iteratorC = fcont.CharIterator();
            while (iteratorC.HasNext())
            {
                string item = (string) iteratorC.MoveNext();
                how_many_chars++;
                charslist.Add(item);
            }
            Console.WriteLine(how_many_chars);
            
            Iterator iteratorW = fcont.WordIterator();
            while (iteratorW.HasNext())
            {
                string item = (string) iteratorW.MoveNext();
                how_many_words++;
                wordslist.Add(item);
            }
            
            Console.WriteLine(how_many_words);
        }
    }
}
