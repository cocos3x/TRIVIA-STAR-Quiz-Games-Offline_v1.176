using UnityEngine;
public class TRVBigQuizEvent : WGEventHandler
{
    // Fields
    private static TRVBigQuizEvent _Instance;
    public const string BIG_HINT_ID = "BigQuiz";
    public const string EVENT_TRACKING_ID = "Big Quiz Event";
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    private int _startLevel;
    private int _levelsNeeded;
    private int _reward;
    private bool rewarded;
    
    // Properties
    public static TRVBigQuizEvent Instance { get; }
    public GameEventV2 getEvent { get; }
    public int eventProgress { get; }
    public int startLevel { get; }
    public int levelsNeeded { get; }
    public int reward { get; }
    private static int LastProgressTimestampPref { get; set; }
    public override bool IsEventHidden { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static TRVBigQuizEvent get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public int get_eventProgress()
    {
        Player val_1 = App.Player;
        var val_2 = 0;
        val_2 = val_2 - this._startLevel;
        return (int)val_2;
    }
    public int get_startLevel()
    {
        return (int)this._startLevel;
    }
    public int get_levelsNeeded()
    {
        return (int)this._levelsNeeded;
    }
    public int get_reward()
    {
        return (int)this._reward;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -431520032, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -431520032, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512765517848] = eventV2;
        this.ParseEventData(eventData:  eventV2.eventData);
        TRVBigQuizEvent.EVENT_TRACKING_ID = this;
        if((this.CheckNeedsNewData(eventData:  eventV2.eventData)) != false)
        {
                this.GenerateNewData();
            return;
        }
        
        this.LoadPersistantData();
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -1648577792)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1648577792);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1648577792);
        if("BigQuiz" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "BigQuiz" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("BigQuiz".Count == 0)
        {
                return true;
        }
        
        if(("BigQuiz".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "BigQuiz".Item[1624646480];
        string val_7 = ToString();
        return System.String.op_Inequality(a:  null, b:  -431139392);
    }
    private void GenerateNewData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        Player val_2 = App.Player;
        Add(key:  -431047344, value:  13152256);
        Add(key:  -1605526400, value:  8945664);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1648577792, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    private void LoadPersistantData()
    {
        string val_1 = CPlayerPrefs.GetString(key:  -1648577792);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1648577792);
        if("BigQuiz" != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        this.myEventData = 0;
        label_9:
        if((0.ContainsKey(key:  -431047344)) == false)
        {
                return;
        }
        
        string val_4 = this.myEventData.Item[-431047344];
        bool val_6 = System.Int32.TryParse(s:  null, result: out  this._startLevel);
        return;
        label_5:
        this.myEventData = "BigQuiz";
        goto label_9;
    }
    private void SaveData()
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -431047344, newValue:  13152256);
        string val_1 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -1648577792, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    public override void OnGameSceneBegan()
    {
        ulong val_9;
        ulong val_11;
        var val_18 = null;
        string val_1 = System.DateTime.MinValue.ToString();
        string val_2 = CPlayerPrefs.GetString(key:  -430694880, defaultValue:  -430681816);
        if((System.DateTime.TryParse(s:  -430694880, result: out  new System.DateTime() {dateData = 1152921512766099760})) != false)
        {
                System.DateTime val_4 = Date;
            System.DateTime val_5 = DateTimeCheat.UtcNow;
            System.DateTime val_8 = Date;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_11}, d2:  new System.DateTime() {dateData = val_9})) == true)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_15 = ShowUGUIMonolith<System.Object>(showNext:  false);
        System.DateTime val_16 = DateTimeCheat.UtcNow;
        string val_17 = val_11.ToString();
        CPlayerPrefs.SetString(key:  -430694880, val:  -430681816);
        CPlayerPrefs.Save();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 1152921504892043264;
        val_3 = 6299676 + 29326111;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(levelsProgressed < 1)
        {
                return;
        }
        
        if(App.game != 19)
        {
                return;
        }
        
        goto typeof(TRVBigQuizEvent).__il2cppRuntimeField_1FC;
    }
    public override void OnCategoryComplete()
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.rewarded == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool EventCompleted()
    {
        return (bool)this.rewarded;
    }
    public override bool get_IsEventHidden()
    {
        return (bool)this.rewarded;
    }
    public override bool get_IsEventValid()
    {
        var val_8;
        var val_9;
        val_8 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  1800251696)) != true)
        {
                GameBehavior val_4 = App.getBehavior;
            val_8 = 0;
            val_9 = 0;
            string val_5 = val_8.GetCurrentLanguage();
            if((System.String.op_Equality(a:  null, b:  -2101987568)) == false)
        {
                return (bool)val_9;
        }
        
        }
        
        val_9 = this.rewarded >> 5;
        return (bool)val_9;
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -430021680, defaultValue:  -430021776, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -430021680, defaultValue:  -430021776, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -430021680, defaultValue:  -430021776, useSingularKey:  false);
        int val_3 = UnityEngine.Mathf.Min(a:  this._levelsNeeded, b:  this.eventProgress);
        string val_4 = System.String.Format(format:  -1128214576, arg0:  -430021680, arg1:  13152256, arg2:  13152256);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void UpdateProgress()
    {
        TRVBigQuizEvent.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_8;
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        string val_3 = this.eventProgress.ToString();
        string val_4 = System.String.Format(format:  1629069648, arg0:  -429332492, arg1:  13152256);
        if(this.eventProgress != 0)
        {
                val_8 = (float)this.eventProgress / (float)this._levelsNeeded;
        }
        else
        {
                val_8 = 0f;
        }
        
        if(loader != 0)
        {
                return;
        }
    
    }
    public override bool IsRewardReadyToCollect()
    {
        Player val_1 = App.Player;
        int val_2 = this._startLevel;
        val_2 = this._levelsNeeded + val_2;
        if(0 >= val_2)
        {
                0 = 1;
        }
        
        return true;
    }
    public void OnCollect()
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  this._reward, source:  -429116368, subsource:  null);
        Player val_2 = App.Player;
        string val_3 = this._reward.ToString();
        0.TrackNonCoinReward(source:  -429116272, subSource:  null, rewardType:  -1668821072, rewardAmount:  this._reward, additionalParams:  0);
        this.rewarded = true;
        this.SaveData();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1472372400, value:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -429092160, data:  78753792);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_18;
        int val_19;
        int val_20;
        val_18 = 35626055;
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        val_18 = "economy";
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventData.Item[-1554533760];
        if((0.ContainsKey(key:  -429000064)) == false)
        {
            goto label_7;
        }
        
        string val_5 = 0.Item[-429000064];
        val_19 = this._reward;
        if((System.Int32.TryParse(s:  null, result: out  val_19)) == false)
        {
            goto label_10;
        }
        
        goto label_11;
        label_7:
        val_19 = this._reward;
        label_10:
        mem2[0] = 100;
        label_11:
        if((0.ContainsKey(key:  -1163066496)) == false)
        {
            goto label_13;
        }
        
        string val_9 = 0.Item[-1163066496];
        val_20 = this._levelsNeeded;
        if((System.Int32.TryParse(s:  null, result: out  val_20)) == false)
        {
            goto label_16;
        }
        
        goto label_17;
        label_13:
        val_20 = this._levelsNeeded;
        label_16:
        mem2[0] = 100;
        label_17:
        val_18 = "progress";
        if((eventData.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        object val_13 = eventData.Item[-1545439648];
        if(eventData == 0)
        {
                return;
        }
        
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                eventData = 0;
        }
        
        val_18 = "rewarded";
        if((eventData.ContainsKey(key:  -1472372400)) == false)
        {
                return;
        }
        
        string val_15 = eventData.Item[-1472372400];
        bool val_17 = System.Boolean.TryParse(value:  null, result: out  this.rewarded);
    }
    public TRVBigQuizEvent()
    {
        this._startLevel = 2147483648;
    }

}
