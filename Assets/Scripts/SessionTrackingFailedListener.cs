using UnityEngine;
private class AdjustAndroid.SessionTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionFailure> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingFailedListener(System.Action<com.adjust.sdk.AdjustSessionFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingFailed(UnityEngine.AndroidJavaObject sessionFailureData)
    {
        UnityEngine.AndroidJavaObject val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.AndroidJavaObject val_18;
        var val_19;
        var val_20;
        UnityEngine.AndroidJavaObject val_21;
        var val_22;
        var val_23;
        var val_24;
        if(sessionFailureData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_14 = 0;
        null = new System.Object();
        val_15 = null;
        val_15 = null;
        object val_2 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        if((System.String.op_Equality(a:  sessionFailureData, b:  1098586544)) != true)
        {
                val_16 = null;
            val_16 = null;
            object val_4 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_14 = sessionFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionFailure).__il2cppRuntimeField_8 = val_14;
        val_17 = null;
        val_17 = null;
        object val_5 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_18 = 0;
        if((System.String.op_Equality(a:  sessionFailureData, b:  1098586544)) != true)
        {
                val_19 = null;
            val_19 = null;
            object val_7 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
            val_18 = sessionFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionFailure).__il2cppRuntimeField_C = val_18;
        val_20 = null;
        val_20 = null;
        typeof(com.adjust.sdk.AdjustSessionFailure).__il2cppRuntimeField_14 = sessionFailureData.Get<System.Boolean>(fieldName:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
        object val_9 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_21 = 0;
        if((System.String.op_Equality(a:  sessionFailureData, b:  1098586544)) != true)
        {
                val_22 = null;
            val_22 = null;
            object val_11 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            val_21 = sessionFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustSessionFailure).__il2cppRuntimeField_10 = val_21;
        val_23 = null;
        val_23 = null;
        object val_12 = sessionFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
        val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_24 == 1)
        {
                val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_13 = sessionFailureData.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        BuildJsonResponseFromString(jsonResponseString:  sessionFailureData);
        this.callback.Invoke(obj:  471511040);
    }

}
