using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollection
    {
        // Fields
        public const int CollectionSize = 16;
        public int imageSetIndex;
        public string name;
        public int[] itemIndexes;
        public int[] itemProgression;
        public bool collected;
        
        // Methods
        public bool IsCompleted()
        {
            int val_1 = this.CollectedItems();
            val_1 = val_1 - 16;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public int CollectedItems()
        {
            var val_1;
            var val_2;
            val_1 = 0;
            val_2 = 0;
            goto label_0;
            label_4:
            val_1 = 1;
            int val_1 = this.itemProgression[val_1];
            if(val_1 > 0)
            {
                    val_2 = 1;
            }
            
            label_0:
            if(val_1 < val_1)
            {
                goto label_4;
            }
            
            return (int)val_2;
        }
        public int CoinReward()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = 0;
            SLC.MatchyPics.MPIEcon val_2 = Econ;
            if((public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance()) != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_11:
            val_6 = 1;
            label_5:
            if(val_6 < (System.Math.Max(val1:  0, val2:  this.itemProgression[val_6] - 1)))
            {
                goto label_11;
            }
            
            return (int)(val_4 + public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_64);
        }
        public int GetItems(int itemIndex)
        {
            int val_1 = System.Array.IndexOf<System.Int32>(array:  this.itemIndexes, value:  itemIndex);
            if(val_1 < 0)
            {
                    return 0;
            }
            
            return (int)this.itemProgression[val_1];
        }
        public int GetRandomItemIndex()
        {
            return (int)this.itemIndexes[UnityEngine.Random.Range(min:  0, max:  15)];
        }
        public override string ToString()
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            val_4 = 4;
            goto label_1;
            label_8:
            Add(key:  this.itemIndexes[0], value:  this.itemProgression[0]);
            val_4 = 5;
            label_1:
            if((val_4 - 4) < null)
            {
                goto label_8;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.name;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            string val_3 = PrettyPrint.printJSON(obj:  78753792, types:  false, singleLineOutput:  false);
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            string val_4 = System.String.Format(format:  741175632, args:  472754880);
        }
        public System.Collections.Generic.Dictionary<string, object> Serialize()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1545439648, value:  this.itemProgression);
            Add(key:  -1584759760, value:  8945664);
        }
        public void Deserialize(System.Collections.Generic.Dictionary<string, object> obj)
        {
            var val_7;
            int val_8;
            var val_9;
            object val_1 = obj.Item[-1545439648];
            val_7 = 0;
            if(obj != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    obj = 0;
            }
            
                val_7 = obj;
            }
            
            val_9 = 4;
            goto label_4;
            label_10:
            if(obj <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = System.Int32.Parse(s:  2621443);
            this.itemProgression[0] = val_8;
            val_9 = 5;
            label_4:
            if((val_9 - 4) < 0)
            {
                goto label_10;
            }
            
            object val_4 = obj.Item[-1584759760];
            string val_5 = obj.ToString();
            bool val_7 = System.Boolean.TryParse(value:  obj, result: out  this.collected);
        }
        public MPICollection()
        {
        
        }
    
    }

}
