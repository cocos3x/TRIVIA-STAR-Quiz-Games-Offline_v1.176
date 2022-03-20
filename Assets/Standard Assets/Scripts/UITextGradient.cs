using UnityEngine;
public class UITextGradient : BaseMeshEffect
{
    // Fields
    public UnityEngine.Color m_color1;
    public UnityEngine.Color m_color2;
    public float m_angle;
    
    // Methods
    public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
    {
        float val_6;
        float val_7;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        byte val_17;
        float val_21;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        byte val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        int val_43;
        var val_44;
        var val_45;
        val_39 = 35668813;
        if(this.enabled == false)
        {
                return;
        }
        
        UnityEngine.UI.Graphic val_2 = this.graphic;
        UnityEngine.RectTransform val_3 = this.rectTransform;
        UnityEngine.Rect val_4 = rect;
        UnityEngine.Vector2 val_5 = UIGradientUtils.RotationDir(angle:  val_4.m_XMin);
        val_40 = val_6;
        val_41 = val_7;
        UnityEngine.Rect val_8 = new UnityEngine.Rect(x:  val_5.x, y:  val_5.y, width:  val_4.m_Width, height:  val_4.m_Height);
        Matrix2x3 val_9 = UIGradientUtils.LocalPositionMatrix(rect:  new UnityEngine.Rect() {m_XMin = 1.471282E+27f, m_YMin = val_8.m_XMin, m_Width = val_8.m_YMin, m_Height = val_8.m_Width}, dir:  new UnityEngine.Vector2() {x = val_8.m_XMin, y = val_40});
        val_43 = 0;
        goto label_6;
        label_17:
        val_9.m11.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 1.471301E+27f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3() {x = val_8.m_XMin, y = val_40, z = val_41}, tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
        var val_39 = 7110099;
        val_39 = 28558744 + val_39;
        val_44 = null;
        val_44 = null;
        if((UIGradientUtils.ms_verticesPositions + 12) <= 0)
        {
                val_45 = 0;
        }
        
        UnityEngine.Vector2 val_16 = UIGradientUtils.Matrix2x3.op_Multiply(m:  new Matrix2x3() {m00 = 1.471297E+27f, m01 = val_10, m02 = val_11, m10 = val_12, m11 = val_13, m12 = val_15}, v:  new UnityEngine.Vector2() {x = val_14, y = UIGradientUtils.ms_verticesPositions + 12 + 16});
        UnityEngine.Color val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 240, g = 32, b = 152, a = 108});
        val_41 = 0;
        UnityEngine.Color val_20 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 1.471295E+27f, g = mem[this.m_color2 + (0)], b = mem[this.m_color2 + (4)], a = mem[this.m_color2 + (8)]}, b:  new UnityEngine.Color() {r = mem[this.m_color2 + (12)], g = this.m_color1, b = val_40, a = val_9.m11}, t:  val_19.r);
        UnityEngine.Color val_23 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.471292E+27f, g = val_8.m_XMin, b = val_8.m_YMin, a = val_8.m_Width}, b:  new UnityEngine.Color() {r = val_8.m_Height, g = val_6, b = val_7, a = val_21});
        UnityEngine.Color32 val_24 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        val_17 = val_24.r;
        val_42 = val_9.m11;
        val_39;
        val_40 = val_37;
        val_42.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_13, y = val_15, z = val_14}, tangent = new UnityEngine.Vector4() {x = val_25, y = val_26, z = val_27, w = val_28}, color = new UnityEngine.Color32() {r = val_29, g = val_29, b = val_29, a = val_29}, uv0 = new UnityEngine.Vector2() {x = val_30, y = val_31}, uv1 = new UnityEngine.Vector2() {x = val_32, y = val_33}, uv2 = new UnityEngine.Vector2() {x = val_34, y = val_35}, uv3 = new UnityEngine.Vector2() {x = val_36, y = val_40}}, i:  val_43);
        val_43 = 1;
        label_6:
        if(val_43 < val_42.currentVertCount)
        {
            goto label_17;
        }
    
    }
    public UITextGradient()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
    }

}
