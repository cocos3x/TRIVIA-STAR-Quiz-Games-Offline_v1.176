using UnityEngine;
public class WGDailyChallengeMainController : MainController
{
    // Fields
    private UnityEngine.GameObject progress_bar_group;
    private UnityEngine.RectTransform progress_bar_image;
    private UnityEngine.GameObject starPrefab;
    private UnityEngine.RectTransform progress_bar;
    private UnityEngine.UI.Text progress_bar_text;
    private WGGameplayMessage gameplayMessage;
    private DailyChallengeDefinition challengeDefinition;
    private DailyChallengeStarGroup starGroup;
    
    // Properties
    public static WGDailyChallengeMainController SpecificInstance { get; }
    public UnityEngine.GameObject GetProgressBarGroup { get; }
    
    // Methods
    public static WGDailyChallengeMainController get_SpecificInstance()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(MainController.extra_words_prefs_key == 0)
        {
                object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
            val_4 = null;
            val_4 = null;
            MainController.extra_words_prefs_key = public static WGDailyChallengeMainController UnityEngine.Object::FindObjectOfType<WGDailyChallengeMainController>();
        }
        
        val_5 = null;
        val_5 = null;
    }
    public UnityEngine.GameObject get_GetProgressBarGroup()
    {
    
    }
    private void Start()
    {
        this.OnStartLogic();
    }
    private void OnStartLogic()
    {
        float val_8;
        bool val_42;
        WGDailyChallengeMainController val_43;
        float val_44;
        UnityEngine.Transform val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        float val_50;
        var val_51;
        val_42 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_3 = CurrentLevel;
        val_43 = this;
        mem[1152921513103175316] = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_C;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem[1152921513103175464] = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20;
        if(mem[1152921513103175324] != 0)
        {
                val_44 = 1152921504892043264;
            val_45 = 8920716 + 26705071;
            if(val_45 == 0)
        {
                mem2[0] = 1;
        }
        
            val_46 = null;
            val_46 = null;
            val_42 = 1;
            if(App.game != 1)
        {
                if(val_45 == 0)
        {
                mem2[0] = 1;
        }
        
            val_47 = null;
            val_47 = null;
            if(App.game != 10)
        {
                if(val_45 == 0)
        {
                mem2[0] = 1;
        }
        
            val_48 = null;
            val_48 = null;
            if(App.game != 7)
        {
                if(val_45 == 0)
        {
                mem2[0] = 1;
        }
        
            val_49 = null;
            val_49 = null;
            GameNames val_41 = App.game;
            val_41 = val_41 - 4;
            val_42 = val_41 >> 5;
        }
        
        }
        
        }
        
            mem[1152921513103175324].SetActive(value:  val_42);
        }
        
        object val_6 = mem[1152921513103175440].GetComponent<System.Object>();
        UnityEngine.Vector2 val_7 = sizeDelta;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        WGDailyChallengeWordRegion.anim_delay = null;
        object val_10 = mem[1152921513103175440].GetComponentInChildren<System.Object>();
        val_50 = 0.5f;
        mem[1152921513103175468] = mem[1152921513103175440];
        val_51 = 0;
        float val_11 = val_8 * val_50;
        mem[1152921513103175440].SetActive(value:  true);
        this.UpdateProgressBar(delay:  val_15.x);
        if(mem[1152921513103175316] == 0)
        {
            goto label_60;
        }
        
        WordRegion val_22 = WordRegion.instance;
        val_45 = 1152921504614301696;
        System.Action val_23 = new System.Action(object:  Pan.tappingAllowed, method:  new IntPtr(2193926176));
        0.addOnLevelLoadCompleteAction(callback:  7454720);
        Pan.tappingAllowed.Load(gameLevel:  mem[1152921513103175316]);
        WordRegion val_24 = WordRegion.instance;
        val_44 = null;
        val_44 = new System.Action(object:  -93606272, method:  new IntPtr(4201334976));
        string val_26 = this.GetLevelWord();
        this.TrackLevelGenerationLevelStart(levelWord:  -93606272);
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnDailyChallengeInit();
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513103175332])) != false)
        {
                mem[1152921513103175332].SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513103175340])) != false)
        {
                mem[1152921513103175340].SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513103175344])) != false)
        {
                val_42 = GoldenMultiplierManager.IsAvaialable;
            mem[1152921513103175344].SetActive(value:  val_42 ^ 1);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513103175348])) != false)
        {
                val_42 = GoldenMultiplierManager.IsAvaialable;
            mem[1152921513103175348].SetActive(value:  val_42);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513103175336])) == false)
        {
            goto label_87;
        }
        
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_88;
        }
        
        string val_37 = WGDailyChallengeManagerHelper.GetLocMorningChallenge();
        goto label_89;
        label_60:
        mem[1152921513103175316].FailedLoadingLevelData();
        return;
        label_88:
        string val_38 = WGDailyChallengeManagerHelper.GetLocEveningChallenge();
        label_89:
        label_87:
        twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_40 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -2116505760, method:  new IntPtr(4201336000));
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
    }
    private void CheckDailyChallengeValidity()
    {
        var val_9;
        System.Func<LineWord, System.Boolean> val_11;
        WordRegion val_1 = WordRegion.instance;
        val_9 = null;
        val_9 = null;
        val_11 = WGDailyChallengeMainController.<>c.<>9__14_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGDailyChallengeMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4201449024));
            WGDailyChallengeMainController.<>c.<>9__14_0 = val_11;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  0, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
        if(0 != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_6 = CurrentLevel;
        UnityEngine.Debug.LogWarning(message:  -93517248);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_8 = CurrentLevel;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_18 = 0;
        this.UpdateProgressBar(delay:  null);
    }
    public void UpdateProgressBar(float delay = 0)
    {
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_4 = GetProgressPercentage();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_6 = GetNextProgressTarget();
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) > 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleStarProgress();
        }
        
        DG.Tweening.Core.DOGetter<UnityEngine.Vector2> val_8 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  -93369808, method:  new IntPtr(4201566320));
        DG.Tweening.Core.DOSetter<UnityEngine.Vector2> val_9 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  -93369808, method:  new IntPtr(4201567344));
        float val_10 = 4201585432 * 2178461536;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_10, y:  val_1.m_YMin);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, duration:  val_10);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  val_10);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_15 = CurrentLevel;
        this.starGroup.Setup(stars:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_14);
    }
    public void SetLevelComplete()
    {
        mem[1152921513103531968] = 1;
    }
    public override void OnComplete()
    {
        static_value_021FB076.Invoke();
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnDailyChallengeComplete();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnDailyChallengeLevelComplete();
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  -93136592, method:  new IntPtr(4201805680));
        DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1071644672, ignoreTimeScale:  false);
    }
    private void FailedLoadingLevelData()
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_9 = 26706807;
        val_9 = 8924424 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_68 = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -93048592, defaultValue:  -93048464, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        val_11 = WGDailyChallengeMainController.<>c.<>9__18_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  WGDailyChallengeMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4201919024));
            WGDailyChallengeMainController.<>c.<>9__18_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  2129276784, messageTxt:  -93048592, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public override void OnLevelClearClosed()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = CurrentChallengeComplete();
        if(val_2 == true)
        {
                2 = 1;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(val_2 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_9 = 26702823;
            val_9 = 8928408 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_68 = 0;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_8 = ShowInterstitial(context:  2);
    }
    public void ShowMessage(string message)
    {
        if(this.gameplayMessage == 0)
        {
                return;
        }
        
        bool val_2 = this.gameplayMessage.ShowMessage(message:  message, showLetterNo:  false, letterCount:  0);
    }
    public WGDailyChallengeMainController()
    {
    
    }
    private UnityEngine.Vector2 <UpdateProgressBar>b__15_0()
    {
        UnityEngine.Vector2 val_1 = this.sizeDelta;
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    private void <UpdateProgressBar>b__15_1(UnityEngine.Vector2 x)
    {
        this.progress_bar.sizeDelta = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }
    private void <OnComplete>b__17_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnChallengeCompleted();
        this.progress_bar_group.SetActive(value:  false);
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
                return;
        }
        
        WGGenericNotificationsManager.CancelDailyChallengeNotification();
    }

}
