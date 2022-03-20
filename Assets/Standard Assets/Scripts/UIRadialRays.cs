using UnityEngine;
public class UIRadialRays : MaskableGraphic
{
    // Fields
    public UnityEngine.Color innerColor;
    public UnityEngine.Color outerColor;
    public UnityEngine.Color innerGlowColor;
    private UnityEngine.Texture m_Texture;
    public int rayCount;
    public float rotation;
    public float innerGlowRadius;
    
    // Properties
    public override UnityEngine.Texture mainTexture { get; }
    public UnityEngine.Texture texture { get; set; }
    private float size { get; }
    
    // Methods
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
    private float get_size()
    {
        UnityEngine.RectTransform val_1 = this.rectTransform;
        UnityEngine.Rect val_2 = rect;
        float val_3 = width;
        UnityEngine.RectTransform val_4 = this.rectTransform;
        UnityEngine.Rect val_5 = rect;
        float val_6 = height;
        UnityEngine.RectTransform val_7 = this.rectTransform;
        if(this > 0)
        {
                UnityEngine.Rect val_8 = rect;
            float val_9 = height;
            return (float)width;
        }
        
        UnityEngine.Rect val_10 = rect;
        return (float)width;
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
        
        UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 9.914809E+26f}, b:  new UnityEngine.Color() {r = val_1, g = color1.r, b = color1.g, a = color1.b});
        UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9.91483E+26f, y = 8.927367E-20f});
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
    protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vertexHelper)
    {
        vertexHelper.Clear();
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
        float val_5 = 360f / (float)this.rayCount;
        goto label_3;
    }
    public UIRadialRays()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
        this.rayCount = 16;
        this.innerGlowRadius = 0.75f;
    }

}
