using UnityEngine;
public class ExtraWord : MonoBehaviour
{
    // Fields
    private bool EXTAWORD_LENGTH_RESTRICT;
    public System.Collections.Generic.List<string> extraWordsFound;
    public UnityEngine.Transform beginPoint;
    public UnityEngine.Transform endPoint;
    public UnityEngine.GameObject lightEffect;
    public UnityEngine.GameObject lightOpenEffect;
    private int world;
    private int subWorld;
    private int level;
    private System.Collections.Generic.Queue<UnityEngine.UI.Text> flyTexts;
    public static ExtraWord instance;
    public UnityEngine.Animator extraWordAnimator;
    public UnityEngine.ParticleSystem extraWordParticles;
    public const string GAMETYPE_DAILY_CHALLENGE = "dailychallenge";
    public const string GAMETYPE_CATEGORY_LEVELS = "categorylevels";
    private ExtraWordGameplayIcon extraWordGameplayIcon;
    private WGGameplayMessage gameplayMessage;
    private UnityEngine.Transform flyToGoldenAppleBeginPoint;
    private UnityEngine.Transform flyToGoldenAppleEndPoint;
    private UnityEngine.GameObject flyToGoldenAppleParticleObject;
    private bool hasViewedWordList;
    public System.Action<int> OnExtraWordAdded;
    private GameLevel currentLevel;
    
    // Properties
    public static bool HasViewedWordList { get; set; }
    public static int ApplesFromExtra { get; }
    public static int ApplesFromExtraBonus { get; }
    
