using UnityEngine;
public class iTween
{
    // Methods
    private static UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path)
    {
        var val_15;
        var val_16;
        var val_18;
        var val_34;
        float val_38;
        var val_40;
        var val_1 = R1 + 2;
        val_34 = null;
        System.Array.Copy(sourceArray:  path, sourceIndex:  0, destinationArray:  533912224, destinationIndex:  1, length:  null);
        val_38 = UnityEngine.Vector3[].__il2cppRuntimeField_castClass;
        val_38 = UnityEngine.Vector3[].__il2cppRuntimeField_castClass;
        val_38 = val_38;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.773293E-37f, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C, z = 2.335942E-33f}, b:  new UnityEngine.Vector3() {x = val_38, y = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType, z = UnityEngine.Vector3[].__il2cppRuntimeField_parent});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.773292E-37f, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C, z = 2.335942E-33f}, b:  new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_castClass});
        val_40 = (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.773291E-37f, y = mem[((val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 16) + (0)], z = mem[((val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 16) + (4)]}, b:  new UnityEngine.Vector3() {x = mem[((val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 16) + (8)], y = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 3) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 3)) << 1)) << 2) + 16, z = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 3) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 3)) << 1)) << 2) + 20});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.773289E-37f, y = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 16, z = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 20}, b:  new UnityEngine.Vector3() {x = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 24});
        mem2[0] = val_15;
        mem2[0] = val_16;
        mem2[0] = val_18;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C, y = 2.335942E-33f, z = UnityEngine.Vector3[].__il2cppRuntimeField_castClass}, rhs:  new UnityEngine.Vector3() {x = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 16, y = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 20, z = (val_34 + (((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2) + ((UnityEngine.Vector3[].__il2cppRuntimeField_namespaze - 2)) << 1)) << 2) + 24})) == false)
        {
                return;
        }
        
        System.Array.Copy(sourceArray:  533912224, destinationArray:  533912224, length:  UnityEngine.Vector3[].__il2cppRuntimeField_namespaze);
        mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType;
        mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_parent;
        mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_generic_class;
        val_34 = null;
        System.Array.Copy(sourceArray:  533912224, destinationArray:  533912224, length:  UnityEngine.Vector3[].__il2cppRuntimeField_namespaze);
    }
    public static System.Collections.Generic.List<UnityEngine.Vector3> GetSmoothPoints(UnityEngine.Vector3[] points, int smooth)
    {
        float val_7;
        float val_8;
        float val_9;
        var val_10;
        var val_11;
        System.Func<UnityEngine.Vector3, UnityEngine.Vector3> val_13;
        float val_15;
        val_10 = smooth;
        if(true == 1)
        {
                val_11 = null;
            val_11 = null;
            val_13 = iTween.<>c.<>9__1_0;
            if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Func<UnityEngine.Vector3, UnityEngine.Vector3>(object:  iTween.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2188641552));
            iTween.<>c.<>9__1_0 = val_13;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Vector3, UnityEngine.Vector3>(source:  points, selector:  7720960);
            return System.Linq.Enumerable.ToList<UnityEngine.Vector3>(source:  points);
        }
        
        UnityEngine.Vector3[] val_3 = iTween.PathControlPointGenerator(path:  points);
        System.Collections.Generic.List<UnityEngine.Vector3> val_5 = (new System.Collections.Generic.List<UnityEngine.Vector3>()) * val_10;
        if(val_5 < 1)
        {
                return;
        }
        
        var val_11 = 1;
        do
        {
            float val_10 = 1f;
            val_10 = val_10 / (float)val_5;
            UnityEngine.Vector3 val_6 = iTween.Interp(pts:  -2106309700, t:  val_10);
            val_15 = val_8;
            Add(item:  new UnityEngine.Vector3() {x = val_7, y = val_15, z = val_9});
            val_11 = val_11 + 1;
        }
        while(val_11 <= val_5);
    
    }
    private static UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t)
    {
        float val_14;
        float val_16;
        float val_19;
        float val_20;
        float val_28;
        float val_29;
        float val_33;
        float val_34;
        float val_39;
        float val_40;
        float val_46;
        float val_47;
        float val_51;
        float val_52;
        float val_56;
        float val_59 = R2;
        var val_60 = R1 + 12;
        val_59 = ((float)val_60 - 3) * val_59;
        int val_4 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  (float)val_60 - 3), b:  val_60 - 4);
        float val_61 = (float)val_4;
        int val_5 = val_4 + (val_4 << 1);
        val_60 = val_4 + 1;
        val_5 = R1 + (val_5 << 2);
        int val_6 = val_60 + (val_60 << 1);
        int val_7 = val_4 + 2;
        val_6 = R1 + (val_6 << 2);
        var val_8 = val_6 + 16;
        int val_9 = val_7 + (val_7 << 1);
        int val_10 = val_4 + 3;
        val_9 = R1 + (val_9 << 2);
        val_59 = val_59 - val_61;
        int val_11 = val_10 + (val_10 << 1);
        val_11 = R1 + (val_11 << 2);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = -1.815391E-37f, y = (R1 + ((val_4 + (val_4) << 1)) << 2) + 16, z = (R1 + ((val_4 + (val_4) << 1)) << 2) + 20});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  val_12.x, a:  new UnityEngine.Vector3() {x = -1.81539E-37f, y = 3f, z = mem[((R1 + (((val_4 + 1) + ((val_4 + 1)) << 1)) << 2) + 16) + (0)]});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815389E-37f}, b:  new UnityEngine.Vector3() {y = val_16, z = val_14});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  val_17.x, a:  new UnityEngine.Vector3() {x = -1.815387E-37f, y = 3f, z = (R1 + (((val_4 + 2) + ((val_4 + 2)) << 1)) << 2) + 16});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.815386E-37f}, b:  new UnityEngine.Vector3() {y = val_20, z = val_19});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815385E-37f}, b:  new UnityEngine.Vector3() {y = (R1 + (((val_4 + 3) + ((val_4 + 3)) << 1)) << 2) + 16, z = (R1 + (((val_4 + 3) + ((val_4 + 3)) << 1)) << 2) + 20});
        val_61 = val_59 * val_59;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.815383E-37f}, d:  val_59 * val_61);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(d:  val_25.x, a:  new UnityEngine.Vector3() {x = -1.815382E-37f, y = 2f, z = (R1 + ((val_4 + (val_4) << 1)) << 2) + 16});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(d:  val_26.x, a:  new UnityEngine.Vector3() {x = -1.815381E-37f, y = 5f, z = mem[((R1 + (((val_4 + 1) + ((val_4 + 1)) << 1)) << 2) + 16) + (0)]});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.815379E-37f}, b:  new UnityEngine.Vector3() {y = val_29, z = val_28});
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(d:  val_31.x, a:  new UnityEngine.Vector3() {x = -1.815378E-37f, y = 4f, z = (R1 + (((val_4 + 2) + ((val_4 + 2)) << 1)) << 2) + 16});
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815378E-37f}, b:  new UnityEngine.Vector3() {y = val_34, z = val_33});
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -1.815377E-37f}, b:  new UnityEngine.Vector3() {y = (R1 + (((val_4 + 3) + ((val_4 + 3)) << 1)) << 2) + 16, z = (R1 + (((val_4 + 3) + ((val_4 + 3)) << 1)) << 2) + 20});
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.815376E-37f}, d:  val_37.x);
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815374E-37f}, b:  new UnityEngine.Vector3() {y = val_40, z = val_39});
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = -1.815373E-37f, y = (R1 + ((val_4 + (val_4) << 1)) << 2) + 16, z = (R1 + ((val_4 + (val_4) << 1)) << 2) + 20});
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815372E-37f}, b:  new UnityEngine.Vector3() {y = (R1 + (((val_4 + 2) + ((val_4 + 2)) << 1)) << 2) + 16, z = (R1 + (((val_4 + 2) + ((val_4 + 2)) << 1)) << 2) + 20});
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.81537E-37f}, d:  val_44.x);
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815369E-37f}, b:  new UnityEngine.Vector3() {y = val_47, z = val_46});
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Multiply(d:  val_49.x, a:  new UnityEngine.Vector3() {x = -1.815368E-37f, y = 2f, z = mem[((R1 + (((val_4 + 1) + ((val_4 + 1)) << 1)) << 2) + 16) + (0)]});
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.815366E-37f}, b:  new UnityEngine.Vector3() {y = val_52, z = val_51});
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Multiply(d:  val_54.x, a:  new UnityEngine.Vector3() {x = pts, y = 0.5f, z = val_56});
        return new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z};
    }
    public iTween()
    {
    
    }

}
