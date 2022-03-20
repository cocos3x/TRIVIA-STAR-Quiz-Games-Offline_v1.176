using UnityEngine;
public class BBLLevelClearPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image background;
    private UnityEngine.CanvasGroup contentGroup;
    private UnityEngine.UI.Text progressPercentText;
    private UnityEngine.UI.Image rainbowProgressOutline;
    private UnityEngine.UI.Text chapterIndexText;
    private UnityEngine.UI.Text rewardAmountText;
    private ExtraProgress chapterProgressBar;
    private UnityEngine.UI.Text chapterProgressBarText;
    private UnityEngine.GameObject levelClearContent;
    private UnityEngine.GameObject chapterClearContent;
    private UnityEngine.GameObject freeCoinGroup;
    private UnityEngine.UI.Button freeCoinsButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.CanvasGroup continueCanvasGroup;
    private GridCoinCollectAnimationInstantiator coinAnimation;
    private bool chapterComplete;
    
    // Methods
    private void Awake()
    {
        if(this.freeCoinsButton == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  2124349840, method:  new IntPtr(2124324816));
        this.freeCoinsButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.continueCanvasGroup.alpha = null;
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  2124482320, method:  new IntPtr(2124454224));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  0, ignoreTimeScale:  false);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  2124482320, method:  new IntPtr(2124455248));
        DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1075838976, ignoreTimeScale:  false);
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  2124482320, method:  new IntPtr(2124456272));
        DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1077097267, ignoreTimeScale:  false);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  2124482320, method:  new IntPtr(2124457296));
        DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1081291571, ignoreTimeScale:  false);
    }
    public void Setup(bool isChapterComplete, int chapterId, int chapterPlayerLevel, int chapterMinLevel, int chapterMaxLevel)
    {
        int val_28;
        bool val_29;
        UnityEngine.GameObject val_30;
        val_28 = chapterId;
        object val_1 = new System.Object();
        typeof(BBLLevelClearPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_C = this;
        this.chapterComplete = isChapterComplete;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = 0;
        if(CanShowPostLevelOffer() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_5 = App.getBehavior;
            val_29 = 0;
            val_28 = val_28;
            if((CanShowPostLevelRewardedVideo(playerLevel:  -1)) != false)
        {
                WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            bool val_8 = rewardVideoCapReached;
            if(val_8 == false)
        {
                val_8 = this.chapterComplete;
        }
        
            if(val_8 == false)
        {
                val_29 = val_8 >> 5;
        }
        
        }
        
        }
        
        string val_9 = System.String.Format(format:  2124579536, arg0:  13152256);
        float val_11 = UnityEngine.Mathf.InverseLerp(a:  (float)chapterPlayerLevel, b:  null, value:  null);
        typeof(BBLLevelClearPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = (float)chapterMinLevel - 1;
        this.chapterProgressBar.target = 1f;
        this.chapterProgressBar.current = UnityEngine.Mathf.InverseLerp(a:  (float)chapterPlayerLevel - 1, b:  null, value:  null);
        float val_28 = 100f;
        val_28 = (typeof(BBLLevelClearPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_8) * val_28;
        string val_15 = UnityEngine.Mathf.FloorToInt(f:  val_28).ToString();
        string val_16 = System.String.Format(format:  2124591920, arg0:  2124632692);
        object val_17 = this.rainbowProgressOutline.GetComponent<System.Object>();
        float val_29 = 0.3f;
        val_29 = ((float)chapterMinLevel - 1) * val_29;
        UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_29, y:  null, z:  typeof(BBLLevelClearPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_8);
        UnityEngine.UI.Image val_19 = this.rainbowProgressOutline + 12;
        PluginExtension.SetColorAlpha(graphic:  this.rainbowProgressOutline, a:  val_29);
        DG.Tweening.Core.DOGetter<System.Single> val_20 = new DG.Tweening.Core.DOGetter<System.Single>(object:  274759680, method:  new IntPtr(2124601216));
        DG.Tweening.Core.DOSetter<System.Single> val_21 = new DG.Tweening.Core.DOSetter<System.Single>(object:  274759680, method:  new IntPtr(2124602240));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_22 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  val_29, duration:  null);
        object val_23 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  val_29);
        this.levelClearContent.SetActive(value:  false);
        val_30 = this.chapterClearContent;
        if(this.chapterComplete == true)
        {
                this.chapterComplete = 1;
        }
        
        val_30.SetActive(value:  true);
        this.freeCoinGroup.SetActive(value:  val_29);
        if(val_29 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SawPostLevelOffer();
        }
        
        if(this.chapterComplete == false)
        {
                return;
        }
        
        BlockPuzzleMagic.BestBlocksGameEcon val_25 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        decimal val_26 = val_18.x.ChapterClearedReward;
        string val_27 = ToString(format:  2124620672);
    }
    private System.Collections.IEnumerator ClearSequence()
    {
        object val_1 = new System.Object();
        typeof(BBLLevelClearPopup.<ClearSequence>d__19).__il2cppRuntimeField_8 = 0;
    }
    public void OnContinuePressed()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        if(this.chapterComplete != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelClearClosed();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnChapterClearClosed();
    }
    public void OnCollectPressed()
    {
        int val_8;
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        decimal val_2 = ChapterClearedReward;
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Chapter Complete", externalParams:  0, animated:  false);
        Player val_3 = App.Player;
        BlockPuzzleMagic.BestBlocksGameEcon val_4 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        decimal val_5 = ChapterClearedReward;
        decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 2125013836, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_7 = App.Player;
        this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_8}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
        mem[1152921511026840236].SetActive(value:  true);
        mem[1152921511026840240].SetActive(value:  false);
    }
    private void OnFreeCoinsButtonClicked()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_3 = 20887205;
        val_3 = 14738856 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        PurchaseProxy.currentPurchasePoint = 49;
        var val_4 = 20886803;
        val_4 = 14738988 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 34;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = null;
        if(0 != 0)
        {
                return;
        }
    
    }
    public BBLLevelClearPopup()
    {
    
    }
    private void <OnEnable>b__17_0()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.background, endValue:  null, duration:  null);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.background, ease:  17);
    }
    private void <OnEnable>b__17_1()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroup, endValue:  null, duration:  null);
    }
    private void <OnEnable>b__17_2()
    {
        System.Collections.IEnumerator val_1 = this.ClearSequence();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  2125607424);
    }
    private void <OnEnable>b__17_3()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.continueCanvasGroup, endValue:  null, duration:  null);
        this.continueButton.interactable = true;
    }

}
