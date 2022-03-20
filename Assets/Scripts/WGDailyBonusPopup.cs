using UnityEngine;
public class WGDailyBonusPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform rewardsParent;
    private UnityEngine.Sprite defaultBoxSp;
    private UnityEngine.Sprite openBoxSp;
    private UnityEngine.UI.Text pickARewardText;
    private UnityEngine.GameObject pickAnotherGroup;
    private UnityEngine.GameObject loadingVideoAnimation;
    private UnityEngine.GameObject watchVideoSprite;
    private UGUINetworkedButton pickAnotherButton;
    private UnityEngine.UI.Button buttonContinue;
    protected UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text timerText;
    protected UnityEngine.GameObject timerGroup;
    private UnityEngine.Color rewardDisabledColor;
    private UnityEngine.UI.Button rewardButton1;
    private UnityEngine.UI.Button rewardButton2;
    private UnityEngine.UI.Button rewardButton3;
    private UnityEngine.UI.Image currentRevealedReward;
    protected UnityEngine.GameObject rewardBtn;
    private System.DateTime lastCollectTime;
    
    // Properties
    private System.TimeSpan currentTimeUntilNextBonus { get; }
    
    // Methods
    private System.TimeSpan get_currentTimeUntilNextBonus()
    {
        var val_5 = R1;
        val_5 = val_5 + 96;
        GameEcon val_1 = App.getGameEcon;
        System.DateTime val_2 = AddHours(value:  null);
        System.DateTime val_3 = DateTimeCheat.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513085953984}, d2:  new System.DateTime());
        return new System.TimeSpan() {_ticks = val_4._ticks};
    }
    private void Start()
    {
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_DC;
    }
    protected virtual void Init_v2()
    {
        UnityEngine.Events.UnityAction val_17;
        System.Delegate val_18;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AddVideoObserver();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -110526784, name:  -113354608);
        if((UnityEngine.Object.op_Implicit(exists:  this.closeButton)) != false)
        {
                val_17 = null;
            val_17 = new UnityEngine.Events.UnityAction(object:  -110526784, method:  typeof(WGDailyBonusPopup).__il2cppRuntimeField_120);
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.buttonContinue)) != false)
        {
                val_17 = null;
            val_17 = new UnityEngine.Events.UnityAction(object:  -110526784, method:  typeof(WGDailyBonusPopup).__il2cppRuntimeField_118);
            this.buttonContinue.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.pickAnotherButton)) == false)
        {
            goto label_19;
        }
        
        val_17 = null;
        val_17 = new System.Action<System.Boolean>(object:  -110526784, method:  typeof(WGDailyBonusPopup).__il2cppRuntimeField_100);
        val_18 = this.pickAnotherButton.OnConnectionClick;
        System.Delegate val_9 = System.Delegate.Combine(a:  val_18, b:  7401472);
        if(val_18 != 0)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        val_18 = 0;
        label_22:
        this.pickAnotherButton.OnConnectionClick = val_18;
        label_19:
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton1)) != false)
        {
                val_17 = null;
            val_17 = new UnityEngine.Events.UnityAction(object:  -110526784, method:  new IntPtr(4184388864));
            this.rewardButton1.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton2)) != false)
        {
                val_17 = null;
            val_17 = new UnityEngine.Events.UnityAction(object:  -110526784, method:  new IntPtr(4184402176));
            this.rewardButton2.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton3)) != false)
        {
                val_17 = null;
            val_17 = new UnityEngine.Events.UnityAction(object:  -110526784, method:  new IntPtr(4184415488));
            this.rewardButton3.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  -110526784);
    }
    protected virtual System.Collections.IEnumerator CheckState()
    {
        object val_1 = new System.Object();
        typeof(WGDailyBonusPopup.<CheckState>d__23).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyBonusPopup.<CheckState>d__23).__il2cppRuntimeField_10 = this;
    }
    private void OnEnable()
    {
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_EC;
    }
    protected virtual void OnEnable_v2()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = this.gameObject;
        public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_1C = this;
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_104;
    }
    protected virtual void OnCoinsAnimFinished_v2()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_14 = 1;
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_104;
    }
    protected virtual void OnClick_PickAnotherButton(bool result)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowVideo(result:  false);
    }
    protected virtual void UpdateDailyBonusUI()
    {
        var val_18;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton1)) != false)
        {
                this.rewardButton1.interactable = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton2)) != false)
        {
                this.rewardButton2.interactable = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton3)) != false)
        {
                this.rewardButton3.interactable = true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_5 = LastCollectTime;
        this.lastCollectTime = new System.DateTime();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_7 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.timerGroup)) != false)
        {
                val_18 = 0;
            this.timerGroup.SetActive(value:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance()) != 0)
        {
                return;
        }
    
    }
    protected virtual void UpdateReward(DailyBonusRevealedRewardInfo info)
    {
        UnityEngine.Transform val_8;
        var val_9;
        val_8 = 35627084;
        if(info != 0)
        {
                val_8 = this.rewardsParent;
            UnityEngine.Transform val_1 = val_8.GetChild(index:  info.revealedReward);
            object val_2 = val_8.GetComponent<System.Object>();
            if(val_8 == 0)
        {
                return;
        }
        
            this.currentRevealedReward = val_8;
            val_8 = this.openBoxSp;
            if((UnityEngine.Object.op_Implicit(exists:  val_8)) == false)
        {
                return;
        }
        
            val_8.sprite = this.openBoxSp;
            return;
        }
        
        val_9 = 1152921504765685760;
        if(this.currentRevealedReward == 0)
        {
                return;
        }
        
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.currentRevealedReward.color = new UnityEngine.Color() {a = ???};
        if((UnityEngine.Object.op_Implicit(exists:  this.defaultBoxSp)) == false)
        {
                return;
        }
        
        this.currentRevealedReward.sprite = this.defaultBoxSp;
    }
    protected virtual void OnClick_ContinueButton()
    {
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_11C;
    }
    protected virtual void OnClick_CloseButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowPostPopups();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_19 = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RemoveVideoObserver();
        this.ClosePopup();
    }
    protected virtual void ShowPickAnotherGroup(bool showPickAnotherButton)
    {
        var val_26;
        System.Action<System.Boolean> val_27;
        UnityEngine.GameObject val_28;
        var val_29;
        val_26 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton1)) != false)
        {
                this.rewardButton1.interactable = false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton2)) != false)
        {
                this.rewardButton2.interactable = false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardButton3)) != false)
        {
                this.rewardButton3.interactable = false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(DailyBonusRevealedRewardInfo).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  0, max:  this.rewardsParent.childCount);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_27 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_10 = new DailyBonusRevealedRewardInfo();
        if((UnityEngine.Object.op_Implicit(exists:  this.pickARewardText)) != false)
        {
                UnityEngine.GameObject val_10 = this.pickARewardText.gameObject;
            this.pickARewardText.SetActive(value:  false);
        }
        
        val_28 = this.pickAnotherGroup;
        if((UnityEngine.Object.op_Implicit(exists:  val_28)) != false)
        {
                val_28 = this.pickAnotherGroup;
            val_28.SetActive(value:  true);
        }
        
        if(showPickAnotherButton == false)
        {
            goto label_35;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsReadyToShowRewardedVideo() == false)
        {
            goto label_35;
        }
        
        val_28 = 1152921504901095424;
        val_27 = 1152921511451249552;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() == false)
        {
            goto label_39;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.loadingVideoAnimation)) != false)
        {
                this.loadingVideoAnimation.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.watchVideoSprite)) == false)
        {
            goto label_48;
        }
        
        this.watchVideoSprite.SetActive(value:  true);
        goto label_48;
        label_35:
        UnityEngine.GameObject val_19 = this.pickAnotherButton.gameObject;
        val_29 = 0;
        goto label_51;
        label_39:
        if((UnityEngine.Object.op_Implicit(exists:  this.loadingVideoAnimation)) != false)
        {
                this.loadingVideoAnimation.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.watchVideoSprite)) != false)
        {
                this.watchVideoSprite.SetActive(value:  false);
        }
        
        this.pickAnotherButton.interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = 1152921504614248448;
        val_27 = null;
        val_27 = new System.Action<System.Boolean>(object:  -109065792, method:  new IntPtr(4185872384));
        System.Delegate val_24 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
        val_28 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_28 != 0)
        {
                if(val_28 == null)
        {
            goto label_66;
        }
        
        }
        
        val_28 = 0;
        label_66:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_28;
        label_48:
        UnityEngine.GameObject val_25 = this.pickAnotherButton.gameObject;
        val_29 = 1;
        label_51:
        this.pickAnotherButton.SetActive(value:  true);
    }
    private void OnRewardedVideoLoaded(bool success)
    {
        System.Action<System.Boolean> val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        this.pickAnotherButton.interactable = success;
        val_7 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.loadingVideoAnimation)) != false)
        {
                this.loadingVideoAnimation.SetActive(value:  success ^ 1);
        }
        
        val_8 = this.watchVideoSprite;
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_8 = this.watchVideoSprite;
            val_8.SetActive(value:  success);
        }
        
        if(success == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean>(object:  -108847296, method:  new IntPtr(4185872384));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
        val_9 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_16;
        }
        
        }
        
        val_9 = 0;
        label_16:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_9;
    }
    protected virtual void ShowFtuxPickGroup()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.pickARewardText)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4 + 24.gameObject;
        R4 + 24.SetActive(value:  true);
        string val_3 = Localization.Localize(key:  -108734528, defaultValue:  -108734720, useSingularKey:  false);
        if((R4 + 24) == 0)
        {
            
        }
    
    }
    protected virtual void ShowFtuxRewardGroup()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.pickARewardText)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.pickARewardText.gameObject;
        this.pickARewardText.SetActive(value:  true);
        string val_3 = Localization.Localize(key:  -108605840, defaultValue:  -108606000, useSingularKey:  false);
        UnityEngine.GameObject val_4 = this.buttonContinue.gameObject;
        this.buttonContinue.SetActive(value:  true);
    }
    protected virtual void HidePickAnotherGroup()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.pickAnotherGroup)) == false)
        {
                return;
        }
        
        R4 + 28.SetActive(value:  false);
    }
    protected virtual void ShowPickRewardText()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.pickARewardText)) != false)
        {
                UnityEngine.GameObject val_2 = this.pickARewardText.gameObject;
            this.pickARewardText.SetActive(value:  true);
            string val_3 = Localization.Localize(key:  -108340640, defaultValue:  -108340736, useSingularKey:  false);
            string val_4 = System.String.Format(format:  -1183154368, arg0:  -108340528, arg1:  -108340640, arg2:  -1319592656);
            if(this.pickARewardText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        }
        else
        {
                var val_5 = FP - 16;
        }
    
    }
    private void ClosePopup()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -108192144, method:  new IntPtr(4185872384));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
        val_5 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_5;
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -108192144, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public virtual void OnRewardButtonClick(UnityEngine.GameObject reward)
    {
        var val_18;
        this.rewardBtn = reward;
        val_18 = 1152921512050304720;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    public WGDailyBonusPopup()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
    }
    private void <Init_v2>b__22_0()
    {
        UnityEngine.GameObject val_1 = this.rewardButton1.gameObject;
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_14C;
    }
    private void <Init_v2>b__22_1()
    {
        UnityEngine.GameObject val_1 = this.rewardButton2.gameObject;
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_14C;
    }
    private void <Init_v2>b__22_2()
    {
        UnityEngine.GameObject val_1 = this.rewardButton3.gameObject;
        goto typeof(WGDailyBonusPopup).__il2cppRuntimeField_14C;
    }

}
