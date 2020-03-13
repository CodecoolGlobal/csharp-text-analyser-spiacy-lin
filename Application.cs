using System;
using System.Collections.Generic;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("mytext.txt");
            FileContent fcont = new FileContent(text);
            Iterator iteratorW = fcont.WordIterator();
            Iterator iteratorC = fcont.CharIterator();

            StatisticalAnalysis staW = new StatisticalAnalysis(iteratorW);
            //string[] ar = {"ala","kot"};
            Console.WriteLine(staW.CountOf("ala","kot"));            
            StatisticalAnalysis staC = new StatisticalAnalysis(iteratorC);
            Console.WriteLine(staC.Size());
            
            
            

               
        }
    }
}

