using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Word
    {
        public Word(string w, int count)
        {
            ThisWord = w;
            Count = count;
        }
        public string ThisWord { get; set; }
        public int Count { get; set; }
    }
}
