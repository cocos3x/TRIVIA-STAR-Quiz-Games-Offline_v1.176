using UnityEngine;
public class TRVEcon : GameEcon
{
    // Fields
    private static bool overridenInitialValues;
    public float quizDuration;
    public int extraLifeCost;
    public int extraLifeCoolDown;
    public int categoryRerollCost;
    public int veryEasyLevelLimit;
    public int ftux2LevelLimit;
    public int levelsPerChapter;
    public int chapterReward;
    private int _quizEntryCost;
    public float quizRewardConstant;
    public bool doubleChapterRewardEnabled;
    public int playLastCategoryCost;
    public int rewardedVideoGemReward;
    public int hintReminderUnlockLevel;
    public bool hintReminderEnabled;
    public int hintReminderLevelInterval;
    public int hintReminderMaxViews;
    public int videosForExtraLife;
    public int askExpertGemCost;
    public int expertCooldownHours;
    public int earlyCategoryUnlockCost;
    public int earlyCategoryUnlockLevel;
    public int variableEntryUnlock;
    public int maxStreak;
    public bool variableLevelCompleteRewardEnabled;
    public int multiplierRedrawUnlockLevel;
    public int expertsUnlockLevel;
    public int maxExtraLives;
    public bool bonusRewardedLivesEnabled;
    public int moreCategoriesShowLevel;
    public int[] variableEntryCost;
    public int[] variableMultipliers;
    private System.Collections.Generic.List<BonusRewardsContainer> trvBonusRewardDefaultData;
    public System.Collections.Generic.Dictionary<TRVExpertRarites, int> expertOdds;
    private System.Collections.Generic.List<GiftRewardTier> returnList;
    private static System.Collections.Generic.List<GiftRewardTier> TRVDailyBonusCoinRewardTiersV2;
    public TRVQotdEcon qotdEcon;
    public decimal startingCoins;
    public int startingGems;
    public int lowGemThreshold;
    private System.Collections.Generic.List<GiftRewardTypeChance> TRVDailyBonusRewardChances;
    public System.Collections.Generic.Dictionary<TRVCategoryID, int> primaryCategoryOdds;
    public System.Collections.Generic.Dictionary<ChestType, System.Collections.Generic.List<int>> chestRewardMultis;
    public System.Collections.Generic.Dictionary<ChestType, int> chestWeights;
    public System.Collections.Generic.Dictionary<int, int[]> quizDifficultyOrders;
    public System.Collections.Generic.Dictionary<int, int[]> FTUX2quizDifficultyOrders;
    public int[] initialQuizLength;
    public int[] quizLengthArray;
    private System.Collections.Generic.Dictionary<int, int> quizLengthBucketA;
    private System.Collections.Generic.Dictionary<int, int> quizLengthBucketB;
    public static System.Collections.Generic.Dictionary<string, int> DefaultCategoryUnlockLevels;
    public System.Collections.Generic.Dictionary<TRVPowerupType, PowerupEcon> PowerupData;
    public System.Collections.Generic.Dictionary<int, TRVCategoryRankInfo> TRVCategoryRankEcon;
    public TriviaMastersEcon TriviaMastersEventEcon;
    public TriviaPursuitEcon TriviaPursuitEventEcon;
    public System.Collections.Generic.List<StarChampionshipTier> StarChampionshipEventEcon;
    
    // Properties
    public int defaultQuizEntryCost { get; }
    public int dynamicQuizEntryCost { get; }
    public override System.Collections.Generic.List<BonusRewardsContainer> bonusRewardTiers { get; }
    public System.Collections.Generic.List<GiftRewardTier> DailyBonusTiersV2 { get; }
    public override int ltb_interval { get; }
    public System.Collections.Generic.List<GiftRewardTypeChance> DailyBonusRewardChances { get; }
    public System.Collections.Generic.Dictionary<int, int> quizLength { get; }
    
