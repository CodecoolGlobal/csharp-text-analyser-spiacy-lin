using System;
using System.Collections.Generic;

namespace csharp_text_analyser_spiacy_lin
{
    class StatisticalAnalysis
    {
        Iterator i;
        public StatisticalAnalysis(Iterator i)
        {
            this.i = i;
        }

        public int CountOf(params string[] args)
        {
            int counter = 0;
            foreach (string el in CreateList())
            {
                foreach (string item in args)
                {
                    if (el.Equals(item)) {counter++;}
                }
            }
            return counter; 
        }
        public List<string> CreateList()
        {
            List<string> stringList = new List<string>();
            while (i.HasNext())
            {
                string item = (string)i.MoveNext();
                stringList.Add(item);
            }
            return stringList;
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