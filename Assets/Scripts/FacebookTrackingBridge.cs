using UnityEngine;
public static class FacebookTrackingBridge
{
    // Methods
    public static void TrackEvent(string eventName)
    {
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        FacebookTrackingBridge.SendRequest(externalMethodName:  287539200, eventName:  eventName, jsonData:  null);
    }
    private static void SendRequest(string externalMethodName, string eventName, string jsonData)
    {
        var val_2;
        string val_1 = System.String.Format(format:  -1916629344, arg0:  externalMethodName);
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
        
        UnityEngine.Application.ExternalCall(functionName:  -1916629344, args:  472754880);
    }

}