    // Methods
    public int get_defaultQuizEntryCost()
    {
        return (int)this._quizEntryCost;
    }
    public int get_dynamicQuizEntryCost()
    {
        int val_6;
        var val_7;
        int val_8;
        Player val_1 = App.Player;
        val_6 = this.variableEntryUnlock;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  val_6)) != false)
        {
                val_6 = 1152921504967548928;
            if(TRVMainController.currentMultiplier >= 0)
        {
                if(TRVMainController.currentMultiplier < TRVMainController.currentMultiplier)
        {
                val_7 = 1152921504762277888;
            val_8 = this.variableEntryCost[TRVMainController.currentMultiplier];
            return UnityEngine.Mathf.Max(a:  100, b:  val_8 = this._quizEntryCost);
        }
        
        }
        
        }
        
        val_7 = 1152921504762277888;
        return UnityEngine.Mathf.Max(a:  100, b:  val_8);
    }
    public override System.Collections.Generic.List<BonusRewardsContainer> get_bonusRewardTiers()
    {
    
    }
    public System.Collections.Generic.List<GiftRewardTier> get_DailyBonusTiersV2()
    {
        if(true != 0)
        {
                return;
        }
        
        this.returnList = null;
        this.returnList = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_3 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_5 = new GiftRewardTier(threshold:  -1830317488, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_7 = new GiftRewardTier(threshold:  -1458517120, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_9 = new GiftRewardTier(threshold:  -1649822208, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_11 = new GiftRewardTier(threshold:  -1649822128, rewards:  80883712);
        Add(item:  373055488);
        this.returnList = this.returnList;
    }
    public override int get_ltb_interval()
    {
        return 4;
    }
    public System.Collections.Generic.List<GiftRewardTypeChance> get_DailyBonusRewardChances()
    {
    
    }
    public System.Collections.Generic.Dictionary<int, int> get_quizLength()
    {
        Player val_1 = App.Player;
        string val_2 = 33449456.ToLower();
        bool val_3 = System.String.op_Equality(a:  33449456, b:  -1953384624);
    }
    public override void ReadFromKnobs()
    {
        var val_38;
        TRVQotdEcon val_39;
        float val_40;
        TRVReward val_41;
        var val_42;
        this.ReadFromKnobs();
        Dictionary.KeyCollection<TKey, TValue> val_1 = 0.Keys;
        if(0.Count <= 1)
        {
            goto label_6;
        }
        
        if((0.ContainsKey(key:  -531366784)) != false)
        {
                string val_4 = 0.Item[-531366784];
            bool val_6 = System.Int32.TryParse(s:  null, result: out  this.veryEasyLevelLimit);
        }
        
        if((0.ContainsKey(key:  -531366704)) != false)
        {
                string val_8 = 0.Item[-531366704];
            bool val_10 = System.Int32.TryParse(s:  null, result: out  this.extraLifeCoolDown);
        }
        
        if((0.ContainsKey(key:  -531366624)) != false)
        {
                string val_12 = 0.Item[-531366624];
            bool val_14 = System.Boolean.TryParse(value:  null, result: out  this.doubleChapterRewardEnabled);
        }
        
        if((0.ContainsKey(key:  -531366544)) == false)
        {
            goto label_51;
        }
        
        string val_16 = 0.Item[-531366544];
        val_38 = 1;
        if((0.ContainsKey(key:  -1640018224)) != false)
        {
                string val_18 = 0.Item[-1640018224];
            bool val_20 = System.Int32.TryParse(s:  null, result: out  this.qotdEcon.unlockLevel);
            val_38 = val_38;
        }
        
        if((0.ContainsKey(key:  -1605526400)) == false)
        {
            goto label_46;
        }
        
        string val_22 = 0.Item[-1605526400];
        if((0.ContainsKey(key:  -1785508240)) == false)
        {
            goto label_37;
        }
        
        string val_24 = 0.Item[-1785508240];
        bool val_26 = System.Int32.TryParse(s:  null, result: out  int val_25 = -531350104);
        val_39 = this.qotdEcon;
        val_40 = 0f;
        val_41 = null;
        val_42 = 0;
        goto label_40;
        label_6:
        UnityEngine.Debug.LogWarning(message:  -531362368);
        goto label_43;
        label_37:
        if((0.ContainsKey(key:  -1968282976)) == false)
        {
            goto label_46;
        }
        
        string val_28 = 0.Item[-1968282976];
        bool val_30 = System.Int32.TryParse(s:  null, result: out  int val_29 = -531350108);
        val_39 = this.qotdEcon;
        val_40 = 0f;
        TRVReward val_31 = null;
        val_41 = val_31;
        val_42 = 1;
        label_40:
        val_31 = new TRVReward(rewardType:  1, rewardAmount:  0);
        this.qotdEcon.normalReward = val_41;
        label_46:
        if((0.ContainsKey(key:  -531362144)) != false)
        {
                string val_33 = 0.Item[-531362144];
            if((0.ContainsKey(key:  -1785508240)) != false)
        {
                string val_35 = 0.Item[-1785508240];
            bool val_37 = System.Int32.TryParse(s:  null, result: out  int val_36 = -531350112);
        }
        
        }
    
    }
    public TRVEcon()
    {
        this.quizDuration = 30f;
        this.quizRewardConstant = 0.5f;
        this.doubleChapterRewardEnabled = true;
        this.playLastCategoryCost = 30;
        this.rewardedVideoGemReward = 15;
        this.hintReminderUnlockLevel = 10;
        this.hintReminderEnabled = true;
        this.hintReminderLevelInterval = 5;
        this.multiplierRedrawUnlockLevel = 8;
        this.expertsUnlockLevel = 5;
        this.maxExtraLives = 3;
        this.moreCategoriesShowLevel = 2;
        this.variableEntryCost = null;
        this.variableMultipliers = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        BonusRewardsContainer val_2 = new BonusRewardsContainer(lvl:  0, ptrq:  0, bonusGC:  0, bonusGems:  0, bonusCoins:  0);
        Add(item:  368795648);
        BonusRewardsContainer val_3 = new BonusRewardsContainer(lvl:  1, ptrq:  200, bonusGC:  10, bonusGems:  5, bonusCoins:  5);
        Add(item:  368795648);
        BonusRewardsContainer val_4 = new BonusRewardsContainer(lvl:  2, ptrq:  500, bonusGC:  20, bonusGems:  10, bonusCoins:  5);
        Add(item:  368795648);
        BonusRewardsContainer val_5 = new BonusRewardsContainer(lvl:  3, ptrq:  700, bonusGC:  30, bonusGems:  10, bonusCoins:  10);
        Add(item:  368795648);
        BonusRewardsContainer val_6 = new BonusRewardsContainer(lvl:  4, ptrq:  1200, bonusGC:  40, bonusGems:  15, bonusCoins:  10);
        Add(item:  368795648);
        BonusRewardsContainer val_7 = new BonusRewardsContainer(lvl:  5, ptrq:  1900, bonusGC:  50, bonusGems:  15, bonusCoins:  20);
        Add(item:  368795648);
        BonusRewardsContainer val_8 = new BonusRewardsContainer(lvl:  6, ptrq:  3100, bonusGC:  60, bonusGems:  25, bonusCoins:  25);
        Add(item:  368795648);
        BonusRewardsContainer val_9 = new BonusRewardsContainer(lvl:  7, ptrq:  5000, bonusGC:  70, bonusGems:  30, bonusCoins:  30);
        Add(item:  368795648);
        BonusRewardsContainer val_10 = new BonusRewardsContainer(lvl:  8, ptrq:  8100, bonusGC:  80, bonusGems:  35, bonusCoins:  35);
        Add(item:  368795648);
        BonusRewardsContainer val_11 = new BonusRewardsContainer(lvl:  9, ptrq:  13100, bonusGC:  90, bonusGems:  40, bonusCoins:  40);
        Add(item:  368795648);
        BonusRewardsContainer val_12 = new BonusRewardsContainer(lvl:  10, ptrq:  21200, bonusGC:  100, bonusGems:  50, bonusCoins:  50);
        Add(item:  368795648);
        mem[1152921512665579496] = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_13 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                Add(key:  1, value:  40);
            Add(key:  2, value:  30);
            Add(key:  3, value:  20);
        }
        else
        {
                Add(key:  1, value:  40);
            Add(key:  2, value:  30);
            Add(key:  3, value:  20);
        }
        
        Add(key:  4, value:  10);
        mem[1152921512665579500] = null;
        mem[1152921512665579508] = new TRVQotdEcon();
        decimal val_15 = new System.Decimal(value:  2500);
        mem[1152921512665579528] = 500;
        mem[1152921512665579532] = 100;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_16 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GiftRewardTypeChance val_17 = new GiftRewardTypeChance(rewardType:  0, chance:  100);
        Add(item:  372948992);
        GiftRewardTypeChance val_18 = new GiftRewardTypeChance(rewardType:  3, chance:  100);
        Add(item:  372948992);
        GiftRewardTypeChance val_19 = new GiftRewardTypeChance(rewardType:  3, chance:  80);
        Add(item:  372948992);
        GiftRewardTypeChance val_20 = new GiftRewardTypeChance(rewardType:  3, chance:  20);
        Add(item:  372948992);
        mem[1152921512665579536] = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_21 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                Add(key:  2, value:  20);
            Add(key:  1, value:  40);
        }
        else
        {
                Add(key:  2, value:  20);
            Add(key:  1, value:  40);
        }
        
        Add(key:  0, value:  40);
        mem[1152921512665579540] = null;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_22 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  2);
        }
        else
        {
                Add(item:  2);
            Add(item:  2);
        }
        
        Add(item:  4);
        Add(key:  0, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  3);
            Add(item:  4);
        }
        else
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  3);
            Add(item:  4);
        }
        
        Add(item:  5);
        Add(key:  1, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  3);
            Add(item:  4);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
        }
        else
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  3);
            Add(item:  4);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
        }
        
        Add(item:  7);
        Add(key:  2, value:  80883712);
        mem[1152921512665579544] = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_26 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                Add(key:  0, value:  60);
            Add(key:  1, value:  30);
        }
    
    }
    private static TRVEcon()
    {
        TRVEcon.overridenInitialValues = false;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_3 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_5 = new GiftRewardTier(threshold:  -1830317488, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_7 = new GiftRewardTier(threshold:  -1458517120, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_9 = new GiftRewardTier(threshold:  -1649822208, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_11 = new GiftRewardTier(threshold:  -1649822128, rewards:  80883712);
        Add(item:  373055488);
        TRVEcon.TRVDailyBonusCoinRewardTiersV2 = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_12 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        if(null != 0)
        {
                Add(key:  -531115504, value:  0);
        }
        else
        {
                Add(key:  -531115504, value:  0);
        }
        
        Add(key:  -1929660112, value:  0);
        if(null != 0)
        {
                Add(key:  -607030864, value:  2);
        }
        else
        {
                Add(key:  -607030864, value:  2);
        }
        
        Add(key:  -1729808800, value:  5);
        if(null != 0)
        {
                Add(key:  -531115408, value:  12);
        }
        else
        {
                Add(key:  -531115408, value:  12);
        }
        
        Add(key:  -531115296, value:  19);
        if(null != 0)
        {
                Add(key:  -531115200, value:  26);
        }
        else
        {
                Add(key:  -531115200, value:  26);
        }
        
        Add(key:  -531115104, value:  33);
        if(null != 0)
        {
                Add(key:  -747330944, value:  40);
        }
        else
        {
                Add(key:  -747330944, value:  40);
        }
        
        Add(key:  -531115024, value:  47);
        if(null != 0)
        {
                Add(key:  -531114928, value:  54);
        }
        else
        {
                Add(key:  -531114928, value:  54);
        }
        
        Add(key:  -531114832, value:  61);
        if(null != 0)
        {
                Add(key:  -531114736, value:  68);
        }
        else
        {
                Add(key:  -531114736, value:  68);
        }
        
        Add(key:  -531114656, value:  75);
        if(null != 0)
        {
                Add(key:  -531114560, value:  82);
        }
        else
        {
                Add(key:  -531114560, value:  82);
        }
        
        Add(key:  -531114464, value:  89);
        if(null != 0)
        {
                Add(key:  -531114368, value:  96);
        }
        else
        {
                Add(key:  -531114368, value:  96);
        }
        
        Add(key:  -531114288, value:  103);
        if(null != 0)
        {
                Add(key:  -531114208, value:  110);
        }
        else
        {
                Add(key:  -531114208, value:  110);
        }
        
        Add(key:  -531114112, value:  117);
        if(null != 0)
        {
                Add(key:  -531114016, value:  125);
        }
        else
        {
                Add(key:  -531114016, value:  125);
        }
        
        Add(key:  -531113936, value:  131);
        if(null != 0)
        {
                Add(key:  -531113840, value:  145);
        }
        else
        {
                Add(key:  -531113840, value:  145);
        }
        
        Add(key:  -531113760, value:  14);
        if(null != 0)
        {
                Add(key:  -531113664, value:  11);
        }
        else
        {
                Add(key:  -531113664, value:  11);
        }
        
        Add(key:  -607029536, value:  3);
        if(null != 0)
        {
                Add(key:  -531113568, value:  9);
        }
        else
        {
                Add(key:  -531113568, value:  9);
        }
        
        Add(key:  -531113472, value:  18);
        if(null != 0)
        {
                Add(key:  -531113392, value:  27);
        }
        else
        {
                Add(key:  -531113392, value:  27);
        }
        
        Add(key:  -531113312, value:  36);
        if(null != 0)
        {
                Add(key:  -531113232, value:  42);
        }
        else
        {
                Add(key:  -531113232, value:  42);
        }
        
        Add(key:  -607028768, value:  45);
        if(null != 0)
        {
                Add(key:  -531113136, value:  65);
        }
        else
        {
                Add(key:  -531113136, value:  65);
        }
        
        Add(key:  -531113056, value:  74);
        if(null != 0)
        {
                Add(key:  -531112960, value:  83);
        }
        else
        {
                Add(key:  -531112960, value:  83);
        }
        
        Add(key:  -607029984, value:  0);
        if(null != 0)
        {
                Add(key:  -531112864, value:  0);
        }
        else
        {
                Add(key:  -531112864, value:  0);
        }
        
        Add(key:  -531112768, value:  1);
        if(null != 0)
        {
                Add(key:  -607028368, value:  7);
        }
        else
        {
                Add(key:  -607028368, value:  7);
        }
        
        Add(key:  -607029232, value:  16);
        if(null != 0)
        {
                Add(key:  -531112688, value:  25);
        }
        else
        {
                Add(key:  -531112688, value:  25);
        }
        
        Add(key:  -607029040, value:  34);
        if(null != 0)
        {
                Add(key:  -531112592, value:  43);
        }
        else
        {
                Add(key:  -531112592, value:  43);
        }
        
        Add(key:  -531112496, value:  52);
        if(null != 0)
        {
                Add(key:  -607030464, value:  62);
        }
        else
        {
                Add(key:  -607030464, value:  62);
        }
        
        Add(key:  -531112400, value:  70);
        if(null != 0)
        {
                Add(key:  -531112288, value:  79);
        }
        else
        {
                Add(key:  -531112288, value:  79);
        }
        
        Add(key:  -531112192, value:  88);
        if(null != 0)
        {
                Add(key:  -607028592, value:  97);
        }
    
    }

}
