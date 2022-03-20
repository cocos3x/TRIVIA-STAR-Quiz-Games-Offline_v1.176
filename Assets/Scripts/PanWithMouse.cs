using UnityEngine;
public class PanWithMouse : IgnoreTimeScale
{
    // Fields
    public UnityEngine.Vector2 degrees;
    public float range;
    private UnityEngine.Transform mTrans;
    private UnityEngine.Quaternion mStart;
    private UnityEngine.Vector2 mRot;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.mTrans = this;
        UnityEngine.Quaternion val_2 = localRotation;
    }
    private void Update()
    {
        var val_6;
        var val_7;
        UnityEngine.Vector2 val_15;
        var val_16;
        float val_22;
        float val_1 = this.UpdateRealTimeDelta();
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        int val_4 = UnityEngine.Screen.height;
        float val_5 = (float)UnityEngine.Screen.width * 0.5f;
        float val_8 = (float)val_4 * 0.5f;
        if(static_value_021FCD72 < 0)
        {
                val_4 = 52429;
            this.range = 1036831949;
            this.range = 0.1f;
        }
        
        float val_9 = val_6 - val_5;
        val_9 = val_9 / val_5;
        val_9 = val_9 / this.range;
        float val_10 = UnityEngine.Mathf.Clamp(value:  val_9, min:  val_2.y, max:  0.1f);
        float val_11 = val_7 - val_8;
        val_11 = val_11 / val_8;
        val_11 = val_11 / this.range;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Clamp(value:  val_11, min:  val_2.y, max:  this.range), y:  val_2.y);
        float val_23 = 5f;
        val_23 = 2288875424 * val_23;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = -7.140489E-34f, y = this.mRot}, b:  new UnityEngine.Vector2() {x = R6, y = val_13.x}, t:  val_23);
        this.mRot = val_15;
        mem[1152921511190689764] = val_16;
        float val_17 = val_7 * val_16;
        float val_19 = val_17 ^ 2147483648;
        UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Euler(x:  val_17, y:  val_14.y, z:  this.degrees * val_15);
        UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = -7.140474E-34f, y = this.mStart, z = val_9, w = 0f}, rhs:  new UnityEngine.Quaternion() {x = ???});
        this.mTrans.localRotation = new UnityEngine.Quaternion() {w = val_22};
    }
    public PanWithMouse()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.mRot = new UnityEngine.Vector2();
        mem[1152921511190805860] = ???;
    }

}
