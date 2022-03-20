using UnityEngine;
public class WGHintPickerButton : MyButton
{
    // Fields
    private UnityEngine.GameObject mainGroup;
    private WGHintPickerButton.HintPickerButtonType buttonType;
    private UnityEngine.UI.Text hintCostText;
    private UnityEngine.GameObject crossedOutCost;
    private UnityEngine.UI.Text crossedOutText;
    private UnityEngine.GameObject discountTimerGroup;
    private UnityEngine.UI.Text discountTimerText;
    private bool alwaysShowDiscount;
    private UnityEngine.GameObject unlockedGroup;
    private UnityEngine.GameObject lockedGroup;
    private UnityEngine.UI.Text unlockLevelText;
    private UnityEngine.GameObject petIcon;
    private UnityEngine.GameObject seasonPassIcon;
    private FrameSkipper frameSkipper;
    
    // Methods
    private void Awake()
    {
        if(this.alwaysShowDiscount == true)
        {
                return;
        }
        
        if((R4 + 40) == 0)
        {
                return;
        }
        
        if((R4 + 44) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = R4.gameObject;
        object val_4 = R4.AddComponent<System.Object>();
        mem2[0] = R4;
        System.Action val_5 = new System.Action(object:  R4, method:  new IntPtr(4004435088));
        mem2[0] = null;
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  R4, name:  -970794608);
    }
    protected override void Start()
    {
        this.Start();
        this.UpdateDisplay();
    }
    public override void OnButtonClick()
    {
        this.OnButtonClick();
        if(this.buttonType > 3)
        {
                return;
        }
        
        var val_1 = 6862272 + (6862272 + (this.buttonType) << 2);
        if(this.buttonType == 3)
        {
                6862272 + (this.buttonType) << 2 = (6862272 + (this.buttonType) << 2) & ((6862272 + (this.buttonType) << 2) << (6862272 + (this.buttonType) << 2));
            6862272 + (this.buttonType) << 2 = (6862272 + (this.buttonType) << 2) & (((IP) << (32-(6862272 + (this.buttonType) << 2 & (6862272 + (this.buttonType) << 2) << 6862272 + (this.buttonType) << 2))) | ((IP) << (6862272 + (this.buttonType) << 2 & (6862272 + (this.buttonType) << 2) << 6862272 + (this.buttonType) << 2)));
            6862272 + (this.buttonType) << 2 = (6862272 + (this.buttonType) << 2) & ((IP) >> 2);
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
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
    public void UpdateDisplay()
    {
        bool val_28;
        var val_29;
        var val_30;
        bool val_31;
        GameBehavior val_1 = App.getBehavior;
        if(0 <= 0)
        {
            goto label_5;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if((UnityEngine.Object.op_Implicit(exists:  this.unlockLevelText)) != false)
        {
                string val_4 = Localization.Localize(key:  -289846784, defaultValue:  -289846896, useSingularKey:  false);
            string val_5 = System.String.Format(format:  -289846784, arg0:  13152256);
        }
        
        GameBehavior val_6 = App.getBehavior;
        val_28 = 1;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) != true)
        {
                val_28 = WADPetsManager.GetUnlockedPetByAbility(ability:  1);
        }
        
        val_28 = val_28 | WGHintPickerDemoPopup.IsShowing;
        if((UnityEngine.Object.op_Implicit(exists:  this.unlockedGroup)) != false)
        {
                this.unlockedGroup.SetActive(value:  val_28);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.lockedGroup)) != false)
        {
                this.lockedGroup.SetActive(value:  val_28 ^ 1);
        }
        
        this.lockedGroup.interactable = val_28;
        if((val_28 == false) || (this.hintCostText == 0))
        {
            goto label_33;
        }
        
        if(WGHintPickerDemoPopup.IsShowing == false)
        {
            goto label_34;
        }
        
        val_30 = "free_upper";
        string val_15 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
        goto label_39;
        label_5:
        val_31 = 0;
        goto label_37;
        label_34:
        if(this.alwaysShowDiscount != false)
        {
                val_30 = this;
            string val_16 = this.GetDiscountedHintCost();
        }
        else
        {
                val_30 = this;
            string val_17 = this.GetRegularHintCost();
        }
        
        label_39:
        val_29 = val_30;
        label_33:
        if(this.crossedOutText != 0)
        {
                GameEcon val_19 = App.getGameEcon;
            GameEcon val_20 = App.getGameEcon;
            string val_21 = ToString(format:  null);
            val_29;
        }
        
        if(this.crossedOutCost != 0)
        {
                this.crossedOutCost.SetActive(value:  false);
        }
        
        if(this.discountTimerGroup != 0)
        {
                this.discountTimerGroup.SetActive(value:  false);
        }
        
        if(this.petIcon != 0)
        {
                this.petIcon.SetActive(value:  false);
        }
        
        if(this.seasonPassIcon == 0)
        {
                return;
        }
        
        val_31 = SeasonPassEventHandler.IsPlusPassActive;
        label_37:
        this.seasonPassIcon.SetActive(value:  val_31);
    }
    private string GetDiscountedHintCost()
    {
        GameEcon val_1 = App.getGameEcon;
        decimal val_2 = HintPickerCostDiscounted;
        GameBehavior val_3 = App.getBehavior;
        if(0 != 0)
        {
                if(this.IsPlayingDailyChallenge() != true)
        {
                decimal val_6 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  1));
            decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -289571192, hi = R4, lo = R5, mid = SB}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        bool val_8 = SeasonPassEventHandler.IsPlusPassActive;
        if(val_8 != false)
        {
                if(val_8.IsPlayingDailyChallenge() != true)
        {
                int val_10 = SeasonPassEventHandler.PassPickHintDiscount;
            decimal val_11 = System.Decimal.op_Implicit(value:  -289571176);
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -289571192, hi = R4, lo = R5, mid = SB}, d2:  new System.Decimal() {flags = ???});
        }
        
        }
        
        GameEcon val_13 = App.getGameEcon;
        string val_14 = ToString(format:  null);
    }
    private string GetRegularHintCost()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_18;
        int val_19;
        int val_20;
        GameEcon val_1 = App.getGameEcon;
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                if(this.IsPlayingDailyChallenge() != true)
        {
                val_18 = val_5;
            val_19 = val_6;
            val_20 = val_7;
            decimal val_9 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  1));
            decimal val_10 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -289459192, hi = val_4, lo = val_18, mid = val_19}, d2:  new System.Decimal() {flags = val_20});
        }
        
        }
        
        bool val_11 = SeasonPassEventHandler.IsPlusPassActive;
        if(val_11 != false)
        {
                if(val_11.IsPlayingDailyChallenge() != true)
        {
                val_18 = val_5;
            val_19 = val_6;
            val_20 = val_7;
            int val_13 = SeasonPassEventHandler.PassPickHintDiscount;
            decimal val_14 = System.Decimal.op_Implicit(value:  -289459176);
            decimal val_15 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -289459192, hi = val_4, lo = val_18, mid = val_19}, d2:  new System.Decimal() {flags = val_20});
        }
        
        }
        
        GameEcon val_16 = App.getGameEcon;
        string val_17 = ToString(format:  null);
    }
    private void UpdateFrameSkip()
    {
    
    }
    private void UpdateTimer()
    {
    
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
    public WGHintPickerButton()
    {
    
    }

}
