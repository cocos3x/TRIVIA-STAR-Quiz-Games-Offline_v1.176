using UnityEngine;
public class UGUIGenericCoinsGainedAnim : MonoBehaviour
{
    // Fields
    private ParticleAttraction particleAttractor;
    private UnityEngine.Transform ParticleStartPos;
    private TweenCoinsText textTween;
    private bool stopOnDisable;
    private bool disableWhenComplete;
    private bool useTweenCounter;
    private bool useParticleCounter;
    private float burstsTime;
    public float firstCoinPercent;
    public float lastCoinPercent;
    public float totalTime;
    public System.Action OnClosedCallback;
    private UnityEngine.ParticleSystem coinFlyParticles;
    private decimal startCoins;
    private decimal finalCoins;
    private bool hasCreated;
    private bool forceTextTweenOnAnimFinished;
    
    // Properties
    private UnityEngine.ParticleSystem particlesPrefab { get; }
    public float countUpDuration { get; }
    
    // Methods
    private UnityEngine.ParticleSystem get_particlesPrefab()
    {
        UnityEngine.GameObject val_1 = PrefabLoader.LoadPrefab(featureName:  -1752778768, prefabName:  -1752778880);
        if("CoinParticles" != 0)
        {
                return GetComponent<System.Object>();
        }
        
        return GetComponent<System.Object>();
    }
    public float get_countUpDuration()
    {
        return (float)this.totalTime - this.totalTime;
    }
    private void Create()
    {
        System.Action val_14;
        System.Action val_15;
        if(this.hasCreated != false)
        {
                return;
        }
        
        this.hasCreated = true;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        this.ParticleStartPos = this;
        UnityEngine.ParticleSystem val_3 = this.particlesPrefab;
        UnityEngine.Transform val_4 = this.transform;
        object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  -1752489712, parent:  -1752489712);
        this.coinFlyParticles = this;
        MainModule val_6 = this.main;
        val_6.m_ParticleSystem.stopAction = 0;
        this.particleAttractor.PS = this.coinFlyParticles;
        if(this.particleAttractor.endPoint == 0)
        {
                UnityEngine.GameObject val_8 = this.gameObject;
            UnityEngine.Transform val_9 = this.transform;
            this.particleAttractor.endPoint = this;
        }
        
        if(this.useParticleCounter == false)
        {
                return;
        }
        
        if(this.useTweenCounter == true)
        {
                return;
        }
        
