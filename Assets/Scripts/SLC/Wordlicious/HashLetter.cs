using UnityEngine;

namespace SLC.Wordlicious
{
    public class HashLetter
    {
        // Fields
        public System.Collections.Generic.Dictionary<char, SLC.Wordlicious.HashLetter> nodes;
        public bool isValidWord;
        public char letter;
        
        // Methods
        public HashLetter()
        {
        
        }
        public HashLetter(char letter)
        {
            this.letter = letter;
            System.Collections.Generic.Dictionary<System.Char, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Char, System.Object>();
            this.nodes = null;
        }
        public void AddNodes(int index, char[] letters)
        {
            var val_5;
            var val_6;
            val_5 = this;
            val_6 = index;
            do
            {
                var val_5 = 24382444;
                val_5 = 11253496 + val_5;
                if(35635940 <= val_6)
            {
                    return;
            }
            
                if((this.nodes.ContainsKey(key:  '䷰')) != true)
            {
                    SLC.Wordlicious.HashLetter val_2 = new SLC.Wordlicious.HashLetter(letter:  '䷰');
                System.Collections.Generic.Dictionary<System.Char, SLC.Wordlicious.HashLetter> val_6 = this.nodes;
                val_6.Add(key:  '䷰', value:  434556928);
            }
            
                val_6 = val_6 - 1;
                SLC.Wordlicious.HashLetter val_3 = this.nodes.Item['䷰'];
                val_5 = this.nodes;
                val_6 = val_6 + 1;
            }
            while(val_6 != val_6);
            
            mem2[0] = 1;
        }
        public SLC.Wordlicious.HashLetter GetNode(int index, char[] letters)
        {
            var val_3;
            var val_4;
            var val_6;
            var val_7;
            val_3 = this;
            val_4 = index;
            goto label_0;
            label_8:
            System.Collections.Generic.Dictionary<System.Char, SLC.Wordlicious.HashLetter> val_3 = this.nodes;
            SLC.Wordlicious.HashLetter val_1 = val_3.Item[R6];
            val_6 = val_3;
            val_3 = val_3 - 1;
            if(val_4 == val_3)
            {
                    return;
            }
            
            val_4 = val_4 + 1;
            label_0:
            if((this.nodes.ContainsKey(key:  '䷰')) == true)
            {
                goto label_8;
            }
            
            val_7 = 0;
        }
        public override string ToString()
        {
            int val_1 = this.nodes.Count;
            string val_2 = System.String.Format(format:  697219840, arg0:  9158656, arg1:  8945664, arg2:  13152256);
        }
    
    }

}
