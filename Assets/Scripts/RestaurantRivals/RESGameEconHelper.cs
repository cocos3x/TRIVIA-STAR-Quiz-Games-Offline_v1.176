using UnityEngine;

namespace RestaurantRivals
{
    public class RESGameEconHelper
    {
        // Methods
        public static RestaurantRivals.RESLevelDef GetRESLevelDef(int level)
        {
            var val_8;
            RESGameEconHelper.<>c__DisplayClass0_0 val_1 = new RESGameEconHelper.<>c__DisplayClass0_0();
            typeof(RESGameEconHelper.<>c__DisplayClass0_0).__il2cppRuntimeField_8 = level;
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_2 = RestaurantRivals.RESGameEcon.LevelDefs;
            System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  425132032, method:  new IntPtr(555871072));
            object val_4 = Find(match:  8040448);
            val_8 = null;
            if(424972288 != 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_6 = RestaurantRivals.RESGameEcon.LevelDefs;
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_7 = RestaurantRivals.RESGameEcon.LevelDefs;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_8 = mem[1152921509974165004];
        }
        public static RestaurantRivals.RESFTUXLevel GetNextRaidLevel(int totalSpinned)
        {
            var val_2;
            System.Collections.Generic.List<RestaurantRivals.RESFTUXLevel> val_3;
            var val_4;
            System.Collections.Generic.List<RestaurantRivals.RESFTUXLevel> val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_2 = 0;
            if(totalSpinned < 0)
            {
                    return;
            }
            
            val_3 = 1152921505031819264;
            val_4 = null;
            val_4 = null;
            val_5 = RestaurantRivals.RESGameEcon.FTUXScripts;
            if((RestaurantRivals.RESGameEcon.FTUXScripts + 12) <= totalSpinned)
            {
                    return;
            }
            
            val_6 = totalSpinned + 4;
            goto label_6;
            label_16:
            val_7 = null;
            val_7 = null;
            if((RestaurantRivals.RESGameEcon.FTUXScripts + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = mem[RestaurantRivals.RESGameEcon.FTUXScripts + 8 + ((totalSpinned + 4)) << 2];
            val_5 = RestaurantRivals.RESGameEcon.FTUXScripts + 8 + ((totalSpinned + 4)) << 2;
            if((RestaurantRivals.RESGameEcon.FTUXScripts + 8 + ((totalSpinned + 4)) << 2 + 12) == 8)
            {
                goto label_12;
            }
            
            val_6 = val_6 + 1;
            label_6:
            val_8 = null;
            val_8 = null;
            val_5 = RestaurantRivals.RESGameEcon.FTUXScripts;
            if((val_6 - 4) < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
            {
                goto label_16;
            }
            
            val_2 = 0;
            return;
            label_12:
            val_9 = null;
            val_9 = null;
            val_3 = RestaurantRivals.RESGameEcon.FTUXScripts;
            if((RestaurantRivals.RESGameEcon.FTUXScripts + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = mem[RestaurantRivals.RESGameEcon.FTUXScripts + 8 + ((totalSpinned + 4)) << 2];
            val_2 = RestaurantRivals.RESGameEcon.FTUXScripts + 8 + ((totalSpinned + 4)) << 2;
        }
        public static decimal Get199CoinPackAmount(int level)
        {
            RestaurantRivals.RESLevelDef val_1 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  R1);
            decimal val_2 = level.getCoin199Pack;
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public static int Get199SpinPackAmount(int level)
        {
            RestaurantRivals.RESLevelDef val_1 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  level);
            if(level != 0)
            {
                    return level.spins199Pack;
            }
            
            return level.spins199Pack;
        }
        public static string FormatNumberWithLimit(decimal num, decimal numLimit)
        {
            numLimit.mid = numLimit.mid;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}, d2:  new System.Decimal() {flags = numLimit.flags, hi = numLimit.hi, lo = numLimit.lo, mid = numLimit.mid})) != false)
            {
                    string val_2 = RestaurantRivals.RESGameEconHelper.GetNumberFormatInt(num:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid});
                return;
            }
            
