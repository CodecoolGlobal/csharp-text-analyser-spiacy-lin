using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int n = 0; n < args.Length; n++)
            {
                Console.WriteLine("==" + args[n] + "==");
                string text = System.IO.File.ReadAllText(args[n]);
                FileContent fcont = new FileContent(text);
                Iterator iteratorW = fcont.WordIterator();
                Iterator iteratorC = fcont.CharIterator();
                StatisticalAnalysis staW = new StatisticalAnalysis(iteratorW);
                StatisticalAnalysis staC = new StatisticalAnalysis(iteratorC);
                
                Console.Write("Char count: ");
                int charnumb = staC.Size();
                Console.WriteLine(charnumb);
                
                Console.Write("Word count: ");
                int wordnumb = staW.Size();
                Console.WriteLine(wordnumb);
                
                Console.Write("Dict size: ");
                Console.WriteLine(staW.DictionarySize());   
                
                Console.WriteLine("Most used words (>1%):");
                int onepercentW = (int)(wordnumb/100 +1);
                Console.WriteLine("[" + String.Join(", ", staW.OccurMoreThan(onepercentW).ToList()) + "]");

                Console.Write("'love' count: ");
                Console.WriteLine(staW.CountOf("love"));
                Console.Write("'hate' count: ");
                Console.WriteLine(staW.CountOf("hate"));
                Console.Write("'music' count: ");
                Console.WriteLine(staW.CountOf("music"));
                
                Console.Write("vowels %: ");
                int vowelsNumber = staC.CountOf("a","e","i","o","u");
                float t1 = (float)vowelsNumber/charnumb;
                int perc = (int)(t1 * 100.0);
                Console.WriteLine(perc+1);

                Console.Write("a:e count ratio: ");
                float ratio = (float)staC.CountOf("e")/staC.CountOf("a");
                Console.WriteLine(ratio.ToString("0.00"));
                
                Dictionary<string,string> outcomedict = staC.DictionaryRatio();
                foreach(KeyValuePair<string,string> kvp in outcomedict)
                {
                    Console.Write("[ {0} -> {1} ]", kvp.Key.ToUpper(),kvp.Value);
                }
                Console.WriteLine();      
            }
            sw.Stop();
            Console.WriteLine("Benchmark time: {0} msecs",sw.Elapsed.Milliseconds);
        }
    }
}

