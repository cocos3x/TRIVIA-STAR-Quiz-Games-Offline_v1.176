using UnityEngine;
public class PiggyBankV2Popup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject previewWindow;
    private UnityEngine.GameObject mainWindow;
    private UnityEngine.GameObject interstitialWindow;
    private UnityEngine.Playables.PlayableDirector interstitialToReadyDirector;
    private UnityEngine.Playables.PlayableDirector previewDirector;
    private UnityEngine.GameObject maxedOutImage;
    private UnityEngine.UI.Text bankAmountText;
    private UnityEngine.UI.Text openButtonText;
    private UnityEngine.UI.Text timerText;
    private UGUINetworkedButton openButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text interstitialBankAmountText;
    private UnityEngine.GameObject piggyBankGraphic;
    private UnityEngine.UI.Image piggyBankOverlay;
    private GoldenCurrencyCollectAnimationInstantiator interstitialGoldAnimation;
    private GridCoinCollectAnimationInstantiator coinAnimation;
    private decimal coinRewardAmount;
    private System.DateTime dealEndTime;
    private bool playPreviewOnAwake;
    private bool playInterstitialOnAwake;
    private DG.Tweening.Sequence timerSequence;
    
    // Methods
    private void Awake()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.closeButton)) == false)
        {
                return;
        }
        
        this.closeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1088288480, method:  new IntPtr(3206653792));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(PiggyBankV2Popup.<Start>d__22).__il2cppRuntimeField_8 = 0;
        typeof(PiggyBankV2Popup.<Start>d__22).__il2cppRuntimeField_10 = this;
    }
    private void OnDisable()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    private void OnDestroy()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    public void SetupPreview()
    {
        this.playPreviewOnAwake = true;
        this.SetupMain();
    }
    public void SetupMain()
    {
        System.DateTime val_5;
        var val_6;
        System.Action<System.Boolean> val_10;
        var val_11;
        this.mainWindow.SetActive(value:  true);
        decimal val_1 = BankAmountCurrent;
        if((PiggyBankV2Handler.minDowngradeTier + 116) != 0)
        {
                PiggyBankV2Handler.minDowngradeTier + 116 = 1;
        }
        
        this.maxedOutImage.SetActive(value:  true);
        GameEcon val_2 = App.getGameEcon;
        string val_3 = this.coinRewardAmount.ToString(format:  null);
        string val_4 = PiggyBankV2Handler.minDowngradeTier + 112.LocalPrice;
        this.dealEndTime = val_5;
        mem[1152921512109115652] = val_6;
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -1087666016, method:  new IntPtr(3207276256));
        System.Delegate val_8 = System.Delegate.Combine(a:  this.openButton.OnConnectionClick, b:  7401472);
        val_10 = this.openButton.OnConnectionClick;
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        val_10 = 0;
        label_20:
        this.openButton.OnConnectionClick = val_10;
        val_11 = null;
        val_11 = null;
        bool val_9 = System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = this.dealEndTime}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue});
        if(val_9 == true)
        {
                val_9 = this;
            this.StartTimer();
        }
    
    }
    public void SetupInterstitial()
    {
        this.playInterstitialOnAwake = true;
    }
    private void PlayInterstitialAnimation()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        object val_1 = new System.Object();
        var val_22 = 25792209;
        typeof(PiggyBankV2Popup.<>c__DisplayClass28_0).__il2cppRuntimeField_C = this;
        val_22 = 9838968 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_2 = BankAmountOld;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_3 = BankAmountCurrent;
        GameEcon val_8 = App.getGameEcon;
        string val_9 = ToString(format:  null);
        this.interstitialWindow.SetActive(value:  true);
        typeof(PiggyBankV2Popup.<>c__DisplayClass28_0).__il2cppRuntimeField_8 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = val_13});
        DG.Tweening.Core.DOGetter<System.Int32> val_15 = new DG.Tweening.Core.DOGetter<System.Int32>(object:  329605120, method:  new IntPtr(3207534048));
        DG.Tweening.Core.DOSetter<System.Int32> val_16 = new DG.Tweening.Core.DOSetter<System.Int32>(object:  329605120, method:  new IntPtr(3207535072));
        DG.Tweening.Tweener val_18 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7}), duration:  null);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  null);
        this.PopPiggyBankGraphic(initialDelay:  null);
        System.Action val_20 = new System.Action(object:  -1087397984, method:  new IntPtr(3207540192));
        mem2[0] = null;
        this.interstitialGoldAnimation.Play(fromValue:  System.Decimal.ToInt32(d:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnInterstitialAnimationComplete()
    {
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.__unknownFiledOffset_78 = PiggyBankV2Handler.minDowngradeTier + 36;
        }
        else
        {
                PiggyBankV2Handler.minDowngradeTier.__unknownFiledOffset_78 = PiggyBankV2Handler.minDowngradeTier + 36;
        }
        
        if((PiggyBankV2Handler.minDowngradeTier + 116) != 0)
        {
                this.interstitialToReadyDirector.Play();
            this.SetupMain();
            return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1087265504, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void PopPiggyBankGraphic(float initialDelay)
    {
        UnityEngine.Transform val_1 = this.piggyBankGraphic.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggyBankGraphic, endValue:  initialDelay, duration:  null);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.piggyBankGraphic, delay:  initialDelay);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.piggyBankOverlay, endValue:  initialDelay, duration:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.piggyBankOverlay, delay:  initialDelay);
        UnityEngine.Transform val_6 = this.piggyBankGraphic.transform;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggyBankGraphic, endValue:  initialDelay, duration:  null);
        float val_11 = 0.15f;
        val_11 = R1 + val_11;
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.piggyBankGraphic, delay:  val_11);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.piggyBankOverlay, endValue:  val_11, duration:  null);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.piggyBankOverlay, delay:  val_11);
    }
    private void OnOpenButtonClick(bool result)
    {
        var val_11;
        var val_12;
        System.Func<System.Boolean> val_14;
        var val_15;
        if(result == false)
        {
            goto label_1;
        }
        
        this.openButton.interactable = false;
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1086994400, method:  new IntPtr(3207946848));
        System.Delegate val_3 = System.Delegate.Combine(a:  PiggyBankV2Handler.minDowngradeTier + 152, b:  7401472);
        val_11 = PiggyBankV2Handler.minDowngradeTier + 152;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_9;
        }
        
        }
        
        val_11 = 0;
        label_9:
        PiggyBankV2Handler.minDowngradeTier.__unknownFiledOffset_98 = val_11;
        PiggyBankV2Handler.minDowngradeTier.TryPurchase();
        return;
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_6 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_12 = null;
        val_12 = null;
        val_14 = PiggyBankV2Popup.<>c.<>9__31_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Boolean>(object:  PiggyBankV2Popup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3207947872));
            PiggyBankV2Popup.<>c.<>9__31_0 = val_14;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_14;
        val_15 = null;
        val_15 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_10 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1086994400, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseAttemptResult(bool result)
    {
        int val_7;
        var val_15;
        var val_16;
        var val_17;
        System.Func<System.Boolean> val_19;
        var val_20;
        var val_15 = 25789077;
        val_15 = 9842100 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1086863968, method:  new IntPtr(3207946848));
        System.Delegate val_2 = System.Delegate.Remove(source:  PiggyBankV2Handler.minDowngradeTier + 152, value:  7401472);
        val_15 = PiggyBankV2Handler.minDowngradeTier + 152;
        if(val_15 != 0)
        {
                if(val_15 == null)
        {
            goto label_5;
        }
        
        }
        
        val_15 = 0;
        label_5:
        PiggyBankV2Handler.minDowngradeTier.__unknownFiledOffset_98 = val_15;
        if(result != false)
        {
                System.Action val_3 = new System.Action(object:  -1086863968, method:  new IntPtr(3208073184));
            this.coinAnimation.OnCompleteCallback = null;
            Player val_4 = App.Player;
            val_16 = 52;
            val_16 = val_16;
            decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1086876020, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.coinRewardAmount, mid = result});
            Player val_6 = App.Player;
            this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_7}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        GameBehavior val_8 = App.getBehavior;
        string val_10 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_11 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_12 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_17 = null;
        val_17 = null;
        val_19 = PiggyBankV2Popup.<>c.<>9__32_0;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Func<System.Boolean>(object:  PiggyBankV2Popup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3208078304));
            PiggyBankV2Popup.<>c.<>9__32_0 = val_19;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_19;
        val_20 = null;
        val_20 = null;
        0.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_14 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1086863968, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnCollectAnimationComplete()
    {
        this.Close();
    }
    private void StartTimer()
    {
        if(this.timerText == 0)
        {
                return;
        }
        
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -1086614368, method:  new IntPtr(3208319712));
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    private string GetDateString()
    {
        long val_2;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_17 = 25787153;
        val_17 = 9844024 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetTimeRemaining();
        val_17 = null;
        val_17 = null;
        bool val_4 = System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_2}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero});
        if(val_4 == true)
        {
                val_4 = this;
            this.Close();
        }
        
        val_18 = 0;
        if(val_2.Days < 1)
        {
            goto label_5;
        }
        
        val_19 = 1152921504619999232;
        val_2 = val_2.Days;
        val_20 = null;
        int val_7 = val_2.Hours;
        val_21 = null;
        int val_8 = val_2.Minutes;
        val_22 = null;
        val_23 = "{0}d {1}h {2}m";
        goto label_6;
        label_5:
        val_18 = 0;
        if(val_2.Hours < 1)
        {
            goto label_7;
        }
        
        val_19 = 1152921504619999232;
        val_2 = val_2.Hours;
        val_20 = null;
        int val_11 = val_2.Minutes;
        val_21 = null;
        int val_12 = val_2.Seconds;
        val_22 = null;
        val_23 = "{0}h {1}m {2}s";
        label_6:
        string val_13 = System.String.Format(format:  -1135144144, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        return;
        label_7:
        val_2 = val_2.Minutes;
        int val_15 = val_2.Seconds;
        string val_16 = System.String.Format(format:  -1086509984, arg0:  13152256, arg1:  13152256);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1086373888, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public PiggyBankV2Popup()
    {
    
    }
    private void <StartTimer>b__34_0()
    {
        string val_1 = Localization.Localize(key:  -1118401280, defaultValue:  -1118401376, useSingularKey:  false);
        string val_2 = this.GetDateString();
        string val_3 = System.String.Format(format:  1592589744, arg0:  -1118401280, arg1:  -1086145792);
        if(this.timerText == 0)
        {
            
        }
    
    }

}
