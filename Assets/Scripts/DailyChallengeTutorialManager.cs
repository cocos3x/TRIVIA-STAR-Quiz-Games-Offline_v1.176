using UnityEngine;
public class DailyChallengeTutorialManager : MonoSingleton<DailyChallengeTutorialManager>
{
    // Fields
    private bool _TutorialActive;
    private bool _GameplayTutorialActive;
    private int _GameplayTutorialStep;
    
    // Properties
    public bool TutorialActive { get; }
    public bool GameplayTutorialActive { get; }
    public int GameplayTutorialStep { get; set; }
    private DailyChallengeTutorialGameplayHelper GetGameplayHelper { get; }
    private DailyChallengeTutorialCalendarHelper GetCalendarHelper { get; }
    private bool PlayerShouldSeeTutorial { get; }
    private bool HasAnyDailyChallengeProgress { get; }
    private bool HasPlayedDailyChallenge30Days { get; }
    private bool HasSeenTutorial { get; }
    
    // Methods
    public bool get_TutorialActive()
    {
        return (bool)this._TutorialActive;
    }
    public bool get_GameplayTutorialActive()
    {
        return (bool)this._GameplayTutorialActive;
    }
    public int get_GameplayTutorialStep()
    {
        return (int)this._GameplayTutorialStep;
    }
    public void set_GameplayTutorialStep(int value)
    {
        this._GameplayTutorialStep = value;
    }
    private DailyChallengeTutorialGameplayHelper get_GetGameplayHelper()
    {
        return MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private DailyChallengeTutorialCalendarHelper get_GetCalendarHelper()
    {
        return MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private bool get_PlayerShouldSeeTutorial()
    {
        return false;
    }
    private bool get_HasAnyDailyChallengeProgress()
    {
        var val_7;
        Player val_1 = App.Player;
        val_7 = 1;
        if(2165608 > 0)
        {
                return (bool)val_7;
        }
        
        Player val_2 = App.Player;
        if(35143864 > 0)
        {
                return (bool)val_7;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<ZooTile> val_4 = GetLifetimeMonthlyZootiles();
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<ZooTile> val_6 = GetLifetimeMonthlyZootiles();
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_C) <= 0)
        {
                val_7 = 0;
        }
        
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private bool get_HasPlayedDailyChallenge30Days()
    {
        ulong val_3;
        var val_11;
        var val_14;
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_2 = LastPlayedDailyChallenge;
        val_14 = null;
        val_14 = null;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_3}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 8) > 0)
        {
                val_15 = 1;
        }
        
