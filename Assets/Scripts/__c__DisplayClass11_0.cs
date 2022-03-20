using UnityEngine;
private sealed class AdViewBridgeAndroid.<>c__DisplayClass11_0
{
    // Fields
    public UnityEngine.AndroidJavaObject activity;
    public double width;
    public double height;
    public UnityEngine.AndroidJavaObject adView;
    public double x;
    public double y;
    
    // Methods
    public AdViewBridgeAndroid.<>c__DisplayClass11_0()
    {
    
    }
    internal void <Show>b__0()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_14 == 1)
        {
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_1 = this.activity.Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_15 == 1)
        {
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = this.activity.Call<UnityEngine.AndroidJavaObject>(methodName:  1300018448, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_16 == 1)
        {
                val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = this.activity.Call<UnityEngine.AndroidJavaObject>(methodName:  1300018544, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        float val_4 = this.activity.Get<System.Single>(fieldName:  1300019680);
        val_17 = 1152921505079601856;
        double val_14 = this.width;
        val_14 = val_14 * D8;
        if(this.activity == 0)
        {
                val_14 = D17;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        double val_15 = this.height;
        val_15 = val_15 * D8;
        if(System.Object[].__il2cppRuntimeField_namespaze == 0)
        {
                val_15 = D17;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        UnityEngine.AndroidJavaObject val_5 = new UnityEngine.AndroidJavaObject(className:  1300019776, args:  472754880);
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.activity;
        UnityEngine.AndroidJavaClass val_7 = new UnityEngine.AndroidJavaClass(className:  1300024160);
        int val_8 = GetStatic<System.Int32>(fieldName:  1300029376);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        UnityEngine.AndroidJavaObject val_9 = this.activity.Call<UnityEngine.AndroidJavaObject>(methodName:  1300029472, args:  472754880);
        val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_18 == 1)
        {
                val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_10 = this.adView.Call<UnityEngine.AndroidJavaObject>(methodName:  1300033664, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_19 = 1152921504619999232;
        if(this.adView != 0)
        {
                bool val_13 = System.IntPtr.op_Inequality(value1:  UnityEngine.AndroidJNI.GetMethodID(clazz:  this.adView.GetRawClass(), name:  1300033760, sig:  1300033856), value2:  new IntPtr(0));
            if(val_13 != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = this.adView;
            this.adView.Call(methodName:  1300033760, args:  472754880);
            val_17 = 1152921505079601856;
            val_19 = 1152921504619999232;
        }
        else
        {
                UnityEngine.AndroidJNI.ExceptionClear();
            val_17 = 1152921505079601856;
        }
        
        }
        
        double val_16 = this.x;
        val_16 = val_16 * D8;
        if(val_13 == false)
        {
                val_16 = D17;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_19;
        double val_17 = this.y;
        val_17 = val_17 * D8;
        if(System.Object[].__il2cppRuntimeField_namespaze == 0)
        {
                val_17 = D17;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        Call(methodName:  1300038064, args:  472754880);
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.adView;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        Call(methodName:  1300042256, args:  472754880);
        typeof(System.Object[]).__il2cppRuntimeField_10 = new UnityEngine.AndroidJavaObject(className:  1300024032, args:  472754880);
        this.activity.Call(methodName:  1300042256, args:  472754880);
    }

}
