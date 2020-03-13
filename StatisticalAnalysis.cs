using System;

namespace csharp_text_analyser_spiacy_lin
{
    class StatisticalAnalysis
    {
        Iterator i;
        public StatisticalAnalysis(Iterator i)
        {
            this.i = i;
        }

        public int Size()
            {
                   int how_many = 0;
                   while (i.HasNext())
                   {
                       string item = (string)i.MoveNext();
                       how_many++;
                   }
                   return how_many;
            }
    }
}