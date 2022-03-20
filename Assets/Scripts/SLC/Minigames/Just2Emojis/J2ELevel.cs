using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class J2ELevel
    {
        // Fields
        private int levelIndex;
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Emoji> emojis;
        private System.Collections.Generic.List<char> lettersSet;
        private string answer;
        
        // Properties
        public System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Emoji> Emojis { get; }
        public System.Collections.Generic.List<char> LettersSet { get; }
        public string Answer { get; }
        public string StrippedAnswer { get; }
        
        // Methods
        public System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Emoji> get_Emojis()
        {
        
        }
        public System.Collections.Generic.List<char> get_LettersSet()
        {
        
        }
        public string get_Answer()
        {
        
        }
        public string get_StrippedAnswer()
        {
            if(this.answer != null)
            {
                    return this.answer.Replace(oldValue:  1297836560, newValue:  1098586544);
            }
            
            return this.answer.Replace(oldValue:  1297836560, newValue:  1098586544);
        }
        public J2ELevel(int index, System.Collections.Generic.List<object> emojiSet, string answer)
        {
            var val_5;
            int val_9;
            var val_10;
            char val_11;
            val_9 = index;
            this.levelIndex = val_9;
            string val_1 = answer.ToUpper();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.emojis = null;
            List.Enumerator<T> val_3 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            object val_6 = new System.Object();
            typeof(SLC.Minigames.Just2Emojis.Emoji).__il2cppRuntimeField_8 = val_5;
            this.emojis.Add(item:  454524928);
            goto label_6;
            label_3:
            Dispose();
            System.Collections.Generic.List<System.Char> val_7 = new System.Collections.Generic.List<System.Char>();
            this.lettersSet = null;
            val_10 = 0;
            System.Char[] val_8 = answer.ToCharArray();
            val_11 = answer + 16;
            goto label_8;
            label_13:
            if(val_11 != 32)
            {
                    val_9 = this.lettersSet;
                val_9.Add(item:  val_11);
            }
            
            val_11 = val_11 + 2;
            val_10 = 1;
            label_8:
            if(val_10 < (answer + 12))
            {
                goto label_13;
            }
            
            PluginExtension.Shuffle<System.Char>(list:  this.lettersSet, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            this.answer = answer;
        }
        public static int GetNumberOfLettersForIndex(int index)
        {
            if(index < 26)
            {
                    return (int)8;
            }
            
            if(index >= 76)
            {
                    8 = 12;
            }
            
            if(index < 126)
            {
                    return (int)8;
            }
            
            if(index >= 201)
            {
                    14 = 16;
            }
            
            if(index <= 300)
            {
                    return (int)8;
            }
            
            if(index <= 400)
            {
                    21 = 18;
            }
            
            return (int)8;
        }
        public static int GetNumberOfTilesForLetters(int number)
        {
            if(number < 9)
            {
                    return (int)8;
            }
            
            if(number >= 11)
            {
                    8 = 12;
            }
            
            if(number < 13)
            {
                    return (int)8;
            }
            
            if(number >= 15)
            {
                    14 = 16;
            }
            
            if(number < 17)
            {
                    return (int)8;
            }
            
            if(number < 19)
            {
                    21 = 18;
            }
            
            return (int)8;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.answer;
            string val_1 = MiniJSON.Json.Serialize(obj:  this.lettersSet);
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.lettersSet;
            string val_2 = MiniJSON.Json.Serialize(obj:  this.emojis);
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.emojis;
            string val_3 = System.String.Format(format:  1037220912, args:  472754880);
        }
    
    }

}
