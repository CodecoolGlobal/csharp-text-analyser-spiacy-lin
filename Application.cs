using System;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            FileContent fcont = new FileContent("ala ma kota");
            Iterator iteratorW = fcont.WordIterator();
            while (iteratorW.HasNext())
            {
                string item = (string) iteratorW.MoveNext();
                Console.WriteLine(item);
            }
            Iterator iteratorC = fcont.CharIterator();
            while (iteratorC.HasNext())
            {
                string item = (string) iteratorC.MoveNext();
                Console.WriteLine(item);
            }
        }
    }
}
