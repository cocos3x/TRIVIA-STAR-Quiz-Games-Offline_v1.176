using UnityEngine;
public class EconConfig : ScriptableObject
{
    // Fields
    public int NonPurchaserVideoAdRewardCoins;
    public int OneTimePurchaserVideoAdRewardCoins;
    public int RepeatPurchaserVideoAdRewardCoins;
    public int VideoAdPlayerLevel;
    public int AdsControlPopup;
    public float DefaultNoAdsPackagePrice;
    public string NumberFormat;
    public string NumberFormatDecimal;
    public int DefaultPlayerCoins;
    public int HintCost;
    public int HintPickerCost;
    public int MegaHintCost;
    public int EmailPromptUnlockLevel;
    public int EmailPromptFrequency;
    public int ReviewPromptUnlockLevel;
    public int HintTutorialLevel;
    public int HintTutorialLevelV2;
    public int PickerHintTutorialLevel;
    public int PickerHintTutorialLevelV2;
    public int MegaHintTutorialLevel;
    public int ExtraReqIncrement;
    public int MaxExtraReqLevelsPerChapter;
    public int HintsPerChapterNonBuyer;
    public int HintsPerChapterOneTimeBuyer;
    public int HintsPerChapterRepeatBuyer;
    public int ExtraRequiredQuantityPerLevel;
    public int ExtraRequiredPostPurchaseLevel;
    public int TimerHours;
    public System.Collections.Generic.Dictionary<int, DailyBonusTier> DailyBonusCoinRewardTiers;
    public System.Collections.Generic.List<int> DailyBonusVideoRewards;
    public int FreeHintDailyBonusLevel;
    protected System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> giftRewardTypeChances;
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTier>> GiftRewardCoinRewardTiers;
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardCoinAmountChances;
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardFoodAmountChances;
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardDiceRollAmountChances;
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>> GiftRewardGoldenCurrencyAmountChances;
    public int WordCoinBonus;
    public int ChapterCompleteBonus;
    public int RateBonus;
    public int FacebookConnectBonus;
    public int VideoAdRewardCoins;
    public int VideoAdRewardBonusCollectCoins;
    public int EmailWelcome;
    public int EmailThankYou;
    public int RPNMonthly;
    public int RPNHoliday;
    public int IncentivizedEmailPrompt;
    public int InitalExtraWordsReq;
    public int ExtraWordsReqInc;
    public int MaxExtraWordsReq;
    public int RewardCoins;
    public int AdsControlButtonMaxLevel;
    public int NoAdsStartCoinAmount;
    public int AdsControlUnlockLevel;
    public bool WGWaterfall;
    public int WGWaterfallIntervalDays;
    public int WaterfallDisplayMinutes;
    public int WaterfallLevel;
    public bool AdvancedPlayerEnabled;
    public int AdvancedPlayerPopupDisplay;
    public int AdvancedPlayerLevelToSkip;
    public int DiscountSizePercent;
    public int DiscountChapterMinutes;
    public int DiscountChapterFrequency;
    public int DiscountDailyBonusMinutes;
    
    // Properties
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> GiftRewardTypeChances { get; }
    
