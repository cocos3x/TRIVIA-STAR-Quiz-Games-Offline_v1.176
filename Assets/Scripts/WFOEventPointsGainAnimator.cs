using UnityEngine;
public class WFOEventPointsGainAnimator : MonoBehaviour
{
    // Fields
    protected UnityEngine.CanvasGroup bgCanvasGroup;
    protected UnityEngine.UI.Image bgImage;
    protected UnityEngine.CanvasGroup flyoutCanvasGroup;
    protected UnityEngine.UI.Image flyoutFrameImage;
    protected UnityEngine.UI.Text eventNameText;
    protected UnityEngine.UI.Slider progressSlider;
    protected UnityEngine.UI.Image pointIconImage;
    protected UnityEngine.UI.Image rewardIconImage;
    protected UnityEngine.UI.Text rewardAmountText;
    protected UnityEngine.UI.Text meterFillLabel;
    protected UnityEngine.Sprite spriteFlyoutBgBrown;
    protected UnityEngine.Sprite spriteFlyoutBgBlue;
    protected UnityEngine.Transform pointsIconParent;
    protected UnityEngine.Transform radialRay;
    protected UnityEngine.RectTransform pointsIconRootTransform;
    protected UnityEngine.Sprite iconAttack;
    protected UnityEngine.Sprite iconRaid;
    protected UnityEngine.Sprite iconCoins;
    protected UnityEngine.Sprite iconGold;
    protected UnityEngine.Sprite iconFood;
    protected UnityEngine.Sprite iconWordHunt;
    protected UnityEngine.Sprite flyIconAttack;
    protected UnityEngine.Sprite flyIconRaid;
    private DG.Tweening.Ease easeX;
    private UnityEngine.AnimationCurve curveY;
    private float duration;
    private float symbolInterval;
    private float symbolScale;
    protected WGEventHandler eventHandler;
    
    // Properties
    protected virtual float AdditionalFlyoutLingerTime { get; }
    
    // Methods
    protected virtual float get_AdditionalFlyoutLingerTime()
    {
        return (float)S0;
    }
    private void Awake()
    {
        WordRegion val_1 = WordRegion.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        0.AddLevelCompleteBlocker(blocker:  2);
    }
    private void Start()
    {
        var val_3 = 0;
        UnityEngine.Transform val_1 = this.flyoutCanvasGroup.transform;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
        if(this.flyoutCanvasGroup != 0)
        {
                if(null != null)
        {
                val_3 = 0;
        }
        else
        {
                val_3 = this.flyoutCanvasGroup;
        }
        
        }
        
        val_3.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
    }
    public void SetHandler(WGEventHandler handler)
    {
        UnityEngine.UI.Image val_5;
        UnityEngine.Sprite val_6;
        this.eventHandler = handler;
        string val_1 = handler.EventType;
        if((System.String.op_Equality(a:  handler, b:  -1549997168)) == false)
        {
            goto label_2;
        }
        
        val_5 = this.pointIconImage;
        val_6 = this.iconAttack;
        goto label_5;
        label_2:
        if((System.String.op_Equality(a:  handler, b:  -1298907488)) == false)
        {
            goto label_4;
        }
        
        val_5 = this.pointIconImage;
        val_6 = this.iconRaid;
        goto label_5;
        label_4:
        if((System.String.op_Equality(a:  handler, b:  -1298909328)) == false)
        {
            goto label_6;
        }
        
        val_5 = this.pointIconImage;
        val_6 = this.iconWordHunt;
        label_5:
        val_5.sprite = val_6;
        label_6:
        this.UpdateValue(animated:  false);
    }
    public void ShowPointGainAnimation(int fromQty, int toQty, int maxQty, System.Action onAnimationComplete, bool onlyAnimateProgressBar = False, bool showBackground = False, bool showBrownFlyout = True)
    {
        int val_10;
        UnityEngine.RectTransform val_11;
        val_10 = fromQty;
        if(showBackground != false)
        {
                DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgCanvasGroup, endValue:  null, duration:  null);
        }
        
