using UnityEngine;
public class SpinKingEventHandler : WGEventHandler
{
    // Fields
    public const string SPINKING_EVENT_ID = "SpinKing";
    public const string SHOW_RANK_UP_FLYOUT = "ShowRankupFlyout";
    public const string SPIN_KING_EVENT_LAST_LEVEL = "spin_king_last_level";
    private static SpinKingEventHandler <Instance>k__BackingField;
    private const string LAST_POPUP_SHOW_LEVEL_KEY = "last_popup_show_level";
    private const string EARNED_SPIN_PIECE_KEY = "spin_earned_pc";
    private const string LAST_PROGRESS_STAMP_KEY = "spin_last_progress";
    public bool isGotSpinInLevel;
    private int span;
    public bool QAHACK_FreeSpins;
    private SpinKingEventHandler.SpinKingEcon <econ>k__BackingField;
    private int _bankedSpins;
    
    // Properties
    public static SpinKingEventHandler Instance { get; set; }
    public static bool EarnedSpinPiece { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    public SpinKingEventHandler.SpinKingEcon econ { get; set; }
    public int BankedSpins { get; }
    public bool PlayingChallenge { get; }
    public bool isBankedSpinsMax { get; }
    public bool isSpinsMax { get; }
    public bool isActive { get; }
    private int LastLevel { get; set; }
    private int lastPopupShowLevel { get; set; }
    
    // Methods
    public static SpinKingEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(SpinKingEventHandler value)
    {
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY = value;
    }
    public static bool get_EarnedSpinPiece()
    {
        return PlayerPrefsX.GetBool(name:  -199398416, defaultValue:  false);
    }
    public static void set_EarnedSpinPiece(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -199398416, value:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -199174320, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -199174320, value:  value);
    }
    public SpinKingEventHandler.SpinKingEcon get_econ()
    {
    
    }
    private void set_econ(SpinKingEventHandler.SpinKingEcon value)
    {
        this.<econ>k__BackingField = value;
    }
    public int get_BankedSpins()
    {
        return (int)this._bankedSpins;
    }
    public bool get_PlayingChallenge()
    {
        int val_6;
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        val_7 = 0;
        if(PlayingChallenge == true)
        {
                return true;
        }
        
        val_7 = 0;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return true;
        }
        
