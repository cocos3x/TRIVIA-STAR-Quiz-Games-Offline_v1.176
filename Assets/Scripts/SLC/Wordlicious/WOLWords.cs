using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLWords
    {
        // Fields
        private SLC.Wordlicious.HashLetter root;
        
        // Methods
        public WOLWords()
        {
            this.root = new SLC.Wordlicious.HashLetter();
        }
        public void AddWord(string word)
        {
            System.Char[] val_1 = word.ToCharArray();
            this.root.AddNodes(index:  0, letters:  word);
        }
        public SLC.Wordlicious.HashLetter GetNode(string word)
        {
            System.Char[] val_1 = word.ToCharArray();
            return this.GetNode(letters:  word);
        }
        public SLC.Wordlicious.HashLetter GetNode(char[] letters)
        {
            if(this.root != 0)
            {
                    return this.root.GetNode(index:  0, letters:  letters);
            }
            
            return this.root.GetNode(index:  0, letters:  letters);
        }
    
    }

}