            return true;
        }
        
        System.DateTime val_7 = DateTimeCheat.Now;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_9 = LastPlayedDailyChallenge;
        System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511756218560}, d2:  new System.DateTime());
        double val_13 = val_11.TotalDays;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished <= 0)
        {
                val_15 = 1;
        }
        
        return true;
    }
    private bool get_HasSeenTutorial()
    {
        Player val_1 = App.Player;
        if(23 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
    }
    public void TryShowLobbyTutorial()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void ShowGameplayTutorial()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        DailyChallengeTutorialGameplayHelper val_3 = this.GetGameplayHelper;
        bool val_4 = UnityEngine.Object.op_Equality(x:  0, y:  0);
        if(val_4 != false)
        {
                UnityEngine.Debug.LogError(message:  -1440125920);
            return;
        }
        
        System.Collections.IEnumerator val_5 = val_4.wait_ShowFTUX();
        UnityEngine.Coroutine val_6 = 0.StartCoroutine(routine:  val_4);
    }
    public GameLevel GetGameLevel()
    {
        if(new GameLevel() != 0)
        {
                typeof(GameLevel).__il2cppRuntimeField_48 = 6;
            typeof(GameLevel).__il2cppRuntimeField_30 = "H|I|N|T";
            typeof(GameLevel).__il2cppRuntimeField_34 = "HI|IN|IT|HIT|TIN|HINT";
            typeof(GameLevel).__il2cppRuntimeField_38 = "";
        }
        else
        {
                mem[56] = "";
            mem[48] = "H|I|N|T";
            mem[52] = "HI|IN|IT|HIT|TIN|HINT";
            mem[72] = 6;
        }
        
        levelName = -1440013504;
    }
    public DailyChallengeGameLevel GetDailyChallengeGameLevel()
    {
        GameLevel val_2 = new DailyChallengeGameLevel().GetGameLevel();
        typeof(DailyChallengeGameLevel).__il2cppRuntimeField_C = new DailyChallengeGameLevel();
    }
    public int GetSunMoonWordIndex()
    {
        if(this._GameplayTutorialStep < 2)
        {
                this._GameplayTutorialStep = 1;
            return (int)this._GameplayTutorialStep;
        }
        
        if(this._GameplayTutorialStep == 2)
        {
                0 = 4;
        }
        
        return 4;
    }
    public System.Collections.Generic.List<bool> GetAllowedLettersForPan(int level, int lettersSize, System.Collections.Generic.List<string> lettersArray, System.Collections.Generic.List<int> indexes)
    {
        var val_10;
        int val_11;
        System.Collections.Generic.List<System.Boolean> val_12;
        var val_13;
        var val_14;
        var val_15;
        val_10 = this;
        val_11 = lettersSize;
        val_12 = null;
        val_12 = new System.Collections.Generic.List<System.Boolean>();
        if(val_12 != 0)
        {
                Add(item:  false);
            Add(item:  false);
            Add(item:  false);
        }
        else
        {
                Add(item:  false);
            Add(item:  false);
            Add(item:  false);
        }
        
        Add(item:  false);
        GameBehavior val_2 = App.getBehavior;
        val_13 = 0;
        string val_3 = val_13.GetCurrentLanguage();
        if(this._GameplayTutorialStep <= 1)
        {
            goto label_7;
        }
        
        if(this._GameplayTutorialStep != 2)
        {
            goto label_8;
        }
        
        val_14 = 4;
        val_10 = "T";
        goto label_9;
        label_25:
        if(this._GameplayTutorialStep <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 10485772;
        val_13 = mem[(0 + 10485772) + 16];
        val_13 = (0 + 10485772) + 16;
        bool val_4 = val_13.Equals(value:  -1439668192);
        if(val_4 == true)
        {
            goto label_18;
        }
        
        if(val_4 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 10485772;
        val_13 = mem[(0 + 10485772) + 16];
        val_13 = (0 + 10485772) + 16;
        bool val_5 = val_13.Equals(value:  -1706786096);
        if(val_5 == true)
        {
            goto label_18;
        }
        
        if(val_5 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 10485772;
        val_13 = mem[(0 + 10485772) + 16];
        val_13 = (0 + 10485772) + 16;
        if((val_13.Equals(value:  -1439668112)) == false)
        {
            goto label_22;
        }
        
        label_18:
        set_Item(index:  val_11, value:  true);
        label_22:
        val_14 = 5;
        label_9:
        val_11 = val_14 - 4;
        if(val_11 < val_12)
        {
            goto label_25;
        }
        
        return;
        label_7:
        val_15 = 4;
        val_10 = "I";
        goto label_27;
        label_39:
        if(this._GameplayTutorialStep <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 10485772;
        val_13 = mem[(0 + 10485772) + 16];
        val_13 = (0 + 10485772) + 16;
        bool val_7 = val_13.Equals(value:  -1706786096);
        if(val_7 == true)
        {
            goto label_32;
        }
        
        if(val_7 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + 10485772;
        val_13 = mem[(0 + 10485772) + 16];
        val_13 = (0 + 10485772) + 16;
        if((val_13.Equals(value:  -1439668112)) == false)
        {
            goto label_36;
        }
        
        label_32:
        set_Item(index:  val_11, value:  true);
        label_36:
        val_15 = 5;
        label_27:
        val_11 = val_15 - 4;
        if(val_11 < val_12)
        {
            goto label_39;
        }
        
        return;
        label_8:
        val_12 = null;
        val_12 = new System.Collections.Generic.List<System.Boolean>();
        if(val_11 < 1)
        {
                return;
        }
        
        do
        {
            Add(item:  true);
            val_11 = val_11 - 1;
        }
        while(val_12 != 0);
    
    }
    public void QAHACK_SKIPTUTORIAL()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1439547840) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QAHACK_CANCEL();
        }
        
        this.HandleGameplayTutorialAborted();
    }
    public void HandleLobbyTutorialClicked()
    {
        this._TutorialActive = true;
        this._GameplayTutorialActive = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public void CheckHomeClick()
    {
        if(this._TutorialActive == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
                return;
        }
        
        R4.HandleGameplayTutorialAborted();
    }
    public void HandleGameplayTutorialComplete()
    {
        this._GameplayTutorialActive = false;
    }
    public void HandlePreviousChallengesPrompted()
    {
        this._TutorialActive = false;
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public void HandleGameplayTutorialAborted()
    {
        this._TutorialActive = false;
        this._GameplayTutorialActive = false;
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public DailyChallengeTutorialManager()
    {
    
    }

}
