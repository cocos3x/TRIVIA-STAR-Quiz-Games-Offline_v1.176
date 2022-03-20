using UnityEngine;
public class MonoSingletonSelfGenerating<T> : MonoBehaviour
{
    // Fields
    protected static T _Instance;
    
    // Properties
    public static T Instance { get; }
    public static bool InstanceExists { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_10 == 1)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                val_11 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_11 = __RuntimeMethodHiddenParam + 12 + 186;
            val_12 = __RuntimeMethodHiddenParam + 12;
            if(val_11 == 1)
        {
                val_12 = mem[__RuntimeMethodHiddenParam + 12];
            val_12 = __RuntimeMethodHiddenParam + 12;
            val_11 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_11 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
            val_13 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12];
            val_13 = __RuntimeMethodHiddenParam + 12 + 96 + 8 + 12;
            if(val_13 >= 2)
        {
                var val_2 = (__RuntimeMethodHiddenParam + 12 + 96 + 8) + 16;
            var val_10 = 0;
            do
        {
            if(((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0) == 0)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = System.String.alignConst;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "\n instances[";
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_1C = "] is null";
            string val_4 = +472754880;
            val_14 = null;
        }
        else
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = System.String.alignConst;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "\n instances[";
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_1C = "] = ";
            string val_5 = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0.name;
            typeof(System.Object[]).__il2cppRuntimeField_20 = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0;
            string val_6 = +472754880;
            val_14 = null;
            val_15 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_15 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_15 == 1)
        {
                val_15 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_15 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0;
        }
        
            val_10 = val_10 + 1;
        }
        while(val_10 < (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12));
        
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 12});
            typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 12 + 96 + 12;
            typeof(System.Object[]).__il2cppRuntimeField_14 = " found: ";
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_1C = " (more details below)";
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_14;
            string val_8 = +472754880;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_16 == 1)
        {
                val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            D.LogClientError(developer:  472754880, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_13 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12];
            val_13 = __RuntimeMethodHiddenParam + 12 + 96 + 8 + 12;
        }
        
            if(val_13 == 1)
        {
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) == 0)
        {
                val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_17 == 1)
        {
                val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            D.LogClientError(developer:  -1826387744, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        
        }
        
        }
    
    }
    public static bool get_InstanceExists()
    {
        var val_3;
        var val_4;
        val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                return false;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        UnityEngine.GameObject val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 92.gameObject;
        return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
    }
    public MonoSingletonSelfGenerating<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    private static MonoSingletonSelfGenerating<T>()
    {
    
    }

}
