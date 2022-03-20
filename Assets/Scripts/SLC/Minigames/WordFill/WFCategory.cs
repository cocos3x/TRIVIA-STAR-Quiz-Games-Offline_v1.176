using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WFCategory
    {
        // Fields
        public string name;
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> words;
        
        // Methods
        public WFCategory(System.Collections.Generic.List<object> data)
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_4;
            if(this == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.name = 2621443;
            val_4 = null;
            val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.words = val_4;
            if(val_4 < 2)
            {
                    return;
            }
            
            var val_6 = 5;
            do
            {
                if(val_4 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
                System.String[] val_2 = 1.Split(separator:  478563824);
                val_4 = null;
                val_4 = new System.Collections.Generic.List<ZooTile>(collection:  1);
                this.words.Add(key:  1 + 2, value:  80883712);
                val_6 = val_6 + 1;
            }
            while((1 + 1) < this.words);
        
        }
    
    }

}
