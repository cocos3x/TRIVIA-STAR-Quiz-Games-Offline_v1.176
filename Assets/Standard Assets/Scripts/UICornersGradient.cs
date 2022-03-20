using UnityEngine;
public class UICornersGradient : BaseMeshEffect
{
    // Fields
    public UnityEngine.Color m_topLeftColor;
    public UnityEngine.Color m_topRightColor;
    public UnityEngine.Color m_bottomRightColor;
    public UnityEngine.Color m_bottomLeftColor;
    
    // Methods
    public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
    {
        float val_6;
        float val_7;
        float val_8;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_21;
        float val_23;
        byte val_25;
        float val_28;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        byte val_36;
        float val_37;
        float val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_46;
        float val_47;
        float val_48;
        float val_49;
        var val_51;
        UnityEngine.Color val_52;
        UnityEngine.Color val_55;
        if(this.enabled == false)
        {
                return;
        }
        
        UnityEngine.UI.Graphic val_2 = this.graphic;
        UnityEngine.RectTransform val_3 = this.rectTransform;
        UnityEngine.Rect val_4 = rect;
        val_46 = 0f;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.right;
        val_47 = val_6;
        val_48 = val_8;
        Matrix2x3 val_9 = UIGradientUtils.LocalPositionMatrix(rect:  new UnityEngine.Rect() {m_XMin = 1.197554E+27f}, dir:  new UnityEngine.Vector2() {x = val_7, y = val_47});
        val_51 = 0;
        goto label_8;
        label_16:
        val_9.m12.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 1.197564E+27f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3() {x = val_7, y = val_47, z = val_48}, tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.197563E+27f, y = val_16, z = val_17});
        UnityEngine.Vector2 val_22 = UIGradientUtils.Matrix2x3.op_Multiply(m:  new Matrix2x3() {m00 = 1.197562E+27f, m01 = val_10, m02 = val_11, m10 = val_12, m11 = val_13, m12 = val_15}, v:  new UnityEngine.Vector2() {x = val_14, y = val_21});
        UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 120, g = 166, b = 119, a = 108});
        val_52 = this.m_topLeftColor;
        val_55 = this.m_bottomLeftColor;
        UnityEngine.Color val_27 = UIGradientUtils.Bilerp(a1:  new UnityEngine.Color() {r = 1.197561E+27f, g = val_55, b = this.m_bottomRightColor, a = this.m_bottomRightColor}, a2:  new UnityEngine.Color() {r = val_46, g = this.m_bottomRightColor, b = this.m_bottomRightColor, a = this.m_bottomRightColor}, b1:  new UnityEngine.Color() {r = this.m_bottomRightColor, g = val_52, b = ???, a = ???}, b2:  new UnityEngine.Color() {r = ???, g = ???}, t:  new UnityEngine.Vector2() {y = val_23});
        val_46 = 0;
        UnityEngine.Color val_30 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.19756E+27f}, b:  new UnityEngine.Color() {r = val_7, g = val_6, b = val_8, a = val_28});
        UnityEngine.Color32 val_31 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        val_25 = val_31.r;
        val_49 = val_9.m12;
        val_47;
        val_48 = val_44;
        val_49.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_13, y = val_15, z = val_14}, tangent = new UnityEngine.Vector4() {x = val_32, y = val_33, z = val_34, w = val_35}, color = new UnityEngine.Color32() {r = val_36, g = val_36, b = val_36, a = val_36}, uv0 = new UnityEngine.Vector2() {x = val_37, y = val_38}, uv1 = new UnityEngine.Vector2() {x = val_39, y = val_40}, uv2 = new UnityEngine.Vector2() {x = val_41, y = val_42}, uv3 = new UnityEngine.Vector2() {x = val_43, y = val_48}}, i:  0);
        val_51 = 1;
        label_8:
        if(val_51 < val_49.currentVertCount)
        {
            goto label_16;
        }
    
    }
    public UICornersGradient()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
    }

}
