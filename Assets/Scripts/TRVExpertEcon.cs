using UnityEngine;
public class TRVExpertEcon : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<string> defaultUnlockedExperts;
    public int expertSpeedUpCost;
    private System.Collections.Generic.Dictionary<int, int> DailyBonusCardProbabilities;
    private System.Collections.Generic.Dictionary<int, int> ChapterRewardCardProbabilities;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<TRVExpertOutcomes, int>> expertProbibilites;
    private System.Collections.Generic.List<ExpertCardEcon> expertLevelUpEcon;
    public System.Collections.Generic.List<TRVCategoryExpertEcon> econs;
    
    // Properties
    public System.Collections.Generic.List<string> getDefaultUnlocked { get; }
    public int getExpertCooldown { get; }
    public System.Collections.Generic.Dictionary<TRVExpertRarites, int> getCardRarityProbabilities { get; }
    public System.Collections.Generic.Dictionary<int, int> getDBProbabilities { get; }
    public System.Collections.Generic.Dictionary<int, int> getCRProbabilities { get; }
    public System.Collections.Generic.List<ExpertCardEcon> cardEcon { get; }
    
    // Methods
    public System.Collections.Generic.List<string> get_getDefaultUnlocked()
    {
    
    }
    public int get_getExpertCooldown()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916244];
        }
        
        return (int)mem[1152921512476916244];
    }
    public System.Collections.Generic.Dictionary<TRVExpertRarites, int> get_getCardRarityProbabilities()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.Dictionary<int, int> get_getDBProbabilities()
    {
    
    }
    public System.Collections.Generic.Dictionary<int, int> get_getCRProbabilities()
    {
    
    }
    public System.Collections.Generic.Dictionary<TRVExpertOutcomes, int> getOutcomesByLevel(int level)
    {
        var val_4;
        if((this.expertProbibilites.ContainsKey(key:  level)) != false)
        {
                System.Collections.Generic.Dictionary<TRVExpertOutcomes, System.Int32> val_2 = this.expertProbibilites.Item[level];
            val_4 = this.expertProbibilites;
            return;
        }
        
        val_4 = 0;
        string val_3 = -615385648(-615385648) + 13152256;
        UnityEngine.Debug.LogError(message:  -615385648);
    }
    public System.Collections.Generic.List<ExpertCardEcon> get_cardEcon()
    {
    
    }
    public ExpertCardEcon.ExpertLevelReq getReqFromExpert(TRVExpert exp, TRVExpertProgressData prog)
    {
        var val_5;
        var val_6;
        if(new System.Object() != 0)
        {
                typeof(TRVExpertEcon.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = exp;
        }
        else
        {
                mem[8] = exp;
        }
        
        typeof(TRVExpertEcon.<>c__DisplayClass19_0).__il2cppRuntimeField_C = prog;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  351703040, method:  new IntPtr(3679834496));
        object val_3 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.expertLevelUpEcon, predicate:  7720960);
        val_5 = public System.Void System.Func<ExpertLevelReq, System.Boolean>::.ctor(object object, IntPtr method);
        val_6 = 1152921512581652864;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  351703040, method:  new IntPtr(3679839616));
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.expertLevelUpEcon, predicate:  7720960);
    }
    public TRVExpertEcon()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.defaultUnlockedExperts = null;
        this.expertSpeedUpCost = 15;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_2 != 0)
        {
                Add(key:  1, value:  100);
            Add(key:  2, value:  80);
        }
        else
        {
                Add(key:  1, value:  100);
            Add(key:  2, value:  80);
        }
        
        Add(key:  3, value:  20);
        this.DailyBonusCardProbabilities = val_2;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_3 != 0)
        {
                Add(key:  1, value:  100);
            Add(key:  2, value:  100);
            Add(key:  3, value:  50);
        }
        else
        {
                Add(key:  1, value:  100);
            Add(key:  2, value:  100);
            Add(key:  3, value:  50);
        }
        
        Add(key:  4, value:  20);
        this.ChapterRewardCardProbabilities = val_3;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        if((new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>()) != 0)
        {
                Add(key:  0, value:  30);
            Add(key:  1, value:  50);
        }
        else
        {
                Add(key:  0, value:  30);
            Add(key:  1, value:  50);
        }
        
        Add(key:  2, value:  20);
        Add(key:  1, value:  78753792);
        if((new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>()) != 0)
        {
                Add(key:  0, value:  20);
            Add(key:  1, value:  40);
        }
        else
        {
                Add(key:  0, value:  20);
            Add(key:  1, value:  40);
        }
        
        Add(key:  2, value:  40);
        Add(key:  2, value:  78753792);
        if((new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>()) != 0)
        {
                Add(key:  0, value:  10);
            Add(key:  1, value:  30);
        }
        else
        {
                Add(key:  0, value:  10);
            Add(key:  1, value:  30);
        }
        
        Add(key:  2, value:  60);
        Add(key:  3, value:  78753792);
        if((new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>()) != 0)
        {
                Add(key:  1, value:  20);
        }
        else
        {
                Add(key:  1, value:  20);
        }
        
        Add(key:  2, value:  80);
        Add(key:  4, value:  78753792);
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_9 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        Add(key:  2, value:  100);
        Add(key:  5, value:  78753792);
        this.expertProbibilites = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.expertLevelUpEcon = null;
    }

}
