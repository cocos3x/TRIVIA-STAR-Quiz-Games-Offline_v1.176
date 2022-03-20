using UnityEngine;
public abstract class CurrencyCollectAnimationInstantiator : StatViewInstantiatior
{
    // Fields
    private bool disableOnComplete;
    public UnityEngine.Transform particlesStartPos;
    private float delayBeforeAnimationConclusion;
    protected UnityEngine.Vector2 tweenPointBeforePlay;
    public System.Action OnCompleteCallback;
    private CurrencyParticles flyingParticles;
    
    // Properties
    public CurrencyParticles GetParticles { get; }
    
    // Methods
    public CurrencyParticles get_GetParticles()
    {
    
    }
    protected override void SetupAnimatedElements()
    {
        UnityEngine.Transform val_6;
        System.Action val_1 = new System.Action(object:  -355860608, method:  new IntPtr(3939072448));
        mem2[0] = null;
        if(this.particlesStartPos != 0)
        {
                val_6 = this.particlesStartPos;
        }
        else
        {
                UnityEngine.Transform val_3 = this.particlesStartPos.transform;
            val_6 = this;
        }
        
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  -355860608, parent:  -355860608);
        object val_5 = this.GetComponent<System.Object>();
        this.flyingParticles = this;
    }
    public void Play(int fromValue, decimal toValue, float textTickTime = -1, float delayBeforeComplete = -1, UnityEngine.GameObject destinationObject, UnityEngine.GameObject originObject)
    {
        var val_1;
        var val_2;
        float val_7;
        float val_8;
        float val_14;
        int val_20;
        var val_21;
        float val_22;
        float val_24;
        DG.Tweening.TweenCallback val_25;
        val_20 = fromValue;
        object val_3 = new System.Object();
        if(val_3 != 0)
        {
                typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_C = val_20;
            CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
        }
        else
        {
                mem[8] = this;
            mem[12] = val_20;
        }
        
        typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_14 = toValue.hi;
        typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_18 = toValue.lo;
        typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_1C = toValue.mid;
        typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_10 = toValue.flags;
        if(val_3 != 0)
        {
                val_21 = val_3;
            typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_28 = val_2;
            val_22 = 1152921504976281636;
            CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_FFFFFFFFFFFFFFF8 = destinationObject;
            CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = originObject;
        }
        else
        {
                mem[32] = destinationObject;
            val_20 = val_2;
            val_22 = 5.044674E-44f;
            mem[36] = originObject;
            val_21 = 40;
            mem[40] = val_20;
        }
        
        typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_2C = val_1;
        if(val_1 == 0)
        {
            goto label_5;
        }
        
        if(val_1 < 0)
        {
                val_22 = this.delayBeforeAnimationConclusion;
        }
        
        this.delayBeforeAnimationConclusion = val_22;
        UnityEngine.GameObject val_4 = val_20.gameObject;
        val_20.SetActive(value:  true);
        this.SetStatViewValue(instantValue:  mem[12]);
        float val_5 = val_22 + 36;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.tweenPointBeforePlay, y = toValue.lo}, rhs:  new UnityEngine.Vector2() {x = val_7, y = val_8})) == false)
        {
            goto label_11;
        }
        
        UnityEngine.Transform val_10 = this.tweenPointBeforePlay.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -1.231851E+26f, y = val_24});
        this.tweenPointBeforePlay.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_12 = 0.transform;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -1.231849E+26f, y = val_14});
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  0, endValue:  new UnityEngine.Vector3(), duration:  val_16.x, snapping:  false);
        val_25 = null;
        val_25 = new DG.Tweening.TweenCallback(object:  369434624, method:  new IntPtr(3939211072));
        object val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        return;
        label_5:
        UnityEngine.Debug.LogError(message:  -355755200);
        return;
        label_11:
        val_25 = typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_1C;
        val_24 = mem[40];
        this.ContinueCoinCollectAnimation(fromValue:  mem[12], toValue:  new System.Decimal() {flags = typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_10, hi = typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_14, lo = typeof(CurrencyCollectAnimationInstantiator.<>c__DisplayClass9_0).__il2cppRuntimeField_18, mid = val_25}, textTickTime:  val_6.x, delayBeforeComplete:  val_6.y, destinationObject:  0, originObject:  null);
    }
    private void ContinueCoinCollectAnimation(int fromValue, decimal toValue, float textTickTime = -1, float delayBeforeComplete = -1, UnityEngine.GameObject destinationObject, UnityEngine.GameObject originObject)
    {
        UnityEngine.Object val_1;
        UnityEngine.Object val_3;
        float val_9;
        float val_10;
        float val_11;
        var val_15;
        if(val_1 != 0)
        {
                this.flyingParticles.SetOrigin(originObject:  val_1);
        }
        
        if(val_3 == 0)
        {
                UnityEngine.Transform val_5 = val_3.AppleIcon;
            val_15 = val_3;
            UnityEngine.Transform val_6 = val_15.transform;
        }
        else
        {
                val_15 = val_3;
            UnityEngine.Transform val_7 = val_15.transform;
        }
        
        UnityEngine.Vector3 val_8 = position;
        decimal val_12 = System.Decimal.op_Implicit(value:  -355606420);
        decimal val_13 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -355606436, hi = toValue.flags, lo = toValue.hi, mid = toValue.lo}, d2:  new System.Decimal() {flags = toValue.mid});
        this.flyingParticles.PlayParticles(destinationPosition:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, particleCount:  System.Decimal.op_Explicit(value:  new System.Decimal()), animateStatView:  true);
    }
    private void ConcludeAnimation()
    {
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -355464960, method:  new IntPtr(3939477312));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  this.delayBeforeAnimationConclusion, ignoreTimeScale:  false);
    }
    protected abstract UnityEngine.GameObject GetParticleSystemPrefabFromTheme(); // 0
    protected CurrencyCollectAnimationInstantiator()
    {
        this.delayBeforeAnimationConclusion = 0.25f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.tweenPointBeforePlay = new UnityEngine.Vector2();
        mem[1152921512841428672] = ???;
    }
    private void <ConcludeAnimation>b__11_0()
    {
        float val_2;
        float val_3;
        var val_10;
        var val_11;
        DG.Tweening.TweenCallback val_12;
        if(this.OnCompleteCallback != 0)
        {
                this.OnCompleteCallback.Invoke();
        }
        
        if(this.disableOnComplete == false)
        {
                return;
        }
        
        val_10 = this;
        val_11 = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_12 = UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.tweenPointBeforePlay, y = R6}, rhs:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        if(val_12 != false)
        {
                val_11 = 0;
            UnityEngine.Transform val_5 = this.tweenPointBeforePlay.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -1.277517E+26f, y = this.tweenPointBeforePlay});
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.tweenPointBeforePlay, endValue:  new UnityEngine.Vector3(), duration:  val_6.x, snapping:  false);
            val_12 = null;
            val_12 = new DG.Tweening.TweenCallback(object:  -355235840, method:  new IntPtr(3939706432));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.tweenPointBeforePlay, action:  190734336);
            return;
        }
        
        this.tweenPointBeforePlay.SetActive(value:  false);
    }
    private void <ConcludeAnimation>b__11_1()
    {
        R4.SetActive(value:  false);
    }

}