    // Methods
    public virtual System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> get_GiftRewardTypeChances()
    {
    
    }
    public EconConfig()
    {
        var val_9;
        var val_10;
        this.AdsControlPopup = 27;
        this.DefaultNoAdsPackagePrice = 5.99f;
        this.NumberFormat = "#,##0";
        this.NumberFormatDecimal = "#,##0.00";
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.DailyBonusCoinRewardTiers = null;
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        this.DailyBonusVideoRewards = null;
        this.FreeHintDailyBonusLevel = 13;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_3 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        val_9 = null;
        val_9 = null;
        Add(key:  0, value:  GiftRewardData.DailyBonusRewardTypeChances);
        Add(key:  2, value:  GiftRewardData.DailyBonusRewardTypeChances);
        Add(key:  1, value:  GiftRewardData.DailyBonusPickAnotherRewardChances);
        Add(key:  3, value:  GiftRewardData.ChapterRewardTypeChances);
        Add(key:  4, value:  GiftRewardData.DailyBonusRewardTypeChances);
        Add(key:  10, value:  GiftRewardData.DailyChallengeWeeklyRewardChances);
        Add(key:  11, value:  GiftRewardData.DailyChallengeMonthlyRewardChances);
        val_10 = null;
        val_10 = null;
        if((SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  5, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 8 + 16);
        if((SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  6, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 8 + 20);
        if((SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  7, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 8 + 24);
        if((SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 12) <= 3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  8, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 8 + 28);
        if((SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 12) <= 4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  9, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardTypeChances + 8 + 32);
        this.giftRewardTypeChances = null;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_4 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        Add(key:  0, value:  GiftRewardData.DailyBonusCoinRewardTiersV2);
        Add(key:  2, value:  GiftRewardData.DailyBonusCoinRewardTiersV2);
        Add(key:  1, value:  GiftRewardData.DailyBonusCoinRewardTiersV2);
        Add(key:  3, value:  GiftRewardData.ChapterRewardCoinRewardTiers);
        Add(key:  10, value:  GiftRewardData.DailyChallengeCoinRewardTiers);
        Add(key:  11, value:  GiftRewardData.DailyChallengeCoinRewardTiers);
        Add(key:  5, value:  SnakesAndLaddersEvent.Econ.BoardGiftCoinRewardTiers);
        Add(key:  6, value:  SnakesAndLaddersEvent.Econ.BoardGiftCoinRewardTiers);
        Add(key:  7, value:  SnakesAndLaddersEvent.Econ.BoardGiftCoinRewardTiers);
        Add(key:  8, value:  SnakesAndLaddersEvent.Econ.BoardGiftCoinRewardTiers);
        Add(key:  9, value:  SnakesAndLaddersEvent.Econ.BoardGiftCoinRewardTiers);
        this.GiftRewardCoinRewardTiers = null;
        this.GiftRewardCoinAmountChances = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        Add(key:  0, value:  GiftRewardData.DailyBonusFoodAmountChances);
        Add(key:  2, value:  GiftRewardData.DailyBonusFoodAmountChances);
        Add(key:  1, value:  GiftRewardData.DailyBonusFoodAmountChances);
        Add(key:  3, value:  GiftRewardData.ChapterRewardFoodAmountChances);
        Add(key:  10, value:  GiftRewardData.DailyChallengeRewardFoodAmountChances);
        Add(key:  11, value:  GiftRewardData.DailyChallengeRewardFoodAmountChances);
        Add(key:  5, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardFoodAmountChances);
        Add(key:  6, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardFoodAmountChances);
        Add(key:  7, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardFoodAmountChances);
        Add(key:  8, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardFoodAmountChances);
        Add(key:  9, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardFoodAmountChances);
        this.GiftRewardFoodAmountChances = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        Add(key:  0, value:  SnakesAndLaddersEvent.Econ.DailyBonusDiceRollAmountChances);
        Add(key:  2, value:  SnakesAndLaddersEvent.Econ.DailyBonusDiceRollAmountChances);
        Add(key:  1, value:  SnakesAndLaddersEvent.Econ.DailyBonusDiceRollAmountChances);
        Add(key:  5, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardDiceRollAmountChances);
        Add(key:  6, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardDiceRollAmountChances);
        Add(key:  7, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardDiceRollAmountChances);
        Add(key:  8, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardDiceRollAmountChances);
        Add(key:  9, value:  SnakesAndLaddersEvent.Econ.BoardGiftRewardDiceRollAmountChances);
        this.GiftRewardDiceRollAmountChances = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.GiftRewardGoldenCurrencyAmountChances = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.ExtraWordsReqInc = 2;
        this.MaxExtraWordsReq = 100;
        this.WGWaterfall = true;
        this.DiscountChapterFrequency = 5;
        this.DiscountDailyBonusMinutes = 60;
    }

}
