using UnityEngine;
public class WGLightningLevelsPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Text description;
    protected UnityEngine.UI.Slider progressBar;
    protected UnityEngine.UI.Text progressText;
    protected UnityEngine.UI.Button playButton;
    protected UnityEngine.UI.Button continueButton;
    protected UGUINetworkedButton collectButton;
    protected UnityEngine.UI.Button closeButton;
    protected GridCoinCollectAnimationInstantiator coinAnim;
    protected UnityEngine.GameObject timerGroup;
    protected UnityEngine.UI.Text eventEndsText;
    protected UnityEngine.UI.Text timer;
    protected UnityEngine.GameObject rewardCoinObject;
    protected UnityEngine.UI.Text reward;
    protected UnityEngine.GameObject rewardBonusGameObject;
    protected UnityEngine.UI.Text rewardBonusGameLabel;
    protected UnityEngine.UI.Image rewardBonusGameIcon;
    protected UnityEngine.Sprite bonusIconWheel;
    protected UnityEngine.Sprite bonusIconSlots;
    private UnityEngine.UI.Text playButtonText;
    protected float progress;
    
    // Methods
    protected virtual void Awake()
    {
        System.Action<System.Boolean> val_16;
        System.Action val_17;
        UnityEngine.GameObject val_1 = this.playButton.gameObject;
        this.playButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  false);
        this.timerGroup.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1171586304, method:  new IntPtr(3123308688));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        if((UnityEngine.Object.op_Implicit(exists:  this.continueButton)) != false)
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1171586304, method:  new IntPtr(3123308688));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
        }
        
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -1171586304, method:  new IntPtr(3123330192));
        System.Delegate val_8 = System.Delegate.Combine(a:  this.collectButton.OnConnectionClick, b:  7401472);
        val_16 = this.collectButton.OnConnectionClick;
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        val_16 = 0;
        label_18:
        this.collectButton.OnConnectionClick = val_16;
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -1171586304, method:  typeof(WGLightningLevelsPopup).__il2cppRuntimeField_150);
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        System.Action val_10 = new System.Action(object:  -1171586304, method:  new IntPtr(3123347600));
        System.Delegate val_11 = System.Delegate.Combine(a:  this.coinAnim.OnCompleteCallback, b:  7454720);
        val_17 = this.coinAnim.OnCompleteCallback;
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_24;
        }
        
        }
        
        val_17 = 0;
        label_24:
        this.coinAnim.OnCompleteCallback = val_17;
        if(this.playButtonText == 0)
        {
                UnityEngine.Debug.LogError(message:  -1171614576);
            return;
        }
        
        string val_13 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_14 = App.Player;
        string val_15 = System.String.Format(format:  -1672741904, arg0:  13152256);
        if(this.playButtonText != 0)
        {
                return;
        }
    
    }
    protected virtual void OnEnable()
    {
        this.progress = this;
        this.ShowProgress();
        this.UpdateRewardInfo();
        if(<0)
        {
                this.ShowEventIncompleteUI();
            return;
        }
        
        this.ShowEventCompletedUI();
    }
    protected void OnCoinAminFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1171292672, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1171180672, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void OnClick_PlayButton()
    {
        var val_9;
        if(SceneDictator.IsInGameScene() == false)
        {
            goto label_3;
        }
        
        val_9 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
            goto label_18;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C.GetComponentInChildren<System.Object>();
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
            goto label_18;
        }
        
        goto label_18;
        label_3:
        GameBehavior val_7 = App.getBehavior;
        label_18:
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1171068672, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void ShowProgress()
    {
        if(this.progressBar == 0)
        {
            
        }
    
    }
    protected void ShowEventIncompleteUI()
    {
        var val_10;
        var val_11;
        var val_12;
        string val_1 = System.String.Format(format:  -1170848192, arg0:  -1170802608);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.timer);
        System.Action val_3 = new System.Action(object:  -1170802608, method:  new IntPtr(3124123280));
        System.Delegate val_4 = System.Delegate.Combine(a:  -1170848192, b:  7454720);
        val_10 = "{0}:";
        if(val_10 != 0)
        {
                if(("{0}:") == null)
        {
            goto label_5;
        }
        
        }
        
        val_10 = 0;
        label_5:
        mem2[0] = val_10;
        val_11 = UnityEngine.Object.op_Inequality(x:  this.continueButton, y:  0);
        UnityEngine.GameObject val_6 = this.playButton.gameObject;
        if(val_11 != false)
        {
                GameBehavior val_7 = App.getBehavior;
            this.playButton.SetActive(value:  true);
            UnityEngine.GameObject val_8 = this.continueButton.gameObject;
            GameBehavior val_9 = App.getBehavior;
            val_11 = 0;
            if(this.continueButton != 0)
        {
                val_12 = 1;
        }
        
        }
        else
        {
                val_12 = 1;
        }
        
        this.playButton.SetActive(value:  true);
        this.timerGroup.SetActive(value:  true);
    }
    protected void ShowEventCompletedUI()
    {
        UnityEngine.GameObject val_1 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
    }
    protected void UpdateEventTimer()
    {
        if(this.timer == 0)
        {
            
        }
    
    }
    protected void UpdateRewardInfo()
    {
        var val_1;
        var val_2;
        UnityEngine.Sprite val_6;
        UnityEngine.UI.Text val_7;
        if(val_1 == 4)
        {
            goto label_1;
        }
        
        if(val_1 == 3)
        {
            goto label_2;
        }
        
        if(val_1 != 1)
        {
            goto label_16;
        }
        
        this.rewardCoinObject.SetActive(value:  true);
        this.rewardBonusGameObject.SetActive(value:  false);
        string val_3 = val_2.ToString();
        val_6;
        if(this.reward >= 0)
        {
                return;
        }
        
        if(this.description != 0)
        {
                return;
        }
        
        return;
        label_1:
        string val_4 = Localization.Localize(key:  -1505604896, defaultValue:  -1505604992, useSingularKey:  false);
        val_6 = this.bonusIconSlots;
        this.rewardBonusGameIcon.sprite = val_6;
        if(this.rewardBonusGameIcon >= 0)
        {
            goto label_16;
        }
        
        val_7 = this.description;
        goto label_13;
        label_2:
        string val_5 = Localization.Localize(key:  -1505638896, defaultValue:  -1505638992, useSingularKey:  false);
        val_6 = this.bonusIconWheel;
        this.rewardBonusGameIcon.sprite = val_6;
        if(this.rewardBonusGameIcon >= 0)
        {
            goto label_16;
        }
        
        val_7 = this.description;
        label_13:
        val_6 = this;
        label_16:
        this.rewardCoinObject.SetActive(value:  false);
        this.rewardBonusGameObject.SetActive(value:  true);
    }
    protected void OnClick_CollectButton(bool connected)
    {
        var val_1;
        int val_10;
        int val_15;
        var val_20;
        WGLightningLevelsPopup val_21;
        this.collectButton.interactable = false;
        if(connected == false)
        {
            goto label_2;
        }
        
        val_20 = val_1;
        val_21 = this;
        if(val_20 == 1)
        {
            goto label_3;
        }
        
        if(val_20 == 3)
        {
            goto label_4;
        }
        
        if(val_20 != 4)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_20 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_40 = val_21;
        System.Action val_4 = new System.Action(object:  -1170160048, method:  typeof(WGLightningLevelsPopup).__il2cppRuntimeField_138);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_44 = null;
        goto label_10;
        label_2:
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1170160048, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_3:
        UnityEngine.GameObject val_6 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  true);
        Player val_8 = App.Player;
        decimal val_9 = System.Decimal.op_Implicit(value:  -1170172112);
        0.AddCredits(amount:  new System.Decimal() {mid = val_10}, source:  this, subSource:  0, externalParams:  0, doTrack:  true);
        val_21 = this.coinAnim;
        Player val_11 = App.Player;
        decimal val_12 = System.Decimal.op_Implicit(value:  -1170172128);
        decimal val_13 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1170172144, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_14 = App.Player;
        val_20 = 52;
        val_21.Play(fromValue:  new System.Decimal() {mid = val_15}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_17 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_20 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_C = val_21;
        System.Action val_18 = new System.Action(object:  -1170160048, method:  typeof(WGLightningLevelsPopup).__il2cppRuntimeField_138);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = null;
        label_10:
        UnityEngine.GameObject val_19 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1170160048, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual string GetEventRemainingTime()
    {
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                return LightningLevelsEventHandler.<Instance>k__BackingField.GetEventRemainingTime();
        }
        
        return LightningLevelsEventHandler.<Instance>k__BackingField.GetEventRemainingTime();
    }
    protected virtual string GetEventEndsText()
    {
        var val_1;
        var val_1 = 27147483;
        val_1 = 8478304 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game == 18)
        {
                "LIGHTNING LEVELS ENDS" = "EVENT ENDS IN";
        }
        
        return Localization.Localize(key:  -1169947760, defaultValue:  -1276450688, useSingularKey:  false);
    }
    protected virtual System.Collections.Generic.KeyValuePair<GameEventRewardType, int> GetRewardInfo()
    {
        var val_2;
        var val_2 = 27149647;
        val_2 = 8478536 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField.Econ) != 0)
        {
            
        }
        else
        {
                val_2 = 0;
        }
        
        this = 0;
        mem[1152921512026971076] = 0;
        this = new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Int32>(key:  0, value:  -1433113904);
        return (System.Collections.Generic.KeyValuePair<GameEventRewardType, System.Int32>)this;
    }
    protected virtual string GetCoinRewardDescription()
    {
        return Localization.Localize(key:  -1169722208, defaultValue:  -1169722496, useSingularKey:  false);
    }
    protected virtual string GetBonusSlotsRewardDescription()
    {
        return Localization.Localize(key:  -1169609664, defaultValue:  -1169610064, useSingularKey:  false);
    }
    protected virtual string GetBonusWheelRewardDescription()
    {
        string val_1 = Localization.Localize(key:  -1169497088, defaultValue:  -1169497504, useSingularKey:  false);
        GameEcon val_2 = App.getGameEcon;
        int val_3 = 0.maxBonusGameWheelAwardCoins;
        GameEcon val_4 = App.getGameEcon;
        int val_5 = 0.maxBonusGameWheelAwardGoldenCurrency;
        string val_6 = System.String.Format(format:  -1169497088, arg0:  13152256, arg1:  13152256);
    }
    protected virtual string GetCongratsDescription()
    {
        string val_1 = Localization.Localize(key:  -1169384752, defaultValue:  -1169384928, useSingularKey:  false);
        string val_2 = System.String.Format(format:  -1169384752, arg0:  13152256);
    }
    protected virtual string GetEventProgressText()
    {
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    protected virtual float GetEventProgressValue()
    {
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    protected virtual void MarkEventRewarded()
    {
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            
        }
    
    }
    protected virtual string GetTrackRewardSource()
    {
    
    }
    protected virtual void ShowInternetRequiredPopup()
    {
        LightningLevelsEventHandler.<Instance>k__BackingField.ShowInternetRequiredPopup();
    }
    protected virtual void OnClick_CloseButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1168688496, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        LightningLevelsEventHandler.<Instance>k__BackingField.OnMyEventPopupClosed();
    }
    public WGLightningLevelsPopup()
    {
    
    }

}
