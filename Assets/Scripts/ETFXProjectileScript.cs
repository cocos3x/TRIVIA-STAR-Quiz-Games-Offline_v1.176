using UnityEngine;
public class ETFXProjectileScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject impactParticle;
    public UnityEngine.GameObject projectileParticle;
    public UnityEngine.GameObject muzzleParticle;
    public float colliderRadius;
    public float collideOffset;
    
    // Methods
    private void Start()
    {
        float val_5;
        float val_14;
        float val_15;
        float val_16;
        UnityEngine.GameObject val_18;
        float val_19;
        float val_20;
        val_18 = this.projectileParticle;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Quaternion val_4 = rotation;
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {w = val_5});
        this.projectileParticle = val_18;
        UnityEngine.Transform val_7 = val_18.transform;
        UnityEngine.Transform val_8 = this.transform;
        val_20 = this;
        val_18.parent = -1767143040;
        if((UnityEngine.Object.op_Implicit(exists:  this.muzzleParticle)) == false)
        {
                return;
        }
        
        val_18 = this.muzzleParticle;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = position;
        UnityEngine.Transform val_12 = this.transform;
        UnityEngine.Quaternion val_13 = rotation;
        val_19 = val_14;
        val_20 = val_16;
        UnityEngine.GameObject val_17 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_15, y = val_19, z = val_20, w = val_5});
        this.muzzleParticle = val_18;
        UnityEngine.Object.Destroy(obj:  val_18, t:  val_13.x);
    }
    private void FixedUpdate()
    {
        float val_3;
        float val_4;
        float val_10;
        float val_42;
        float val_43;
        float val_50;
        float val_51;
        float val_54;
        float val_63;
        float val_64;
        float val_65;
        float val_66;
        var val_67;
        val_63 = 1152921510151666016;
        object val_1 = this.GetComponent<System.Object>();
        UnityEngine.Vector3 val_2 = velocity;
        float val_5 = val_4.magnitude;
        if(this != 0)
        {
                UnityEngine.Transform val_6 = this.transform;
            object val_7 = this.GetComponent<System.Object>();
            UnityEngine.Vector3 val_8 = val_4.velocity;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = -2.803539E-25f, y = val_4, z = 0f});
            this.rotation = new UnityEngine.Quaternion() {w = val_10};
        }
        
        UnityEngine.Transform val_11 = this.transform;
        object val_12 = this.GetComponent<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  -1767000240)) != false)
        {
                UnityEngine.Transform val_14 = this.transform;
            object val_15 = this.GetComponent<System.Object>();
            float val_16 = this.radius;
            val_64 = 2527967056;
        }
        else
        {
                val_64 = this.colliderRadius;
        }
        
        UnityEngine.Transform val_17 = this.transform;
        object val_18 = this.GetComponent<System.Object>();
        UnityEngine.Vector3 val_19 = velocity;
        UnityEngine.Transform val_20 = this.transform;
        object val_21 = this.GetComponent<System.Object>();
        if(this.useGravity != false)
        {
                UnityEngine.Vector3 val_23 = UnityEngine.Physics.gravity;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.803543E-25f}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.803535E-25f, y = val_4, z = 0f}, b:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = 0f});
        }
        
        UnityEngine.Vector3 val_29 = normalized;
        UnityEngine.Transform val_30 = this.transform;
        object val_31 = this.GetComponent<System.Object>();
        val_65 = 0f;
        UnityEngine.Vector3 val_32 = val_4.velocity;
        float val_33 = val_4.magnitude;
        uint val_64 = 2527954920;
        float val_34 = UnityEngine.Time.deltaTime;
        val_64 = val_64 * 0;
        UnityEngine.Transform val_35 = this.transform;
        UnityEngine.Vector3 val_36 = position;
        if((UnityEngine.Physics.SphereCast(origin:  new UnityEngine.Vector3(), radius:  val_36.x, direction:  new UnityEngine.Vector3() {x = val_64, y = val_4, z = 0f}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_3, y = -2.803551E-25f, z = val_64}, m_Normal = new UnityEngine.Vector3() {x = val_65}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_36.y)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_38 = this.transform;
        UnityEngine.Vector3 val_39 = val_4.point;
        UnityEngine.Vector3 val_40 = normal;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.803532E-25f}, d:  val_40.x);
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.803529E-25f, y = val_4, z = 0f}, b:  new UnityEngine.Vector3() {x = val_3, y = val_43, z = val_42});
        this.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_46 = this.transform;
        UnityEngine.Vector3 val_47 = position;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_49 = normal;
        UnityEngine.Quaternion val_53 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = -2.803539E-25f}, toDirection:  new UnityEngine.Vector3() {y = val_51, z = val_50});
        val_66 = val_54;
        UnityEngine.GameObject val_55 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.impactParticle, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_4, y = val_66, z = val_3, w = val_10});
        T[] val_56 = this.GetComponentsInChildren<System.Object>();
        val_67 = 5;
        val_63 = "Trail";
        goto label_33;
        label_45:
        val_66 = this.muzzleParticle;
        UnityEngine.GameObject val_57 = val_66.gameObject;
        string val_58 = val_66.name;
        if((val_66.Contains(value:  -1767036608)) != false)
        {
                UnityEngine.Transform val_60 = val_66.transform;
            val_66.SetParent(p:  0);
            UnityEngine.GameObject val_61 = val_66.gameObject;
            val_66 = val_66;
            UnityEngine.Object.Destroy(obj:  val_66, t:  val_53.x);
        }
        
        val_67 = 6;
        label_33:
        if((val_67 - 4) < this.impactParticle)
        {
            goto label_45;
        }
        
        val_65 = this.projectileParticle;
        UnityEngine.Object.Destroy(obj:  val_65, t:  val_53.x);
        UnityEngine.Object.Destroy(obj:  this.impactParticle, t:  val_53.x);
        UnityEngine.GameObject val_63 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1767000240);
    }
    public ETFXProjectileScript()
    {
        this.colliderRadius = 1f;
        this.collideOffset = 0.15f;
    }

}
