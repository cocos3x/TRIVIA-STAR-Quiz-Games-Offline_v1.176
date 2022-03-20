using UnityEngine;
public class ForestFrenzyManager : MonoSingleton<ForestFrenzyManager>
{
    // Fields
    private System.Collections.Generic.List<WordForest.WFOForestContent> forestContentList;
    private WordForest.WFODigAnimation digAnimationPrefab;
    private UnityEngine.ParticleSystem prefabEfxTreeChoppedSmoke;
    private System.Collections.Generic.List<WordForest.WFOForestData> forestDataList;
    private int levelsPlayedThisSession;
    private System.DateTime lastLevelCompleteShownTime;
    
    // Properties
    public static bool IsFeatureUnlocked { get; }
    public System.Collections.Generic.List<WordForest.WFOForestData> ForestDataList { get; }
    public WordForest.WFOForestData CurrentForestData { get; }
    public WordForest.WFODigAnimation DigAnimationPrefab { get; }
    public UnityEngine.ParticleSystem ChoppedTreeSmokeEfxPrefab { get; }
    public int CurrentForestID { get; }
    public int CurrentForestGrowth { get; }
    public bool CurrentForestContainsDamagedTrees { get; }
    public int CurrentMaxGrowth { get; }
    public int CurrentGrowthCost { get; }
    public int CurrentForestLevel { get; }
    public string CurrentForestName { get; }
    public WordForest.WFOBackgroundType CurrentBGType { get; }
    public bool IsAtMaxGrowth { get; }
    public bool IsAtLastForest { get; }
    public int AffordableGrowthStages { get; }
    
