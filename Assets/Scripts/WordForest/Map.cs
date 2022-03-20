using UnityEngine;

namespace WordForest
{
    public class Map
    {
        // Fields
        public System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> area;
        
        // Properties
        public bool ContainsDamagedTrees { get; }
        
        // Methods
        public Map(System.Collections.Generic.List<WordForest.MapItem> initialAreaItems)
        {
            System.Collections.Generic.List<WordForest.MapItem> val_1 = initialAreaItems;
            val_1 = new System.Object();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.area = null;
            Add(item:  val_1);
        }
        public System.Collections.Generic.List<WordForest.MapItem> GetForestData()
        {
            if(true < 1)
            {
                    return;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public bool get_ContainsDamagedTrees()
        {
            var val_4;
            System.Predicate<WordForest.MapItem> val_6;
            System.Collections.Generic.List<WordForest.MapItem> val_1 = this.GetForestData();
            if(this == 0)
            {
                    return false;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = Map.<>c.<>9__4_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(257474528));
                Map.<>c.<>9__4_0 = val_6;
            }
            
            if((this.FindIndex(match:  8040448)) > 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public int CurrentForestGrowth(bool includeDamagedTrees = True)
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<WordForest.MapItem> val_1 = this.GetForestData();
            val_4 = 0;
            val_5 = 4;
            goto label_1;
            label_11:
            if(this <= 35634234)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = System.String.op_Inequality(a:  this.area, b:  -1402413584);
            if(val_2 != true)
            {
                    if(val_2 <= 35634234)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.area != 0)
            {
                    if(this.area <= 35634234)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_5 = static_value_021FBC4A;
                val_5 = val_5 - 2;
                if(35634234 != 0)
            {
                    val_5 = 1;
            }
            
                bool val_3 = 1 | includeDamagedTrees;
                val_4 = val_4 + val_3;
            }
            
            }
            
            val_5 = 5;
            label_1:
            if((val_5 - 4) < val_3)
            {
                goto label_11;
            }
            
            return (int)val_4;
        }
        public System.Collections.Generic.Dictionary<string, object> Encode()
        {
            twelvegigs.sweepstakes.Distribution val_5;
            System.Collections.Generic.List<WordForest.MapItem> val_2 = this.GetForestData();
            if((this == 0) || (this < 1))
            {
                goto label_2;
            }
            
            label_8:
            val_5 = 0;
            if(this <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.area == 0)
            {
                goto label_4;
            }
            
            if((public System.Void System.Collections.Generic.List<System.Object>::.ctor()) > val_5)
            {
                goto label_5;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(this.area == 0)
            {
                goto label_6;
            }
            
            label_5:
            val_5 = this.area;
            Add(item:  val_5);
            label_4:
            var val_3 = 4 + 1;
            if((4 - 3) < (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
            {
                goto label_8;
            }
            
            label_2:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Add(item:  80883712);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  257740512, value:  80883712);
            return;
            label_6:
        }
    
    }

}
