using UnityEngine;
public class WGOnTheTrailPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform tooltip;
    private UnityEngine.UI.Text tooltipText;
    private UnityEngine.UI.Slider progressSlider;
    private UnityEngine.Sprite checkMark;
    private UnityEngine.Sprite crossMark;
    private UnityEngine.UI.Image completionStatusImg;
    private UnityEngine.Transform wagonTransform;
    private UnityEngine.UI.Text dayTimeInfo;
    private WGOnTheTrailDayTracking days3Tracking;
    private WGOnTheTrailDayTracking days4Tracking;
    private WGOnTheTrailDayTracking days5Tracking;
    private UnityEngine.UI.Text description;
    private UnityEngine.GameObject rewardGroup;
    private UnityEngine.UI.Text rewardAmount;
    private UGUINetworkedButton greenButton;
    private UnityEngine.UI.Text greenButtonText;
    private UnityEngine.UI.Button blueButton;
    private UnityEngine.UI.Text blueButtonText;
    private UnityEngine.GameObject fixWagonCostGroup;
    private UnityEngine.UI.Text fixWagonCostText;
    private UnityEngine.UI.Button closeButton;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private UnityEngine.GameObject coinCurrencyStatView;
    private FrameSkipper frameSkipper;
    private System.DateTime endTime;
    private string dayTimePrefix;
    private bool isShowingDayCompleted;
    private int wagonFixPrice;
    private int completionReward;
    private bool isFinalDay;
    private const float WAGON_FAR_LEFT_POS_X = -347.5;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1137183600, method:  new IntPtr(3157758672));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(OnTheTrailEvent.PopupUIParameters_Basic param)
    {
        var val_3;
        var val_4;
        System.Type val_5;
        int val_6;
        var val_7;
        System.Collections.Generic.List<System.Boolean> val_8;
        var val_9;
        if(param != 0)
        {
                val_3 = 0;
            System.Type val_1 = param.GetType();
            val_4 = param;
            val_5 = param;
            val_6 = param.Day;
            val_7 = mem[param + 8 + 24];
            val_7 = param + 8 + 24;
        }
        else
        {
                val_3 = 0;
            System.Type val_2 = 0.GetType();
            val_5 = 0;
            val_4 = 8;
            val_6 = 0f;
            val_7 = 35615780;
        }
        
        this.UpdateWagonProgressUI(today:  0, completedLevels:  35615780, goal:  83886592, timeLeft:  new System.TimeSpan() {_ticks = param.TimeLeft}, paramType:  val_5);
        if(param != 0)
        {
                val_8 = param.DaysRewarded;
        }
        else
        {
                val_9 = 0;
            val_8 = 0;
        }
        
        this.UpdateDayTrackingUI(today:  0, daysRewarded:  0, rewards:  param.Rewards);
        this.UpdateRewardUI(param:  param, paramType:  0);
    }
    private void UpdateWagonProgressUI(int today, int completedLevels, int goal, System.TimeSpan timeLeft, System.Type paramType)
    {
        System.DateTime val_19;
        UnityEngine.Sprite val_38;
        var val_39;
        var val_40;
        var val_41;
        string val_42;
        UnityEngine.Sprite val_43;
        float val_1 = (float)completedLevels / (float)goal;
        object val_2 = this.wagonTransform.GetComponent<System.Object>();
        UnityEngine.Rect val_3 = rect;
        float val_4 = width;
        object val_5 = this.progressSlider.GetComponent<System.Object>();
        UnityEngine.Rect val_6 = rect;
        float val_7 = width;
        float val_9 = 20f + (3158087784 * (-0.5f));
        float val_10 = UnityEngine.Mathf.Max(a:  3158087784, b:  val_6.m_YMin);
        UnityEngine.Vector3 val_11 = localPosition;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_11.x, y:  val_11.y, z:  val_11.z);
        this.wagonTransform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433545216)});
        System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433438720)});
        System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433491968)});
        UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  0f = -10f, y:  val_11.y, z:  -10f);
        this.wagonTransform.localEulerAngles = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_18 = localPosition;
        UnityEngine.Vector3 val_20 = localPosition;
        UnityEngine.Vector3 val_21 = val_13.x.localPosition;
        UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  val_21.x, y:  val_21.y, z:  val_21.z);
        this.tooltip.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        if(paramType == 0)
        {
            goto label_20;
        }
        
        string val_23 = Localization.Localize(key:  -1136901584, defaultValue:  -1136901680, useSingularKey:  false);
        val_38 = this.crossMark;
        goto label_22;
        label_20:
        if(paramType == 0)
        {
            goto label_23;
        }
        
        val_39 = "CONTINUE TOMORROW!";
        val_40 = "complete_wagon_tooltip_upper";
        goto label_24;
        label_23:
        if(paramType == 0)
        {
            goto label_25;
        }
        
        val_39 = "COLLECT REWARD";
        val_40 = "reward_wagon_tooltip_upper";
        label_24:
        string val_24 = Localization.Localize(key:  -1136901216, defaultValue:  -1630895344, useSingularKey:  false);
        goto label_26;
        label_25:
        string val_25 = Localization.Localize(key:  -1136900976, defaultValue:  -1136901088, useSingularKey:  false);
        val_41 = "trail_wagon_tooltip_upper";
        string val_26 = System.String.Format(format:  -1136900976, arg0:  13152256);
        label_26:
        val_38 = this.checkMark;
        label_22:
        this.completionStatusImg.sprite = mem[this.checkMark];
        if(paramType != 0)
        {
                string val_27 = Localization.Localize(key:  -1136896656, defaultValue:  -1136896752, useSingularKey:  false);
            int val_38 = today;
            val_38 = val_38 + 1;
            val_42 = "day_x_begin_upper";
            string val_28 = System.String.Format(format:  -1136896656, arg0:  13152256);
        }
        else
        {
                string val_29 = Localization.Localize(key:  -1141456624, defaultValue:  -1141456528, useSingularKey:  false);
            val_42 = "{0} {1}";
            string val_30 = System.String.Format(format:  1592589744, arg0:  -1141456624, arg1:  13152256);
        }
        
        this.isShowingDayCompleted = paramType;
        this.dayTimePrefix = val_42;
        System.DateTime val_31 = DateTimeCheat.UtcNow;
        System.DateTime val_32 = Add(value:  new System.TimeSpan() {_ticks = 1152921512059902080});
        this.endTime = val_19;
        UnityEngine.GameObject val_34 = this.tooltip.gameObject;
        UnityEngine.UI.LayoutElement val_35 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1136867424);
        this.frameSkipper = this;
        System.Action val_36 = new System.Action(object:  -1136867424, method:  new IntPtr(3158074848));
        System.Delegate val_37 = System.Delegate.Combine(a:  this.checkMark, b:  7454720);
        val_43 = this.checkMark;
        if(val_43 != 0)
        {
                if(null == null)
        {
            goto label_36;
        }
        
        }
        
        val_43 = 0;
        label_36:
        this.checkMark = val_43;
    }
    private void UpdateDayTrackingUI(int today, System.Collections.Generic.List<bool> daysRewarded, System.Collections.Generic.List<int> rewards)
    {
        WGOnTheTrailDayTracking val_3;
        if(true == 5)
        {
            goto label_2;
        }
        
        if(true == 4)
        {
            goto label_3;
        }
        
        if(true == 3)
        {
                val_3 = this.days3Tracking;
        }
        
        goto label_5;
        label_2:
        val_3 = this.days5Tracking;
        goto label_5;
        label_3:
        val_3 = this.days4Tracking;
        label_5:
        if(val_3 == 0)
        {
                return;
        }
        
        if(val_3 != 0)
        {
                val_3.Setup(today:  today, daysRewarded:  daysRewarded, rewards:  rewards);
        }
        else
        {
                val_3.Setup(today:  today, daysRewarded:  daysRewarded, rewards:  rewards);
        }
        
        UnityEngine.GameObject val_2 = val_3.gameObject;
        val_3.SetActive(value:  true);
    }
    private void UpdateRewardUI(OnTheTrailEvent.PopupUIParameters_Basic param, System.Type paramType)
    {
        var val_32;
        UnityEngine.Events.UnityAction val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        UnityEngine.UI.Text val_38;
        this.PrepareRewardUI();
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433385472)});
        if(paramType == 0)
        {
            goto label_4;
        }
        
        string val_2 = Localization.Localize(key:  -1136560544, defaultValue:  -1136560928, useSingularKey:  false);
        UnityEngine.GameObject val_3 = this.description.gameObject;
        this.description.SetActive(value:  true);
        if((SceneDictator.IsInGameScene() == false) || (CategoryPacksManager.IsPlaying == true))
        {
            goto label_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_17;
        }
        
        label_13:
        string val_8 = Localization.Localize(key:  -2116031904, defaultValue:  -2116031984, useSingularKey:  false);
        Player val_9 = App.Player;
        string val_10 = System.String.Format(format:  1592589744, arg0:  -2116031904, arg1:  13152256);
        this.SetupButtonColor(color:  1);
        this.greenButton.RemoveAllListeners();
        label_82:
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  -1136381072, method:  new IntPtr(3158427344));
        this.greenButton.AddListener(call:  162246656);
        this.coinCurrencyStatView.SetActive(value:  false);
        this.fixWagonCostGroup.SetActive(value:  false);
        return;
        label_4:
        val_32 = null;
        System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433438720)});
        if(paramType == 0)
        {
            goto label_30;
        }
        
        this.rewardGroup.SetActive(value:  false);
        UnityEngine.GameObject val_13 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  true);
        string val_14 = Localization.Localize(key:  -1136518160, defaultValue:  -1136518448, useSingularKey:  false);
        val_33 = "day_complete_popup";
        UnityEngine.GameObject val_15 = this.description.gameObject;
        this.description.SetActive(value:  true);
        this.blueButtonText.resizeTextMaxSize = 60;
        this.SetupButtonColor(color:  0);
        this.blueButton.interactable = false;
        UnityEngine.GameObject val_16 = this.goldenCurrencyAnimControl.gameObject;
        val_34 = 0;
        goto label_42;
        label_30:
        val_32 = null;
        System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433491968)});
        if(paramType == 0)
        {
            goto label_45;
        }
        
        UnityEngine.GameObject val_18 = this.closeButton.gameObject;
        val_35 = this.closeButton;
        val_36 = 0;
        val_35.SetActive(value:  false);
        if(param == 0)
        {
            goto label_48;
        }
        
        val_36 = null;
        this.isFinalDay = ((param.Day - (OnTheTrailEvent.PopupUIParameters_Basic.__il2cppRuntimeField_typeHierarchy + (OnTheTrailEvent.PopupUIParameters_RewardAvailable.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4)) >> 5;
        UnityEngine.GameObject val_20 = this.description.gameObject;
        this.description.SetActive(value:  false);
        this.completionReward = this.description;
        string val_21 = param + 40.ToString();
        this.rewardGroup.SetActive(value:  true);
        string val_22 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        this.SetupButtonColor(color:  1);
        this.greenButton.RemoveAllListeners();
        val_33 = null;
        val_33 = new UnityEngine.Events.UnityAction(object:  -1136381072, method:  new IntPtr(3158498400));
        this.greenButton.AddListener(call:  162246656);
        UnityEngine.GameObject val_24 = this.goldenCurrencyAnimControl.gameObject;
        val_34 = 1;
        label_42:
        this.goldenCurrencyAnimControl.SetActive(value:  true);
        return;
        label_45:
        val_37 = 0;
        System.Type val_25 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(433545216)});
        if(paramType == 0)
        {
                return;
        }
        
        string val_26 = Localization.Localize(key:  -1136463552, defaultValue:  -1136463776, useSingularKey:  false);
        UnityEngine.GameObject val_27 = this.description.gameObject;
        this.description.SetActive(value:  true);
        UnityEngine.GameObject val_28 = this.greenButtonText.gameObject;
        this.greenButtonText.SetActive(value:  false);
        if(val_37 == 0)
        {
            goto label_75;
        }
        
        val_38 = this.fixWagonCostText;
        this.wagonFixPrice = 2097204;
        goto label_76;
        label_17:
        string val_29 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        this.SetupButtonColor(color:  0);
        this.greenButton.RemoveAllListeners();
        this.blueButton.m_OnClick.RemoveAllListeners();
        goto label_82;
        label_75:
        val_37 = 40;
        val_38 = this.fixWagonCostText;
        this.wagonFixPrice = 2097204;
        label_76:
        string val_30 = val_37.ToString();
        this.fixWagonCostGroup.SetActive(value:  true);
        this.SetupButtonColor(color:  1);
        this.coinCurrencyStatView.SetActive(value:  true);
        this.greenButton.RemoveAllListeners();
        System.Action<System.Boolean> val_31 = new System.Action<System.Boolean>(object:  -1136381072, method:  new IntPtr(3158561200));
        this.greenButton.OnConnectionClick = null;
        return;
        label_48:
    }
    private void PrepareRewardUI()
    {
        this.goldenCurrencyAnimControl.Create();
        UnityEngine.GameObject val_1 = this.greenButton.gameObject;
        this.greenButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.greenButtonText.gameObject;
        this.greenButtonText.SetActive(value:  true);
        UnityEngine.GameObject val_3 = this.blueButton.gameObject;
        this.blueButton.SetActive(value:  false);
    }
    private void SetupButtonColor(WGOnTheTrailPopup.ButtonColor color)
    {
        UnityEngine.GameObject val_1 = this.greenButton.gameObject;
        this.greenButton.SetActive(value:  (color - 1) >> 5);
        UnityEngine.GameObject val_4 = this.blueButton.gameObject;
        this.blueButton.SetActive(value:  this.blueButton >> 5);
    }
    private void OnClick_Level()
    {
        this.Close();
        SceneType val_1 = SceneDictator.GetActiveSceneType();
        if(0 == 2)
        {
                if(CategoryPacksManager.IsPlaying != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == false)
        {
                return;
        }
        
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnClick_Collect()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        this.greenButton.interactable = false;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1135698576, method:  new IntPtr(3158498400));
        this.greenButton.RemoveListener(call:  162246656);
        OnTheTrailEventHandler.<Instance>k__BackingField.CollectReward(rewardAmount:  this.completionReward);
        System.Action val_2 = new System.Action(object:  -1135698576, method:  new IntPtr(3159239600));
        mem2[0] = null;
        Player val_3 = App.Player;
        Player val_4 = App.Player;
        decimal val_5 = System.Decimal.op_Implicit(value:  -1135710624);
        this.goldenCurrencyAnimControl.Play(fromValue:  4 - this.completionReward, toValue:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_7, mid = val_6}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnClick_FixWagon(bool connected)
    {
        var val_7;
        if(connected == false)
        {
            goto label_1;
        }
        
        Player val_1 = App.Player;
        var val_2 = 0 + 60;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1135581220);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, d2:  new System.Decimal())) == false)
        {
            goto label_7;
        }
        
        var val_8 = 27054593;
        val_8 = 8571468 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        PurchaseProxy.currentPurchasePoint = 78;
        GameBehavior val_5 = App.getBehavior;
        System.Action val_7 = new System.Action(object:  -1135569168, method:  new IntPtr(3159373104));
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        this.Close();
        return;
        label_1:
        this.ShowConnectionRequired();
        this.Close();
        return;
        label_7:
        var val_9 = 27058911;
        val_9 = 8571812 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        OnTheTrailEventHandler.<Instance>k__BackingField.FixWagon();
        OnTheTrailEventHandler.<Instance>k__BackingField.ReinitializePopup();
    }
    private void OnGoldenCurrencyAnimFinished()
    {
        if(this.isFinalDay != false)
        {
                this.Close();
            return;
        }
        
        this.ReinitializePopup();
    }
    private void ShowConnectionRequired()
    {
        var val_7;
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_6 = new System.Func<System.Boolean>(object:  -1135344144, method:  new IntPtr(3159598128));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_7 = null;
        val_8 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void ReinitializePopup()
    {
        OnTheTrailEventHandler.<Instance>k__BackingField.OnEventButtonPressed();
    }
    private void UpdateTimer()
    {
        var val_5;
        var val_29;
        var val_30;
        var val_31;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512061665832}, d2:  new System.DateTime() {dateData = this.endTime});
        val_29 = 0;
        string val_9 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0).ToString(format:  -1827641632);
        string val_12 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0).ToString(format:  -1827641632);
        string val_15 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0).ToString(format:  -1827641632);
        string val_16 = System.String.Format(format:  -1135144144, arg0:  -1135115716, arg1:  -1135115716, arg2:  -1135115716);
        string val_17 = System.String.Format(format:  -1704297152, arg0:  this.dayTimePrefix, arg1:  -1135144144);
        val_31 = "{0} - {1}";
        if(this.isShowingDayCompleted == false)
        {
                return;
        }
        
        val_29 = 0;
        string val_20 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0).ToString(format:  -1827641632);
        string val_23 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0).ToString(format:  -1827641632);
        val_30 = ;
        string val_26 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0).ToString(format:  -1827641632);
        string val_27 = System.String.Format(format:  -1687058320, arg0:  -1135115716, arg1:  -1135115716, arg2:  -1135115716);
        string val_28 = System.String.Format(format:  1592589744, arg0:  this.dayTimePrefix, arg1:  -1687058320);
    }
    private void Close()
    {
        System.Action val_4;
        System.Action val_1 = new System.Action(object:  -1134967088, method:  new IntPtr(3158074848));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.frameSkipper.updateLogic, value:  7454720);
        val_4 = this.frameSkipper.updateLogic;
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        this.frameSkipper.updateLogic = val_4;
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1134967088, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGOnTheTrailPopup()
    {
    
    }
    private void <OnClick_FixWagon>b__41_0()
    {
        this.ReinitializePopup();
    }
    private bool <ShowConnectionRequired>b__43_0()
    {
        this.ReinitializePopup();
        return true;
    }

}
