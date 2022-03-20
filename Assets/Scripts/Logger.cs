using UnityEngine;
public class Logger
{
    // Fields
    public static bool Leagues;
    public static bool GameEvents;
    public static bool Machines;
    public static bool Profile;
    public static bool Store;
    public static bool EncodableModel;
    private static bool Enabled;
    
    // Methods
    public static void Init()
    {
    
    }
    public static void Setup(bool val)
    {
        null = null;
        Logger.Enabled = val;
    }
    public static void Exception(System.Exception ex)
    {
        null = null;
        if(Logger.Enabled == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogException(exception:  ex);
    }
    public static void Warn(object message)
    {
        null = null;
        if(Logger.Enabled == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  message);
    }
    public static void Log(object message)
    {
        null = null;
        if(Logger.Enabled == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  message);
    }
    public Logger()
    {
    
    }
    private static Logger()
    {
        Logger.Enabled = true;
    }

}