            string val_3 = RestaurantRivals.RESGameEconHelper.GetAbbreviatedFormat(num:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid});
        }
        public static string GetNumberFormatInt(decimal num)
        {
            GameEcon val_1 = App.getGameEcon;
            string val_2 = num.flags.ToString(format:  null);
        }
        public static string GetAbbreviatedFormat(decimal num)
        {
            double val_13;
            var val_14;
            decimal val_1 = new System.Decimal(value:  num.hi);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}, d2:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid})) != false)
            {
                    val_13 = 1.34282546147021E-314;
                val_14 = "T";
            }
            else
            {
                    decimal val_3 = new System.Decimal(value:  1000000000);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}, d2:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid})) != false)
            {
                    val_13 = 0;
                val_14 = "B";
            }
            else
            {
                    decimal val_5 = new System.Decimal(value:  1000000);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}, d2:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid})) != false)
            {
                    val_13 = 0;
                val_14 = "M";
            }
            else
            {
                    decimal val_7 = new System.Decimal(value:  1000);
                bool val_8 = System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}, d2:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid});
                if(val_8 == true)
            {
                    val_13 = 0;
            }
            
                if(val_8 == true)
            {
                    val_14 = "K";
            }
            
            }
            
            }
            
            }
            
            int val_12 = num.flags;
            val_12 = val_12 / val_13;
            double val_10 = RestaurantRivals.RESGameEconHelper.RoundToSignificantDigits(d:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = num.lo, mid = num.mid}), digits:  num.hi);
            string val_11 = System.String.Format(format:  -1671354896, arg0:  10489856, arg1:  -233706608);
        }
        public static double RoundToSignificantDigits(double d, int digits)
        {
            var val_5;
            double val_4 = System.Math.Abs(digits);
            double val_5 = 1;
            val_5 = System.Math.__il2cppRuntimeField_cctor_finished + val_5;
            int val_2 = digits / System.Math.__il2cppRuntimeField_cctor_finished;
            double val_3 = System.Math.Round(value:  System.Math.Pow(x:  d, y:  null), digits:  System.Math.__il2cppRuntimeField_cctor_finished);
            val_5 = System.Math.__il2cppRuntimeField_cctor_finished * System.Math.__il2cppRuntimeField_cctor_finished;
            return (double)d;
        }
        public static decimal GetDailyBonusRewardAmount()
        {
            int val_8;
            int val_11;
            int val_13;
            int val_14;
            int val_15;
            int val_16;
            var val_27;
            var val_28;
            int val_29;
            int val_31;
            Player val_1 = App.Player;
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_3 = getBuildCost(category:  0, tier:  0);
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            RestaurantRivals.RESGameEcon val_5 = RestaurantRivals.RESGameEcon.Instance;
            decimal val_7 = System.Decimal.op_Explicit(value:  UnityEngine.Random.Range(min:  null, max:  null));
            decimal val_9 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 556782048}, d2:  new System.Decimal() {flags = val_8});
            val_28 = 12;
            decimal val_10 = new System.Decimal(value:  100);
            decimal val_12 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 556782016}, d2:  new System.Decimal() {flags = val_11, hi = val_10.flags, lo = val_10.hi, mid = val_10.lo});
            val_29 = val_13;
            decimal val_17 = new System.Decimal(value:  1000000);
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_29, hi = val_14, lo = val_15, mid = val_16}, d2:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.flags})) != false)
            {
                    val_27 = 0;
                decimal val_19 = new System.Decimal(value:  1000);
                decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 556782064, hi = val_29, lo = val_14, mid = val_15}, d2:  new System.Decimal() {flags = val_16, hi = val_19.flags, lo = val_19.hi, mid = val_19.lo});
                decimal val_21 = System.Decimal.Round(d:  new System.Decimal() {flags = 556782048});
                 = new System.Decimal(value:  1000);
                val_31 = val_22.flags;
                val_29 = val_22.hi;
                decimal val_23 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 556782016}, d2:  new System.Decimal() {flags = val_11, hi = val_31, lo = val_29, mid = val_22.lo});
                return new System.Decimal() {hi = val_26.hi, lo = val_26.lo, mid = val_26.mid};
            }
            
            val_31 = 0;
            decimal val_26 = System.Decimal.op_Explicit(value:  RestaurantRivals.RESGameEconHelper.RoundToSignificantDigits(d:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_29, hi = val_14, lo = val_15, mid = val_16}), digits:  val_29));
            return new System.Decimal() {hi = val_26.hi, lo = val_26.lo, mid = val_26.mid};
        }
        public static RestaurantRivals.RESLevelChestData GetCurrentLevelChestData()
        {
            var val_7;
            System.Predicate<RestaurantRivals.RESLevelChestData> val_9;
            var val_10;
            RestaurantRivals.RESGameEcon val_1 = RestaurantRivals.RESGameEcon.Instance;
            val_7 = null;
            val_7 = null;
            val_9 = RESGameEconHelper.<>c.<>9__9_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Predicate<RestaurantRivals.RESLevelChestData>(object:  RESGameEconHelper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(556882144));
                RESGameEconHelper.<>c.<>9__9_0 = val_9;
            }
            
            val_10 = typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_518.FindIndex(match:  8040448);
            if(val_10 != 1)
            {
                    RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
                val_9 = null;
                return new RestaurantRivals.RESLevelChestData() {restaurantLevel = (typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_518 + 8 + 0) + 16, spins = RestaurantRivals.RESGameEcon.__il2cppRuntimeField_cctor_finished};
            }
            
            RestaurantRivals.RESGameEcon val_5 = RestaurantRivals.RESGameEcon.Instance;
            val_10 = 0;
            val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return new RestaurantRivals.RESLevelChestData() {restaurantLevel = (typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_518 + 8 + 0) + 16, spins = RestaurantRivals.RESGameEcon.__il2cppRuntimeField_cctor_finished};
        }
        public static RestaurantRivals.Map CreateStartingMap()
        {
            return RestaurantRivals.RESGameEconHelper.CreateMap(level:  1, randomProgress:  false);
        }
        public static RestaurantRivals.Map CreateMap(int level, bool randomProgress = False)
        {
            var val_8;
            UnityEngine.Object val_9;
            var val_10;
            int val_11;
            val_8 = randomProgress;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  level);
            val_9 = level;
            val_10 = 0;
            val_11 = 25;
            if(val_9 != 0)
            {
                    val_11 = val_9.stages;
            }
            
            if(val_8 != false)
            {
                    val_10 = UnityEngine.Random.Range(min:  0, max:  val_11);
            }
            
            if(val_11 >= 1)
            {
                    var val_8 = 0;
                val_8 = 1152921513753891808;
                do
            {
                val_9 = null;
                val_9 = new EncodableModel();
                if(val_8 < val_10)
            {
                    0 = 1;
            }
            
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_8 = "tree";
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_C = val_8;
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_10 = 1;
                Add(item:  426889216);
                val_8 = val_8 + 1;
            }
            while(val_11 != val_8);
            
            }
            
            RestaurantRivals.Map val_7 = new RestaurantRivals.Map(initialAreaItems:  80883712);
        }
        public static RestaurantRivals.Map CreateCompletedMap(int level)
        {
            UnityEngine.Object val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  level);
            val_7 = level;
            val_8 = 0;
            val_9 = 25;
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            int val_4 = val_7.stages;
            val_9 = val_4;
            if(val_4 < 1)
            {
                goto label_5;
            }
            
            label_3:
            do
            {
                val_7 = null;
                val_7 = new EncodableModel();
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_8 = "tree";
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_C = val_8;
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_10 = 1;
                Add(item:  426889216);
                val_8 = val_8 + 1;
            }
            while(val_9 != val_8);
            
            label_5:
            RestaurantRivals.Map val_6 = new RestaurantRivals.Map(initialAreaItems:  80883712);
        }
        public static RestaurantRivals.Map CreateDummyMap(int level, int minObjects = 0, bool forAttack = False)
        {
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  level);
            val_11 = 25;
            if(level != 0)
            {
                    val_11 = level.stages;
            }
            
            val_12 = 0;
            int val_6 = UnityEngine.Mathf.Min(a:  UnityEngine.Random.Range(min:  minObjects, max:  val_11), b:  val_11);
            val_13 = 1;
            if(val_11 < 1)
            {
                goto label_7;
            }
            
            label_12:
            val_14 = 0;
            if(val_12 >= val_6)
            {
                goto label_8;
            }
            
            float val_7 = UnityEngine.Random.Range(min:  null, max:  null);
            val_14 = 1;
            if(val_12 <= val_6)
            {
                goto label_9;
            }
            
            label_8:
            val_13 = val_13 & 0;
            goto label_10;
            label_9:
            val_14 = 2;
            label_10:
            EncodableModel val_8 = new EncodableModel();
            typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_8 = "tree";
            typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_C = val_12;
            typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_10 = val_14;
            Add(item:  426889216);
            val_12 = val_12 + 1;
            if(val_11 != val_12)
            {
                goto label_12;
            }
            
            label_7:
            if(val_13 != 1)
            {
                    null = forAttack;
            }
            
            if(null != false)
            {
                    int val_9 = UnityEngine.Random.Range(min:  0, max:  val_6);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                mem2[0] = 1;
            }
            
            RestaurantRivals.Map val_10 = new RestaurantRivals.Map(initialAreaItems:  80883712);
        }
        public static RestaurantRivals.Map CreateFTUXDummyMap(int level, int progress = 0)
        {
            UnityEngine.Object val_7;
            var val_8;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  level);
            val_7 = level;
            var val_7 = 0;
            val_8 = 25;
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            int val_4 = val_7.stages;
            val_8 = val_4;
            if(val_4 < 1)
            {
                goto label_5;
            }
            
            label_3:
            do
            {
                EncodableModel val_5 = null;
                val_7 = val_5;
                val_5 = new EncodableModel();
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_8 = "tree";
                if(val_7 < progress)
            {
                    0 = 1;
            }
            
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_C = val_7;
                typeof(RestaurantRivals.MapItem).__il2cppRuntimeField_10 = 1;
                Add(item:  426889216);
                val_7 = val_7 + 1;
            }
            while(val_8 != val_7);
            
            label_5:
            RestaurantRivals.Map val_6 = new RestaurantRivals.Map(initialAreaItems:  80883712);
        }
        public static RestaurantRivals.Map ProgressMapForAttack(int level, RestaurantRivals.Map map)
        {
            int val_7;
            var val_8;
            val_7 = level;
            int val_1 = map.CurrentRestaurantStage(includeDamagedObjects:  true);
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  val_7);
            float val_4 = UnityEngine.Random.Range(min:  null, max:  null);
            if(val_7 <= 0)
            {
                    if(val_1 != (val_7.stages - 1))
            {
                    val_8 = val_1 + 1;
                return RestaurantRivals.RESGameEconHelper.CreateDummyMap(level:  val_7 = (UnityEngine.Random.Range(min:  1, max:  4)) + val_7, minObjects:  1, forAttack:  true);
            }
            
            }
            
            val_8 = 1;
            return RestaurantRivals.RESGameEconHelper.CreateDummyMap(level:  val_7, minObjects:  1, forAttack:  true);
        }
        public static System.Collections.Generic.List<System.Decimal> GeneratePickerOptions(decimal treasureAmount)
        {
            int val_11;
            var val_12;
            System.Collections.Generic.List<System.Decimal> val_2 = new System.Collections.Generic.List<System.Decimal>();
            val_12 = null;
            val_12 = null;
            Add(item:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
            Add(item:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
            Add(item:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
            var val_12 = 0;
            decimal val_3 = new System.Decimal(value:  4);
            Add(item:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
            RandomSet val_4 = new RandomSet();
            do
            {
                RestaurantRivals.RESGameEcon val_5 = RestaurantRivals.RESGameEcon.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                add(item:  0, weight:  (float)(typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_574 + 8 + 0) + 16);
                val_12 = val_12 + 1;
            }
            while(val_12 != 4);
            
            do
            {
                int val_6 = roll(unweighted:  false);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                decimal val_8 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 557691384, hi = treasureAmount.flags, lo = treasureAmount.hi, mid = treasureAmount.lo}, d2:  new System.Decimal() {flags = treasureAmount.mid, hi = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 4) + 16) + (0)], lo = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 4) + 16) + (4)], mid = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 4) + 16) + (8)]});
                decimal val_9 = new System.Decimal(value:  6);
                decimal val_10 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 557691368, hi = val_9.flags, lo = val_9.hi, mid = val_9.lo}, d2:  new System.Decimal() {flags = val_9.mid, hi = val_9.flags, lo = val_9.hi, mid = val_9.lo});
                Add(item:  new System.Decimal() {mid = val_11});
            }
            while((new System.Collections.Generic.List<System.Decimal>()) != 0);
        
        }
        public static System.Collections.Generic.List<System.Decimal> GenerateRiggedPickerOptions(decimal treasureAmount, string result)
        {
            int val_8;
            int val_10;
            int val_14;
            int val_19;
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            val_22 = 0;
            val_23 = 4;
            if((System.String.op_Equality(a:  result, b:  557795552)) != false)
            {
                    val_22 = 1;
            }
            else
            {
                    if((System.String.op_Equality(a:  result, b:  557795632)) != true)
            {
                    val_22 = 0;
                val_23 = System.String.op_Equality(a:  result, b:  557795712);
            }
            
            }
            
            System.Collections.Generic.List<System.Decimal> val_4 = new System.Collections.Generic.List<System.Decimal>();
            decimal val_5 = System.Decimal.op_Implicit(value:  557807716);
            decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 557807700, hi = treasureAmount.flags, lo = treasureAmount.hi, mid = treasureAmount.lo}, d2:  new System.Decimal() {flags = treasureAmount.mid});
            decimal val_7 = new System.Decimal(value:  6);
            decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 557807664}, d2:  new System.Decimal() {flags = val_8, hi = val_7.flags, lo = val_7.hi, mid = val_7.lo});
            Add(item:  new System.Decimal() {mid = val_10});
            decimal val_11 = System.Decimal.op_Implicit(value:  557807648);
            decimal val_12 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 557807648, hi = treasureAmount.flags, lo = treasureAmount.hi, mid = treasureAmount.lo}, d2:  new System.Decimal() {flags = treasureAmount.mid});
            decimal val_13 = new System.Decimal(value:  6);
            decimal val_15 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 557807616}, d2:  new System.Decimal() {flags = val_14, hi = val_13.flags, lo = val_13.hi, mid = val_13.lo});
            val_24 = null;
            if(val_24 == 0)
            {
                    val_24 = val_24;
            }
            
            Add(item:  new System.Decimal());
            decimal val_16 = System.Decimal.op_Implicit(value:  557807600);
            decimal val_17 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 557807584, hi = treasureAmount.flags, lo = treasureAmount.hi, mid = treasureAmount.lo}, d2:  new System.Decimal() {flags = treasureAmount.mid});
            decimal val_18 = new System.Decimal(value:  6);
            decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 557807552}, d2:  new System.Decimal() {flags = val_19, hi = val_18.flags, lo = val_18.hi, mid = val_18.lo});
            Add(item:  new System.Decimal() {mid = val_21});
            PluginExtension.Shuffle<System.Decimal>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public static decimal GetBaseRaidCoinsValue(int level)
        {
            int val_4;
            RestaurantRivals.RESLevelDef val_1 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  R1);
            decimal val_2 = TotalBuildCost;
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = level}, d2:  new System.Decimal() {flags = val_4, hi = typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_578, lo = typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_57C, mid = typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_580});
            return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
        }
        public static decimal GetRaidTreasureAmount(int level, decimal maxValueLimit)
        {
            int val_1;
            var val_15;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            decimal val_2 = RestaurantRivals.RESGameEconHelper.GetBaseRaidCoinsValue(level:  558035832);
            long val_3 = System.Decimal.op_Explicit(value:  new System.Decimal());
            val_15 = 1;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = maxValueLimit.hi, hi = maxValueLimit.lo, lo = maxValueLimit.mid, mid = val_1}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != true)
            {
                    RestaurantRivals.RESGameEcon val_5 = RestaurantRivals.RESGameEcon.Instance;
                RandomSet val_6 = RaidRankRoller;
                val_15 = roll(unweighted:  false);
            }
            
            RestaurantRivals.RESGameEcon val_8 = RestaurantRivals.RESGameEcon.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_14 = (typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_58C + 8 + (val_7) << 2) + 16;
            val_14 = val_14 * val_3;
            val_17 = val_3;
            val_18 = R1;
            if(val_15 != 0)
            {
                    RestaurantRivals.RESGameEcon val_10 = RestaurantRivals.RESGameEcon.Instance;
                val_15 = val_15 - 1;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                float val_15 = (typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_58C + 8 + ((val_7 - 1)) << 2) + 16;
                val_15 = val_15 * val_3;
                if((typeof(RestaurantRivals.RESGameEcon).__il2cppRuntimeField_58C + 12) == val_15)
            {
                    -D16 = -(-D16);
            }
            
                val_17 = RestaurantRivals.RESGameEcon.__il2cppRuntimeField_cctor_finished;
                val_18 = RestaurantRivals.RESGameEcon.__il2cppRuntimeField_cctor_finished;
            }
            
            long val_11 = val_3 + 9;
            val_20 = 119 + 60;
            val_11 = 18 - val_11;
            val_21 = val_20 >> 31;
            var val_16 = val_17;
            val_16 = val_16 + 1;
            float val_12 = UnityEngine.Random.Range(min:  val_15, max:  null);
            if(System.Decimal.__il2cppRuntimeField_cctor_finished == 0)
            {
                    -D16 = -(-D16);
            }
            
            decimal val_13 = System.Decimal.op_Implicit(value:  level);
            return new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid};
        }
        public static decimal GetPotentialRaidValue(int level, decimal playerCredits)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_8;
            int val_9;
            int val_13;
            int val_14;
            int val_15;
            decimal val_1 = new System.Decimal(lo:  371, mid:  0, hi:  0, isNegative:  false, scale:  2);
            decimal val_2 = RestaurantRivals.RESGameEconHelper.GetBaseRaidCoinsValue(level:  558147800);
            decimal val_7 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 558147784, hi = val_1.flags, lo = val_1.hi, mid = val_1.lo}, d2:  new System.Decimal() {flags = val_1.mid, hi = val_3, lo = val_4, mid = val_5});
            val_13 = val_8;
            decimal val_11 = new System.Decimal(lo:  75, mid:  0, hi:  0, isNegative:  false, scale:  2);
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = playerCredits.hi, hi = playerCredits.lo, lo = playerCredits.mid, mid = val_9}, d2:  new System.Decimal() {flags = val_13})) == false)
            {
                    val_14 = R4;
                val_15 = val_13;
            }
            
            val_13 = val_15;
            val_14 = val_14;
            val_15 = val_13;
            decimal val_12 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = level, hi = val_15, lo = val_14, mid = playerCredits.mid}, d2:  new System.Decimal() {flags = val_9, hi = val_11.flags, lo = val_11.hi, mid = val_11.lo});
            return new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid};
        }
        private static int GetDigits(long value)
        {
            var val_2;
            var val_3;
            val_2 = value;
            if()
            {
                    do
            {
                long val_1 = val_2 + 9;
                val_3 = 0 + 1;
                val_1 = 18 - val_1;
                val_2 = val_2;
            }
            while();
            
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public RESGameEconHelper()
        {
        
        }
    
    }

}
