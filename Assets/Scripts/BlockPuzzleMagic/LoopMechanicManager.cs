using UnityEngine;

namespace BlockPuzzleMagic
{
    public class LoopMechanicManager : MonoSingletonSelfGenerating<BlockPuzzleMagic.LoopMechanicManager>
    {
        // Fields
        private System.Collections.Generic.List<System.Collections.Generic.List<int>> loopList;
        
        // Properties
        public System.Collections.Generic.List<System.Collections.Generic.List<int>> LoopList { get; }
        
        // Methods
        public System.Collections.Generic.List<System.Collections.Generic.List<int>> get_LoopList()
        {
        
        }
        public BlockPuzzleMagic.LevelMechanicMetadata GetMetadata()
        {
            if(new BlockPuzzleMagic.LevelMechanicMetadata() != 0)
            {
                    typeof(BlockPuzzleMagic.LevelMechanicMetadata).__il2cppRuntimeField_8 = 301;
            }
            else
            {
                    mem[8] = 301;
            }
            
            int val_2 = UnityEngine.Random.Range(min:  0, max:  1000);
            Add(key:  1274842704, value:  13152256);
        }
        public void SetupLoops(BlockPuzzleMagic.GridLayout gridLayout, BlockPuzzleMagic.LevelMechanicMetadata mechRef)
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_24;
            var val_25;
            var val_27;
            if((mechRef.mechanicData.ContainsKey(key:  1274842704)) != false)
            {
                    object val_2 = mechRef.mechanicData.Item[1274842704];
                string val_3 = mechRef.mechanicData.ToString();
                if((System.Int32.TryParse(s:  mechRef.mechanicData, result: out  int val_4 = 1274999528)) != false)
            {
                    UnityEngine.Random.InitState(seed:  0);
            }
            
            }
            
            val_24 = null;
            val_24 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            val_25 = 0;
            goto label_7;
            label_14:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_25)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + 0;
            if(((0 + 0) + 16 + 12) >= 0)
            {
                    EnumerableExtentions.SetOrAdd<System.Int32, System.Object>(dic:  78753792, key:  (0 + 0) + 16 + 8, newValue:  (0 + 0) + 16);
                EnumerableExtentions.SetOrAdd<System.Int32, System.Boolean>(dic:  78753792, key:  (0 + 0) + 16 + 8, newValue:  false);
            }
            
            val_24 = val_24;
            val_25 = 1;
            label_7:
            if(val_25 < (new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>()))
            {
                goto label_14;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_9 = GetEnumerator();
            label_34:
            if(0.MoveNext() == false)
            {
                goto label_16;
            }
            
            if(Item[0] == true)
            {
                goto label_34;
            }
            
            set_Item(key:  0, value:  true);
            System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>();
            Add(item:  0);
            System.TimeType val_14 = Item[0];
            var val_15 = (gridLayout + 12 + 12) - 1;
            label_31:
            System.TimeType val_16 = Item[1085059232];
            Add(item:  1085059232);
            val_15 = val_15 - 1;
            set_Item(key:  1085059232, value:  true);
            goto label_31;
            label_16:
            0.Dispose();
            val_27 = 0;
            mem[1152921514471793148] = null;
        }
        public LoopMechanicManager()
        {
        
        }
    
    }

}
