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
            if (position > fileContent.Count) {return false;}
            else
            {
                position ++;
                Console.WriteLine(position);
                Console.ReadKey();
                while (fileContent[position]== " ")
                {
                    position++;
                    Console.WriteLine(position);
                    Console.ReadKey();
                }
                return true;
            }
        }
        public string MoveNext()
        {
            string temporary = "";
            while (fileContent[position]!= " " && position < fileContent.Count)
            {
                temporary += fileContent[position];
                Console.WriteLine(temporary);
                Console.ReadKey();
                position++;
            }
                  
            return temporary;
            
        }
        public void Remove()
        {
            position = -1;
        }
    }
}