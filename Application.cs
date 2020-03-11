using System;

namespace csharp_text_analyser_spiacy_lin
{
    class Application
    {
        static void Main(string[] args)
        {
            FileContent fcont = new FileContent("andrzej ma kota");
            Iterator iterator = fcont.WordIterator();
            while (iterator.HasNext())
            {
                string item = (string) iterator.MoveNext();
                Console.WriteLine(item);
            }
        }
    }
}
