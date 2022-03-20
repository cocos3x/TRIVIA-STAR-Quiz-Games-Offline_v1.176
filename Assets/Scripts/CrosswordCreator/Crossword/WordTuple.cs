using UnityEngine;

namespace CrosswordCreator.Crossword
{
    public class WordTuple
    {
        // Fields
        public string word;
        public int x;
        public int y;
        public int dir;
        
        // Methods
        public WordTuple(string word, int x, int y, int dir)
        {
            string val_1 = word;
            val_1 = new System.Object();
            this.word = val_1;
            this.x = x;
            this.y = y;
            this.dir = dir;
        }
    
    }

}
