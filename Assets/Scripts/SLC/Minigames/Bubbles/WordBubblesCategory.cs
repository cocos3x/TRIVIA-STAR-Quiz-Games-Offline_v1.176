using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesCategory
    {
        // Fields
        private string <Category>k__BackingField;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> <LetterWordsDic>k__BackingField;
        
        // Properties
        public string Category { get; set; }
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> LetterWordsDic { get; set; }
        
        // Methods
        public string get_Category()
        {
        
        }
        private void set_Category(string value)
        {
            this.<Category>k__BackingField = value;
        }
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> get_LetterWordsDic()
        {
        
        }
        private void set_LetterWordsDic(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> value)
        {
            this.<LetterWordsDic>k__BackingField = value;
        }
        public WordBubblesCategory(string catName, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> letterWordsDic)
        {
            val_1 = new System.Object();
            this.<Category>k__BackingField = catName;
            this.<LetterWordsDic>k__BackingField = val_1;
        }
        public override string ToString()
        {
            string val_9;
            string val_1 = 971594768 + this.<Category>k__BackingField(this.<Category>k__BackingField);
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_8:
            var val_11 = 0;
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_5 = 0.ToString();
            string val_6 = 971594768 + 1370307136 + 971615068 + 2089622272;
            List.Enumerator<T> val_7 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            string val_10 = 971594768 + 971603056 + val_9;
            goto label_5;
            label_4:
            val_11 = val_11 + 1;
            mem2[0] = 135;
            Dispose();
            if(val_11 == 1)
            {
                goto label_8;
            }
            
            if((971615008 + ((0 + 1)) << 2) == 135)
            {
                    val_11 = val_11 >> 31;
                val_11 = ~(val_11 >> 31);
                val_11 = val_11 + val_11;
            }
            
            goto label_8;
            label_2:
            0.Dispose();
        }
    
    }

}
