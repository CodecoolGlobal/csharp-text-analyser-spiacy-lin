using System;
using System.Collections.Generic;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("       TEXT ANALIZER     ");
            for (int n = 0; n < args.Length; n++)
            {
                Console.WriteLine("---- " + args[n] + " ----");
                string text = System.IO.File.ReadAllText(args[n]);
                FileContent fcont = new FileContent(text);
                Iterator iteratorW = fcont.WordIterator();
                Iterator iteratorC = fcont.CharIterator();
                StatisticalAnalysis staW = new StatisticalAnalysis(iteratorW);
                StatisticalAnalysis staC = new StatisticalAnalysis(iteratorC);
                
                // Size() method
                Console.Write("Number of words: ");
                Console.WriteLine(staW.Size());
                Console.Write("Number of chars without empty spaces: ");
                Console.WriteLine(staC.Size());
                // CountOf("caca") method
                Console.Write("Number of particular word: ");
                Console.WriteLine(staW.CountOf("ala"));
                Console.Write("Number of wovels: ");
                Console.WriteLine(staC.CountOf("a","e","i","o","u"));
                // DictionarySize() method
                Console.Write("Number of different chars: ");
                Console.WriteLine(staC.DictionarySize());
                Console.Write("Number of different words: ");
                Console.WriteLine(staW.DictionarySize());            
                // OccurMOreThan(int) method
                foreach (string i in staW.OccurMoreThan(2))
                {
                    Console.WriteLine(i);
                }
                foreach (string i in staC.OccurMoreThan(2))
                {
                    Console.WriteLine(i);
                }


            }
            
        }
    }
}

