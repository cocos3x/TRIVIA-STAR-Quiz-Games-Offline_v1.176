using UnityEngine;
private class AdjustAndroid.SessionTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionSuccess> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustSessionSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingSucceeded(UnityEngine.AndroidJavaObject sessionSuccessData)
    {
        UnityEngine.AndroidJavaObject val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.AndroidJavaObject val_17;
        var val_18;
        var val_19;
        UnityEngine.AndroidJavaObject val_20;
        var val_21;
        var val_22;
        var val_23;
        if(sessionSuccessData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_13 = 0;
        null = new System.Object();
        val_14 = null;
        val_14 = null;
        object val_2 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        if((System.String.op_Equality(a:  sessionSuccessData, b:  1098586544)) != true)
        {
                val_15 = null;
            val_15 = null;
            object val_4 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_13 = sessionSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionSuccess).__il2cppRuntimeField_8 = val_13;
        val_16 = null;
        val_16 = null;
        object val_5 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_17 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData, b:  1098586544)) != true)
        {
                val_18 = null;
            val_18 = null;
            object val_7 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
            val_17 = sessionSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionSuccess).__il2cppRuntimeField_C = val_17;
        val_19 = null;
        val_19 = null;
        object val_8 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_20 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData, b:  1098586544)) != true)
        {
                val_21 = null;
            val_21 = null;
            object val_10 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            val_20 = sessionSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionSuccess).__il2cppRuntimeField_10 = val_20;
        val_22 = null;
        val_22 = null;
        object val_11 = sessionSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
        val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_23 == 1)
        {
                val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_12 = sessionSuccessData.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        BuildJsonResponseFromString(jsonResponseString:  sessionSuccessData);
        this.callback.Invoke(obj:  471564288);
    }

}
