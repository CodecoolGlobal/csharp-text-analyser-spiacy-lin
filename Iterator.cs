using System;

namespace csharp_text_analyser_spiacy_lin
{
    public interface Iterator
    {
        public bool HasNext();
        public string MoveNext();
        public void Remove();
    }
}