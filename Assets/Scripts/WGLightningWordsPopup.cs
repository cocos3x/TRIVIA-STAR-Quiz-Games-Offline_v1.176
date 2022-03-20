using UnityEngine;
public class WGLightningWordsPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text descriptionText;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Button levelButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text levelButtonText;
    private UnityEngine.GameObject timerGroup;
    private UnityEngine.UI.Text lightningWordsEndsText;
    private UnityEngine.UI.Text timerText;
    private UGUINetworkedButton collectButton;
    private UnityEngine.UI.Button closeButton;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private UnityEngine.GameObject rewardCoinObject;
    private UnityEngine.UI.Text reward;
    private UnityEngine.GameObject rewardBonusGameObject;
    private UnityEngine.UI.Text rewardBonusGameLabel;
    private UnityEngine.UI.Image rewardBonusGameIcon;
    private UnityEngine.Sprite bonusIconWheel;
    private UnityEngine.Sprite bonusIconSlots;
    private UnityEngine.ParticleSystem victorySystem;
    private float progress;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_14;
        System.Action val_15;
        UnityEngine.GameObject val_1 = this.levelButton.gameObject;
        this.levelButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  false);
        this.timerGroup.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  11548000, method:  new IntPtr(11474848));
        this.levelButton.m_OnClick.AddListener(call:  162246656);
        if(this.continueButton != 0)
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  11548000, method:  new IntPtr(11474848));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
        }
        
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  11548000, method:  new IntPtr(11496352));
        System.Delegate val_8 = System.Delegate.Combine(a:  this.collectButton.OnConnectionClick, b:  7401472);
        val_14 = this.collectButton.OnConnectionClick;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        val_14 = 0;
        label_18:
        this.collectButton.OnConnectionClick = val_14;
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  11548000, method:  new IntPtr(11505568));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        System.Action val_10 = new System.Action(object:  11548000, method:  new IntPtr(11514784));
        System.Delegate val_11 = System.Delegate.Combine(a:  this.coinAnim.OnCompleteCallback, b:  7454720);
        val_15 = this.coinAnim.OnCompleteCallback;
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_24;
        }
        
        }
        
        val_15 = 0;
        label_24:
        this.coinAnim.OnCompleteCallback = val_15;
        if(this.victorySystem == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_13 = this.victorySystem.gameObject;
        this.victorySystem.SetActive(value:  false);
    }
    private void OnEnable()
    {
        float val_1 = LightningWordsHandler.DEFAULT_REWARD_VALUE.GetEventProgress();
        this.progress = LightningWordsHandler.DEFAULT_REWARD_VALUE;
        this.ShowProgress();
        this.UpdateRewardInfo();
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE < 0)
        {
                this.ShowEventIncompleteUI();
            return;
        }
        
        this.ShowEventCompletedUI();
    }
    private void ShowProgress()
    {
        string val_1 = LightningWordsHandler.DEFAULT_REWARD_VALUE.GetEventProgressText(spaced:  true);
        if(this.progressBar == 0)
        {
            
        }
    
    }
    private void ShowEventIncompleteUI()
    {
        var val_16;
        UnityEngine.GameObject val_1 = this.levelButton.gameObject;
        this.levelButton.SetActive(value:  true);
        if(this.levelButtonText != 0)
        {
                string val_3 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
            Player val_4 = App.Player;
            string val_5 = System.String.Format(format:  -1672741904, arg0:  13152256);
        }
        
        if(this.continueButton != 0)
        {
                UnityEngine.GameObject val_7 = this.continueButton.gameObject;
            GameBehavior val_8 = App.getBehavior;
            if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
            this.continueButton.SetActive(value:  true);
            UnityEngine.GameObject val_9 = this.levelButton.gameObject;
            GameBehavior val_10 = App.getBehavior;
            this.levelButton.SetActive(value:  true);
        }
        
        string val_11 = Localization.Localize(key:  11970704, defaultValue:  11970592, useSingularKey:  false);
        string val_12 = 11970704 + 1269544640;
        twelvegigs.Autopilot.WUTAutopilotGameplay val_13 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.timerText);
        System.Action val_14 = new System.Action(object:  12008144, method:  new IntPtr(11979024));
        System.Delegate val_15 = System.Delegate.Combine(a:  11970704, b:  7454720);
        val_16 = "lightning_words_ends_upper";
        if(val_16 != 0)
        {
                if("lightning_words_ends_upper" == null)
        {
            goto label_27;
        }
        
        }
        
        val_16 = 0;
        label_27:
        mem2[0] = val_16;
        this.timerGroup.SetActive(value:  true);
    }
    private void ShowEventCompletedUI()
    {
        var val_7;
        string val_1 = Localization.Localize(key:  12133184, defaultValue:  12133008, useSingularKey:  false);
        val_7 = null;
        val_7 = null;
        string val_2 = System.String.Format(format:  12133184, arg0:  13152256);
        UnityEngine.GameObject val_3 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        if(this.victorySystem == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_6 = this.victorySystem.gameObject;
        this.victorySystem.SetActive(value:  true);
        this.victorySystem.Play();
    }
    private void UpdateEventTimer()
    {
        string val_1 = LightningWordsHandler.DEFAULT_REWARD_VALUE.GetEventRemainingTime();
        if(this.timerText == 0)
        {
            
        }
    
    }
    private void UpdateRewardInfo()
    {
        var val_13;
        UnityEngine.Sprite val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        float val_19;
        UnityEngine.UI.Text val_20;
        var val_21;
        val_13 = this;
        val_14 = 1152921504984055808;
        val_15 = null;
        val_15 = null;
        if(LightningWordsEcon.rewardType == 4)
        {
            goto label_3;
        }
        
        if(LightningWordsEcon.rewardType == 3)
        {
            goto label_4;
        }
        
        if(LightningWordsEcon.rewardType != 1)
        {
            goto label_19;
        }
        
        this.rewardCoinObject.SetActive(value:  true);
        this.rewardBonusGameObject.SetActive(value:  false);
        val_16 = null;
        val_16 = null;
        string val_1 = ToString();
        val_14 = 1152921504984059908;
        if(this.reward >= 0)
        {
                return;
        }
        
        string val_2 = Localization.Localize(key:  12427216, defaultValue:  12426944, useSingularKey:  false);
        if(this.descriptionText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_3:
        string val_3 = Localization.Localize(key:  -1505604896, defaultValue:  -1505604992, useSingularKey:  false);
        val_14 = mem[R4 + 84];
        val_14 = R4 + 84;
        R4 + 76.sprite = val_14;
        if((R4 + 76) >= 0)
        {
            goto label_19;
        }
        
        val_20 = mem[R4 + 12];
        val_20 = R4 + 12;
        val_21 = "lightning_words_event_bonus_slots";
        string val_4 = Localization.Localize(key:  12431856, defaultValue:  public System.Void SLC.Minigames.TwistyArrow.TwistyUIController::ShowCheck(), useSingularKey:  false);
        goto label_16;
        label_4:
        string val_5 = Localization.Localize(key:  -1505638896, defaultValue:  -1505638992, useSingularKey:  false);
        val_14 = this.bonusIconWheel;
        this.rewardBonusGameIcon.sprite = val_14;
        if(this.rewardBonusGameIcon >= 0)
        {
            goto label_19;
        }
        
        val_20 = this.descriptionText;
        string val_6 = Localization.Localize(key:  12444688, defaultValue:  12444288, useSingularKey:  false);
        val_18 = "lightning_words_event_bonus_wheel";
        GameEcon val_7 = App.getGameEcon;
        int val_8 = 0.maxBonusGameWheelAwardCoins;
        val_19 = 1152921504619999232;
        val_17 = null;
        GameEcon val_9 = App.getGameEcon;
        int val_10 = 0.maxBonusGameWheelAwardGoldenCurrency;
        val_21 = val_18;
        string val_11 = System.String.Format(format:  12444688, arg0:  13152256, arg1:  13152256);
        label_16:
        val_14 = val_21;
        label_19:
        this.rewardCoinObject.SetActive(value:  false);
        this.rewardBonusGameObject.SetActive(value:  true);
    }
    private void OnClick_LevelButton()
    {
        if(SceneDictator.IsInGameScene() != true)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  12642272, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_CollectButton(bool connected)
    {
        int val_4;
        int val_9;
        UGUINetworkedButton val_17;
        var val_18;
        var val_19;
        val_17 = this.collectButton;
        val_17.interactable = false;
        if(connected == false)
        {
            goto label_2;
        }
        
        val_18 = null;
        val_18 = null;
        if(LightningWordsEcon.rewardType == 4)
        {
            goto label_5;
        }
        
        if(LightningWordsEcon.rewardType == 3)
        {
            goto label_6;
        }
        
        if(LightningWordsEcon.rewardType != 1)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  true);
        Player val_2 = App.Player;
        val_19 = null;
        val_19 = null;
        decimal val_3 = System.Decimal.op_Implicit(value:  12754636);
        0.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  "Lightning Words Event Reward", subSource:  0, externalParams:  0, doTrack:  true);
        Player val_5 = App.Player;
        decimal val_6 = System.Decimal.op_Implicit(value:  12754620);
        decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 12754604, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_8 = App.Player;
        val_17 = 52;
        this.coinAnim.Play(fromValue:  new System.Decimal() {mid = val_9}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_2:
        var val_17 = 27137217;
        val_17 = 8490964 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        LightningWordsHandler.DEFAULT_REWARD_VALUE.ShowInternetRequiredPopup();
        label_37:
        UnityEngine.GameObject val_10 = this.gameObject;
        SLCWindow.CloseWindow(window:  12766688, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_5:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_12 = ShowUGUIMonolith<System.Object>(showNext:  true);
        var val_18 = 27136977;
        val_18 = 8491204 + val_18;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_40 = "Lightning Words Event Reward";
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action val_13 = new System.Action(object:  LightningWordsHandler.DEFAULT_REWARD_VALUE, method:  typeof(System.Int32).__il2cppRuntimeField_2E0);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_44 = null;
        goto label_37;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_15 = ShowUGUIMonolith<System.Object>(showNext:  true);
        var val_19 = 27136721;
        val_19 = 8491460 + val_19;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_C = "Lightning Words Event Reward";
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action val_16 = new System.Action(object:  LightningWordsHandler.DEFAULT_REWARD_VALUE, method:  typeof(System.Int32).__il2cppRuntimeField_2E0);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = null;
        goto label_37;
    }
    private void OnClick_CloseButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  12890976, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
            
        }
    
    }
    private void OnCoinAminFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  13002976, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  13114976, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGLightningWordsPopup()
    {
    
    }

}