        this.SetFlyoutFrame(showBrownFrame:  showBrownFlyout);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.pointsIconParent.localScale = new UnityEngine.Vector3();
        if(onlyAnimateProgressBar == false)
        {
            goto label_5;
        }
        
        val_10 = 0;
        UnityEngine.Transform val_3 = this.flyoutCanvasGroup.transform;
        val_11 = 0;
        if(this.flyoutCanvasGroup == 0)
        {
            goto label_9;
        }
        
        if(null == null)
        {
            goto label_8;
        }
        
        val_11 = 0;
        goto label_9;
        label_5:
        UnityEngine.GameObject val_4 = this.pointsIconParent.gameObject;
        if(this.activeSelf != true)
        {
                UnityEngine.GameObject val_6 = this.gameObject;
            this.SetActive(value:  true);
        }
        
        System.Collections.IEnumerator val_7 = this.ShowPointGainAnimationCoroutine(fromQty:  val_10, toQty:  toQty, maxQty:  maxQty, onAnimationComplete:  onAnimationComplete);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -379952096);
        return;
        label_8:
        val_11 = this.flyoutCanvasGroup;
        label_9:
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  val_11, endValue:  val_2.x, duration:  val_2.y, snapping:  false);
        this.ShowProgressBarAnimation(fromQty:  -1041235968, toQty:  toQty, maxQty:  maxQty, parentSeq:  val_10, onAnimationComplete:  onAnimationComplete);
    }
    public void Close()
    {
        WordRegion val_1 = WordRegion.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                WordRegion val_3 = WordRegion.instance;
            0.RemoveLevelCompleteBlocker(blocker:  2);
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -379823712, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void ShowProgressBarAnimation(int fromQty, int toQty, int maxQty, DG.Tweening.Sequence parentSeq, System.Action onAnimationComplete)
    {
        UnityEngine.Transform val_36;
        DG.Tweening.Sequence val_37;
        var val_38;
        DG.Tweening.TweenCallback val_40;
        UnityEngine.RectTransform val_41;
        val_36 = maxQty;
        val_37 = parentSeq;
        if((new WFOEventPointsGainAnimator.<>c__DisplayClass36_0()) != 0)
        {
                typeof(WFOEventPointsGainAnimator.<>c__DisplayClass36_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(WFOEventPointsGainAnimator.<>c__DisplayClass36_0).__il2cppRuntimeField_C = onAnimationComplete;
        if(val_37 == 0)
        {
                DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            val_37 = 0;
        }
        
        if(toQty < val_36)
        {
                DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  367624192, method:  new IntPtr(3915239776));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        }
        else
        {
                UnityEngine.GameObject val_6 = this.rewardIconImage.gameObject;
            UnityEngine.Transform val_7 = this.pointsIconParent.parent;
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  this.rewardIconImage, parent:  this.pointsIconParent);
            val_36 = this.rewardIconImage;
            UnityEngine.Transform val_9 = val_36.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_36.localScale = new UnityEngine.Vector3();
            UnityEngine.GameObject val_11 = val_36.gameObject;
            val_36.SetActive(value:  true);
            UnityEngine.Transform val_12 = val_36.transform;
            UnityEngine.Transform val_13 = this.rewardIconImage.transform;
            UnityEngine.Vector3 val_14 = position;
            val_36.position = new UnityEngine.Vector3();
            UnityEngine.GameObject val_15 = this.rewardIconImage.gameObject;
            this.rewardIconImage.SetActive(value:  false);
            DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  367624192, method:  new IntPtr(3915257184));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_14.x);
            val_38 = null;
            val_38 = null;
            val_40 = WFOEventPointsGainAnimator.<>c.<>9__36_3;
            if(val_40 == 0)
        {
                val_40 = null;
            val_40 = new DG.Tweening.TweenCallback(object:  WFOEventPointsGainAnimator.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3915258208));
            WFOEventPointsGainAnimator.<>c.<>9__36_3 = val_40;
        }
        
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_21 = val_36.transform;
            UnityEngine.Vector3 val_22 = position;
            DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOMove(target:  val_36, endValue:  new UnityEngine.Vector3(), duration:  val_22.x, snapping:  true);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_36);
            UnityEngine.Transform val_25 = val_36.transform;
            DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  val_22.x, duration:  val_22.y);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_36);
        }
        
        if(val_36 > 0)
        {
                DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  3915293472);
        }
        
        UnityEngine.Transform val_29 = this.flyoutCanvasGroup.transform;
        val_41 = 0;
        if(this.flyoutCanvasGroup != 0)
        {
                if(null != null)
        {
                val_41 = 0;
        }
        else
        {
                val_41 = this.flyoutCanvasGroup;
        }
        
        }
        
        DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  val_41, endValue:  3915293472, duration:  val_22.y, snapping:  false);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_41);
        DG.Tweening.TweenCallback val_32 = new DG.Tweening.TweenCallback(object:  -379673824, method:  new IntPtr(3915267424));
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.TweenCallback val_34 = new DG.Tweening.TweenCallback(object:  367624192, method:  new IntPtr(3915268448));
        DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
    }
    private System.Collections.IEnumerator ShowPointGainAnimationCoroutine(int fromQty, int toQty, int maxQty, System.Action onAnimationComplete)
    {
        if((new WFOEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__37(<>1__state:  0)) != 0)
        {
            
        }
        else
        {
                mem[16] = this;
            mem[24] = fromQty;
            mem[20] = toQty;
            mem[28] = maxQty;
        }
        
        typeof(WFOEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__37).__il2cppRuntimeField_20 = onAnimationComplete;
    }
    private void MoveSymbol(DG.Tweening.Sequence sq, UnityEngine.Transform trans, UnityEngine.Transform dest, System.Action onComplete)
    {
        bool val_3;
        bool val_10;
        WFOEventPointsGainAnimator.<>c__DisplayClass38_0 val_1 = new WFOEventPointsGainAnimator.<>c__DisplayClass38_0();
        typeof(WFOEventPointsGainAnimator.<>c__DisplayClass38_0).__il2cppRuntimeField_8 = onComplete;
        UnityEngine.Vector3 val_2 = position;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  trans, endValue:  val_2.x, duration:  val_2.y, snapping:  val_3);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  trans, ease:  this.easeX);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  sq, t:  trans);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  367837184, method:  new IntPtr(3915554912));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  sq, action:  190734336);
        UnityEngine.Vector3 val_9 = position;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  trans, endValue:  val_9.x, duration:  val_9.y, snapping:  val_10);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  trans, animCurve:  this.curveY);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  sq, t:  trans);
        UnityEngine.Vector3 val_14 = localScale;
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3(), duration:  this.duration);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  sq, t:  trans);
    }
    private void OnIndividualPointIconAnimComplete(UnityEngine.GameObject pointObj)
    {
        UnityEngine.Object.Destroy(obj:  pointObj);
    }
    private UnityEngine.Sprite GetFlySprite()
    {
        var val_4;
        UnityEngine.Sprite val_5;
        val_4 = 0;
        string val_1 = this.eventHandler.EventType;
        if((System.String.op_Equality(a:  this.eventHandler, b:  -1549997168)) != false)
        {
                val_5 = this.flyIconAttack;
        }
        else
        {
                if((System.String.op_Equality(a:  this.eventHandler, b:  -1298907488)) == false)
        {
                return;
        }
        
            val_5 = this.iconRaid;
        }
        
        val_4 = mem[this.iconRaid];
    }
    private void UpdateValue(bool animated = False)
    {
        if(this.eventHandler != 0)
        {
                UnityEngine.GameObject val_1 = this.rewardIconImage.gameObject;
            this.rewardIconImage.SetActive(value:  false);
            return;
        }
        
        if(this.eventHandler != 0)
        {
                WGEventHandler val_6 = this.eventHandler;
            GameEventRewardType val_2 = RESEventRewardTypeExtensions.ToGameEventRewardType(rewardType:  this.eventHandler.myEvent);
            val_6 = val_6 + 16;
            GameEcon val_3 = App.getGameEcon;
            string val_4 = val_6.ToString(format:  null);
            this.SetRewardDisplay(gameEventRewardType:  this.eventHandler.myEvent, rewardText:  val_6);
        }
        
        this.SetProgressBarValue(pointsCollected:  UnityEngine.Mathf.Min(a:  this.eventHandler, b:  this.eventHandler), pointsRequired:  this.eventHandler, animated:  animated);
    }
    public void SetRewardDisplay(GameEventRewardType gameEventRewardType, string rewardText)
    {
        UnityEngine.UI.Image val_4;
        UnityEngine.Sprite val_5;
        if(gameEventRewardType == 5)
        {
            goto label_0;
        }
        
        if(gameEventRewardType == 2)
        {
            goto label_1;
        }
        
        if(gameEventRewardType != 1)
        {
            goto label_2;
        }
        
        val_4 = this.rewardIconImage;
        val_5 = this.iconCoins;
        goto label_4;
        label_0:
        val_4 = this.rewardIconImage;
        val_5 = this.iconFood;
        goto label_4;
        label_1:
        val_4 = this.rewardIconImage;
        val_5 = this.iconGold;
        label_4:
        val_4.sprite = val_5;
        label_2:
        UnityEngine.GameObject val_1 = this.rewardAmountText.gameObject;
        this.rewardAmountText.SetActive(value:  (System.String.IsNullOrEmpty(value:  rewardText)) ^ 1);
        if(this.rewardAmountText == 0)
        {
            
        }
    
    }
    public void SetProgressBarValue(int pointsCollected, int pointsRequired, bool animated = False)
    {
        int val_10;
        int val_11;
        int val_12;
        var val_13;
        var val_14;
        val_10 = pointsRequired;
        val_11 = pointsCollected;
        WFOEventPointsGainAnimator.<>c__DisplayClass43_0 val_1 = new WFOEventPointsGainAnimator.<>c__DisplayClass43_0();
        if(val_1 != 0)
        {
                val_12 = val_1;
            typeof(WFOEventPointsGainAnimator.<>c__DisplayClass43_0).__il2cppRuntimeField_10 = val_11;
            val_13 = 1152921504974737424;
            WFOEventPointsGainAnimator.<>c__DisplayClass43_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFF8 = this;
            WFOEventPointsGainAnimator.<>c__DisplayClass43_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = val_10;
        }
        else
        {
                mem[8] = this;
            val_13 = 12;
            mem[12] = val_10;
            val_12 = 16;
            mem[16] = val_11;
            val_11 = mem[16];
            val_10 = mem[12];
        }
        
        if(animated != false)
        {
                DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.progressSlider, endValue:  (float)val_10, duration:  null, snapping:  (float)val_11 / (float)val_10);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.progressSlider, ease:  1);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  367890432, method:  new IntPtr(3916312640));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  this.progressSlider, action:  190734336);
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  367890432, method:  new IntPtr(3916313664));
            object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.progressSlider, action:  190734336);
            return;
        }
        
        if(this.eventHandler != 0)
        {
                val_14 = "COMPLETED";
        }
        else
        {
                string val_9 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_14 = "{0}/{1}";
        }
        
        if(this.meterFillLabel != 0)
        {
                return;
        }
    
    }
    private void SetFlyoutFrame(bool showBrownFrame)
    {
        if(showBrownFrame == true)
        {
                56 = 52;
        }
        
        this.flyoutFrameImage.sprite = this.spriteFlyoutBgBrown;
    }
    private void SetBackground(bool darken)
    {
        if(darken == false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgCanvasGroup, endValue:  null, duration:  null);
    }
    public WFOEventPointsGainAnimator()
    {
        this.duration = 1f;
        this.symbolInterval = 0.2f;
        this.symbolScale = 1f;
    }
    private void <ShowPointGainAnimationCoroutine>b__37_3()
    {
        UnityEngine.GameObject val_1 = this.radialRay.gameObject;
        this.radialRay.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.pointsIconRootTransform.gameObject;
        this.pointsIconRootTransform.SetActive(value:  false);
    }

}
