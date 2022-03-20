using UnityEngine;
public class LookAtTarget : MonoBehaviour
{
    // Fields
    public int level;
    public UnityEngine.Transform target;
    public float speed;
    private UnityEngine.Transform mTrans;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.mTrans = this;
    }
    private void LateUpdate()
    {
        float val_4;
        float val_5;
        float val_8;
        float val_9;
        float val_17;
        float val_18;
        float val_19;
        if(this.target == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = 0f.position;
        val_18 = 0;
        UnityEngine.Vector3 val_3 = position;
        val_19 = val_4;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -6.976776E-34f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = val_5, z = val_19});
        float val_10 = val_9.magnitude;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = -6.97679E-34f, y = val_9, z = 0f});
        UnityEngine.Quaternion val_12 = rotation;
        float val_13 = UnityEngine.Time.deltaTime;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = -6.976776E-34f}, b:  new UnityEngine.Quaternion() {y = val_18, z = 0f, w = val_8}, t:  UnityEngine.Mathf.Clamp01(value:  this.speed * 0));
        val_19 = 0;
        this.mTrans.rotation = new UnityEngine.Quaternion() {w = val_17};
    }
    public LookAtTarget()
    {
        this.speed = 8f;
    }

}