        System.Action val_10 = new System.Action(object:  -1752489712, method:  new IntPtr(2542443344));
        System.Delegate val_11 = System.Delegate.Combine(a:  this.particleAttractor.OnParticleHitCallback, b:  7454720);
        val_14 = this.particleAttractor.OnParticleHitCallback;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_14 = 0;
        label_16:
        this.particleAttractor.OnParticleHitCallback = val_14;
        System.Action val_12 = new System.Action(object:  -1752489712, method:  new IntPtr(2542452560));
        System.Delegate val_13 = System.Delegate.Combine(a:  this.particleAttractor.OnParticleHitsCompleteCallback, b:  7454720);
        val_15 = this.particleAttractor.OnParticleHitsCompleteCallback;
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        val_15 = 0;
        label_20:
        this.particleAttractor.OnParticleHitsCompleteCallback = val_15;
    }
    private void ParticleAtractor_OnParticleHitsCompleteCallback()
    {
        this.ConcludeAnimation();
    }
    private void ParticleAttractor_OnParticleHitCallback()
    {
        UGUIGenericCoinsGainedAnim val_6;
        decimal val_7;
        decimal val_8;
        decimal val_9;
        int val_10;
        int val_11;
        int val_12;
        decimal val_13;
        decimal val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        val_6 = this;
        val_7 = this.startCoins;
        val_9 = this.finalCoins;
        val_12 = R3;
        val_10 = ???;
        val_9 = val_9;
        val_11 = R2;
        val_7 = val_7;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_12}, d2:  new System.Decimal() {flags = val_7, hi = ???, lo = ???, mid = ???})) == false)
        {
            goto label_3;
        }
        
        val_13 = this.startCoins;
        decimal val_2 = System.Decimal.op_Increment(d:  new System.Decimal() {flags = -1752232720, hi = val_13, lo = SB, mid = val_9});
        goto label_6;
        label_3:
        val_8 = this.startCoins;
        val_15 = this.finalCoins;
        val_19 = ???;
        val_16 = val_7;
        val_18 = ???;
        val_17 = ???;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_15, hi = val_17, lo = val_18, mid = val_19}, d2:  new System.Decimal() {flags = val_8, hi = val_16, lo = ???, mid = ???})) == false)
        {
            goto label_9;
        }
        
        val_13 = this.startCoins;
        decimal val_4 = System.Decimal.op_Decrement(d:  new System.Decimal() {flags = -1752232720, hi = val_13, lo = SB, mid = val_15});
        label_6:
        label_9:
        if((UnityEngine.Object.op_Implicit(exists:  this.textTween)) == false)
        {
                return;
        }
        
        this.textTween.Set(instantValue:  new System.Decimal() {flags = mem[this.startCoins + (0)], hi = mem[this.startCoins + (4)], lo = mem[this.startCoins + (8)], mid = val_6});
    }
    public void Set(decimal instantValue)
    {
        if(this.hasCreated == false)
        {
                this.hasCreated = this;
            this.Create();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.textTween)) == false)
        {
                return;
        }
        
        this.textTween.Set(instantValue:  new System.Decimal() {flags = instantValue.flags, hi = instantValue.hi, lo = instantValue.lo, mid = instantValue.mid});
    }
    public void Play(decimal startCoins, decimal finalCoins, UnityEngine.Transform particleStart, bool forceTextTween = False)
    {
        float val_10;
        UnityEngine.AnimationCurve val_11;
        float val_12;
        if(this.hasCreated == false)
        {
                this.hasCreated = this;
            this.Create();
        }
        
        if(particleStart != 0)
        {
                this.ParticleStartPos = particleStart;
        }
        
        UnityEngine.Transform val_2 = this.coinFlyParticles.transform;
        UnityEngine.Vector3 val_3 = position;
        this.coinFlyParticles.position = new UnityEngine.Vector3();
        EmissionModule val_8 = this.coinFlyParticles.emission;
        MinMaxCurve val_9 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  (float)UnityEngine.Mathf.Abs(value:  (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = finalCoins.flags, hi = finalCoins.hi, lo = finalCoins.lo, mid = finalCoins.mid})) - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = startCoins.flags, hi = startCoins.hi, lo = startCoins.lo, mid = startCoins.mid}))));
        val_8.m_ParticleSystem.rateOverTime = new MinMaxCurve() {m_CurveMax = val_11, m_ConstantMin = val_10, m_ConstantMax = val_12};
        MainModule val_13 = val_9.m_ConstantMin + 48.main;
        val_13.m_ParticleSystem.duration = (float)UnityEngine.Mathf.Abs(value:  (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = finalCoins.flags, hi = finalCoins.hi, lo = finalCoins.lo, mid = finalCoins.mid})) - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = startCoins.flags, hi = startCoins.hi, lo = startCoins.lo, mid = startCoins.mid})));
        mem2[0] = startCoins.flags;
        mem2[0] = startCoins.hi;
        mem2[0] = startCoins.lo;
        mem2[0] = startCoins.mid;
        mem2[0] = finalCoins.flags;
        mem2[0] = finalCoins.hi;
        mem2[0] = finalCoins.lo;
        mem2[0] = finalCoins.mid;
        val_9.m_ConstantMin.Set(instantValue:  new System.Decimal() {flags = startCoins.flags, hi = startCoins.hi, lo = startCoins.lo, mid = startCoins.mid});
        UnityEngine.GameObject val_14 = val_9.m_ConstantMin.gameObject;
        val_9.m_ConstantMin.SetActive(value:  true);
        val_9.m_ConstantMin + 48.Play();
        mem2[0] = forceTextTween;
        if((val_9.m_ConstantMin + 26) == 0)
        {
                return;
        }
        
        if((val_9.m_ConstantMin + 27) != 0)
        {
                return;
        }
        
        float val_15 = val_9.m_ConstantMin + 32;
        val_15 = val_15 * (val_9.m_ConstantMin + 40);
        val_9.m_ConstantMin.Invoke(methodName:  -1751979696, time:  val_15);
        val_9.m_ConstantMin.Invoke(methodName:  -1751979584, time:  val_15);
    }
    private void StartCountingUp()
    {
        int val_3;
        int val_4;
        int val_5;
        if((UnityEngine.Object.op_Implicit(exists:  this.textTween)) == false)
        {
                return;
        }
        
        float val_2 = this.totalTime - this.totalTime;
        if(this.textTween == 0)
        {
                val_5 = mem[this.startCoins + (8)];
            val_4 = mem[this.startCoins + (4)];
            val_3 = mem[this.startCoins + (0)];
        }
        
        this.textTween.Tween(startValue:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = mem[this.startCoins + (12)]}, endValue:  new System.Decimal() {flags = mem[this.startCoins + (16)], hi = mem[this.startCoins + (20)], lo = mem[this.startCoins + (24)], mid = mem[this.startCoins + (28)]}, seconds:  this.firstCoinPercent);
    }
    private void ConcludeAnimation()
    {
        System.Action val_6;
        System.Action val_7;
        if(this.forceTextTweenOnAnimFinished != false)
        {
                if(this.useTweenCounter == false)
        {
            goto label_2;
        }
        
        }
        
        label_16:
        this.Set(instantValue:  new System.Decimal() {flags = mem[this.finalCoins + (0)], hi = mem[this.finalCoins + (4)], lo = mem[this.finalCoins + (8)], mid = this.useTweenCounter});
        label_17:
        if(this.OnClosedCallback != 0)
        {
                this.OnClosedCallback.Invoke();
        }
        
        if(this.disableWhenComplete != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
        
        this.hasCreated = false;
        if(this.useParticleCounter == false)
        {
                return;
        }
        
        if(this.useTweenCounter == true)
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  -1751678224, method:  new IntPtr(2542443344));
        System.Delegate val_3 = System.Delegate.Remove(source:  this.particleAttractor.OnParticleHitCallback, value:  7454720);
        val_6 = this.particleAttractor.OnParticleHitCallback;
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_6 = 0;
        label_11:
        this.particleAttractor.OnParticleHitCallback = val_6;
        System.Action val_4 = new System.Action(object:  -1751678224, method:  new IntPtr(2542452560));
        System.Delegate val_5 = System.Delegate.Remove(source:  this.particleAttractor.OnParticleHitsCompleteCallback, value:  7454720);
        val_7 = this.particleAttractor.OnParticleHitsCompleteCallback;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_7 = 0;
        label_15:
        this.particleAttractor.OnParticleHitsCompleteCallback = val_7;
        return;
        label_2:
        if(this.useParticleCounter == false)
        {
            goto label_16;
        }
        
        this.StartCountingUp();
        goto label_17;
    }
    private void OnDisable()
    {
        if(this.stopOnDisable == false)
        {
                return;
        }
        
        this.CancelInvoke();
        if((UnityEngine.Object.op_Implicit(exists:  this.textTween)) == false)
        {
                return;
        }
        
        R4 + 20.HaltImmediate();
    }
    public UGUIGenericCoinsGainedAnim()
    {
        this.useParticleCounter = true;
        this.stopOnDisable = true;
    }

}