    // Methods
    public static bool get_IsFeatureUnlocked()
    {
        var val_2;
        Player val_1 = App.Player;
        val_2 = null;
        val_2 = null;
        if(0 >= ForestFrenzyEcon.UnlockLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.List<WordForest.WFOForestData> get_ForestDataList()
    {
    
    }
    public WordForest.WFOForestData get_CurrentForestData()
    {
        int val_1 = this.CurrentForestID;
        int val_2 = (R1 + 24 + 12) - 1;
        int val_3 = UnityEngine.Mathf.Clamp(value:  0, min:  0, max:  val_2);
        if((R1 + 24 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        ForestFrenzyManager val_5 = R1 + 24 + 8;
        int val_4 = val_3 + (val_3 << 1);
        val_5 = val_5 + (val_4 << 3);
        val_5 = val_5 + 16;
        this = val_5;
        return new WordForest.WFOForestData() {level = val_5, forestName = val_4, initialCost = val_2};
    }
    public WordForest.WFODigAnimation get_DigAnimationPrefab()
    {
    
    }
    public UnityEngine.ParticleSystem get_ChoppedTreeSmokeEfxPrefab()
    {
    
    }
    public int get_CurrentForestID()
    {
        return 1;
    }
    public int get_CurrentForestGrowth()
    {
        null = null;
        if(ForestFrenzyEventProgress.forestMapData != 0)
        {
                return ForestFrenzyEventProgress.forestMapData.CurrentForestGrowth(includeDamagedTrees:  false);
        }
        
        return ForestFrenzyEventProgress.forestMapData.CurrentForestGrowth(includeDamagedTrees:  false);
    }
    public bool get_CurrentForestContainsDamagedTrees()
    {
        null = null;
        if(ForestFrenzyEventProgress.forestMapData != 0)
        {
                return ForestFrenzyEventProgress.forestMapData.ContainsDamagedTrees;
        }
        
        return ForestFrenzyEventProgress.forestMapData.ContainsDamagedTrees;
    }
    public int get_CurrentMaxGrowth()
    {
        var val_2;
        WordForest.WFOForestData val_1 = CurrentForestData;
        return (int)val_2;
    }
    public int get_CurrentGrowthCost()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        if(ForestFrenzyEcon.CostPerGrowthStage == null)
        {
                val_6 = null;
        }
        
        if(this.CurrentForestGrowth < (ForestFrenzyEcon.CostPerGrowthStage + 12))
        {
                val_7 = null;
            val_8 = ForestFrenzyEcon.CostPerGrowthStage + (CurrentForestGrowth << 2);
            return (int)null;
        }
        
        val_9 = null;
        val_8 = ForestFrenzyEcon.CostPerGrowthStage + (((ForestFrenzyEcon.CostPerGrowthStage + 12) - 1) << 2);
        return (int)null;
    }
    public int get_CurrentForestLevel()
    {
        var val_2;
        WordForest.WFOForestData val_1 = CurrentForestData;
        return (int)val_2;
    }
    public string get_CurrentForestName()
    {
        string val_2;
        WordForest.WFOForestData val_1 = CurrentForestData;
        string val_3 = Localization.Localize(key:  val_2, defaultValue:  1098586544, useSingularKey:  false);
    }
    public WordForest.WFOBackgroundType get_CurrentBGType()
    {
        WordForest.WFOForestData val_1 = CurrentForestData;
    }
    public bool get_IsAtMaxGrowth()
    {
        var val_3;
        int val_1 = this.CurrentForestGrowth;
        WordForest.WFOForestData val_2 = CurrentForestData;
        if(val_2.bgType >= val_3)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_IsAtLastForest()
    {
        if((this.CurrentForestID - 1) < 2)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_AffordableGrowthStages()
    {
        var val_3;
        float val_5;
        var val_9;
        int val_10;
        int val_11;
        var val_12;
        var val_9 = 22609904;
        val_9 = 13018052 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = ForestFrenzyEventProgress.accumulatedCurrency;
        val_11 = CurrentForestGrowth;
        WordForest.WFOForestData val_2 = CurrentForestData;
        val_12 = 0;
        if(val_11 >= val_3)
        {
                return (int)val_7.bgType;
        }
        
        do
        {
            WordForest.WFOForestData val_4 = CurrentForestData;
            int val_6 = val_5.GetGrowthCost(toStage:  val_11);
            WordForest.WFOForestData val_7 = CurrentForestData;
            val_11 = val_11 + 1;
            if(val_11 >= val_3)
        {
                val_10 = val_10 - val_7.stages;
        }
        
            if(val_11 >= val_3)
        {
                0 = 1;
        }
        
        }
        while(val_11 < val_3);
        
        return (int)val_7.bgType;
    }
    public override void InitMonoSingleton()
    {
        var val_1;
        var val_1 = 22620701;
        val_1 = 13018416 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        this.forestDataList = ForestFrenzyEcon.forests;
    }
    public void ShowForestScene()
    {
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BannerAdsUnblocked = false;
    }
    public void CloseForestScene(bool playClicked = False)
    {
        if(ForestFrenzyMonolithProxy.Instance != 0)
        {
                UnityEngine.GameObject val_2 = ForestFrenzyMonolithProxy.Instance.gameObject;
            SLCWindow.CloseWindow(window:  ForestFrenzyMonolithProxy.Instance, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        
        GameBehavior val_3 = App.getBehavior;
        UnityEngine.AsyncOperation val_4 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BannerAdsUnblocked = true;
        if(playClicked != false)
        {
                return;
        }
        
        var val_6 = 22619834;
        val_6 = 13019284 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((ForestFrenzyEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    public void OnPlayLevelButtonClicked()
    {
        var val_13;
        var val_14;
        var val_15;
        GameBehavior val_1 = App.getBehavior;
        if(0.IsLoadingScene() != false)
        {
                return;
        }
        
        val_13 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = 0;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = PlayingChallenge;
        }
        
        if((val_14 != true) && (SceneDictator.IsInGameScene() != false))
        {
                if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_20;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
        var val_13 = 22605639;
        val_13 = 13020152 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 100;
        GameBehavior val_12 = App.getBehavior;
        label_20:
        this.CloseForestScene(playClicked:  true);
    }
    public void AddCurrency(int amount)
    {
        var val_5;
        ForestFrenzyEventProgress.AddCurrency(amount:  amount);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1392636224) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_5 = 22607252;
        val_5 = 13020704 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UpdateCurrency(from:  ForestFrenzyEventProgress.accumulatedCurrency - amount, to:  ForestFrenzyEventProgress.accumulatedCurrency);
    }
    private void DeductCurrency(int amount)
    {
        var val_5;
        ForestFrenzyEventProgress.DeductCurrency(amount:  amount);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1392636224) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_5 = 22606692;
        val_5 = 13021264 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UpdateCurrency(from:  ForestFrenzyEventProgress.accumulatedCurrency + amount, to:  ForestFrenzyEventProgress.accumulatedCurrency);
    }
    public void AddGrowth(int damagedTreeIdToFix = -1, System.Action<bool> onServerResponse)
    {
        var val_5;
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        int val_15;
        System.Predicate<ZooTile> val_16;
        int val_17;
        var val_18;
        val_11 = onServerResponse;
        object val_1 = new System.Object();
        typeof(ForestFrenzyManager.<>c__DisplayClass44_0).__il2cppRuntimeField_8 = damagedTreeIdToFix;
        var val_12 = 22606284;
        val_12 = 13021672 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = ForestFrenzyEventProgress.accumulatedCurrency;
        int val_2 = CurrentGrowthCost;
        if(val_13 < val_2)
        {
            goto label_8;
        }
        
        val_13 = val_2.CurrentForestGrowth;
        WordForest.WFOForestData val_4 = CurrentForestData;
        if(val_13 >= val_5)
        {
            goto label_8;
        }
        
        val_14 = null;
        val_14 = null;
        System.Collections.Generic.List<WordForest.MapItem> val_6 = ForestFrenzyEventProgress.forestMapData.GetForestData();
        val_15 = ForestFrenzyEventProgress.forestMapData.CurrentGrowthCost;
        val_16 = null;
        val_16 = new System.Predicate<ZooTile>(object:  317251584, method:  new IntPtr(2902560192));
        int val_9 = ForestFrenzyEventProgress.forestMapData.FindIndex(match:  8040448);
        val_17 = val_9;
        if(val_9 < 0)
        {
            goto label_14;
        }
        
        if((ForestFrenzyEventProgress.forestMapData + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> val_13 = ForestFrenzyEventProgress.forestMapData.area;
        val_13 = val_13 + (val_17 << 2);
        val_18 = mem[(ForestFrenzyEventProgress.forestMapData.area + (val_9) << 2) + 16];
        goto label_17;
        label_8:
        if(val_11 == 0)
        {
                return;
        }
        
        val_11.Invoke(obj:  false);
        return;
        label_14:
        val_16 = 4;
        goto label_20;
        label_28:
        if(val_9 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.String.op_Inequality(a:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 8, b:  -1402413584)) != true)
        {
                if((ForestFrenzyEventProgress.forestMapData + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        }
        
        val_16 = 5;
        label_20:
        if((val_16 - 4) < (ForestFrenzyEventProgress.forestMapData + 12))
        {
            goto label_28;
        }
        
        val_17 = val_17;
        val_15 = val_15;
        goto label_33;
        label_17:
        label_33:
        System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg.DeductCurrency(amount:  null);
        if((ForestFrenzyEventProgress.forestMapData + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> val_14 = ForestFrenzyEventProgress.forestMapData.area;
        val_14 = val_14 + (val_17 << 2);
        mem2[0] = 1;
        ForestFrenzyEventProgress.UpdateForestMapData();
    }
    public void RewardForestComplete()
    {
        var val_6;
        var val_7;
        var val_6 = 22605322;
        val_6 = 13022636 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(ForestFrenzyEventProgress.hasRewarded != false)
        {
                return;
        }
        
        ForestFrenzyEventProgress.HasRewarded = true;
        if(this.IsAtLastForest == true)
        {
                "Forest Frenzy Location" = "Forest Frenzy All Complete";
        }
        
        Player val_2 = App.Player;
        val_7 = null;
        val_7 = null;
        0.AddCredits(amount:  new System.Decimal() {flags = ForestFrenzyEcon.ForestCompleteReward, hi = R6, lo = R7, mid = ForestFrenzyEcon.UnlockLevel.__il2cppRuntimeField_18}, source:  "Forest Frenzy All Complete", subSource:  0, externalParams:  0, doTrack:  true);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnEventHandlerProgress();
    }
    public WordForest.WFOForestContent GetCurrentForestLayout()
    {
        int val_2;
        WordForest.WFOForestData val_1 = CurrentForestData;
        return val_1.stages.GetForestLayout(forestId:  val_2);
    }
    public WordForest.WFOForestContent GetForestLayout(int forestId)
    {
        UnityEngine.Object val_6;
        var val_7;
        var val_8;
        object val_1 = new System.Object();
        typeof(ForestFrenzyManager.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = forestId;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  317304832, method:  new IntPtr(2902909744));
        WordForest.WFOForestContent val_3 = this.forestContentList.Find(match:  8040448);
        val_6 = this.forestContentList;
        if(val_6 != 0)
        {
                return;
        }
        
        string val_5 = System.String.Format(format:  -1392054480, arg0:  13152256);
        UnityEngine.Debug.LogError(message:  -1392054480);
        if(this.forestContentList != 0)
        {
                val_8 = "Forest Layout Content for forest {0} not found, loading last forest as a failsafe";
        }
        else
        {
                val_8 = 0;
            val_7 = 0;
        }
        
        if(val_7 <= (-1))
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 4294967292;
        val_6 = mem[(0 + 4294967292) + 16];
        val_6 = (0 + 4294967292) + 16;
    }
    public bool TryShowForestBeforeLevelComplete()
    {
        ulong val_2;
        var val_5;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        if(this.levelsPlayedThisSession >= ForestFrenzyEcon.LevelsToPlay)
        {
                System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511804863552}, d2:  new System.DateTime() {dateData = val_2});
            double val_7 = val_5.TotalSeconds;
            val_12 = null;
            val_12 = null;
            val_11 = 1152921504923832320;
            var val_10 = 22603748;
            val_10 = 13024208 + val_10;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_13 = null;
            val_13 = null;
            int val_11 = this.levelsPlayedThisSession;
            val_11 = val_11 + 1;
            this.levelsPlayedThisSession = val_11;
            val_14 = 0;
            if(ForestFrenzyEventProgress.accumulatedCurrency < CurrentGrowthCost)
        {
                return (bool)val_14;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
            this.lastLevelCompleteShownTime = val_2;
            val_2.ShowForestScene();
            val_14 = 1;
            return (bool)val_14;
        }
        
        int val_12 = this.levelsPlayedThisSession;
        val_12 = val_12 + 1;
        this.levelsPlayedThisSession = val_12;
        val_14 = 0;
        return (bool)val_14;
    }
    public void Hack_SetForestGrowth(int growth)
    {
    
    }
    public ForestFrenzyManager()
    {
        var val_1 = null;
        this.lastLevelCompleteShownTime = System.DateTime.MinValue;
    }

}
