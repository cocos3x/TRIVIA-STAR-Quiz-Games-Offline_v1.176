using UnityEngine;

namespace SLC.Minigames.WordMemory
{
    public class WordMemoryParser
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, string[]> wordDataSource;
        private SLC.Minigames.WordMemory.WordMemoryLevel[] levelDataSource;
        
        // Methods
        public WordMemoryParser()
        {
            var val_8;
            SLC.Minigames.WordMemory.WordMemoryLevel val_15;
            var val_16;
            float val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            mem[1152921514133910680] = null;
            object val_2 = UnityEngine.Resources.Load<System.Object>(path:  937100720);
            string val_3 = text;
            object val_4 = MiniJSON.Json.Deserialize(json:  937100720);
            if(("minigames/WordMemory/word_categories") != 0)
            {
                    if(null == null)
            {
                goto label_33;
            }
            
            }
            
            if(("minigames/WordMemory/word_categories") != 0)
            {
                    label_33:
            }
            
            val_15 = 0;
            Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            val_17 = 1152921510046813136;
            label_19:
            if(0.MoveNext() == false)
            {
                goto label_8;
            }
            
            val_18 = 0;
            if(val_8 != 0)
            {
                    if(((val_8 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_8 = 0;
            }
            
                val_18 = val_8;
            }
            
            val_19 = 0;
            goto label_11;
            label_16:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = 0;
            val_17 = val_17 + 0;
            Add(item:  (0 + 0) + 16);
            val_19 = 1;
            label_11:
            if(val_19 < 0)
            {
                goto label_16;
            }
            
            T[] val_10 = ToArray();
            Add(key:  0, value:  80883712);
            goto label_19;
            label_8:
            0.Dispose();
            object val_11 = UnityEngine.Resources.Load<System.Object>(path:  937100864);
            string val_12 = text;
            object val_13 = MiniJSON.Json.Deserialize(json:  937100864);
            if(("minigames/WordMemory/WordMemory_levels") == 0)
            {
                goto label_22;
            }
            
            val_20 = "minigames/WordMemory/WordMemory_levels";
            if(null == null)
            {
                goto label_23;
            }
            
            label_22:
            val_20 = 0;
            label_23:
            mem[1152921514133910684] = null;
            if(0 < 1)
            {
                    return;
            }
            
            val_17 = 1152921505055834112;
            do
            {
                val_16 = 0;
                if(0 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = null;
                val_21 = 0;
                if(2621443 != 0)
            {
                    if(((mem[406885476] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    2621443 = 0;
            }
            
                val_21 = 2621443;
            }
            
                val_15 = new SLC.Minigames.WordMemory.WordMemoryLevel(dict:  0);
                typeof(SLC.Minigames.WordMemory.WordMemoryLevel[]).__il2cppRuntimeField_10 = val_15;
                var val_15 = 4 + 1;
            }
            while((4 - 3) < 0);
        
        }
        public SLC.Minigames.WordMemory.WordMemoryLevel GetWordMemoryLevelData(int level)
        {
            SLC.Minigames.WordMemory.WordMemoryLevel val_1 = this.levelDataSource[level];
        }
    
    }

}
