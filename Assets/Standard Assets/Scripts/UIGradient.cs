using UnityEngine;
public class UIGradient : BaseMeshEffect
{
    // Fields
    public UnityEngine.Color m_color1;
    public UnityEngine.Color m_color2;
    public float m_angle;
    public bool m_ignoreRatio;
    
    // Methods
    public void Refresh()
    {
        UnityEngine.UI.Graphic val_1 = this.graphic;
        if(this == 0)
        {
            
        }
    
    }
    public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_10;
        var val_11;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_21;
        byte val_23;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        byte val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        UnityEngine.UI.VertexHelper val_48;
        float val_49;
        float val_50;
        float val_51;
        int val_53;
        val_48 = vh;
        val_49 = 35668797;
        if(this.enabled == false)
        {
                return;
        }
        
        UnityEngine.UI.Graphic val_2 = this.graphic;
        UnityEngine.RectTransform val_3 = this.rectTransform;
        UnityEngine.Rect val_4 = rect;
        val_49 = val_8;
        UnityEngine.Vector2 val_9 = UIGradientUtils.RotationDir(angle:  val_4.m_XMin);
        val_50 = val_10;
        val_51 = val_11;
        if(mem[1152921510721951380] != false)
        {
            
        }
        else
        {
                UnityEngine.Vector2 val_12 = UIGradientUtils.CompensateAspectRatio(rect:  new UnityEngine.Rect() {m_XMin = 1.222951E+27f, m_YMin = val_6, m_Width = val_5, m_Height = val_7}, dir:  new UnityEngine.Vector2() {x = val_49, y = val_50});
            val_50 = val_6;
            val_51 = val_5;
        }
        
        Matrix2x3 val_13 = UIGradientUtils.LocalPositionMatrix(rect:  new UnityEngine.Rect() {m_XMin = 1.222951E+27f, m_YMin = val_6, m_Width = val_5, m_Height = val_7}, dir:  new UnityEngine.Vector2() {x = val_49, y = val_50});
        val_53 = 0;
        goto label_12;
        label_18:
        val_48.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 1.222961E+27f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3() {x = val_49, y = val_50, z = val_51}, tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
        val_50 = 0;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.22296E+27f, y = val_16, z = val_17});
        UnityEngine.Vector2 val_22 = UIGradientUtils.Matrix2x3.op_Multiply(m:  new Matrix2x3() {m00 = 1.22296E+27f, m01 = val_6, m02 = val_5, m10 = val_7, m11 = val_8, m12 = val_15}, v:  new UnityEngine.Vector2() {x = val_14, y = val_21});
        UnityEngine.Color val_25 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 224, g = 230, b = 124, a = 108});
        UnityEngine.Color val_26 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 1.222957E+27f}, b:  new UnityEngine.Color() {r = ???, g = mem[1152921510721951344], b = mem[1152921510721951348], a = mem[1152921510721951352]}, t:  val_25.r);
        UnityEngine.Color val_32 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.222957E+27f}, b:  new UnityEngine.Color() {r = val_28, g = val_27, b = val_29, a = val_30});
        UnityEngine.Color32 val_33 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        val_23 = val_33.r;
        val_48 = val_48;
        val_51;
        val_49 = val_46;
        val_48.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_8, y = val_15, z = val_14}, tangent = new UnityEngine.Vector4() {x = val_34, y = val_35, z = val_36, w = val_37}, color = new UnityEngine.Color32() {r = val_38, g = val_38, b = val_38, a = val_38}, uv0 = new UnityEngine.Vector2() {x = val_39, y = val_40}, uv1 = new UnityEngine.Vector2() {x = val_41, y = val_42}, uv2 = new UnityEngine.Vector2() {x = val_43, y = val_44}, uv3 = new UnityEngine.Vector2() {x = val_45, y = val_49}}, i:  val_53);
        val_53 = 1;
        label_12:
        if(val_53 < val_48.currentVertCount)
        {
            goto label_18;
        }
    
    }
    public UIGradient()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.m_ignoreRatio = true;
    }

}
