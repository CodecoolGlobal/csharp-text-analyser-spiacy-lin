using System;
using System.Collections;

namespace csharp_text_analyser_spiacy_lin
{
    public class FileContent : IterableText
    {
        private string basestring;
        public FileContent(string str)
        {
            basestring = str;
        }
        
        public Iterator CharIterator()  
        {
            return new CharIterator(this);
        }
        public Iterator WordIterator()  
        {
            return new WordIterator(this);
        }
        public string this[int index]
        {
            get {return basestring[index].ToString();}
        }
        public int Count
        {
            get {return basestring.Length;}
        }
        public void Add(string s)
        {
            basestring += s;
        }
        public string GetFileName()
        {
            return "";
        }
    }
}