using UnityEngine;
public class UITextCornersGradient : BaseMeshEffect
{
    // Fields
    public UnityEngine.Color m_topLeftColor;
    public UnityEngine.Color m_topRightColor;
    public UnityEngine.Color m_bottomRightColor;
    public UnityEngine.Color m_bottomLeftColor;
    
    // Methods
    public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
    {
        byte val_5;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        byte val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        UnityEngine.UI.VertexHelper val_32;
        var val_33;
        float val_34;
        var val_36;
        var val_37;
        val_32 = vh;
        val_33 = 35668812;
        if(this.enabled == false)
        {
                return;
        }
        
        UnityEngine.UI.Graphic val_2 = this.graphic;
        val_33 = this;
        UnityEngine.RectTransform val_3 = this.rectTransform;
        val_34 = val_33;
        UnityEngine.Rect val_4 = rect;
        val_36 = 0;
        goto label_4;
        label_15:
        val_32.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 1.437036E+27f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
        var val_32 = 7111415;
        val_32 = 28557428 + val_32;
        val_37 = null;
        val_37 = null;
        UnityEngine.Color val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 248, g = 149, b = 148, a = 108});
        UnityEngine.Color val_7 = UIGradientUtils.Bilerp(a1:  new UnityEngine.Color() {r = 1.437031E+27f, g = R7, b = LR, a = mem[1152921510723503528]}, a2:  new UnityEngine.Color() {r = mem[1152921510723503532], a = ???}, b1:  new UnityEngine.Color() {r = ???, g = mem[1152921510723503472], b = mem[1152921510723503476], a = mem[1152921510723503480]}, b2:  new UnityEngine.Color() {r = ???, g = ???, b = ???, a = ???}, t:  new UnityEngine.Vector2() {x = ???, y = UIGradientUtils.ms_verticesPositions + 12 + 16});
        UnityEngine.Color val_13 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.437029E+27f}, b:  new UnityEngine.Color() {r = val_9, g = val_8, b = val_10, a = val_11});
        UnityEngine.Color32 val_14 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        val_5 = val_14.r;
        val_32 = val_32;
        val_33;
        val_34 = val_30;
        val_32.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, tangent = new UnityEngine.Vector4() {x = val_18, y = val_19, z = val_20, w = val_21}, color = new UnityEngine.Color32() {r = val_22, g = val_22, b = val_22, a = val_22}, uv0 = new UnityEngine.Vector2() {x = val_23, y = val_24}, uv1 = new UnityEngine.Vector2() {x = val_25, y = val_26}, uv2 = new UnityEngine.Vector2() {x = val_27, y = val_28}, uv3 = new UnityEngine.Vector2() {x = val_29, y = val_34}}, i:  0);
        val_36 = 1;
        label_4:
        if(val_36 < val_32.currentVertCount)
        {
            goto label_15;
        }
    
    }
    public UITextCornersGradient()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
    }

}
