using UnityEngine;

namespace SLC.Minigames.WordMemory
{
    public class WordMemoryLevel
    {
        // Fields
        public int level;
        public int lives;
        public int pairs;
        
        // Methods
        public WordMemoryLevel(System.Collections.Generic.Dictionary<string, object> dict)
        {
            object val_1 = dict.Item[-1987496192];
            string val_2 = dict.ToString();
            this.level = System.Int32.Parse(s:  dict);
            object val_4 = dict.Item[-771665344];
            string val_5 = dict.ToString();
            this.lives = System.Int32.Parse(s:  dict);
            object val_7 = dict.Item[937415120];
            string val_8 = dict.ToString();
            this.pairs = System.Int32.Parse(s:  dict);
        }
    
    }

}
