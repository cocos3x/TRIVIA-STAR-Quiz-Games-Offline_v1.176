using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackDataParser
    {
        // Fields
        private static bool initialized;
        private static System.Collections.Generic.List<SLC.Minigames.Whack.WhackLevel> levels;
        
        // Methods
        public static void Initialize()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = null;
            val_11 = null;
            if(SLC.Minigames.Whack.WhackDataParser.initialized == true)
            {
                    return;
            }
            
            val_12 = 0;
            UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  1001894496);
            if(("minigames/whack/levels") != 0)
            {
                    val_13 = null;
                if(null != val_13)
            {
                    val_13 = null;
            }
            
                val_12 = 0;
                if(null != val_13)
            {
                    "minigames/whack/levels" = 0;
            }
            
                val_12 = "minigames/whack/levels";
            }
            
            val_14 = 0;
            string val_2 = val_12.text;
            object val_3 = MiniJSON.Json.Deserialize(json:  null);
            if(val_12 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_12 = 0;
            }
            
                val_14 = val_12;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_15 = null;
            val_15 = null;
            SLC.Minigames.Whack.WhackDataParser.levels = null;
            List.Enumerator<T> val_5 = GetEnumerator();
            label_25:
            if(MoveNext() == false)
            {
                goto label_14;
            }
            
            val_16 = null;
            val_16 = null;
            string val_9 = 0.Item[-922441872];
            val_17 = 0;
            if(0 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_17 = 0;
            }
            
            SLC.Minigames.Whack.WhackLevel val_10 = new SLC.Minigames.Whack.WhackLevel(index:  val_14.IndexOf(item:  0), words:  0);
            Add(item:  452820992);
            goto label_25;
            label_14:
            Dispose();
            val_18 = null;
            val_18 = null;
            SLC.Minigames.Whack.WhackDataParser.initialized = true;
        }
        public static SLC.Minigames.Whack.WhackLevel GetWhackLevel()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            if((SLC.Minigames.Whack.WhackDataParser.levels + 12) == 0)
            {
                    val_3 = null;
                val_3 = null;
                SLC.Minigames.Whack.WhackDataParser.initialized = false;
                SLC.Minigames.Whack.WhackDataParser.Initialize();
            }
            
            val_4 = null;
            val_4 = null;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  SLC.Minigames.Whack.WhackDataParser.levels + 12);
            if((SLC.Minigames.Whack.WhackDataParser.levels + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = SLC.Minigames.Whack.WhackDataParser.levels + 8;
            val_2 = val_2 + (val_1 << 2);
            SLC.Minigames.Whack.WhackDataParser.levels.RemoveAt(index:  val_1);
        }
        public WhackDataParser()
        {
        
        }
        private static WhackDataParser()
        {
        
        }
    
    }

}
