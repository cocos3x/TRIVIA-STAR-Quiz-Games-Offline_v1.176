using UnityEngine;
public class GameEcon
{
    // Fields
    public string numberFormatInt;
    public static string numberFormatDecimal;
    private string _titleFormat;
    private bool _formatSet;
    private decimal _base099CreditPackSize;
    private decimal _base199CreditPackSize;
    private decimal _base299CreditPackSize;
    private decimal _base499CreditPackSize;
    private decimal _base999CreditPackSize;
    private decimal _base1999CreditPackSize;
    private decimal _base4999CreditPackSize;
    private decimal _base099GemPackSize;
    public decimal InitialPlayerCoins;
    public int InitialPlayerGems;
    public int InitialPlayerGoldenCurrency;
    private decimal _HintCost;
    private decimal _HintPickerCost;
    private decimal _HintMEGACost;
    public float ChapterClearedRewardMulitplier;
    private decimal InitialChapterClearedReward;
    public int InitialExtraWordsReq;
    public int ExtraWordsIncrement;
    public int ExtraWordsMaxReq;
    public decimal ExtraWordsReward;
    public decimal videoAdReward;
    public decimal nonPurchaserVidReward;
    public decimal oneTimePurchaserVidReward;
    public decimal repeatPurchaserVidReward;
    public decimal videoAdRewardBonusCollect;
    public int NoAdsStarterPackCoinAmount;
    public float NoAdsPackagePriceToUse;
    public float fallbackNoAdsPackagePriceToUse;
    public decimal fbConnectBonus;
    public int dailyBonusHours;
    public System.Collections.Generic.Dictionary<int, DailyBonusTier> dailyBonusTiers;
    public System.Collections.Generic.List<int> dailyBonusVideoRewards;
    public LimitedTimeBundlesEcon LimitedTimeBundlesEcon;
    public int subscriptionPromoPostDailyBonusLevel;
    public decimal ratingReward;
    public decimal wordCoinBonus;
    public decimal emailCollectReward;
    public int emailCollectTimeoutDays;
    public int freeHintPopupLevel;
    public int freeHintPostDailyBonus;
    public int adsControlPopupLevel;
    public int adsControlButtonLevel_max;
    public int adsControlMaxViews;
    public int emailCollectPopupLevel;
    public int extraReqBeginningChapter;
    public int extraReqDefaultLevelsPerChapter;
    public int extraReqIncrement;
    public int extraReqMaxLevelsPerChapter;
    public int extraReqHintsPerCh_BuyNone;
    public int extraReqHintsPerCh_BuyFirst;
    public int extraReqHintsPerCh_BuyRepeat;
    public int extraReqQuantityPerLevel;
    public int extraReqPostPurchaseLvl;
    public int extraReqPostPurchaseMin;
    public int extraReqPostPurchaseMax;
    public int remLevelWordMax;
    public int remWordRemovalPercentage;
    public int hintTutorialLevel;
    public int hintTutorialLevelV2;
    public int hintPickerTutorialLevel;
    public int hintPickerTutorialLevelV2;
    public int hintMEGATutorialLevel;
    public int FInviterLevelComplete;
    public int FInviterCoinsReward;
    public int FInviterFTUX;
    public int FInviter_BR_I;
    public int FInviter_BR_R;
    public int FInviter_SI_I;
    public int FInviter_SI_R;
    public int FInviter_GO_I;
    public int FInviter_GO_R;
    public bool FInviterEnabled;
    public int RecLevel;
    public int RecInterval;
    public int RecLimit;
    public int RecDelay;
    public int difficultySettingPromptLevel;
    public int difficultySettingHintDiscount;
    public int levelGenStartLevel;
    public float plvDesiredNumReqWordsBase;
    public float plvDesiredNumReqWordsIncrement;
    public float plvDesiredNumReqWordsMax;
    public int plvMaxExtraWords;
    public float[] plvReqWordDeviations;
    public int[] plvExtraWordCounts;
    public int[] plvNumWordLengths;
    public float plvDesiredWordLengthBase;
    public float plvDesiredWordLengthIncrement;
    public int plvLettersArrayIncrement;
    public float plvWordLengthMax;
    public int plvNumLettersMax;
    public float plvGivenLettersBase;
    public float plvGivenLettersDecrement;
    public float plvGivenLettersMin;
    public float[] plvWordLengthDeviations;
    public int[] plvLettersArray;
    public int plvHintsPerCh_BuyNone;
    public int plvHintsPerCh_BuyFirst;
    public int plvHintsPerCh_BuyRepeat;
    public float wsaDefaultGridSize;
    public float wsaDefaultGridSizeIncrement;
    public float wsaMaximumGridSize;
    public int wsaMysteryWordIncrement;
    public int wsaMaxMysteryWordQuantity;
    public int ChapterHintThresholdNonBuyer;
    public int ChapterHintThresholdFirstTimeBuyer;
    public int ChapterHintThresholdRepeatBuyer;
    public bool coinStorePack1Override;
    public int scsStandardEntryCost;
    public int scsVideosPerLuckyCash;
    public int scsMinimumCashOutBankBalance;
    private int hintDiscountSizePercent;
    public int hintDiscountChapterMinutes;
    public int hintDiscountDailyBonusMinutes;
    public int hintDiscountChapterFreq;
    public float extraChapterEventMultiplier;
    public int alphabetOneMoreCost;
    public System.Collections.Generic.List<object> alphabetRewards;
    public int starUnlockLevel;
    public System.Collections.Generic.Dictionary<string, object> goalsHashes;
    public int starRowDif;
    public int starStreakDif;
    public int mysteryGiftUnlockLevel;
    public int mysteryGiftFlyoutLevelInterval;
    public int mysteryGiftReward;
    public int finalForcedLetterLayoutLevel;
    public int storyPopupLevel;
    public System.Collections.Generic.List<int> WADHardLevels;
    public int hintPickerUnlockLevel;
    public int hintPickerUnlockLevelV2;
    public int shuffleHintFtuxLevel;
    public int leaguesUnlockLevel;
    public bool ftuxTutorialEnabled;
    public int maxLevelEasyLetters;
    public int postLevelRewardedVideo_Level;
    public int postLevelRewardedVideo_minLevels;
    public int postLevelRewardedVideo_maxLevels;
    public float postLevelRewardedVideo_freq;
    public float postLevelCollectionTile_freq;
    public float postLevelAdsControl_freq;
    public int postLevelAdsControl_duration;
    public int postLevelAdsControl_minLvl;
    public int notificationPromptUnlockLevel;
    public int notificationUnlockInterval;
    public int notificationUnlockAppearances;
    public bool offersEnabled;
    public bool surveysEnabled;
    public decimal ab_completeCollectionReward;
    public int ab_minLevelsPerTile;
    public int ab_maxLevelsPerTile;
    public int ab_postLevelTileFreq_Modulo;
    public int ab_unlockLevel;
    public decimal ab_redrawCoinCost;
    public int[] bonusGameWheelAwardCoins;
    public int[] bonusGameWheelAwardGoldenCurrency;
    public bool starterPackEnabled;
    public int starterPackLevel;
    public System.TimeSpan starterPackTimeSpan;
    public System.TimeSpan starterPackWaterfalDelay;
    public int FOMOPackUnlockedLevel;
    public decimal FOMOMaxBalance;
    public int FOMOLevelInterval;
    public System.TimeSpan FOMOPackTimeSpan;
    private int _challengeWordsunlockLevel;
    private int _challengeWordsLevelCooldown;
    private int _challengeWordsWordChance;
    public int events_unlockLevel;
    public int freeHintFinalLevel;
    public int freeHintInitialTooltip;
    public int freeHintEndingTooltip;
    public int spHintsPerLevel;
    public float spHintConstant;
    public int spHintStartLevel;
    public int spHintEndLevel;
    public float WIQ_BaseIQ;
    public float WIQ_MaxNEWWORDIQCompensation;
    public float WIQ_LevelClearIQCompensation_a;
    public float WIQ_LevelClearIQCompensation_b;
    public float WIQ_BaseNewWordPoint;
    public float WIQ_LetterPoint;
    public float WIQ_NEWWORDMultiplier;
    public float WIQ_BaseClearPoints_min;
    public float WIQ_BaseClearPoints_max;
    public float WIQ_HighestComplexity;
    public float WIQ_MaxAdditionalClearPoints;
    public float[] WIQ_Milestones;
    public int categoryUnlockLevel;
    public string categoryShowLevelsDisplay;
    public decimal categoryChapterReward;
    public bool categoryShowButtonLocked;
    public int categoryCompletionGoal;
    public int categoryCompletionCountIncrease;
    public int categoryCompletionGoalMax;
    public int categoryMaxRequiredWords;
    public int watchAdForSpinUnlockSpins;
    public int watchAdForCoinUnlockLevel;
    public int nonPurchaserCap;
    public int lowPurchaserCap;
    public int highPurchaserCap;
    public int repeatPurchaserCap;
    public int dbFtuxLevel;
    public int dbFtuxCr;
    public int hintMeterFreeHints;
    public int storeButtonDisplayLevel;
    public int friendInvButtonDisplayLevel;
    public int alphButtonDisplayLevel;
    public int iqButtonDisplayLevel;
    public int dcButtonDisplayLevel;
    public int leaguesButtonDisplayLevel;
    public int libraryButtonDisplayLevel;
    public int categoriesButtonDisplayLevel;
    public int eventButtonDisplayLevel;
    public bool levelSkipEnabled;
    public float lifetime099SpendLimit;
    public int goldenAppleFtuxLevel;
    public int definitionFtuxLevel;
    public int newUserTaskUnlock;
    public bool gm_enabled;
    public float gm_defaultMultiplier;
    public float gm_defaultMultiplierCost;
    public float gm_multiplierIncrement;
    public float gm_costIncrementCoefficient;
    public float gm_maxGoldenMultiplier;
    public int caf_unlockLevel;
    public int caf_frequencyShown;
    public decimal caf_reward_coins;
    public PrizeBalloon.Econ prize_balloon_econ;
    protected twelvegigs.storage.JsonDictionary knobsConfigjs;
    private twelvegigs.storage.JsonDictionary otherKnobsConfigjs;
    private System.Collections.Generic.Dictionary<string, object> minigameUnlockLevels;
    public int ltb_unlockLevel;
    public bool ss_enabled;
    public int ss_min_offer;
    public int ss_cost_multiplier;
    private System.Collections.Generic.List<BonusRewardsContainer> _bonusRewardDefaultData;
    
