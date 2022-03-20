using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesEconomy
    {
        // Fields
        public static decimal CostToCreate;
        public static int LeaguesPerGroup;
        public static SLC.Social.Leagues.GuildLevel[] GuildLevels;
        private static System.Decimal[] SupportOptions;
        public static System.TimeSpan AllowedDonationInterval;
        private static System.Decimal[] RequirementOptions;
        public static decimal MultiplierCostScale;
        public static System.Decimal[] MultiplierOptions;
        public static SLC.Social.Leagues.SeasonRewards seasonRewards;
        
        // Methods
        public static void UpdateGuildRanksEconomy(System.Collections.Generic.List<object> response)
        {
            var val_4;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Func<SLC.Social.Leagues.GuildLevel, System.Int32> val_20;
            var val_21;
            val_13 = response;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_19:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            SLC.Social.Leagues.GuildLevel val_5 = new SLC.Social.Leagues.GuildLevel(maxMembers:  0, requiredSupport:  0);
            if(val_4 != 0)
            {
                    val_14 = null;
            }
            
            if(val_4 != 0)
            {
                    val_14 = null;
                val_15 = 0;
                if(((val_4 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) == val_14)
            {
                    val_15 = val_4;
            }
            
            }
            else
            {
                    val_15 = 0;
            }
            
            string val_6 = val_15.Item[818972752];
            typeof(SLC.Social.Leagues.GuildLevel).__il2cppRuntimeField_8 = System.Int32.Parse(s:  null);
            if(val_4 != 0)
            {
                    val_16 = null;
            }
            
            if(val_4 != 0)
            {
                    val_16 = null;
                val_17 = 0;
                if(((val_4 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_16)
            {
                    val_4 = 0;
            }
            
                val_17 = val_4;
            }
            else
            {
                    val_17 = 0;
            }
            
            string val_8 = val_17.Item[818972848];
            typeof(SLC.Social.Leagues.GuildLevel).__il2cppRuntimeField_C = System.Int32.Parse(s:  null);
            Add(item:  441319424);
            goto label_19;
            label_2:
            Dispose();
            val_18 = null;
            val_18 = null;
            val_20 = LeaguesEconomy.<>c.<>9__8_0;
            if(val_20 == 0)
            {
                    val_20 = null;
                val_20 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  LeaguesEconomy.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(818973968));
                LeaguesEconomy.<>c.<>9__8_0 = val_20;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_11 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
            TSource[] val_12 = System.Linq.Enumerable.ToArray<System.Object>(source:  80883712);
            val_21 = null;
            val_21 = null;
            SLC.Social.Leagues.LeaguesEconomy.GuildLevels = null;
        }
        public static void UpdateRequirementOptions(System.Collections.Generic.List<object> response)
        {
            System.IFormatProvider val_4;
            int val_7;
            var val_9;
            System.Collections.Generic.List<System.Decimal> val_1 = new System.Collections.Generic.List<System.Decimal>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_6 = System.Decimal.Parse(s:  819111208, provider:  val_4);
            Add(item:  new System.Decimal() {mid = val_7});
            goto label_9;
            label_2:
            Dispose();
            T[] val_8 = ToArray();
            val_9 = null;
            val_9 = null;
            SLC.Social.Leagues.LeaguesEconomy.RequirementOptions = null;
        }
        public static void UpdateContributionOptions(System.Collections.Generic.List<object> response)
        {
            System.IFormatProvider val_4;
            int val_7;
            var val_9;
            System.Collections.Generic.List<System.Decimal> val_1 = new System.Collections.Generic.List<System.Decimal>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_6 = System.Decimal.Parse(s:  819231400, provider:  val_4);
            Add(item:  new System.Decimal() {mid = val_7});
            goto label_9;
            label_2:
            Dispose();
            T[] val_8 = ToArray();
            val_9 = null;
            val_9 = null;
            SLC.Social.Leagues.LeaguesEconomy.SupportOptions = null;
        }
        public static void UpdateMultiplierOptions(System.Collections.Generic.List<object> response)
        {
            System.IFormatProvider val_4;
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            var val_13;
            System.Collections.Generic.List<System.Decimal> val_1 = new System.Collections.Generic.List<System.Decimal>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_10:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_6 = System.Decimal.Parse(s:  819351592, provider:  val_4);
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_9, mid = val_10}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
            {
                goto label_8;
            }
            
            Add(item:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_9, mid = val_10});
            goto label_10;
            label_2:
            Dispose();
            T[] val_12 = ToArray();
            val_13 = null;
            val_13 = null;
            SLC.Social.Leagues.LeaguesEconomy.MultiplierOptions = null;
            return;
            label_8:
            Dispose();
        }
        public static void UpdateSeasonRewardsEconomy(System.Collections.Generic.Dictionary<string, object> response)
        {
            string val_4;
            var val_7;
            var val_8;
            var val_9;
            val_7 = null;
            val_7 = null;
            SLC.Social.Leagues.LeaguesEconomy.seasonRewards.Clear();
            Dictionary.KeyCollection<TKey, TValue> val_1 = response.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            SLC.Social.Leagues.SeasonReward val_5 = new SLC.Social.Leagues.SeasonReward();
            object val_6 = response.Item[val_4];
            val_8 = 0;
            if(response != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    response = 0;
            }
            
                val_8 = response;
            }
            
            Decode(jasonObject:  0, sourceModel:  0);
            val_9 = null;
            val_9 = null;
            SLC.Social.Leagues.LeaguesEconomy.seasonRewards.Add(key:  val_4, value:  442331136);
            goto label_14;
            label_6:
            Dispose();
        }
        public static SLC.Social.Leagues.GuildLevel GetCurrentLevel(int level)
        {
            var val_2;
            int val_2 = level;
            val_2 = null;
            val_2 = null;
            val_2 = val_2 - 1;
            SLC.Social.Leagues.GuildLevel[] val_1 = SLC.Social.Leagues.LeaguesEconomy.GuildLevels + (val_2 << 2);
        }
        public static SLC.Social.Leagues.GuildLevel GetNextLevel(int level)
        {
            null = null;
            SLC.Social.Leagues.GuildLevel[] val_3 = SLC.Social.Leagues.LeaguesEconomy.GuildLevels + ((UnityEngine.Mathf.Min(a:  level, b:  (SLC.Social.Leagues.LeaguesEconomy.GuildLevels + 12) - 1)) << 2);
        }
        public static decimal GetSupportOption(int index)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((SLC.Social.Leagues.LeaguesEconomy.SupportOptions + 12) > R1)
            {
                    return new System.Decimal() {flags = SLC.Social.Leagues.LeaguesEconomy.SupportOptions + (R1 << 4)};
            }
            
            val_3 = 0;
            return new System.Decimal() {flags = SLC.Social.Leagues.LeaguesEconomy.SupportOptions + (R1 << 4)};
        }
        public static System.Decimal[] GetRequirementOptions()
        {
            null = null;
        }
        public static int GetIndexOfRequirementOption(decimal req)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = 0;
            val_3 = 0;
            goto label_1;
            label_11:
            val_4 = null;
            val_4 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = 2621443, hi = 1, mid = 52}, d2:  new System.Decimal() {flags = req.flags, hi = req.hi, lo = req.lo, mid = req.mid})) == true)
            {
                    val_3 = val_2;
            }
            
            val_2 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            if(val_2 < (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + 12))
            {
                goto label_11;
            }
            
            return (int)val_3;
        }
        public static SLC.Social.Leagues.SeasonReward GetSeasonRewardForTier(SLC.Social.Leagues.GuildTier tier)
        {
            var val_3;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_1 = Replace(oldValue:  2144339952, newValue:  1297836560);
            val_3 = null;
            val_3 = null;
            string val_2 = SLC.Social.Leagues.LeaguesEconomy.seasonRewards.Item[441212928];
        }
        public static decimal GetRewardedCoinsPerDay(decimal totalRewardedCoins, int totalLeagues)
        {
            var val_1;
            int val_5;
            decimal val_3 = System.Decimal.op_Explicit(value:  UnityEngine.Mathf.Max(a:  (float)val_1, b:  null));
            decimal val_4 = new System.Decimal(value:  7);
            decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 820271128}, d2:  new System.Decimal() {flags = val_5, hi = val_4.flags, lo = val_4.hi, mid = val_4.lo});
            decimal val_7 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = totalRewardedCoins.flags, hi = totalRewardedCoins.hi, lo = totalRewardedCoins.lo, mid = totalRewardedCoins.mid}, d2:  new System.Decimal() {flags = totalLeagues});
            return new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid};
        }
        public LeaguesEconomy()
        {
        
        }
        private static LeaguesEconomy()
        {
            System.TimeSpan val_27;
            decimal val_1 = new System.Decimal(value:  120);
            SLC.Social.Leagues.LeaguesEconomy.LeaguesPerGroup = 15;
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_10 = new SLC.Social.Leagues.GuildLevel(maxMembers:  10, requiredSupport:  0);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_14 = new SLC.Social.Leagues.GuildLevel(maxMembers:  15, requiredSupport:  1000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_18 = new SLC.Social.Leagues.GuildLevel(maxMembers:  20, requiredSupport:  1250);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_1C = new SLC.Social.Leagues.GuildLevel(maxMembers:  25, requiredSupport:  1500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_20 = new SLC.Social.Leagues.GuildLevel(maxMembers:  30, requiredSupport:  2000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_24 = new SLC.Social.Leagues.GuildLevel(maxMembers:  35, requiredSupport:  2500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_28 = new SLC.Social.Leagues.GuildLevel(maxMembers:  40, requiredSupport:  3000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_2C = new SLC.Social.Leagues.GuildLevel(maxMembers:  45, requiredSupport:  4000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_30 = new SLC.Social.Leagues.GuildLevel(maxMembers:  50, requiredSupport:  5000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_34 = new SLC.Social.Leagues.GuildLevel(maxMembers:  55, requiredSupport:  7500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_38 = new SLC.Social.Leagues.GuildLevel(maxMembers:  60, requiredSupport:  10000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_3C = new SLC.Social.Leagues.GuildLevel(maxMembers:  65, requiredSupport:  12500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_40 = new SLC.Social.Leagues.GuildLevel(maxMembers:  70, requiredSupport:  15000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_44 = new SLC.Social.Leagues.GuildLevel(maxMembers:  75, requiredSupport:  17500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_48 = new SLC.Social.Leagues.GuildLevel(maxMembers:  80, requiredSupport:  20000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_4C = new SLC.Social.Leagues.GuildLevel(maxMembers:  85, requiredSupport:  22500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_50 = new SLC.Social.Leagues.GuildLevel(maxMembers:  90, requiredSupport:  25000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_54 = new SLC.Social.Leagues.GuildLevel(maxMembers:  95, requiredSupport:  27500);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_58 = new SLC.Social.Leagues.GuildLevel(maxMembers:  97, requiredSupport:  30000);
            typeof(SLC.Social.Leagues.GuildLevel[]).__il2cppRuntimeField_5C = new SLC.Social.Leagues.GuildLevel(maxMembers:  100, requiredSupport:  35000);
            SLC.Social.Leagues.LeaguesEconomy.GuildLevels = null;
            decimal val_22 = new System.Decimal(value:  50);
            decimal val_23 = new System.Decimal(value:  150);
            decimal val_24 = new System.Decimal(value:  250);
            SLC.Social.Leagues.LeaguesEconomy.SupportOptions = null;
            System.TimeSpan val_25 = System.TimeSpan.FromDays(value:  null);
            SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval = val_27;
            decimal val_28 = new System.Decimal(value:  500);
            decimal val_29 = new System.Decimal(value:  1000);
            decimal val_30 = new System.Decimal(value:  2500);
            decimal val_31 = new System.Decimal(value:  5000);
            decimal val_32 = new System.Decimal(value:  10000);
            decimal val_33 = new System.Decimal(value:  25000);
            SLC.Social.Leagues.LeaguesEconomy.RequirementOptions = null;
            decimal val_34 = new System.Decimal(value:  100);
            decimal val_35 = new System.Decimal(lo:  1, mid:  0, hi:  0, isNegative:  false, scale:  1);
            decimal val_36 = new System.Decimal(lo:  2, mid:  0, hi:  0, isNegative:  false, scale:  1);
            decimal val_37 = new System.Decimal(lo:  5, mid:  0, hi:  0, isNegative:  false, scale:  1);
            decimal val_38 = new System.Decimal(lo:  10, mid:  0, hi:  0, isNegative:  false, scale:  1);
            SLC.Social.Leagues.LeaguesEconomy.MultiplierOptions = null;
            SLC.Social.Leagues.LeaguesEconomy.seasonRewards = new SLC.Social.Leagues.SeasonRewards();
        }
    
    }

}
