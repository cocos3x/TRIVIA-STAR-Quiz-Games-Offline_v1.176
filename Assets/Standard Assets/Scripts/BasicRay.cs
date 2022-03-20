using UnityEngine;
public class BasicRay : MaskableGraphic
{
    // Fields
    public UnityEngine.Color innerColor;
    public UnityEngine.Color outerColor;
    public float shrinkSource;
    private UnityEngine.Texture m_Texture;
    
    // Properties
    public UnityEngine.Texture texture { get; set; }
    public override UnityEngine.Texture mainTexture { get; }
    
    // Methods
    public UnityEngine.Texture get_texture()
    {
    
    }
    public void set_texture(UnityEngine.Texture value)
    {
        if(this.m_Texture == value)
        {
                return;
        }
        
        this.m_Texture = value;
        this.SetVerticesDirty();
        this.SetMaterialDirty();
    }
    protected override void OnRectTransformDimensionsChange()
    {
        this.OnRectTransformDimensionsChange();
        this.SetVerticesDirty();
        this.SetMaterialDirty();
    }
    public override UnityEngine.Texture get_mainTexture()
    {
        var val_2;
        if(this.m_Texture != 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
    }
    private UnityEngine.UIVertex[] SetVBO(UnityEngine.Vector2[] vertices, UnityEngine.Vector2[] uvs, UnityEngine.Color color1, UnityEngine.Color color2)
    {
        float val_1;
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        var val_9;
        var val_10;
        var val_11;
        UnityEngine.Vector2[] val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        float val_21;
        UnityEngine.Vector2[] val_22;
        var val_23;
        val_12 = vertices;
        val_13 = null;
        val_14 = 1152921506293842820;
        UnityEngine.Vector2[] val_12 = uvs;
        val_12 = val_12 + 16;
        val_16 = 0;
        goto label_1;
        label_14:
        val_17 = null;
        val_17 = null;
        if(val_16 <= 1)
        {
                val_21 = color2.a;
        }
        else
        {
                val_21 = color1.a;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 9.102562E+26f}, b:  new UnityEngine.Color() {r = val_1, g = color1.r, b = color1.g, a = color1.b});
        UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9.102583E+26f, y = 8.927367E-20f});
        val_22 = uvs;
        if(val_22 == null)
        {
                val_22 = uvs;
        }
        
        val_23 = 12;
        val_13 = val_13;
        if(val_13 == 0)
        {
                val_13 = val_13;
            val_23 = 12;
        }
        
        val_13 = val_13;
        val_23 = 12;
        val_16 = 1;
        UnityEngine.UIVertex[].__il2cppRuntimeField_events.__il2cppRuntimeField_FFFFFFFFFFFFFFCC = val_9;
        UnityEngine.UIVertex[].__il2cppRuntimeField_events.__il2cppRuntimeField_FFFFFFFFFFFFFFD0 = val_11;
        UnityEngine.UIVertex[].__il2cppRuntimeField_events.__il2cppRuntimeField_FFFFFFFFFFFFFFD4 = val_10;
        val_12 = val_12;
        UnityEngine.UIVertex[].__il2cppRuntimeField_events.__il2cppRuntimeField_10 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_58;
        val_15 = val_12[16] + 8;
        UnityEngine.Vector2[] val_14 = val_12;
        val_14 = val_14 + 8;
        label_1:
        if(val_12 == null)
        {
                val_13 = val_13;
        }
        
        if(val_16 < (vertices + 12))
        {
            goto label_14;
        }
    
    }
    private void AddRay(UnityEngine.UI.VertexHelper vh, UnityEngine.Vector2 source, UnityEngine.Vector2 end, float shrink = 1)
    {
        var val_1;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        var val_23 = val_1;
        float val_24 = source.x;
        float val_21 = end.x;
        float val_22 = 1f;
        val_21 = val_21 - val_24;
        val_22 = val_22 - val_23;
        val_21 = val_21 * 0.5f;
        val_23 = val_22 * val_21;
        float val_2 = val_21 + val_24;
        val_24 = val_2 - val_23;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_24, y:  null);
        float val_4 = val_2 + val_23;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  null);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  null);
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4, y:  null);
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_4, y:  null);
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_4, y:  null);
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_4, y:  null);
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_3.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = val_3.y;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_5.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_1C = val_5.y;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = end.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = end.y;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_6.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_7.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_10.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_9.x;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_10.x;
        UnityEngine.Color val_11 = color;
        UnityEngine.Color val_12 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 9.242675E+26f, g = this.outerColor, b = 8.927367E-20f, a = val_10.y}, b:  new UnityEngine.Color() {r = val_5.x, a = val_9.x});
        UnityEngine.Color val_13 = color;
        UnityEngine.Color val_14 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 9.242651E+26f, g = this.innerColor, b = val_10.y, a = 8.927367E-20f}, b:  new UnityEngine.Color() {r = this.outerColor});
        UnityEngine.UIVertex[] val_20 = this.SetVBO(vertices:  533908128, uvs:  533908128, color1:  new UnityEngine.Color() {r = val_15}, color2:  new UnityEngine.Color() {r = val_16, g = val_17, b = val_18, a = val_19});
        vh.AddUIVertexQuad(verts:  1816089008);
    }
    protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
    {
        float val_4;
        float val_6;
        var val_7;
        float val_22;
        float val_32;
        float val_33;
        float val_34;
        float val_36;
        float val_37;
        vh.Clear();
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.RectTransform val_2 = this.rectTransform;
        UnityEngine.Vector2 val_3 = pivot;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9.331384E+26f, y = val_1.x}, b:  new UnityEngine.Vector2() {x = val_1.y, y = val_4});
        float val_38 = val_6;
        UnityEngine.RectTransform val_8 = this.rectTransform;
        UnityEngine.Rect val_9 = rect;
        float val_10 = width;
        val_38 = val_38 * 1816197128;
        UnityEngine.RectTransform val_11 = this.rectTransform;
        UnityEngine.Rect val_12 = rect;
        float val_13 = height;
        uint val_39 = 1816197128;
        val_39 = val_7 * val_39;
        UnityEngine.RectTransform val_14 = this.rectTransform;
        UnityEngine.Rect val_15 = rect;
        float val_16 = width;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(d:  val_17.x, a:  new UnityEngine.Vector2() {x = 9.331349E+26f, y = 9.331402E+26f});
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 9.331343E+26f, y = val_38}, b:  new UnityEngine.Vector2() {x = val_39, y = val_22});
        UnityEngine.RectTransform val_24 = this.rectTransform;
        UnityEngine.Rect val_25 = rect;
        float val_26 = height;
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.up;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Multiply(d:  val_27.x, a:  new UnityEngine.Vector2() {x = 9.331319E+26f, y = 9.331402E+26f});
        UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 9.331314E+26f, y = val_32}, b:  new UnityEngine.Vector2() {x = val_33, y = val_34});
        this.AddRay(vh:  vh, source:  new UnityEngine.Vector2() {x = val_38, y = val_39}, end:  new UnityEngine.Vector2() {x = val_37, y = val_36}, shrink:  this.shrinkSource);
    }
    public BasicRay()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        this.shrinkSource = 0.5f;
    }

}
