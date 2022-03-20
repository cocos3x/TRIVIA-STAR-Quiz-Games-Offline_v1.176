using UnityEngine;
public class GoldenMultiplierManager : MonoSingleton<GoldenMultiplierManager>
{
    // Fields
    public const string MULTI_UPDATED = "OnGoldenMultiplierUpdate";
    private const int STREAK_TOOLIP = 50;
    private int currentLevelCompleteBonus;
    private bool hasShownTooltipThisLevel;
    private System.Collections.Generic.Dictionary<float, float> multiplierCosts;
    
    // Properties
    public static bool IsAvaialable { get; }
    public float GetMultiplierIncrement { get; }
    public float GetNextCost { get; }
    public bool IsMaxGoldedMultiplier { get; }
    public float GetCurrentGoldenMultiplier { get; }
    public float GetCurrentBaseMultiplier { get; }
    public int GetCurrentLevelCompleteBonus { get; }
    public float GetCurrentBonusFromSubs { get; }
    public float GetCurrentBonusFromDifficulty { get; }
    private bool knobEnabled { get; }
    private float defaultMultiplier { get; }
    private float defaultCost { get; }
    private float multiplierIncrement { get; }
    private float costIncrementCoefficient { get; }
    private float maxGoldenMultiplier { get; }
    private float currentMultiplier { get; set; }
    
