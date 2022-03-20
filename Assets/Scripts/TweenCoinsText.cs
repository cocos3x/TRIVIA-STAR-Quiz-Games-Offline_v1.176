using UnityEngine;
public class TweenCoinsText : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text coinText;
    public bool disableAfterTween;
    private DG.Tweening.Tweener tween;
    private decimal currentTextValue;
    private bool usingDecimal;
    
    // Properties
    public UnityEngine.UI.Text getCoinText { get; }
    public bool IsTweening { get; }
    public decimal CurrentTextValue { get; }
    
    // Methods
    public UnityEngine.UI.Text get_getCoinText()
    {
    
    }
    public bool get_IsTweening()
    {
        if(this.tween == 0)
        {
                return this.IsInvoking();
        }
        
        if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.tween)) == false)
        {
                return this.IsInvoking();
        }
        
        return true;
    }
    public decimal get_CurrentTextValue()
    {
        return new System.Decimal() {flags = -2004093552, hi = R1 + 24};
    }
    private void Start()
    {
        var val_3;
        var val_4;
        val_3 = 7383908 + 28241879;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.game == 15)
        {
                this.usingDecimal = true;
            return;
        }
        
        if(this.usingDecimal == true)
        {
                return;
        }
        
        if((R4 + 12) == 0)
        {
                return;
        }
        
        R4 + 12.alignByGeometry = false;
    }
    public void Set(decimal instantValue)
    {
        this.usingDecimal = false;
        this.HaltImmediate();
        string val_1 = this.GetFormattedText(value:  new System.Decimal() {flags = instantValue.flags, hi = instantValue.hi, lo = instantValue.lo, mid = instantValue.mid});
        this.currentTextValue = instantValue;
        mem[1152921511192916140] = instantValue.hi;
        mem[1152921511192916144] = instantValue.lo;
        mem[1152921511192916148] = instantValue.mid;
    }
    public void Tween(decimal startValue, decimal endValue, float seconds)
    {
        int val_15;
        int val_16;
        decimal val_17;
        DG.Tweening.TweenCallback val_18;
        var val_19;
        val_15 = endValue.hi;
        val_16 = endValue.flags;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_10 = val_16;
        typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_14 = val_15;
        typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_18 = endValue.lo;
        typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_1C = endValue.mid;
        if(val_1 != 0)
        {
            
        }
        else
        {
                val_16 = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_10;
            val_15 = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_14;
        }
        
        val_17 = this.currentTextValue;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_16, hi = val_15, lo = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_18, mid = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_1C}, d2:  new System.Decimal() {flags = val_17, hi = endValue.mid, lo = endValue.lo, mid = this})) == true)
        {
                return;
        }
        
        this.HaltImmediate();
        val_16 = 0;
        float val_4 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = startValue.flags, hi = startValue.hi, lo = startValue.lo, mid = startValue.mid});
        typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = startValue.flags;
        val_17 = null;
        val_17 = new DG.Tweening.Core.DOSetter<System.Single>(object:  283492352, method:  new IntPtr(2291193936));
        float val_6 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = startValue.flags, hi = startValue.hi, lo = startValue.lo, mid = startValue.mid});
        val_15 = startValue.flags;
        DG.Tweening.Tweener val_8 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_10, hi = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_14, lo = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_18, mid = typeof(TweenCoinsText.<>c__DisplayClass13_0).__il2cppRuntimeField_1C}), endValue:  null, duration:  null);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  283492352, method:  new IntPtr(2291194960));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        val_19 = val_17;
        val_18 = null;
        val_18 = new DG.Tweening.TweenCallback(object:  283492352, method:  new IntPtr(2291195984));
        object val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198881280, autoKillOnCompletion:  true);
        mem[1152921511193035300] = val_19;
    }
    public void CountUp(decimal endValue, float seconds)
    {
        int val_15;
        decimal val_16;
        var val_17;
        DG.Tweening.Tweener val_19;
        val_15 = endValue.hi;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(TweenCoinsText.<>c__DisplayClass14_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        if(val_1 != 0)
        {
            
        }
        else
        {
                val_15 = val_15;
        }
        
        val_16 = this.currentTextValue;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = endValue.flags, hi = val_15, lo = endValue.lo, mid = endValue.mid}, d2:  new System.Decimal() {flags = val_16, hi = endValue.lo, lo = endValue.mid, mid = endValue.flags})) == true)
        {
                return;
        }
        
        this.HaltImmediate();
        val_16 = 0;
        float val_4 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.currentTextValue + (0)], hi = mem[this.currentTextValue + (4)], lo = mem[this.currentTextValue + (8)], mid = mem[this.currentTextValue + (12)]});
        typeof(TweenCoinsText.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = mem[this.currentTextValue + (0)];
        DG.Tweening.Core.DOSetter<System.Single> val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  283545600, method:  new IntPtr(2291309008));
        float val_6 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.currentTextValue + (0)], hi = mem[this.currentTextValue + (4)], lo = mem[this.currentTextValue + (8)], mid = mem[this.currentTextValue + (12)]});
        DG.Tweening.Tweener val_8 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = endValue.flags, hi = val_15, lo = endValue.lo, mid = endValue.mid}), endValue:  null, duration:  null);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        val_17 = 1152921504797581312;
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  283545600, method:  new IntPtr(2291310032));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        val_19 = null;
        val_15 = null;
        val_15 = new DG.Tweening.TweenCallback(object:  283545600, method:  new IntPtr(2291311056));
        object val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198881280, autoKillOnCompletion:  true);
        this.tween = val_19;
    }
    private void DisableAfter()
    {
        if(this.disableAfterTween == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void HaltImmediate()
    {
        if(this.tween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tween, complete:  false);
        }
        
        this.CancelInvoke();
    }
    private string GetFormattedText(decimal value)
    {
        var val_3;
        var val_4;
        if(this.usingDecimal != false)
        {
                val_3 = null;
            val_3 = null;
        }
        else
        {
                GameEcon val_1 = App.getGameEcon;
            val_4 = 8;
        }
        
        string val_2 = value.flags.ToString(format:  null);
    }
    public TweenCoinsText()
    {
        this.disableAfterTween = true;
    }

}
