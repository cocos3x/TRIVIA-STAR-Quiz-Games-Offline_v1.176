using UnityEngine;
public class Spin : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 rotationsPerSecond;
    private UnityEngine.Rigidbody mRb;
    private UnityEngine.Transform mTrans;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.mTrans = this;
        object val_2 = this.GetComponent<System.Object>();
        this.mRb = this;
    }
    private void Update()
    {
        if(this.mRb != 0)
        {
                return;
        }
        
        R4.ApplyDelta(delta:  UnityEngine.Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if(this.mRb == 0)
        {
                return;
        }
        
        R4.ApplyDelta(delta:  UnityEngine.Time.deltaTime);
    }
    public void ApplyDelta(float delta)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_10;
        var val_13;
        float val_13 = R1;
        val_13 = val_13 * 360f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -7.412664E-34f, y = mem[this.rotationsPerSecond + (0)], z = mem[this.rotationsPerSecond + (4)]}, d:  360f);
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = -7.412671E-34f});
        if(this.mRb == 0)
        {
                UnityEngine.Quaternion val_8 = rotation;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = -7.412664E-34f}, rhs:  new UnityEngine.Quaternion() {x = val_6, y = val_3, z = val_4, w = val_5});
            val_13 = 0;
            this.mTrans.rotation = new UnityEngine.Quaternion() {w = val_10};
            return;
        }
        
        UnityEngine.Quaternion val_11 = rotation;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = -7.412664E-34f}, rhs:  new UnityEngine.Quaternion() {x = val_6, y = val_3, z = val_4, w = val_5});
        val_13 = 0;
        this.mRb.MoveRotation(rot:  new UnityEngine.Quaternion() {w = val_10});
    }
    public Spin()
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
    }

}
