using UnityEngine;
public static class SRDebug
{
    // Fields
    public const string Version = "1.6.0";
    
    // Properties
    public static SRDebugger.Services.IDebugService Instance { get; }
    
    // Methods
    public static SRDebugger.Services.IDebugService get_Instance()
    {
        return SRF.Service.SRServiceManager.GetService<System.Object>();
    }
    public static void Init()
    {
        if((SRF.Service.SRServiceManager.HasService<System.Object>()) != true)
        {
                SRDebugger.Services.Implementation.StandardConsoleService val_2 = new SRDebugger.Services.Implementation.StandardConsoleService();
        }
        
        object val_3 = SRF.Service.SRServiceManager.GetService<System.Object>();
    }

}
