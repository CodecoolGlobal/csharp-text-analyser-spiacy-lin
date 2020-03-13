using System;

namespace csharp_text_analyser_spiacy_lin
{
    class CharIterator :  Iterator
    {
        private int position;
        private FileContent fileContent;
        // constructor
        public CharIterator(FileContent fc)
        {
            this.fileContent = fc;
            Remove();
        }
        // methods
        public bool HasNext()
        {
            position++;
            return position < fileContent.Count;
        }
        public string MoveNext()
        {
            if (position<fileContent.Count)
            {
                while (fileContent[position] == " " || fileContent[position] == "\n")
                {
                   position++;
                }
                return fileContent[position]; 
            }
            else
            {
                return "";
            }
        }
        public void Remove()
        {
            position = -1;
        }
    }
}