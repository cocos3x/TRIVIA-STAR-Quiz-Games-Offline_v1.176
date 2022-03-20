using UnityEngine;
public abstract class TRVPowerupButton : MyButton
{
    // Fields
    private UnityEngine.UI.Text costText;
    private UnityEngine.UI.Image currencyIcon;
    private UnityEngine.GameObject glow;
    public const string LastHintUsedCPrefKey = "lastPowerupUsedLevel";
    private TRVPowerup <powerup>k__BackingField;
    protected UnityEngine.GameObject notEnoughCoinsTooltip;
    protected UnityEngine.GameObject ftuxTooltip;
    protected bool isShowingFTUX;
    private bool startedGlow;
    public System.Action supplmentalOneTimeOnClickAction;
    
    // Properties
    public virtual TRVPowerup powerup { get; set; }
    protected virtual string pref_ftux_shown_key { get; }
    public int lastLevelAnyPowerupUsed { get; set; }
    
    // Methods
    public virtual TRVPowerup get_powerup()
    {
    
    }
    private void set_powerup(TRVPowerup value)
    {
        this.<powerup>k__BackingField = value;
    }
    protected virtual string get_pref_ftux_shown_key()
    {
    
    }
    public int get_lastLevelAnyPowerupUsed()
    {
        return CPlayerPrefs.GetInt(key:  -517632144, defaultValue:  0);
    }
    public void set_lastLevelAnyPowerupUsed(int value)
    {
        CPlayerPrefs.SetInt(key:  -517632144, val:  value);
    }
    protected void CheckFTUX()
    {
        var val_25;
        Player val_1 = App.Player;
        if(0 != this)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -466072720, defaultValue:  0)) == 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(eventEntryType == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        this.isShowingFTUX = true;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimer();
        if(this.ftuxTooltip != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_10 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.GameObject val_11 = gameObject;
        this.ftuxTooltip = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_12 = this.gameObject;
        ShowToolTip(objToToolTip:  -466072720, text:  -466072720, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1176256512, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  3259498496);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_14 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_15 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_15.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_18 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_19 = this.gameObject;
        UnityEngine.Transform val_20 = this.transform;
        val_25 = this;
        Add(item:  -466072720);
        UnityEngine.GameObject val_21 = this.ftuxTooltip.gameObject;
        UnityEngine.Transform val_22 = this.ftuxTooltip.transform;
        Add(item:  this.ftuxTooltip);
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_24 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
    }
    protected void HideFTUXAndRefresh()
    {
        if(this.ftuxTooltip != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.ftuxTooltip);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_3 = new System.Action(object:  -465943312, method:  new IntPtr(3828998960));
        CloseOverlay(onClosed:  7454720);
    }
    protected virtual void OnPowerupSuccess()
    {
    
    }
    protected virtual void OnPowerupFailed()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimer();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetGameplayAlpha(visible:  false);
        string val_3 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_7 = 23682965;
        val_7 = 11943096 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        PurchaseProxy.currentPurchasePoint = 86;
        GameBehavior val_4 = App.getBehavior;
        System.Action val_6 = new System.Action(object:  -465710096, method:  new IntPtr(3829232176));
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
    }
    protected virtual string GetFtuxText()
    {
    
    }
    protected virtual bool IsPowerupAvailable()
    {
        return true;
    }
    protected virtual bool IsEligibleToShowInQOTD()
    {
        return true;
    }
    protected virtual void SetupButtonUI()
    {
        var val_9;
        var val_10;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        val_9 = this;
        this.interactable = true;
        if(this == 0)
        {
            goto label_3;
        }
        
        if(this.IsFreeCost() == false)
        {
            goto label_5;
        }
        
        string val_4 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
        val_9 = "free_upper";
        UnityEngine.GameObject val_5 = this.currencyIcon.gameObject;
        val_10 = 0;
        goto label_9;
        label_3:
        this.DisableButton();
        goto label_10;
        label_5:
        string val_6 = this.currencyIcon.ToString();
        val_9 = this.currencyIcon;
        UnityEngine.GameObject val_7 = this.currencyIcon.gameObject;
        val_10 = 1;
        label_9:
        this.currencyIcon.SetActive(value:  true);
        label_10:
        UnityEngine.GameObject val_8 = this.gameObject;
        this.SetActive(value:  true);
    }
    public virtual void PlayReminderAnim(int remainingTime)
    {
        var val_6;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_6 = this;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        object val_3 = this.GetComponent<System.Object>();
        val_6 = this;
        if(this == 0)
        {
                return;
        }
        
        mem[1152921512731660160] = (float)remainingTime;
        if(this.costText == remainingTime)
        {
                this.costText = this.startedGlow;
        }
        
        if(this.costText == true)
        {
                return;
        }
        
        mem2[0] = 1;
        System.Collections.IEnumerator val_4 = R4.StartGlow();
        UnityEngine.Coroutine val_5 = R4.StartCoroutine(routine:  R4);
    }
    public void UpdateButton()
    {
        if(this.IsEligibleToShow() == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = R4.StartFadingIn();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    public void FadeOut()
    {
        System.Collections.IEnumerator val_1 = this.StartFadingOut();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -464893328);
    }
    public override void OnButtonClick()
    {
        var val_10;
        System.Action val_11;
        this.OnButtonClick();
        val_10 = 1152921504892043264;
        Player val_1 = App.Player;
        val_11 = 0;
        if(val_11 < this.currencyIcon)
        {
                if(this.IsFreeCost() == false)
        {
            goto label_8;
        }
        
        }
        
        this.DisableButton();
        if(this.isShowingFTUX == false)
        {
            goto label_9;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -464768928, value:  1);
        this.HideFTUXAndRefresh();
        goto label_10;
        label_9:
        if(this.IsFreeCost() == true)
        {
            goto label_16;
        }
        
        Player val_4 = App.Player;
        this.lastLevelAnyPowerupUsed = 0;
        goto label_16;
        label_8:
        if(this.notEnoughCoinsTooltip == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = PlaceGameObject<System.Object>(loc:  0);
            val_11 = 0;
            UnityEngine.GameObject val_8 = gameObject;
            this.notEnoughCoinsTooltip = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
            UnityEngine.GameObject val_9 = this.gameObject;
            val_10 = this;
            ShowToolTip(objToToolTip:  -464768928, text:  -464797136, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  val_11, showPick:  false, maxFontSize:  val_11);
        }
        
        label_16:
        label_10:
        if(this.supplmentalOneTimeOnClickAction != 0)
        {
                this.supplmentalOneTimeOnClickAction.Invoke();
        }
        
        this.supplmentalOneTimeOnClickAction = 0;
    }
    private System.Collections.IEnumerator StartFadingIn()
    {
        object val_1 = new System.Object();
        typeof(TRVPowerupButton.<StartFadingIn>d__30).__il2cppRuntimeField_8 = 0;
        typeof(TRVPowerupButton.<StartFadingIn>d__30).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator StartFadingOut()
    {
        object val_1 = new System.Object();
        typeof(TRVPowerupButton.<StartFadingOut>d__31).__il2cppRuntimeField_8 = 0;
        typeof(TRVPowerupButton.<StartFadingOut>d__31).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator StartGlow()
    {
        object val_1 = new System.Object();
        typeof(TRVPowerupButton.<StartGlow>d__32).__il2cppRuntimeField_8 = 0;
        typeof(TRVPowerupButton.<StartGlow>d__32).__il2cppRuntimeField_10 = this;
    }
    public void DisableButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.interactable = false;
    }
    private void CheckOOC()
    {
        System.Collections.IEnumerator val_1 = this.CheckOOCAfterDelay();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -464196640);
    }
    private System.Collections.IEnumerator CheckOOCAfterDelay()
    {
        object val_1 = new System.Object();
        typeof(TRVPowerupButton.<CheckOOCAfterDelay>d__35).__il2cppRuntimeField_8 = 0;
        typeof(TRVPowerupButton.<CheckOOCAfterDelay>d__35).__il2cppRuntimeField_10 = this;
    }
    private void ContinueGame()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetGameplayAlpha(visible:  true);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ContinueTimer(duration:  null);
    }
    private bool IsEligibleToShow()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this == 0)
        {
                return false;
        }
        
        if(this != 0)
        {
                return this.IsUnlocked();
        }
        
        return this.IsUnlocked();
    }
    protected TRVPowerupButton()
    {
    
    }
    private void <HideFTUXAndRefresh>b__19_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartQuiz();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = GetWindow<System.Object>();
        UnityEngine.GameObject val_4 = gameObject;
        SLCWindow.CloseWindow(window:  2119322896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <CheckOOCAfterDelay>b__35_0()
    {
        this.ContinueGame();
    }

}
