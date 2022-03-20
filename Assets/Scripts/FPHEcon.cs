using UnityEngine;
public class FPHEcon : GameEcon
{
    // Fields
    private int levelEntryFee;
    public int levelsPerChapter;
    private int baseLevelCompletionReward;
    public decimal startingCoins;
    public int startingGems;
    public int rewardedVideoGemReward;
    public int keyboardTutorialRewardMultiplier;
    private System.Collections.Generic.Dictionary<FPHChestType, System.Collections.Generic.List<int>> chestRewardMultis;
    private System.Collections.Generic.Dictionary<FPHChestType, System.Collections.Generic.List<int>> chestRewardBucketA;
    private System.Collections.Generic.Dictionary<FPHChestType, int> chestWeights;
    private int defaultTokens;
    public int consonantCost;
    private int vowelCost;
    private int powerupHintUnlockLevel;
    private int powerupHintFtuxLevel;
    private int powerupHintFreeUsageLevelLimit;
    private int powerupHintCost;
    private int powerupRemoveUnlockLevel;
    private int powerupRemoveFtuxLevel;
    private int powerupRemoveFreeUsageLevelLimit;
    private int powerupRemoveCost;
    private int powerupRemoveQty;
    public System.Collections.Generic.List<char> vowels;
    public static System.Collections.Generic.List<GiftRewardTypeChance> ChapterRewardTypeChances;
    public static System.Collections.Generic.List<GiftRewardTypeChance> DailyBonusRewardTypeChances;
    public static System.Collections.Generic.List<GiftRewardTier> DailyBonusCoinRewardTiers;
    public static System.Collections.Generic.List<GiftRewardTier> DailyBonusFTUXCoinRewardTiers;
    public static System.Collections.Generic.List<GiftRewardTier> DailyBonusPickAnotherCoinRewardTiers;
    public static System.Collections.Generic.List<GiftRewardTier> ChapterRewardCoinRewardTiers;
    public int qotdUnlockLevel;
    public FPHQOTDPhrase QotdNormalReward;
    public FPHQOTDPhrase QotdBonusReward;
    
    // Properties
    public int LevelEntryFee { get; }
    public int BaseLevelCompletionReward { get; }
    public System.Collections.Generic.Dictionary<FPHChestType, int> ChestWeights { get; }
    public int DefaultTokens { get; }
    public int VowelCost { get; }
    public int PowerupHintUnlockLevel { get; }
    public int PowerupHintFtuxLevel { get; }
    public int PowerupHintFreeUsageLevelLimit { get; }
    public int PowerupHintCost { get; }
    public int PowerupRemoveUnlockLevel { get; }
    public int PowerupRemoveFtuxLevel { get; }
    public int PowerupRemoveFreeUsageLevelLimit { get; }
    public int PowerupRemoveCost { get; }
    public int PowerupRemoveQty { get; }
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> GiftRewardTypeChances { get; }
    
