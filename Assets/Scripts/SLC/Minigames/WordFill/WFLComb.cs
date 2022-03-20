using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WFLComb
    {
        // Fields
        private int size;
        private System.Collections.Generic.List<int> wordLengthCounts;
        private System.Collections.Generic.List<string> buildDirectives;
        
        // Methods
        public WFLComb(string data)
        {
            int val_10;
            var val_11;
            System.Collections.Generic.List<System.String> val_12;
            string val_3 = data;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.wordLengthCounts = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.buildDirectives = null;
            val_3 = new System.Object();
            var val_13 = 11;
            do
            {
                this.wordLengthCounts.Add(item:  0);
                val_13 = val_13 - 1;
            }
            while(this.wordLengthCounts != 0);
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_4 = val_3.Split(separator:  478563824);
            val_10 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 43;
            val_11 = 0;
            System.String[] val_5 = Split(separator:  478563824);
            val_12 = null;
            if((System.Linq.Enumerable.Count<WGEventHandler>(source:  val_3)) < 2)
            {
                    return;
            }
            
            val_10 = 1152921510046813136;
            do
            {
                val_12 = this.buildDirectives;
                val_12.Add(item:  5 - 4);
                var val_11 = 5 + 1;
            }
            while((5 - 3) < (System.Linq.Enumerable.Count<WGEventHandler>(source:  val_3)));
        
        }
        public bool CanSupport(SLC.Minigames.WordFill.WFCategory cat)
        {
            System.Collections.Generic.List<System.Int32> val_2;
            var val_3;
            var val_3 = 4;
            label_10:
            val_2 = this.wordLengthCounts;
            int val_1 = val_3 - 4;
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 < 1)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<System.String> val_2 = cat.words.Item[val_1];
            if(cat.words <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(cat.words < 2621443)
            {
                goto label_9;
            }
            
            label_3:
            val_3 = val_3 + 1;
            if(val_1 < 10)
            {
                goto label_10;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_9:
            val_3 = 0;
            return (bool)val_3;
        }
        public SLC.Minigames.WordFill.WordFillLevel CreateLevel(SLC.Minigames.WordFill.WFCategory cat, System.Collections.Generic.Dictionary<string, SLC.Minigames.WordFill.WFLShapeDef> shapeDefs)
        {
            var val_25;
            var val_26;
            System.Collections.Generic.List<System.String> val_27;
            System.Collections.Generic.Dictionary<System.String, SLC.Minigames.WordFill.WFLShapeDef> val_28;
            var val_29;
            var val_30;
            SLC.Minigames.WordFill.WordFillLevel val_1 = null;
            val_25 = val_1;
            val_1 = new SLC.Minigames.WordFill.WordFillLevel(size:  this.size);
            SLC.Minigames.WordFill.WFLComb val_25 = 1152921514151520383;
            int val_2 = RandomSet.singleInRange(lowest:  0, highest:  954738815);
            if(val_2 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_2 << 2);
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            val_26 = 0;
            System.String[] val_3 = (1152921514151520383 + (val_2) << 2).buildDirectives.Split(separator:  478563824);
            val_27 = (1152921514151520383 + (val_2) << 2).buildDirectives;
            goto label_8;
            label_48:
            string val_5 = System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg.Chars[0].ToString();
            int val_6 = System.Int32.Parse(s:  954726778);
            System.TimeType val_7 = cat + 12.Item[val_6];
            System.TimeType val_8 = cat + 12.Item[val_6];
            int val_10 = RandomSet.singleInRange(lowest:  0, highest:  (cat + 12 + 12) - 1);
            if((cat + 12 + 12) <= val_10)
            {
                goto label_18;
            }
            
            label_29:
            var val_26 = cat + 12 + 8;
            val_26 = val_26 + (val_10 << 2);
            val_25 = val_25;
            if((typeof(SLC.Minigames.WordFill.WordFillLevel).__il2cppRuntimeField_14.Contains(item:  (cat + 12 + 8 + (val_10) << 2) + 16)) == false)
            {
                goto label_21;
            }
            
            System.TimeType val_12 = cat + 12.Item[val_6];
            System.TimeType val_13 = cat + 12.Item[val_6];
            if((cat + 12 + 12) > (RandomSet.singleInRange(lowest:  0, highest:  (cat + 12 + 12) - 1)))
            {
                goto label_29;
            }
            
            label_18:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_29;
            label_21:
            string val_16 = System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg.Substring(startIndex:  0, length:  2);
            val_28 = shapeDefs;
            if(val_28 == 0)
            {
                    val_28 = shapeDefs;
            }
            
            string val_17 = val_28.Item[System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg];
            SLC.Minigames.WordFill.WFLShape val_18 = val_28.GenerateShape(word:  (cat + 12 + 8 + (val_10) << 2) + 16);
            val_29 = 2;
            if(val_25 != 0)
            {
                    AddShape(shape:  val_28);
            }
            else
            {
                    AddShape(shape:  val_28);
            }
            
            typeof(SLC.Minigames.WordFill.WordFillLevel).__il2cppRuntimeField_14.Add(item:  (cat + 12 + 8 + (val_10) << 2) + 16);
            val_27 = (1152921514151520383 + (val_2) << 2).buildDirectives;
            val_26 = 1;
            label_8:
            if(val_26 < ((1152921514151520383 + (val_2) << 2).buildDirectives + 12))
            {
                goto label_48;
            }
            
            int val_20 = RandomSet.singleInRange(lowest:  0, highest:  2);
            if(val_20 == 1)
            {
                goto label_51;
            }
            
            if(val_20 != 2)
            {
                goto label_52;
            }
            
            if(val_25 != 0)
            {
                goto label_54;
            }
            
            goto label_54;
            label_51:
            label_54:
            label_52:
            if(val_25 != 0)
            {
                
            }
            else
            {
                    val_30 = 0;
            }
            
            int val_22 = RandomSet.singleInRange(lowest:  0, highest:  3);
            if(val_22 < 1)
            {
                    return;
            }
            
            int val_23 = val_22 + 1;
            do
            {
                val_23 = val_23 - 1;
            }
            while(val_23 >= 2);
        
        }
    
    }

}