    // Methods
    public static bool get_IsAvaialable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1232361088) == 0)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance()) != 0)
        {
                return knobEnabled;
        }
        
            return knobEnabled;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_7 = gameObject;
        UnityEngine.Object.Destroy(obj:  -1232361088);
        return false;
    }
    public float get_GetMultiplierIncrement()
    {
        return this.multiplierIncrement;
    }
    public float get_GetNextCost()
    {
        bool val_13;
        var val_14;
        val_13 = static_value_021F9E1F;
        if(val_13 != true)
        {
                val_13 = true;
        }
        
        float val_1 = this.defaultCost;
        int val_2 = this.multiplierCosts.Count;
        if(val_2 != 0)
        {
                bool val_4 = this.multiplierCosts.ContainsKey(key:  val_2.defaultMultiplier);
            if(val_4 != false)
        {
                if((this.multiplierCosts.ContainsKey(key:  val_4.currentMultiplier)) == true)
        {
            goto label_6;
        }
        
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  -1231668448);
        val_14 = this;
        this.PopulateMultiplierCosts();
        label_6:
        bool val_8 = this.multiplierCosts.ContainsKey(key:  this.currentMultiplier);
        if(val_8 != false)
        {
                if(this.multiplierCosts != 0)
        {
                return this.multiplierCosts.Item[val_8.currentMultiplier];
        }
        
            return this.multiplierCosts.Item[val_8.currentMultiplier];
        }
        
        UnityEngine.Debug.LogWarning(message:  -1231659056);
        Dictionary.KeyCollection<TKey, TValue> val_10 = this.multiplierCosts.Keys;
        System.Func<System.Single, System.Boolean> val_11 = new System.Func<System.Single, System.Boolean>(object:  -1231622368, method:  new IntPtr(3063313536));
        float val_12 = System.Linq.Enumerable.FirstOrDefault<System.Single>(source:  this.multiplierCosts, predicate:  7720960);
        if(this.multiplierCosts > 0)
        {
                if(this.multiplierCosts != 0)
        {
                return this.multiplierCosts.Item[this.multiplierCosts];
        }
        
            return this.multiplierCosts.Item[this.multiplierCosts];
        }
        
        UnityEngine.Debug.LogError(message:  -1231646592);
        return (float)this.multiplierCosts;
    }
    public bool get_IsMaxGoldedMultiplier()
    {
        float val_1 = this.currentMultiplier;
        float val_2 = this.maxGoldenMultiplier;
        if()
        {
                0 = 1;
        }
        
        return true;
    }
    public float get_GetCurrentGoldenMultiplier()
    {
        return this.GetTotalMultipliers();
    }
    public float get_GetCurrentBaseMultiplier()
    {
        return this.currentMultiplier;
    }
    public int get_GetCurrentLevelCompleteBonus()
    {
        return (int)this.currentLevelCompleteBonus;
    }
    public float get_GetCurrentBonusFromSubs()
    {
        return WGSubscriptionManager.GetPointMultiplier();
    }
    public float get_GetCurrentBonusFromDifficulty()
    {
        return DifficultySettingManager.GetCurrentPointMultiplier;
    }
    private bool get_knobEnabled()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return true;
        }
        
        return true;
    }
    private float get_defaultMultiplier()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_defaultCost()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_multiplierIncrement()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_costIncrementCoefficient()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_maxGoldenMultiplier()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_currentMultiplier()
    {
        Player val_1 = App.Player;
        if(2621448 < 0)
        {
                return this.defaultMultiplier;
        }
        
        Player val_2 = App.Player;
        if(2621448 != 0)
        {
                return 1.118596E-37f;
        }
        
        return 1.118596E-37f;
    }
    private void set_currentMultiplier(float value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1229912672, method:  new IntPtr(3065029600));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public bool PurchaseMultiplier()
    {
        var val_18;
        var val_19;
        float val_1 = this.GetNextCost;
        val_18 = 0;
        Player val_2 = App.Player;
        val_19 = 0;
        if(4 < S16)
        {
                return (bool)val_18;
        }
        
        float val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().currentMultiplier;
        float val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().multiplierIncrement;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = (new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) + (new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>());
        string val_8 = System.String.Format(format:  -1229824672, arg0:  15282176);
        val_19 = "multiplier {0}";
        Add(key:  -1229824576, value:  -1229824672);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DebitBalance(debitAmount:  S16, source:  -1229824464, additionalParams:  78753792);
        float val_10 = currentMultiplier;
        uint val_18 = 36340740;
        float val_11 = multiplierIncrement;
        val_18 = val_18 + 36340740;
        currentMultiplier = 36340740;
        double val_12 = System.Math.Round(value:  System.Math.Round(value:  null, digits:  System.Math.__il2cppRuntimeField_cctor_finished), digits:  val_18);
        val_18.currentMultiplier = 36340740;
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1229800352, aName:  -1232710528);
        NotificationCenter val_14 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        SLC.Social.Leagues.LeaguesDataController val_15 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_18 = 1;
        if(0 == 0)
        {
                return (bool)val_18;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_17 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_18 = 1;
        0.UpdateMyProfileInfo(force:  true);
        return (bool)val_18;
    }
    public void CurrentLevelWordStreaked(int currentStreak)
    {
        var val_7;
        bool val_8;
        val_7 = 35626538;
        val_8 = static_value_021F9E2A;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        if(currentStreak < 50)
        {
                return;
        }
        
        float val_1 = this.currentMultiplier;
        val_7 = val_8;
        if((UnityEngine.Mathf.Approximately(a:  this.defaultMultiplier, b:  null)) == false)
        {
                return;
        }
        
        if(this.hasShownTooltipThisLevel == true)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        0.PlayCompleteFlyout();
        mem2[0] = 1;
    }
    private void PopulateMultiplierCosts()
    {
        float val_12;
        var val_14;
        var val_15;
        this.multiplierCosts.Clear();
        float val_1 = this.multiplierCosts.defaultCost;
        float val_2 = this.multiplierCosts.defaultMultiplier;
        System.Collections.Generic.Dictionary<System.Single, System.Single> val_11 = this.multiplierCosts;
        var val_12 = 992;
        float val_4 = System.Math.__il2cppRuntimeField_cctor_finished.costIncrementCoefficient;
        val_12 = S30;
        val_11 = val_11 + val_12;
        val_14 = System.Math.__il2cppRuntimeField_cctor_finished;
        float val_6 = S19 + (-1f);
        if(( & 1) != 0)
        {
                val_15 = S19;
        }
        
        this.multiplierCosts.Add(key:  null, value:  null);
        float val_8 = this.multiplierCosts.multiplierIncrement;
        System.Collections.Generic.Dictionary<System.Single, System.Single> val_9 = this.multiplierCosts + S30;
        double val_10 = System.Math.Round(value:  System.Math.Round(value:  null, digits:  System.Math.__il2cppRuntimeField_cctor_finished), digits:  System.Math.__il2cppRuntimeField_cctor_finished);
        val_12 = val_12 - 1;
    }
    private float GetTotalMultipliers()
    {
        float val_1 = WGSubscriptionManager.GetPointMultiplier();
        float val_7 = -1f;
        float val_3 = DifficultySettingManager.GetCurrentPointMultiplier;
        val_7 = 0 + val_7;
        if(static_value_021F9E2C > false)
        {
                0 = 0 + val_7;
        }
        
        float val_4 = this.currentMultiplier;
        uint val_8 = 0;
        if(static_value_021F9E2C > false)
        {
                0f = val_7;
        }
        
        val_8 = (val_8 + 0) + 0f;
        double val_6 = System.Math.Round(value:  null, digits:  System.Math.__il2cppRuntimeField_cctor_finished);
        return (float)val_8;
    }
    private void OnSceneLoaded(SceneType sceneType)
    {
        if(sceneType != 2)
        {
                return;
        }
        
        if(GoldenMultiplierManager.IsAvaialable == false)
        {
                return;
        }
        
        35626541 = 1152921504886931456;
        WordRegion val_2 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1229326752, method:  new IntPtr(3065614496));
        0.addOnLevelLoadedAction(callback:  7401472);
        WordRegion val_6 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1229326752, method:  new IntPtr(3065615520));
        0.addOnLevelCompleteAction(callback:  7401472);
    }
    private void OnLevelLoaded(GameLevel level)
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1232710528);
        this.hasShownTooltipThisLevel = false;
    }
    private void OnLevelComplete(GameLevel level)
    {
        if(GoldenMultiplierManager.IsAvaialable == false)
        {
                return;
        }
        
        float val_2 = this.GetTotalMultipliers();
        int val_11 = level.goldenApplesStreaks;
        val_11 = 3065881264 * val_11;
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_11);
        this.currentLevelCompleteBonus = val_3;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_5 = val_3 - level.goldenApplesStreaks;
        Add(key:  -1229110368, value:  13152256);
        Add(key:  -1229110272, value:  13152256);
        float val_6 = DifficultySettingManager.GetCurrentPointMultiplier;
        if(null > 0)
        {
                float val_7 = DifficultySettingManager.GetCurrentPointMultiplier;
            float val_12 = -1f;
            val_12 = 0 + val_12;
            val_12 = val_12 * val_11;
            Add(key:  -1229110144, value:  15282176);
        }
        
        float val_8 = WGSubscriptionManager.GetPointMultiplier();
        if(null > 0)
        {
                float val_9 = WGSubscriptionManager.GetPointMultiplier();
            float val_13 = -1f;
            val_13 = 0 + val_13;
            val_13 = val_13 * val_11;
            Add(key:  -2092883856, value:  15282176);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        35626543 = public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance();
    }
    public GoldenMultiplierManager()
    {
        System.Collections.Generic.Dictionary<System.Single, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.Single, System.Single>();
        this.multiplierCosts = null;
    }
    private bool <get_GetNextCost>b__10_0(float x)
    {
        float val_1 = this.currentMultiplier;
        if(<0)
        {
                0 = 1;
        }
        
        return true;
    }

}
