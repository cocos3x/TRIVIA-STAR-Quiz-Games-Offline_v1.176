using UnityEngine;
[Serializable]
public class HelpshiftConfig : ScriptableObject
{
    // Fields
    private static HelpshiftConfig instance;
    private const string helpshiftConfigAssetName = "HelpshiftConfig";
    private const string helpshiftConfigPath = "Helpshift/Resources";
    public const string pluginVersion = "5.5.1";
    
    // Properties
    public static HelpshiftConfig Instance { get; }
    
    // Methods
    public static HelpshiftConfig get_Instance()
    {
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  -672275152);
        if("HelpshiftConfig" != 0)
        {
                if(null != null)
        {
                "HelpshiftConfig" = 0;
        }
        
            0 = "HelpshiftConfig";
        }
        
        HelpshiftConfig.pluginVersion = 0;
        if(0 != 0)
        {
                return;
        }
        
        UnityEngine.Networking.PlayerConnection.PlayerConnection val_3 = UnityEngine.ScriptableObject.CreateInstance<UnityEngine.Networking.PlayerConnection.PlayerConnection>();
        HelpshiftConfig.pluginVersion = public static HelpshiftConfig UnityEngine.ScriptableObject::CreateInstance<HelpshiftConfig>();
    }
    public HelpshiftConfig()
    {
    
    }

}
