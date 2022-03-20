using UnityEngine;
public class FPHGameplayUIController : MonoSingleton<FPHGameplayUIController>
{
    // Fields
    private UnityEngine.CanvasGroup topBarCanvasGroup;
    private UnityEngine.CanvasGroup topBarButtonsGroup;
    private FPHKeyboard keyBoard;
    private UnityEngine.GameObject banner;
    private UnityEngine.UI.Text bannerText;
    private FPHAnswerDisplay answerDisplay;
    private UnityEngine.CanvasGroup solveRowCanvasGroup;
    private FPHTokenDisplay tokenDisplay;
    private FPHIncorrectGuessDisplay incorrectGuessDisplay;
    private FPHLevelFailDisplay levelFailDisplay;
    private UnityEngine.UI.Button howToPlayButton;
    private UnityEngine.UI.Button leaguesButton;
    private UnityEngine.UI.Button eventsButton;
    private UnityEngine.UI.Button removeAdsButton;
    private UnityEngine.UI.Button freeGemsButton;
    private UnityEngine.UI.Button buttonSolve;
    private UnityEngine.UI.Button buttonExitSolve;
    private FPHPowerupButton buttonPowerupHint;
    private UnityEngine.UI.Image ootSolveButtonHighlight;
    private UnityEngine.UI.Text tutorialText;
    private UnityEngine.GameObject solveButtonTutorial;
    private FPHEcon econ;
    private DG.Tweening.Tween solveButtonHighlightTween;
    
    // Properties
    public FPHAnswerDisplay AnswerDisplay { get; }
    
