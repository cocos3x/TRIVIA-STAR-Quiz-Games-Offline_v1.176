using UnityEngine;

namespace RestaurantRivals
{
    public class RESGameEcon : GameEcon
    {
        // Fields
        public const int playerMaxLevel = 200;
        private System.Collections.Generic.List<RestaurantRivals.RESLevelChestData> levelChests;
        public static System.Collections.Generic.List<GiftRewardTypeChance> DailyBonusRewardTypeChances;
        private int autoSpinUnlock;
        private int spinsPerSpinContainerOutcome;
        private int dailyBonusUnlockSpins;
        private int maxVideoAdRewards;
        private int videoFreeCoinAmount;
        private int defaultRechargeableSpinAmount;
        private int spinBuyButtonUnlockLevel;
        private int betMultiplierUnlockLevel;
        private int unlockLevel4thShield;
        private int unlockLevel5thShield;
        private int lowOnSpins;
        private int dailyBonusTimer;
        private float dailyBonusMinRewardPercentage;
        private float dailyBonusMaxRewardPercentage;
        private int onlineMinOffensiveInterval;
        private int onlineMaxOffensiveInterval;
        private int maxRaidsReceived;
        private int maxUnblockAttacksReceived;
        private int offensiveActionsPerDay;
        private int daysOfOffensiveActionsPostSession;
        private float attackLowSuccessRate;
        private float attackHighSuccessRate;
        public System.Collections.Generic.List<int> raidPickerWeights;
        private decimal raidbuildCostMultiplier;
        private System.Collections.Generic.List<int> raidRankWeights;
        private System.Collections.Generic.List<float> raidRankMultipliers;
        private RandomSet raidRankRoller;
        public static System.Collections.Generic.List<RestaurantRivals.RESFTUXLevel> FTUXScripts;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<System.Collections.Generic.Dictionary<float, System.Collections.Generic.List<System.Decimal>>>>> returnGameRewardConfig;
        
        // Properties
        public static RestaurantRivals.RESGameEcon Instance { get; }
        public static System.Collections.Generic.List<RestaurantRivals.RESLevelDef> LevelDefs { get; }
        public System.Collections.Generic.List<RestaurantRivals.RESLevelChestData> LevelChests { get; }
        public int AutoSpinUnlock { get; }
        public int SpinsPerSpinContainerOutcome { get; }
        public int NoAdsSpinQuantity { get; }
        public int DailyBonusUnlockSpins { get; }
        public int MaxVideoAdRewards { get; }
        public int SpinsPerInterstitial { get; }
        public int WatchAdForSpinUnlockSpins { get; }
        public int WatchAdForCoinUnlockLevel { get; }
        public int VideoFreeCoinAmount { get; }
        public int DefaultRechargeableSpinAmount { get; }
        public int SpinBuyButtonUnlockLevel { get; }
        public int BetMultiplierUnlockLevel { get; }
        public int UnlockLevel4thShield { get; }
        public int UnlockLevel5thShield { get; }
        public int LowOnSpins { get; }
        public int DailyBonusTimer { get; }
        public float DailyBonusMinRewardPercentage { get; }
        public float DailyBonusMaxRewardPercentage { get; }
        public int OnlineMinOffensiveInterval { get; }
        public int OnlineMaxOffensiveInterval { get; }
        public int MaxRaidsReceived { get; }
        public int MaxUnblockAttacksReceived { get; }
        public int OffensiveActionsPerDay { get; }
        public int DaysOfOffensiveActionsPostSession { get; }
        public float AttackLowSuccessRate { get; }
        public float AttackHighSuccessRate { get; }
        public decimal RaidBuildCostMultiplier { get; }
        public System.Collections.Generic.List<int> RaidRankWeights { get; }
        public System.Collections.Generic.List<float> RaidRankMultipliers { get; }
        public RandomSet RaidRankRoller { get; }
        public override float MiniReturnGameGiftOfflineHours { get; }
        
