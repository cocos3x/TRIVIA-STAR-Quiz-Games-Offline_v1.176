using UnityEngine;
public class LoadingDialogPlugin
{
    // Fields
    private static UnityEngine.AndroidJavaObject mPlugin;
    
    // Properties
    private static UnityEngine.AndroidJavaObject plugin { get; }
    
    // Methods
    private static UnityEngine.AndroidJavaObject get_plugin()
    {
        var val_3;
        if(LoadingDialogPlugin.mPlugin != 0)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1846151488);
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        LoadingDialogPlugin.mPlugin = null;
    }
    public static void RemoveView()
    {
        var val_3;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaObject val_2 = LoadingDialogPlugin.plugin;
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        0.Call(methodName:  -1846039328, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public LoadingDialogPlugin()
    {
    
    }

}
