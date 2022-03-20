using UnityEngine;
public class WordStreak : MonoSingleton<WordStreak>
{
    // Fields
    public const string STREAK_UPDATED = "OnWordStreakUpdated";
    protected int currentStreak;
    public static System.Collections.Generic.Dictionary<int, string> streakFeedback;
    protected GameLevel currentLevel;
    
    // Properties
    public static int CurrentStreak { get; }
    public static int LargestStreak { get; }
    public static int ApplesFromStreak { get; }
    public static int ApplesFromStreakSub { get; }
    
    // Methods
    public static int get_CurrentStreak()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        if((-278152400) == 0)
        {
                return (int)public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_C;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return (int)public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_C;
    }
    public static int get_LargestStreak()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-278152400) == 0)
        {
                return (int)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 40];
        val_5 = public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 40;
        return (int)val_5;
    }
    public static int get_ApplesFromStreak()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-278152400) == 0)
        {
                return (int)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 24];
        val_5 = public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 24;
        return (int)val_5;
    }
    public static int get_ApplesFromStreakSub()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-278152400) == 0)
        {
                return (int)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 28];
        val_5 = public static WordStreak MonoSingleton<WordStreak>::get_Instance().__il2cppRuntimeField_10 + 28;
        return (int)val_5;
    }
    protected virtual void Start()
    {
        WordRegion val_1 = WordRegion.instance;
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_2 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -277679376, method:  typeof(WordStreak).__il2cppRuntimeField_118);
        addOnValidWordSubmittedAction(callback:  7507968);
        WordRegion val_3 = WordRegion.instance;
        System.Action val_4 = new System.Action(object:  -277679376, method:  typeof(WordStreak).__il2cppRuntimeField_120);
        addOnInvalidWordSubmittedAction(callback:  7454720);
        WordRegion val_5 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -277679376, method:  typeof(WordStreak).__il2cppRuntimeField_100);
        addOnLevelLoadedAction(callback:  7401472);
        MainController val_7 = MainController.instance;
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -277679376, method:  typeof(WordStreak).__il2cppRuntimeField_108);
        1.AddListener(call:  162246656);
    }
    protected virtual void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus == true)
        {
                return;
        }
        
        System.Collections.IEnumerator val_1 = this.CheckAndBreakStreak();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -277567376);
    }
    public void PlayBorderEffects(bool restoreEffects = False)
    {
        var val_7;
        if(restoreEffects != false)
        {
                if(this.currentStreak < 2)
        {
                return;
        }
        
            var val_7 = 2;
            do
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static GoldenApplesEffectController MonoSingleton<GoldenApplesEffectController>::get_Instance();
            if((-277479376) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static GoldenApplesEffectController MonoSingleton<GoldenApplesEffectController>::get_Instance();
            PlayEffects(streak:  2);
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 <= this.currentStreak);
        
            return;
        }
        
        val_7 = 1152921512919302192;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-277479376) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayEffects(streak:  this.currentStreak);
    }
    protected virtual void OnLevelLoaded(GameLevel level)
    {
        this.currentLevel = level;
        if(GoldenMultiplierManager.IsAvaialable == false)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -277338256, aName:  -1228543888);
    }
    protected virtual void OnLevelComplete()
    {
        goto typeof(WordStreak).__il2cppRuntimeField_10C;
    }
    private System.Collections.IEnumerator CheckAndBreakStreak()
    {
        object val_1 = new System.Object();
        typeof(WordStreak.<CheckAndBreakStreak>d__17).__il2cppRuntimeField_8 = 0;
        typeof(WordStreak.<CheckAndBreakStreak>d__17).__il2cppRuntimeField_10 = this;
    }
    private bool IsBreakingStreak()
    {
        var val_1;
        var val_1 = 29231472;
        val_1 = 6394316 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(TrackingComponent.lastIntent != 0)
        {
                return false;
        }
        
        bool val_2 = InAppPurchasesManager.<inPurchaseIntent>k__BackingField;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    protected void StopBorderEffects()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-277479376) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopEffects();
    }
    public virtual void ResetStreak()
    {
        this.currentStreak = 0;
    }
    protected virtual void OnValidWordSubmitted(string word, bool extra)
    {
        var val_21;
        GameLevel val_22;
        int val_23;
        GameLevel val_24;
        int val_25;
        var val_26;
        if(extra != false)
        {
                GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
        {
                return;
        }
        
        }
        
        val_21 = this;
        int val_2 = this.currentStreak + 1;
        this.currentStreak = val_2;
        GameBehavior val_3 = App.getBehavior;
        if(val_2 < 0)
        {
                this.StopBorderEffects();
            return;
        }
        
        this.PlayBorderEffects(restoreEffects:  false);
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
            
        }
        else
        {
                if(this.currentStreak < 12)
        {
                10 = this.currentStreak - 1;
        }
        
        }
        
        val_22 = this.currentLevel;
        if(val_22 != 0)
        {
                val_23 = this.currentLevel.goldenApplesStreaks;
        }
        else
        {
                val_22 = 24;
            val_23 = 0;
        }
        
        int val_21 = 10;
        val_21 = val_23 + val_21;
        mem[24] = val_21;
        this.currentLevel.highestWordStreak = UnityEngine.Mathf.Max(a:  this.currentLevel.highestWordStreak, b:  this.currentStreak);
        Player val_6 = App.Player;
        2621448.SetLifetimeLargestStreak = this.currentStreak;
        if(GoldenMultiplierManager.IsAvaialable != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CurrentLevelWordStreaked(currentStreak:  this.currentLevel.goldenApplesStreaks);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -276640560, aName:  -1228543888);
        }
        else
        {
                val_24 = this.currentLevel;
            if(val_24 != 0)
        {
                val_25 = this.currentLevel.goldenApplesStreaksSubBonus;
            val_26 = WGSubscriptionManager.GetAdditionalPoints(basePoints:  10);
        }
        else
        {
                val_24 = 28;
            val_25 = 52;
            int val_11 = WGSubscriptionManager.GetAdditionalPoints(basePoints:  10);
            val_26 = val_11;
        }
        
            val_11 = val_25 + val_26;
            mem[28] = val_11;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_13 = this.currentStreak.ToString();
            string val_14 = -276665680(-276665680) + -276640548(-276640548);
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1436585440) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardExtraApples(earnedAmount:  10);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -276665584)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnWordStreakUpdated(extra:  extra);
    }
    protected virtual void OnInvalidWordSubmitted()
    {
        this.StopBorderEffects();
        goto typeof(WordStreak).__il2cppRuntimeField_10C;
    }
    public WordStreak()
    {
    
    }
    private static WordStreak()
    {
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        if(null != 0)
        {
                Add(key:  1, value:  -990687360);
        }
        else
        {
                Add(key:  1, value:  -990687360);
        }
        
        Add(key:  2, value:  -276305008);
        if(null != 0)
        {
                Add(key:  3, value:  -276304912);
        }
        else
        {
                Add(key:  3, value:  -276304912);
        }
        
        Add(key:  4, value:  -276304800);
        if(null != 0)
        {
                Add(key:  5, value:  -276304704);
        }
        else
        {
                Add(key:  5, value:  -276304704);
        }
        
        Add(key:  6, value:  -276304592);
        WordStreak.streakFeedback = null;
    }

}
