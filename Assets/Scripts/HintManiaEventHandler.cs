using UnityEngine;
public class HintManiaEventHandler : WGEventHandler
{
    // Fields
    private static HintManiaEventHandler _Instance;
    public const string HINT_MANIA_ID = "HintMania";
    private GameEventRewardType _currentRewardType;
    private int _hintRewardOdds;
    private System.Collections.Generic.Dictionary<string, object> rewardProbabilities;
    private System.Collections.Generic.Dictionary<string, object> rewardValues;
    
    // Properties
    public static HintManiaEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public GameEventRewardType currentRewardType { get; }
    public int hintRewardOdds { get; }
    private static int LastProgressTimestampPref { get; set; }
    private int LastEventPopupShown { get; set; }
    public override bool IsEventHidden { get; }
    
    // Methods
    public static HintManiaEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public GameEventRewardType get_currentRewardType()
    {
    
    }
    public int get_hintRewardOdds()
    {
        return (int)this._hintRewardOdds;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1211943120, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1211943120, value:  value);
    }
    private int get_LastEventPopupShown()
    {
        return CPlayerPrefs.GetInt(key:  -1211719008, defaultValue:  0);
    }
    private void set_LastEventPopupShown(int value)
    {
        CPlayerPrefs.SetInt(key:  -1211719008, val:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_3 = 35641715;
        mem[1152921511985318872] = eventV2;
        this.ParseEventData(eventData:  eventV2.eventData);
        HintManiaEventHandler.HINT_MANIA_ID = this;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        goto typeof(HintManiaEventHandler).__il2cppRuntimeField_134;
    }
    public override void OnGameSceneBegan()
    {
        if(this.LastEventPopupShown == (R6 + 48))
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        LastEventPopupShown = 0;
        CPlayerPrefs.Save();
    }
    public override void OnGameSceneInit()
    {
    
    }
    public override void OnDailyChallengeInit()
    {
    
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1211029392, defaultValue:  -1211029488, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -1211029392, defaultValue:  -1211029488, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1211029392, defaultValue:  -1211029488, useSingularKey:  false);
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
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return true;
    }
    public override bool EventCompleted()
    {
        bool val_1 = this.IsEventValid;
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public override bool get_IsEventHidden()
    {
        bool val_1 = this.IsEventValid;
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public override void OnAnyHintUsed(bool free)
    {
        if(free == true)
        {
                return;
        }
        
        this.RollForReward();
    }
    public override int LastProgressTimestamp()
    {
        return HintManiaEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        HintManiaEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        if(this._currentRewardType != 0)
        {
                this._currentRewardType = 1;
        }
        
        return true;
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        string val_2 = Localization.Localize(key:  -1209671968, defaultValue:  -1209671872, useSingularKey:  false);
        string val_3 = System.String.Format(format:  -1209671968, arg0:  13152256);
        if(loader != 0)
        {
                return;
        }
    
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        35641724 = "economy";
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventData.Item[-1554533760];
        if(eventData == 0)
        {
                return;
        }
        
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                eventData = 0;
        }
    
    }
    private void CheckDisplayRewardAvailable()
    {
    
    }
    private void RollForReward()
    {
        var val_29;
        if((UnityEngine.Random.Range(min:  0, max:  100)) > this._hintRewardOdds)
        {
                return;
        }
        
        RandomSet val_2 = new RandomSet();
        val_29 = 1152921510392296080;
        if((this.rewardProbabilities.ContainsKey(key:  -1987496016)) != false)
        {
                object val_4 = this.rewardProbabilities.Item[-1987496016];
            string val_5 = this.rewardProbabilities.ToString();
            add(item:  1, weight:  (float)System.Int32.Parse(s:  this.rewardProbabilities));
        }
        
        if((this.rewardProbabilities.ContainsKey(key:  -1812169936)) != false)
        {
                object val_8 = this.rewardProbabilities.Item[-1812169936];
            string val_9 = this.rewardProbabilities.ToString();
            add(item:  2, weight:  (float)System.Int32.Parse(s:  this.rewardProbabilities));
        }
        
        if((this.rewardProbabilities.ContainsKey(key:  -1318762064)) != false)
        {
                object val_12 = this.rewardProbabilities.Item[-1318762064];
            string val_13 = this.rewardProbabilities.ToString();
            add(item:  4, weight:  (float)System.Int32.Parse(s:  this.rewardProbabilities));
        }
        
        if((this.rewardProbabilities.ContainsKey(key:  -1318762160)) != false)
        {
                object val_16 = this.rewardProbabilities.Item[-1318762160];
            string val_17 = this.rewardProbabilities.ToString();
            add(item:  3, weight:  (float)System.Int32.Parse(s:  this.rewardProbabilities));
        }
        
        this._currentRewardType = roll(unweighted:  false);
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2060922896) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = 1152921511987491440;
        object val_25 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_28 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.CheckShowButton();
    }
    public void CollectReward()
    {
        if(this._currentRewardType <= 4)
        {
                var val_1 = 14433960 + (14433960 + (this._currentRewardType) << 2);
            if(this._currentRewardType == 4)
        {
                14433960 + (this._currentRewardType) << 2 = (14433960 + (this._currentRewardType) << 2) & (this << (14433960 + (this._currentRewardType) << 2));
            14433960 + (this._currentRewardType) << 2 = (14433960 + (this._currentRewardType) << 2) & (this >> (14433960 + (this._currentRewardType) << 2));
            14433960 + (this._currentRewardType) << 2 = (14433960 + (this._currentRewardType) << 2) & ((R8) << 14433960);
            mem2[0] = (((14433960 + (this._currentRewardType) << 2 & (this) << 14433960 + (this._currentRewardType) << 2) & ((int)this) >> (14433960 + (this._currentRewardType) << 2 & (this) << 14433960 + (this._currentRew + (((14433960 + (this._currentRewardType) << 2 & (this) << 14433960 + (this._currentRewardType) << 2) & ((int)this) >> (14433960 + (this._currentRewardType) << 2 & (this) << 14433960 + (this._currentRew;
        }
        
            UnityEngine.Debug.LogError(message:  -1209140240);
        }
        
        this._currentRewardType = 0;
        this.SaveCurrentReward();
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2060922896) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_17 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_20 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.CheckShowButton();
    }
    public int GetRewardValue(GameEventRewardType rewardType)
    {
        var val_9 = 0;
        if(rewardType != 2)
        {
                if(rewardType != 1)
        {
                return (int)val_9;
        }
        
            object val_1 = this.rewardValues.Item[-1987496016];
            string val_2 = this.rewardValues.ToString();
            bool val_4 = System.Int32.TryParse(s:  this.rewardValues, result: out  int val_3 = -1208999724);
            if(val_9 == 0)
        {
                val_9 = 50;
        }
        
            return (int)val_9;
        }
        
        object val_5 = this.rewardValues.Item[-1812169936];
        string val_6 = this.rewardValues.ToString();
        bool val_8 = System.Int32.TryParse(s:  this.rewardValues, result: out  int val_7 = -1208999724);
        if(val_9 == 0)
        {
                val_9 = 250;
        }
        
        return (int)val_9;
    }
    private void SaveCurrentReward()
    {
        CPlayerPrefs.SetInt(key:  -1208883312, val:  this._currentRewardType);
        CPlayerPrefs.Save();
    }
    public HintManiaEventHandler()
    {
        this._hintRewardOdds = 4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496016, value:  13152256);
        Add(key:  -1812169936, value:  13152256);
        Add(key:  -1318762160, value:  13152256);
        Add(key:  -1318762064, value:  13152256);
        this.rewardProbabilities = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496016, value:  13152256);
        Add(key:  -1812169936, value:  13152256);
        Add(key:  -1318762160, value:  13152256);
        Add(key:  -1318762064, value:  13152256);
        this.rewardValues = null;
    }

}
