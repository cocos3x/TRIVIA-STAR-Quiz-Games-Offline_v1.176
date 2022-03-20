using UnityEngine;
public class LevelCompletePopup : MonoBehaviour
{
    // Fields
    protected WGLevelClearPopup levelClearPopup;
    protected WGChapterClearPopup chapterClearPopup;
    private WordIQLevelCompleteDisplayAnim iqDisplayAnim;
    private ChapterBookLevelCompleteDisplay chapterBookLevelComplete;
    protected UnityEngine.CanvasGroup rootCanvasGroup;
    private UnityEngine.CanvasGroup allUpperUI;
    private UnityEngine.CanvasGroup allLowerUI;
    private LevelCompleteGoldenApplesUI goldenApplesGroup;
    private UnityEngine.RectTransform categoryInfoDisplayContainer;
    private CategoryPackCompleteDisplay catPackCompleteDisplayPrefab;
    private GoldenCurrencyCollectAnimationInstantiator appleCollector;
    private UnityEngine.GameObject group_goldenApplesDisplay;
    private UnityEngine.UI.Text goldenApplesBonus;
    private UnityEngine.UI.Button difficultySettingButton;
    private UnityEngine.UI.Text goldenMultiplierBonusApples;
    private UnityEngine.GameObject goldenMultiplierGroup;
    private TournamentsButton tournamentsButton;
    private CategoryPackCompleteDisplay catPackCompleteDisplayInstance;
    
    // Properties
    public UnityEngine.CanvasGroup RootCanvasGroup { get; }
    public GoldenCurrencyCollectAnimationInstantiator AppleCollector { get; }
    
    // Methods
    public UnityEngine.CanvasGroup get_RootCanvasGroup()
    {
    
    }
    public GoldenCurrencyCollectAnimationInstantiator get_AppleCollector()
    {
    
    }
    public virtual void OnEnable()
    {
        System.Action<System.Boolean> val_19;
        bool val_20;
        System.Action<System.Boolean> val_21;
        val_19 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                this.iqDisplayAnim.Setup();
        }
        
