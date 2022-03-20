using UnityEngine;
public class WordHuntEvent : WGEventHandler
{
    // Fields
    public static WordHuntEvent Instance;
    public const string WORD_HUNT_EVENT_ID = "WordHunt";
    public const string EVENT_TRACKING_ID = "Word Hunt";
    public const string SHOW_WORD_FOUND_TOOLTIP = "ShowWordHuntTooltip";
    private GameLevel generatedLevel;
    protected System.Collections.Generic.List<string> eventRequiredWords;
    private System.Collections.Generic.List<object> <collectedWords>k__BackingField;
    private GameEventRewardType <myReward>k__BackingField;
    private int _rewardCoins;
    private System.Collections.Generic.Dictionary<string, object> eventProgressData;
    private System.Collections.Generic.Dictionary<string, object> eventEconData;
    public System.Collections.Generic.Dictionary<string, UnityEngine.Color32> tileColorLookup;
    private bool wordCollectedInDC;
    protected int cacheCurrLevelWordFound;
    protected System.Collections.Generic.List<string> currLevelEventWordsTotal;
    protected int cacheOverallWordFound;
    protected int cacheOverallWordTotal;
    
    // Properties
    public System.Collections.Generic.List<string> getCurrentWordList { get; }
    public System.Collections.Generic.List<object> collectedWords { get; set; }
    public GameEventRewardType myReward { get; set; }
    public int rewardCoins { get; }
    public bool eventComplete { get; }
    public GameEventV2 getEvent { get; }
    private static int LastProgressTimestampPref { get; set; }
    public int levelsBeforeGenerate { get; }
    public string eventTheme { get; }
    public string currentColor { get; }
    public int LastLevelCollectedWordAt { get; set; }
    public override int PointsCollected { get; }
    public override int PointsRequired { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public System.Collections.Generic.List<string> get_getCurrentWordList()
    {
    
    }
    public System.Collections.Generic.List<object> get_collectedWords()
    {
    
    }
    private void set_collectedWords(System.Collections.Generic.List<object> value)
    {
        this.<collectedWords>k__BackingField = value;
    }
    public GameEventRewardType get_myReward()
    {
    
    }
    private void set_myReward(GameEventRewardType value)
    {
        this.<myReward>k__BackingField = value;
    }
    public int get_rewardCoins()
    {
        return (int)this._rewardCoins;
    }
    public bool get_eventComplete()
    {
        if(this.eventRequiredWords != 0)
        {
                return false;
        }
        
        return false;
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1282450496, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1282450496, value:  value);
    }
    public int get_levelsBeforeGenerate()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.eventEconData, key:  -947525616, defaultValue:  13152256);
        this.eventEconData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    public string get_eventTheme()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.eventEconData, key:  -947409424, defaultValue:  1295406352);
        string val_2 = this.eventEconData.ToString();
    }
    public string get_currentColor()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.eventEconData, key:  1956389760, defaultValue:  -1729501776);
        string val_2 = this.eventEconData.ToString();
        if(this.eventEconData != 0)
        {
                return this.eventEconData.ToUpper();
        }
        
        return this.eventEconData.ToUpper();
    }
    public int get_LastLevelCollectedWordAt()
    {
        Player val_1 = App.Player;
        object val_2 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.eventProgressData, key:  -947164864, defaultValue:  13152256);
        this.eventProgressData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    public void set_LastLevelCollectedWordAt(int value)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.eventProgressData, key:  -947164864, newValue:  13152256);
    }
    public override int get_PointsCollected()
    {
        if((this.<collectedWords>k__BackingField) != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public override int get_PointsRequired()
    {
        if(this.eventRequiredWords != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public override bool get_IsEventValid()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public override void Init(GameEventV2 eventV2)
    {
        WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP = this;
        mem[1152921512250245864] = eventV2;
        if(eventV2.eventData != 0)
        {
                WordHuntEvent.__il2cppRuntimeField_static_fields = this;
            this.ParseEventData(eventData:  eventV2.eventData);
        }
        
        if(this.CheckNeedsNewData() != false)
        {
                this.GenerateNewData();
        }
        else
        {
                this.LoadPersistantData();
        }
        
        Player val_2 = App.Player;
        GameEcon val_3 = App.getGameEcon;
        if(0 == 983057)
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 == 2)
        {
                0 = this;
            this.CheckFtux();
        }
        
        }
        
        this.cacheOverallWordFound = 0;
        this.cacheOverallWordTotal = 0;
    }
    public override GameLevel getGameLevel(GameLevel refLevel)
    {
        GameLevel val_34;
        string val_35;
        var val_36;
        System.Func<System.String, System.Int32> val_38;
        GameLevel val_39;
        val_34 = 0;
        if(this.eventComplete == true)
        {
                return;
        }
        
        val_34 = 0;
        Player val_2 = App.Player;
        var val_34 = 0;
        val_34 = val_34 - this.LastLevelCollectedWordAt;
        if(val_34 <= this.levelsBeforeGenerate)
        {
                return;
        }
        
        val_34 = this.generatedLevel;
        if(val_34 != 0)
        {
                return;
        }
        
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -946375376, method:  new IntPtr(3348548256));
        System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Where<System.Object>(source:  this.eventRequiredWords, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Object>(source:  this.eventRequiredWords);
        if(this.eventRequiredWords == 0)
        {
                return;
        }
        
        Player val_8 = App.Player;
        if(0 > 99)
        {
                int val_9 = UnityEngine.Random.Range(min:  0, max:  mem[1179403871]);
            if(val_9 <= val_9)
        {
                var val_35 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_35 = val_35 + (val_9 << 2);
            val_35 = mem[(0 + (val_9) << 2) + 16];
            val_35 = (0 + (val_9) << 2) + 16;
        }
        else
        {
                val_36 = null;
            val_36 = null;
            val_38 = WordHuntEvent.<>c.<>9__50_1;
            if(val_38 == 0)
        {
                val_38 = null;
            val_38 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3348549280));
            WordHuntEvent.<>c.<>9__50_1 = val_38;
        }
        
            string val_11 = MoreLinq.MinBy<System.String, System.Int32>(source:  this.eventRequiredWords, selector:  7720960);
            val_35 = this.eventRequiredWords;
        }
        
        string val_12 = refLevel.word.Replace(oldValue:  -2100450224, newValue:  1098586544);
        System.Collections.Generic.List<T> val_13 = CUtils.BuildListFromString<System.String>(values:  refLevel.answers, split:  '|');
        if(refLevel.word.m_stringLength <= refLevel.answers)
        {
            goto label_27;
        }
        
        int val_15 = System.Math.Max(val1:  1, val2:  refLevel.word.m_stringLength + (~refLevel.answers));
        int val_16 = System.Math.Min(val1:  refLevel.answers.m_firstChar, val2:  18);
        GameBehavior val_17 = App.getBehavior;
        if(0 == 0)
        {
            goto label_34;
        }
        
        WordPets.WPTDataParser val_18 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_39 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
        GameLevel val_19 = BuildLevelContainingWordOfLength(word:  val_35, desiredLength:  refLevel.word.m_stringLength, desiredAnswers:  val_16, lengthFlexibility:  val_15);
        goto label_38;
        label_27:
        val_39 = this.generatedLevel;
        goto label_39;
        label_34:
        WordPets.WPTDataParser val_20 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(WADChapterManager.GetCurrentChapter() > 10)
        {
                0 = 1;
        }
        
        val_39 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
        GameLevel val_22 = BuildLevelContainingWordOfLength(word:  val_35, desiredLength:  refLevel.word.m_stringLength, desiredAnswers:  val_16, runWordRemoval:  true, lengthFlexibility:  val_15);
        label_38:
        this.generatedLevel = val_39;
        label_39:
        if(val_39 == 0)
        {
                if(new BuildLevelBasedOnWordParams() != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = 1;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = val_35;
        }
        else
        {
                mem[32] = val_35;
            mem[28] = 1;
        }
        
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = refLevel.answers.m_firstChar;
            twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2101084320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_27 = IsPlayingChallengingLevels;
            if(val_27 == true)
        {
                val_27 = 1;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1D = val_27;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_24 = val_27;
        }
        
        }
        
            GameBehavior val_28 = App.getBehavior;
            if(0 != 0)
        {
                WordPets.WPTDataParser val_29 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_39 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
            GameLevel val_30 = BuildLevelBasedOnWord(daWord:  val_35, maxWordCount:  refLevel.answers.m_firstChar, keepWord:  null);
        }
        else
        {
                WordPets.WPTDataParser val_31 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_39 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
            GameLevel val_32 = BuildLevelBasedOnWord(param:  384237568);
        }
        
            this.generatedLevel = val_39;
            if(val_39 == 0)
        {
                return;
        }
        
        }
        
        if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_34.Contains(value:  val_35)) != false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  -946399584);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_8;
        var val_9;
        val_8 = 1152921504901095424;
        val_9 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public WordHuntPopup MetaGameBehavior::ShowUGUIFlyOut<WordHuntPopup>().__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = R6.ShowUGUIMonolith<System.Object>(showNext:  false);
        }
    
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.SaveData();
        if(this.generatedLevel != 0)
        {
                this.generatedLevel = 0;
            this.generatedLevel = this.generatedLevel;
        }
    
    }
    public override void OnDailyChallengeInit()
    {
        this.wordCollectedInDC = false;
    }
    public override void OnGameSceneInit()
    {
        this.SaveData();
        this.OnGameSceneInit();
        WordRegion val_1 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -945886416, method:  new IntPtr(3349054832));
        0.addOnWordFoundAction(callback:  7401472);
        WordRegion val_3 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -945886416, method:  new IntPtr(3349055856));
        0.addOnExtraWordFoundAction(callback:  7401472);
        this.wordCollectedInDC = false;
        System.Collections.Generic.List<System.String> val_5 = this.GetEventWordsAvailableInLevel(dontIncludeDiscoveredWords:  true);
        this.currLevelEventWordsTotal = this;
        System.Collections.Generic.List<System.String> val_6 = this.GetEventWordsSolvedInLevel();
        this.cacheCurrLevelWordFound = this;
    }
    public override void OnGameSceneBegan()
    {
        this.CheckFtux();
    }
    public override void OnMenuLoaded()
    {
        this.SaveData();
        this.OnMenuLoaded();
    }
    public override string GetEventDisplayName()
    {
    
    }
    public override string GetGameButtonText()
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = System.String.Format(format:  -945325744, arg0:  13152256, arg1:  13152256);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_8;
        var val_9;
        val_8 = 1152921504901095424;
        val_9 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public WordHuntPopup MetaGameBehavior::ShowUGUIFlyOut<WordHuntPopup>().__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = R6.ShowUGUIMonolith<System.Object>(showNext:  false);
        }
    
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(WordHuntEvent).__il2cppRuntimeField_29C;
    }
    public override bool IsRewardReadyToCollect()
    {
        return this.eventComplete;
    }
    public override bool EventCompleted()
    {
        if(this.eventProgressData != 0)
        {
                return this.eventProgressData.ContainsKey(key:  -944865344);
        }
        
        return this.eventProgressData.ContainsKey(key:  -944865344);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        float val_3 = (float)this.<collectedWords>k__BackingField;
        val_3 = val_3 / (float)S0;
        TheLibraryMainScreen val_2 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void OnSubmitWordWithHints(string word)
    {
        goto typeof(WordHuntEvent).__il2cppRuntimeField_40C;
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        var val_8;
        System.Collections.Generic.List<System.Object> val_10;
        var val_11;
        string val_1 = this.EventWordContainedInWord(wordFound:  word);
        val_10 = this.<collectedWords>k__BackingField;
        if((val_10.Contains(item:  -944434592)) == true)
        {
                return;
        }
        
        val_10 = this.eventRequiredWords;
        if((val_10.Contains(item:  word)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  -944434592)) == true)
        {
                return;
        }
        
        }
        
        WordRegion val_5 = WordRegion.instance;
        val_10 = 0;
        val_11;
        List.Enumerator<T> val_6 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        val_10 = val_8;
        if((System.String.op_Equality(a:  val_8 + 12, b:  word)) == false)
        {
            goto label_12;
        }
        
        label_10:
        Dispose();
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67).__il2cppRuntimeField_14 = this;
            typeof(WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67).__il2cppRuntimeField_18 = eventButton;
        }
        else
        {
                mem[20] = this;
            mem[24] = eventButton;
        }
        
        typeof(WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67).__il2cppRuntimeField_10 = eventProgressUI;
    }
    public override int LastProgressTimestamp()
    {
        return WordHuntEvent.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        WordHuntEvent.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return true;
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        if(this.currLevelEventWordsTotal == 0)
        {
                return false;
        }
        
        if(layoutType > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        Player val_2 = App.Player;
        var val_4 = mem[1179403871];
        var val_3 = 0;
        val_3 = this.LastLevelCollectedWordAt - val_3;
        val_4 = val_4 >> 5;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  currentData, key:  -943717040, newValue:  8945664);
    }
    public override void AppendDailyChallengeCompleteData(ref System.Collections.Generic.Dictionary<string, object> data)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  data, key:  -943717040, newValue:  8945664);
        this.wordCollectedInDC = false;
    }
    public override void ResetDCProgress()
    {
        this.wordCollectedInDC = false;
    }
    public override UnityEngine.Sprite GetEventIcon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        EventPrefabsConfig val_2 = EventPrefabsConfig;
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) != 0)
        {
                return;
        }
    
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        string val_24;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_26;
        var val_28;
        var val_29;
        var val_30;
        GameEventRewardType val_31;
        string val_32;
        val_26 = eventData;
        val_28 = 1152921510392296080;
        if((val_26.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = val_26.Item[-1554533760];
        val_29 = 1152921504685600768;
        val_30 = this;
        this.eventEconData = 0;
        if((0.ContainsKey(key:  -1470584448)) == false)
        {
            goto label_19;
        }
        
        string val_4 = this.eventEconData.Item[-1470584448];
        val_29 = 1;
        if((0.ContainsKey(key:  -1987496016)) == false)
        {
            goto label_16;
        }
        
        string val_6 = 0.Item[-1987496016];
        if((0 < 1) || ((System.Int32.TryParse(s:  null, result: out  int val_7 = -943228440)) == false))
        {
            goto label_16;
        }
        
        string val_9 = 0.Item[-1987496016];
        val_30 = this.eventEconData;
        val_28 = 1152921510392296080;
        bool val_11 = System.Int32.TryParse(s:  null, result: out  this._rewardCoins);
        this.<myReward>k__BackingField = 1;
        goto label_19;
        label_16:
        if((0.ContainsKey(key:  -1318762160)) == false)
        {
            goto label_25;
        }
        
        string val_13 = 0.Item[-1318762160];
        if((0 < 1) || ((System.Int32.TryParse(s:  null, result: out  int val_14 = -943228440)) == false))
        {
            goto label_25;
        }
        
        val_31 = 3;
        goto label_26;
        label_25:
        if((0.ContainsKey(key:  -1318762064)) == false)
        {
            goto label_32;
        }
        
        string val_17 = 0.Item[-1318762064];
        if((0 < 1) || ((System.Int32.TryParse(s:  null, result: out  int val_18 = -943228440)) == false))
        {
            goto label_32;
        }
        
        val_31 = 4;
        label_26:
        this.<myReward>k__BackingField = val_31;
        goto label_33;
        label_32:
        this.<myReward>k__BackingField = 1;
        this._rewardCoins = 250;
        label_33:
        val_30 = this.eventEconData;
        val_28 = 1152921510392296080;
        label_19:
        if((val_30.ContainsKey(key:  -943252784)) == false)
        {
                return;
        }
        
        string val_21 = 1179403647.Item[-943252784];
        this.eventRequiredWords.Clear();
        val_26 = 0;
        List.Enumerator<T> val_22 = GetEnumerator();
        val_29 = 1152921510046813136;
        label_49:
        if(MoveNext() == false)
        {
            goto label_44;
        }
        
        val_32 = 0;
        if(val_24 != 0)
        {
                if(val_24 != null)
        {
            
        }
        else
        {
                val_32 = val_24;
        }
        
        }
        
        this.eventRequiredWords.Add(item:  val_32);
        goto label_49;
        label_44:
        Dispose();
        if(this.eventRequiredWords != 0)
        {
                return;
        }
        
        string val_25 = 1179403647.Item[-943252784];
        UnityEngine.Debug.LogError(message:  1179403647);
    }
    private void LoadPersistantData()
    {
        string val_1 = CPlayerPrefs.GetString(key:  -943112016);
        object val_2 = MiniJSON.Json.Deserialize(json:  -943112016);
        if("wordHuntData" != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        this.eventProgressData = 0;
        label_9:
        string val_3 = 0.Item[-1584759760];
        this.<collectedWords>k__BackingField = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921512253693672] = null;
        return;
        label_5:
        this.eventProgressData = "wordHuntData";
        goto label_9;
    }
    private void GenerateNewData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(key:  -1584759760, value:  80883712);
        Player val_3 = App.Player;
        Add(key:  -947164864, value:  13152256);
        string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -943112016, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    private bool CheckNeedsNewData()
    {
        if((CPlayerPrefs.HasKey(key:  -943112016)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -943112016);
        object val_3 = MiniJSON.Json.Deserialize(json:  -943112016);
        if("wordHuntData" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "wordHuntData" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("wordHuntData".Count == 0)
        {
                return true;
        }
        
        if(("wordHuntData".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "wordHuntData".Item[1624646480];
        string val_7 = this.wordCollectedInDC.ToString();
        return System.String.op_Inequality(a:  null, b:  this.wordCollectedInDC);
    }
    public void CollectReward()
    {
        int val_3;
        if((this.<myReward>k__BackingField) == 4)
        {
            goto label_1;
        }
        
        if((this.<myReward>k__BackingField) == 3)
        {
            goto label_2;
        }
        
        if((this.<myReward>k__BackingField) != 1)
        {
            goto label_3;
        }
        
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -942755512);
        0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  "Word Hunt Complete", subSource:  0, externalParams:  0, doTrack:  true);
        goto label_21;
        label_1:
        GameBehavior val_4 = App.getBehavior;
        mem[64] = "WordHunt";
        goto label_21;
        label_2:
        GameBehavior val_6 = App.getBehavior;
        mem[12] = "WordHunt";
        goto label_21;
        label_3:
        string val_8 = -942771712(-942771712) + 321617920;
        UnityEngine.Debug.LogError(message:  -942771712);
        label_21:
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.eventProgressData, key:  -944865344, newValue:  8945664);
        this.SaveData();
    }
    private void SaveData()
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  this.eventProgressData);
        CPlayerPrefs.SetString(key:  -943112016, val:  this.eventProgressData);
    }
    private void OnValidExtraWordSubmission(string word)
    {
        goto typeof(WordHuntEvent).__il2cppRuntimeField_40C;
    }
    private void OnValidWordSubmission(string word)
    {
        goto typeof(WordHuntEvent).__il2cppRuntimeField_40C;
    }
    protected virtual void OnValidWordSubmission(string word, bool isExtraWord)
    {
        var val_11;
        var val_13;
        System.Collections.Generic.List<System.Object> val_14;
        System.Collections.Generic.List<System.Object> val_15;
        var val_16;
        var val_17;
        val_13 = isExtraWord;
        string val_1 = this.EventWordContainedInWord(wordFound:  word);
        val_14 = this.<collectedWords>k__BackingField;
        if((val_14.Contains(item:  -942234032)) == true)
        {
                return;
        }
        
        val_14 = this.eventRequiredWords;
        if((val_14.Contains(item:  word)) != false)
        {
                val_15 = this.<collectedWords>k__BackingField;
            val_16 = word;
            val_17 = 1152921510271993840;
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  -942234032)) == true)
        {
                return;
        }
        
            val_15 = this.<collectedWords>k__BackingField;
            val_16 = this;
            val_17 = 1152921510271993840;
        }
        
        val_15.Add(item:  -942234032);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.eventProgressData, key:  -1584759760, newValue:  this.<collectedWords>k__BackingField);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge != false)
        {
                this.wordCollectedInDC = true;
        }
        else
        {
                Player val_7 = App.Player;
            val_14 = 0;
            this.LastLevelCollectedWordAt = 0;
        }
        
        if(val_13 != false)
        {
                return;
        }
        
        WordRegion val_8 = WordRegion.instance;
        val_14 = 0;
        val_13;
        List.Enumerator<T> val_9 = GetEnumerator();
        label_25:
        if(MoveNext() == false)
        {
            goto label_23;
        }
        
        val_14 = val_11;
        if((System.String.op_Equality(a:  val_11 + 12, b:  word)) == false)
        {
            goto label_25;
        }
        
        label_23:
        Dispose();
    }
    protected virtual void HighlightEventExtraWordFound(string word)
    {
    
    }
    protected virtual void PostValidWordSubmission()
    {
        if(this.eventComplete != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -950707424);
    }
    protected string EventWordContainedInWord(string wordFound)
    {
        object val_1 = new System.Object();
        typeof(WordHuntEvent.<>c__DisplayClass87_0).__il2cppRuntimeField_8 = wordFound;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  337272832, method:  new IntPtr(3353090320));
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.eventRequiredWords, predicate:  7720960);
    }
    protected virtual void ColorAllVisibleTiles(LineWord wordLine, string eventWord)
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if(((val_3 + 36) == 0) || ((eventWord.Contains(value:  val_3 + 32)) == false))
        {
            goto label_10;
        }
        
        string val_5 = this.currentColor;
        string val_6 = eventWord.ToUpper();
        UnityEngine.Color32 val_7 = this.tileColorLookup.Item[-941715376];
        val_3.SetNewBackgroundAndColor(bgColor:  new UnityEngine.Color32() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
        goto label_10;
        label_3:
        Dispose();
    }
    protected virtual void DecorateSelectedTiles(LineWord wordLine, string eventWord)
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if((eventWord.Contains(value:  val_3 + 32)) == false)
        {
            goto label_7;
        }
        
        val_3.ShowDynamicImage(sprite:  -941574704);
        goto label_7;
        label_3:
        Dispose();
    }
    private void CheckFtux()
    {
        if((this.eventProgressData.ContainsKey(key:  -1463122928)) == true)
        {
                return;
        }
        
        this.eventProgressData.Add(key:  -1463122928, value:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public System.Collections.Generic.List<string> GetEventWordsSolvedInLevel()
    {
        object val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((this.<collectedWords>k__BackingField.Contains(item:  val_4)) == false)
        {
            goto label_6;
        }
        
        Add(item:  val_4);
        goto label_6;
        label_2:
        Dispose();
    }
    public System.Collections.Generic.List<string> GetEventWordsAvailableInLevel(bool dontIncludeDiscoveredWords = False)
    {
        var val_5;
        var val_11;
        object val_20;
        var val_26;
        System.Collections.Generic.List<System.String> val_27;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(dontIncludeDiscoveredWords == false)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<WGEventButtonV2> val_2 = new System.Collections.Generic.List<WGEventButtonV2>(capacity:  this.<collectedWords>k__BackingField);
        List.Enumerator<T> val_3 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_5 != 0)
        {
                if(val_5 != null)
        {
                val_26 = 0;
        }
        
        }
        else
        {
                val_26 = 0;
        }
        
        Add(item:  0);
        goto label_8;
        label_1:
        val_27 = this.eventRequiredWords;
        goto label_9;
        label_4:
        Dispose();
        System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Except<System.Object>(first:  val_27, second:  80883712);
        val_27 = val_27;
        label_9:
        WordRegion val_7 = WordRegion.instance;
        List.Enumerator<T> val_8 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        object val_10 = new System.Object();
        typeof(WordHuntEvent.<>c__DisplayClass92_0).__il2cppRuntimeField_8 = val_11;
        if(dontIncludeDiscoveredWords != false)
        {
                if((val_11 + 32) != 0)
        {
            goto label_21;
        }
        
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Except<System.Object>(first:  val_27, second:  80883712);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_13 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  337326080, method:  new IntPtr(3353763984));
        object val_14 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_27, predicate:  7720960);
        if((System.String.IsNullOrEmpty(value:  val_27)) == true)
        {
            goto label_21;
        }
        
        Add(item:  val_27);
        goto label_21;
        label_14:
        Dispose();
        WordRegion val_16 = WordRegion.instance;
        List.Enumerator<T> val_17 = GetEnumerator();
        label_33:
        if(MoveNext() == false)
        {
            goto label_26;
        }
        
        object val_19 = new System.Object();
        typeof(WordHuntEvent.<>c__DisplayClass92_1).__il2cppRuntimeField_8 = val_20;
        if(dontIncludeDiscoveredWords != false)
        {
                if((this.<collectedWords>k__BackingField.Contains(item:  val_20)) == true)
        {
            goto label_33;
        }
        
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_22 = System.Linq.Enumerable.Except<System.Object>(first:  val_27, second:  80883712);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_23 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  337379328, method:  new IntPtr(3353765008));
        object val_24 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_27, predicate:  7720960);
        if((System.String.IsNullOrEmpty(value:  val_27)) == true)
        {
            goto label_33;
        }
        
        Add(item:  val_27);
        goto label_33;
        label_26:
        Dispose();
    }
    public bool IsLevelContainEventWord()
    {
        if(this.currLevelEventWordsTotal == 0)
        {
                return false;
        }
        
        if(R1 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    protected UnityEngine.UI.Image CreateIconObject(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 size, UnityEngine.Transform parentTransform)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  -940952688);
        UnityEngine.Transform val_2 = transform;
        SetParent(p:  parentTransform);
        UnityEngine.Transform val_3 = transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = transform;
        position = new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z};
        UnityEngine.Transform val_6 = transform;
        SetAsLastSibling();
        object val_7 = AddComponent<System.Object>();
        if(null != 0)
        {
                sprite = -940928592;
            preserveAspect = true;
        }
        else
        {
                sprite = -940928592;
            preserveAspect = true;
        }
        
        UnityEngine.RectTransform val_8 = rectTransform;
        sizeDelta = new UnityEngine.Vector2() {x = size.x, y = size.y};
    }
    public void SetRequiredWordsAsCurrentExtraWords()
    {
        GameLevel val_1 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  true);
        System.Collections.Generic.List<T> val_2 = CUtils.BuildListFromString<System.String>(values:  52, split:  '|');
        this.eventRequiredWords = 52;
    }
    public void HackCollectSmallestWord()
    {
        var val_17;
        System.Func<System.String, System.Int32> val_19;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        if(this.eventComplete != false)
        {
                return;
        }
        
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -940671824, method:  new IntPtr(3354246896));
        System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<System.Object>(source:  this.eventRequiredWords, predicate:  7720960);
        val_17 = null;
        val_17 = null;
        val_19 = WordHuntEvent.<>c.<>9__96_1;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3354247920));
            WordHuntEvent.<>c.<>9__96_1 = val_19;
        }
        
        string val_7 = MoreLinq.MinBy<System.String, System.Int32>(source:  this.eventRequiredWords, selector:  7720960);
        this.<collectedWords>k__BackingField.Add(item:  this.eventRequiredWords);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.eventProgressData, key:  -1584759760, newValue:  this.<collectedWords>k__BackingField);
        this.cacheOverallWordFound = this.eventProgressData;
        this.cacheOverallWordTotal = this.eventProgressData;
        Player val_8 = App.Player;
        this.LastLevelCollectedWordAt = 0;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_10 = PlayingChallenge;
        if(val_10 == true)
        {
                val_10 = true;
            this.wordCollectedInDC = val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) != false)
        {
                object val_13 = UnityEngine.Object.FindObjectOfType<System.Object>();
            BuildUI();
            return;
        }
        
        if(this.eventComplete != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_16 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
    
    }
    public WordHuntEvent()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -940559248);
        }
        else
        {
                Add(item:  -940559248);
        }
        
        Add(item:  -940559168);
        if(null != 0)
        {
                Add(item:  -940559088);
        }
        else
        {
                Add(item:  -940559088);
        }
        
        Add(item:  -940559008);
        if(null != 0)
        {
                Add(item:  -940558928);
        }
        else
        {
                Add(item:  -940558928);
        }
        
        Add(item:  -940558848);
        if(null != 0)
        {
                Add(item:  -940558768);
        }
        else
        {
                Add(item:  -940558768);
        }
        
        Add(item:  -940558688);
        if(null != 0)
        {
                Add(item:  -940558608);
        }
        else
        {
                Add(item:  -940558608);
        }
        
        Add(item:  -940558528);
        if(null != 0)
        {
                Add(item:  -940558432);
        }
        else
        {
                Add(item:  -940558432);
        }
        
        Add(item:  -940558352);
        this.eventRequiredWords = null;
        this.eventProgressData = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.eventEconData = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color32> val_4 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color32>();
        UnityEngine.Color32 val_5 = new UnityEngine.Color32(r:  255, g:  79, b:  67, a:  225);
        Add(key:  -1729501776, value:  new UnityEngine.Color32() {r = val_5.r, g = val_5.r, b = val_5.r, a = val_5.r});
        UnityEngine.Color32 val_6 = new UnityEngine.Color32(r:  255, g:  136, b:  192, a:  225);
        Add(key:  -940556224, value:  new UnityEngine.Color32() {r = val_6.r, g = val_6.r, b = val_6.r, a = val_6.r});
        UnityEngine.Color32 val_7 = new UnityEngine.Color32(r:  107, g:  249, b:  100, a:  225);
        Add(key:  -940556144, value:  new UnityEngine.Color32() {r = val_7.r, g = val_7.r, b = val_7.r, a = val_7.r});
        UnityEngine.Color32 val_8 = new UnityEngine.Color32(r:  247, g:  220, b:  42, a:  225);
        Add(key:  -940556064, value:  new UnityEngine.Color32() {r = val_8.r, g = val_8.r, b = val_8.r, a = val_8.r});
        UnityEngine.Color32 val_9 = new UnityEngine.Color32(r:  125, g:  234, b:  8, a:  225);
        Add(key:  -940555984, value:  new UnityEngine.Color32() {r = val_9.r, g = val_9.r, b = val_9.r, a = val_9.r});
        UnityEngine.Color32 val_10 = new UnityEngine.Color32(r:  106, g:  191, b:  255, a:  225);
        Add(key:  -940555888, value:  new UnityEngine.Color32() {r = val_10.r, g = val_10.r, b = val_10.r, a = val_10.r});
        UnityEngine.Color32 val_11 = new UnityEngine.Color32(r:  255, g:  147, b:  21, a:  225);
        Add(key:  -940555808, value:  new UnityEngine.Color32() {r = val_11.r, g = val_11.r, b = val_11.r, a = val_11.r});
        this.tileColorLookup = null;
    }
    private bool <getGameLevel>b__50_0(string x)
    {
        bool val_1 = this.<collectedWords>k__BackingField.Contains(item:  x);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    private bool <HackCollectSmallestWord>b__96_0(string x)
    {
        bool val_1 = this.<collectedWords>k__BackingField.Contains(item:  x);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }

}
