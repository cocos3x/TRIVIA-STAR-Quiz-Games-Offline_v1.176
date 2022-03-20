using UnityEngine;

namespace RestaurantRivals
{
    public class Map
    {
        // Fields
        public System.Collections.Generic.List<System.Collections.Generic.List<RestaurantRivals.MapItem>> area;
        public int StarCollected;
        
        // Properties
        public bool ContainsDamagedObjects { get; }
        public bool ContainsAttackableObjects { get; }
        public int NumOfBrokenRestaurantItems { get; }
        public int FirstBrokenItem { get; }
        
        // Methods
        public Map(System.Collections.Generic.List<RestaurantRivals.MapItem> initialAreaItems)
        {
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = initialAreaItems;
            val_1 = new System.Object();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.area = null;
            Add(item:  val_1);
        }
        public System.Collections.Generic.List<RestaurantRivals.MapItem> GetRestaurantData()
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
        public void ResetRestaurantData()
        {
            System.Collections.Generic.List<System.Collections.Generic.List<RestaurantRivals.MapItem>> val_1;
            var val_2;
            val_1 = this.area;
            if(true == 0)
            {
                    return;
            }
            
            val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.StarCollected = 0;
        }
        public bool get_ContainsDamagedObjects()
        {
            var val_4;
            System.Predicate<RestaurantRivals.MapItem> val_6;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            if(this == 0)
            {
                    return false;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = Map.<>c.<>9__6_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(593845760));
                Map.<>c.<>9__6_0 = val_6;
            }
            
            if((this.FindIndex(match:  8040448)) > 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_ContainsAttackableObjects()
        {
            var val_4;
            System.Predicate<RestaurantRivals.MapItem> val_6;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            if(this == 0)
            {
                    return false;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = Map.<>c.<>9__8_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(593960832));
                Map.<>c.<>9__8_0 = val_6;
            }
            
            if((this.FindIndex(match:  8040448)) > 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public int get_NumOfBrokenRestaurantItems()
        {
            var val_4;
            System.Predicate<RestaurantRivals.MapItem> val_6;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            if(this == 0)
            {
                    return 0;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = Map.<>c.<>9__10_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(594073856));
                Map.<>c.<>9__10_0 = val_6;
            }
            
            System.Collections.Generic.List<T> val_3 = this.FindAll(match:  8040448);
            if(this != 0)
            {
                    return (int)this.StarCollected;
            }
            
            return (int)this.StarCollected;
        }
        public int get_FirstBrokenItem()
        {
            var val_2;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            val_2 = 0;
            goto label_1;
            label_6:
            if(this <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = 1;
            label_1:
            if(val_2 < this.StarCollected)
            {
                goto label_6;
            }
            
            return 0;
        }
        public int CurrentRestaurantStage(bool includeDamagedObjects = True)
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            val_4 = 0;
            val_5 = 4;
            goto label_1;
            label_11:
            if(this <= 35634402)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Inequality(a:  this.area, b:  -1402413584)) != true)
            {
                    if(this.StarCollected <= 35634402)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.area != 0)
            {
                    if(this.StarCollected <= 35634402)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_5 = static_value_021FBCF2;
                val_5 = val_5 - 2;
                if(35634402 != 0)
            {
                    val_5 = 1;
            }
            
                val_4 = val_4 + (1 | includeDamagedObjects);
            }
            
            }
            
            val_5 = 5;
            label_1:
            if((val_5 - 4) < this.StarCollected)
            {
                goto label_11;
            }
            
            return (int)val_4;
        }
        public int TotalRestaurantItemsGrowthCount()
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            val_3 = 0;
            val_4 = 0;
            goto label_1;
            label_5:
            if(this <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = System.String.op_Inequality(a:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 8, b:  -1402413584);
            val_2 = val_2 ^ 1;
            val_3 = 1;
            val_4 = val_4 + val_2;
            label_1:
            if(val_3 < this.StarCollected)
            {
                goto label_5;
            }
            
            return (int)val_4;
        }
        public System.Collections.Generic.Dictionary<string, object> Encode()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_2 = this.GetRestaurantData();
            if((this == 0) || (this.StarCollected < 1))
            {
                goto label_2;
            }
            
            label_8:
            if(this.StarCollected <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.area == 0)
            {
                goto label_4;
            }
            
            if(this.StarCollected > 0)
            {
                goto label_5;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(this.area == 0)
            {
                goto label_6;
            }
            
            label_5:
            Add(item:  this.area);
            label_4:
            var val_3 = 4 + 1;
            if((4 - 3) < this.StarCollected)
            {
                goto label_8;
            }
            
            label_2:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Add(item:  80883712);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  257740512, value:  80883712);
            Add(key:  594581248, value:  13152256);
            return;
            label_6:
        }
        public RestaurantRivals.MapItem GetRandomObjectForAttack()
        {
            var val_5;
            var val_6;
            System.Predicate<RestaurantRivals.MapItem> val_8;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            val_5 = 0;
            if(this != 0)
            {
                    35634405 = this;
                this = this.StarCollected;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = Map.<>c.<>9__16_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(594701536));
                Map.<>c.<>9__16_0 = val_8;
            }
            
            System.Collections.Generic.List<T> val_3 = this.FindAll(match:  8040448);
            if(val_8 == 0)
            {
                    return;
            }
            
            int val_4 = UnityEngine.Random.Range(min:  0, max:  val_8 = this.StarCollected);
            if(this.StarCollected <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<RestaurantRivals.MapItem>> val_5 = this.area;
            val_5 = val_5 + (val_4 << 2);
        }
        public void HackToFixAllBrokenItems()
        {
            var val_5;
            System.Predicate<RestaurantRivals.MapItem> val_7;
            var val_8;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = this.GetRestaurantData();
            if(this == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = Map.<>c.<>9__17_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Predicate<ZooTile>(object:  Map.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(594822752));
                Map.<>c.<>9__17_0 = val_7;
            }
            
            System.Collections.Generic.List<T> val_3 = this.FindAll(match:  8040448);
            val_8 = 0;
            goto label_7;
            label_11:
            if(this <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = 1;
            System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_10 = 1;
            label_7:
            if(val_8 < this.StarCollected)
            {
                goto label_11;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = false}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = true}, shields:  new System.Nullable<System.Int32>() {HasValue = false}, name:  null, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
        }
    
    }

}
