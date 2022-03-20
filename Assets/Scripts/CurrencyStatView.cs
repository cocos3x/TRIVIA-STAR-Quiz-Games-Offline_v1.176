using UnityEngine;
public abstract class CurrencyStatView : MonoBehaviour
{
    // Fields
    private static readonly System.Collections.Hashtable animTrueHT;
    private static readonly System.Collections.Hashtable animFalseHT;
    private UnityEngine.UI.Button touchArea;
    protected TweenCoinsText text;
    protected UnityEngine.Transform currencyIcon;
    private float countUpTime;
    protected UnityEngine.UI.Button storeButton;
    protected bool autoUpdate;
    protected decimal artificalTargetBalance;
    private int loops;
    private DG.Tweening.Tweener punchSequence;
    public System.Action OnAnimateComplete;
    
    // Properties
    public UnityEngine.UI.Button getStoreButton { get; }
    public TweenCoinsText getText { get; }
    public UnityEngine.Transform AppleIcon { get; }
    public bool Interactable { get; set; }
    public bool SetAutoUpdate { set; }
    protected virtual CurrencyType getMyCurrency { get; }
    
    // Methods
    public static System.Collections.Hashtable GetAnimHT(bool shouldAnimate)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = null;
        if(shouldAnimate != false)
        {
                val_3 = null;
            return;
        }
        
        val_5 = null;
        val_4 = 1152921504976551940;
    }
    public UnityEngine.UI.Button get_getStoreButton()
    {
    
    }
    public TweenCoinsText get_getText()
    {
    
    }
    public UnityEngine.Transform get_AppleIcon()
    {
        if(this.currencyIcon != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  -352060736);
        UnityEngine.Transform val_3 = transform;
        this.currencyIcon = null;
        UnityEngine.Transform val_4 = transform;
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.Transform val_6 = this.transform;
        SetParent(parent:  -352032528, worldPositionStays:  false);
    }
    public bool get_Interactable()
    {
        var val_2 = 0;
        if(this.touchArea == 0)
        {
                return true;
        }
        
        if(val_2 != 0)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public void set_Interactable(bool value)
    {
        if(this.touchArea != 0)
        {
                this.touchArea.interactable = value;
        }
        
        if(this.storeButton == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.storeButton.gameObject;
        this.storeButton.SetActive(value:  value);
    }
    public void set_SetAutoUpdate(bool value)
    {
        this.autoUpdate = value;
    }
    private void Awake()
    {
        System.Action val_1 = new System.Action(object:  -351513872, method:  new IntPtr(3943416112));
        CurrencyController.AddCurrencyListener(onChangeAction:  7454720, type:  -351513872);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -351513872, name:  -1898880160);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -351513872, name:  -351513872);
        if(this.touchArea == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -351513872, method:  typeof(CurrencyStatView).__il2cppRuntimeField_F0);
        this.touchArea.m_OnClick.AddListener(call:  162246656);
    }
    private void OnServerSync()
    {
        if(this.autoUpdate == false)
        {
                return;
        }
        
        goto typeof(CurrencyStatView).__il2cppRuntimeField_E4;
    }
    protected virtual void OnEnable()
    {
        if(this.autoUpdate == false)
        {
                return;
        }
        
        goto typeof(CurrencyStatView).__il2cppRuntimeField_E4;
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -351165584, method:  new IntPtr(3943416112));
        CurrencyController.RemoveCurrencyListener(onChangeAction:  7454720, type:  -351165584);
    }
    public void SetTargetBalance(decimal targetBalance)
    {
    
    }
    public void SetBalanceNow(decimal newBalance)
    {
        if(this.text == 0)
        {
                return;
        }
        
        this.text.Set(instantValue:  new System.Decimal() {flags = newBalance.flags, hi = newBalance.hi, lo = newBalance.lo, mid = newBalance.mid});
    }
    protected virtual void UpdateBalance(bool instantly = False)
    {
        int val_5;
        DG.Tweening.TweenCallback val_12;
        if(this.text == 0)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            string val_3 = this.name;
            string val_4 = -350833104(-350833104) + -350799776(-350799776);
            UnityEngine.Debug.LogError(message:  -350833104);
            return;
        }
        
        if(instantly != false)
        {
                val_12 = 0;
            this.text.Set(instantValue:  new System.Decimal() {mid = val_5});
            return;
        }
        
        val_12 = 0;
        this.text.CountUp(endValue:  new System.Decimal() {mid = val_5}, seconds:  null);
        if(this.punchSequence != 0)
        {
                if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.punchSequence)) != false)
        {
                int val_12 = this.loops;
            val_12 = val_12 + 1;
            this.loops = val_12;
            return;
        }
        
        }
        
        UnityEngine.Transform val_7 = this.AppleIcon;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  -350799776, punch:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  null, vibrato:  1051931443, elasticity:  null);
        val_12 = null;
        val_12 = new DG.Tweening.TweenCallback(object:  -350799776, method:  new IntPtr(3944142496));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  -350799776, action:  190734336);
        this.punchSequence = this;
    }
    private void PlayAnotherPunchTween()
    {
        if(this.loops >= 1)
        {
                UnityEngine.Transform val_1 = this.AppleIcon;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  -350670368, punch:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  null, vibrato:  1051931443, elasticity:  null);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  -350670368, method:  new IntPtr(3944267808));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  -350670368, action:  190734336);
            this.punchSequence = this;
            return;
        }
        
        if(this.OnAnimateComplete == 0)
        {
                return;
        }
        
        this.OnAnimateComplete.Invoke();
    }
    private void OnBalanceChanged()
    {
        if(this.autoUpdate == false)
        {
                return;
        }
        
        goto typeof(CurrencyStatView).__il2cppRuntimeField_E4;
    }
    protected abstract void OnTouchAreaClicked(); // 0
    protected abstract string GetBalanceUpdateNotificationName(); // 0
    protected abstract decimal GetCountUpBalance(); // 0
    protected virtual CurrencyType get_getMyCurrency()
    {
    
    }
    protected CurrencyStatView()
    {
        this.autoUpdate = true;
        this.countUpTime = 0.5f;
    }
    private static CurrencyStatView()
    {
        CurrencyStatView.animTrueHT = new System.Collections.Hashtable();
        CurrencyStatView.animFalseHT = new System.Collections.Hashtable();
    }
    private void <UpdateBalance>b__30_0()
    {
        this.PlayAnotherPunchTween();
    }
    private void <PlayAnotherPunchTween>b__31_0()
    {
        this.PlayAnotherPunchTween();
        int val_1 = this.loops;
        val_1 = val_1 - 1;
        this.loops = val_1;
    }

}
