using UnityEngine;
public class WGLevelClearPopup : MonoBehaviour
{
    // Fields
    protected ExtraProgress progress;
    protected UnityEngine.UI.Text text_progress;
    protected TMPro.TextMeshProUGUI text_chapter;
    protected TMPro.TextMeshProUGUI text_chapter_shadow;
    protected UnityEngine.GameObject chapter_progress_group;
    protected UnityEngine.UI.Button buttonContinue;
    protected UnityEngine.CanvasGroup tapToContinueCanvasGroup;
    protected UnityEngine.CanvasGroup postLevelButtonsCanvasGroup;
    protected UGUINetworkedButton postLevelRewardedButton;
    protected UGUINetworkedButton postLevelAlphabetButton;
    protected UGUINetworkedButton postLevelAdControlButton;
    protected UnityEngine.UI.Text postLevelAdControlButtonText;
    protected UnityEngine.GameObject postLevelAlphabetRewardGroup;
    private UnityEngine.ParticleSystem completeAnimation;
    protected UnityEngine.GameObject group_tapToContinue;
    protected UnityEngine.GameObject group_freeHint;
    protected LevelCompletePopup levelCompletePopup;
    protected WGLevelClearPopup.OfferButton offerButton;
    private System.Action onEnableAction;
    
    // Methods
    public void Init()
    {
        this.completeAnimation.Play();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  0, oneshot:  true, pitch:  null, vol:  null);
    }
    public void Setup(bool shouldBeShowing)
    {
        this.group_tapToContinue.SetActive(value:  shouldBeShowing);
        this.group_freeHint.SetActive(value:  shouldBeShowing);
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  shouldBeShowing);
        if(shouldBeShowing == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                this.Init();
            return;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        if(this.activeInHierarchy == true)
        {
                return;
        }
        
        System.Action val_6 = new System.Action(object:  3548576, method:  new IntPtr(3523552));
        this.onEnableAction = null;
    }
    public void SetupLevelCompletePopup(LevelCompletePopup popup)
    {
        this.levelCompletePopup = popup;
    }
    private void OnEnable()
    {
        if(this.onEnableAction != 0)
        {
                this.onEnableAction.Invoke();
        }
        
        this.onEnableAction = 0;
    }
    protected virtual void Start()
    {
        UnityEngine.Events.UnityAction val_11;
        var val_12;
        System.Action<System.Boolean> val_14;
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.GameObject val_2 = this.gameObject;
        0.SetSelectedGameObject(selected:  3949088);
        val_11 = null;
        val_11 = new UnityEngine.Events.UnityAction(object:  3949088, method:  typeof(WGLevelClearPopup).__il2cppRuntimeField_F0);
        this.buttonContinue.m_OnClick.AddListener(call:  162246656);
        if(this.postLevelRewardedButton != 0)
        {
                val_12 = null;
            val_12 = null;
            val_14 = WGLevelClearPopup.<>c.<>9__24_0;
            if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Action<System.Boolean>(object:  WGLevelClearPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3901536));
            WGLevelClearPopup.<>c.<>9__24_0 = val_14;
        }
        
            this.postLevelRewardedButton.OnConnectionClick = val_14;
        }
        
        if(this.postLevelAlphabetButton != 0)
        {
                if(this.postLevelAlphabetRewardGroup != 0)
        {
                val_11 = this.postLevelAlphabetButton;
            System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  3949088, method:  new IntPtr(3914848));
            this.postLevelAlphabetButton.OnConnectionClick = null;
        }
        
        }
        
        if(this.postLevelAdControlButton == 0)
        {
                return;
        }
        
        val_11 = this.postLevelAdControlButton;
        System.Action<System.Boolean> val_10 = new System.Action<System.Boolean>(object:  3949088, method:  new IntPtr(3924064));
        this.postLevelAdControlButton.OnConnectionClick = null;
    }
    protected virtual void UpdateUI()
    {
        ExtraProgress val_32;
        OfferButton val_33;
        UGUINetworkedButton val_34;
        var val_35;
        UnityEngine.GameObject val_1 = this.chapter_progress_group.gameObject;
        this.chapter_progress_group.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  4078144, defaultValue:  4078048, useSingularKey:  false);
        string val_3 = 4078144 + 1297836560 + 13152256;
        this.text_chapter.text = 4078144;
        this.text_chapter_shadow.text = 4078144;
        this.progress.target = 0f;
        this.progress.current = null;
        val_32 = this.progress;
        if(this.progress != 0)
        {
            goto label_7;
        }
        
        val_32 = this.progress;
        if(val_32 == 0)
        {
            goto label_8;
        }
        
        label_7:
        float val_32 = 100f;
        val_32 = this.progress._current * val_32;
        val_32 = val_32 / this.progress.target;
        float val_4 = UnityEngine.Mathf.Clamp(value:  val_32, min:  null, max:  null);
        string val_5 = val_32.ToString(format:  -1946611488);
        string val_6 = 4151636 + 1472028528;
        this.HideOfferButtons();
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CanShowPostLevelOffer() == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached != false)
        {
                return;
        }
        
        val_33 = this.offerButton;
        if(val_33 == 0)
        {
                val_33 = this;
            this.offerButton = val_33;
        }
        
        if(val_33 == 3)
        {
            goto label_21;
        }
        
        if(val_33 == 2)
        {
            goto label_22;
        }
        
        if(val_33 != 1)
        {
                return;
        }
        
        if(this.postLevelRewardedButton == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_13 = App.getBehavior;
        if((CanShowPostLevelRewardedVideo(playerLevel:  -1)) == false)
        {
                return;
        }
        
        val_34 = this.postLevelRewardedButton;
        goto label_54;
        label_22:
        if(this.postLevelAlphabetButton == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_17 = App.getBehavior;
        if((CanShowPostLevelRewardedVideo(playerLevel:  -1)) == false)
        {
                return;
        }
        
        if(Alphabet2Manager.IsAvailable == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(ShouldShowPostLevelAd() == false)
        {
                return;
        }
        
        val_34 = this.postLevelAlphabetButton;
        goto label_54;
        label_21:
        if(this.postLevelAdControlButton == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_24 = App.getBehavior;
        if((CanShowPostLevelAdsControlOffer(playerLevel:  -1)) == false)
        {
                return;
        }
        
        var val_33 = 28689149;
        val_33 = 6938276 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
                return;
        }
        
        NotificationCenter val_26 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  4163680, name:  2128120864);
        string val_27 = Localization.Localize(key:  -372696592, defaultValue:  -372696704, useSingularKey:  false);
        GameEcon val_28 = App.getGameEcon;
        string val_29 = System.String.Format(format:  -372696592, arg0:  13152256);
        val_34 = this.postLevelAdControlButton;
        label_54:
        UnityEngine.GameObject val_30 = val_34.gameObject;
        val_34.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SawPostLevelOffer();
        return;
        label_8:
    }
    public virtual void OnClick_TapToContinue()
    {
        if((UnityEngine.Mathf.Approximately(a:  this.tapToContinueCanvasGroup.alpha, b:  null)) == false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  4357600, method:  typeof(WGLevelClearPopup).__il2cppRuntimeField_F0);
        this.buttonContinue.m_OnClick.RemoveListener(call:  162246656);
        if(this.levelCompletePopup == 0)
        {
            
        }
    
    }
    public virtual void PlayStartAnims()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeSelf == false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 36, endValue:  null, duration:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  R4 + 36, delay:  null);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 40, endValue:  null, duration:  null);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  R4 + 40, delay:  null);
    }
    private void OnDestroy()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  4597984, name:  2128120864);
    }
    protected void HideOfferButtons()
    {
        if(this.postLevelRewardedButton != 0)
        {
                UnityEngine.GameObject val_2 = this.postLevelRewardedButton.gameObject;
            this.postLevelRewardedButton.SetActive(value:  false);
        }
        
        if(this.postLevelAlphabetButton != 0)
        {
                UnityEngine.GameObject val_4 = this.postLevelAlphabetButton.gameObject;
            this.postLevelAlphabetButton.SetActive(value:  false);
        }
        
        if(this.postLevelAdControlButton == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_6 = this.postLevelAdControlButton.gameObject;
        this.postLevelAdControlButton.SetActive(value:  false);
    }
    private void ForceShowOfferButton(WGLevelClearPopup.OfferButton offer)
    {
        this.offerButton = offer;
    }
    private void OnClick_PostLevelAdControlButton(bool success)
    {
        var val_4;
        if(success == false)
        {
            goto label_1;
        }
        
        UnityEngine.GameObject val_1 = this.postLevelAdControlButton.gameObject;
        this.postLevelAdControlButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_3 = ShowIncentivizedVideo(tag:  24, adCapExempt:  false);
        if(val_3 == false)
        {
            goto label_7;
        }
        
        var val_4 = 28685777;
        val_4 = 6940284 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        PurchaseProxy.currentPurchasePoint = 18;
        return;
        label_1:
        this.ShowConnectionRequired();
        return;
        label_7:
        val_3.ShowVideoUnavailable();
    }
    private void ShowConnectionRequired()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = WGLevelClearPopup.<>c.<>9__32_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  WGLevelClearPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(5087520));
            WGLevelClearPopup.<>c.<>9__32_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void ShowVideoUnavailable()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = WGLevelClearPopup.<>c.<>9__33_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  WGLevelClearPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(5200544));
            WGLevelClearPopup.<>c.<>9__33_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        0.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void OnVideoResponse(Notification notif)
    {
        var val_7;
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        Player val_3 = App.Player;
        AdsManager.noAdsStartLevel = 0;
        GameBehavior val_4 = App.getBehavior;
        Player val_6 = App.Player;
        val_7 = null;
        val_7 = null;
        0.AddCredits(amount:  new System.Decimal() {flags = System.Decimal.Zero, hi = R6, lo = R7, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, source:  "Ads Control Level Complete", subSource:  0, externalParams:  0, doTrack:  true);
    }
    protected virtual WGLevelClearPopup.OfferButton GetOfferButtonToShow()
    {
        GameEcon val_1 = App.getGameEcon;
        float val_7 = 7.86253E-39f;
        val_7 = val_7 * 10f;
        GameEcon val_2 = App.getGameEcon;
        float val_8 = 1.102051E-39f;
        val_8 = val_8 * 10f;
        if(0 == 0)
        {
                -D16 = -(-D16);
        }
        
        GameEcon val_3 = App.getGameEcon;
        float val_9 = 7.65109E-43f;
        float val_4 = val_8 + S20;
        val_9 = val_9 * 10f;
        if(0 == 0)
        {
                -D16 = -(-D16);
        }
        
        int val_6 = UnityEngine.Random.Range(min:  0, max:  val_4 + val_9);
        if(val_6 <= S20)
        {
                return;
        }
        
        if(val_6 > val_4)
        {
                1 = 2;
        }
    
    }
    public WGLevelClearPopup()
    {
    
    }
    private void <Start>b__24_1(bool result)
    {
        var val_1;
        var val_1 = 28682353;
        val_1 = 6943708 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PurchaseProxy.currentPurchasePoint = 49;
        this.postLevelAlphabetRewardGroup.SetActive(value:  true);
    }

}