        val_6 = 35627674;
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
                return true;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY != null)
        {
                return true;
        }
        
        val_7 = 0;
        if(SceneDictator.IsInGameScene() == false)
        {
                return true;
        }
        
        val_6 = this._bankedSpins;
        if((this.span + val_6) >= (this.<econ>k__BackingField.EventMaxSpins))
        {
                return true;
        }
        
        if(this._bankedSpins < (this.<econ>k__BackingField.MaxBankedSpins))
        {
                val_7 = 1;
        }
        
        return true;
    }
    public bool get_isBankedSpinsMax()
    {
        if(this._bankedSpins >= (this.<econ>k__BackingField.MaxBankedSpins))
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_isSpinsMax()
    {
        if((this.span + this._bankedSpins) >= (this.<econ>k__BackingField.EventMaxSpins))
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_isActive()
    {
        if(this.IsEventExpired() == true)
        {
                return (bool)0;
        }
        
        0 = 1152921512998576513;
        return (bool)0;
    }
    private int get_LastLevel()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -198117056, defaultValue:  0);
    }
    private void set_LastLevel(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -198117056, value:  value);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private int get_lastPopupShowLevel()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -197892944)) != false)
        {
                return UnityEngine.PlayerPrefs.GetInt(key:  -197892944);
        }
        
        Player val_2 = App.Player;
        int val_6 = this.<econ>k__BackingField.LevelsShowPopup;
        val_6 = (0 - 10) - val_6;
        UnityEngine.PlayerPrefs.SetInt(key:  -197892944, value:  val_6);
        Player val_4 = App.Player;
        int val_7 = this.<econ>k__BackingField.LevelsShowPopup;
        val_7 = (0 - 10) - val_7;
        return (int)val_7;
    }
    private void set_lastPopupShowLevel(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -197892944, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_3 = 19719695;
        mem[1152921512999161320] = eventV2;
        val_3 = 15925124 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY = this;
        object val_1 = new System.Object();
        this.<econ>k__BackingField = null;
        this.ParseEventData(eventData:  eventV2.eventData);
        SpinKingOutCome val_2 = SpinKingSlotMachine.CreateSpinOutCome();
    }
    public override void OnWordRegionLoaded()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static SpinKingEventUIController MonoSingleton<SpinKingEventUIController>::get_Instance().__il2cppRuntimeField_30 = 1;
        UpdateSpinCollectionUI();
        this.isGotSpinInLevel = false;
    }
    public override string GetGameButtonText()
    {
        return this._bankedSpins.ToString();
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -197298944, defaultValue:  -197299040, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        if(this != 0)
        {
                return;
        }
        
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(this._bankedSpins >= (this.<econ>k__BackingField.MaxBankedSpins))
        {
                0 = 1;
        }
        
        loader.SetupCollectedSpins(amount:  1629069648, isMax:  true);
        35644759 = this.<econ>k__BackingField;
        float val_5 = 100f;
        val_5 = ((float)this._bankedSpins / ((float)this.<econ>k__BackingField.MaxBankedSpins)) * val_5;
        string val_4 = System.String.Format(format:  2124591920, arg0:  13152256);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -197298944, defaultValue:  -197299040, useSingularKey:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_3 = this;
        if(val_3 != 0)
        {
                val_3 = this;
        }
        else
        {
                WGSpinKingSlotPopup val_1 = this.ShowSlotPopup();
            this.SetPlayFromLevelComplete(level_complete:  false);
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3 = this;
        if(val_3 != 0)
        {
                val_3 = this;
        }
        else
        {
                WGSpinKingSlotPopup val_1 = this.ShowSlotPopup();
            this.SetPlayFromLevelComplete(level_complete:  false);
        }
    
    }
    public override bool EventCompleted()
    {
        if(this.span >= (this.<econ>k__BackingField.EventMaxSpins))
        {
                0 = 1;
        }
        
        return true;
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(SpinKingEventHandler).__il2cppRuntimeField_29C;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        if(this._bankedSpins != (this.<econ>k__BackingField.MaxBankedSpins))
        {
                return;
        }
        
        Player val_1 = App.Player;
        this.<econ>k__BackingField = this.lastPopupShowLevel;
        int val_5 = this.<econ>k__BackingField.LevelsShowPopup;
        val_5 = val_5 + (this.<econ>k__BackingField);
        if(0 < val_5)
        {
                return;
        }
        
        WGSpinKingSlotPopup val_3 = val_5.ShowSlotPopup();
        val_5.SetPlayFromLevelComplete(level_complete:  true);
        Player val_4 = App.Player;
        this.lastPopupShowLevel = 0;
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        if(CategoryPacksManager.IsPlaying == false)
        {
                return this.ShouldShowInDailyChallenge(dailyChallengeState:  dailyChallengeState);
        }
        
        return false;
    }
    public override int GetMovingWordIndex()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -197524064)) == false)
        {
                return this.GetMovingWordIndex();
        }
        
        if(this.PlayingChallenge == false)
        {
                return this.GetMovingWordIndex();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static SpinKingEventUIController MonoSingleton<SpinKingEventUIController>::get_Instance()) != 0)
        {
                return spinWordIndex;
        }
        
        return spinWordIndex;
    }
    public override void OnValidWordSubmitted(string word)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = this;
        val_9 = word;
        val_10 = 35644764;
        if(this.IsEventExpired() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DestroySpinPiece();
        }
        else
        {
                if(R5.PlayingChallenge == false)
        {
                return;
        }
        
            val_10 = 1152921504901095424;
            val_11 = 1152921512999257504;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SpinKingEventUIController MonoSingleton<SpinKingEventUIController>::get_Instance().__il2cppRuntimeField_20) == 0)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnWordSubmitted(submitWord:  R4);
        }
    
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_16 = this;
        val_17 = hintedCell;
        val_18 = 35644765;
        if(this.IsEventExpired() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DestroySpinPiece();
        }
        else
        {
                if(R5.PlayingChallenge != false)
        {
                val_20 = 1152921504901095424;
            val_19 = 1152921512999257504;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SpinKingEventUIController MonoSingleton<SpinKingEventUIController>::get_Instance().__il2cppRuntimeField_20) != 0)
        {
                UnityEngine.Transform val_6 = R4.transform;
            UnityEngine.Vector3 val_7 = position;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_9 = public static SpinKingEventUIController MonoSingleton<SpinKingEventUIController>::get_Instance().__il2cppRuntimeField_20.transform;
            UnityEngine.Vector3 val_10 = position;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShiftSpinPiece();
        }
        
        }
        
        }
        
            var val_13 = FP - 24;
        }
    
    }
    public override int LastProgressTimestamp()
    {
        return SpinKingEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        SpinKingEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public System.TimeSpan GetRemainingTime()
    {
        ulong val_2;
        System.TimeSpan val_8;
        var val_9;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = R1 + 8 + 32}, t2:  new System.DateTime() {dateData = val_2})) != false)
        {
                System.DateTime val_6 = DateTimeCheat.UtcNow;
            System.TimeSpan val_7 = this.Subtract(value:  new System.DateTime() {dateData = (R1 + 8) + 32});
            return new System.TimeSpan() {_ticks = val_8};
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = System.TimeSpan.Zero;
        this = val_8;
        return new System.TimeSpan() {_ticks = val_8};
    }
    public void HandleSpinPieceCollected()
    {
        this.isGotSpinInLevel = true;
        int val_1 = this._bankedSpins + 1;
        this._bankedSpins = val_1;
        if(val_1 > (this.<econ>k__BackingField.MaxBankedSpins))
        {
                this._bankedSpins = this.<econ>k__BackingField.MaxBankedSpins;
        }
        
        this.SendSpinsAmountToServer();
        goto typeof(SpinKingEventHandler).__il2cppRuntimeField_17C;
    }
    public float GetPercentProgress()
    {
        float val_1 = (float)this.<econ>k__BackingField.MaxBankedSpins;
        val_1 = (float)this._bankedSpins / val_1;
        return (float)val_1;
    }
    public WGSpinKingSlotPopup ShowSlotPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return ShowUGUIMonolith<System.Object>(showNext:  true);
        }
        
        return ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    public void Spin()
    {
        int val_2 = this._bankedSpins;
        if(val_2 < 1)
        {
                return;
        }
        
        val_2 = val_2 - 1;
        this._bankedSpins = val_2;
        this.span = this.span + 1;
        this.SendSpinsAmountToServer();
        goto typeof(SpinKingEventHandler).__il2cppRuntimeField_17C;
    }
    public bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this._bankedSpins});
        }
        
        return true;
    }
    public bool IsSolvingInProgress()
    {
        int val_2 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_2 = this.LastLevel - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public void SaveEventProgress()
    {
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
        }
        
        int val_5 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_5.LastLevel = val_5;
    }
    public void SpinPieceAnimationComplete()
    {
        goto typeof(SpinKingEventHandler).__il2cppRuntimeField_17C;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        float val_26;
        var val_27;
        var val_28;
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        val_26 = 1152921510392296080;
        if((eventData.ContainsKey(key:  -1554533760)) != false)
        {
                object val_3 = eventData.Item[-1554533760];
            if((0.ContainsKey(key:  -194610192)) != false)
        {
                string val_5 = 0.Item[-194610192];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  this.<econ>k__BackingField.InitialBaseSpins);
            val_26 = val_26;
        }
        
            if((0.ContainsKey(key:  -194606016)) != false)
        {
                string val_9 = 0.Item[-194606016];
            bool val_11 = System.Int32.TryParse(s:  null, result: out  this.<econ>k__BackingField.MaxBankedSpins);
        }
        
            val_27 = "ems";
            if((0.ContainsKey(key:  -194601840)) != false)
        {
                string val_13 = 0.Item[-194601840];
            bool val_15 = System.Int32.TryParse(s:  null, result: out  this.<econ>k__BackingField.EventMaxSpins);
        }
        
        }
        
        val_28 = "progress";
        if((eventData.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        object val_17 = eventData.Item[-1545439648];
        val_27 = 1;
        if((0.ContainsKey(key:  -1987367328)) != false)
        {
                string val_19 = 0.Item[-1987367328];
            bool val_21 = System.Int32.TryParse(s:  null, result: out  this._bankedSpins);
            val_28 = "span";
            if((0.ContainsKey(key:  -194597664)) == false)
        {
                return;
        }
        
            string val_23 = 0.Item[-194597664];
            bool val_25 = System.Int32.TryParse(s:  null, result: out  this.span);
            return;
        }
        
        this.span = 0;
        this._bankedSpins = this.<econ>k__BackingField.InitialBaseSpins;
        this.SendSpinsAmountToServer();
    }
    private void DeletePlayerPref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private string GetPlatformId()
    {
    
    }
    public void SendSpinsAmountToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        Add(key:  -1987367328, value:  13152256);
        Add(key:  -194597664, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  19169280, data:  78753792);
    }
    public SpinKingEventHandler()
    {
    
    }

}
