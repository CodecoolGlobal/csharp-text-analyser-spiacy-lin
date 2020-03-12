using System;

namespace csharp_text_analyser_spiacy_lin
{
    public interface IterableText
    {
        public Iterator CharIterator();  
        public Iterator WordIterator();  
    }
}