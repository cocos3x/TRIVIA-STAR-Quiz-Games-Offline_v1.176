using UnityEngine;
public class ParticlePositionToPoint : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform attractionPoint;
    private UnityEngine.ParticleSystem myParticleSystem;
    private UnityEngine.ParticleSystem.Particle[] myParticles;
    
    // Methods
    public void SetAttractionPoint(UnityEngine.Transform newPoint)
    {
        this.attractionPoint = newPoint;
    }
    private void LateUpdate()
    {
        float val_4;
        float val_5;
        float val_6;
        float val_14;
        float val_15;
        float val_18;
        float val_19;
        float val_20;
        var val_27;
        int val_28;
        var val_29;
        Particle[] val_31;
        val_27 = this;
        if(this.myParticleSystem.isPlaying == false)
        {
                return;
        }
        
        val_28 = this.myParticleSystem.GetParticles(particles:  this.myParticles);
        val_29 = 0;
        UnityEngine.Vector3 val_3 = position;
        if(val_28 >= 1)
        {
                var val_28 = 16;
            var val_27 = 0;
            do
        {
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.Vector3 val_8 = position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.035876E+30f, y = val_4, z = val_5}, b:  new UnityEngine.Vector3() {x = val_6});
            val_31 = val_27;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = -3.035873E+30f}, d:  this.myParticles[val_28].remainingLifetime);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.035869E+30f}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.035865E+30f}, b:  new UnityEngine.Vector3() {y = val_15, z = val_14});
            val_27 = val_31;
            if((((((System.Single.IsNaN(f:  val_17.x)) != true) && ((System.Single.IsNaN(f:  val_17.x)) != true)) && ((System.Single.IsNaN(f:  val_17.x)) != true)) && ((System.Single.IsInfinity(f:  val_17.x)) != true)) && ((System.Single.IsInfinity(f:  val_17.x)) != true))
        {
                if((System.Single.IsInfinity(f:  val_17.x)) != true)
        {
                val_31 = this.myParticles;
            val_31[val_28].position = new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20};
        }
        
        }
        
            val_28 = val_28;
            val_27 = val_27 + 1;
            val_28 = val_28 + 132;
            val_29 = 0;
        }
        while(val_28 != val_27);
        
        }
        
        this.myParticleSystem.SetParticles(particles:  this.myParticles, size:  val_28);
    }
    public ParticlePositionToPoint()
    {
        this.myParticles = null;
    }

}
