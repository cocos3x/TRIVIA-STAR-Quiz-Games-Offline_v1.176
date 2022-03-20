using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonDataManager
    {
        // Fields
        private const string PREFKEY_USED_CATEGORY = "wordballoon_used_cat";
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.List<string>>> wordDictionary;
        private static System.Collections.Generic.List<string> previouslyUsedCategories;
        
        // Methods
        private static void Load()
        {
            var val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  981726400);
            string val_2 = text;
            object val_3 = MiniJSON.Json.Deserialize(json:  981726400);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_13 = null;
            val_13 = null;
            SLC.Minigames.WordBalloon.WordBalloonDataManager.wordDictionary = null;
            if(("minigames/WordBalloons/word_categories") != 0)
            {
                    if(null == null)
            {
                goto label_32;
            }
            
            }
            
            if(("minigames/WordBalloons/word_categories") != 0)
            {
                    label_32:
            }
            
            val_14 = 0;
            Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            label_29:
            if(0.MoveNext() == false)
            {
                goto label_10;
            }
            
            val_15 = 0;
            if(65793 != 0)
            {
                    if(((mem[1768188873] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    65793 = 0;
            }
            
                val_15 = 65793;
            }
            
            val_16 = null;
            val_16 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_17 = 0;
            goto label_13;
            label_25:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(0 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = 0;
            val_18 = 0;
            val_19 = 0;
            val_13 = val_13 + 0;
            if(((0 + 0) + 16) == 0)
            {
                goto label_17;
            }
            
            val_19 = 0;
            if((((0 + 0) + 16 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    (0 + 0) + 16 = 0;
            }
            
            val_19 = (0 + 0) + 16;
            goto label_17;
            label_22:
            if(((0 + 0) + 16) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = 0;
            val_14 = val_14 + 0;
            Add(item:  (0 + 0) + 16);
            val_18 = 1;
            label_17:
            if(val_18 < 0)
            {
                goto label_22;
            }
            
            val_16 = val_16;
            Add(item:  80883712);
            val_17 = 1;
            label_13:
            if(val_17 < 0)
            {
                goto label_25;
            }
            
            val_20 = null;
            val_20 = null;
            Add(key:  1179403647, value:  80883712);
            goto label_29;
            label_10:
            0.Dispose();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_21 = null;
            val_21 = null;
            SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories = null;
            System.String[] val_11 = PlayerPrefsX.GetStringArray(key:  981728592);
            System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<System.Object>(source:  981728592);
            SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories = "wordballoon_used_cat";
        }
        public static SLC.Minigames.WordBalloon.WordBalloonWordData GetWords(int amountToGet, bool storeHistory = True)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            var val_30;
            val_18 = amountToGet;
            val_19 = null;
            val_19 = null;
            if(SLC.Minigames.WordBalloon.WordBalloonDataManager.wordDictionary == 0)
            {
                    SLC.Minigames.WordBalloon.WordBalloonDataManager.Load();
                val_19 = null;
            }
            
            val_19 = null;
            System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  SLC.Minigames.WordBalloon.WordBalloonDataManager.wordDictionary);
            val_20 = 0;
            goto label_8;
            label_17:
            val_21 = null;
            val_21 = null;
            if((SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 12) <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 8;
            val_18 = val_18 + 0;
            bool val_2 = Remove(key:  (SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 8 + 0) + 16);
            val_20 = 1;
            label_8:
            val_22 = null;
            val_22 = null;
            if(val_20 < (SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 12))
            {
                goto label_17;
            }
            
            if(null != 0)
            {
                    Dictionary.KeyCollection<TKey, TValue> val_3 = Keys;
                val_23 = null;
            }
            else
            {
                    Dictionary.KeyCollection<TKey, TValue> val_4 = Keys;
                val_23 = null;
            }
            
            object val_7 = System.Linq.Enumerable.ElementAt<System.Object>(source:  78753792, index:  UnityEngine.Random.Range(min:  0, max:  Count));
            string val_8 = Item[78753792];
            val_24 = null;
            if(val_18 >= 1)
            {
                    do
            {
                if(val_24 != 0)
            {
                    val_25 = UnityEngine.Random.Range(min:  0, max:  1085059232);
            }
            else
            {
                    val_25 = UnityEngine.Random.Range(min:  0, max:  1085059232);
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_11) << 2) + 16;
                val_27 = UnityEngine.Random.Range(min:  0, max:  (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_11) << 2) + 16 + 12);
                if( <= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Add(item:  ((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_11) << 2) + 16 + 8 + (val_13) << 2) + 16);
                (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_11) << 2) + 16.RemoveAt(index:  null);
                val_24 = val_24;
                if(0 <= 0)
            {
                    RemoveAt(index:  val_25);
            }
            
                val_18 = val_18 - 1;
            }
            while(0 != 0);
            
            }
            
            val_28 = null;
            val_28 = null;
            SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories.Add(item:  78753792);
            if((SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 12) >= 51)
            {
                    val_29 = null;
                val_29 = null;
                if(SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories != 0)
            {
                    val_24 = mem[SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 12];
                val_24 = SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories + 12;
            }
            else
            {
                    val_24 = 0;
            }
            
                SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories.RemoveRange(index:  0, count:  val_24 - 50);
            }
            
            if(storeHistory != false)
            {
                    val_30 = null;
                val_30 = null;
                T[] val_15 = SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories.ToArray();
                bool val_16 = PlayerPrefsX.SetStringArray(key:  981728592, stringArray:  SLC.Minigames.WordBalloon.WordBalloonDataManager.previouslyUsedCategories);
            }
            
            object val_17 = new System.Object();
            typeof(SLC.Minigames.WordBalloon.WordBalloonWordData).__il2cppRuntimeField_8 = val_23;
            typeof(SLC.Minigames.WordBalloon.WordBalloonWordData).__il2cppRuntimeField_C = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        public WordBalloonDataManager()
        {
        
        }
        private static WordBalloonDataManager()
        {
        
        }
    
    }

}
