using UnityEngine;
public class BonusGameWheelPopup : MonoBehaviour
{
    // Fields
    public string trackEventSource;
    public System.Action OnRewarded;
    private UnityEngine.UI.Text descriptionLabel;
    private UnityEngine.UI.Button buttonSpin;
    private UnityEngine.UI.Button buttonCollect;
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.RectTransform spinContainer;
    private BonusGameWheelWedge[] wedges;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private UnityEngine.Sprite spriteIconGoldenCurrency;
    private UnityEngine.Sprite spriteIconCoin;
    private int minSpinCount;
    private int maxSpinCount;
    private float spinDuration;
    private float pullbackDegree;
    private System.Collections.Generic.List<BonusGameWheelPopup.WheelPrizeData> prizeList;
    private int wheelOffset;
    private int prizeIndex;
    private static BonusGameWheelPopup.AwardType qaHackFlagAwardType;
    
    // Properties
    public static BonusGameWheelPopup.AwardType QAHACK_ForceAwardType { get; set; }
    
    // Methods
    private void Start()
    {
        this.Init();
    }
    private void Init()
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = this;
        GameEcon val_1 = App.getGameEcon;
        var val_16 = 0;
        GameEcon val_2 = App.getGameEcon;
        T[] val_3 = this.ShuffleAwardArray<System.Int32>(originalArray:  666);
        val_15 = val_14;
        T[] val_4 = this.ShuffleAwardArray<System.Int32>(originalArray:  5761245);
        System.Collections.Generic.List<WheelPrizeData> val_5 = new System.Collections.Generic.List<WheelPrizeData>();
        System.Action val_15 = this.OnRewarded;
        this.prizeList = null;
        label_23:
        val_15 = val_15 + (val_15 >> 31);
        if(val_16 >= (val_15 >> 1))
        {
            goto label_6;
        }
        
        if((val_16 < this.trackEventSource) && (this.prizeList < this.trackEventSource))
        {
                this.prizeList.Add(item:  new WheelPrizeData() {prizeType = 1, prizeAmount = this.OnRewarded + 0});
        }
        
        if((val_16 < this.trackEventSource) && (this.prizeList < this.trackEventSource))
        {
                this.prizeList.Add(item:  new WheelPrizeData() {prizeType = 2, prizeAmount = mem[this.OnRewarded + 0]});
        }
        
        val_16 = val_16 + 1;
        if(this.prizeList < this.prizeList)
        {
            goto label_23;
        }
        
