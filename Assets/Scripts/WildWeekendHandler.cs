using UnityEngine;
public class WildWeekendHandler : WGEventHandler
{
    // Fields
    public static WildWeekendHandler Instance;
    public const string WILD_WEEKEND_EVENT_ID = "WildWordWeekend";
    public const string WILD_WEEKEND_EVENT_TRACKING_ID = "Wild Weekend Complete";
    private const int econ_default_levels = 50;
    private const int econ_default_award = 200;
    
    // Properties
    public static int TotalLevelQuantity { get; }
    private static int SavedLevelQuantity { get; set; }
    private int SavedAwardAmount { get; set; }
    private bool SavedHasSeenFirstTime { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    public virtual bool IsAvailable { get; }
    
    // Methods
    public static int get_TotalLevelQuantity()
    {
        return WildWeekendHandler.SavedLevelQuantity;
    }
    private static int get_SavedLevelQuantity()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1283122784, defaultValue:  0);
    }
    private static void set_SavedLevelQuantity(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1283122784, value:  value);
    }
    private int get_SavedAwardAmount()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1282898688, defaultValue:  0);
    }
    private void set_SavedAwardAmount(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1282898688, value:  value);
    }
    private bool get_SavedHasSeenFirstTime()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1282674592, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_SavedHasSeenFirstTime(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1282674592, value:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1282450496, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1282450496, value:  value);
    }
    public virtual bool get_IsAvailable()
    {
        if(true == 0)
        {
                return true;
        }
        
        bool val_1 = this.HasCollected();
        if(val_1 == true)
        {
                return true;
        }
        
        if(val_1 == false)
        {
                return true;
        }
        
        val_1 = val_1 + 32;
        double val_2 = val_1.ToOADate();
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        double val_4 = ???.ToOADate();
        if(DateTimeCheat.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void GainLevelComplete(int levelsToGain = 1)
    {
        if(this == 0)
        {
                return;
        }
        
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        35625702 = static_value_00280080;
        int val_4 = System.Math.Max(val1:  35625702 + levelsToGain, val2:  0);
        Player val_5 = App.Player;
        2621448.Save(writePrefs:  true);
        if(this.GetLevelsComplete() >= WildWeekendHandler.SavedLevelQuantity)
        {
            goto typeof(WildWeekendHandler).__il2cppRuntimeField_414;
        }
    
    }
    public bool CheckComplete()
    {
        if(this == 0)
        {
                return false;
        }
        
        if(this.GetLevelsComplete() >= WildWeekendHandler.SavedLevelQuantity)
        {
                0 = 1;
        }
        
        return true;
    }
    public int GetLevelsComplete()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return (int)static_value_00280080;
        }
        
        return (int)static_value_00280080;
    }
    public void SetHasSeenFirstTime()
    {
        bool val_1 = this.SavedHasSeenFirstTime;
        if(val_1 == true)
        {
                return;
        }
        
        val_1.SavedHasSeenFirstTime = true;
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void SetSavedCollected(bool collected)
    {
        Player val_1 = App.Player;
        2621448.WWWEventCollected = collected;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public bool HasCollected()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 2621448.WWWEventCollected;
        }
        
        return 2621448.WWWEventCollected;
    }
    public int GetLevelsTotal()
    {
        return WildWeekendHandler.SavedLevelQuantity;
    }
    public System.DateTime GetEndDate()
    {
        this = R1 + 8 + 32;
        return new System.DateTime() {dateData = R1 + 8 + 32};
    }
    public GameEventRewardType getRewardType()
    {
        var val_16;
        string val_1 = this.Item[-1554533760];
        val_16 = 1;
        if((0.ContainsKey(key:  -1281218384)) == false)
        {
                return;
        }
        
        string val_3 = 0.Item[-1281218384];
        val_16 = 1;
        if((0.ContainsKey(key:  -1987496016)) != false)
        {
                string val_5 = 0.Item[-1987496016];
            if(0 >= 1)
        {
                if((System.Int32.TryParse(s:  null, result: out  int val_6 = -1281206340)) == true)
        {
                return;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1318762064)) != false)
        {
                string val_9 = 0.Item[-1318762064];
            if(0 >= 1)
        {
                if((System.Int32.TryParse(s:  null, result: out  int val_10 = -1281206340)) == true)
        {
                return;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1318762160)) == false)
        {
                return;
        }
        
        string val_13 = 0.Item[-1318762160];
        if(0 < 1)
        {
                return;
        }
        
        if((System.Int32.TryParse(s:  null, result: out  int val_14 = -1281206340)) == false)
        {
                3 = 1;
        }
    
    }
    public int getRewardValue()
    {
        var val_10;
        var val_11;
        val_10 = 0;
        GameEventRewardType val_1 = this.getRewardType();
        if(this != 1)
        {
                return (int)val_10;
        }
        
        string val_2 = this.Item[-1554533760];
        val_11 = "rew_v2";
        if((0.ContainsKey(key:  -1281218384)) != false)
        {
                string val_4 = 0.Item[-1281218384];
            val_11 = 1;
            if((0.ContainsKey(key:  -1987496016)) != false)
        {
                string val_6 = 0.Item[-1987496016];
            bool val_8 = System.Int32.TryParse(s:  null, result: out  int val_7 = -1281094340);
            val_10 = 0;
            if(val_10 >= 1)
        {
                if(val_8 == true)
        {
                return (int)val_10;
        }
        
        }
        
        }
        
        }
        
        val_10 = val_8.SavedAwardAmount;
        return (int)val_10;
    }
    private void InitWildWeekend(string json, bool clearProgress)
    {
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_19 = 0;
        if((System.String.IsNullOrEmpty(value:  json)) == false)
        {
                "{}" = json;
        }
        
        object val_2 = MiniJSON.Json.Deserialize(json:  "{}");
        val_20 = 1152921504685600768;
        if("{}" != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_19 = 0;
        }
        
        }
        
        if(clearProgress == false)
        {
            goto label_3;
        }
        
        Player val_3 = App.Player;
        Player val_4 = App.Player;
        Player val_5 = App.Player;
        2621448.WWWEventCollected = false;
        Player val_6 = App.Player;
        2621448.Save(writePrefs:  true);
        this.SavedHasSeenFirstTime = false;
        WildWeekendHandler.LastProgressTimestampPref = 0;
        if(val_19 != 0)
        {
            goto label_19;
        }
        
        goto label_18;
        label_3:
        if("{}" != null)
        {
                val_19 = "{}";
        }
        
        label_18:
        val_19 = 0;
        label_19:
        string val_7 = val_19.Item[-1554533760];
        val_21 = 0;
        val_22 = "levels";
        val_23 = 50;
        if((val_21.ContainsKey(key:  -1630882544)) != false)
        {
                string val_9 = val_21.Item[-1630882544];
            if((System.String.IsNullOrEmpty(value:  null)) != true)
        {
                val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_11 = val_21.Item[-1630882544];
            val_20 = val_21;
            val_25 = null;
            val_20.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(1179403647 > 0)
        {
                val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_12 = val_21.Item[-1630882544];
            val_26 = val_21;
            val_25 = null;
            val_26.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_27 = 1179403647;
        }
        
        }
        
        }
        
        WildWeekendHandler.SavedLevelQuantity = 1179403647;
        val_28 = 200;
        if((val_21.ContainsKey(key:  -1280990208)) != false)
        {
                string val_14 = val_21.Item[-1280990208];
            if((System.String.IsNullOrEmpty(value:  null)) != true)
        {
                val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_16 = val_21.Item[-1280990208];
            val_20 = val_21;
            val_22 = 1152921504619999232;
            val_25 = null;
            val_20.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(1179403647 > 0)
        {
                val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_17 = val_21.Item[-1280990208];
            val_25 = null;
            val_21 = val_21;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_29 = 1179403647;
        }
        
        }
        
        }
        
        this.SavedAwardAmount = 1179403647;
        bool val_18 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public bool ShowNewWeekendInLobby()
    {
        SceneType val_1 = SceneDictator.GetActiveSceneType();
        if(0 != 1)
        {
                return false;
        }
        
        if(this == 0)
        {
                return false;
        }
        
        bool val_2 = this.SavedHasSeenFirstTime;
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    protected virtual void SetupAndShowPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        int val_3 = GetLevelsComplete();
        bool val_5 = WildWeekendHandler.SavedLevelQuantity.HasCollected();
        GameEventRewardType val_6 = this.getRewardType();
        System.Action val_7 = new System.Action(object:  -1280737008, method:  typeof(WildWeekendHandler).__il2cppRuntimeField_248);
        System.Action val_8 = new System.Action(object:  -1280737008, method:  typeof(WildWeekendHandler).__il2cppRuntimeField_250);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_10 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void RefreshWeekendInfo(GameEventV2 eventV2)
    {
        mem[1152921511916165080] = eventV2;
        if(eventV2 == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1280644912)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1280640704(-1280640704) + eventV2;
            UnityEngine.Debug.LogError(message:  -1280640704);
            return;
        }
        
        WildWeekendHandler.econ_default_award = this;
        Player val_4 = App.Player;
        if(0 != 0)
        {
                eventV2.serverTimestamp - static_value_0028007C = 1;
        }
        
        this.InitWildWeekend(json:  256, clearProgress:  true);
    }
    public override void Init(GameEventV2 eventV2)
    {
        this.RefreshWeekendInfo(eventV2:  eventV2);
    }
    public override void OnGameSceneBegan()
    {
        if(this.SavedHasSeenFirstTime == true)
        {
                return;
        }
        
        if(R4 == 0)
        {
                return;
        }
        
        goto R4 + 1044;
    }
    public override void OnMenuLoaded()
    {
    
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        var val_1 = 29492791;
        val_1 = 6133000 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 16;
        goto typeof(WildWeekendHandler).__il2cppRuntimeField_414;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                17 = 18;
        }
        
        var val_3 = 29492459;
        val_3 = 6133332 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 18;
        goto typeof(WildWeekendHandler).__il2cppRuntimeField_414;
    }
    public override void OnEventEnded()
    {
        this.OnEventEnded();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshWeekendInfo(eventV2:  eventV2);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -1279719808, defaultValue:  -1279719920, useSingularKey:  false);
        string val_3 = GetLevelsComplete().ToString();
        string val_5 = WildWeekendHandler.SavedLevelQuantity.ToString();
        string val_6 = System.String.Format(format:  -1694782544, arg0:  -1279719808, arg1:  -1279707708, arg2:  -1279707708);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1279607568, defaultValue:  -1279607680, useSingularKey:  false);
    }
    public override void HackAddLevels(int levelsHacked)
    {
        this.GainLevelComplete(levelsToGain:  levelsHacked);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.GainLevelComplete(levelsToGain:  levelsProgressed);
    }
    public override void HandleCollectAction()
    {
        this.SetSavedCollected(collected:  true);
    }
    public override void HandleAdvertisedSeen()
    {
        this.SetHasSeenFirstTime();
    }
    public override string GetGameButtonText()
    {
        Player val_1 = App.Player;
        int val_2 = WildWeekendHandler.SavedLevelQuantity;
        string val_3 = 13152256 + 1115175264 + 13152256;
    }
    public override bool IsChallengeCompleted()
    {
        return this.HasCollected();
    }
    public override bool IsEventEndedOffline()
    {
        var val_2;
        System.DateTime val_1 = System.Convert.ToDateTime(value:  new System.DateTime() {dateData = 1152921511917970072});
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        int val_7 = val_2.CompareTo(value:  new System.DateTime());
        val_7 = val_7 >> 31;
        return (bool)val_7;
    }
    public override int LastProgressTimestamp()
    {
        return WildWeekendHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        WildWeekendHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        return this.CheckComplete();
    }
    public override bool EventCompleted()
    {
        return this.HasCollected();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_2 = this.GetLevelsComplete().ToString();
        string val_4 = WildWeekendHandler.SavedLevelQuantity.ToString();
        string val_5 = System.String.Format(format:  -1322846112, arg0:  -1278246364, arg1:  -1278246364);
        float val_9 = (float)GetLevelsComplete();
        val_9 = val_9 / (float)WildWeekendHandler.SavedLevelQuantity;
        TheLibraryMainScreen val_8 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public string GetEventRemainingTime()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511918651280}, d2:  new System.DateTime() {dateData = 1152921511918663328});
        int val_8 = UnityEngine.Mathf.Max(a:  val_5.Days, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_10 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_12 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_14 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_15 = System.String.Format(format:  -1515309312, args:  472754880);
    }
    public WildWeekendHandler()
    {
    
    }

}
