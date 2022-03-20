using UnityEngine;
public static class AmplitudeBridge
{
    // Methods
    public static void TrackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> eventParams)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  eventParams);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        AmplitudeBridge.SendRequest(externalMethodName:  287059968, eventName:  eventName, jsonData:  eventParams);
    }
    public static void LogRevenue(System.Collections.Generic.Dictionary<string, object> eventParams)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  eventParams);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        AmplitudeBridge.SendRequest(externalMethodName:  287059968, eventName:  null, jsonData:  eventParams);
    }
    public static void SetSuperProperties(System.Collections.Generic.Dictionary<string, object> eventParams)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  eventParams);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        AmplitudeBridge.SendRequest(externalMethodName:  287059968, eventName:  null, jsonData:  eventParams);
    }
    private static void SendRequest(string externalMethodName, string eventName, string jsonData)
    {
        var val_2;
        string val_1 = System.String.Format(format:  -1923060832, arg0:  externalMethodName);
        if(eventName != null)
        {
                val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = eventName;
            typeof(System.Object[]).__il2cppRuntimeField_14 = jsonData;
        }
        else
        {
                val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = jsonData;
        }
        
        UnityEngine.Application.ExternalCall(functionName:  -1923060832, args:  472754880);
    }

}
