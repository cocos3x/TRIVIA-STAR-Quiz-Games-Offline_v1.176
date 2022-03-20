using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public struct WordJumbleLevel
    {
        // Fields
        private string <category>k__BackingField;
        private System.Collections.Generic.List<string> <levelWords>k__BackingField;
        
        // Properties
        public string category { get; set; }
        public System.Collections.Generic.List<string> levelWords { get; set; }
        
        // Methods
        public string get_category()
        {
        
        }
        private void set_category(string value)
        {
            this = value;
        }
        public System.Collections.Generic.List<string> get_levelWords()
        {
        
        }
        private void set_levelWords(System.Collections.Generic.List<string> value)
        {
            this.<levelWords>k__BackingField = value;
        }
        public WordJumbleLevel(string name, System.Collections.Generic.Dictionary<string, object> data, object levelSpecData)
        {
            System.Collections.Generic.IEnumerable<TSource> val_17;
            float val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_17 = data;
            this = name;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<levelWords>k__BackingField = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_18 = 1152921510392296080;
            do
            {
                string val_3 = 3.ToString();
                if((val_17.ContainsKey(key:  916461144)) != false)
            {
                    string val_5 = 3.ToString();
                string val_6 = 3.ToString();
                object val_7 = val_17.Item[916461144];
                string val_8 = val_17.ToString();
                typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
                System.String[] val_9 = val_17.Split(separator:  478563824);
                System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<System.Object>(source:  val_17);
                Add(key:  916461144, value:  val_17);
            }
            
                var val_17 = 3;
                val_17 = val_17 + 1;
            }
            while(val_17 < 8);
            
            if(levelSpecData != 0)
            {
                    val_19 = null;
                val_19 = null;
                val_20 = 0;
                val_17 = mem[levelSpecData + 180];
                val_17 = levelSpecData + 180;
                if(((levelSpecData + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_19)
            {
                    levelSpecData = 0;
            }
            
                val_20 = levelSpecData;
            }
            else
            {
                    val_20 = 0;
            }
            
            string val_11 = val_20.Item[916449088];
            typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
            val_21 = 0;
            System.String[] val_12 = val_20.Split(separator:  478563824);
            System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
            goto label_19;
            label_27:
            if(val_20 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = 0;
            val_18 = val_18 + 0;
            string val_14 = Item[(0 + 0) + 16];
            val_18 = null;
            if(val_18 != 0)
            {
                    val_17 = val_18;
                val_22 = UnityEngine.Random.Range(min:  0, max:  1085059232);
            }
            else
            {
                    val_17 = 12;
                val_22 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_17 <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Add(item:  (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_16) << 2) + 16);
            val_21 = 1;
            label_19:
            if(val_21 < 0)
            {
                goto label_27;
            }
        
        }
    
    }

}
