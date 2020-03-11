using System;

namespace csharp_text_analyser_spiacy_lin
{
    class CharIterator :  Iterator
    {
        private FileContent fileContent;
        // constructor
        public CharIterator(FileContent fc)
        {
            this.fileContent = fc;
        }
        // methods
        public bool HasNext()
        {
            return true;
        }
        public string MoveNext()
        {
            return fileContent[0];
        }
        public void Remove()
        {

        }
    }
}