using UnityEngine;
public abstract class CurrencyParticles : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem trailParticles;
    private UnityEngine.ParticleSystem burstParticles;
    private UnityEngine.Transform trailDestination;
    private UnityEngine.Vector3 offSetVector;
    private float statViewDelay;
    private System.Action onAwake;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(CurrencyParticles.<Start>d__6).__il2cppRuntimeField_8 = 0;
        typeof(CurrencyParticles.<Start>d__6).__il2cppRuntimeField_10 = this;
    }
    public void SetOrigin(UnityEngine.GameObject originObject)
    {
        UnityEngine.Transform val_1 = this.trailParticles.transform;
        UnityEngine.Transform val_2 = originObject.transform;
        UnityEngine.Vector3 val_3 = position;
        this.trailParticles.position = new UnityEngine.Vector3();
    }
    public void PlayParticles(UnityEngine.Vector3 destinationPosition, int particleCount, bool animateStatView = True)
    {
        UnityEngine.Transform val_10;
        bool val_11;
        int val_12;
        int val_13;
        UnityEngine.Vector3 val_14;
        float val_15;
        float val_16;
        float val_17;
        UnityEngine.ParticleSystem val_18;
        val_10 = destinationPosition.z;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(CurrencyParticles.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        val_11 = animateStatView;
        val_12 = particleCount;
        if(val_1 != 0)
        {
                val_13 = val_1;
            typeof(CurrencyParticles.<>c__DisplayClass8_0).__il2cppRuntimeField_18 = val_12;
        }
        else
        {
                val_13 = 24;
            mem[24] = val_12;
        }
        
        typeof(CurrencyParticles.<>c__DisplayClass8_0).__il2cppRuntimeField_1C = val_11;
        UnityEngine.GameObject val_2 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                val_10 = this.trailDestination;
            val_14 = this.offSetVector;
            val_17 = val_17;
            val_14 = val_14;
            val_16 = val_16;
            val_15 = val_15;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.344881E+26f, y = val_15, z = val_16}, b:  new UnityEngine.Vector3() {x = val_17, y = val_14, z = val_11});
            val_10.position = new UnityEngine.Vector3();
            val_13 = UnityEngine.Mathf.Abs(value:  val_13);
            this.trailParticles.Emit(count:  val_13);
            val_18 = this.burstParticles;
            val_18.Play();
            if((System.String.IsNullOrEmpty(value:  -354505472)) == true)
        {
                return;
        }
        
            System.Collections.IEnumerator val_7 = this.UpdateStatView(statViewDelaySeconds:  val_4.x, doStatViewAnimation:  this.statViewDelay);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -354505472);
            return;
        }
        
        val_18 = null;
        val_18 = new System.Action(object:  369594368, method:  new IntPtr(3940436800));
        this.onAwake = val_18;
    }
    public void PlayParticles(int particleCount, bool animateStatView = True)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.trailDestination.localPosition = new UnityEngine.Vector3();
        UnityEngine.Vector3 val_2 = position;
        this.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  particleCount, animateStatView:  animateStatView);
    }
    private System.Collections.IEnumerator UpdateStatView(float statViewDelaySeconds, bool doStatViewAnimation)
    {
        typeof(CurrencyParticles.<UpdateStatView>d__10).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(CurrencyParticles.<UpdateStatView>d__10).__il2cppRuntimeField_10 = doStatViewAnimation;
            typeof(CurrencyParticles.<UpdateStatView>d__10).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = doStatViewAnimation;
        }
        
        typeof(CurrencyParticles.<UpdateStatView>d__10).__il2cppRuntimeField_18 = R2;
    }
    protected abstract string GetBalanceUpdateNotifiicationName(); // 0
    protected CurrencyParticles()
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
    }

}
