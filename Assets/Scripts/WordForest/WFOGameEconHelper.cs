using UnityEngine;

namespace WordForest
{
    public class WFOGameEconHelper
    {
        // Fields
        private static System.Collections.Generic.List<WordForest.WFOForestData> _forests;
        
        // Properties
        public static System.Collections.Generic.List<WordForest.WFOForestData> Forests { get; }
        
        // Methods
        public static System.Collections.Generic.List<WordForest.WFOForestData> get_Forests()
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<WordForest.WFOForestData> val_4;
            var val_5;
            if(WordForest.WFOGameEconHelper._forests != 0)
            {
                    return;
            }
            
            val_2 = 14069592 + 21556195;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            if(App.game != 18)
            {
                goto label_7;
            }
            
            WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
            if(App.game != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_7:
            val_2 = 14069760 + 21569357;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = 1152921504923570208;
            label_9:
            WordForest.WFOGameEconHelper._forests = val_4;
        }
        public static WordForest.WFOForestData GetForestEconData(int forestId)
        {
            typeof(WFOGameEconHelper.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = R1;
            System.Collections.Generic.List<WordForest.WFOForestData> val_2 = WordForest.WFOGameEconHelper.Forests;
            System.Predicate<WordForest.WFOForestData> val_3 = new System.Predicate<WordForest.WFOForestData>(object:  407773184, method:  new IntPtr(309622816));
            WordForest.WFOForestData val_4 = forestId.Find(match:  new System.Object() = new System.Object());
            return new WordForest.WFOForestData() {level = val_4.level, forestName = val_4.forestName, initialCost = val_4.initialCost, costIncrease = val_4.costIncrease};
        }
        public static System.Collections.Generic.List<WordForest.WFORewardData> GetMysteryRewards(int acornSmall, int acornMedium, int acornLarge, int coinSmall, int coinMedium)
        {
            System.Collections.Generic.List<WordForest.WFORewardData> val_1 = new System.Collections.Generic.List<WordForest.WFORewardData>();
            WordForest.WFORewardData val_2 = new WordForest.WFORewardData(rType:  5, rAmt:  1);
            Add(item:  new WordForest.WFORewardData() {id = val_2.id, rewardType = val_2.rewardType, amount = new System.Decimal() {flags = val_2.amount.flags, hi = val_2.amount.hi, lo = val_2.amount.lo, mid = val_2.amount.mid}, transformToId = val_2.transformToId});
            WordForest.WFORewardData val_3 = new WordForest.WFORewardData(rType:  6, rAmt:  1);
            Add(item:  new WordForest.WFORewardData() {id = val_3.id, rewardType = val_3.rewardType, amount = new System.Decimal() {flags = val_3.amount.flags, hi = val_3.amount.hi, lo = val_3.amount.lo, mid = val_3.amount.mid}, transformToId = val_3.transformToId});
            WordForest.WFORewardData val_4 = new WordForest.WFORewardData(rType:  4, rAmt:  1);
            Add(item:  new WordForest.WFORewardData() {id = val_4.id, rewardType = val_4.rewardType, amount = new System.Decimal() {flags = val_4.amount.flags, hi = val_4.amount.hi, lo = val_4.amount.lo, mid = val_4.amount.mid}, transformToId = val_4.transformToId});
            var val_10 = 5;
            do
            {
                WordForest.WFORewardData val_5 = new WordForest.WFORewardData(rType:  1, rAmt:  acornSmall);
                Add(item:  new WordForest.WFORewardData() {id = val_5.id, rewardType = val_5.rewardType, amount = new System.Decimal() {flags = val_5.amount.flags, hi = val_5.amount.hi, lo = val_5.amount.lo, mid = val_5.amount.mid}, transformToId = val_5.transformToId});
                val_10 = val_10 - 1;
            }
            while(null != 0);
            
            var val_11 = 3;
            do
            {
                WordForest.WFORewardData val_6 = new WordForest.WFORewardData(rType:  1, rAmt:  acornMedium);
                Add(item:  new WordForest.WFORewardData() {id = val_6.id, rewardType = val_6.rewardType, amount = new System.Decimal() {flags = val_6.amount.flags, hi = val_6.amount.hi, lo = val_6.amount.lo, mid = val_6.amount.mid}, transformToId = val_6.transformToId});
                val_11 = val_11 - 1;
            }
            while(null != 0);
            
            WordForest.WFORewardData val_7 = new WordForest.WFORewardData(rType:  1, rAmt:  acornLarge);
            Add(item:  new WordForest.WFORewardData() {id = val_7.id, rewardType = val_7.rewardType, amount = new System.Decimal() {flags = val_7.amount.flags, hi = val_7.amount.hi, lo = val_7.amount.lo, mid = val_7.amount.mid}, transformToId = val_7.transformToId});
            var val_12 = 2;
            do
            {
                WordForest.WFORewardData val_8 = new WordForest.WFORewardData(rType:  2, rAmt:  coinSmall);
                Add(item:  new WordForest.WFORewardData() {id = val_8.id, rewardType = val_8.rewardType, amount = new System.Decimal() {flags = val_8.amount.flags, hi = val_8.amount.hi, lo = val_8.amount.lo, mid = val_8.amount.mid}, transformToId = val_8.transformToId});
                val_12 = val_12 - 1;
            }
            while(null != 0);
            
            WordForest.WFORewardData val_9 = new WordForest.WFORewardData(rType:  2, rAmt:  coinMedium);
            Add(item:  new WordForest.WFORewardData() {id = val_9.id, rewardType = val_9.rewardType, amount = new System.Decimal() {flags = val_9.amount.flags, hi = val_9.amount.hi, lo = val_9.amount.lo, mid = val_9.amount.mid}, transformToId = val_9.transformToId});
        }
        public static WordForest.Map MapDataV1ToV2Migration(int oldForestId, int oldForestGrowth)
        {
            bool val_6;
            var val_7;
            val_6 = static_value_021FD6A9;
            if(val_6 != true)
            {
                    val_6 = true;
            }
            
            System.Collections.Generic.List<WordForest.WFOForestData> val_1 = WordForest.WFOGameEconHelper.Forests;
            val_7 = val_6;
            if(50331648 <= oldForestId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = 0;
            val_6 = val_6 + ((oldForestId + (oldForestId << 1)) << 3);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(((0 + ((oldForestId + (oldForestId) << 1)) << 3) + 32) >= 1)
            {
                    do
            {
                if(0 < oldForestGrowth)
            {
                    0 = 1;
            }
            
                WordForest.MapItem val_4 = new WordForest.MapItem(mType:  -1402413584, mId:  0, mStatus:  1);
                Add(item:  404525056);
                val_7 = 0 + 1;
            }
            while(((0 + ((oldForestId + (oldForestId) << 1)) << 3) + 32) != val_7);
            
            }
            
            WordForest.Map val_5 = new WordForest.Map(initialAreaItems:  80883712);
        }
        public static WordForest.Map CreateStartingMap()
        {
            WordForest.Map val_1 = WordForest.WFOGameEconHelper.CreateMap(forestLevel:  1, growthLevel:  0, growthPercent:  null, dummyProfile:  false);
        }
        public static WordForest.Map CreateMap(int forestLevel, int growthLevel = 0, float growthPercent = 0, bool dummyProfile = False)
        {
            float val_12;
            float val_13;
            WordForest.MapItem val_14;
            var val_15;
            val_12 = dummyProfile;
            val_13 = growthLevel;
            object val_1 = new System.Object();
            typeof(WFOGameEconHelper.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = forestLevel;
            System.Collections.Generic.List<WordForest.WFOForestData> val_3 = WordForest.WFOGameEconHelper.Forests;
            val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Predicate<WordForest.WFOForestData> val_4 = new System.Predicate<WordForest.WFOForestData>(object:  407826432, method:  new IntPtr(310073888));
            int val_5 = val_14.FindIndex(match:  8040448);
            if(val_5 >= 0)
            {
                    System.Collections.Generic.List<WordForest.WFOForestData> val_6 = WordForest.WFOGameEconHelper.Forests;
                val_14 = val_5;
                if((val_5 + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_12 = val_5 + 8;
                val_12 = val_12 + ((val_5 + (val_5 << 1)) << 3);
                val_15 = mem[(val_5 + 8 + ((val_5 + (val_5) << 1)) << 3) + 32];
                val_15 = (val_5 + 8 + ((val_5 + (val_5) << 1)) << 3) + 32;
            }
            else
            {
                    val_15 = 20;
            }
            
            if((val_13 <= 0) && (val_13 > 0))
            {
                    float val_8 = UnityEngine.Mathf.Clamp(value:  val_12, min:  null, max:  null);
                float val_13 = 20f;
                val_13 = val_12 * val_13;
                val_13 = UnityEngine.Mathf.FloorToInt(f:  val_13);
            }
            
            if((???) != 0)
            {
                    val_13 = 3;
            }
            
            if(val_15 >= 1)
            {
                    var val_14 = 0;
                val_12 = "tree";
                val_13 = 1152921511794368064;
                do
            {
                val_14 = null;
                if(val_14 < val_13)
            {
                    0 = 1;
            }
            
                val_14 = new WordForest.MapItem(mType:  -1402413584, mId:  0, mStatus:  1);
                Add(item:  404525056);
                val_14 = val_14 + 1;
            }
            while(val_15 != val_14);
            
            }
            
            WordForest.Map val_11 = new WordForest.Map(initialAreaItems:  80883712);
        }
        public static UnityEngine.Vector2Int GetRaidEligibleAcornsMinMax(int forestLevel)
        {
            var val_6;
            int val_9;
            bool val_11;
            var val_14;
            val_11 = static_value_021FD6AB;
            if(val_11 != true)
            {
                    val_11 = true;
            }
            
            WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
            if((268435456.ContainsKey(key:  R1)) == false)
            {
                goto label_3;
            }
            
            val_14 = R1;
            goto label_14;
            label_3:
            WordForest.WFOGameEcon val_3 = WordForest.WFOGameEcon.Instance;
            Dictionary.KeyCollection<TKey, TValue> val_4 = val_2 + 1356.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            val_14 = 2;
            goto label_8;
            label_9:
            if(val_6 > R1)
            {
                    val_6 = val_14;
            }
            
            if(val_6 > val_14)
            {
                    val_14 = val_6;
            }
            
            label_8:
            if(MoveNext() == true)
            {
                goto label_9;
            }
            
            Dispose();
            label_14:
            WordForest.WFOGameEcon val_8 = WordForest.WFOGameEcon.Instance;
            UnityEngine.Vector2Int val_10 = forestLevel.Item[val_9];
            return new UnityEngine.Vector2Int() {m_X = val_10.m_X, m_Y = val_10.m_Y};
        }
        public static int GetRandomRaidEligibleAcorns(int forestLevel)
        {
            UnityEngine.Vector2Int val_1 = WordForest.WFOGameEconHelper.GetRaidEligibleAcornsMinMax(forestLevel:  310314984);
            var val_7 = 0.y;
            int val_3 = 0.x;
            val_3 = val_7 - val_3;
            val_7 = val_3 + (val_3 >> 31);
            int val_6 = UnityEngine.Random.Range(min:  0, max:  val_7 + 1);
            val_6 = val_6 + (val_6 << 1);
            val_6 = 0.x + (val_6 << 1);
            return (int)val_6;
        }
        public static System.Collections.Generic.List<int> GeneratePickerOptionsFromEligibleAcorns(int eligibleAcorns)
        {
            var val_3;
            int val_4;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    val_3 = 1152921510720759024;
                Add(item:  0);
                val_4 = 715827883;
                Add(item:  715827883);
                Add(item:  715827883);
            }
            else
            {
                    val_3 = 1152921510720759024;
                Add(item:  0);
                val_4 = eligibleAcorns + (eligibleAcorns >> 31);
                Add(item:  val_4);
                Add(item:  val_4);
            }
            
            Add(item:  val_4 << 2);
            PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public WFOGameEconHelper()
        {
        
        }
    
    }

}
