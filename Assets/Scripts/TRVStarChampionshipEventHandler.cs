using UnityEngine;
public class TRVStarChampionshipEventHandler : WGEventHandler
{
    // Fields
    public const string STAR_CHAMPIONSHIP_EVENT_ID = "StarChampionship";
    public const string EVENT_TRACKING_ID = "Star Championship Event";
    private const string STAR_CHAMPIONSHIP_EVENT_NAME = "STAR CHAMPIONSHIP";
    private static TRVStarChampionshipEventHandler <Instance>k__BackingField;
    private StarChampionshipEventProgress eventProgress;
    private System.Action onLevelCompleteRewardAnimFinished;
    
    // Properties
    public static TRVStarChampionshipEventHandler Instance { get; set; }
    public override bool SupportsGoldenApples { get; }
    public GameEventV2 getGameEvent { get; }
    private System.Collections.Generic.List<StarChampionshipTier> EventEcon { get; set; }
    
    // Methods
    public static TRVStarChampionshipEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(TRVStarChampionshipEventHandler value)
    {
        TRVStarChampionshipEventHandler.<Instance>k__BackingField = value;
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public GameEventV2 get_getGameEvent()
    {
    
    }
    private System.Collections.Generic.List<StarChampionshipTier> get_EventEcon()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    private void set_EventEcon(System.Collections.Generic.List<StarChampionshipTier> value)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_5F8 = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512780662136] = eventV2;
        TRVStarChampionshipEventHandler.<Instance>k__BackingField = this;
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnEventEnded()
    {
        TRVStarChampionshipEventHandler.<Instance>k__BackingField = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override void OnGameSceneBegan()
    {
        if(this != 0)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        R4.ShowStarChampionshipProgressPopup();
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        var val_5 = 1;
        if(this.eventProgress.Rewarded == true)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512781155184});
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512781155184});
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(TRVStarChampionshipEventHandler).__il2cppRuntimeField_29C;
    }
    public override void OnAppleAwarded(int earnedAmount)
    {
        int val_5;
        StarChampionshipEventProgress val_6;
        val_5 = 35630035;
        if(this != 0)
        {
                return;
        }
        
        StarChampionshipTier val_1 = this.GetCurrentTier();
        val_6 = this.eventProgress;
        if(val_6 != 0)
        {
                val_5 = this.eventProgress.Stars;
        }
        else
        {
                val_6 = 20;
            val_5 = 1;
        }
        
        mem[20] = val_5 + earnedAmount;
        StarChampionshipTier val_3 = this.GetCurrentTier();
        if(this == R8)
        {
                return;
        }
        
        System.Action val_4 = new System.Action(object:  -415389072, method:  new IntPtr(3879553200));
        this.onLevelCompleteRewardAnimFinished = null;
    }
    public override void MarkEventRewarded()
    {
        this.eventProgress.Rewarded = true;
        this.UpdateRewardStatus();
    }
    public override int LastProgressTimestamp()
    {
        if(this.eventProgress != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public override void UpdateProgress()
    {
        mem2[0] = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void OnLevelCompleteRewardAnimFinished()
    {
        if(this.onLevelCompleteRewardAnimFinished == 0)
        {
                return;
        }
        
        this.onLevelCompleteRewardAnimFinished.Invoke();
        this.onLevelCompleteRewardAnimFinished = 0;
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
            
        }
        else
        {
                R4.ShowStarChampionshipProgressPopup();
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_2;
        var val_3;
        val_2 = this;
        val_3 = connected;
        if(val_2 != 0)
        {
            
        }
    
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -414579808, defaultValue:  -414579920, useSingularKey:  false);
        string val_2 = this.GetEventProgressText();
        string val_3 = System.String.Format(format:  -414579680, arg0:  -414579552, arg1:  -414579808, arg2:  -414555472);
    }
    public override string GetGameButtonText()
    {
        string val_1 = Localization.Localize(key:  -414579808, defaultValue:  -414579920, useSingularKey:  false);
        string val_2 = this.GetEventProgressText();
        string val_3 = System.String.Format(format:  -414579680, arg0:  -414579552, arg1:  -414579808, arg2:  -414443472);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -414579808, defaultValue:  -414579920, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_6;
        if(new TRVStarChampionshipPopupUIParam() != 0)
        {
                float val_2 = this.GetProgressBarValue(definedDivisions:  -1075612608);
            val_6 = 3880752944;
        }
        else
        {
                float val_3 = this.GetProgressBarValue(definedDivisions:  null);
            val_6 = 3880752944;
        }
        
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_10 = val_6;
        StarChampionshipTier val_4 = this.GetCurrentTier();
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_C = 1152921512782567215;
        TheLibraryMainScreen val_5 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.UpdateProgressBar(uiParam:  365387776);
    }
    public override UnityEngine.Sprite GetEventIcon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVUtils MonoSingleton<TRVUtils>::get_Instance()) != 0)
        {
                return GetEventIcon(eventHandler:  -414098256);
        }
        
        return GetEventIcon(eventHandler:  -414098256);
    }
    public string GetEventProgressText()
    {
        StarChampionshipTier val_1 = this.GetNextTier();
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    private void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        if((System.String.op_Inequality(a:  static_value_021FAC13, b:  -1298908624)) != false)
        {
                string val_2 = -1322383584(-1322383584) + -1298908624(-1298908624);
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        bool val_3 = this.IsEventNewCycle();
        if(val_3 == true)
        {
                val_3 = this;
            this.ResetEventProgress();
        }
        
        this.ParseEcon(data:  data);
        this.ParseServerProgress(data:  data);
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private void ParseEcon(System.Collections.Generic.Dictionary<string, object> data)
    {
        StarChampionshipTier val_14;
        if(data == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_14 = null;
        val_14 = new StarChampionshipTier(tierIndex:  0, goal:  0, reward:  0, isTopTier:  false);
        Add(item:  358199296);
        object val_4 = data.Item[-1554533760];
        if(data == 0)
        {
                return;
        }
        
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
    
    }
    private void ParseServerProgress(System.Collections.Generic.Dictionary<string, object> data)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8;
        var val_9;
        val_8 = null;
        val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((data.ContainsKey(key:  -1545439648)) == false)
        {
            goto label_2;
        }
        
        object val_3 = data.Item[-1545439648];
        if(data != 0)
        {
                val_8 = data;
        }
        
        label_8:
        val_8 = 0;
        val_9 = 1;
        goto label_7;
        label_2:
        if(val_8 == 0)
        {
            goto label_8;
        }
        
        val_9 = 0;
        label_7:
        if((ContainsKey(key:  -1472372400)) == false)
        {
                return;
        }
        
        string val_5 = Item[-1472372400];
        string val_6 = ToString();
        bool val_8 = this.eventProgress.Rewarded;
        val_8 = val_8 >> 5;
        if(this.eventProgress != 0)
        {
                this.eventProgress.Rewarded = System.Boolean.Parse(value:  78753792);
            return;
        }
        
        this.UpdateRewardStatus();
    }
    private bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    private void ResetEventProgress()
    {
        this.eventProgress = new StarChampionshipEventProgress();
        typeof(StarChampionshipEventProgress).__il2cppRuntimeField_8 = R6 + 8;
    }
    private void UpdateRewardStatus()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1472372400, value:  8945664);
        this.UpdateToServer(data:  78753792);
    }
    private void UpdateToServer(System.Collections.Generic.Dictionary<string, object> data)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -413122304, data:  data);
    }
    private StarChampionshipTier GetCurrentTier()
    {
        bool val_4;
        var val_5;
        val_4 = static_value_021FABE1;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<StarChampionshipTier> val_1 = this.EventEcon;
        var val_4 = 50331648;
        val_5 = 0;
        do
        {
            val_4 = val_4 - 1;
            if(val_4 <= 1)
        {
                return;
        }
        
            System.Collections.Generic.List<StarChampionshipTier> val_2 = this.EventEcon;
            if(50331648 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_5 = 0;
            val_5 = val_5 + 201326592;
        }
        while(this.eventProgress.Stars < ((0 + 201326592) + 12 + 12));
        
        System.Collections.Generic.List<StarChampionshipTier> val_3 = (0 + 201326592) + 12 + 12.EventEcon;
        if(((0 + 201326592) + 12 + 12 + 12) <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = (0 + 201326592) + 12 + 12 + 8;
        val_6 = val_6 + (val_4 << 2);
        val_5 = mem[((0 + 201326592) + 12 + 12 + 8 + ((50331648 - 1)) << 2) + 16];
        val_5 = ((0 + 201326592) + 12 + 12 + 8 + ((50331648 - 1)) << 2) + 16;
    }
    private StarChampionshipTier GetNextTier()
    {
        TRVStarChampionshipEventHandler val_7;
        var val_8;
        object val_1 = new System.Object();
        StarChampionshipTier val_2 = this.GetCurrentTier();
        val_7 = this;
        if(val_1 != 0)
        {
                val_8 = val_1;
            typeof(TRVStarChampionshipEventHandler.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = val_7;
        }
        else
        {
                val_8 = 8;
            mem[8] = val_7;
            val_7 = mem[8];
        }
        
        if(mem[1152921512783898644] != false)
        {
                if(val_1 != 0)
        {
                return;
        }
        
            return;
        }
        
        System.Collections.Generic.List<StarChampionshipTier> val_3 = mem[1152921512783898644].EventEcon;
        System.Collections.Generic.List<StarChampionshipTier> val_4 = mem[1152921512783898644].EventEcon;
        System.Predicate<ZooTile> val_5 = new System.Predicate<ZooTile>(object:  364961792, method:  new IntPtr(3882057280));
        int val_7 = mem[1152921512783898644].FindIndex(match:  8040448);
        val_7 = val_7 + 1;
        if((mem[1152921512783898644] + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = mem[1152921512783898644] + 8;
        val_8 = val_8 + (val_7 << 2);
        val_8 = val_8 + 16;
    }
    private void ShowStarChampionshipProgressPopup()
    {
        float val_11;
        if(new TRVStarChampionshipPopupUIParam() != 0)
        {
                float val_2 = this.GetProgressBarValue(definedDivisions:  -1075612608);
            val_11 = 3882202080;
        }
        else
        {
                float val_3 = this.GetProgressBarValue(definedDivisions:  null);
            val_11 = 3882202080;
        }
        
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_10 = val_11;
        StarChampionshipTier val_4 = this.GetCurrentTier();
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_C = 1152921512784016351;
        string val_5 = Localization.Localize(key:  -412794752, defaultValue:  -412794944, useSingularKey:  false);
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_14 = "star_championship_popup_ln1";
        string val_6 = Localization.Localize(key:  -412794624, defaultValue:  -412794496, useSingularKey:  false);
        StarChampionshipTier val_7 = this.GetNextTier();
        int val_11 = this.eventProgress.Stars;
        val_11 = this - val_11;
        string val_8 = System.String.Format(format:  -412794624, arg0:  13152256);
        typeof(TRVStarChampionshipProgressUIParam).__il2cppRuntimeField_18 = "star_championship_popup_ln2";
        GameBehavior val_9 = App.getBehavior;
        0.ShowProgressPopup(param:  365387776);
    }
    private void ShowStarChampionshipRewardPopup()
    {
        float val_12;
        if(new TRVStarChampionshipPopupUIParam() != 0)
        {
                float val_2 = this.GetProgressBarValue(definedDivisions:  -1075676800);
            val_12 = 3882327680;
        }
        else
        {
                float val_3 = this.GetProgressBarValue(definedDivisions:  null);
            val_12 = 3882327680;
        }
        
        typeof(TRVStarChampionshipRewardUIParam).__il2cppRuntimeField_10 = val_12;
        StarChampionshipTier val_4 = this.GetCurrentTier();
        typeof(TRVStarChampionshipRewardUIParam).__il2cppRuntimeField_C = 1152921512784141951;
        string val_5 = Localization.Localize(key:  -412672960, defaultValue:  -412673120, useSingularKey:  false);
        string val_6 = System.String.Format(format:  -412672960, arg0:  13152256);
        string val_7 = Localization.Localize(key:  -428595648, defaultValue:  -428595520, useSingularKey:  false);
        string val_8 = -412672960(-412672960) + 1269544832 + -428595648(-428595648);
        typeof(TRVStarChampionshipRewardUIParam).__il2cppRuntimeField_14 = "star_championship_reward";
        StarChampionshipTier val_9 = this.GetCurrentTier();
        typeof(TRVStarChampionshipRewardUIParam).__il2cppRuntimeField_18 = this.eventProgress;
        typeof(TRVStarChampionshipRewardUIParam).__il2cppRuntimeField_1C = 0;
        GameBehavior val_10 = App.getBehavior;
        0.ShowRewardPopup(param:  365334528);
        if(this.onLevelCompleteRewardAnimFinished == 0)
        {
                return;
        }
    
    }
    private float GetProgressBarValue(float[] definedDivisions)
    {
        var val_8;
        var val_9;
        StarChampionshipTier val_1 = this.GetCurrentTier();
        val_8 = this;
        StarChampionshipTier val_2 = this.GetNextTier();
        if(35630053 != this)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<StarChampionshipTier> val_3 = this.EventEcon;
        var val_4 = R6 - 1;
        if(this <= val_4)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_4 << 2);
        val_8 = mem[(0 + ((R6 - 1)) << 2) + 16];
        val_8 = (0 + ((R6 - 1)) << 2) + 16;
        if(val_8 != 0)
        {
            goto label_7;
        }
        
        val_8 = 0;
        goto label_7;
        label_3:
        label_7:
        val_9 = R6;
        float val_9 = definedDivisions[val_8];
        float val_10 = (float)this - R6;
        val_10 = ((float)this.eventProgress.Stars - val_9) / val_10;
        float val_11 = definedDivisions[this];
        val_11 = val_11 - val_9;
        val_10 = val_9 + (val_10 * val_11);
        return UnityEngine.Mathf.Min(a:  val_10, b:  null);
    }
    public TRVStarChampionshipEventHandler()
    {
        this.eventProgress = new StarChampionshipEventProgress();
    }

}
