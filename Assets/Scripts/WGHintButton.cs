using UnityEngine;
public class WGHintButton : MyButton
{
    // Fields
    private UnityEngine.UI.Text hintCostText;
    private UnityEngine.GameObject crossedOutCost;
    private UnityEngine.UI.Text crossedOutText;
    private bool alwaysShowDiscount;
    private UnityEngine.UI.Image hintImage;
    private UnityEngine.GameObject popUp;
    private UnityEngine.UI.Text popupText;
    private UnityEngine.GameObject petIcon;
    private UnityEngine.GameObject seasonPassIcon;
    private bool isChallengingLevelLoaded;
    
    // Methods
    protected override void Start()
    {
        WordRegion val_1 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -29748544, method:  new IntPtr(4265193728));
        0.addOnLevelLoadedAction(callback:  7401472);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -29748544, name:  -970794608);
        this.Start();
        this.UpdateDisplay();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DoHintButtonStartBehavior(button:  -29748544);
    }
    public override void OnButtonClick()
    {
        this.OnButtonClick();
        GameBehavior val_1 = App.getBehavior;
        this.UpdateDisplay();
    }
    public void ToggleInteractable(bool state)
    {
        R5.interactable = state;
    }
    private void OnHintDiscountAvailable()
    {
        this.UpdateDisplay();
    }
    private void OnHintDiscountExpire()
    {
        this.UpdateDisplay();
    }
    private void OnPetsStatusUpdated()
    {
        this.UpdateDisplay();
    }
    private void OnLevelLoaded(GameLevel level)
    {
        this.isChallengingLevelLoaded = level.isChallengingLevel;
        this.UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        var val_13;
        bool val_14;
        this.popUp.SetActive(value:  false);
        if(this.petIcon != 0)
        {
                this.petIcon.SetActive(value:  false);
        }
        
        if(this.hintCostText != 0)
        {
                if(this.alwaysShowDiscount != false)
        {
                val_13 = this;
            string val_3 = this.GetDiscountedHintCost();
        }
        else
        {
                val_13 = this;
            string val_4 = this.GetRegularHintCost();
        }
        
            val_14 = val_13;
        }
        
        if(this.crossedOutText != 0)
        {
                GameEcon val_6 = App.getGameEcon;
            GameEcon val_7 = App.getGameEcon;
            string val_8 = ToString(format:  null);
            val_14 = ;
        }
        
        if(this.crossedOutCost != 0)
        {
                this.crossedOutCost.SetActive(value:  false);
        }
        
        if(this.seasonPassIcon != 0)
        {
                val_14 = SeasonPassEventHandler.IsPlusPassActive;
            this.seasonPassIcon.SetActive(value:  val_14);
        }
        
        this.CheckFreeHinting();
    }
    public void CheckFreeHinting()
    {
        var val_6 = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(WGHintButtonDemoPopup.IsShowing != false)
        {
                string val_3 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
            if(this.hintCostText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        }
        else
        {
                string val_4 = R4.GetRegularHintCost();
            if((R4 + 20) != 0)
        {
            goto R4 + 20 + 788;
        }
        
        }
    
    }
    public void SetPopup(string message, bool interactablePopup)
    {
        this.StopAllCoroutines();
        UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.popUp);
        this.popUp.blocksRaycasts = interactablePopup;
        System.Collections.IEnumerator val_2 = this.WaitThenShow();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -28621760);
    }
    private string GetDiscountedHintCost()
    {
        GameEcon val_1 = App.getGameEcon;
        decimal val_2 = HintCostDiscounted;
        GameBehavior val_3 = App.getBehavior;
        if(0 != 0)
        {
                if(this.IsPlayingDailyChallenge() != true)
        {
                decimal val_6 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  0));
            decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -28509560, hi = R4, lo = R5, mid = SB}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        bool val_8 = SeasonPassEventHandler.IsPlusPassActive;
        if(val_8 != false)
        {
                if(val_8.IsPlayingDailyChallenge() != true)
        {
                int val_10 = SeasonPassEventHandler.PassHintDiscount;
            decimal val_11 = System.Decimal.op_Implicit(value:  -28509544);
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -28509560, hi = R4, lo = R5, mid = SB}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        GameEcon val_13 = App.getGameEcon;
        string val_14 = ToString(format:  null);
    }
    private string GetRegularHintCost()
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        var val_21;
        int val_23;
        int val_24;
        int val_25;
        val_21 = 1152921504892043264;
        GameEcon val_1 = App.getGameEcon;
        if(this.isChallengingLevelLoaded != false)
        {
                val_23 = val_2;
            val_24 = val_4;
            GameEcon val_6 = App.getGameEcon;
            val_25 = 0;
            decimal val_7 = System.Decimal.op_Implicit(value:  -28397544);
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -28397560, hi = val_23, lo = val_3, mid = val_24}, d2:  new System.Decimal() {flags = val_5});
            val_21 = 1152921504892043264;
        }
        
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
                if(this.IsPlayingDailyChallenge() != true)
        {
                val_25 = val_2;
            decimal val_12 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  0));
            decimal val_13 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -28397560, hi = val_25, lo = R5, mid = R8}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        bool val_14 = SeasonPassEventHandler.IsPlusPassActive;
        if(val_14 != false)
        {
                if(val_14.IsPlayingDailyChallenge() != true)
        {
                val_25 = val_2;
            int val_16 = SeasonPassEventHandler.PassHintDiscount;
            decimal val_17 = System.Decimal.op_Implicit(value:  -28397544);
            decimal val_18 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -28397560, hi = val_25, lo = R5, mid = R8}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        GameEcon val_19 = App.getGameEcon;
        string val_20 = ToString(format:  null);
    }
    private System.Collections.IEnumerator WaitThenShow()
    {
        object val_1 = new System.Object();
        typeof(WGHintButton.<WaitThenShow>d__22).__il2cppRuntimeField_8 = 0;
        typeof(WGHintButton.<WaitThenShow>d__22).__il2cppRuntimeField_10 = this;
    }
    private bool IsPlayingDailyChallenge()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return PlayingChallenge;
        }
        
        return PlayingChallenge;
    }
    public WGHintButton()
    {
    
    }
    private void <WaitThenShow>b__22_0()
    {
        float val_3;
        UnityEngine.Transform val_1 = this.hintImage.transform;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -7.097641E+37f, y = val_3});
        this.hintImage.localPosition = new UnityEngine.Vector3();
    }
    private void <WaitThenShow>b__22_1()
    {
        this.popUp.SetActive(value:  false);
    }

}