    // Methods
    public int get_LevelEntryFee()
    {
        return (int)this.levelEntryFee;
    }
    public int get_BaseLevelCompletionReward()
    {
        return (int)this.baseLevelCompletionReward;
    }
    public System.Collections.Generic.Dictionary<FPHChestType, int> get_ChestWeights()
    {
    
    }
    public FPHChestType GetChestType()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 2)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 3)
        {
                return;
        }
        
        add(item:  0, weight:  (float)this.chestWeights.Item[0]);
        add(item:  1, weight:  (float)this.chestWeights.Item[1]);
        int val_7 = this.chestWeights.Item[2];
        if(new RandomSet() != 0)
        {
                add(item:  2, weight:  (float)val_7);
            return roll(unweighted:  false);
        }
        
        add(item:  2, weight:  (float)val_7);
        return roll(unweighted:  false);
    }
    public int get_DefaultTokens()
    {
        return (int)this.defaultTokens;
    }
    public int get_VowelCost()
    {
        return (int)this.vowelCost;
    }
    public int get_PowerupHintUnlockLevel()
    {
        return (int)this.powerupHintUnlockLevel;
    }
    public int get_PowerupHintFtuxLevel()
    {
        return (int)this.powerupHintFtuxLevel;
    }
    public int get_PowerupHintFreeUsageLevelLimit()
    {
        return (int)this.powerupHintFreeUsageLevelLimit;
    }
    public int get_PowerupHintCost()
    {
        return (int)this.powerupHintCost;
    }
    public int get_PowerupRemoveUnlockLevel()
    {
        return (int)this.powerupRemoveUnlockLevel;
    }
    public int get_PowerupRemoveFtuxLevel()
    {
        return (int)this.powerupRemoveFtuxLevel;
    }
    public int get_PowerupRemoveFreeUsageLevelLimit()
    {
        return (int)this.powerupRemoveFreeUsageLevelLimit;
    }
    public int get_PowerupRemoveCost()
    {
        return (int)this.powerupRemoveCost;
    }
    public int get_PowerupRemoveQty()
    {
        return (int)this.powerupRemoveQty;
    }
    public System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> get_GiftRewardTypeChances()
    {
        var val_2;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        val_2 = null;
        val_2 = null;
        Add(key:  0, value:  FPHEcon.DailyBonusRewardTypeChances);
        Add(key:  2, value:  FPHEcon.DailyBonusRewardTypeChances);
        Add(key:  1, value:  FPHEcon.DailyBonusRewardTypeChances);
        Add(key:  3, value:  FPHEcon.ChapterRewardTypeChances);
    }
    public FPHEcon()
    {
        var val_14;
        this.levelEntryFee = 500;
        this.levelsPerChapter = 10;
        decimal val_1;
        this.baseLevelCompletionReward = 150;
        val_1 = new System.Decimal(value:  3000);
        this.startingGems = 350;
        this.rewardedVideoGemReward = 10;
        this.keyboardTutorialRewardMultiplier = 5;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_2 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  3);
        }
        else
        {
                Add(item:  2);
            Add(item:  3);
        }
        
        Add(item:  7);
        Add(key:  0, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  4);
            Add(item:  5);
        }
        else
        {
                Add(item:  2);
            Add(item:  2);
            Add(item:  3);
            Add(item:  4);
            Add(item:  5);
        }
        
        Add(item:  10);
        Add(key:  1, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  2);
            Add(item:  3);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
            Add(item:  10);
        }
        else
        {
                Add(item:  2);
            Add(item:  3);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
            Add(item:  10);
        }
        
        Add(item:  15);
        Add(key:  2, value:  80883712);
        this.chestRewardMultis = null;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_6 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  4);
            Add(item:  5);
        }
        else
        {
                Add(item:  4);
            Add(item:  5);
        }
        
        Add(item:  8);
        Add(key:  0, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
        }
        else
        {
                Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
        }
        
        Add(item:  9);
        Add(key:  1, value:  80883712);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  3);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
            Add(item:  9);
            Add(item:  10);
        }
        else
        {
                Add(item:  3);
            Add(item:  4);
            Add(item:  5);
            Add(item:  6);
            Add(item:  7);
            Add(item:  8);
            Add(item:  9);
            Add(item:  10);
        }
        
        Add(item:  15);
        Add(key:  2, value:  80883712);
        this.chestRewardBucketA = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_10 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                Add(key:  0, value:  60);
            Add(key:  1, value:  30);
        }
        else
        {
                Add(key:  0, value:  60);
            Add(key:  1, value:  30);
        }
        
        Add(key:  2, value:  10);
        this.chestWeights = null;
        System.Collections.Generic.List<System.Char> val_11 = new System.Collections.Generic.List<System.Char>();
        if(null != 0)
        {
                Add(item:  'A');
            Add(item:  'E');
            Add(item:  'I');
            Add(item:  'O');
        }
        else
        {
                Add(item:  'A');
            Add(item:  'E');
            Add(item:  'I');
            Add(item:  'O');
        }
        
        Add(item:  'U');
        this.vowels = null;
        this.qotdUnlockLevel = 6;
        this.QotdNormalReward = new FPHQOTDPhrase(rewardType:  0, rewardAmount:  100, tokens:  150);
        this.QotdBonusReward = new FPHQOTDPhrase(rewardType:  1, rewardAmount:  10, tokens:  80);
        mem[1152921511546624820] = 700;
        mem[1152921511546624484] = 0;
        val_14 = null;
        val_14 = null;
        this.set_Item(key:  0, value:  FPHEcon.DailyBonusCoinRewardTiers);
        this.set_Item(key:  2, value:  FPHEcon.DailyBonusFTUXCoinRewardTiers);
        this.set_Item(key:  1, value:  FPHEcon.DailyBonusPickAnotherCoinRewardTiers);
        this.set_Item(key:  3, value:  FPHEcon.ChapterRewardCoinRewardTiers);
    }
    public System.Collections.Generic.List<int> GetChestRewardMultiplier(FPHChestType type)
    {
        Player val_1 = App.Player;
        string val_2 = 33449456.ToLower();
        if((System.String.op_Equality(a:  33449456, b:  -1953384624)) == false)
        {
                this = this.chestRewardMultis;
        }
        
        System.Collections.Generic.List<System.Int32> val_4 = this.Item[type];
        System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>(collection:  this);
    }
    public override void ReadFromKnobs()
    {
        FPHEcon val_71;
        var val_72;
        val_71 = this;
        val_71.ReadFromKnobs();
        if((0.ContainsKey(key:  -1649939472)) == false)
        {
            goto label_17;
        }
        
        string val_2 = 0.Item[-1649939472];
        if(0 == 0)
        {
            goto label_17;
        }
        
        if((0.ContainsKey(key:  -1649939376)) != false)
        {
                string val_4 = 0.Item[-1649939376];
        }
        
        if((0.ContainsKey(key:  -1649939296)) == false)
        {
            goto label_17;
        }
        
        string val_6 = 0.Item[-1649939296];
        if(0 == 0)
        {
            goto label_17;
        }
        
        System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
        mem[1152921511546869696] = null;
        if(0 < 1)
        {
            goto label_18;
        }
        
        goto label_19;
        label_25:
        label_19:
        if(null <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_71 = R6 + 8;
        val_71 = val_71 + 0;
        Add(item:  System.Convert.ToInt32(value:  (R6 + 8 + 0) + 16));
        if(1 < (R6 + 12))
        {
            goto label_25;
        }
        
        label_18:
        val_71 = val_71;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GiftRewardTier val_10 = new GiftRewardTier(threshold:  1254115712, rewards:  R6);
        Add(item:  373055488);
        this.set_Item(key:  1, value:  80883712);
        label_17:
        if((mem[35639233].ContainsKey(key:  -1649937168)) != false)
        {
                string val_12 = mem[35639233].Item[-1649937168];
            if((0.ContainsKey(key:  -1649937088)) != false)
        {
                string val_14 = 0.Item[-1649937088];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  int val_15 = -1649910900);
        }
        
            if((0.ContainsKey(key:  -1649937008)) != false)
        {
                string val_18 = 0.Item[-1649937008];
            bool val_20 = System.Int32.TryParse(s:  null, result: out  int val_19 = -1649910952);
        }
        
            if((0.ContainsKey(key:  -1649936928)) != false)
        {
                string val_22 = 0.Item[-1649936928];
            bool val_24 = System.Int32.TryParse(s:  null, result: out  int val_23 = -1649910892);
        }
        
            if((0.ContainsKey(key:  -1649936848)) != false)
        {
                string val_26 = 0.Item[-1649936848];
            bool val_28 = System.Int32.TryParse(s:  null, result: out  int val_27 = -1649910896);
        }
        
            if((0.ContainsKey(key:  -1649936768)) != false)
        {
                string val_30 = 0.Item[-1649936768];
            bool val_32 = System.Int32.TryParse(s:  null, result: out  int val_31 = -1649910944);
        }
        
        }
        
        val_72 = 1;
        if((mem[35639233].ContainsKey(key:  -1649936688)) != false)
        {
                string val_34 = mem[35639233].Item[-1649936688];
            if((0.ContainsKey(key:  1638199088)) != false)
        {
                string val_36 = 0.Item[1638199088];
            if((0.ContainsKey(key:  -1785508240)) != false)
        {
                string val_38 = 0.Item[-1785508240];
            bool val_40 = System.Int32.TryParse(s:  null, result: out  int val_39 = -1649910876);
        }
        
            if((0.ContainsKey(key:  -1649936592)) != false)
        {
                string val_42 = 0.Item[-1649936592];
            bool val_44 = System.Int32.TryParse(s:  null, result: out  int val_43 = -1649910888);
        }
        
            if((0.ContainsKey(key:  -1649936512)) != false)
        {
                string val_46 = 0.Item[-1649936512];
            bool val_48 = System.Int32.TryParse(s:  null, result: out  int val_47 = -1649910884);
        }
        
        }
        
            val_71 = val_71;
            val_72 = 1;
            if((0.ContainsKey(key:  -1649936432)) != false)
        {
                string val_50 = 0.Item[-1649936432];
            if((0.ContainsKey(key:  -1785508240)) != false)
        {
                string val_52 = 0.Item[-1785508240];
            bool val_54 = System.Int32.TryParse(s:  null, result: out  int val_53 = -1649910860);
        }
        
            if((0.ContainsKey(key:  -1649936592)) != false)
        {
                string val_56 = 0.Item[-1649936592];
            bool val_58 = System.Int32.TryParse(s:  null, result: out  int val_57 = -1649910872);
        }
        
            val_72 = 1;
            if((0.ContainsKey(key:  -1649936512)) != false)
        {
                string val_60 = 0.Item[-1649936512];
            bool val_62 = System.Int32.TryParse(s:  null, result: out  int val_61 = -1649910868);
        }
        
        }
        
        }
        
        if((mem[35639233].ContainsKey(key:  -1649936352)) != false)
        {
                string val_64 = mem[35639233].Item[-1649936352];
            bool val_66 = System.Int32.TryParse(s:  mem[35639233], result: out  int val_65 = -1649910920);
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_67 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_68 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GameEcon val_69 = App.getGameEcon;
        Add(item:  13152256);
        GiftRewardTier val_70 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        this.set_Item(key:  2, value:  80883712);
        goto label_103;
    }
    private static FPHEcon()
    {
        GiftRewardTypeChance val_2 = new GiftRewardTypeChance(rewardType:  0, chance:  100);
        Add(item:  372948992);
        FPHEcon.ChapterRewardTypeChances = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GiftRewardTypeChance val_4 = new GiftRewardTypeChance(rewardType:  0, chance:  100);
        Add(item:  372948992);
        FPHEcon.DailyBonusRewardTypeChances = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_7 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
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
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_13 = new GiftRewardTier(threshold:  -1649822048, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_15 = new GiftRewardTier(threshold:  -1649821968, rewards:  80883712);
        Add(item:  373055488);
        FPHEcon.DailyBonusCoinRewardTiers = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_16 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        GiftRewardTier val_18 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        FPHEcon.DailyBonusFTUXCoinRewardTiers = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_19 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_20 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_21 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        FPHEcon.DailyBonusPickAnotherCoinRewardTiers = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_22 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_23 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_24 = new GiftRewardTier(threshold:  1254115712, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_25 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_26 = new GiftRewardTier(threshold:  -1649822208, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_27 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_28 = new GiftRewardTier(threshold:  -1649822128, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_29 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_30 = new GiftRewardTier(threshold:  -1649822048, rewards:  80883712);
        Add(item:  373055488);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_31 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  13152256);
        Add(item:  13152256);
        Add(item:  13152256);
        GiftRewardTier val_32 = new GiftRewardTier(threshold:  -1649821968, rewards:  80883712);
        Add(item:  373055488);
        FPHEcon.ChapterRewardCoinRewardTiers = null;
    }

}
