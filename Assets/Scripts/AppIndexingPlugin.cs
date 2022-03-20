using UnityEngine;
public class AppIndexingPlugin : MonoBehaviour
{
    // Fields
    private static UnityEngine.AndroidJavaObject mPlugin;
    
    // Properties
    private static UnityEngine.AndroidJavaObject plugin { get; }
    
    // Methods
    public static void LogStartSession()
    {
        AppConfigs val_1 = App.Configuration;
        string val_2 = -1874707456(-1874707456) + .__il2cppRuntimeField_C;
        AppConfigs val_3 = App.Configuration;
        AppConfigs val_4 = App.Configuration;
        string val_5 = System.String.Format(format:  -1874707376, arg0:  "Play ".__il2cppRuntimeField_C + 60, arg1:  "Play ".__il2cppRuntimeField_C + 64);
        AppConfigs val_6 = App.Configuration;
        AppIndexingPlugin.AndroidIndexAndLogAction(name:  -1874707456, url:  -1874707376, description:  "https://{0}.{1}".__il2cppRuntimeField_14 + 64);
    }
    public static void IndexAndLogAction(string name, string url, string description)
    {
        AppIndexingPlugin.AndroidIndexAndLogAction(name:  name, url:  url, description:  description);
    }
    public static void LogAction(string name, string url)
    {
        AppIndexingPlugin.AndroidLogAction(name:  name, url:  url);
    }
    private static void AndroidIndexAndLogAction(string name, string url, string description)
    {
        bool val_3 = static_value_021FB365;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        UnityEngine.AndroidJavaObject val_1 = AppIndexingPlugin.plugin;
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.AndroidJavaObject val_2 = AppIndexingPlugin.plugin;
        typeof(System.Object[]).__il2cppRuntimeField_10 = name;
        typeof(System.Object[]).__il2cppRuntimeField_14 = url;
        typeof(System.Object[]).__il2cppRuntimeField_18 = description;
        val_3.Call(methodName:  -1874318016, args:  472754880);
    }
    private static void AndroidLogAction(string name, string url)
    {
        bool val_3 = static_value_021FB366;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        UnityEngine.AndroidJavaObject val_1 = AppIndexingPlugin.plugin;
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.AndroidJavaObject val_2 = AppIndexingPlugin.plugin;
        typeof(System.Object[]).__il2cppRuntimeField_10 = name;
        typeof(System.Object[]).__il2cppRuntimeField_14 = url;
        val_3.Call(methodName:  -1874185424, args:  472754880);
    }
    private static UnityEngine.AndroidJavaObject get_plugin()
    {
        var val_3;
        if(AppIndexingPlugin.mPlugin != 0)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1874065136);
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        AppIndexingPlugin.mPlugin = null;
    }
    public AppIndexingPlugin()
    {
    
    }

}