    // Methods
    public static bool get_HasViewedWordList()
    {
        if(ExtraWord.GAMETYPE_CATEGORY_LEVELS == 0)
        {
                return true;
        }
        
        if((ExtraWord.GAMETYPE_CATEGORY_LEVELS + 80) != 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static void set_HasViewedWordList(bool value)
    {
        if(ExtraWord.GAMETYPE_CATEGORY_LEVELS == 0)
        {
                return;
        }
        
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.__unknownFiledOffset_50 = value;
    }
    public static int get_ApplesFromExtra()
    {
        var val_2 = 0;
        if(ExtraWord.GAMETYPE_CATEGORY_LEVELS == 0)
        {
                return (int)val_2;
        }
        
        if((ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88) == 0)
        {
                return (int)val_2;
        }
        
        val_2 = mem[ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88 + 32];
        val_2 = ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88 + 32;
        return (int)val_2;
    }
    public static int get_ApplesFromExtraBonus()
    {
        var val_2 = 0;
        if(ExtraWord.GAMETYPE_CATEGORY_LEVELS == 0)
        {
                return (int)val_2;
        }
        
        if((ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88) == 0)
        {
                return (int)val_2;
        }
        
        val_2 = mem[ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88 + 36];
        val_2 = ExtraWord.GAMETYPE_CATEGORY_LEVELS + 88 + 36;
        return (int)val_2;
    }
    private void Awake()
    {
        ExtraWord.GAMETYPE_CATEGORY_LEVELS = this;
    }
    private void Start()
    {
        var val_16;
        UnityEngine.Events.UnityAction val_19;
        this.world = Prefs.currentWorld;
        this.subWorld = Prefs.currentChapter;
        this.level = Prefs.currentLevel;
        ExtraWord.HasViewedWordList = false;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_4;
        }
        
        val_16 = "dailychallenge";
        goto label_5;
        label_4:
        if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_8;
        }
        
        val_16 = "categorylevels";
        label_5:
        System.String[] val_7 = Prefs.GetExtraWordsEvents(gameType:  -2094123824);
        goto label_9;
        label_8:
        System.String[] val_8 = Prefs.GetExtraWords(world:  mem[this.world + (0)], subWorld:  mem[this.world + (4)], level:  mem[this.world + (8)]);
        label_9:
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<System.Object>(source:  mem[this.world + (0)]);
        this.extraWordsFound = null;
        WordRegion val_10 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -2094096656, method:  new IntPtr(2200843568));
        0.addOnLevelLoadedAction(callback:  7401472);
        val_19 = 1152921504885600256;
        MainController val_12 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_14 = MainController.instance;
            val_19 = null;
            val_19 = new UnityEngine.Events.UnityAction(object:  -2094096656, method:  new IntPtr(2200845616));
            1.AddListener(call:  162246656);
        }
        
        this.UpdateUI();
    }
    private void OnLevelLoaded(GameLevel gamelevel)
    {
        this.currentLevel = gamelevel;
        gamelevel.goldenApplesExtraWords = this;
    }
    private void OnLevelComplete()
    {
        if(this.lightOpenEffect != 0)
        {
                this.lightOpenEffect.SetActive(value:  false);
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                0 = this;
            this.AwardGoldenApples();
        }
        
        if(CategoryPacksManager.IsPlaying == false)
        {
                return;
        }
        
        ExtraWord.ClearEventExtraWordProgress(gameTypeId:  -2094123824);
    }
    private void UpdateUI()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        val_5 = 0;
        if(Prefs.extraProgress >= Prefs.extraTarget)
        {
                if(Prefs.extraTarget > 0)
        {
                val_5 = 1;
        }
        
        }
        
        this.lightOpenEffect.SetActive(value:  true);
    }
    public bool ProcessWord(string word, System.Collections.Generic.List<LineWord> lines, bool isWord)
    {
        float val_7;
        float val_8;
        var val_11;
        var val_12;
        var val_13;
        ExtraWord val_39;
        float val_40;
        string val_41;
        ExtraWord val_42;
        var val_43;
        float val_45;
        var val_46;
        var val_47;
        WGGameplayMessage val_48;
        val_39 = this;
        val_40 = lines;
        val_41 = word;
        if((this.extraWordsFound.Contains(item:  val_41)) == false)
        {
            goto label_2;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_43 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  8, oneshot:  true, pitch:  null, vol:  null);
        if((this.gameplayMessage.<isMessageShowing>k__BackingField) == true)
        {
                return (bool)val_43;
        }
        
        val_43 = 0;
        string val_3 = Localization.Localize(key:  -2093615168, defaultValue:  -2093615312, useSingularKey:  false);
        label_70:
        bool val_4 = this.gameplayMessage.ShowMessage(message:  -2093615168, showLetterNo:  false, letterCount:  0);
        return (bool)val_43;
        label_2:
        val_43 = 0;
        if(word.m_stringLength < 3)
        {
                return (bool)val_43;
        }
        
        if(isWord == true)
        {
            goto label_13;
        }
        
        label_63:
        if(isWord == false)
        {
                return (bool)val_43;
        }
        
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.Vector3 val_10 = CUtils.GetMiddlePoint(begin:  new UnityEngine.Vector3() {x = -5.361464E-37f}, end:  new UnityEngine.Vector3() {y = val_8, z = val_7}, delta:  val_6.x);
        val_40 = null;
        UnityEngine.Vector3 val_14 = position;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C = val_11;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_12;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_13;
        UnityEngine.Vector3 val_15 = position;
        val_45 = 1152921504887676928;
        object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  208465920);
        if(MonoUtils.instance.letter == 0)
        {
            goto label_72;
        }
        
        val_42 = MonoUtils.instance.letter;
        UnityEngine.Transform val_17 = transform;
        UnityEngine.Vector3 val_18 = position;
        position = new UnityEngine.Vector3();
        UnityEngine.Transform val_19 = transform;
        SetParent(p:  160649216);
        UnityEngine.Transform val_20 = transform;
        UnityEngine.Transform val_21 = transform;
        UnityEngine.Vector3 val_22 = localScale;
        localScale = new UnityEngine.Vector3();
        mem[1152921511103209568].Enqueue(item:  208465920);
        val_39 = val_41;
        UnityEngine.GameObject val_23 = gameObject;
        UnityEngine.Transform val_24 = transform;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_25 = DG.Tweening.ShortcutExtensions.DOPath(target:  208465920, path:  533912224, duration:  val_22.x, pathType:  1050253722, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        DG.Tweening.TweenCallback val_26 = new DG.Tweening.TweenCallback(object:  -2093572048, method:  new IntPtr(2201366592));
        object val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  208465920, action:  190734336);
        this.AddNewExtraWord(word:  val_39);
        WordPets.WPTDataParser val_28 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_30 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnExtraWordFound();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_43 = 1;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  7, oneshot:  true, pitch:  val_22.x, vol:  val_22.y);
        return (bool)val_43;
        label_13:
        List.Enumerator<T> val_32 = GetEnumerator();
        label_57:
        if(MoveNext() == false)
        {
            goto label_54;
        }
        
        val_45 = val_41;
        val_41 = val_45;
        if(word.m_stringLength != (val_34 + 12 + 8))
        {
            goto label_57;
        }
        
        val_40 = 1152921511103183936;
        Dispose();
        List.Enumerator<T> val_35 = GetEnumerator();
        val_39 = val_39;
        label_62:
        if(MoveNext() == false)
        {
            goto label_59;
        }
        
        if((val_34 + 12 + 8) == word.m_stringLength)
        {
                word.m_stringLength = mem[val_34 + 32];
            word.m_stringLength = val_34 + 32;
        }
        
        if(word.m_stringLength != 0)
        {
            goto label_62;
        }
        
        Dispose();
        goto label_63;
        label_54:
        Dispose();
        val_42 = val_39;
        val_43 = 0;
        if((this.gameplayMessage.<isMessageShowing>k__BackingField) == true)
        {
                return (bool)val_43;
        }
        
        val_46 = "There are no {0}-letter required words!";
        val_47 = "extra_word_flyout_no_req";
        val_48 = this.gameplayMessage;
        goto label_66;
        label_59:
        Dispose();
        label_77:
        val_43 = 0;
        if((this.gameplayMessage.<isMessageShowing>k__BackingField) != false)
        {
                return (bool)val_43;
        }
        
        val_46 = "All {0}-letter words already found!";
        val_47 = "extra_word_flyout_found_all";
        val_48 = this.gameplayMessage;
        label_66:
        string val_37 = Localization.Localize(key:  -2093596176, defaultValue:  -2093596320, useSingularKey:  false);
        string val_38 = System.String.Format(format:  -2093596176, arg0:  13152256);
        if(val_48 != 0)
        {
            goto label_70;
        }
        
        goto label_70;
        label_72:
        if((public static UnityEngine.UI.Text UnityEngine.Object::Instantiate<UnityEngine.UI.Text>(UnityEngine.UI.Text original)) != 1)
        {
            goto label_78;
        }
        
        Dispose();
        if(null == 0)
        {
            goto label_77;
        }
        
        goto label_77;
        label_78:
    }
    public void CheckRequiredExtraWord(string word)
    {
        Player val_2 = App.Player;
        var val_5 = 0;
        val_5 = val_5 - (UnityEngine.PlayerPrefs.GetInt(key:  -2093451280, defaultValue:  0));
        if(val_5 < 20)
        {
                return;
        }
        
        Player val_3 = App.Player;
        if(0 > 199)
        {
                return;
        }
        
        this.DisplayDefinitionFlyout();
        Player val_4 = App.Player;
        UnityEngine.PlayerPrefs.SetInt(key:  -2093451280, value:  0);
    }
    public void DisplayDefinitionFlyout()
    {
        string val_1 = Localization.Localize(key:  -2093334928, defaultValue:  -2093335072, useSingularKey:  false);
        bool val_2 = this.gameplayMessage.ShowMessage(message:  -2093334928, showLetterNo:  false, letterCount:  0);
    }
    public void AddNewExtraWord(string word)
    {
        System.Collections.Generic.List<System.String> val_10;
        System.String[] val_11;
        var val_12;
        val_10 = this.extraWordsFound;
        val_10.Add(item:  word);
        if(this.currentLevel != 0)
        {
                this.currentLevel.goldenApplesExtraWords = val_10;
            val_10 = this.currentLevel;
            this.currentLevel.goldenApplesExtraWordsSubBonus = WGSubscriptionManager.GetAdditionalPoints(basePoints:  val_10);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  -2093190032, context:  -2093145392);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_12;
        }
        
        T[] val_4 = this.extraWordsFound.ToArray();
        val_11 = this.extraWordsFound;
        val_12 = "dailychallenge";
        goto label_14;
        label_12:
        if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_17;
        }
        
        T[] val_6 = this.extraWordsFound.ToArray();
        val_11 = this.extraWordsFound;
        val_12 = "categorylevels";
        label_14:
        Prefs.SetExtraWordsEvents(gameType:  -2094123824, extraWords:  val_11);
        goto label_19;
        label_17:
        val_10 = this.subWorld;
        T[] val_7 = this.extraWordsFound.ToArray();
        Prefs.SetExtraWords(world:  this.world, subWorld:  val_10, level:  this.level, extraWords:  this.extraWordsFound);
        label_19:
        int val_8 = Prefs.extraProgress;
        val_8 = val_8 + 1;
        Prefs.extraProgress = val_8;
        int val_9 = Prefs.totalExtraAdded;
        val_9 = val_9 + 1;
        Prefs.totalExtraAdded = val_9;
        if(this.OnExtraWordAdded == 0)
        {
                return;
        }
        
        this.OnExtraWordAdded.Invoke(obj:  0);
    }
    public static void ClearEventExtraWordProgress(string gameTypeId)
    {
        if((System.String.IsNullOrEmpty(value:  gameTypeId)) == true)
        {
                return;
        }
        
        Prefs.SetExtraWordsEvents(gameType:  R4, extraWords:  477709520);
    }
    private void AwardGoldenApples()
    {
        System.Collections.Generic.List<System.String> val_14;
        var val_15;
        var val_16;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        val_14 = 13161636 + 22464151;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(App.game == 18)
        {
                return;
        }
        
        val_14 = this.extraWordsFound;
        if(App.game >= 1)
        {
                var val_14 = 0;
            Player val_3 = App.Player;
            val_14 = val_14 + static_value_00280154;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            int val_5 = ExtraWord.ApplesFromExtra;
            Add(key:  -2092883952, value:  13152256);
            val_16 = ExtraWord.ApplesFromExtra;
            if(GoldenMultiplierManager.IsAvaialable != true)
        {
                if(ExtraWord.ApplesFromExtraBonus >= 1)
        {
                int val_9 = ExtraWord.ApplesFromExtraBonus;
            Add(key:  -2092883856, value:  13152256);
            val_16 = ExtraWord.ApplesFromExtraBonus + val_16;
        }
        
        }
        
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        if(GoldenMultiplierManager.IsAvaialable == true)
        {
                return;
        }
        
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -2092858528, aName:  -2092882624);
    }
    private void OnTextMoveToComplete()
    {
        UnityEngine.UI.Text val_15;
        object val_1 = new System.Object();
        this.UpdateUI();
        if(this.lightOpenEffect != 0)
        {
                if(this.lightOpenEffect.activeSelf != true)
        {
                this.lightEffect.SetActive(value:  true);
            UnityEngine.Transform val_4 = this.lightEffect.transform;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.lightEffect, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  null, mode:  1053609165);
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  -2092698304, method:  new IntPtr(2202221344));
            object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.lightEffect, action:  190734336);
        }
        
        }
        
        if(this.extraWordAnimator != 0)
        {
                this.extraWordAnimator.SetTrigger(name:  -2092736736);
        }
        
        if(this.extraWordParticles != 0)
        {
                this.extraWordParticles.Play();
        }
        
        UnityEngine.UI.Text val_11 = this.flyTexts.Dequeue();
        if(val_1 != 0)
        {
                val_15 = val_1;
            typeof(ExtraWord.<>c__DisplayClass41_0).__il2cppRuntimeField_8 = this.flyTexts;
        }
        else
        {
                val_15 = 8;
            mem[8] = this.flyTexts;
        }
        
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_15, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  279072768, method:  new IntPtr(2202243968));
        object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_15, action:  190734336);
    }
    private void OnLightRotateComplete()
    {
        this.lightEffect.SetActive(value:  false);
    }
    public void OnClaimed()
    {
        this.UpdateUI();
    }
    public ExtraWord()
    {
        GameBehavior val_1 = App.getBehavior;
        this.EXTAWORD_LENGTH_RESTRICT = false;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.extraWordsFound = null;
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_3 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.flyTexts = null;
    }

}
