using UnityEngine;
private class AdjustAndroid.DeferredDeeplinkListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> callback;
    
    // Methods
    public AdjustAndroid.DeferredDeeplinkListener(System.Action<string> pCallback)
    {
        this.callback = pCallback;
    }
    public bool launchReceivedDeeplink(UnityEngine.AndroidJavaObject deeplink)
    {
        System.Object[] val_2;
        var val_3;
        val_2 = 35639539;
        if(this.callback == 0)
        {
                return (bool)com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink;
        }
        
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92;
        UnityEngine.AndroidJavaObject val_1 = deeplink.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  val_2);
        this.callback.Invoke(obj:  deeplink);
        return (bool)com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink;
    }

}
