using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackWord
    {
        // Fields
        public string word;
        public bool incorrect;
        
        // Methods
        public WhackWord(string word, bool incorrect)
        {
            string val_1 = word;
            val_1 = new System.Object();
            this.incorrect = incorrect;
            this.word = val_1;
        }
        public override string ToString()
        {
            string val_1 = System.String.Format(format:  1002945728, arg0:  this.word, arg1:  8945664);
        }
    
    }

}