        this.Invoke(methodName:  -247212400, time:  null);
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                UnityEngine.GameObject val_3 = this.chapterBookLevelComplete.gameObject;
            this.chapterBookLevelComplete.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.categoryInfoDisplayContainer.gameObject;
            this.categoryInfoDisplayContainer.SetActive(value:  true);
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.catPackCompleteDisplayPrefab, parent:  this.categoryInfoDisplayContainer);
            this.catPackCompleteDisplayInstance = this.catPackCompleteDisplayPrefab;
            this.catPackCompleteDisplayPrefab.levelCompletePopup = this;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_20 = IsPackNewlyCompleted;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_2C) != 0)
        {
                val_19 = 1;
        }
        
            this.catPackCompleteDisplayInstance.Show(isChapterComplete:  true, isPackComplete:  val_20);
        }
        else
        {
                val_20 = 1152921504765685760;
            if(this.chapterBookLevelComplete != 0)
        {
                UnityEngine.GameObject val_10 = this.chapterBookLevelComplete.gameObject;
            this.chapterBookLevelComplete.SetActive(value:  true);
            Player val_11 = App.Player;
            val_19 = 0;
            this.chapterBookLevelComplete.Display(currentPlayerLevel:  0, secondsBeforeDisplay:  null);
        }
        
            if(this.categoryInfoDisplayContainer != 0)
        {
                UnityEngine.GameObject val_13 = this.categoryInfoDisplayContainer.gameObject;
            this.categoryInfoDisplayContainer.SetActive(value:  false);
        }
        
        }
        
        if(GoldenMultiplierManager.IsAvaialable != false)
        {
                this.SetupGoldenMultiplierUI();
        }
        else
        {
                if(this.goldenApplesGroup != 0)
        {
                this.goldenApplesGroup.SetupDifficultySettingUI();
            this.goldenApplesGroup.SetupPetsUI();
        }
        else
        {
                this.SetupDifficultySettingUI();
        }
        
        }
        
        if(this.tournamentsButton == 0)
        {
                return;
        }
        
        val_20 = this.tournamentsButton;
        val_19 = null;
        val_19 = new System.Action<System.Boolean>(object:  -247128896, method:  new IntPtr(4047813376));
        System.Delegate val_18 = System.Delegate.Combine(a:  this.tournamentsButton.ExternalClickCallback, b:  7401472);
        val_21 = this.tournamentsButton.ExternalClickCallback;
        if(val_21 != 0)
        {
                if(null == null)
        {
            goto label_50;
        }
        
        }
        
        val_21 = 0;
        label_50:
        this.tournamentsButton.ExternalClickCallback = val_21;
    }
    public virtual void ShowWithEffects()
    {
        bool val_12;
        bool val_13;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_2C) != 0)
        {
                val_12 = 1;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = IsPackNewlyCompleted;
            val_4 = val_4 ^ 1;
            val_13 = 1 & val_4;
        }
        else
        {
                Player val_5 = App.Player;
            val_12 = ChapterBookLogic.ShowChapterComplete(playerLevel:  0);
            Player val_7 = App.Player;
            val_13 = (ChapterBookLogic.ShowBookComplete(playerLevel:  0)) ^ 1;
        }
        
        this.chapterClearPopup.Setup(shouldBeShowing:  val_12, showRewards:  val_13);
        this.levelClearPopup.Setup(shouldBeShowing:  val_12 ^ 1);
    }
    public virtual void HandleWindowClose(bool chapterClear)
    {
        var val_18;
        var val_19;
        float val_20;
        System.Action<System.Boolean> val_21;
        System.Action<System.Boolean> val_22;
        var val_23;
        val_18 = chapterClear;
        val_19 = 1152921504765685760;
        if(this.tournamentsButton == 0)
        {
            goto label_3;
        }
        
        val_20 = 1152921504614248448;
        val_21 = null;
        val_21 = new System.Action<System.Boolean>(object:  -246814784, method:  new IntPtr(4047813376));
        System.Delegate val_3 = System.Delegate.Remove(source:  this.tournamentsButton.ExternalClickCallback, value:  7401472);
        val_22 = this.tournamentsButton.ExternalClickCallback;
        if(val_22 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_22 = 0;
        label_7:
        this.tournamentsButton.ExternalClickCallback = val_22;
        label_3:
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -246814784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPackCompleted(packId:  0)) == false)
        {
            goto label_14;
        }
        
        MainController val_8 = MainController.instance;
        0.OnCategoryPackCompletedClosed();
        goto label_23;
        label_14:
        if(val_18 != false)
        {
                MainController val_10 = MainController.instance;
            0.OnChapterClearClosed();
        }
        else
        {
                MainController val_11 = MainController.instance;
        }
        
        label_23:
        val_23 = 1152921511095697248;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_15 = App.getBehavior;
            if(0 != 0)
        {
            goto mem[1179404171];
        }
        
        }
        else
        {
                var val_16 = FP - 28;
        }
    
    }
    public void HideLowerUI(float fadeOutDuration = 0.5, float delay = 0)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.allLowerUI, endValue:  fadeOutDuration, duration:  delay);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.allLowerUI, delay:  fadeOutDuration);
    }
    public void HideUpperUI(float fadeOutDuration = 0.5, float delay = 0)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.allUpperUI, endValue:  fadeOutDuration, duration:  delay);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.allUpperUI, delay:  fadeOutDuration);
    }
    public void ShowLowerUI(float fadeInDuration = 0.5, float delay = 0)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.allLowerUI, endValue:  fadeInDuration, duration:  delay);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.allLowerUI, delay:  fadeInDuration);
    }
    public void ShowUpperUI(float fadeInDuration = 0.5, float delay = 0)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.allUpperUI, endValue:  fadeInDuration, duration:  delay);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.allUpperUI, delay:  fadeInDuration);
    }
    public virtual void WaitAndPlayAnim()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                this.iqDisplayAnim.Play();
        }
        
        this.chapterClearPopup.PlayStartAnims();
        if(this.levelClearPopup == 0)
        {
            
        }
    
    }
    public void OpenStackingMonolith<T>()
    {
        var val_5;
        var val_6;
        this.HideSelfAndDontDestroy();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetComponent<System.Object>();
        val_6 = 0;
        System.Action val_3 = new System.Action(object:  -246073152, method:  new IntPtr(3921964816));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
        val_5 = null;
        val_6 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14;
        val_6 = 0;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_6;
    }
    public void HideSelfAndDontDestroy()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -245961152, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
    }
    public void RestoreHiddenSelf()
    {
        var val_3;
        System.Action val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = null;
        val_3 = null;
        val_5 = LevelCompletePopup.<>c.<>9__32_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Action(object:  LevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4049094144));
            LevelCompletePopup.<>c.<>9__32_0 = val_5;
        }
        
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  2119322896, callback:  7454720);
    }
    private void OnClick_DifficultySettingButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void SetupDifficultySettingUI()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1436585440) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = ToString();
        if((UnityEngine.Object.op_Implicit(exists:  this.appleCollector)) != false)
        {
                mem2[0] = 1;
        }
        
        this.group_goldenApplesDisplay.SetActive(value:  true);
        UnityEngine.GameObject val_10 = this.difficultySettingButton.gameObject;
        this.difficultySettingButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  -245594432, method:  new IntPtr(4049347840));
        this.difficultySettingButton.m_OnClick.AddListener(call:  162246656);
    }
    private void SetupGoldenMultiplierUI()
    {
        mem2[0] = 0;
        this.group_goldenApplesDisplay.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.IEnumerator val_2 = this.PlayGoldenCurrencyGet(amount:  public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().__il2cppRuntimeField_C);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -245445568);
    }
    private System.Collections.IEnumerator PlayGoldenCurrencyGet(int amount)
    {
        typeof(LevelCompletePopup.<PlayGoldenCurrencyGet>d__36).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LevelCompletePopup.<PlayGoldenCurrencyGet>d__36).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(LevelCompletePopup.<PlayGoldenCurrencyGet>d__36).__il2cppRuntimeField_14 = amount;
    }
    private void OnTournamentsClicked(bool isConnected)
    {
        var val_10;
        System.Action val_11;
        UnityEngine.GameObject val_12;
        var val_13;
        if(isConnected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_2 = App.getBehavior;
            mem[12] = 0;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = PlaceGameObject<System.Object>(loc:  0);
        val_10 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_11 = 0;
        UnityEngine.GameObject val_6 = this.tournamentsButton.gameObject;
        val_12 = this.tournamentsButton;
        val_13 = "Internet connection required. Please check your connection and try again!";
        ShowToolTip(objToToolTip:  null, text:  -1671479392, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
    }
    public LevelCompletePopup()
    {
    
    }

}
