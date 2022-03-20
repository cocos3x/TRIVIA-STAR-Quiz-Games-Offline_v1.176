using UnityEngine;
private class AdjustAndroid.EventTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventFailure> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingFailedListener(System.Action<com.adjust.sdk.AdjustEventFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingFailed(UnityEngine.AndroidJavaObject eventFailureData)
    {
        UnityEngine.AndroidJavaObject val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.AndroidJavaObject val_24;
        var val_25;
        var val_26;
        UnityEngine.AndroidJavaObject val_27;
        var val_28;
        var val_29;
        UnityEngine.AndroidJavaObject val_30;
        var val_31;
        var val_32;
        UnityEngine.AndroidJavaObject val_33;
        var val_34;
        var val_35;
        var val_36;
        if(eventFailureData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_20 = 0;
        null = new System.Object();
        val_21 = null;
        val_21 = null;
        object val_2 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        if((System.String.op_Equality(a:  eventFailureData, b:  1098586544)) != true)
        {
                val_22 = null;
            val_22 = null;
            object val_4 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_20 = eventFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_8 = val_20;
        val_23 = null;
        val_23 = null;
        object val_5 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_24 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  1098586544)) != true)
        {
                val_25 = null;
            val_25 = null;
            object val_7 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
            val_24 = eventFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_C = val_24;
        val_26 = null;
        val_26 = null;
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_1C = eventFailureData.Get<System.Boolean>(fieldName:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
        object val_9 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_27 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  1098586544)) != true)
        {
                val_28 = null;
            val_28 = null;
            object val_11 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            val_27 = eventFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_10 = val_27;
        val_29 = null;
        val_29 = null;
        object val_12 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
        val_30 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  1098586544)) != true)
        {
                val_31 = null;
            val_31 = null;
            object val_14 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            val_30 = eventFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_14 = val_30;
        val_32 = null;
        val_32 = null;
        object val_15 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
        val_33 = 0;
        if((System.String.op_Equality(a:  eventFailureData, b:  1098586544)) != true)
        {
                val_34 = null;
            val_34 = null;
            object val_17 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            val_33 = eventFailureData;
        }
        
        typeof(com.adjust.sdk.AdjustEventFailure).__il2cppRuntimeField_18 = val_33;
        val_35 = null;
        val_35 = null;
        object val_18 = eventFailureData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
        val_36 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_36 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_36 == 1)
        {
                val_36 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_36 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_19 = eventFailureData.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        BuildJsonResponseFromString(jsonResponseString:  eventFailureData);
        this.callback.Invoke(obj:  471244800);
    }

}
