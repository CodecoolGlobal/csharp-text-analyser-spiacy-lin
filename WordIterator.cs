using System;

namespace csharp_text_analyser_spiacy_lin
{
    class WordIterator : Iterator
    {
        
        private int position;
        FileContent fileContent;
        // constructor
        public WordIterator(FileContent fc)
        {
            this.fileContent = fc;
            Remove();
        }               
        // metoda sprawdza czy jest nastepny element kolekcji
        public bool HasNext()
        {
            position++;
            return position < fileContent.Count;
        }
        public string MoveNext()
        {
            if (position <fileContent.Count)
            {
                return fileContent[position];
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public void Remove()
        {
            position = -1;
        }
    }
}