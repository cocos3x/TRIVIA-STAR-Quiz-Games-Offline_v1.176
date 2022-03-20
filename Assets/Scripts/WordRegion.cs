using UnityEngine;
public class WordRegion : WordRegionBase
{
    // Fields
    public TextPreview textPreview;
    public WGCompliment compliment;
    protected UnityEngine.Transform safeTransform;
    protected System.Collections.Generic.List<string> validWords;
    public bool canHint;
    protected GameLevel gameLevel;
    public UnityEngine.ParticleSystem hintEffect;
    protected UnityEngine.RectTransform rt;
    private static WordRegion wordRegion;
    protected decimal ooc_coins;
    private const string extra_req_words_daily_challenge_pref_key = "xtra_req_words_daily_challenge1";
    private const string level_progress_pref_key = "level_progress2";
    private const string level_progress_daily_challenge_pref_key = "lvl_prog_daily_challenge3";
    private const string level_progress_spd_pref_key = "level_progress_spd3";
    public System.Action<string, int, bool, bool> OnHintedUsed;
    private System.Action<bool, string, LineWord, Cell> OnPreprocessPlayerTurn;
    private System.Action<string, bool> OnValidWordSubmitted;
    private System.Action OnInvalidWordSubmitted;
    private System.Action<GameLevel> OnBeforeLevelComplete;
    private System.Action<GameLevel> OnLevelComplete;
    public System.Action<GameLevel> OnLevelLoaded;
    protected System.Action onLevelLoadCompleteAction;
    private System.Action<string> onWordFoundAction;
    private System.Action<string> onExtraWordFoundAction;
    private System.Action<UnityEngine.Vector3> onHintUsedAtLocation;
    public UnityEngine.Events.UnityEvent onWordFound;
    public UnityEngine.Events.UnityEvent onExtraWordFound;
    protected float baseScale;
    private bool validWordsIncluded;
    private System.Collections.Generic.List<string> Hack_ExtraWords;
    private System.Collections.Generic.List<string> Hack_EssentialWords;
    private string Hack_hackedWord;
    public static bool hackTapToReveal;
    protected System.Collections.Generic.HashSet<LevelCompleteBlockerType> levelCompleteBlockers;
    public UnityEngine.Events.UnityEvent onBeforeLevelComplete;
    private int correctChainCount;
    protected System.Collections.Generic.List<string> ExtraRequiredList;
    private bool _hintDemoFTUX;
    private UnityEngine.Coroutine levelCompleteCoroutine;
    
    // Properties
    public UnityEngine.Transform SafeTransform { get; }
    public System.Collections.Generic.List<string> ExtraWords { get; }
    private static string extra_req_words_pref_key { get; }
    public static WordRegion instance { get; }
    protected bool levelCompleteBlocked { get; }
    
    // Methods
    public UnityEngine.Transform get_SafeTransform()
    {
        if(this.safeTransform == 0)
        {
                return this.transform;
        }
    
    }
    public System.Collections.Generic.List<string> get_ExtraWords()
    {
    
    }
    private static string get_extra_req_words_pref_key()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void addOnHintedUsedAction(System.Action<string, int, bool, bool> callback)
    {
        System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnHintedUsed, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnHintedUsed;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnHintedUsed = val_3;
    }
    public void addOnValidWordSubmittedAction(System.Action<string, bool> callback)
    {
        System.Action<System.String, System.Boolean> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnValidWordSubmitted, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnValidWordSubmitted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnValidWordSubmitted = val_3;
    }
    public void addOnPreprocessPlayerTurnAction(System.Action<bool, string, LineWord, Cell> callback)
    {
        System.Action<System.Boolean, System.String, LineWord, Cell> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnPreprocessPlayerTurn, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnPreprocessPlayerTurn;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnPreprocessPlayerTurn = val_3;
    }
    public void addOnInvalidWordSubmittedAction(System.Action callback)
    {
        System.Action val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnInvalidWordSubmitted, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnInvalidWordSubmitted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnInvalidWordSubmitted = val_3;
    }
    public void addOnBeforeLevelCompleteAction(System.Action<GameLevel> callback)
    {
        System.Action<GameLevel> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnBeforeLevelComplete, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnBeforeLevelComplete;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnBeforeLevelComplete = val_3;
    }
    public void addOnLevelCompleteAction(System.Action<GameLevel> callback)
    {
        System.Action<GameLevel> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnLevelComplete, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnLevelComplete;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnLevelComplete = val_3;
    }
    public void addOnLevelLoadedAction(System.Action<GameLevel> callback)
    {
        System.Action<GameLevel> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.OnLevelLoaded, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.OnLevelLoaded;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.OnLevelLoaded = val_3;
    }
    public void addOnLevelLoadCompleteAction(System.Action callback)
    {
        System.Action val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.onLevelLoadCompleteAction, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.onLevelLoadCompleteAction;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.onLevelLoadCompleteAction = val_3;
    }
    public void addOnWordFoundAction(System.Action<string> callback)
    {
        System.Action<System.String> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.onWordFoundAction, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.onWordFoundAction;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.onWordFoundAction = val_3;
    }
    public void removeOnWordFoundAction(System.Action<string> callback)
    {
        System.Action<System.String> val_2 = this.onWordFoundAction;
        System.Delegate val_1 = System.Delegate.Remove(source:  val_2 = this.onWordFoundAction, value:  callback);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.onWordFoundAction = val_2;
    }
    public void addOnExtraWordFoundAction(System.Action<string> callback)
    {
        System.Action<System.String> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.onExtraWordFoundAction, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.onExtraWordFoundAction;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.onExtraWordFoundAction = val_3;
    }
    public void addOnHintUsedAtLocation(System.Action<UnityEngine.Vector3> callback)
    {
        System.Action<UnityEngine.Vector3> val_3;
        if((this.CheckValidCallback(wordRegionEvent:  this.onHintUsedAtLocation, callback:  callback)) == false)
        {
                return;
        }
        
        val_3 = this.onHintUsedAtLocation;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.onHintUsedAtLocation = val_3;
    }
    private bool CheckValidCallback(System.Delegate wordRegionEvent, System.Delegate callback)
    {
        if(wordRegionEvent == 0)
        {
                return true;
        }
        
        35626142 = wordRegionEvent;
        if(wordRegionEvent.invoke_impl == new IntPtr(0))
        {
                return true;
        }
        
        System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<System.Object>(source:  wordRegionEvent);
        bool val_2 = wordRegionEvent.Contains(item:  callback);
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public void AddLevelCompleteBlocker(LevelCompleteBlockerType blocker)
    {
        bool val_1 = this.levelCompleteBlockers.Add(item:  blocker);
    }
    public void RemoveLevelCompleteBlocker(LevelCompleteBlockerType blocker)
    {
        bool val_1 = this.levelCompleteBlockers.Remove(item:  blocker);
    }
    public static WordRegion get_instance()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_32;
        var val_33;
        val_12 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
            goto label_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_9;
        }
        