    // Methods
    public FPHAnswerDisplay get_AnswerDisplay()
    {
    
    }
    private void Start()
    {
        System.Delegate val_15;
        var val_16;
        System.Delegate val_17;
        var val_18;
        var val_19;
        UnityEngine.Events.UnityAction val_20;
        var val_21;
        UnityEngine.Events.UnityAction val_23;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        this.econ = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  -1639069488, method:  new IntPtr(2655851280));
        val_15 = typeof(FPHGameplayController).__il2cppRuntimeField_14;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_15, b:  7401472);
        val_16 = val_15;
        if(val_16 == 0)
        {
            goto label_7;
        }
        
        val_15 = mem[typeof(FPHGameplayController).__il2cppRuntimeField_14];
        val_15 = val_16;
        if(val_15 == null)
        {
            goto label_8;
        }
        
        val_15 = val_16;
        label_7:
        val_16 = 0;
        label_8:
        typeof(FPHGameplayController).__il2cppRuntimeField_14 = val_16;
        FPHGameplayController val_5 = FPHGameplayController.Instance;
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -1639069488, method:  new IntPtr(2655852304));
        val_17 = typeof(FPHGameplayController).__il2cppRuntimeField_14 + 16;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_17, b:  7401472);
        val_18 = val_17;
        if(val_18 == 0)
        {
            goto label_11;
        }
        
        val_17 = mem[typeof(FPHGameplayController).__il2cppRuntimeField_14 + 16];
        val_17 = val_18;
        if(val_17 == null)
        {
            goto label_12;
        }
        
        val_17 = val_18;
        label_11:
        val_18 = 0;
        label_12:
        mem2[0] = val_18;
        FPHGameplayController val_8 = FPHGameplayController.Instance;
        System.Action val_9 = new System.Action(object:  -1639069488, method:  new IntPtr(2655853328));
        System.Delegate val_10 = System.Delegate.Combine(a:  typeof(FPHGameplayController).__il2cppRuntimeField_14 + 16 + 24, b:  7454720);
        val_19 = typeof(FPHGameplayController).__il2cppRuntimeField_14 + 16 + 24;
        if(val_19 != 0)
        {
                if(val_19 == null)
        {
            goto label_16;
        }
        
        }
        
        val_19 = 0;
        label_16:
        mem2[0] = val_19;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  -1639069488, method:  new IntPtr(2655854352));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.AddListener(call:  162246656);
        val_20 = null;
        val_20 = new UnityEngine.Events.UnityAction(object:  -1639069488, method:  new IntPtr(2655863568));
        this.buttonSolve.m_OnClick.AddListener(call:  162246656);
        val_21 = null;
        val_21 = null;
        val_23 = FPHGameplayUIController.<>c.<>9__25_0;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new UnityEngine.Events.UnityAction(object:  FPHGameplayUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2655872784));
            FPHGameplayUIController.<>c.<>9__25_0 = val_23;
        }
        
        this.buttonExitSolve.m_OnClick.AddListener(call:  162246656);
    }
    public void StartGameplay(FPHGameplayState newState)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        this.econ = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        if(null != 0)
        {
                this.ShowTutorial(newState:  newState);
            return;
        }
        
        UnityEngine.GameObject val_3 = this.tutorialText.gameObject;
        this.tutorialText.SetActive(value:  false);
        this.keyBoard.UpdateKeyboard(state:  newState);
        this.answerDisplay.Setup(state:  newState);
        this.tokenDisplay.Setup(initial:  newState.<tokensRemaining>k__BackingField);
        this.ToggleTopUI();
        if(this.buttonPowerupHint == 0)
        {
            
        }
    
    }
    public void UpdateGameplayState(FPHGameplayState updatedState)
    {
        this.keyBoard.UpdateKeyboard(state:  updatedState);
        this.answerDisplay.UpdateState(state:  updatedState);
        this.tokenDisplay.UpdateState(state:  updatedState);
    }
    public void UpdateTutorialText(string text)
    {
        UnityEngine.GameObject val_1 = this.tutorialText.gameObject;
        this.tutorialText.SetActive(value:  true);
    }
    public void ShowSolveButtonTutorial()
    {
        UnityEngine.GameObject val_1 = this.tutorialText.gameObject;
        this.tutorialText.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.freeGemsButton.gameObject;
        this.freeGemsButton.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.buttonPowerupHint.gameObject;
        this.buttonPowerupHint.SetActive(value:  false);
        this.solveRowCanvasGroup.alpha = null;
        this.solveButtonTutorial.SetActive(value:  true);
    }
    private void ShowTutorial(FPHGameplayState newState)
    {
        var val_9;
        var val_10;
        string val_1 = Localization.Localize(key:  -1638365456, defaultValue:  -1638365552, useSingularKey:  false);
        val_9 = "how_to_play_upper";
        this.banner.SetActive(value:  true);
        this.keyBoard.UpdateKeyboard(state:  newState);
        this.answerDisplay.Setup(state:  newState);
        this.tokenDisplay.Setup(initial:  newState.<tokensRemaining>k__BackingField);
        this.solveRowCanvasGroup.alpha = null;
        val_10 = 1152921504909881344;
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        if(null != 0)
        {
                this.topBarCanvasGroup.alpha = null;
            return;
        }
        
        FPHGameplayController val_3 = FPHGameplayController.Instance;
        if(null == 0)
        {
                return;
        }
        
        this.topBarButtonsGroup.alpha = null;
        string val_4 = Localization.Localize(key:  -1638332432, defaultValue:  -1638332576, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -1638332432, arg0:  13152256);
        string val_6 = Localization.Localize(key:  -1638328240, defaultValue:  -1638328144, useSingularKey:  false);
        val_10 = "FPH_FTUX2_ln2";
        val_9 = null;
        string val_7 = System.String.Format(format:  -1638328240, arg0:  13152256, arg1:  13152256);
        string val_8 = System.String.Format(format:  -1826949520, arg0:  -1638332432, arg1:  -1638328240);
        this.UpdateTutorialText(text:  -1826949520);
    }
    private void ToggleTopUI()
    {
        bool val_18;
        UnityEngine.GameObject val_1 = this.leaguesButton.gameObject;
        this.leaguesButton.SetActive(value:  SLC.Social.Leagues.LeaguesManager.IsAvailable());
        UnityEngine.GameObject val_3 = this.eventsButton.gameObject;
        this.eventsButton.SetActive(value:  WordGameEventsController.EventsEnabled);
        UnityEngine.GameObject val_5 = this.removeAdsButton.gameObject;
        val_18 = 0;
        Player val_6 = App.Player;
        if(0.RemovedAds != true)
        {
                GameBehavior val_8 = App.getBehavior;
            val_18 = 0;
            if(0 >= 2)
        {
                val_18 = AdsManager.ShowAdsControlButtons(fromSettings:  false);
        }
        
        }
        
        this.removeAdsButton.SetActive(value:  val_18);
        UnityEngine.GameObject val_10 = this.freeGemsButton.gameObject;
        GameBehavior val_11 = App.getBehavior;
        GameEcon val_12 = App.getGameEcon;
        this.freeGemsButton.SetActive(value:  GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0));
        UnityEngine.GameObject val_14 = this.buttonPowerupHint.gameObject;
        GameBehavior val_15 = App.getBehavior;
        WordForest.WFOGameEcon val_16 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        this.buttonPowerupHint.SetActive(value:  GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_158));
    }
    private void OnButtonSolveClicked()
    {
        var val_6;
        var val_7;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        val_6 = null;
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        val_7 = 0;
        val_6 = val_6;
        goto mem[null + 236];
    }
    private void OnAnswerSubmitted(bool isCorrect)
    {
        object val_1 = new System.Object();
        typeof(FPHGameplayUIController.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = isCorrect;
        this.topBarCanvasGroup.blocksRaycasts = false;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1637889600, clipIndex:  0);
        this.answerDisplay.DoLevelCompleteAnimation();
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  303407104, method:  new IntPtr(2657081888));
        DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1057803469, ignoreTimeScale:  false);
    }
    public void OnIncorrectAnswerSubmitted()
    {
        this.solveRowCanvasGroup.interactable = false;
        this.topBarCanvasGroup.interactable = false;
        this.answerDisplay.DoLevelFailAnimation();
        this.incorrectGuessDisplay.Show();
    }
    private void OnOutOfTokens()
    {
        float val_3;
        float val_4;
        float val_5;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(null != 0)
        {
                this.ShowSolveButtonTutorial();
            return;
        }
        
        this.tokenDisplay.ShowOutOfTokens();
        if(this.solveButtonHighlightTween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.solveButtonHighlightTween, complete:  false);
        }
        
        UnityEngine.Color val_2 = color;
        this.ootSolveButtonHighlight.color = new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = 0f};
        UnityEngine.GameObject val_6 = this.ootSolveButtonHighlight.gameObject;
        this.ootSolveButtonHighlight.SetActive(value:  true);
        DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ootSolveButtonHighlight, endValue:  val_2.r, duration:  val_2.g);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.ootSolveButtonHighlight);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ootSolveButtonHighlight, endValue:  val_2.r, duration:  val_2.g);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.ootSolveButtonHighlight);
        this.solveButtonHighlightTween = 0;
    }
    public void AbortLevel()
    {
        var val_10;
        System.Func<System.Boolean> val_12;
        var val_13;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1637450080, defaultValue:  -1637449984, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1637449888, defaultValue:  -1637449776, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        typeof(System.Boolean[]).__il2cppRuntimeField_11 = 1;
        string val_5 = Localization.Localize(key:  -1637449600, defaultValue:  -1847818176, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "yes_upper";
        string val_6 = Localization.Localize(key:  -1637449424, defaultValue:  -1637449504, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_14 = "no_upper";
        System.Func<System.Boolean> val_7 = new System.Func<System.Boolean>(object:  -1637423280, method:  new IntPtr(2657517968));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_10 = null;
        val_10 = null;
        val_12 = FPHGameplayUIController.<>c.<>9__36_1;
        if(val_12 != 0)
        {
            goto label_21;
        }
        
        val_12 = null;
        val_12 = new System.Func<System.Boolean>(object:  FPHGameplayUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2657518992));
        FPHGameplayUIController.<>c.<>9__36_1 = val_12;
        if(val_12 == 0)
        {
            goto label_24;
        }
        
        label_21:
        if(val_12 != 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_24:
        val_12 = 0;
        label_26:
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = val_12;
        val_13 = null;
        val_13 = null;
        0.SetupMessage(titleTxt:  -1637450080, messageTxt:  -1637449888, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public void ShowLevelFail(string failReason)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        FPHGameplayController val_3 = FPHGameplayController.Instance;
        TrackLevelComplete(isSuccess:  false, failReason:  failReason);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateSavedLevel(state:  0);
        this.levelFailDisplay.Show();
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1637303088, aName:  -2092882624);
    }
    public void GuessAgain()
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        mem[40] = 2097205;
        this.topBarCanvasGroup.blocksRaycasts = true;
        this.incorrectGuessDisplay.Hide();
        this.solveRowCanvasGroup.interactable = true;
        this.topBarCanvasGroup.interactable = true;
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        this.topBarCanvasGroup.ResetAnyUnconfirmedLetters();
    }
    private void OnSolveModeToggled(bool isOn)
    {
        if(isOn != false)
        {
                UnityEngine.GameObject val_1 = this.buttonExitSolve.gameObject;
            this.buttonExitSolve.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            Interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_6 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.r});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_6.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_10 = this.answerDisplay.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.answerDisplay;
            UnityEngine.Transform val_11 = this.keyBoard.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this.keyBoard;
            UnityEngine.Transform val_12 = this.buttonSolve.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = this.buttonSolve;
            UnityEngine.Transform val_13 = this.buttonExitSolve.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_1C = this.buttonExitSolve;
            ShowOverlay(contentToOverlay:  -2028557104);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = false}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_16 = this.buttonExitSolve.gameObject;
        this.buttonExitSolve.SetActive(value:  false);
    }
    public FPHGameplayUIController()
    {
    
    }
    private bool <AbortLevel>b__36_0()
    {
        this.ShowLevelFail(failReason:  -1636786928);
        return true;
    }

}
