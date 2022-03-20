using UnityEngine;

namespace RestaurantRivals
{
    public class RESSymbol
    {
        // Fields
        public const string Coin = "coin";
        public const string Bag = "bag";
        public const string Attack = "attack";
        public const string Raid = "raid";
        public const string Shield = "shield";
        public const string Spin = "spin";
        public const string EventSymbol = "evtsym";
        private static System.Collections.Generic.List<string> ordered_Default;
        private static System.Collections.Generic.List<string> ordered_WithEventSymbol;
        private static System.Collections.Generic.List<string> currentOrdered;
        public static System.Collections.Generic.Dictionary<string, string> debugTxt;
        
        // Properties
        public static System.Collections.Generic.List<string> ordered { get; }
        
        // Methods
        public static System.Collections.Generic.List<string> get_ordered()
        {
            null = null;
        }
        public static string GetRandomSymbol()
        {
            var val_3;
            var val_3 = 25709646;
            val_3 = 9915896 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = RandomSet.singleInRange(lowest:  0, highest:  (RestaurantRivals.RESSymbol.currentOrdered + 12) - 1);
            if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = RestaurantRivals.RESSymbol.currentOrdered + 8;
            val_4 = val_4 + (val_2 << 2);
        }
        public static void IncludeEventSymbols(bool includeSymbols)
        {
            var val_2;
            var val_3;
            val_2 = null;
            if(includeSymbols != false)
            {
                    val_2 = null;
                val_3 = 1152921505036615684;
            }
            else
            {
                    val_2 = null;
            }
            
            val_2 = null;
            RestaurantRivals.RESSymbol.currentOrdered = RestaurantRivals.RESSymbol.__il2cppRuntimeField_static_fields;
        }
        public RESSymbol()
        {
        
        }
        private static RESSymbol()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_1 != 0)
            {
                    Add(item:  569027824);
            }
            else
            {
                    Add(item:  569027824);
            }
            
            Add(item:  569027904);
            if(val_1 != 0)
            {
                    Add(item:  249556880);
            }
            else
            {
                    Add(item:  249556880);
            }
            
            Add(item:  -1202791792);
            if(val_1 != 0)
            {
                    Add(item:  569027984);
            }
            else
            {
                    Add(item:  569027984);
            }
            
            Add(item:  -1987367408);
            RestaurantRivals.RESSymbol.ordered_Default = val_1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_2 != 0)
            {
                    Add(item:  569027824);
            }
            else
            {
                    Add(item:  569027824);
            }
            
            Add(item:  569027904);
            if(val_2 != 0)
            {
                    Add(item:  249556880);
            }
            else
            {
                    Add(item:  249556880);
            }
            
            Add(item:  -1202791792);
            if(val_2 != 0)
            {
                    Add(item:  569027984);
            }
            else
            {
                    Add(item:  569027984);
            }
            
            Add(item:  -1987367408);
            Add(item:  569028064);
            RestaurantRivals.RESSymbol.ordered_WithEventSymbol = val_2;
            RestaurantRivals.RESSymbol.currentOrdered = RestaurantRivals.RESSymbol.ordered_Default;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(null != 0)
            {
                    Add(key:  569027824, value:  -1802497744);
            }
            else
            {
                    Add(key:  569027824, value:  -1802497744);
            }
            
            Add(key:  569027904, value:  1466177632);
            if(null != 0)
            {
                    Add(key:  249556880, value:  1115175264);
            }
            else
            {
                    Add(key:  249556880, value:  1115175264);
            }
            
            Add(key:  -1202791792, value:  1726048032);
            if(null != 0)
            {
                    Add(key:  569027984, value:  1009293344);
            }
            else
            {
                    Add(key:  569027984, value:  1009293344);
            }
            
            Add(key:  -1987367408, value:  651536272);
            Add(key:  569028064, value:  1472028528);
            RestaurantRivals.RESSymbol.debugTxt = null;
        }
    
    }

}
