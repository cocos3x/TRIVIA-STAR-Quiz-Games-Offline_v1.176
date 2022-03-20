using UnityEngine;
public class UGUIGenericCoinsGainedParticleAnim : MonoBehaviour
{
    // Fields
    private ParticleAttraction particleAttractor;
    private UnityEngine.Transform ParticleStartPos;
    private UnityEngine.GameObject contents;
    private TweenCoinsText textTween;
    private UnityEngine.ParticleSystem coinFlyParticles;
    public float firstCoinPercent;
    public float lastCoinPercent;
    public float totalTime;
    private bool disableStatViewWhenComplete;
    private bool disableWhenComplete;
    private bool stopOnDisable;
    private decimal startCoins;
    private decimal finalCoins;
    public System.Action OnClosedCallback;
    private bool hasCreated;
    private UnityEngine.ParticleSystem.MainModule mainMan;
    
    // Properties
    public float countUpDuration { get; }
    
    // Methods
    public float get_countUpDuration()
    {
        return (float)this.totalTime - this.totalTime;
    }
    private void Create()
    {
        if(this.hasCreated == true)
        {
                return;
        }
        
        this.hasCreated = true;
        GameSpecificUI val_1 = GameSpecificUI.currentGame;
        UnityEngine.GameObject val_2 = 0.CoinsGainedAnimContents;
        UnityEngine.Transform val_3 = this.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  -1751158544);
        this.contents = 0;
        object val_5 = 0.GetComponentInChildren<System.Object>(includeInactive:  true);
        this.textTween = 0;
        object val_6 = this.contents.GetComponentInChildren<System.Object>(includeInactive:  true);
        this.coinFlyParticles = this.contents;
        this.particleAttractor.PS = this.contents;
        if(this.particleAttractor.endPoint == 0)
        {
                UnityEngine.Transform val_8 = this.textTween.transform;
            this.particleAttractor.endPoint = this.textTween;
        }
        
        if(this.ParticleStartPos == 0)
        {
                UnityEngine.Transform val_10 = this.ParticleStartPos.transform;
            this.ParticleStartPos = this;
        }
        
        UnityEngine.Transform val_11 = this.coinFlyParticles.transform;
        this.coinFlyParticles.SetParent(parent:  this.ParticleStartPos, worldPositionStays:  false);
        UnityEngine.Transform val_12 = this.coinFlyParticles.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        this.coinFlyParticles.localPosition = new UnityEngine.Vector3();
    }
    private void Awake()
    {
        if(this.hasCreated == true)
        {
                return;
        }
        
        this.Create();
    }
    public void Set(decimal instantValue)
    {
        if(this.hasCreated == false)
        {
                this.hasCreated = this;
            this.Create();
        }
        
        this.textTween.Set(instantValue:  new System.Decimal() {flags = instantValue.flags, hi = instantValue.hi, lo = instantValue.lo, mid = instantValue.mid});
    }
    public void Play(decimal startCoins, decimal finalCoins)
    {
        int val_5;
        if(this.hasCreated == false)
        {
                this.hasCreated = this;
            this.Create();
        }
        
        MainModule val_1 = this.coinFlyParticles.main;
        this.mainMan = val_1.m_ParticleSystem;
        this.mainMan.duration = this.totalTime - this.totalTime;
        val_5 = startCoins.mid;
        mem[1152921511446024608] = startCoins.flags;
        mem[1152921511446024612] = startCoins.hi;
        mem[1152921511446024616] = startCoins.lo;
        mem[1152921511446024620] = val_5;
        mem[1152921511446024624] = finalCoins.flags;
        mem[1152921511446024628] = finalCoins.hi;
        mem[1152921511446024632] = finalCoins.lo;
        mem[1152921511446024636] = finalCoins.mid;
        if(this.textTween == 0)
        {
                val_5 = startCoins.mid;
        }
        
        this.textTween.disableAfterTween = this.disableStatViewWhenComplete;
        this.Set(instantValue:  new System.Decimal() {flags = startCoins.flags, hi = startCoins.hi, lo = startCoins.lo, mid = val_5});
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.textTween.gameObject;
        this.textTween.SetActive(value:  true);
        this.coinFlyParticles.Play();
        float val_5 = this.firstCoinPercent;
        val_5 = val_5 * this.totalTime;
        this.textTween.Invoke(methodName:  -1751979696, time:  val_5);
        this.Invoke(methodName:  -1751979584, time:  val_5);
    }
    private void StartCountingUp()
    {
        int val_2;
        int val_3;
        float val_1 = this.totalTime - this.totalTime;
        if(this.textTween == 0)
        {
                val_3 = mem[this.startCoins + (4)];
            val_2 = mem[this.startCoins + (0)];
        }
        
        this.textTween.Tween(startValue:  new System.Decimal() {flags = val_2, hi = val_3, lo = mem[this.startCoins + (8)]}, endValue:  new System.Decimal(), seconds:  this.firstCoinPercent);
    }
    private void ConcludeAnimation()
    {
        if(this.OnClosedCallback != 0)
        {
                this.OnClosedCallback.Invoke();
        }
        
        if(this.disableWhenComplete == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if(this.stopOnDisable == false)
        {
                return;
        }
        
        this.CancelInvoke();
        this.textTween.HaltImmediate();
    }
    public UGUIGenericCoinsGainedParticleAnim()
    {
        this.firstCoinPercent = 0.5f;
        this.lastCoinPercent = 1.5f;
        this.totalTime = 4f;
        this.disableStatViewWhenComplete = true;
        this.disableWhenComplete = true;
        this.stopOnDisable = true;
    }

}
