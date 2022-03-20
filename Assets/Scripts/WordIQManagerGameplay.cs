using UnityEngine;
public class WordIQManagerGameplay : MonoSingleton<WordIQManagerGameplay>
{
    // Fields
    private const string pref_iq_input = "iq_input";
    private const string pref_iq_streak = "iq_streak";
    private const string pref_iq_highest_streak = "iq_highest_streak";
    private const string pref_iq_input_words = "iq_input_words";
    private const string pref_iq_has_seen_new = "iq_has_seen_new";
    private int _TotalInput;
    private int _CurrentStreak;
    private int _HighestConsecutiveValidInput;
    private System.Collections.Generic.List<string> _ValidWordsInput;
    private int _LevelFirstSawNew;
    private IQGains lastLevelGains;
    
    // Methods
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -919274592, method:  new IntPtr(3375667680));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public void AddValidInput(string validWord, bool isExtra)
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        int val_6 = this._TotalInput;
        val_6 = val_6 + 1;
        this._TotalInput = val_6;
        this._ValidWordsInput.Add(item:  validWord);
        int val_7 = this._CurrentStreak;
        val_7 = val_7 + 1;
        this._CurrentStreak = val_7;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance();
        if((IsNewWord(word:  validWord)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static WordIQManagerUI MonoSingleton<WordIQManagerUI>::get_Instance();
            NewWordFound(word:  validWord, isExtra:  isExtra);
        }
        
        this.SaveGameState();
    }
    public void AddInvalidInput()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        var val_3 = R4 + 12;
        val_3 = val_3 + 1;
        mem2[0] = val_3;
        if((R4 + 16) > (R4 + 20))
        {
                mem2[0] = R4 + 16;
        }
        
        mem2[0] = 0;
        R4.SaveGameState();
    }
    public void ResetLevelProgress()
    {
        this._TotalInput = 0;
        this._CurrentStreak = 0;
        this._HighestConsecutiveValidInput = 0;
        this._ValidWordsInput.Clear();
        this.SaveGameState();
    }
    public void HandleLevelComplete(GameLevel level)
    {
        var val_21;
        System.Predicate<System.String> val_23;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_4 = level.answers.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  level.answers);
        IQGains val_7 = CalculateCompletedLevelPoints(allValidWords:  this._ValidWordsInput, requiredWords:  80883712, numLetters:  level.word.m_stringLength, totalInput:  this._TotalInput, highestConsecutiveValidInput:  UnityEngine.Mathf.Max(a:  this._CurrentStreak, b:  this._HighestConsecutiveValidInput));
        this.lastLevelGains = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance();
        float val_8 = Total;
        string val_9 = -918809632(-918809632) + 15282176;
        DebugLog(logString:  -918809632);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_11 = PlayerIQ;
        float val_12 = this.lastLevelGains.Total;
        PlayerIQ = 3361248464 + this.lastLevelGains;
        System.Collections.Generic.List<ZooTile> val_14 = new System.Collections.Generic.List<ZooTile>(collection:  this._ValidWordsInput);
        val_21 = null;
        val_21 = null;
        val_23 = WordIQManagerGameplay.<>c.<>9__15_0;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new System.Predicate<ZooTile>(object:  WordIQManagerGameplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3376165968));
            WordIQManagerGameplay.<>c.<>9__15_0 = val_23;
        }
        
        int val_16 = RemoveAll(match:  8040448);
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleLevelCompleted(iqPointsTotal:  PlayerIQ, iqPointsGainedLastLevel:  -933718832, newWordsFoundLastLevel:  this.lastLevelGains);
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleLevelCompleted(allValidWords:  this._ValidWordsInput);
        this.ResetLevelProgress();
    }
    public void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> curData)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.lastLevelGains == 0)
        {
                return;
        }
        
        val_3 = curData;
        val_3.Add(key:  -918639232, value:  15282176);
        curData.Add(key:  -918635008, value:  15282176);
    }
    public void HandleNewLevel(GameLevel level)
    {
        System.Collections.Generic.List<ZooTile> val_11;
        var val_12;
        System.Predicate<System.String> val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_3 = level.answers.Split(separator:  478563824);
        val_11 = 1152921504687730688;
        System.Collections.Generic.List<ZooTile> val_4 = new System.Collections.Generic.List<ZooTile>(collection:  level.answers);
        System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        val_12 = null;
        val_12 = null;
        val_14 = WordIQManagerGameplay.<>c.<>9__17_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Predicate<ZooTile>(object:  WordIQManagerGameplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3376464816));
            WordIQManagerGameplay.<>c.<>9__17_0 = val_14;
            val_11 = 1152921504687730688;
        }
        
        int val_7 = RemoveAll(match:  8040448);
        val_11 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_8 = level.extraWords.Split(separator:  478563824);
        AddRange(collection:  level.extraWords);
        this.LoadGameState(allLevelWords:  80883712);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PrepNewLevel();
    }
    public string DebugGameplayLogic()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        string val_1 = PrettyPrint.printJSON(obj:  this._ValidWordsInput, types:  false, singleLineOutput:  false);
        typeof(System.Object[]).__il2cppRuntimeField_1C = this._ValidWordsInput;
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        string val_2 = System.String.Format(format:  -918368976, args:  472754880);
    }
    private void OnSceneLoaded(SceneType sceneType)
    {
        if(sceneType != 2)
        {
                return;
        }
        
        35636552 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_4 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -918220400, method:  new IntPtr(3376718800));
        0.addOnValidWordSubmittedAction(callback:  7507968);
        WordRegion val_5 = WordRegion.instance;
        System.Action val_6 = new System.Action(object:  -918220400, method:  new IntPtr(3376719824));
        0.addOnInvalidWordSubmittedAction(callback:  7454720);
        WordRegion val_7 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -918220400, method:  new IntPtr(3376720848));
        0.addOnLevelLoadedAction(callback:  7401472);
        WordRegion val_9 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -918220400, method:  new IntPtr(3376721872));
        0.addOnLevelCompleteAction(callback:  7401472);
    }
    private void SaveGameState()
    {
        this.WriteDataToPrefs();
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        string val_2 = this.DebugGameplayLogic();
        string val_3 = -918128304(-918128304) + -918104208(-918104208);
        DebugLog(logString:  -918128304);
    }
    private string GetPrefPrefix()
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                "" = "cat_";
        }
    
    }
    private void WriteDataToPrefs()
    {
        bool val_7 = static_value_021FC54B;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        string val_1 = this.GetPrefPrefix();
        string val_2 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917904128);
        UnityEngine.PlayerPrefs.SetInt(key:  -1671354896, value:  this._TotalInput);
        string val_3 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917904032);
        UnityEngine.PlayerPrefs.SetInt(key:  -1671354896, value:  this._CurrentStreak);
        string val_4 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917903936);
        UnityEngine.PlayerPrefs.SetInt(key:  -1671354896, value:  this._HighestConsecutiveValidInput);
        string val_5 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917903824);
        string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this._ValidWordsInput);
        UnityEngine.PlayerPrefs.SetString(key:  -1671354896, value:  this._ValidWordsInput);
        UnityEngine.PlayerPrefs.SetInt(key:  -917899632, value:  this._LevelFirstSawNew);
    }
    private void LoadGameState(System.Collections.Generic.List<string> allLevelWords)
    {
        bool val_18 = static_value_021FC54C;
        if(val_18 != true)
        {
                val_18 = true;
        }
        
        string val_1 = this.GetPrefPrefix();
        var val_19 = 0;
        string val_2 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917904128);
        this._TotalInput = UnityEngine.PlayerPrefs.GetInt(key:  -1671354896, defaultValue:  0);
        string val_4 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917904032);
        this._CurrentStreak = UnityEngine.PlayerPrefs.GetInt(key:  -1671354896, defaultValue:  0);
        string val_6 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917903936);
        this._HighestConsecutiveValidInput = UnityEngine.PlayerPrefs.GetInt(key:  -1671354896, defaultValue:  0);
        string val_8 = System.String.Format(format:  -1671354896, arg0:  1, arg1:  -917903824);
        string val_9 = UnityEngine.PlayerPrefs.GetString(key:  -1671354896, defaultValue:  -2141227328);
        object val_10 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1671354896);
        this._ValidWordsInput = "{0}{1}";
        string val_11 = this.DebugGameplayLogic();
        string val_12 = -917779328(-917779328) + -917742608(-917742608);
        DebugLog(logString:  -917779328);
        int val_13 = UnityEngine.PlayerPrefs.GetInt(key:  -917899632, defaultValue:  0);
        this._LevelFirstSawNew = val_13;
        do
        {
            if(val_19 >= val_13)
        {
                return;
        }
        
            if(val_13 <= val_19)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_18 = val_18 + 0;
            val_19 = val_19 + 1;
        }
        while((allLevelWords.Contains(item:  (0 + 0) + 16)) == true);
        
        string val_15 = PrettyPrint.printJSON(obj:  allLevelWords, types:  false, singleLineOutput:  false);
        string val_16 = PrettyPrint.printJSON(obj:  this._ValidWordsInput, types:  false, singleLineOutput:  false);
        string val_17 = -917766944(-917766944) + allLevelWords + -917766736(-917766736) + this._ValidWordsInput;
        DebugLog(logString:  -917766944);
        this.ResetLevelProgress();
    }
    private void DebugLog(string logString)
    {
        WordIQManager.DebugLog(logString:  logString);
    }
    public WordIQManagerGameplay()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this._ValidWordsInput = null;
        this._LevelFirstSawNew = 0;
    }

}
