using UnityEngine;
public static class WGResources
{
    // Fields
    private static string cachedGameResourcesPath;
    
    // Properties
    public static string gameResourcesPath { get; }
    public static string genericResourcesPath { get; }
    
    // Methods
    public static T Load<T>(string fileName, string extension = ".prefab", bool errorLog = True)
    {
        var val_8;
        string val_1 = WGResources.gameResourcesPath;
        string val_2 = null + fileName;
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  null, systemTypeInstance:  __RuntimeMethodHiddenParam + 24);
        val_8 = 0;
        if(0 != 0)
        {
                val_8 = 0;
            if(0 == 0)
        {
                val_8 = 0;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
        {
                return;
        }
        
        string val_7 = -683354000(-683354000) + null;
        UnityEngine.Debug.LogWarning(message:  -683354000);
    }
    public static T[] LoadAll<T>(string path, string extension = ".prefab")
    {
        string val_1 = WGResources.gameResourcesPath;
        string val_2 = null + path;
        goto __RuntimeMethodHiddenParam + 24;
    }
    public static string get_gameResourcesPath()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 != 0)
        {
                return -1655690384(-1655690384) + 2621443 + 1115175264;
        }
        
        return -1655690384(-1655690384) + 2621443 + 1115175264;
    }
    public static void ClearCachedGameResourcesPath()
    {
        null = null;
        WGResources.cachedGameResourcesPath = 0;
    }
    public static string get_genericResourcesPath()
    {
    
    }
    private static WGResources()
    {
    
    }

}
