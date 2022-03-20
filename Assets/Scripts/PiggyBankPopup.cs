using UnityEngine;
public class PiggyBankPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject previewWindow;
    private UnityEngine.GameObject notReadyWindow;
    private UnityEngine.GameObject readyWindow;
    private UnityEngine.GameObject interstitialWindow;
    private UnityEngine.Playables.PlayableDirector interstitialToReadyDirector;
    protected UnityEngine.Playables.PlayableDirector previewDirector;
    private System.Collections.Generic.List<UnityEngine.UI.Text> coinTexts;
    private System.Collections.Generic.List<UnityEngine.UI.Text> appleTexts;
    protected UnityEngine.UI.Text previewText;
    private ExtraProgress progressBar;
    private UnityEngine.UI.Text progressBarText;
    private UnityEngine.UI.Text percentageFreeText;
    private UnityEngine.UI.Text valueText;
    private UnityEngine.UI.Text openButtonText;
    private UnityEngine.UI.Text timerText;
    private UGUINetworkedButton openButton;
    private UnityEngine.UI.Button closeButton;
    private ExtraProgress interstitialProgressBar;
    private UnityEngine.UI.Text interstitialProgressBarText;
    protected UnityEngine.GameObject piggyBankGraphic;
    private UnityEngine.UI.Image piggyBankOverlay;
    protected GoldenCurrencyCollectAnimationInstantiator interstitialGoldAnimation;
    private GridCoinCollectAnimationInstantiator coinAnimation;
    private GoldenCurrencyCollectAnimationInstantiator goldAnimation;
    protected GemsCollectAnimationInstantiator gemAnimation;
    protected decimal coinRewardAmount;
    private int appleRewardAmount;
    private System.DateTime dealEndTime;
    protected bool playPreviewOnAwake;
    private bool playInterstitialOnAwake;
    private bool endOfChapter;
    
    // Methods
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.closeButton)) == false)
        {
                return;
        }
        
        this.closeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1122989984, method:  new IntPtr(3171952288));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(PiggyBankPopup.<Start>d__32).__il2cppRuntimeField_8 = 0;
        typeof(PiggyBankPopup.<Start>d__32).__il2cppRuntimeField_10 = this;
    }
    public virtual void SetupPreview()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_6 = 25870211;
        val_6 = 9755576 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game == 17)
        {
                string val_1 = System.String.Format(format:  -1134286320, arg0:  13152256);
            val_6 = null;
        }
        
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        if(App.game == 18)
        {
                val_8 = null;
            val_9 = "Collect {0} Acorns and buy the Piggy Bank to open it";
        }
        else
        {
                string val_2 = Localization.Localize(key:  -1134286144, defaultValue:  -1122761136, useSingularKey:  false);
            val_8 = null;
            val_9 = "piggy_bank_popup_info";
        }
        
        string val_3 = System.String.Format(format:  -1134286144, arg0:  13152256);
        UnityEngine.GameObject val_4 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                this.previewDirector.Play();
            return;
        }
        
        this.playPreviewOnAwake = true;
    }
    public void SetupNotReady()
    {
        var val_2;
        var val_2 = 25871416;
        val_2 = 9756536 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                val_2 = mem[PiggyBankHandler.iapHigh + 116];
            val_2 = PiggyBankHandler.iapHigh + 116;
        }
        else
        {
                val_2 = mem[PiggyBankHandler.iapHigh + 116];
            val_2 = PiggyBankHandler.iapHigh + 116;
            if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        this.progressBar.target = (float)val_2;
        this.progressBar.current = (float)PiggyBankHandler.iapHigh + 112;
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        this.notReadyWindow.SetActive(value:  true);
    }
    public void SetupReady(bool fromInterstitial = False, bool endOfChapter = False)
    {
        System.Action<System.Boolean> val_11;
        float val_11 = 5.097206E-38f;
        val_11 = 9757016 + val_11;
        this.endOfChapter = endOfChapter;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_1 = System.String.Format(format:  2124591920, arg0:  13152256);
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_2 = Localization.Localize(key:  -1122475424, defaultValue:  -1122475504, useSingularKey:  false);
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_3 = PiggyBankHandler.iapHigh.PricePurchaseString;
        string val_4 = System.String.Format(format:  1592589744, arg0:  -1122475424, arg1:  PiggyBankHandler.iapHigh);
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        this.dealEndTime = PiggyBankHandler.iapHigh + 136;
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -1122438016, method:  new IntPtr(3172500160));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.openButton.OnConnectionClick, b:  7401472);
        val_11 = this.openButton.OnConnectionClick;
        if(val_11 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_11 = 0;
        label_15:
        this.openButton.OnConnectionClick = val_11;
        UnityEngine.GameObject val_7 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                System.Collections.IEnumerator val_9 = this.UpdateTimer();
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1122438016);
        }
        
        if(fromInterstitial == true)
        {
                return;
        }
        
        this.readyWindow.SetActive(value:  true);
    }
    public void SetupInterstitial(bool endOfChapter = False)
    {
        this.playInterstitialOnAwake = true;
        this.endOfChapter = endOfChapter;
    }
    private void PlayInterstitialAnimation()
    {
        int val_10;
        int val_11;
        int val_12;
        var val_14;
        var val_15;
        int val_16;
        GoldenCurrencyCollectAnimationInstantiator val_17;
        GoldenCurrencyCollectAnimationInstantiator val_18;
        object val_1 = new System.Object();
        var val_14 = 25869920;
        typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = this;
        val_14 = 9758032 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                val_14 = val_1;
            typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C = PiggyBankHandler.iapHigh + 116;
        }
        else
        {
                val_14 = val_1;
            typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C = PiggyBankHandler.iapHigh + 116;
            if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                val_15 = val_1;
            typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_10 = PiggyBankHandler.iapHigh + 192;
        }
        else
        {
                val_15 = val_1;
            typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_10 = PiggyBankHandler.iapHigh + 192;
            if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_14 = PiggyBankHandler.iapHigh + 112;
        this.interstitialProgressBar.target = (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C;
        this.interstitialProgressBar.current = (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_10;
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        val_16 = 0;
        this.interstitialWindow.SetActive(value:  true);
        DG.Tweening.Core.DOGetter<System.Single> val_3 = new DG.Tweening.Core.DOGetter<System.Single>(object:  328540160, method:  new IntPtr(3172770240));
        DG.Tweening.Core.DOSetter<System.Single> val_4 = new DG.Tweening.Core.DOSetter<System.Single>(object:  328540160, method:  new IntPtr(3172771264));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_14, duration:  null);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_14);
        this.PopPiggyBankGraphic(initialDelay:  (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_14);
        mem2[0] = null;
        val_17 = this.interstitialGoldAnimation;
        val_18 = val_17;
        if(val_17 == 0)
        {
                val_18 = this.interstitialGoldAnimation;
        }
        
        if((new System.Action(object:  -1122152576, method:  new IntPtr(3172776384))) != 0)
        {
                val_16 = typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_10;
            decimal val_8 = System.Decimal.op_Implicit(value:  -1122164628);
            UnityEngine.GameObject val_9 = this.piggyBankGraphic.gameObject;
            val_17 = 49024;
            val_17 = 3212836864;
            val_18.Play(fromValue:  val_16, toValue:  new System.Decimal() {flags = typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_10, hi = val_11, lo = val_12, mid = val_10}, textTickTime:  (float)typeof(PiggyBankPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_14, delayBeforeComplete:  null, destinationObject:  val_17, originObject:  val_17);
            return;
        }
        
        System.Action val_13 = new System.Action(object:  328540160, method:  new IntPtr(3172789696));
        mem2[0] = null;
    }
    protected virtual void AnimateParticleAttraction()
    {
        UnityEngine.Object val_5;
        var val_6;
        val_5 = 9759620 + 25866167;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game != 17)
        {
                return;
        }
        
        object val_1 = this.interstitialGoldAnimation.GetComponent<System.Object>();
        val_5 = this.interstitialGoldAnimation;
        if(val_5 == 0)
        {
                return;
        }
        
        object val_3 = this.interstitialGoldAnimation.GetComponent<System.Object>();
        UnityEngine.Transform val_4 = this.piggyBankGraphic.transform;
        mem2[0] = this.piggyBankGraphic;
    }
    private void OnInterstitialAnimationComplete()
    {
        PiggyBankHandler.iapHigh.ResetGoldGainedOld();
        if((PiggyBankHandler.iapHigh + 188) != 0)
        {
                this.interstitialToReadyDirector.Play();
            this.SetupReady(fromInterstitial:  true, endOfChapter:  this.endOfChapter);
            return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1121875328, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
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
    public void OnOpenButtonClick(bool result)
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
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1121604224, method:  new IntPtr(3173337024));
        System.Delegate val_3 = System.Delegate.Combine(a:  PiggyBankHandler.iapHigh + 228, b:  7401472);
        val_11 = PiggyBankHandler.iapHigh + 228;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_9;
        }
        
        }
        
        val_11 = 0;
        label_9:
        PiggyBankHandler.iapHigh.__unknownFiledOffset_E4 = val_11;
        PiggyBankHandler.iapHigh.TryPurchase();
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
        val_14 = PiggyBankPopup.<>c.<>9__41_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Boolean>(object:  PiggyBankPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3173338048));
            PiggyBankPopup.<>c.<>9__41_0 = val_14;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_14;
        val_15 = null;
        val_15 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_10 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1121604224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseAttemptResult(bool result)
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        var val_18;
        var val_19;
        System.Func<System.Boolean> val_21;
        var val_22;
        var val_18 = 25866152;
        val_18 = 9761800 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1121478912, method:  new IntPtr(3173337024));
        System.Delegate val_2 = System.Delegate.Remove(source:  PiggyBankHandler.iapHigh + 228, value:  7401472);
        val_18 = PiggyBankHandler.iapHigh + 228;
        if(val_18 != 0)
        {
                if(val_18 == null)
        {
            goto label_5;
        }
        
        }
        
        val_18 = 0;
        label_5:
        PiggyBankHandler.iapHigh.__unknownFiledOffset_E4 = val_18;
        if(result != false)
        {
                Player val_3 = App.Player;
            Player val_4 = App.Player;
            decimal val_5 = System.Decimal.op_Implicit(value:  -1121490964);
            this.goldAnimation.Play(fromValue:  (5.605194E-45f) - this.appleRewardAmount, toValue:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_7, mid = val_6}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1069547520);
            return;
        }
        
        GameBehavior val_11 = App.getBehavior;
        string val_13 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_14 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_15 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_19 = null;
        val_19 = null;
        val_21 = PiggyBankPopup.<>c.<>9__42_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<System.Boolean>(object:  PiggyBankPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3173463360));
            PiggyBankPopup.<>c.<>9__42_0 = val_21;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_21;
        val_22 = null;
        val_22 = null;
        0.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_17 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1121478912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual void DoOnPurchaseAnimation()
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_18;
        GemsCollectAnimationInstantiator val_18;
        int val_19;
        int val_20;
        UnityEngine.GameObject val_21;
        int val_22;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                System.Action val_2 = new System.Action(object:  -1121346432, method:  new IntPtr(3160906288));
            mem2[0] = null;
            val_18 = this.gemAnimation;
            Player val_3 = App.Player;
            val_19 = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  -1121358484);
            decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1121358500}, d2:  new System.Decimal() {flags = ???, hi = this.coinRewardAmount});
            Player val_7 = App.Player;
            val_20 = 0;
            decimal val_8 = System.Decimal.op_Implicit(value:  -1121358516);
            val_21 = 1069547520;
            val_18.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = val_9}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  val_21);
            return;
        }
        
        System.Action val_13 = new System.Action(object:  -1121346432, method:  new IntPtr(3160906288));
        this.coinAnimation.OnCompleteCallback = null;
        Player val_14 = App.Player;
        var val_15 = 0 + 60;
        val_22 = mem[(0 + 60) + (0)];
        decimal val_16 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1121358484, hi = val_22, lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.coinRewardAmount + (0)], lo = mem[this.coinRewardAmount + (4)], mid = mem[this.coinRewardAmount + (8)]});
        Player val_17 = App.Player;
        val_18 = 49024;
        val_18 = 3212836864;
        this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_18}, toValue:  new System.Decimal() {hi = val_20, lo = val_21, mid = val_19}, textTickTime:  null, delayBeforeComplete:  null);
    }
    protected void OnCollectAnimationComplete()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1121218048, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetRewardAmounts()
    {
        var val_3;
        var val_4;
        var val_3 = 25863500;
        val_3 = 9764452 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
            
        }
        else
        {
                if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        this.appleRewardAmount = PiggyBankHandler.iapHigh + 172;
        val_3 = 0;
        goto label_6;
        label_11:
        if((PiggyBankHandler.iapHigh + 172) <= val_3)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        string val_1 = new System.Decimal().ToString();
        val_3 = 1;
        label_6:
        if(val_3 < ((0 + 0) + 16))
        {
            goto label_11;
        }
        
        val_4 = 0;
        goto label_12;
        label_17:
        if(((0 + 0) + 16) <= val_4)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        val_3 = mem[(0 + 0) + 16];
        val_3 = (0 + 0) + 16;
        string val_2 = this.appleRewardAmount.ToString();
        val_4 = 1;
        label_12:
        if(val_4 < val_3)
        {
            goto label_17;
        }
    
    }
    private void StartTimer()
    {
        System.Collections.IEnumerator val_1 = this.UpdateTimer();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1120961280);
    }
    private System.Collections.IEnumerator UpdateTimer()
    {
        object val_1 = new System.Object();
        typeof(PiggyBankPopup.<UpdateTimer>d__47).__il2cppRuntimeField_8 = 0;
        typeof(PiggyBankPopup.<UpdateTimer>d__47).__il2cppRuntimeField_10 = this;
    }
    private string GetDateString()
    {
        int val_3;
        long val_5;
        var val_22;
        var val_23;
        var val_25;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512076032328}, d2:  new System.DateTime() {dateData = this.dealEndTime});
        val_22 = null;
        val_22 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_5}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_23 = null;
            val_23 = null;
        }
        
        if(System.TimeSpan.Zero.Days >= 1)
        {
                val_25 = 1152921504619999232;
            val_3 = System.TimeSpan.Zero.Days;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_5 = System.TimeSpan.Zero.Hours;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            int val_11 = System.TimeSpan.Zero.Minutes;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            int val_12 = System.TimeSpan.Zero.Seconds;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            string val_13 = System.String.Format(format:  -1366069552, args:  472754880);
            return;
        }
        
        if(System.TimeSpan.Zero.Hours >= 1)
        {
                val_3 = System.TimeSpan.Zero.Hours;
            val_5 = System.TimeSpan.Zero.Minutes;
            val_25 = null;
            int val_17 = System.TimeSpan.Zero.Seconds;
            string val_18 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
            return;
        }
        
        val_25 = 1152921504619999232;
        val_3 = System.TimeSpan.Zero.Minutes;
        val_5 = System.TimeSpan.Zero.Seconds;
        string val_21 = System.String.Format(format:  -1120761280, arg0:  13152256, arg1:  13152256);
    }
    private void OnDisable()
    {
        if(PiggyBankHandler.iapHigh == null)
        {
                return;
        }
        
        goto typeof(System.String).__il2cppRuntimeField_2C4;
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1120513184, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public PiggyBankPopup()
    {
        this.coinTexts = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.appleTexts = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