        val_13 = 1152921504886931456;
        val_14 = null;
        val_15 = 1152921504765685760;
        goto label_94;
        label_9:
        val_13 = 6337584 + 29288203;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        val_12 = 1152921504765685760;
        if(App.game != 4)
        {
            goto label_17;
        }
        
        val_13 = 1152921504886931456;
        val_17 = null;
        val_17 = null;
        if(WordRegion.level_progress_spd_pref_key != 0)
        {
            goto label_97;
        }
        
        val_18 = 1152921511132388400;
        goto label_25;
        label_17:
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_19 = null;
        val_19 = null;
        if(App.game != 1)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_20 = null;
            val_20 = null;
            if(App.game != 7)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_21 = null;
            val_21 = null;
            if(App.game != 8)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_22 = null;
            val_22 = null;
            if(App.game != 9)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_23 = null;
            val_23 = null;
            if(App.game != 10)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_24 = null;
            val_24 = null;
            if(App.game != 11)
        {
                if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_25 = null;
            val_25 = null;
            if(App.game != 18)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        if(WordRegion.level_progress_spd_pref_key == 0)
        {
                T[] val_7 = UnityEngine.Resources.FindObjectsOfTypeAll<System.Object>();
            val_13 = 1152921511132389440;
            val_27 = 0;
        }
        
        val_32 = null;
        val_32 = null;
        return;
        label_94:
        if( != 0)
        {
            goto label_97;
        }
        
        val_18 = 1152921511132390448;
        label_25:
        object val_11 = UnityEngine.Object.FindObjectOfType<System.Object>();
        val_33 = null;
        WordRegion.level_progress_spd_pref_key = val_18;
        label_97:
        val_32 = null;
        val_32 = null;
    }
    protected bool get_levelCompleteBlocked()
    {
        if(true != 0)
        {
                true = 1;
        }
        
        return true;
    }
    protected virtual void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.rt = this;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
    }
    private void LateUpdate()
    {
        goto typeof(WordRegion).__il2cppRuntimeField_DC;
    }
    public void SetActive(bool state)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  state);
    }
    public int GetTotalAcceptableWords()
    {
        if(this.validWords != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    protected string ScrubStar(string word)
    {
        if((word.Contains(value:  -2063697616)) == false)
        {
                return;
        }
        
        if(word != null)
        {
                return word.Remove(startIndex:  0, count:  1);
        }
        
        return word.Remove(startIndex:  0, count:  1);
    }
    public static string Debug_GetExtraRequiredWordsInfo()
    {
        var val_13;
        GameEcon val_1 = App.getGameEcon;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        GameEcon val_2 = App.getGameEcon;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        GameEcon val_3 = App.getGameEcon;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        GameEcon val_4 = App.getGameEcon;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        int val_5 = MainController.GetHintsPerChapterThreshold();
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        GameEcon val_6 = App.getGameEcon;
        typeof(System.Object[]).__il2cppRuntimeField_24 = null;
        Player val_7 = App.Player;
        typeof(System.Object[]).__il2cppRuntimeField_28 = null;
        Player val_8 = App.Player;
        typeof(System.Object[]).__il2cppRuntimeField_2C = null;
        Player val_9 = App.Player;
        typeof(System.Object[]).__il2cppRuntimeField_30 = null;
        val_13 = null;
        val_13 = null;
        typeof(System.Object[]).__il2cppRuntimeField_34 = WADataParser.CurrentLevelGenVersion;
        typeof(System.Object[]).__il2cppRuntimeField_38 = WADataParser.debug_lastReqDetermination;
        string val_10 = PrettyPrint.printJSON(obj:  WADataParser.debug_extraRequiredWords, types:  false, singleLineOutput:  false);
        typeof(System.Object[]).__il2cppRuntimeField_3C = WADataParser.debug_extraRequiredWords;
        int val_11 = Prefs.currentChapter;
        typeof(System.Object[]).__il2cppRuntimeField_40 = null;
        string val_12 = System.String.Format(format:  -2063581440, args:  472754880);
    }
    public virtual void Load(GameLevel gameLevel, System.Action loadCompleteCallback)
    {
        this.gameLevel = gameLevel;
        if(loadCompleteCallback != 0)
        {
                this = this;
            this.addOnLevelLoadCompleteAction(callback:  gameLevel = loadCompleteCallback);
        }
        
        System.Collections.IEnumerator val_1 = this.LoadCoroutine();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2063436240);
    }
    private System.Collections.IEnumerator LoadCoroutine()
    {
        object val_1 = new System.Object();
        typeof(WordRegion.<LoadCoroutine>d__70).__il2cppRuntimeField_8 = 0;
        typeof(WordRegion.<LoadCoroutine>d__70).__il2cppRuntimeField_10 = this;
    }
    public virtual void UpdateOverlayUI(LineWord word, bool hintUsed = False)
    {
    
    }
    public virtual void UpdateProgressBar()
    {
    
    }
    private System.Collections.IEnumerator LevelLoadCompleteActionCoroutine()
    {
        object val_1 = new System.Object();
        typeof(WordRegion.<LevelLoadCompleteActionCoroutine>d__73).__il2cppRuntimeField_8 = 0;
        typeof(WordRegion.<LevelLoadCompleteActionCoroutine>d__73).__il2cppRuntimeField_10 = this;
    }
    private void CheckLinesShowing()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_3 + 32) != 0)
        {
            goto label_5;
        }
        
        val_3.CheckShown();
        goto label_5;
        label_2:
        Dispose();
    }
    public virtual void CheckAnswer(string checkWord)
    {
        string val_28;
        string val_29;
        TextPreview val_30;
        var val_31;
        TextPreview val_32;
        var val_34;
        var val_35;
        var val_36;
        float val_38;
        val_28 = checkWord;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_29 = val_1;
            typeof(WordRegion.<>c__DisplayClass75_0).__il2cppRuntimeField_8 = val_28;
        }
        else
        {
                val_29 = 8;
            mem[8] = val_28;
            val_28 = mem[8];
        }
        
        if((System.String.IsNullOrEmpty(value:  val_28)) == false)
        {
            goto label_3;
        }
        
        val_30 = this.textPreview;
        goto label_4;
        label_3:
        mem[1152921511134088116] = 0;
        this.NotifyPreprocessPlayerTurn(hintUsage:  false, wordEntered:  val_29, lineWord:  0, cell:  0);
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  280297472, method:  new IntPtr(2232203632));
        object val_4 = val_28.Find(match:  8040448);
        val_28 = val_28;
        if(val_28 == 0)
        {
            goto label_9;
        }
        
        val_31 = this;
        val_32 = this.textPreview;
        if((checkWord + 32) == 0)
        {
            goto label_12;
        }
        
        val_32.SetExistColor();
        val_28.ShowExists();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_34 = 0;
        val_35 = 6;
        goto label_17;
        label_9:
        val_28 = this.validWords.Contains(item:  mem[8]);
        val_32 = ExtraWord.GAMETYPE_CATEGORY_LEVELS;
        if((val_32.ProcessWord(word:  mem[8], lines:  mem[8], isWord:  val_28)) == false)
        {
            goto label_22;
        }
        
        if(this.onExtraWordFoundAction != 0)
        {
                this.onExtraWordFoundAction.Invoke(obj:  mem[8]);
        }
        
        val_31 = this;
        this.textPreview.SetValidColor();
        MainController val_9 = MainController.instance;
        val_28 = 0;
        if(0 == 0)
        {
            goto label_28;
        }
        
        val_36 = 0;
        goto label_29;
        label_22:
        val_31 = this;
        this.textPreview.SetWrongColor();
        if((checkWord + 8) < 3)
        {
                0 = 1;
        }
        
        if((checkWord + 8) == 3)
        {
                this.PostGoldenApplesNotif(valid:  false, isHint:  false);
            this.NotifyWordSubmitted(word:  mem[8], valid:  false, isExtra:  false);
        }
        
        this.correctChainCount = 0;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_34 = 0;
        val_35 = 5;
        label_17:
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  5, oneshot:  true, pitch:  null, vol:  null);
        goto label_90;
        label_12:
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.SetAnswerColor();
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PostGoldenApplesNotif(valid:  true, isHint:  false);
        this.NotifyWordSubmitted(word:  val_7 + 12, valid:  true, isExtra:  false);
        if((val_7 + 33) != 0)
        {
                GameEcon val_11 = App.getGameEcon;
            var val_12 = 0 + 412;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 412) + (0)], hi = mem[(0 + 412) + (4)], lo = mem[(0 + 412) + (8)], mid = mem[(0 + 412) + (12)]}, source:  "Word Coin Bonus", externalParams:  0, animated:  false);
            val_31 = val_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_38 = 0f;
        if((-2100700048) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_16 = UnityEngine.Object.op_Inequality(x:  public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C, y:  0);
            if(val_16 != false)
        {
                if(val_16 == false)
        {
                6343828 = 6343832;
        }
        
            val_38 = 0f;
        }
        
        }
        
        val_28.ShowAnswer(waitTime:  null);
        MainController val_17 = MainController.instance;
        MainController val_18 = MainController.instance;
        string val_19 = null + val_7 + 12(val_7 + 12) + -2100450224(-2100450224);
        0.WordsCompleted = null;
        int val_29 = this.correctChainCount;
        val_29 = val_29 + 1;
        this.correctChainCount = val_29;
        if((UnityEngine.Object.op_Implicit(exists:  this.compliment)) != false)
        {
                object val_21 = System.Linq.Enumerable.Last<System.Object>(source:  1152921511134046688);
            if(1152921511134046688 != val_28)
        {
                if(this.correctChainCount < 3)
        {
            goto label_70;
        }
        
        }
        
            GameBehavior val_23 = App.getBehavior;
            if(0 >= 3)
        {
                this.compliment.ShowRandom();
        }
        
        }
        
        label_70:
        this.CheckLinesShowing();
        if(this.onWordFoundAction != 0)
        {
                this.onWordFoundAction.Invoke(obj:  mem[8]);
        }
        
        this.CheckGameComplete();
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  null, vol:  null);
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != true)
        {
                string val_27 = this.GetFirstIncompleteWord();
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  -2062693472, QAHACK_Force:  false);
        }
        
        this.onWordFound.Invoke();
        if((this.ExtraRequiredList.Contains(item:  mem[8])) == false)
        {
            goto label_90;
        }
        
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.CheckRequiredExtraWord(word:  mem[8]);
        goto label_90;
        label_28:
        val_36 = 0;
        label_29:
        val_28.ExtraWordsFound = 1;
        this.NotifyWordSubmitted(word:  mem[8], valid:  true, isExtra:  true);
        label_90:
        val_30 = val_30;
        label_4:
        val_30.FadeOut();
    }
    private void PostGoldenApplesNotif(bool valid, bool isHint = False)
    {
        string val_1 = valid.ToString();
        string val_2 = isHint.ToString();
        string val_3 = -2062556320(-2062556320) + -2062544065(-2062544065) + -2062556144(-2062556144) + -2062544066(-2062544066);
        UnityEngine.Debug.LogWarning(message:  -2062556320);
    }
    private void NotifyPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        if(this.OnPreprocessPlayerTurn == 0)
        {
                return;
        }
        
        this.OnPreprocessPlayerTurn.Invoke(arg1:  hintUsage, arg2:  wordEntered, arg3:  lineWord, arg4:  cell);
    }
    private void NotifyWordSubmitted(string word, bool valid, bool isExtra)
    {
        if(valid != false)
        {
                if(this.OnValidWordSubmitted == 0)
        {
                return;
        }
        
            this.OnValidWordSubmitted.Invoke(arg1:  word, arg2:  isExtra);
            return;
        }
        
        if(this.OnInvalidWordSubmitted == 0)
        {
                return;
        }
        
        this.OnInvalidWordSubmitted.Invoke();
    }
    private void NotifyLevelLoaded(GameLevel level)
    {
        if(this.OnLevelLoaded == 0)
        {
                return;
        }
        
        this.OnLevelLoaded.Invoke(obj:  level);
    }
    private void NotifyBeforeLevelComplete(GameLevel level)
    {
        if(this.OnBeforeLevelComplete == 0)
        {
                return;
        }
        
        this.OnBeforeLevelComplete.Invoke(obj:  level);
    }
    private void NotifyLevelComplete(GameLevel level)
    {
        if(this.OnLevelComplete == 0)
        {
                return;
        }
        
        this.OnLevelComplete.Invoke(obj:  level);
    }
    private void NotifyHintUsed(string word, int index, bool isFree, bool isPickerHint)
    {
        if(this.OnHintedUsed == 0)
        {
                return;
        }
        
        this.OnHintedUsed.Invoke(arg1:  word, arg2:  index, arg3:  isFree, arg4:  isPickerHint);
    }
    public void CheckGameComplete()
    {
        var val_6;
        System.Predicate<LineWord> val_8;
        val_6 = null;
        val_6 = null;
        val_8 = WordRegion.<>c.<>9__83_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2233322224));
            WordRegion.<>c.<>9__83_0 = val_8;
        }
        
        object val_2 = static_value_021F9CB2.Find(match:  8040448);
        if(static_value_021F9CB2 != 0)
        {
                return;
        }
        
        if(this.levelCompleteCoroutine == 0)
        {
                System.Collections.IEnumerator val_4 = this.DoLevelCompleteActions();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -2061611856);
            this.levelCompleteCoroutine = this;
        }
        
        this.onBeforeLevelComplete.Invoke();
    }
    private System.Collections.IEnumerator DoLevelCompleteActions()
    {
        object val_1 = new System.Object();
        typeof(WordRegion.<DoLevelCompleteActions>d__85).__il2cppRuntimeField_8 = 0;
        typeof(WordRegion.<DoLevelCompleteActions>d__85).__il2cppRuntimeField_10 = this;
    }
    public virtual void HintReward()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_26;
        System.Func<LineWord, System.Int32> val_28;
        string val_29;
        var val_30;
        System.Func<LineWord, System.Int32> val_32;
        var val_33;
        System.Func<LineWord, System.Boolean> val_35;
        var val_37;
        var val_38;
        val_26 = null;
        val_26 = null;
        val_28 = WordRegion.<>c.<>9__86_0;
        if(val_28 == 0)
        {
                val_28 = null;
            val_28 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2233563632));
            WordRegion.<>c.<>9__86_0 = val_28;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  R5, keySelector:  7720960);
        val_30 = null;
        val_30 = null;
        val_32 = WordRegion.<>c.<>9__86_1;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2233566704));
            WordRegion.<>c.<>9__86_1 = val_32;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_4 = System.Linq.Enumerable.ThenBy<System.Object, System.Int32>(source:  R5, keySelector:  7720960);
        val_33 = null;
        val_33 = null;
        val_35 = WordRegion.<>c.<>9__86_2;
        if(val_35 == 0)
        {
                val_35 = null;
            val_35 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2233568752));
            WordRegion.<>c.<>9__86_2 = val_35;
        }
        
        object val_6 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  R5, predicate:  7720960);
        if(R5 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = ShowHint(cell:  R5);
        if((R5 + 32) != 0)
        {
                if((R5 + 33) != 0)
        {
                GameEcon val_12 = App.getGameEcon;
            var val_13 = 0 + 412;
            val_29 = "Word Coin Bonus";
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 412) + (0)], hi = mem[(0 + 412) + (4)], lo = mem[(0 + 412) + (8)], mid = mem[(0 + 412) + (12)]}, source:  val_29, externalParams:  0, animated:  false);
        }
        
            mem[(0 + 412) + (0)].PostGoldenApplesNotif(valid:  true, isHint:  true);
            this.NotifyWordSubmitted(word:  R5 + 12, valid:  true, isExtra:  false);
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  val_8.x, vol:  val_8.y);
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                string val_17 = this.GetFirstIncompleteWord();
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  -2061363280, QAHACK_Force:  false);
        }
        
        }
        
        this.CheckGameComplete();
        val_35 = Prefs.currentChapter;
        Prefs.AddToNumHint(world:  Prefs.currentWorld, subWorld:  val_35, level:  Prefs.currentLevel);
        UnityEngine.Transform val_21 = this.hintEffect.transform;
        float val_28 = -20f;
        val_10 = 0;
        val_9 = 0;
        val_11 = 0;
        val_28 = val_11 + val_28;
        UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  val_28, y:  val_8.y, z:  val_8.z);
        this.hintEffect.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        this.hintEffect.Play();
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  val_28, vol:  val_8.y);
        MainController val_24 = MainController.instance;
        var val_25 = 0 + 1;
        Player val_26 = App.Player;
        val_37 = 2621448;
        if(val_37 != 0)
        {
                val_38 = static_value_00280060;
        }
        else
        {
                val_37 = 88;
            val_38 = 0;
        }
        
        mem[88] = 1;
        Player val_27 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public void OnHintDemoEnable()
    {
        this._hintDemoFTUX = true;
    }
    public void OnHintDemoDisable()
    {
        System.Collections.IEnumerator val_1 = this.FrameAfterHintDemo();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2061131088);
    }
    private System.Collections.IEnumerator FrameAfterHintDemo()
    {
        object val_1 = new System.Object();
        typeof(WordRegion.<FrameAfterHintDemo>d__89).__il2cppRuntimeField_8 = 0;
        typeof(WordRegion.<FrameAfterHintDemo>d__89).__il2cppRuntimeField_10 = this;
    }
    public virtual void HintClick(bool free = False, LineWord line, Cell cell, bool isPickerHint = False)
    {
        int val_7;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_28;
        int val_29;
        int val_30;
        var val_69;
        var val_71;
        System.Func<LineWord, System.Int32> val_73;
        var val_74;
        System.Func<LineWord, System.Boolean> val_76;
        UnityEngine.Object val_77;
        var val_78;
        if(WGFTUXManager.IsShowing == true)
        {
            goto label_131;
        }
        
        if(this._hintDemoFTUX != false)
        {
                if(free == false)
        {
            goto label_131;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem[1152921511135893556] = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnHintForceEventLineWord(lines:  cell, word: ref  LineWord val_4 = -2060900072, isPickerHint:  isPickerHint);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        decimal val_6 = CurrencyController.GetBalance();
        val_69 = 1152921504892043264;
        if(isPickerHint == false)
        {
            goto label_10;
        }
        
        GameEcon val_9 = App.getGameEcon;
        if(0 != 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_10:
        GameBehavior val_10 = App.getBehavior;
        if(0 == 0)
        {
            goto label_23;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlayingChallengingLevels == false)
        {
            goto label_23;
        }
        
        goto label_29;
        label_23:
        if(this.gameLevel.isChallengingLevel == false)
        {
            goto label_27;
        }
        
        label_29:
        GameEcon val_14 = App.getGameEcon;
        GameEcon val_15 = App.getGameEcon;
        decimal val_16 = System.Decimal.op_Implicit(value:  -2060900096);
        decimal val_17 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -2060900112, hi = 6, lo = 4, mid = 4}, d2:  new System.Decimal() {flags = 308});
        val_69 = 1152921504892043264;
        goto label_34;
        label_27:
        GameEcon val_22 = App.getGameEcon;
        label_14:
        label_34:
        GameBehavior val_23 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                decimal val_27 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  isPickerHint));
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_28, hi = val_29, lo = val_30, mid = val_7}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_32 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -2060900096, hi = 6, lo = 4, mid = 4}, d2:  new System.Decimal() {flags = 308, hi = val_28, lo = val_29, mid = val_30});
            WADPets.WADPet val_33 = WADPetsManager.GetPetByAbility(ability:  isPickerHint);
            var val_69 = isPickerHint + 8;
            val_69 = val_69 + 8;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            string val_34 = System.String.Format(format:  -2060917776, arg0:  431575040);
            val_19 = val_29;
            val_18 = val_28;
            val_20 = val_30;
            val_21 = val_7;
            Add(key:  -2060917776, value:  10170368);
        }
        
            val_69 = 1152921504892043264;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  -2060917648);
        twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_36 = isPickerHint ^ 1;
        if(((UnityEngine.Object.op_Implicit(exists:  -2100701168)) != false) && (WGChallengeWordsManager.IsFeatureUnlocked != false))
        {
                twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsPlaying != false)
        {
                val_28 = 1;
            Add(key:  -2060917520, value:  8945664);
        }
        
        }
        
        val_36 = 1 & val_36;
        if(SeasonPassEventHandler.IsPlusPassActive != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_42 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                if(isPickerHint != false)
        {
                int val_44 = SeasonPassEventHandler.PassPickHintDiscount;
        }
        else
        {
                int val_45 = SeasonPassEventHandler.PassHintDiscount;
        }
        
            decimal val_46 = System.Decimal.op_Implicit(value:  -2060900096);
            decimal val_47 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -2060900112, hi = val_28, lo = val_29, mid = val_30}, d2:  new System.Decimal() {flags = val_7});
        }
        
        }
        
        val_36 = val_36 | free;
        bool val_48 = System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = ???, hi = ???, lo = ???, mid = val_7}, d2:  new System.Decimal() {flags = val_18, hi = val_19, lo = val_20, mid = val_21});
        val_48 = val_36 | val_48;
        if(val_48 != true)
        {
            goto label_81;
        }
        
        if(isPickerHint != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_49 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnHintUsed(wasFree:  val_36);
        }
        
        if(line != 0)
        {
            goto label_88;
        }
        
        val_71 = null;
        val_71 = null;
        val_73 = WordRegion.<>c.<>9__90_0;
        if(val_73 == 0)
        {
                val_73 = null;
            val_73 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2234049888));
            WordRegion.<>c.<>9__90_0 = val_73;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_52 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  mem[1152921511135893560], keySelector:  7720960);
        val_74 = null;
        val_74 = null;
        val_76 = WordRegion.<>c.<>9__90_1;
        if(val_76 == 0)
        {
                val_76 = null;
            val_76 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2234051936));
            WordRegion.<>c.<>9__90_1 = val_76;
        }
        
        object val_54 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  mem[1152921511135893560], predicate:  7720960);
        val_77 = mem[1152921511135893560];
        goto label_99;
        label_81:
        decimal val_55 = CurrencyController.GetBalance();
        if(CategoryPacksManager.IsPlaying == true)
        {
                6 = 117;
        }
        
        var val_70 = 29273101;
        val_70 = 6352960 + val_70;
        if(val_70 == 0)
        {
                mem2[0] = 1;
        }
        
        val_78 = null;
        val_78 = null;
        PurchaseProxy.currentPurchasePoint = 117;
        UnityEngine.Debug.LogError(message:  -2060914336);
        if(WGStarterPackController.featureRelavent == false)
        {
            goto label_109;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_59 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_60 = ShowUGUIMonolith<System.Object>(showNext:  false);
        twelvegigs.Autopilot.AutopilotManager val_61 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance().__il2cppRuntimeField_C = 47;
        goto label_136;
        label_88:
        val_77 = mem[1152921511135893560];
        label_99:
        if(val_77 == 0)
        {
            goto label_136;
        }
        
        UnityEngine.Vector3 val_63 = UnityEngine.Vector3.zero;
        if(cell != 0)
        {
            goto label_125;
        }
        
        Cell val_65 = mem[1152921511135893560].ShowHintGetCell(cell:  cell);
        if(mem[1152921511135893560] != 0)
        {
            goto label_128;
        }
        
        UnityEngine.Debug.LogWarning(message:  -2060912176, context:  -2060888032);
        goto label_131;
        label_109:
        twelvegigs.Autopilot.AutopilotManager val_67 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_68 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Init(outOfCredits:  true, onCloseAction:  0);
        goto label_136;
    }
    public virtual void DoFreeHint(LineWord line, Cell cell, UnityEngine.Transform hintAnimStartTransform)
    {
        if(line == 0)
        {
                return;
        }
        
        if(cell == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = ShowHint(cell:  line);
        if(this.onHintUsedAtLocation != 0)
        {
                this.onHintUsedAtLocation.Invoke(obj:  new UnityEngine.Vector3());
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2060922896) != 0)
        {
                UnityEngine.Transform val_6 = cell.letterGroup.transform;
            cell.letterGroup.DoHintAnimation(letterGroup:  cell.letterGroup, startTransform:  hintAnimStartTransform);
        }
        
        UnityEngine.Transform val_7 = this.hintEffect.transform;
        UnityEngine.Transform val_8 = cell.transform;
        UnityEngine.Vector3 val_9 = position;
        this.hintEffect.position = new UnityEngine.Vector3();
        this.hintEffect.Play();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  val_9.x, vol:  val_9.y);
        this.CheckLinesShowing();
        this.CheckGameComplete();
    }
    protected virtual void ApplyHintToLine(LineWord line, Cell cell)
    {
        var val_13;
        if(line.isShown != false)
        {
                if(line.isStarred != false)
        {
                GameEcon val_1 = App.getGameEcon;
            var val_2 = 0 + 412;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 412) + (0)], hi = mem[(0 + 412) + (4)], lo = mem[(0 + 412) + (8)], mid = mem[(0 + 412) + (12)]}, source:  "Word Coin Bonus", externalParams:  0, animated:  false);
        }
        
            mem[(0 + 412) + (0)].PostGoldenApplesNotif(valid:  true, isHint:  true);
            this.NotifyWordSubmitted(word:  line.answer, valid:  true, isExtra:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  null, vol:  null);
            if(this.onWordFoundAction != 0)
        {
                this.onWordFoundAction.Invoke(obj:  line.answer);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            OnSubmitWordWithHints(word:  line.answer);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                string val_9 = this.GetFirstIncompleteWord();
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  -2060560608, QAHACK_Force:  false);
        }
        
            this.textPreview.FadeOut();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnHintIncompleteWord(word:  line.answer, hintedCell:  cell);
    }
    public virtual void MegalHint(LineWord line, Cell cell)
    {
        if(WGFTUXManager.IsShowing == true)
        {
                return;
        }
        
        if(line.isShown != false)
        {
                if(line.isStarred != false)
        {
                GameEcon val_2 = App.getGameEcon;
            var val_3 = 0 + 412;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 412) + (0)], hi = mem[(0 + 412) + (4)], lo = mem[(0 + 412) + (8)], mid = mem[(0 + 412) + (12)]}, source:  "Word Coin Bonus", externalParams:  0, animated:  false);
        }
        
            mem[(0 + 412) + (0)].PostGoldenApplesNotif(valid:  true, isHint:  true);
            this.NotifyWordSubmitted(word:  line.answer, valid:  true, isExtra:  false);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  null, vol:  null);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnSubmitWordWithHints(word:  line.answer);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                string val_10 = this.GetFirstIncompleteWord();
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  -2060391264, QAHACK_Force:  false);
        }
        
        }
        
        UnityEngine.Transform val_11 = this.hintEffect.transform;
        UnityEngine.Transform val_12 = cell.transform;
        UnityEngine.Vector3 val_13 = position;
        this.hintEffect.position = new UnityEngine.Vector3();
        this.hintEffect.Play();
        line = 1152921511082729536;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  val_13.x, vol:  val_13.y);
        this.CheckLinesShowing();
        this.CheckGameComplete();
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  val_13.x, vol:  val_13.y);
    }
    public System.Collections.Generic.List<string> GetCompletedWords()
    {
        var val_6;
        System.Predicate<LineWord> val_8;
        var val_10;
        System.Func<LineWord, System.String> val_12;
        val_6 = null;
        val_6 = null;
        val_8 = WordRegion.<>c.<>9__94_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2234688608));
            WordRegion.<>c.<>9__94_0 = val_8;
        }
        
        System.Collections.Generic.List<T> val_2 = this.FindAll(match:  8040448);
        if(this == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = WordRegion.<>c.<>9__94_1;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<ZooTile, System.String>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2234690656));
            WordRegion.<>c.<>9__94_1 = val_12;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_4 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  -2060249568, selector:  7720960);
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  -2060249568);
    }
    public string GetFirstIncompleteWord()
    {
        var val_4;
        System.Func<LineWord, System.Boolean> val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_6 = WordRegion.<>c.<>9__95_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2234805728));
            WordRegion.<>c.<>9__95_0 = val_6;
        }
        
        object val_2 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -2060136544, predicate:  7720960);
        val_7 = 0;
        if((-2060136544) == 0)
        {
                return;
        }
    
    }
    private string GetLevelProgressPrefKey()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                val_5 = "lvl_prog_daily_challenge3";
            return;
        }
        
        if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                return LevelProgressPrefKey;
        }
        
            return LevelProgressPrefKey;
        }
        
        val_5 = "level_progress2";
    }
    protected string GetExtraRequiredWordsProgressPrefKey()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        if(CategoryPacksManager.IsPlaying == false)
        {
                return WordRegion.extra_req_words_pref_key;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                return LevelExtraRequiredWordsProgressPrefKey;
        }
        
        return LevelExtraRequiredWordsProgressPrefKey;
    }
    private void DoHintAnimation(UnityEngine.Transform letterGroup, UnityEngine.Transform startTransform)
    {
        float val_13;
        float val_14;
        UnityEngine.Transform val_24 = startTransform;
        if(val_24 == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_4 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.transform;
            val_24 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18;
        }
        
        UnityEngine.Vector3 val_5 = position;
        letterGroup.position = new UnityEngine.Vector3();
        object val_6 = letterGroup.GetComponent<System.Object>();
        bool val_7 = UnityEngine.Object.op_Equality(x:  letterGroup, y:  0);
        if(new System.Object() != 0)
        {
                typeof(WordRegion.<>c__DisplayClass98_0).__il2cppRuntimeField_8 = val_7;
        }
        else
        {
                mem[8] = val_7;
        }
        
        typeof(WordRegion.<>c__DisplayClass98_0).__il2cppRuntimeField_10 = 0;
        if(184877056 != 0)
        {
                object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  184877056, parent:  letterGroup, worldPositionStays:  false);
            typeof(WordRegion.<>c__DisplayClass98_0).__il2cppRuntimeField_10 = MonoUtils.instance.tileTrailEffect;
            object val_10 = GetComponent<System.Object>();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = -8.744745E-36f});
            anchoredPosition = new UnityEngine.Vector2() {x = val_13, y = val_14};
        }
        
        twelvegigs.Autopilot.WUTAutopilotGameplay val_15 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  letterGroup);
        typeof(WordRegion.<>c__DisplayClass98_0).__il2cppRuntimeField_C = letterGroup;
        letterGroup.overrideSorting = true;
        typeof(WordRegion.<>c__DisplayClass98_0).__il2cppRuntimeField_C.sortingLayerName = -2059812896;
        DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
        object val_17 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  letterGroup, endValue:  new UnityEngine.Vector3(), duration:  val_18.x, snapping:  true);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  letterGroup);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_18.x);
        DG.Tweening.TweenCallback val_22 = new DG.Tweening.TweenCallback(object:  280457216, method:  new IntPtr(2235155520));
        mem[68] = null;
        object val_23 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
    }
    public virtual void SaveLevelProgress()
    {
        WordRegion val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  this.gameLevel.answers);
        List.Enumerator<T> val_2 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_6 = GetEnumerator();
        float val_18 = 0f;
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if((val_8 + 36) == 0)
        {
                "1" = "0";
        }
        
        System.Text.StringBuilder val_9 = Append(value:  1254115712);
        goto label_10;
        label_7:
        val_18 = val_18 + 1;
        mem2[0] = 126;
        Dispose();
        if(val_18 != 1)
        {
                if(val_18 > 1)
        {
                0 = 1;
        }
        
            var val_19 = -2059669376 + ((0 + 1)) << 2;
            val_19 = val_19 - 126;
            val_19 = val_19 >> 5;
            val_19 = 1 & val_19;
            val_18 = val_18 - val_19;
        }
        
        Add(item:  24121344);
        goto label_16;
        label_4:
        Dispose();
        val_18 = this;
        if(CategoryPacksManager.IsPlaying != false)
        {
                val_19 = 0;
            GameLevel val_12 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
        }
        else
        {
                val_19 = 0;
            GameplayMode val_13 = PlayingLevel.CurrentGameplayMode;
            GameLevel val_14 = PlayingLevel.GetLevel(currentMode:  0, parameters:  0);
        }
        
        if(val_19 != 0)
        {
                0 = null;
            mem[8] = 0;
        }
        
        PlayingLevel.Save();
        string val_15 = this.GetExtraRequiredWordsProgressPrefKey();
        if((mem[1152921511137124492] + 12) >= 1)
        {
                T[] val_16 = mem[1152921511137124492].ToArray();
            val_20 = mem[1152921511137124492];
            val_21 = 0;
        }
        else
        {
                val_18 = "n/a";
            val_21 = 0;
            val_20 = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = val_18;
        }
        
        bool val_17 = CryptoPlayerPrefsX.SetStringArray(key:  null, stringArray:  477709520);
    }
    public string[] GetAncientLevelProgress()
    {
        bool val_11;
        System.Collections.Generic.List<System.String> val_12;
        val_11 = static_value_021F9CC0;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        string val_1 = this.GetLevelProgressPrefKey();
        System.String[] val_2 = CryptoPlayerPrefsX.GetStringArray(key:  1);
        val_12 = val_11;
        if(50331648 == 0)
        {
                return;
        }
        
        string val_3 = 16787456.Replace(oldValue:  -2063697616, newValue:  1098586544);
        string val_4 = this.gameLevel.answers.Replace(oldValue:  -2063697616, newValue:  1098586544);
        if((16787456.Equals(value:  this.gameLevel.answers)) != false)
        {
                System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Skip<System.Object>(source:  1, count:  1);
            TSource[] val_7 = System.Linq.Enumerable.ToArray<System.Object>(source:  1);
            val_12 = val_12;
            string val_8 = this.GetExtraRequiredWordsProgressPrefKey();
            System.String[] val_9 = CryptoPlayerPrefsX.GetStringArray(key:  1);
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<System.Object>(source:  1);
            this.ExtraRequiredList = val_12;
            return;
        }
        
        val_12 = null;
    }
    public void ClearAncientLevelProgress()
    {
        bool val_2 = static_value_021F9CC1;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        string val_1 = this.GetLevelProgressPrefKey();
        CPlayerPrefs.DeleteKey(key:  1);
    }
    private bool LevelsMatch(string setA, string setB)
    {
        if(setA != null)
        {
                return setA.Equals(value:  setB);
        }
        
        return setA.Equals(value:  setB);
    }
    public void ClearLevelProgress()
    {
        bool val_2 = static_value_021F9CC2;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        string val_1 = this.GetExtraRequiredWordsProgressPrefKey();
        CPlayerPrefs.DeleteKey(key:  1);
    }
    public void TryShowWordDefinition(Cell selectedCell)
    {
        var val_8;
        Player val_1 = App.Player;
        val_8 = 0;
        if(val_8 < 3)
        {
                return;
        }
        
        MainController val_2 = MainController.instance;
        val_8 = 0;
        if(3 != 0)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        val_8 = mem[val_5 + 20];
        val_8 = val_5 + 20;
        bool val_6 = val_8.Contains(item:  selectedCell);
        if(val_6 == true)
        {
                val_6 = mem[val_5 + 32];
            val_6 = val_5 + 32;
        }
        
        if(val_6 == 0)
        {
            goto label_13;
        }
        
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        displayDefinition(word:  val_5 + 12, flyout:  false);
        label_10:
        Dispose();
    }
    protected void SetupHackedWordsLists(System.Collections.Generic.List<string> wordList)
    {
        string val_6;
        System.Collections.Generic.List<System.String> val_11;
        float val_12;
        System.Collections.Generic.List<ZooTile> val_13;
        System.Collections.Generic.List<System.String> val_14;
        var val_15;
        val_11 = wordList;
        val_12 = 1152921511120667904;
        System.Collections.Generic.List<T> val_1 = CUtils.BuildListFromString<System.String>(values:  this.gameLevel.answers, split:  '|');
        this.Hack_EssentialWords = this.gameLevel.answers;
        val_13 = 1152921504687730688;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.Hack_ExtraWords = null;
        if(this.validWordsIncluded == false)
        {
            goto label_19;
        }
        
        System.Collections.Generic.List<T> val_3 = CUtils.BuildListFromString<System.String>(values:  this.gameLevel.extraWords, split:  '|');
        val_13 = this.gameLevel.extraWords;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_14 = 1152921510891363008;
        val_15 = 1152921510929906144;
        val_11 = 1152921510046813136;
        label_13:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        if((this.Hack_EssentialWords.Contains(item:  val_6)) == true)
        {
            goto label_13;
        }
        
        this.Hack_ExtraWords.Add(item:  val_6);
        goto label_13;
        label_9:
        Dispose();
        return;
        label_19:
        val_15 = 1152921511111006592;
         = new System.Collections.Generic.List<ZooTile>(collection:  null);
        val_14 = this.validWords;
        this.Hack_EssentialWords = ;
        this.Hack_ExtraWords = new System.Collections.Generic.List<ZooTile>(collection:  val_14);
    }
    protected bool IsSpellableWord(string letters, string word)
    {
        string val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = letters;
        string val_1 = val_11.Trim();
        System.Collections.Generic.List<T> val_2 = CUtils.BuildListFromString<System.String>(values:  val_11, split:  '|');
        if(letters.m_firstChar <= '')
        {
                val_11.Clear();
            string val_3 = val_11.Trim();
            val_12 = letters.m_stringLength;
            if(val_12 >= 1)
        {
                val_13 = 1152921510046813136;
            do
        {
            string val_5 = val_11.Chars[0].ToString();
            val_11.Add(item:  -2058760374);
            val_14 = 0 + 1;
        }
        while(val_12 != val_14);
        
        }
        
        }
        
        string val_6 = word.Trim();
        val_15 = 1;
        if(word.m_stringLength < 1)
        {
                return (bool)val_15;
        }
        
        val_14 = 0;
        val_13 = 1152921510929906144;
        label_19:
        string val_8 = word.Chars[0].ToString();
        val_12 = ;
        if((val_11.Contains(item:  -2058760374)) == false)
        {
            goto label_17;
        }
        
        bool val_10 = val_11.Remove(item:  -2058760374);
        val_14 = val_14 + 1;
        if(val_14 < word.m_stringLength)
        {
            goto label_19;
        }
        
        val_15 = 1;
        return (bool)val_15;
        label_17:
        val_15 = 0;
        return (bool)val_15;
    }
    public virtual void Hack_GrantWord()
    {
        var val_6;
        System.Collections.Generic.List<System.String> val_7;
        if(true >= 1)
        {
                if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_1 = 2621443.ToUpper();
            val_6 = this;
            this.Hack_hackedWord = 2621443;
            val_7 = this.Hack_ExtraWords;
        }
        else
        {
                if(true < 1)
        {
                return;
        }
        
            if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_2 = 2621443.ToUpper();
            string val_3 = 2621443.Replace(oldValue:  -2063697616, newValue:  1098586544);
            val_6 = this;
            this.Hack_hackedWord = 2621443;
            val_7 = this.Hack_EssentialWords;
        }
        
        val_7.RemoveAt(index:  0);
        string val_4 = -2058635648(-2058635648) + 2621443 + -2058635760(-2058635760);
        UnityEngine.Debug.LogWarning(message:  -2058635648);
        goto typeof(WordRegion).__il2cppRuntimeField_10C;
    }
    public virtual void Hack_CompleteLevel()
    {
        goto typeof(WordRegion).__il2cppRuntimeField_154;
    }
    public virtual void Hack_CompleteLevel(bool notifyLevelCompleteImmediately)
    {
        string val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        string val_4 = val_3.ToUpper();
        string val_5 = val_3.Replace(oldValue:  -2063697616, newValue:  1098586544);
        this.NotifyWordSubmitted(word:  val_3, valid:  true, isExtra:  false);
        goto label_5;
        label_2:
        Dispose();
        if(notifyLevelCompleteImmediately != false)
        {
                MainController val_6 = MainController.instance;
            this.NotifyBeforeLevelComplete(level:  this.gameLevel);
            this.NotifyLevelComplete(level:  this.gameLevel);
            return;
        }
        
        if(this.levelCompleteCoroutine != 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_7 = this.DoLevelCompleteActions();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -2058346560);
        this.levelCompleteCoroutine = this;
    }
    public WordRegion()
    {
        var val_6;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.canHint = true;
        this.validWords = null;
        val_6 = null;
        val_6 = null;
        this.onWordFound = new UnityEngine.Events.UnityEvent();
        this.onExtraWordFound = new UnityEngine.Events.UnityEvent();
        this.baseScale = 1f;
        System.Collections.Generic.HashSet<System.Int32Enum> val_4 = new System.Collections.Generic.HashSet<System.Int32Enum>();
        this.levelCompleteBlockers = null;
        this.onBeforeLevelComplete = new UnityEngine.Events.UnityEvent();
    }
    private static WordRegion()
    {
    
    }
    private int <LoadCoroutine>b__70_1(string x)
    {
        string val_1 = this.ScrubStar(word:  x);
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    private string <LoadCoroutine>b__70_2(string x)
    {
        return this.ScrubStar(word:  x);
    }
    private bool <DoLevelCompleteActions>b__85_0()
    {
        bool val_1 = this.levelCompleteBlocked;
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }

}
