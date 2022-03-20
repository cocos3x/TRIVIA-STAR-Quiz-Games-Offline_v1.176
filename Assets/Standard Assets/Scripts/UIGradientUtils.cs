using UnityEngine;
public static class UIGradientUtils
{
    // Fields
    private static UnityEngine.Vector2[] ms_verticesPositions;
    
    // Properties
    public static UnityEngine.Vector2[] VerticePositions { get; }
    
    // Methods
    public static UIGradientUtils.Matrix2x3 LocalPositionMatrix(UnityEngine.Rect rect, UnityEngine.Vector2 dir)
    {
        float val_3;
        var val_4;
        float val_5;
        var val_6;
        var val_7;
        UnityEngine.Vector2 val_1 = min;
        UnityEngine.Vector2 val_2 = size;
        float val_14 = val_3;
        var val_12 = val_4;
        float val_15 = val_5;
        var val_13 = val_6;
        val_12 = val_12 / val_14;
        val_13 = val_13 / val_15;
        val_12 = val_12 + 0.5f;
        val_13 = val_13 + 0.5f;
        mem2[0] = dir.y / val_14;
        mem2[0] = val_7 / val_15;
        val_14 = val_7 / val_14;
        val_15 = dir.y / val_15;
        val_12 = (val_12 * dir.y) + (-0.5f);
        val_13 = (val_13 * dir.y) + (-0.5f);
        mem2[0] = -val_12;
        mem2[0] = val_14;
        mem2[0] = val_15;
        mem2[0] = -val_13;
        return new Matrix2x3() {m00 = 1.241654E+27f, m01 = 1.241657E+27f, m02 = 0f, m10 = rect.m_Height};
    }
    public static UnityEngine.Vector2[] get_VerticePositions()
    {
        null = null;
    }
    public static UnityEngine.Vector2 RotationDir(float angle)
    {
        var val_2 = R1;
        val_2 = val_2 * 0.01745329f;
        mem2[0] = 0;
        mem[4] = 0;
        0 = new UnityEngine.Vector2(x:  0.01745329f, y:  null);
        return new UnityEngine.Vector2() {x = 0.01745329f};
    }
    public static UnityEngine.Vector2 CompensateAspectRatio(UnityEngine.Rect rect, UnityEngine.Vector2 dir)
    {
        float val_2 = rect.m_YMin.height;
        float val_3 = rect.m_YMin.width;
        uint val_5 = 1820689120;
        val_5 = 1820689120 / val_5;
        val_5 = val_5 * dir.y;
        UnityEngine.Vector2 val_4 = rect.m_XMin.normalized;
        return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
    }
    public static float InverseLerp(float a, float b, float v)
    {
        float val_1;
        var val_1 = R1;
        uint val_2 = 0;
        if()
        {
                val_1 = 0f;
            return (float)val_1;
        }
        
        val_1 = val_1 - val_2;
        val_2 = R2 - val_2;
        val_1 = val_2 / val_1;
        return (float)val_1;
    }
    public static UnityEngine.Color Bilerp(UnityEngine.Color a1, UnityEngine.Color a2, UnityEngine.Color b1, UnityEngine.Color b2, UnityEngine.Vector2 t)
    {
        float val_4;
        float val_5;
        float val_6;
        UnityEngine.Color val_1 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = 1.324296E+27f, g = a1.g, b = a1.b, a = a1.a}, b:  new UnityEngine.Color() {r = a2.r, g = a2.g, b = a2.b, a = a2.a}, t:  null);
        UnityEngine.Color val_2 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = 1.324293E+27f, g = b1.g, b = b1.b, a = b1.a}, b:  new UnityEngine.Color() {r = b2.r, g = b2.g, b = b2.b, a = b2.a}, t:  val_1.r);
        UnityEngine.Color val_8 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = a1.r}, b:  new UnityEngine.Color() {r = ???, g = val_4, b = val_5, a = val_6}, t:  val_2.r);
        return new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
    }
    public static void Lerp(UnityEngine.UIVertex a, UnityEngine.UIVertex b, float t, ref UnityEngine.UIVertex c)
    {
        float val_6;
        float val_7;
        float val_13;
        float val_14;
        var val_18;
        var val_19;
        float val_22;
        float val_23;
        var val_27;
        var val_28;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = 1.355574E+27f, y = a.position.x, z = a.position.y}, b:  new UnityEngine.Vector3() {x = a.position.z, y = b.position.x, z = b.position.y}, t:  t);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = 1.355572E+27f, y = a.normal.x, z = a.normal.y}, b:  new UnityEngine.Vector3() {x = a.normal.z, y = b.normal.x, z = b.normal.y}, t:  val_1.x);
        UnityEngine.Color32 val_3 = UnityEngine.Color32.LerpUnclamped(a:  new UnityEngine.Color32() {r = a.color.r, g = a.color.r, b = a.color.r, a = a.color.r}, b:  new UnityEngine.Color32() {r = b.color.r, g = b.color.r, b = b.color.r, a = b.color.r}, t:  val_2.x);
        mem[1152921510722987976] = val_3.r;
        mem[1152921510722987977] = val_3.g;
        mem[1152921510722987978] = val_3.b;
        mem[1152921510722987979] = val_3.a;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = 1.35557E+27f, y = a.tangent.x, z = a.tangent.y, w = a.tangent.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = 1.355568E+27f, y = b.tangent.x, z = b.tangent.y, w = b.tangent.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = 1.355567E+27f}, b:  new UnityEngine.Vector3() {y = val_7, z = val_6}, t:  val_5.x);
        UnityEngine.Vector4 val_10 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.355564E+27f});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.355562E+27f, y = mem[a.uv0.x + (0)]});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.35556E+27f, y = mem[b.uv0.x + (0)]});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = 1.355558E+27f}, b:  new UnityEngine.Vector3() {y = val_14, z = val_13}, t:  val_12.x);
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.355557E+27f});
        mem[1152921510722987980] = val_18;
        mem[1152921510722987984] = val_19;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.355555E+27f, y = a.uv1.x});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.355554E+27f, y = b.uv1.x});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = 1.355552E+27f}, b:  new UnityEngine.Vector3() {y = val_23, z = val_22}, t:  val_21.x);
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.355551E+27f});
        mem[1152921510722987988] = val_27;
        mem[1152921510722987992] = val_28;
    }
    private static UIGradientUtils()
    {
        var val_2;
        var val_5;
        var val_8;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.up;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_2;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_5;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.right;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_8;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = ???;
        UIGradientUtils.ms_verticesPositions = null;
    }

}
