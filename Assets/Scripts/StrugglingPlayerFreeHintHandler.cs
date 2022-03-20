using UnityEngine;
public class StrugglingPlayerFreeHintHandler : HintFeatureHandler
{
    // Fields
    private const float DEFAULT_AVG_COMPLETION_TIME = 60;
    private bool initd;
    private int freeHintsRemaining;
    private bool freeHintAvailableNow;
    private float currentCompletionTime;
    private UnityEngine.Coroutine waitingRoutine;
    private int wordsInThisLevel;
    private float timeWaited;
    
    // Properties
    public override bool freeHintEligable { get; }
    public override bool hasFreeHintsRemaining { get; }
    private float TimeToWaitBetweenHints { get; }
    
    // Methods
    public override bool get_freeHintEligable()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        val_11 = 0;
        if((-2116505760) == 0)
        {
                return (bool)val_11;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        val_11 = 0;
        if(PlayingChallenge == true)
        {
                return (bool)val_11;
        }
        
        Player val_5 = App.Player;
        val_10 = 0;
        val_11 = 0;
        GameEcon val_6 = App.getGameEcon;
        val_9 = 0;
        if(val_10 < 34479464)
        {
                return (bool)val_11;
        }
        
        Player val_7 = App.Player;
        val_10 = 0;
        val_11 = 0;
        GameEcon val_8 = App.getGameEcon;
        val_9 = 0;
        if(val_10 > 40)
        {
                return (bool)val_11;
        }
        
        val_11 = 1;
        return (bool)val_11;
    }
    public override void Init()
    {
        if(this.initd == false)
        {
                this.initd = true;
            this.initd = this.initd;
        }
    
    }
    private void OnDisable()
    {
        if(this.waitingRoutine == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.waitingRoutine);
    }
    public override void OnLevelStarted()
    {
        var val_14;
        int val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        val_14 = 1152921504886931456;
        WordRegion val_3 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_5 = WordRegion.instance;
            this.wordsInThisLevel = 0;
        }
        
        GameLevel val_6 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        this.currentCompletionTime = 3.034663E-39f;
        if(0 < 0)
        {
                return;
        }
        
        if(0 == 0)
        {
                0 = 0;
            this.currentCompletionTime = 60f;
        }
        
        this.freeHintAvailableNow = false;
        Player val_8 = App.Player;
        val_14 = 0;
        if((CPlayerPrefs.GetInt(key:  -1005038240, defaultValue:  0)) == val_14)
        {
                this.freeHintsRemaining = CPlayerPrefs.GetInt(key:  -1005038144, defaultValue:  0);
        }
        else
        {
                GameEcon val_10 = App.getGameEcon;
            this.freeHintsRemaining = 983057;
            CPlayerPrefs.SetInt(key:  -1005038144, val:  983057);
            Player val_11 = App.Player;
            CPlayerPrefs.SetInt(key:  -1005038240, val:  0);
            val_15 = this.freeHintsRemaining;
        }
        
        if(val_15 < 1)
        {
                return;
        }
        
        if(this.waitingRoutine != 0)
        {
                this.StopCoroutine(routine:  this.waitingRoutine);
        }
        
        System.Collections.IEnumerator val_12 = this.WaitThenDisplayPopup();
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  -1005009952);
        this.waitingRoutine = this;
    }
    public override void OnLevelComplete()
    {
        if(this.waitingRoutine == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.waitingRoutine);
    }
    public override void OnSceneChanged()
    {
        if(this.waitingRoutine == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.waitingRoutine);
    }
    public override bool get_hasFreeHintsRemaining()
    {
        if(this == 0)
        {
                return true;
        }
        
        if(this.freeHintsRemaining < 1)
        {
                return true;
        }
        
        if(this.freeHintAvailableNow == true)
        {
                0 = 1;
        }
        
        return true;
    }
    public override void OnHintUsed(bool freeHint)
    {
        if(this == 0)
        {
                return;
        }
        
        GameLevel val_1 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        35625820 = 0f;
        if(0f < 0)
        {
                return;
        }
        
        if(freeHint == false)
        {
                0f = 0f;
            this.timeWaited = 0f;
        }
    
    }
    public override void OnMyFreeHintUsed()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                val_7 = 33449456;
        }
        else
        {
                val_7 = 33449456;
        }
        
        0.StruggleHintsUsed = 33449457;
        Player val_2 = App.Player;
        val_8 = 2621448;
        if(val_8 != 0)
        {
                val_9 = 23;
        }
        else
        {
                val_8 = 64;
            val_9 = 52;
        }
        
        mem[64] = 53;
        int val_7 = this.freeHintsRemaining;
        this.freeHintAvailableNow = false;
        val_7 = val_7 - 1;
        this.freeHintsRemaining = val_7;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateFreeHintEligable();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.CheckFreeHinting();
        if(this.freeHintsRemaining >= 1)
        {
                if(this.waitingRoutine != 0)
        {
                this.StopCoroutine(routine:  this.waitingRoutine);
        }
        
            System.Collections.IEnumerator val_5 = this.WaitThenDisplayPopup();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1004425376);
            this.waitingRoutine = this;
        }
        
        var val_8 = 29440570;
        val_8 = 6184968 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        App.trackerManager.track(eventName:  Events.STRUGGLE_HINT_USED);
    }
    private System.Collections.IEnumerator WaitThenDisplayPopup()
    {
        object val_1 = new System.Object();
        typeof(StrugglingPlayerFreeHintHandler.<WaitThenDisplayPopup>d__19).__il2cppRuntimeField_8 = 0;
        typeof(StrugglingPlayerFreeHintHandler.<WaitThenDisplayPopup>d__19).__il2cppRuntimeField_10 = this;
    }
    private float get_TimeToWaitBetweenHints()
    {
        float val_2;
        if(this.wordsInThisLevel != 0)
        {
                GameEcon val_1 = App.getGameEcon;
            float val_2 = this.currentCompletionTime;
            val_2 = (1.161676E-42f) * val_2;
            val_2 = val_2 * (float)this.wordsInThisLevel;
            return val_2;
        }
        
        val_2 = 99999f;
        return val_2;
    }
    public StrugglingPlayerFreeHintHandler()
    {
    
    }

}