        label_6:
        val_16 = 4;
        goto label_24;
        label_37:
        val_15 = val_14;
        if(16 <= this.OnRewarded)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_6 = 0.ToString();
        if(0 <= this.OnRewarded)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 == 1)
        {
                52 = 56;
        }
        
        this.wedges[0].Init(rewardText:  null, rewardIcon:  this.spriteIconCoin);
        var val_21 = 0;
        val_14 = val_15;
        new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null) = val_21 + (new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null));
        float val_19 = (float)this.OnRewarded;
        float val_20 = (float)new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        val_19 = val_19 * 0.4f;
        val_20 = val_20 * 0.4f;
        this.wedges[0].Flash(flashColor:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a}, flashDuration:  val_19, startDelay:  null, endDelay:  val_20);
        val_16 = 5;
        val_21 = val_21 - 1;
        label_24:
        if((val_16 - 4) < 24)
        {
            goto label_37;
        }
        
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -1518662160, method:  new IntPtr(2776241200));
        this.buttonSpin.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  -1518662160, method:  new IntPtr(2776250416));
        this.buttonCollect.m_OnClick.AddListener(call:  162246656);
        this.buttonCollect.interactable = false;
        this.buttonSpin.interactable = true;
        UnityEngine.GameObject val_11 = this.buttonSpin.gameObject;
        this.buttonSpin.SetActive(value:  true);
        UnityEngine.GameObject val_12 = this.buttonCollect.gameObject;
        this.buttonCollect.SetActive(value:  false);
        UnityEngine.GameObject val_13 = this.buttonClose.gameObject;
        this.buttonClose.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  -1518662160, method:  new IntPtr(2776280112));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
    }
    public void SetOnClose(System.Action onClose)
    {
        UnityEngine.UI.Text val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        if(this != 0)
        {
                System.Delegate val_3 = System.Delegate.Combine(a:  this.descriptionLabel, b:  onClose);
            val_5 = this.descriptionLabel;
        }
        else
        {
                System.Delegate val_4 = System.Delegate.Combine(a:  this.descriptionLabel, b:  onClose);
            val_5 = this.descriptionLabel;
        }
        
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_5 = 0;
        label_5:
        this.descriptionLabel = val_5;
    }
    private void Spin()
    {
        int val_10;
        var val_39;
        System.Delegate val_40;
        val_39 = 0;
        this.buttonCollect.interactable = false;
        this.buttonSpin.interactable = false;
        goto label_3;
        label_8:
        BonusGameWheelWedge val_39 = this.wedges[val_39];
        val_39.StopFlash();
        val_39 = 1;
        label_3:
        if(val_39 < val_39)
        {
            goto label_8;
        }
        
        this.prizeIndex = UnityEngine.Random.Range(min:  0, max:  0);
        CompanyDevices val_2 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                AwardType val_4 = BonusGameWheelPopup.QAHACK_ForceAwardType;
            if(null != 0)
        {
                if(null <= this.prizeIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            AwardType val_5 = BonusGameWheelPopup.QAHACK_ForceAwardType;
            float val_7 = UnityEngine.Mathf.Repeat(t:  (float)this.prizeList, length:  null);
            this.prizeIndex = (float)this.prizeIndex + 1;
        }
        
        }
        
        if(((float)this.prizeIndex + 1) <= this.prizeIndex)
        {
                var val_40 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_40 = val_40 + (this.prizeIndex << 3);
        if(((0 + (this.prizeIndex) << 3) + 16) == 2)
        {
            goto label_27;
        }
        
        if(((0 + (this.prizeIndex) << 3) + 16) != 1)
        {
            goto label_44;
        }
        
        Player val_8 = App.Player;
        decimal val_9 = System.Decimal.op_Implicit(value:  -1517887920);
        0.AddCredits(amount:  new System.Decimal() {mid = val_10}, source:  this.trackEventSource, subSource:  "Bonus Game Wheel", externalParams:  0, doTrack:  true);
        goto label_34;
        label_27:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_12 = this.gameObject;
        object val_13 = this.GetComponent<System.Object>();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_15 = new System.Action(object:  -2101040096, method:  new IntPtr(2772230480));
        val_40 = this.descriptionLabel;
        System.Delegate val_16 = System.Delegate.Combine(a:  val_40, b:  7454720);
        if(val_40 != 0)
        {
                if(null == null)
        {
            goto label_43;
        }
        
        }
        
        val_40 = 0;
        label_43:
        this.descriptionLabel = val_40;
        label_34:
        if(this.OnRewarded != 0)
        {
                this.OnRewarded.Invoke();
        }
        
        label_44:
        float val_42 = (float)(float)this.prizeIndex + 1;
        int val_41 = this.maxSpinCount;
        val_41 = val_41 + 1;
        int val_17 = UnityEngine.Random.Range(min:  this.minSpinCount, max:  val_41);
        val_42 = 360f / val_42;
        DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  this.wheelOffset, y:  null, z:  (float)this.prizeIndex);
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.spinContainer, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  this.wheelOffset, mode:  1062836634);
        object val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.spinContainer, ease:  6);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.spinContainer);
        UnityEngine.Transform val_23 = this.spinContainer.transform;
        UnityEngine.Transform val_24 = this.spinContainer.parent;
        DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.spinContainer, endValue:  this.wheelOffset, duration:  null);
        object val_26 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.spinContainer, ease:  6);
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.spinContainer);
        float val_43 = this.pullbackDegree;
        val_43 = 360f - val_43;
        UnityEngine.Vector3 val_28 = new UnityEngine.Vector3(x:  val_43, y:  null, z:  (float)this.prizeIndex);
        DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.spinContainer, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  this.spinDuration, mode:  this.spinDuration);
        object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.spinContainer, ease:  21);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.spinContainer);
        UnityEngine.Transform val_32 = this.spinContainer.transform;
        UnityEngine.Transform val_33 = this.spinContainer.parent;
        DG.Tweening.Tweener val_34 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.spinContainer, endValue:  this.spinDuration, duration:  null);
        object val_35 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.spinContainer, ease:  21);
        DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.spinContainer);
        DG.Tweening.TweenCallback val_37 = new DG.Tweening.TweenCallback(object:  -1517875872, method:  new IntPtr(2777066400));
        object val_38 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        this.wheelOffset = this.prizeIndex;
    }
    private void Collect()
    {
        int val_7;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        GridCoinCollectAnimationInstantiator val_17;
        int val_18;
        int val_19;
        this.buttonCollect.interactable = false;
        this.buttonSpin.interactable = false;
        BonusGameWheelWedge val_18 = this.wedges[this.prizeIndex];
        val_18.StopFlash();
        if(val_18 <= this.prizeIndex)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_19 + (this.prizeIndex << 3);
        val_17 = mem[(0 + (this.prizeIndex) << 3) + 16];
        val_17 = (0 + (this.prizeIndex) << 3) + 16;
        if(val_17 == 2)
        {
            goto label_8;
        }
        
        if(val_17 != 1)
        {
            goto label_9;
        }
        
        System.Action val_1 = new System.Action(object:  -1517554976, method:  new IntPtr(2776280112));
        this.coinsAnim.OnCompleteCallback = null;
        val_17 = this.coinsAnim;
        Player val_2 = App.Player;
        var val_3 = 0 + 60;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1517567028);
        decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1517567044, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
        Player val_6 = App.Player;
        val_17.Play(fromValue:  new System.Decimal() {mid = val_7}, toValue:  new System.Decimal() {hi = val_18, lo = val_19}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_8:
        System.Action val_8 = new System.Action(object:  -1517554976, method:  new IntPtr(2776280112));
        mem2[0] = null;
        Player val_9 = App.Player;
        val_18 = 4;
        Player val_10 = App.Player;
        val_19 = 0;
        decimal val_11 = System.Decimal.op_Implicit(value:  -1517567028);
        this.goldenCurrencyAnimControl.Play(fromValue:  val_18 - SB, toValue:  new System.Decimal() {flags = val_14, hi = val_15, lo = val_13, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return;
        label_9:
        UnityEngine.GameObject val_17 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1517554976, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnSpinComplete()
    {
        float val_2;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.wedges[this.prizeIndex].Flash(flashColor:  new UnityEngine.Color() {a = val_2}, flashDuration:  val_1.r, startDelay:  val_1.g, endDelay:  val_1.b);
        this.buttonCollect.interactable = true;
        this.buttonSpin.interactable = false;
        UnityEngine.GameObject val_3 = this.buttonSpin.gameObject;
        this.buttonSpin.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.buttonCollect.gameObject;
        this.buttonCollect.SetActive(value:  true);
    }
    private UnityEngine.Sprite GetAwardIcon(BonusGameWheelPopup.AwardType _type)
    {
        if(_type == 1)
        {
                52 = 56;
        }
    
    }
    private T[] ShuffleAwardArray<T>(T[] originalArray)
    {
        var val_5;
        addIntRange(lowest:  0, highest:  new RandomSet() - 1);
        var val_3 = (__RuntimeMethodHiddenParam + 24) + 16;
        val_5 = 0;
        goto label_5;
        label_10:
        mem2[0] = originalArray[roll(unweighted:  false)];
        val_5 = 1;
        label_5:
        if(val_5 < (__RuntimeMethodHiddenParam + 24 + 12))
        {
            goto label_10;
        }
    
    }
    private void CloseProperly()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1516832544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public static BonusGameWheelPopup.AwardType get_QAHACK_ForceAwardType()
    {
        AwardType val_3;
        var val_4;
        val_3 = 0;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = BonusGameWheelPopup.qaHackFlagAwardType;
    }
    public static void set_QAHACK_ForceAwardType(BonusGameWheelPopup.AwardType value)
    {
        var val_3;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        BonusGameWheelPopup.qaHackFlagAwardType = ;
    }
    public BonusGameWheelPopup()
    {
        this.pullbackDegree = 15f;
        this.trackEventSource = "Bonus Game Wheel";
    }
    private static BonusGameWheelPopup()
    {
    
    }

}
