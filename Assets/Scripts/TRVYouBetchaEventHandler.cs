using UnityEngine;
public class TRVYouBetchaEventHandler : WGEventHandler
{
    // Fields
    private static TRVYouBetchaEventHandler _Instance;
    public const string YOU_BETCHA_ID = "YouBetcha";
    public const string EVENT_TRACKING_ID = "You Betcha Event";
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    private bool hasPromptedEvent;
    private bool <hasActiveBet>k__BackingField;
    private int <betAmount>k__BackingField;
    private float <rewardMulti>k__BackingField;
    private int <consecPopupDismissal>k__BackingField;
    private int <lastLevelBetAt>k__BackingField;
    public int lastLevelAwardedAt;
    
    // Properties
    public static TRVYouBetchaEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public bool hasActiveBet { get; set; }
    public int betAmount { get; set; }
    public float rewardMulti { get; set; }
    public int consecPopupDismissal { get; set; }
    public int betReward { get; }
    public int lastLevelBetAt { get; set; }
    public bool shouldShowPopup { get; }
    private static int LastProgressTimestampPref { get; set; }
    
    // Methods
    public static TRVYouBetchaEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public bool get_hasActiveBet()
    {
        return (bool)this.<hasActiveBet>k__BackingField;
    }
    private void set_hasActiveBet(bool value)
    {
        this.<hasActiveBet>k__BackingField = value;
    }
    public int get_betAmount()
    {
        return (int)this.<betAmount>k__BackingField;
    }
    private void set_betAmount(int value)
    {
        this.<betAmount>k__BackingField = value;
    }
    public float get_rewardMulti()
    {
        return (float)S0;
    }
    private void set_rewardMulti(float value)
    {
        this.<rewardMulti>k__BackingField = ;
    }
    public int get_consecPopupDismissal()
    {
        return (int)this.<consecPopupDismissal>k__BackingField;
    }
    private void set_consecPopupDismissal(int value)
    {
        this.<consecPopupDismissal>k__BackingField = value;
    }
    public int get_betReward()
    {
        float val_3 = (float)this.<betAmount>k__BackingField;
        val_3 = val_3 * 1.2f;
        float val_4 = 1f;
        val_4 = (this.<rewardMulti>k__BackingField) + val_4;
        val_4 = val_4 * ((float)this.<betAmount>k__BackingField);
        return UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_3), b:  UnityEngine.Mathf.FloorToInt(f:  val_4));
    }
    public int get_lastLevelBetAt()
    {
        return (int)this.<lastLevelBetAt>k__BackingField;
    }
    private void set_lastLevelBetAt(int value)
    {
        this.<lastLevelBetAt>k__BackingField = value;
    }
    public bool get_shouldShowPopup()
    {
        Player val_1 = App.Player;
        var val_2 = 0;
        val_2 = val_2 - (this.<lastLevelBetAt>k__BackingField);
        if(val_2 < (this.<consecPopupDismissal>k__BackingField))
        {
                0 = 1;
        }
        
        return true;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -593617824, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -593617824, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512760739736] = eventV2;
        this.ParseEventData(eventData:  eventV2.eventData);
        TRVYouBetchaEventHandler.EVENT_TRACKING_ID = this;
        if((this.CheckNeedsNewData(eventData:  eventV2.eventData)) != false)
        {
                this.GenerateNewData();
            return;
        }
        
        this.LoadPersistantData();
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -1266461488)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1266461488);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1266461488);
        if("YouBetcha" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "YouBetcha" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("YouBetcha".Count == 0)
        {
                return true;
        }
        
        if(("YouBetcha".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "YouBetcha".Item[1624646480];
        string val_7 = ToString();
        return System.String.op_Inequality(a:  null, b:  -435917504);
    }
    private void GenerateNewData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        Add(key:  -435825456, value:  8945664);
        Player val_2 = App.Player;
        Add(key:  -435825360, value:  13152256);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1266461488, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    private void LoadPersistantData()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
        var val_7;
        var val_8;
        string val_1 = CPlayerPrefs.GetString(key:  -1266461488);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1266461488);
        val_6 = 0;
        if("YouBetcha" != 0)
        {
                val_6 = 0;
            if(null != null)
        {
                "YouBetcha" = 0;
        }
        
            val_6 = "YouBetcha";
        }
        
        this.myEventData = val_6;
        object val_3 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -435825456, defaultValue:  8945664);
        val_7 = null;
        val_8 = val_6;
        val_8.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.hasPromptedEvent = true;
        Player val_4 = App.Player;
        object val_5 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -435825360, defaultValue:  13152256);
        val_7 = null;
        val_8 = this.myEventData;
        val_8.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.<lastLevelBetAt>k__BackingField = null;
    }
    private void SaveData()
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -435825456, newValue:  8945664);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -435825360, newValue:  13152256);
        string val_1 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -1266461488, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_18 = 35630184;
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
        if((0.ContainsKey(key:  -435452416)) != false)
        {
                string val_5 = 0.Item[-435452416];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = -435440204);
            if(val_7 == true)
        {
                val_7 = 100;
            this.<betAmount>k__BackingField = 100;
        }
        
        }
        
        this.<betAmount>k__BackingField = UnityEngine.Mathf.Max(a:  this.<betAmount>k__BackingField, b:  50);
        if((0.ContainsKey(key:  -435452336)) != false)
        {
                string val_10 = 0.Item[-435452336];
            bool val_12 = System.Single.TryParse(s:  null, result: out  float val_11 = -1.649401E+23f);
            if(val_12 == true)
        {
                val_12 = 1056964608;
            this.<rewardMulti>k__BackingField = 0.5f;
        }
        
        }
        
        float val_13 = UnityEngine.Mathf.Max(a:  null, b:  null);
        this.<rewardMulti>k__BackingField = this.<rewardMulti>k__BackingField;
        val_18 = "cpu_dis";
        if((0.ContainsKey(key:  -435452256)) == false)
        {
                return;
        }
        
        string val_15 = 0.Item[-435452256];
        bool val_17 = System.Int32.TryParse(s:  null, result: out  int val_16 = -435440204);
        if(val_17 == true)
        {
                val_17 = 100;
            this.<consecPopupDismissal>k__BackingField = 100;
        }
    
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -435335968, defaultValue:  -435336064, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -435335968, defaultValue:  -435336064, useSingularKey:  false);
    }
    public override void OnCategorySelected(TRVCategorySelectionInfo category)
    {
        this.<hasActiveBet>k__BackingField = false;
    }
    public override void OnGameSceneBegan()
    {
        if(this.hasPromptedEvent == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        mem2[0] = 1;
        R4.SaveData();
    }
    public override void OnLevelComplete(int levelsProgressed)
    {
        this.OnLevelComplete(levelsProgressed:  levelsProgressed);
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
        TRVYouBetchaEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -435335968, defaultValue:  -435336064, useSingularKey:  false);
    }
    public override WGWindow showPreQuestionWindow(TRVQuizProgress progress)
    {
        if(this.shouldShowPopup == false)
        {
                return;
        }
        
        System.Collections.Generic.List<TRVQuestionHistory> val_2 = progress.countedAnswerData;
        if(progress.quizLength != (progress.correctAnswerRequirement - 1))
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        object val_6 = 0.GetComponent<System.Object>();
    }
    public bool TryPlaceBet()
    {
        int val_8;
        var val_9;
        string val_10;
        bool val_11;
        Player val_1 = App.Player;
        var val_2 = 0 + 60;
        val_11 = 0;
        decimal val_3 = System.Decimal.op_Implicit(value:  -434064260);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256}, d2:  new System.Decimal())) == true)
        {
                return val_11;
        }
        
        Player val_5 = App.Player;
        val_9 = 0;
        int val_6 = 0 - (this.<betAmount>k__BackingField);
        decimal val_7 = System.Decimal.op_Implicit(value:  -434064260);
        val_11 = true;
        val_10 = "you_betcha";
        val_9.AddCredits(amount:  new System.Decimal() {mid = val_8}, source:  val_10, subSource:  0, externalParams:  0, doTrack:  true);
        this.<hasActiveBet>k__BackingField = val_11;
        Player val_9 = App.Player;
        this.<lastLevelBetAt>k__BackingField = 0;
        this.SaveData();
        return val_11;
    }
    public bool TryRewardBet()
    {
        int val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 44) != this.lastLevelAwardedAt)
        {
                this.lastLevelAwardedAt = this.<hasActiveBet>k__BackingField;
        }
        
        if(this.lastLevelAwardedAt != true)
        {
                return false;
        }
        
        this.<hasActiveBet>k__BackingField = false;
        Player val_2 = App.Player;
        int val_3 = this.betReward;
        decimal val_4 = System.Decimal.op_Implicit(value:  -433952256);
        0.AddCredits(amount:  new System.Decimal() {mid = val_5}, source:  "you_betcha", subSource:  0, externalParams:  0, doTrack:  true);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.lastLevelAwardedAt = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 44;
        return false;
    }
    public void ResetEventProgress()
    {
        Player val_1 = App.Player;
        this.<lastLevelBetAt>k__BackingField = 0;
        this.SaveData();
    }
    public TRVYouBetchaEventHandler()
    {
    
    }

}
