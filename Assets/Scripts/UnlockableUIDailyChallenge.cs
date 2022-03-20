using UnityEngine;
public class UnlockableUIDailyChallenge : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.UI.Text myText;
    private UnityEngine.GameObject starsParent;
    private System.Collections.Generic.List<UnityEngine.UI.Image> starFills;
    private UnityEngine.UI.Image morningImage;
    private UnityEngine.UI.Image eveningImage;
    private UnityEngine.UI.Image availableToolTip;
    private UGUINetworkedButton netWorkedButton;
    
    // Properties
    protected override int UnlockLevel { get; }
    protected override bool FeatureHidden { get; }
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.netWorkedButton = this;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -160948416, method:  new IntPtr(4133993856));
        mem[1152921513035833452] = null;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -160948416, name:  1799422256);
    }
    protected override int get_UnlockLevel()
    {
        return 6;
    }
    protected override bool get_FeatureHidden()
    {
        var val_9;
        var val_10;
        GameEcon val_1 = App.getGameEcon;
        val_9 = 1;
        if(18 < 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((-2116505760) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(CurrentLanguageSupported() == false)
        {
                return true;
        }
        
        val_9 = 0;
        Player val_6 = App.Player;
        val_10 = 0;
        if(val_10 >= this)
        {
                return true;
        }
        
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        val_10 = 0;
        if(0 < 18)
        {
                val_9 = 1;
        }
        
        return true;
    }
    protected override void UpdateButton()
    {
        var val_15;
        if(true != 3)
        {
                return;
        }
        
        bool val_1 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        UnityEngine.GameObject val_2 = this.morningImage.gameObject;
        this.morningImage.SetActive(value:  val_1);
        UnityEngine.GameObject val_3 = this.eveningImage.gameObject;
        this.eveningImage.SetActive(value:  val_1 ^ 1);
        UnityEngine.GameObject val_5 = this.availableToolTip.gameObject;
        this.availableToolTip.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20];
        val_15 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20;
        goto label_19;
        label_14:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_26;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24];
        val_15 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24;
        label_19:
        this.DisplayStars(stars:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24 + 8);
        return;
        label_26:
        if(this.myText != 0)
        {
                UnityEngine.GameObject val_13 = this.myText.gameObject;
            this.myText.SetActive(value:  true);
        }
        
        this.starsParent.SetActive(value:  false);
        UnityEngine.GameObject val_14 = this.availableToolTip.gameObject;
        this.availableToolTip.SetActive(value:  true);
    }
    protected override void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
        if(newState != 2)
        {
                return;
        }
        
        bool val_1 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        UnityEngine.GameObject val_2 = this.morningImage.gameObject;
        this.morningImage.SetActive(value:  val_1);
        UnityEngine.GameObject val_3 = this.eveningImage.gameObject;
        this.eveningImage.SetActive(value:  val_1 ^ 1);
        this.starsParent.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.availableToolTip.gameObject;
        this.availableToolTip.SetActive(value:  false);
    }
    private void OnConnectionClicked(bool connected)
    {
        if(connected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_78.ShowDailyChallengePopup();
            return;
        }
        
        this.ShowConnectionRequired();
    }
    private void ShowDailyChallengePopup()
    {
        var val_5;
        var val_6;
        FeatureAccessPoints val_7;
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_1;
        }
        
        val_5 = 1152921504895770624;
        var val_5 = 28012279;
        val_5 = 7613512 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_7 = 5;
        goto label_5;
        label_1:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_6;
        }
        
        val_5 = 1152921504895770624;
        var val_6 = 28012167;
        val_6 = 7613624 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_7 = 8;
        label_5:
        AmplitudePluginHelper.lastFeatureAccessPoint = val_7;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowConnectionRequired()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = UnlockableUIDailyChallenge.<>c.<>9__16_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  UnlockableUIDailyChallenge.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4134878208));
            UnlockableUIDailyChallenge.<>c.<>9__16_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void DisplayStars(int stars)
    {
        var val_4;
        this.starsParent.SetActive(value:  true);
        if(this.myText != 0)
        {
                UnityEngine.GameObject val_2 = this.myText.gameObject;
            this.myText.SetActive(value:  false);
        }
        
        val_4 = 4;
        goto label_7;
        label_13:
        if(this.myText <= 35628752)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_3 = 2621443.gameObject;
        var val_5 = 2621443;
        if(35628753 > stars)
        {
                0 = 0;
        }
        
        if(35628753 <= stars)
        {
                0 = 1;
        }
        
        2621443.SetActive(value:  true);
        val_4 = 5;
        label_7:
        val_5 = val_5 + 1;
        if((val_4 - 3) < val_5)
        {
            goto label_13;
        }
    
    }
    private void OnComplete(bool success)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -159799104, method:  new IntPtr(4134653184));
        UnregisterRequestCallback(callback:  7401472);
        object val_3 = this.GetComponent<System.Object>();
        this.WaitingStatus(waiting:  false);
        if(success != false)
        {
                this.ShowDailyChallengePopup();
            return;
        }
        
        this.ShowConnectionRequired();
    }
    private void OnDestroy()
    {
        var val_5;
        var val_5 = 28012609;
        val_5 = 7614284 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(App.isQuitting == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(4134653184));
        UnregisterRequestCallback(callback:  7401472);
    }
    public UnlockableUIDailyChallenge()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.starFills = null;
    }

}
