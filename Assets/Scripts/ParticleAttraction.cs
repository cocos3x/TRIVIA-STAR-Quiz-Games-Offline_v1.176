using UnityEngine;
public class ParticleAttraction : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform endPoint;
    public UnityEngine.ParticleSystem PS;
    private float attractionSpeed;
    public bool ignoreZ;
    private bool destroyWhenReached;
    private float destroyRadius;
    public System.Action OnParticleHitCallback;
    public System.Action OnParticleHitsCompleteCallback;
    
    // Methods
    private void Update()
    {
        this.Attract();
    }
    public void Attract()
    {
        float val_7;
        float val_8;
        float val_9;
        var val_11;
        var val_12;
        var val_13;
        float val_21;
        float val_22;
        float val_23;
        if(this.PS == 0)
        {
                return;
        }
        
        if(this.PS.isPlaying == false)
        {
                return;
        }
        
        if((this.PS.IsAlive(withChildren:  false)) == false)
        {
                return;
        }
        
        int val_4 = this.PS.particleCount;
        int val_5 = this.PS.GetParticles(particles:  1743425792);
        if(val_5 >= 1)
        {
                var val_22 = 0;
            do
        {
            if(this.ignoreZ != false)
        {
                UnityEngine.Vector3 val_6 = position;
            UnityEngine.Vector3 val_10 = GetXYTargetPosition(pos:  new UnityEngine.Vector3() {x = -9.98452E-35f, y = val_8, z = val_9});
            val_21 = val_11;
            val_22 = val_12;
            val_23 = val_13;
        }
        else
        {
                UnityEngine.Vector3 val_14 = position;
            val_21 = val_8;
            val_22 = val_9;
            val_23 = val_7;
        }
        
            UnityEngine.Vector3 val_15 = position;
            float val_16 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = -9.970672E-35f}, target:  new UnityEngine.Vector3() {y = val_21, z = val_22}, maxDistanceDelta:  0 * this.attractionSpeed);
            position = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_19 = position;
            float val_20 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
            if(this.destroyWhenReached != false)
        {
                remainingLifetime = this.destroyRadius;
        }
        
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(this.OnParticleHitCallback != 0)
        {
                this.OnParticleHitCallback.Invoke();
        }
        
            val_22 = val_22 + 1;
        }
        while(val_5 != val_22);
        
        }
        
        this.PS.SetParticles(particles:  1743425792, size:  val_5);
        var val_23 = val_21;
        val_23 = val_5 - val_23;
        if(val_23 > 0)
        {
                return;
        }
        
        if(this.OnParticleHitsCompleteCallback == 0)
        {
                return;
        }
        
        this.OnParticleHitsCompleteCallback.Invoke();
    }
    public UnityEngine.Vector3 GetXYTargetPosition(UnityEngine.Vector3 pos)
    {
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_4 = position;
        this = 0;
        mem[1152921511167196436] = 0;
        mem[1152921511167196440] = 0;
        this = new UnityEngine.Vector3(x:  val_4.x, y:  val_4.y, z:  val_4.z);
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public ParticleAttraction()
    {
        this.destroyRadius = 0.05f;
        this.attractionSpeed = 1f;
    }

}
