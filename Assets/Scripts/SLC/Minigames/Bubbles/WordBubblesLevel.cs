using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesLevel
    {
        // Fields
        private System.Collections.Generic.HashSet<string> <RequiredWords>k__BackingField;
        private System.Collections.Generic.List<string> <Elements>k__BackingField;
        private string <Category>k__BackingField;
        private SLC.Minigames.Bubbles.WordBubblesLevelData <LevelData>k__BackingField;
        
        // Properties
        public System.Collections.Generic.HashSet<string> RequiredWords { get; set; }
        public System.Collections.Generic.List<string> Elements { get; set; }
        public string Category { get; set; }
        public SLC.Minigames.Bubbles.WordBubblesLevelData LevelData { get; set; }
        
        // Methods
        public System.Collections.Generic.HashSet<string> get_RequiredWords()
        {
        
        }
        private void set_RequiredWords(System.Collections.Generic.HashSet<string> value)
        {
            this.<RequiredWords>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_Elements()
        {
        
        }
        private void set_Elements(System.Collections.Generic.List<string> value)
        {
            this.<Elements>k__BackingField = value;
        }
        public string get_Category()
        {
        
        }
        private void set_Category(string value)
        {
            this.<Category>k__BackingField = value;
        }
        public SLC.Minigames.Bubbles.WordBubblesLevelData get_LevelData()
        {
        
        }
        private void set_LevelData(SLC.Minigames.Bubbles.WordBubblesLevelData value)
        {
            this.<LevelData>k__BackingField = value;
        }
        public bool IsQulify(string word)
        {
            if((this.<RequiredWords>k__BackingField.Contains(item:  word)) == false)
            {
                    return (bool)0;
            }
            
            bool val_2 = this.<RequiredWords>k__BackingField.Remove(item:  word);
            0 = 1;
            return (bool)0;
        }
        public bool IsComplete()
        {
            if((this.<RequiredWords>k__BackingField) != 0)
            {
                    return false;
            }
            
            return false;
        }
        public WordBubblesLevel(SLC.Minigames.Bubbles.WordBubblesLevelData levelData, string[] words)
        {
            SLC.Minigames.Bubbles.WordBubblesLevelData val_6;
            var val_7;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8;
            var val_9;
            var val_10;
            val_6 = levelData;
            val_7 = 0;
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_1 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.<RequiredWords>k__BackingField = null;
            val_8 = null;
            val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<LevelData>k__BackingField = val_6;
            this.<Elements>k__BackingField = val_8;
            goto label_1;
            label_12:
            val_8 = this.<RequiredWords>k__BackingField;
            bool val_3 = val_8.Add(item:  477709520);
            if((System.String.op_Equality(a:  477709520, b:  -940556144)) == false)
            {
                goto label_4;
            }
            
            this.<Elements>k__BackingField.Add(item:  -1927029248);
            val_6 = this.<Elements>k__BackingField;
            val_9 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_10 = "EEN";
            goto label_7;
            label_4:
            if((System.String.op_Equality(a:  477709520, b:  -940555888)) == false)
            {
                goto label_8;
            }
            
            this.<Elements>k__BackingField.Add(item:  -1927027088);
            val_6 = this.<Elements>k__BackingField;
            val_9 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_10 = "UE";
            label_7:
            val_6.Add(item:  976324832);
            label_8:
            val_7 = 1;
            label_1:
            if(val_7 < val_6)
            {
                goto label_12;
            }
            
            this.<Category>k__BackingField = "color";
        }
        public WordBubblesLevel(SLC.Minigames.Bubbles.WordBubblesLevelData levelData, SLC.Minigames.Bubbles.WordBubblesCategory category)
        {
            SLC.Minigames.Bubbles.WordBubblesLevel val_29;
            SLC.Minigames.Bubbles.WordBubblesCategory val_30;
            SLC.Minigames.Bubbles.WordBubblesLevelData val_31;
            var val_32;
            var val_33;
            var val_34;
            string val_35;
            int val_36;
            var val_37;
            var val_38;
            var val_39;
            int val_40;
            val_29 = this;
            val_30 = val_1;
            val_31 = levelData;
            val_1 = new System.Object();
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_2 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.<RequiredWords>k__BackingField = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<LevelData>k__BackingField = val_31;
            this.<Elements>k__BackingField = null;
            if((levelData.<FragmentsCount>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            val_32 = 1152921511610303840;
            label_42:
            if((levelData.<FragmentsCount>k__BackingField) != 1)
            {
                goto label_3;
            }
            
            do
            {
                System.Collections.Generic.List<System.String> val_4 = category.<LetterWordsDic>k__BackingField.Item[3];
                val_31 = category.<LetterWordsDic>k__BackingField;
                if((category.<LetterWordsDic>k__BackingField) != 0)
            {
                    val_33 = val_31;
                val_34 = UnityEngine.Random.Range(min:  0, max:  3);
            }
            else
            {
                    val_33 = 12;
                val_34 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
                if(val_33 <= val_34)
            {
                    var val_31 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_31 = val_31 + (val_34 << 2);
                val_35 = mem[(0 + (val_6) << 2) + 16];
                val_35 = (0 + (val_6) << 2) + 16;
            }
            while((this.<RequiredWords>k__BackingField.Contains(item:  val_35)) == true);
            
            if((this.<Elements>k__BackingField) == 0)
            {
                goto label_11;
            }
            
            val_36 = UnityEngine.Random.Range(min:  0, max:  val_35);
            goto label_12;
            label_3:
            if((levelData.<FragmentsCount>k__BackingField) <= 2)
            {
                goto label_28;
            }
            
            do
            {
                int val_9 = UnityEngine.Random.Range(min:  3, max:  9);
                System.Collections.Generic.List<System.String> val_10 = category.<LetterWordsDic>k__BackingField.Item[val_9];
                val_31 = category.<LetterWordsDic>k__BackingField;
                if((category.<LetterWordsDic>k__BackingField) != 0)
            {
                    val_37 = val_31;
                val_38 = UnityEngine.Random.Range(min:  0, max:  val_9);
            }
            else
            {
                    val_37 = 12;
                val_38 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
                if(val_37 <= val_38)
            {
                    var val_32 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = val_32 + (val_38 << 2);
                val_35 = mem[(0 + (val_12) << 2) + 16];
                val_35 = (0 + (val_12) << 2) + 16;
            }
            while((this.<RequiredWords>k__BackingField.Contains(item:  val_35)) == true);
            
            val_39 = 0;
            val_40 = levelData.<FragmentsCount>k__BackingField;
            goto label_21;
            label_35:
            int val_34 = (0 + (val_17) << 2) + 16 + 8;
            val_34 = val_34 - (this.<Elements>k__BackingField);
            if(val_34 <= 2)
            {
                    UnityEngine.Random.Range(min:  2, max:  4) = val_34;
            }
            
            val_31 = UnityEngine.Random.Range(min:  0, max:  4);
            string val_22 = val_35.Substring(startIndex:  this.<Elements>k__BackingField, length:  UnityEngine.Random.Range(min:  2, max:  4));
            this.<Elements>k__BackingField.Insert(index:  val_31, item:  val_35 = (0 + (val_17) << 2) + 16);
            val_39 = (UnityEngine.Random.Range(min:  2, max:  4)) + (this.<Elements>k__BackingField);
            val_40 = ((0 + (val_17) << 2) + 16 + 8) - 1;
            val_29 = val_29;
            val_30 = val_30;
            label_21:
            var val_35 = (0 + (val_17) << 2) + 16 + 8;
            val_35 = val_35 - val_39;
            if(val_35 > 0)
            {
                goto label_35;
            }
            
            goto label_36;
            label_11:
            val_36 = UnityEngine.Random.Range(min:  0, max:  0);
            label_12:
            this.<Elements>k__BackingField.Insert(index:  val_36, item:  val_35);
            val_40 = 0;
            goto label_37;
            label_36:
            val_32 = 1152921511610303840;
            label_37:
            bool val_30 = Add(item:  val_35);
            if( > 0)
            {
                goto label_42;
            }
            
            label_2:
            mem[1152921514173358208] = category.<Category>k__BackingField;
        }
    
    }

}
