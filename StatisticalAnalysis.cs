using System;
using System.Collections.Generic;

namespace csharp_text_analyser_spiacy_lin
{
    class StatisticalAnalysis
    {
        List<string> strList = new List<string>();
        //constructor
        public StatisticalAnalysis(Iterator i)
        {
            List<string> stringList = new List<string>();
            while (i.HasNext())
            {
                string item = (string)i.MoveNext();
                stringList.Add(item);
            }
            strList = stringList;
        }
        //methods
        public int CountOf(params string[] args)
        {
            int counter = 0;
            foreach (string item in args)
            {
                foreach (string el in strList)
                {
                    if (item.Equals(el)) {counter++;}
                }
            }
            return counter; 
        }
        
        public int DictionarySize()
        {
            Dictionary<string,int> mydict = new Dictionary<string, int>();
            int dictcounter = 0;
            foreach (string dstring in strList)
            {
                if (!mydict.ContainsKey(dstring))
                {
                    mydict.Add(dstring,1);
                    dictcounter++;
                }
            }
            return dictcounter;
        }
        public int Size()
        {
            return strList.Count;
        }
        public ISet<string> OccurMoreThan(int _n_)
        {
            // from List to HashSet
            HashSet<string> mySet = new HashSet<string>(strList);//tylko różne wyrazy
            HashSet<string> outputSet = new HashSet<string>();
            foreach (string item in mySet)
            {
                int how_many = 0;
                foreach (string el in strList)
                {
                    if (item.Equals(el)) {how_many++;}
                }
                if (how_many > _n_) { outputSet.Add(item);}
            }
            return outputSet;
        }
    }
}