    // Properties
    public string titleFormat { get; }
    public decimal base099CreditPackSize { get; }
    public decimal base199CreditPackSize { get; }
    public decimal base299CreditPackSize { get; }
    public decimal base499CreditPackSize { get; }
    public decimal base999CreditPackSize { get; }
    public decimal base1999CreditPackSize { get; }
    public decimal base4999CreditPackSize { get; }
    public decimal base099GemPackSize { get; }
    public int ExtraWordsTarget { get; }
    public decimal HintCost { get; }
    public decimal HintCostUnaltered { get; }
    public decimal HintCostDiscounted { get; }
    public decimal HintPickerCost { get; }
    public decimal HintPickerCostUnaltered { get; }
    public decimal HintPickerCostDiscounted { get; }
    public decimal HintMEGACost { get; }
    public decimal HintMEGACostUnaltered { get; }
    public decimal HintMEGACostDiscounted { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> GiftRewardTypeChances { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTier>> GiftRewardCoinRewardTiers { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardCoinAmountChances { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardFoodAmountChances { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardDiceRollAmountChances { get; }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardGoldenCurrencyAmountChances { get; }
    public decimal hintDiscountAmount { get; }
    public int maxBonusGameWheelAwardCoins { get; }
    public int maxBonusGameWheelAwardGoldenCurrency { get; }
    public int ChallengeWordsUnlockLevel { get; }
    public int ChallengeWordsLevelCooldown { get; }
    public int ChallengeWordsWordChance { get; }
    public virtual int ltb_interval { get; }
    public virtual float MiniReturnGameGiftOfflineHours { get; }
    public virtual int bonusRewardPointsPerDollarSpent { get; }
    public virtual System.Collections.Generic.List<BonusRewardsContainer> bonusRewardTiers { get; }
    
    // Methods
    public string get_titleFormat()
    {
        if(this._formatSet == true)
        {
                this._formatSet = this._titleFormat;
            return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        mem2[0] = 0;
        mem2[0] = 1;
    }
    public decimal get_base099CreditPackSize()
    {
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        var val_11;
        int val_12;
        int val_13;
        int val_14;
        var val_15;
        var val_16;
        val_7 = 0;
        val_8 = 1152921504617017344;
        val_9 = null;
        val_9 = null;
        val_12 = mem[R1 + 20 + (4)];
        val_13 = mem[R1 + 20 + (8)];
        val_14 = mem[R1 + 20 + (12)];
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = R1 + 20, hi = val_12, lo = val_13, mid = val_14}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_15 = 0;
        val_8 = 1152921504899072000;
        val_7 = "credits";
        goto label_4;
        label_15:
        if(("credits".Equals(obj:  PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  0))) == true)
        {
            goto label_7;
        }
        
        val_15 = 1;
        label_4:
        System.Collections.IList val_4 = PackagesManager.GetPackages(packageType:  2129282688);
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_11 = 0;
        val_10 = mem[mem[R1 + 20 + (12)] + 0];
        val_10 = mem[R1 + 20 + (12)] + 0;
        if(val_10 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        val_11 = (uint)val_7 & 65535;
        if(val_11 < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_16 = "credits";
        goto label_14;
        label_12:
        var val_5 = val_14 + 0;
        val_8 = val_8 + (((mem[R1 + 20 + (12)] + 0) + 4) << 3);
        val_16 = val_8 + 196;
        label_14:
        if(val_15 < "credits")
        {
            goto label_15;
        }
        
        label_7:
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319651584, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 20;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base199CreditPackSize()
    {
        int val_6;
        var val_7;
        var val_8;
        int val_9;
        var val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = mem[R1 + 36];
        val_6 = R1 + 36;
        val_7 = null;
        val_9 = mem[R1 + 36 + 12];
        val_9 = R1 + 36 + 12;
        val_7 = null;
        val_10 = 0;
        val_11 = mem[R1 + 36 + (4)];
        val_12 = mem[R1 + 36 + (8)];
        val_13 = val_9;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_6, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_8 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  0);
        val_10 = 1;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_6 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_9 = mem[R1 + 36 + 12 + 0];
        val_9 = R1 + 36 + 12 + 0;
        if(val_9 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_6;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 36 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_10 < val_6)
        {
            goto label_15;
        }
        
        var val_5 = val_10 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319539576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 36;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base299CreditPackSize()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = 1152921504617017344;
        val_7 = mem[R1 + 52];
        val_7 = R1 + 52;
        val_8 = null;
        val_8 = null;
        val_11 = mem[R1 + 52 + (4)];
        val_12 = mem[R1 + 52 + (8)];
        val_13 = R1 + 52 + 12;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_6 = 1;
        val_10 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  1);
        val_6 = 2;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_9 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_7 = mem[R1 + 52 + 12 + 0];
        val_7 = R1 + 52 + 12 + 0;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_9;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 52 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_6 < val_9)
        {
            goto label_15;
        }
        
        var val_5 = val_6 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319427576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 52;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base499CreditPackSize()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = 1152921504617017344;
        val_7 = mem[R1 + 68];
        val_7 = R1 + 68;
        val_8 = null;
        val_8 = null;
        val_11 = mem[R1 + 68 + (4)];
        val_12 = mem[R1 + 68 + (8)];
        val_13 = R1 + 68 + 12;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_6 = 1;
        val_10 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  1);
        val_6 = 2;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_9 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_7 = mem[R1 + 68 + 12 + 0];
        val_7 = R1 + 68 + 12 + 0;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_9;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 68 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_6 < val_9)
        {
            goto label_15;
        }
        
        var val_5 = val_6 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319315576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 68;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base999CreditPackSize()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = 1152921504617017344;
        val_7 = mem[R1 + 84];
        val_7 = R1 + 84;
        val_8 = null;
        val_8 = null;
        val_11 = mem[R1 + 84 + (4)];
        val_12 = mem[R1 + 84 + (8)];
        val_13 = R1 + 84 + 12;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_6 = 1;
        val_10 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  1);
        val_6 = 2;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_9 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_7 = mem[R1 + 84 + 12 + 0];
        val_7 = R1 + 84 + 12 + 0;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_9;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 84 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_6 < val_9)
        {
            goto label_15;
        }
        
        var val_5 = val_6 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319203576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 84;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base1999CreditPackSize()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = 1152921504617017344;
        val_7 = mem[R1 + 100];
        val_7 = R1 + 100;
        val_8 = null;
        val_8 = null;
        val_11 = mem[R1 + 100 + (4)];
        val_12 = mem[R1 + 100 + (8)];
        val_13 = R1 + 100 + 12;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_6 = 1;
        val_10 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  1);
        val_6 = 2;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_9 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_7 = mem[R1 + 100 + 12 + 0];
        val_7 = R1 + 100 + 12 + 0;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_9;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 100 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_6 < val_9)
        {
            goto label_15;
        }
        
        var val_5 = val_6 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -319091576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 100;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base4999CreditPackSize()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        val_6 = 1152921504617017344;
        val_7 = mem[R1 + 116];
        val_7 = R1 + 116;
        val_8 = null;
        val_8 = null;
        val_11 = mem[R1 + 116 + (4)];
        val_12 = mem[R1 + 116 + (8)];
        val_13 = R1 + 116 + 12;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_11, lo = val_12, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_6 = 1;
        val_10 = "credits";
        goto label_4;
        label_15:
        float val_2 = PackagesManager.GetPriceByIndex(packageType:  2129282688, index:  1);
        val_6 = 2;
        label_4:
        System.Collections.IList val_3 = PackagesManager.GetPackages(packageType:  2129282688);
        val_9 = "credits";
        string val_8 = "credits";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_7 = mem[R1 + 116 + 12 + 0];
        val_7 = R1 + 116 + 12 + 0;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_14 = val_9;
        goto label_14;
        label_12:
        var val_4 = val_13 + 0;
        val_8 = val_8 + (((R1 + 116 + 12 + 0) + 4) << 3);
        val_14 = val_8 + 196;
        label_14:
        if(val_6 < val_9)
        {
            goto label_15;
        }
        
        var val_5 = val_6 - 1;
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -318979576, packageIndex:  2129282688);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 116;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public decimal get_base099GemPackSize()
    {
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        var val_11;
        int val_12;
        int val_13;
        int val_14;
        var val_15;
        var val_16;
        val_7 = 0;
        val_8 = 1152921504617017344;
        val_9 = null;
        val_9 = null;
        val_12 = mem[R1 + 132 + (4)];
        val_13 = mem[R1 + 132 + (8)];
        val_14 = mem[R1 + 132 + (12)];
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = R1 + 132, hi = val_12, lo = val_13, mid = val_14}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        val_15 = 0;
        val_8 = 1152921504899072000;
        val_7 = "gems";
        goto label_4;
        label_15:
        if(("gems".Equals(obj:  PackagesManager.GetPriceByIndex(packageType:  -1930648496, index:  0))) == true)
        {
            goto label_7;
        }
        
        val_15 = 1;
        label_4:
        System.Collections.IList val_4 = PackagesManager.GetPackages(packageType:  -1930648496);
        string val_8 = "gems";
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        label_13:
        val_11 = 0;
        val_10 = mem[mem[R1 + 132 + (12)] + 0];
        val_10 = mem[R1 + 132 + (12)] + 0;
        if(val_10 == null)
        {
            goto label_12;
        }
        
        val_7 = val_7 + 1;
        val_11 = (uint)val_7 & 65535;
        if(val_11 < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_16 = "gems";
        goto label_14;
        label_12:
        var val_5 = val_14 + 0;
        val_8 = val_8 + (((mem[R1 + 132 + (12)] + 0) + 4) << 3);
        val_16 = val_8 + 196;
        label_14:
        if(val_15 < "gems")
        {
            goto label_15;
        }
        
        label_7:
        decimal val_6 = PackagesManager.GetCreditsAmountByIndex(packageType:  -318867584, packageIndex:  -1930648496);
        label_3:
        int val_9 = R1;
        val_9 = val_9 + 132;
        return new System.Decimal() {flags = val_9, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    public int get_ExtraWordsTarget()
    {
        if(Prefs.extraTarget != 0)
        {
                return Prefs.extraTarget;
        }
        
        Prefs.extraTarget = this.InitialExtraWordsReq;
        return Prefs.extraTarget;
    }
    public decimal get_HintCost()
    {
        return new System.Decimal() {flags = -318631520, hi = R1 + 172};
    }
    public decimal get_HintCostUnaltered()
    {
        return new System.Decimal() {flags = -318519520, hi = R1 + 172};
    }
    public decimal get_HintCostDiscounted()
    {
        int val_2;
        decimal val_1 = hintDiscountAmount;
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -318407520}, d2:  new System.Decimal() {flags = val_2, hi = R1 + 172, lo = R1 + 176, mid = R1 + 180});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    public decimal get_HintPickerCost()
    {
        return new System.Decimal() {flags = -318295520, hi = R1 + 188};
    }
    public decimal get_HintPickerCostUnaltered()
    {
        return new System.Decimal() {flags = -318183520, hi = R1 + 188};
    }
    public decimal get_HintPickerCostDiscounted()
    {
        int val_2;
        decimal val_1 = hintDiscountAmount;
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -318071520}, d2:  new System.Decimal() {flags = val_2, hi = R1 + 188, lo = R1 + 192, mid = R1 + 196});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    public decimal get_HintMEGACost()
    {
        return new System.Decimal() {flags = -317959520, hi = R1 + 204};
    }
    public decimal get_HintMEGACostUnaltered()
    {
        return new System.Decimal() {flags = -317847520, hi = R1 + 204};
    }
    public decimal get_HintMEGACostDiscounted()
    {
        int val_2;
        decimal val_1 = hintDiscountAmount;
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -317735520}, d2:  new System.Decimal() {flags = val_2, hi = R1 + 204, lo = R1 + 208, mid = R1 + 212});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> get_GiftRewardTypeChances()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 == 0)
        {
            
        }
    
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTier>> get_GiftRewardCoinRewardTiers()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 != 0)
        {
                return;
        }
    
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> get_GiftRewardCoinAmountChances()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 != 0)
        {
                return;
        }
    
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> get_GiftRewardFoodAmountChances()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 != 0)
        {
                return;
        }
    
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> get_GiftRewardDiceRollAmountChances()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 != 0)
        {
                return;
        }
    
    }
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> get_GiftRewardGoldenCurrencyAmountChances()
    {
        AppConfigs val_1 = App.Configuration;
        if(52 != 0)
        {
                return;
        }
    
    }
    public decimal get_hintDiscountAmount()
    {
        int val_3;
        decimal val_1 = System.Decimal.op_Implicit(value:  -316963568);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -316951520}, d2:  new System.Decimal() {flags = val_3, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    public int get_maxBonusGameWheelAwardCoins()
    {
        return (int)this.bonusGameWheelAwardCoins[1152921512879978911];
    }
    public int get_maxBonusGameWheelAwardGoldenCurrency()
    {
        return (int)this.bonusGameWheelAwardGoldenCurrency[1152921512880164639];
    }
    public int get_ChallengeWordsUnlockLevel()
    {
        return (int)this._challengeWordsunlockLevel;
    }
    public int get_ChallengeWordsLevelCooldown()
    {
        return (int)this._challengeWordsLevelCooldown;
    }
    public int get_ChallengeWordsWordChance()
    {
        return (int)this._challengeWordsWordChance;
    }
    public virtual int get_ltb_interval()
    {
        return 8;
    }
    public virtual float get_MiniReturnGameGiftOfflineHours()
    {
        return (float)S0;
    }
    public virtual ReturnGameGiftReward GetReturnReward(int level, float leftHours)
    {
    
    }
    public virtual int get_bonusRewardPointsPerDollarSpent()
    {
        return 50;
    }
    public virtual System.Collections.Generic.List<BonusRewardsContainer> get_bonusRewardTiers()
    {
    
    }
    public static bool IsEnabledAndLevelMet(int playerLevel, int knobValue)
    {
        if(knobValue == 1)
        {
                playerLevel = 0;
            return (bool)playerLevel;
        }
        
        if(playerLevel >= knobValue)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool IsEnabledAndLevelNotExeeded(int playerLevel, int knobValue)
    {
        if(knobValue == 1)
        {
                playerLevel = 1;
            return (bool)playerLevel;
        }
        
        if(playerLevel <= knobValue)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.Dictionary<string, object> GetGameplayKnobs()
    {
        if(this.knobsConfigjs.dataSource == 0)
        {
                return;
        }
        
        if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.knobsConfigjs.dataSource = 0;
        }
    
    }
    public System.Collections.Generic.Dictionary<string, object> GetMinigamesUnlockKnobs()
    {
    
    }
    public virtual void ReadFromKnobs()
    {
        var val_63;
        twelvegigs.storage.JsonDictionary val_64;
        var val_65;
        var val_66;
        var val_63 = 22562359;
        val_63 = 13065056 + val_63;
        if(val_63 == 0)
        {
                mem2[0] = 1;
        }
        
        val_63 = null;
        val_63 = null;
        val_64 = App.storageManager.knobsModel;
        twelvegigs.storage.JsonDictionary val_1 = getWordGameplayKnobs();
        if(val_64 == 0)
        {
            goto label_8;
        }
        
        this.knobsConfigjs = val_64;
        goto label_9;
        label_8:
        val_64 = this.knobsConfigjs;
        if(val_64 == 0)
        {
            goto label_10;
        }
        
        label_9:
        val_65 = 0;
        if(this.knobsConfigjs.dataSource != 0)
        {
                val_65 = 0;
            if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.knobsConfigjs.dataSource = 0;
        }
        
            val_65 = this.knobsConfigjs.dataSource;
        }
        
        var val_64 = 22560467;
        val_64 = 13065320 + val_64;
        if(val_64 == 0)
        {
                mem2[0] = 1;
        }
        
        val_66 = null;
        val_66 = null;
        if(App.game != 15)
        {
            goto label_18;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -315107104, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -315107104);
        if("scratch_gameplay" != 0)
        {
                if(null == null)
        {
            goto label_112;
        }
        
        }
        
        label_112:
        if((0.ContainsKey(key:  -315106992)) != false)
        {
                string val_5 = 0.Item[-315106992];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  this.scsStandardEntryCost);
        }
        
        if((0.ContainsKey(key:  -315106912)) != false)
        {
                string val_9 = 0.Item[-315106912];
            bool val_11 = System.Int32.TryParse(s:  null, result: out  this.scsVideosPerLuckyCash);
        }
        
        if((0.ContainsKey(key:  -315106832)) == false)
        {
            goto label_111;
        }
        
        string val_13 = 0.Item[-315106832];
        bool val_15 = System.Int32.TryParse(s:  null, result: out  this.scsMinimumCashOutBankBalance);
        goto label_111;
        label_18:
        Dictionary.KeyCollection<TKey, TValue> val_16 = val_65.Keys;
        if(val_65.Count <= 1)
        {
            goto label_36;
        }
        
        if((val_65.ContainsKey(key:  -315106736)) != false)
        {
                string val_19 = val_65.Item[-315106736];
            bool val_20 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.InitialPlayerCoins, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106640)) != false)
        {
                string val_22 = val_65.Item[-315106640];
            bool val_24 = System.Int32.TryParse(s:  null, result: out  this.InitialPlayerGems);
        }
        
        if((val_65.ContainsKey(key:  -315106544)) != false)
        {
                string val_26 = val_65.Item[-315106544];
            bool val_27 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this._HintCost, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106448)) != false)
        {
                string val_29 = val_65.Item[-315106448];
            bool val_30 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this._HintPickerCost, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106368)) != false)
        {
                string val_32 = val_65.Item[-315106368];
            bool val_33 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this._HintMEGACost, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106288)) != false)
        {
                string val_35 = val_65.Item[-315106288];
            bool val_36 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.InitialChapterClearedReward, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106208)) != false)
        {
                string val_38 = val_65.Item[-315106208];
            bool val_40 = System.Single.TryParse(s:  null, result: out  this.extraChapterEventMultiplier);
        }
        
        if((val_65.ContainsKey(key:  -315106128)) != false)
        {
                string val_42 = val_65.Item[-315106128];
            bool val_43 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.wordCoinBonus, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
        }
        
        if((val_65.ContainsKey(key:  -315106016)) != false)
        {
                string val_45 = val_65.Item[-315106016];
            bool val_47 = System.Int32.TryParse(s:  null, result: out  this.InitialExtraWordsReq);
        }
        
        if((val_65.ContainsKey(key:  -315105888)) != false)
        {
                string val_49 = val_65.Item[-315105888];
            bool val_51 = System.Int32.TryParse(s:  null, result: out  this.ExtraWordsIncrement);
        }
        
        if((val_65.ContainsKey(key:  -315105776)) != false)
        {
                string val_53 = val_65.Item[-315105776];
            bool val_55 = System.Int32.TryParse(s:  null, result: out  this.ExtraWordsMaxReq);
        }
        
        if((val_65.ContainsKey(key:  -1649939472)) == false)
        {
            goto label_107;
        }
        
        string val_57 = val_65.Item[-1649939472];
        if(val_65 == 0)
        {
            goto label_107;
        }
        
        if((val_65.ContainsKey(key:  -1649939376)) != false)
        {
                string val_59 = val_65.Item[-1649939376];
        }
        
        if((val_65.ContainsKey(key:  -1649939296)) == false)
        {
            goto label_107;
        }
        
        string val_61 = val_65.Item[-1649939296];
        if(val_65 == 0)
        {
            goto label_107;
        }
        
        System.Collections.Generic.List<System.Int32> val_62 = new System.Collections.Generic.List<System.Int32>();
        mem[1152921512881700304] = null;
        if(0 < 1)
        {
            goto label_107;
        }
        
        goto label_108;
        label_36:
        UnityEngine.Debug.LogWarning(message:  -531362368);
        goto label_111;
    }
    public GameEcon()
    {
        AppConfigs val_1 = App.Configuration;
        this.numberFormatInt = 4718393278305665024;
        AppConfigs val_2 = App.Configuration;
        decimal val_3 = System.Decimal.op_Implicit(value:  -314940272);
        this.InitialPlayerGems = 14;
        AppConfigs val_4 = App.Configuration;
        decimal val_5 = System.Decimal.op_Implicit(value:  -314940288);
        AppConfigs val_6 = App.Configuration;
        decimal val_7 = System.Decimal.op_Implicit(value:  -314940304);
        AppConfigs val_8 = App.Configuration;
        decimal val_9 = System.Decimal.op_Implicit(value:  -314940320);
        this.ChapterClearedRewardMulitplier = 1f;
        AppConfigs val_10 = App.Configuration;
        decimal val_11 = System.Decimal.op_Implicit(value:  -314940336);
        AppConfigs val_12 = App.Configuration;
        this.InitialExtraWordsReq = 28950032;
        AppConfigs val_13 = App.Configuration;
        this.ExtraWordsIncrement = 754104;
        AppConfigs val_14 = App.Configuration;
        this.ExtraWordsMaxReq = 754104;
        AppConfigs val_15 = App.Configuration;
        decimal val_16 = System.Decimal.op_Implicit(value:  -314940352);
        AppConfigs val_17 = App.Configuration;
        decimal val_18 = System.Decimal.op_Implicit(value:  -314940368);
        AppConfigs val_19 = App.Configuration;
        decimal val_20 = System.Decimal.op_Implicit(value:  -314940384);
        AppConfigs val_21 = App.Configuration;
        decimal val_22 = System.Decimal.op_Implicit(value:  -314940400);
        AppConfigs val_23 = App.Configuration;
        decimal val_24 = System.Decimal.op_Implicit(value:  -314940416);
        AppConfigs val_25 = App.Configuration;
        decimal val_26 = System.Decimal.op_Implicit(value:  -314940432);
        AppConfigs val_27 = App.Configuration;
        this.NoAdsStarterPackCoinAmount = 1685382482;
        AppConfigs val_28 = App.Configuration;
        this.NoAdsPackagePriceToUse = 1.401298E-45f;
        AppConfigs val_29 = App.Configuration;
        this.fallbackNoAdsPackagePriceToUse = 1.401298E-45f;
        AppConfigs val_30 = App.Configuration;
        decimal val_31 = System.Decimal.op_Implicit(value:  -314940448);
        AppConfigs val_32 = App.Configuration;
        this.dailyBonusHours = 6;
        AppConfigs val_33 = App.Configuration;
        this.dailyBonusTiers = 4;
        AppConfigs val_34 = App.Configuration;
        this.dailyBonusVideoRewards = 4;
        this.LimitedTimeBundlesEcon = new LimitedTimeBundlesEcon();
        this.subscriptionPromoPostDailyBonusLevel = 0;
        AppConfigs val_36 = App.Configuration;
        decimal val_37 = System.Decimal.op_Implicit(value:  -314940464);
        AppConfigs val_38 = App.Configuration;
        decimal val_39 = System.Decimal.op_Implicit(value:  -314940480);
        AppConfigs val_40 = App.Configuration;
        decimal val_41 = System.Decimal.op_Implicit(value:  -314940496);
        AppConfigs val_42 = App.Configuration;
        this.emailCollectTimeoutDays = 1;
        AppConfigs val_43 = App.Configuration;
        this.freeHintPopupLevel = 4;
        AppConfigs val_44 = App.Configuration;
        this.freeHintPostDailyBonus = 308;
        AppConfigs val_45 = App.Configuration;
        this.adsControlPopupLevel = 4;
        AppConfigs val_46 = App.Configuration;
        this.adsControlButtonLevel_max = 4;
        this.adsControlMaxViews = 5;
        AppConfigs val_47 = App.Configuration;
        this.emailCollectPopupLevel = 4096;
        this.extraReqBeginningChapter = 10;
        this.extraReqDefaultLevelsPerChapter = 1;
        AppConfigs val_48 = App.Configuration;
        this.extraReqIncrement = 4096;
        AppConfigs val_49 = App.Configuration;
        this.extraReqMaxLevelsPerChapter = 2;
        AppConfigs val_50 = App.Configuration;
        this.extraReqHintsPerCh_BuyNone = 34479860;
        AppConfigs val_51 = App.Configuration;
        this.extraReqHintsPerCh_BuyFirst = 34483956;
        AppConfigs val_52 = App.Configuration;
        this.extraReqHintsPerCh_BuyRepeat = 34483956;
        AppConfigs val_53 = App.Configuration;
        this.extraReqQuantityPerLevel = 264;
        AppConfigs val_54 = App.Configuration;
        this.extraReqPostPurchaseLvl = 264;
        AppConfigs val_55 = App.Configuration;
        this.hintTutorialLevel = 33453552;
        AppConfigs val_56 = App.Configuration;
        this.hintTutorialLevelV2 = 33453552;
        AppConfigs val_57 = App.Configuration;
        this.hintPickerTutorialLevel = 2165608;
        AppConfigs val_58 = App.Configuration;
        this.hintPickerTutorialLevelV2 = 2900448;
        AppConfigs val_59 = App.Configuration;
        this.hintMEGATutorialLevel = 6;
        this.FInviter_GO_R = 1300;
        this.FInviterEnabled = true;
        this.difficultySettingPromptLevel = 105;
        this.difficultySettingHintDiscount = 10;
        this.plvDesiredNumReqWordsMax = 14f;
        this.plvMaxExtraWords = 6;
        this.plvReqWordDeviations = null;
        this.plvExtraWordCounts = null;
        this.plvGivenLettersMin = 1f;
        this.plvNumWordLengths = null;
        this.plvDesiredWordLengthBase = 5f;
        this.plvDesiredWordLengthIncrement = 0.1f;
        this.plvLettersArrayIncrement = 2;
        this.plvWordLengthMax = 7f;
        this.plvWordLengthDeviations = null;
        this.plvLettersArray = null;
        this.plvHintsPerCh_BuyNone = 2;
        this.plvHintsPerCh_BuyFirst = 5;
        this.plvHintsPerCh_BuyRepeat = 10;
        this.wsaDefaultGridSize = 10f;
        this.wsaDefaultGridSizeIncrement = 0.25f;
        this.wsaMaximumGridSize = 12f;
        this.ChapterHintThresholdRepeatBuyer = 10;
        AppConfigs val_60 = App.Configuration;
        this.hintDiscountSizePercent = 132;
        AppConfigs val_61 = App.Configuration;
        this.hintDiscountChapterMinutes = 1;
        AppConfigs val_62 = App.Configuration;
        this.hintDiscountDailyBonusMinutes = 6580591;
        AppConfigs val_63 = App.Configuration;
        this.hintDiscountChapterFreq = 1919184449;
        this.extraChapterEventMultiplier = 2f;
        this.alphabetOneMoreCost = 100;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_64 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.alphabetRewards = null;
        this.starUnlockLevel = 6;
        this.starRowDif = 2;
        this.storyPopupLevel = 0;
        System.Collections.Generic.List<System.Int32> val_65 = new System.Collections.Generic.List<System.Int32>();
        this.offersEnabled = true;
        this.surveysEnabled = true;
        this.WADHardLevels = null;
        this.ftuxTutorialEnabled = true;
        this.postLevelRewardedVideo_freq = 0.5f;
        this.postLevelCollectionTile_freq = 0.4f;
        this.postLevelAdsControl_freq = 0.1f;
        this.notificationUnlockAppearances = 4;
        decimal val_66 = new System.Decimal(value:  1000);
        mem[1152921512881854252] = val_66.flags;
        decimal val_67 = new System.Decimal(value:  60);
        this.bonusGameWheelAwardCoins = null;
        this.starterPackEnabled = true;
        this.bonusGameWheelAwardGoldenCurrency = null;
        this.starterPackLevel = 24;
        System.TimeSpan val_68 = new System.TimeSpan(hours:  24, minutes:  0, seconds:  0);
        this.starterPackTimeSpan = val_68._ticks;
        mem[1152921512881854308] = val_68._ticks;
        System.TimeSpan val_69 = new System.TimeSpan(hours:  24, minutes:  0, seconds:  0);
        decimal val_70 = new System.Decimal(value:  500);
        this.FOMOLevelInterval = 2;
        System.TimeSpan val_71 = new System.TimeSpan(hours:  1, minutes:  0, seconds:  0);
        this.FOMOPackTimeSpan = val_71._ticks;
        mem[1152921512881854348] = val_71._ticks;
        this.spHintConstant = 2.2f;
        this.spHintStartLevel = 50;
        this.spHintEndLevel = 120;
        this.WIQ_BaseClearPoints_max = 0.04f;
        this.WIQ_HighestComplexity = 0.87f;
        this.WIQ_MaxAdditionalClearPoints = 0.025f;
        this.WIQ_Milestones = null;
        this.categoryUnlockLevel = 150;
        this.categoryShowLevelsDisplay = "100";
        decimal val_72 = new System.Decimal(value:  30);
        this.highPurchaserCap = 20;
        this.repeatPurchaserCap = 20;
        this.dbFtuxLevel = 6;
        this.dbFtuxCr = 50;
        this.hintMeterFreeHints = true;
        this.libraryButtonDisplayLevel = 6;
        this.categoriesButtonDisplayLevel = 110;
        this.gm_maxGoldenMultiplier = 100f;
        this.caf_unlockLevel = 5;
        this.caf_frequencyShown = 5;
        this.lifetime099SpendLimit = 19.99f;
        this.goldenAppleFtuxLevel = 6;
        this.definitionFtuxLevel = 3;
        this.newUserTaskUnlock = 3;
        decimal val_73 = new System.Decimal(value:  50);
        this.caf_reward_coins = val_73.flags;
        mem[1152921512881854616] = val_73.hi;
        mem[1152921512881854620] = val_73.lo;
        mem[1152921512881854624] = val_73.flags;
        PrizeBalloon.Econ val_74 = new PrizeBalloon.Econ();
        goto label_101;
    }
    private static GameEcon()
    {
        AppConfigs val_1 = App.Configuration;
        GameEcon.numberFormatDecimal = 0;
    }

}
