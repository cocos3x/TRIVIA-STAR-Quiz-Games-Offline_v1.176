using UnityEngine;
public class Gradient : BaseMeshEffect
{
    // Fields
    public Gradient.GradientDirection GradientType;
    public float Offset;
    public UnityEngine.Color32 StartColor;
    public UnityEngine.Color32 EndColor;
    
    // Methods
    public override void ModifyMesh(UnityEngine.UI.VertexHelper helper)
    {
        float val_6;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        byte val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_27;
        int val_30;
        System.Collections.Generic.List<UnityEngine.UIVertex> val_31;
        var val_33;
        var val_35;
        var val_38;
        val_30 = 35641540;
        if(this.IsActive() == false)
        {
                return;
        }
        
        if(helper.currentVertCount == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
        helper.GetUIVertexStream(stream:  80883712);
        if(this.GradientType == 1)
        {
            goto label_6;
        }
        
        if(this.GradientType != 0)
        {
                return;
        }
        
        val_33 = 1152921505700909039;
        if(val_33 < 1)
        {
            goto label_9;
        }
        
        val_35 = List<T>.__il2cppRuntimeField_14;
        do
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[-3458764429577766152];
            val_33 = 1152921505700909038;
        }
        while(val_33 > 0);
        
        goto label_23;
        label_6:
        val_33 = 1152921505700909039;
        if(val_33 < 1)
        {
            goto label_16;
        }
        
        val_38 = List<T>.__il2cppRuntimeField_10;
        do
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_38 = mem[-3458764429577766156];
            val_33 = 1152921505700909038;
        }
        while(val_33 > 0);
        
        goto label_25;
        label_9:
        val_35 = List<T>.__il2cppRuntimeField_14;
        goto label_23;
        label_16:
        val_38 = List<T>.__il2cppRuntimeField_10;
        goto label_25;
        label_23:
        val_30 = 0;
        float val_5 = 1f / ((List<T>.__il2cppRuntimeField_14) - (List<T>.__il2cppRuntimeField_14));
        goto label_26;
        label_30:
        helper.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = -5.989302E-34f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
        float val_30 = val_6;
        val_30 = val_30 - (List<T>.__il2cppRuntimeField_14);
        UnityEngine.Color32 val_7 = UnityEngine.Color32.Lerp(a:  new UnityEngine.Color32() {r = this.EndColor, g = this.EndColor, b = this.EndColor, a = this.EndColor}, b:  new UnityEngine.Color32() {r = this.StartColor, g = this.StartColor, b = this.StartColor, a = this.StartColor}, t:  val_30);
        val_33;
        helper.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, tangent = new UnityEngine.Vector4() {x = val_11, y = val_12, z = val_13, w = val_14}, color = new UnityEngine.Color32() {r = val_15, g = val_15, b = val_15, a = val_15}, uv0 = new UnityEngine.Vector2() {x = val_16, y = val_17}, uv1 = new UnityEngine.Vector2() {x = val_18, y = val_19}, uv2 = new UnityEngine.Vector2() {x = val_20, y = val_21}, uv3 = new UnityEngine.Vector2() {x = val_22, y = val_23}}, i:  val_30);
        val_30 = 1;
        label_26:
        if(val_30 < helper.currentVertCount)
        {
            goto label_30;
        }
        
        return;
        label_25:
        val_30 = 0;
        float val_26 = 1f / ((List<T>.__il2cppRuntimeField_10) - (List<T>.__il2cppRuntimeField_10));
        goto label_32;
        label_36:
        helper.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = -5.989272E-34f, y = 0f, z = 0f}, normal = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, tangent = new UnityEngine.Vector4() {x = val_11, y = val_12, z = val_13, w = val_14}, color = new UnityEngine.Color32() {r = val_15, g = val_15, b = val_15, a = val_15}, uv0 = new UnityEngine.Vector2() {x = val_16, y = val_17}, uv1 = new UnityEngine.Vector2() {x = val_18, y = val_19}, uv2 = new UnityEngine.Vector2() {x = val_20, y = val_21}, uv3 = new UnityEngine.Vector2() {x = val_22, y = val_23}}, i:  val_30);
        float val_31 = val_27;
        val_31 = val_31 - (List<T>.__il2cppRuntimeField_10);
        UnityEngine.Color32 val_28 = UnityEngine.Color32.Lerp(a:  new UnityEngine.Color32() {r = this.EndColor, g = this.EndColor, b = this.EndColor, a = this.EndColor}, b:  new UnityEngine.Color32() {r = this.StartColor, g = this.StartColor, b = this.StartColor, a = this.StartColor}, t:  val_31);
        val_33;
        helper.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, tangent = new UnityEngine.Vector4() {x = val_11, y = val_12, z = val_13, w = val_14}, color = new UnityEngine.Color32() {r = val_15, g = val_15, b = val_15, a = val_15}, uv0 = new UnityEngine.Vector2() {x = val_16, y = val_17}, uv1 = new UnityEngine.Vector2() {x = val_18, y = val_19}, uv2 = new UnityEngine.Vector2() {x = val_20, y = val_21}, uv3 = new UnityEngine.Vector2() {x = val_22, y = val_23}}, i:  val_30);
        val_30 = 1;
        label_32:
        if(val_30 < helper.currentVertCount)
        {
            goto label_36;
        }
    
    }
    public Gradient()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color32 val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        this.StartColor = val_2;
        UnityEngine.Color val_3 = UnityEngine.Color.black;
        UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        this.EndColor = val_4;
    }

}