        // Methods
        public static RestaurantRivals.RESGameEcon get_Instance()
        {
            var val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static System.Collections.Generic.List<RestaurantRivals.RESLevelDef> get_LevelDefs()
        {
            var val_3;
            AppConfigs val_1 = App.Configuration;
            if(52 != 0)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            if((((328190 + (RestaurantRivals.RESEconConfig.__il2cppRuntimeField_typeHierarchyDepth) << 2) - 4)) == val_3)
            {
                    276 = 52 + 276;
            }
        
        }
        public System.Collections.Generic.List<RestaurantRivals.RESLevelChestData> get_LevelChests()
        {
        
        }
        public int get_AutoSpinUnlock()
        {
            return (int)this.autoSpinUnlock;
        }
        public int get_SpinsPerSpinContainerOutcome()
        {
            return (int)this.spinsPerSpinContainerOutcome;
        }
        public int get_NoAdsSpinQuantity()
        {
            return 50;
        }
        public int get_DailyBonusUnlockSpins()
        {
            return (int)this.dailyBonusUnlockSpins;
        }
        public int get_MaxVideoAdRewards()
        {
            return (int)this.maxVideoAdRewards;
        }
        public int get_SpinsPerInterstitial()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
            {
                    return InterstitialSeconds;
            }
            
            return InterstitialSeconds;
        }
        public int get_WatchAdForSpinUnlockSpins()
        {
            return (int)this;
        }
        public int get_WatchAdForCoinUnlockLevel()
        {
            return (int)this;
        }
        public int get_VideoFreeCoinAmount()
        {
            return (int)this.videoFreeCoinAmount;
        }
        public int get_DefaultRechargeableSpinAmount()
        {
            return (int)this.defaultRechargeableSpinAmount;
        }
        public int get_SpinBuyButtonUnlockLevel()
        {
            return (int)this.spinBuyButtonUnlockLevel;
        }
        public int get_BetMultiplierUnlockLevel()
        {
            return (int)this.betMultiplierUnlockLevel;
        }
        public int get_UnlockLevel4thShield()
        {
            return (int)this.unlockLevel4thShield;
        }
        public int get_UnlockLevel5thShield()
        {
            return (int)this.unlockLevel5thShield;
        }
        public int get_LowOnSpins()
        {
            return (int)this.lowOnSpins;
        }
        public int get_DailyBonusTimer()
        {
            return (int)this.dailyBonusTimer;
        }
        public float get_DailyBonusMinRewardPercentage()
        {
            return (float)S0;
        }
        public float get_DailyBonusMaxRewardPercentage()
        {
            return (float)S0;
        }
        public int get_OnlineMinOffensiveInterval()
        {
            return (int)this.onlineMinOffensiveInterval;
        }
        public int get_OnlineMaxOffensiveInterval()
        {
            return (int)this.onlineMaxOffensiveInterval;
        }
        public int get_MaxRaidsReceived()
        {
            return (int)this.maxRaidsReceived;
        }
        public int get_MaxUnblockAttacksReceived()
        {
            return (int)this.maxUnblockAttacksReceived;
        }
        public int get_OffensiveActionsPerDay()
        {
            return (int)this.offensiveActionsPerDay;
        }
        public int get_DaysOfOffensiveActionsPostSession()
        {
            return (int)this.daysOfOffensiveActionsPostSession;
        }
        public float get_AttackLowSuccessRate()
        {
            return (float)S0;
        }
        public float get_AttackHighSuccessRate()
        {
            return (float)S0;
        }
        public decimal get_RaidBuildCostMultiplier()
        {
            return new System.Decimal() {flags = 554473952, hi = R1 + 1400, lo = 1400};
        }
        public System.Collections.Generic.List<int> get_RaidRankWeights()
        {
        
        }
        public System.Collections.Generic.List<float> get_RaidRankMultipliers()
        {
        
        }
        public RandomSet get_RaidRankRoller()
        {
            RandomSet val_2;
            var val_3;
            val_2 = this.raidRankRoller;
            if(val_2 != 0)
            {
                    return;
            }
            
            RandomSet val_1 = null;
            val_3 = 0;
            val_1 = new RandomSet();
            this.raidRankRoller = val_1;
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            goto label_3;
            label_8:
            if(1 <= val_3)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            add(item:  0, weight:  (float)(0 + 0) + 16);
            val_3 = 1;
            label_3:
            val_2 = this.raidRankRoller;
            if(val_3 < val_1)
            {
                goto label_8;
            }
        
        }
        public RandomSet GetPlayerRaidRankRoller(long baseValue, decimal playerCredits)
        {
            var val_3;
            int val_5;
            int val_8;
            RestaurantRivals.RESGameEcon val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = this;
            val_11 = 0;
            null = new RandomSet();
            val_12 = 16;
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            val_13 = 0;
            goto label_2;
            label_12:
            decimal val_2 = System.Decimal.op_Implicit(value:  1152921513751744716);
            if(val_2.flags <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            decimal val_4 = System.Decimal.op_Explicit(value:  null);
            val_11 = 0;
            decimal val_7 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 554963116}, d2:  new System.Decimal() {flags = val_5});
            val_10 = val_10;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = playerCredits.hi, hi = playerCredits.lo, lo = playerCredits.mid, mid = val_8})) == true)
            {
                    return;
            }
            
            if((mem[1152921513751758184] + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            add(item:  0, weight:  (float)mem[1152921513751758184] + 8 + val_3);
            val_12 = val_3 + 4;
            val_13 = 1;
            label_2:
            val_3 = val_12;
            if(val_13 < (mem[1152921513751758184] + 12))
            {
                goto label_12;
            }
        
        }
        public override void ReadFromKnobs()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5;
            var val_6;
            var val_7;
            this.ReadFromKnobs();
            val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_5 = 25040487;
            val_5 = 10586928 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            twelvegigs.storage.JsonDictionary val_2 = getWordGameplayKnobs();
            if(App.storageManager.knobsModel != 0)
            {
                    if(null != null)
            {
                goto label_11;
            }
            
            }
            
            label_11:
            val_5 = 0;
            val_7 = 1;
            if((val_5.ContainsKey(key:  308442640)) == false)
            {
                    return;
            }
            
            string val_4 = val_5.Item[308442640];
        }
        public void ParseServerJsonKnobs(System.Collections.Generic.Dictionary<string, object> jsonDict)
        {
            string val_82;
            float val_83;
            var val_84;
            if((jsonDict.ContainsKey(key:  555183392)) != false)
            {
                    object val_2 = jsonDict.Item[555183392];
                val_82 = jsonDict;
                string val_3 = val_82.ToString();
                bool val_5 = System.Int32.TryParse(s:  val_82, result: out  this.defaultRechargeableSpinAmount);
            }
            
            if((jsonDict.ContainsKey(key:  555183488)) != false)
            {
                    object val_7 = jsonDict.Item[555183488];
                val_82 = jsonDict;
                string val_8 = val_82.ToString();
                bool val_10 = System.Int32.TryParse(s:  val_82, result: out  this.lowOnSpins);
            }
            
            if((jsonDict.ContainsKey(key:  555183568)) != false)
            {
                    val_83 = 1152921510385703632;
                object val_12 = jsonDict.Item[555183568];
                val_82 = 0;
                if((val_82.ContainsKey(key:  555183648)) != false)
            {
                    string val_14 = val_82.Item[555183648];
                bool val_16 = System.Int32.TryParse(s:  null, result: out  this.spinBuyButtonUnlockLevel);
            }
            
                if((val_82.ContainsKey(key:  555183744)) != false)
            {
                    string val_18 = val_82.Item[555183744];
                bool val_20 = System.Int32.TryParse(s:  null, result: out  this.betMultiplierUnlockLevel);
            }
            
                if((val_82.ContainsKey(key:  555183840)) != false)
            {
                    string val_22 = val_82.Item[555183840];
                bool val_24 = System.Int32.TryParse(s:  null, result: out  this.unlockLevel4thShield);
            }
            
                val_84 = "5th_Shield";
                if((val_82.ContainsKey(key:  555183936)) != false)
            {
                    string val_26 = val_82.Item[555183936];
                val_82 = val_82;
                bool val_28 = System.Int32.TryParse(s:  null, result: out  this.unlockLevel5thShield);
            }
            
            }
            
            if((jsonDict.ContainsKey(key:  555184032)) != false)
            {
                    object val_30 = jsonDict.Item[555184032];
                val_82 = jsonDict;
                string val_31 = val_82.ToString();
                bool val_33 = System.Int32.TryParse(s:  val_82, result: out  int val_32 = 555209496);
            }
            
            if((jsonDict.ContainsKey(key:  555184128)) != false)
            {
                    object val_35 = jsonDict.Item[555184128];
                val_82 = jsonDict;
                string val_36 = val_82.ToString();
                bool val_38 = System.Single.TryParse(s:  val_82, result: out  this.dailyBonusMinRewardPercentage);
            }
            
            if((jsonDict.ContainsKey(key:  555184224)) != false)
            {
                    object val_40 = jsonDict.Item[555184224];
                val_82 = jsonDict;
                string val_41 = val_82.ToString();
                bool val_43 = System.Single.TryParse(s:  val_82, result: out  this.dailyBonusMaxRewardPercentage);
            }
            
            if((jsonDict.ContainsKey(key:  555184320)) == false)
            {
                    return;
            }
            
            object val_45 = jsonDict.Item[555184320];
            if((0.ContainsKey(key:  -1163065312)) != false)
            {
                    string val_47 = 0.Item[-1163065312];
                val_83 = 1;
                if((0.ContainsKey(key:  555184416)) != false)
            {
                    string val_49 = 0.Item[555184416];
                bool val_51 = System.Int32.TryParse(s:  null, result: out  this.onlineMinOffensiveInterval);
            }
            
                if((0.ContainsKey(key:  555184512)) != false)
            {
                    string val_53 = 0.Item[555184512];
                bool val_55 = System.Int32.TryParse(s:  null, result: out  this.onlineMaxOffensiveInterval);
            }
            
                if((0.ContainsKey(key:  555184608)) != false)
            {
                    string val_57 = 0.Item[555184608];
                bool val_59 = System.Int32.TryParse(s:  null, result: out  this.maxRaidsReceived);
            }
            
                if((0.ContainsKey(key:  555184688)) != false)
            {
                    string val_61 = 0.Item[555184688];
                bool val_63 = System.Int32.TryParse(s:  null, result: out  this.maxUnblockAttacksReceived);
            }
            
                if((0.ContainsKey(key:  555184784)) != false)
            {
                    string val_65 = 0.Item[555184784];
                bool val_67 = System.Int32.TryParse(s:  null, result: out  this.offensiveActionsPerDay);
            }
            
                val_84 = "dooa_ps";
                if((0.ContainsKey(key:  555184864)) != false)
            {
                    string val_69 = 0.Item[555184864];
                bool val_71 = System.Int32.TryParse(s:  null, result: out  this.daysOfOffensiveActionsPostSession);
            }
            
            }
            
            val_82 = "atk";
            if((0.ContainsKey(key:  -1554533584)) == false)
            {
                    return;
            }
            
            string val_73 = 0.Item[-1554533584];
            if((0.ContainsKey(key:  555184960)) != false)
            {
                    string val_75 = 0.Item[555184960];
                bool val_77 = System.Single.TryParse(s:  null, result: out  this.attackLowSuccessRate);
            }
            
            val_82 = "hsr";
            if((0.ContainsKey(key:  555185040)) == false)
            {
                    return;
            }
            
            string val_79 = 0.Item[555185040];
            bool val_81 = System.Single.TryParse(s:  null, result: out  this.attackHighSuccessRate);
        }
        public override float get_MiniReturnGameGiftOfflineHours()
        {
            return (float)S0;
        }
        public override ReturnGameGiftReward GetReturnReward(int level, float leftHours)
        {
            float val_3;
            var val_5;
            int val_18;
            int val_21;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            int val_29;
            int val_30;
            int val_31;
            int val_32;
            var val_38;
            var val_39;
            int val_40;
            var val_41;
            int val_42;
            var val_45;
            var val_48;
            var val_49;
            var val_50;
            int val_51;
            var val_52;
            var val_53;
            int val_1 = level - 1;
            label_103:
            if(0 >= (mem[1152921513752228020] + 12))
            {
                    return;
            }
            
            val_40 = level;
            if((mem[1152921513752228020] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_37 = mem[1152921513752228020] + 8;
            val_37 = val_37 + 0;
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            val_41 = ;
            val_42 = val_40;
            label_9:
            if(val_3.MoveNext() == false)
            {
                goto label_6;
            }
            
            if(val_5 < val_42)
            {
                goto label_9;
            }
            
            label_64:
            if(0 >= 0)
            {
                goto label_9;
            }
            
            if(0 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
            val_41 = val_41;
            val_42 = val_42;
            val_40 = 0;
            label_13:
            bool val_7 = val_3.MoveNext();
            if(val_7 == false)
            {
                goto label_12;
            }
            
            if(val_7 <= false)
            {
                goto label_13;
            }
            
            System.Collections.Generic.List<System.Decimal> val_9 = new System.Collections.Generic.List<System.Decimal>(collection:  0);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            decimal val_10 = new System.Decimal(value:  100);
            val_45 = null;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = R4, hi = R5, lo = R6, mid = R7}, d2:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid})) != false)
            {
                    System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_12 = RestaurantRivals.RESGameEcon.LevelDefs;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                decimal val_13 = val_10.flags.TotalBuildCost;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                decimal val_14 = new System.Decimal(value:  100);
                decimal val_15 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 555432800, hi = R4, lo = R5, mid = R6}, d2:  new System.Decimal() {flags = ???, hi = val_14.flags, lo = val_14.hi, mid = val_14.lo});
                decimal val_17 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 555432784, hi = val_10.flags, lo = val_10.hi, mid = val_10.lo}, d2:  new System.Decimal() {flags = val_10.mid});
                decimal val_19 = new System.Decimal(value:  1000000);
                decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 555432752, hi = R4, lo = R5, mid = R6}, d2:  new System.Decimal() {flags = val_18, hi = val_19.flags, lo = val_19.hi, mid = val_19.lo});
                decimal val_22 = System.Decimal.Round(d:  new System.Decimal() {flags = 555432736}, decimals:  val_21);
                decimal val_27 = new System.Decimal(value:  1000000);
                decimal val_28 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 555432704, hi = val_23, lo = val_24, mid = val_25}, d2:  new System.Decimal() {flags = val_26, hi = val_27.flags, lo = val_27.hi, mid = val_27.lo});
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                UnityEngine.Debug.LogErrorFormat(format:  555418336, args:  472754880);
                string val_33 = ToString(format:  555418480);
                typeof(System.Object[]).__il2cppRuntimeField_10 = ;
                string val_34 = ToString(format:  555418480);
                typeof(System.Object[]).__il2cppRuntimeField_14 = ;
                UnityEngine.Debug.LogErrorFormat(format:  555418560, args:  472754880);
                string val_35 = ToString(format:  555418480);
                typeof(System.Object[]).__il2cppRuntimeField_10 = ;
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                UnityEngine.Debug.LogErrorFormat(format:  555418688, args:  472754880);
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                UnityEngine.Debug.LogErrorFormat(format:  555418848, args:  472754880);
                val_45 = null;
                set_Item(index:  0, value:  new System.Decimal() {flags = val_31, hi = val_29, lo = val_32, mid = val_30});
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_48 = 1152921505700904988;
            val_49 = 1152921505700904984;
            val_50 = 1152921505700904980;
            val_51 = 1152921505700904976;
            val_52 = 0;
            goto label_56;
            label_12:
            var val_38 = 0;
            val_53 = 0;
            val_38 = val_38 + 1;
            mem2[0] = 509;
            goto label_99;
            label_56:
            ReturnGameGiftReward val_36 = new ReturnGameGiftReward(_tier:  1, _coins:  new System.Decimal() {flags = List<T>.__il2cppRuntimeField_10, hi = List<T>.__il2cppRuntimeField_14, lo = List<T>.__il2cppRuntimeField_18, mid = List<T>.__il2cppRuntimeField_1C}, _spins:  new System.Decimal() {hi = mem[1152921504617021448], lo = mem[1152921504617021452], mid = mem[1152921504617021456]});
            var val_39 = val_38;
            val_38 = 555432576;
            val_53 = 0;
            val_39 = val_39 + 1;
            mem2[0] = 580;
            val_42 = level;
            val_39 = 555432916;
            label_99:
            val_3.Dispose();
            var val_41 = val_39;
            if(val_41 == 1)
            {
                goto label_61;
            }
            
            var val_40 = val_38 + (((0 + 1) + 1)) << 2;
            if(val_40 == 580)
            {
                goto label_62;
            }
            
            val_40 = val_40 - 509;
            val_40 = val_40 >> 5;
            if(val_41 > 1)
            {
                    0 = 1;
            }
            
            val_40 = 1 & val_40;
            val_41 = val_41 - val_40;
            goto label_63;
            label_61:
            label_63:
            var val_42 = 0;
            val_42 = val_42 + 1;
            goto label_64;
            label_6:
            var val_43 = 0;
            val_43 = val_43 + 1;
            mem2[0] = 557;
            val_3.Dispose();
            var val_45 = val_40;
            if(val_43 != 1)
            {
                    var val_44 = 1152921513752214144 + ((0 + 1)) << 2;
                if(val_44 == 580)
            {
                    return;
            }
            
                val_44 = val_44 - 557;
                val_44 = val_44 >> 5;
                if(val_43 > 1)
            {
                    0 = 1;
            }
            
                val_44 = 1 & val_44;
                val_43 = val_43 - val_44;
            }
            
            val_45 = val_45 + 1;
            goto label_103;
            label_62:
            val_3.Dispose();
        }
        public RESGameEcon()
        {
            System.Collections.Generic.List<RestaurantRivals.RESLevelChestData> val_1 = new System.Collections.Generic.List<RestaurantRivals.RESLevelChestData>();
            RestaurantRivals.RESLevelChestData val_2 = new RestaurantRivals.RESLevelChestData(_level:  2, _spins:  25);
            Add(item:  new RestaurantRivals.RESLevelChestData() {restaurantLevel = val_2.restaurantLevel, spins = val_2.spins});
            this.levelChests = null;
            this.dailyBonusMinRewardPercentage = 50f;
            this.dailyBonusMaxRewardPercentage = 100f;
            this.onlineMinOffensiveInterval = 10;
            this.daysOfOffensiveActionsPostSession = 2;
            this.attackLowSuccessRate = 20f;
            this.attackHighSuccessRate = 80f;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            if(val_3 != 0)
            {
                    Add(item:  25);
                Add(item:  25);
                Add(item:  25);
            }
            else
            {
                    Add(item:  25);
                Add(item:  25);
                Add(item:  25);
            }
            
            Add(item:  25);
            this.raidPickerWeights = val_3;
            decimal val_4 = new System.Decimal(lo:  3, mid:  0, hi:  0, isNegative:  false, scale:  3);
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            if(val_5 != 0)
            {
                    Add(item:  127);
                Add(item:  693);
                Add(item:  971);
                Add(item:  1248);
                Add(item:  1525);
                Add(item:  1941);
                Add(item:  1109);
                Add(item:  693);
                Add(item:  555);
                Add(item:  416);
                Add(item:  277);
                Add(item:  139);
                Add(item:  139);
                Add(item:  111);
                Add(item:  28);
                Add(item:  14);
            }
            else
            {
                    Add(item:  127);
                Add(item:  693);
                Add(item:  971);
                Add(item:  1248);
                Add(item:  1525);
                Add(item:  1941);
                Add(item:  1109);
                Add(item:  693);
                Add(item:  555);
                Add(item:  416);
                Add(item:  277);
                Add(item:  139);
                Add(item:  139);
                Add(item:  111);
                Add(item:  28);
                Add(item:  14);
            }
            
            Add(item:  14);
            this.raidRankWeights = val_5;
            System.Collections.Generic.List<System.Single> val_6 = new System.Collections.Generic.List<System.Single>();
            if(null != 0)
            {
                    Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
            }
        
        }
        private static RESGameEcon()
        {
            if(mem[35634557] != true)
            {
                
            }
        
        }
    
    }

}
