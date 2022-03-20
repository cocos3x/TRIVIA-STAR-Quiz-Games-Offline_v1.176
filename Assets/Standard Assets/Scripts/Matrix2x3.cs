using UnityEngine;
public struct UIGradientUtils.Matrix2x3
{
    // Fields
    public float m00;
    public float m01;
    public float m02;
    public float m10;
    public float m11;
    public float m12;
    
    // Methods
    public UIGradientUtils.Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
    {
        float val_1;
        float val_2;
        float val_3;
        this.m10 = val_3;
        this.m11 = val_1;
        this.m12 = val_2;
    }
    public static UnityEngine.Vector2 op_Multiply(UIGradientUtils.Matrix2x3 m, UnityEngine.Vector2 v)
    {
        var val_1;
        float val_4 = m.m01;
        float val_3 = m.m12;
        val_3 = val_3 * val_1;
        val_4 = val_4 * v.y;
        float val_5 = v.x;
        float val_6 = m.m10;
        mem2[0] = 0;
        mem2[0] = 0;
        val_5 = val_3 + val_5;
        val_6 = val_4 + val_6;
        val_2 = new UnityEngine.Vector2(x:  val_5, y:  null);
        return new UnityEngine.Vector2() {x = val_5};
    }

}
