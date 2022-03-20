using UnityEngine;
private class AdjustAndroid.EventTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventSuccess> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustEventSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingSucceeded(UnityEngine.AndroidJavaObject eventSuccessData)
    {
        UnityEngine.AndroidJavaObject val_19;
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.AndroidJavaObject val_23;
        var val_24;
        var val_25;
        UnityEngine.AndroidJavaObject val_26;
        var val_27;
        var val_28;
        UnityEngine.AndroidJavaObject val_29;
        var val_30;
        var val_31;
        UnityEngine.AndroidJavaObject val_32;
        var val_33;
        var val_34;
        var val_35;
        if(eventSuccessData != 0)
        {
                true = this.callback;
        }
        
        if(true == 0)
        {
                return;
        }
        
        val_19 = 0;
        null = new System.Object();
        val_20 = null;
        val_20 = null;
        object val_2 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        if((System.String.op_Equality(a:  eventSuccessData, b:  1098586544)) != true)
        {
                val_21 = null;
            val_21 = null;
            object val_4 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_19 = eventSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustEventSuccess).__il2cppRuntimeField_8 = val_19;
        val_22 = null;
        val_22 = null;
        object val_5 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_23 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  1098586544)) != true)
        {
                val_24 = null;
            val_24 = null;
            object val_7 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
            val_23 = eventSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustEventSuccess).__il2cppRuntimeField_C = val_23;
        val_25 = null;
        val_25 = null;
        object val_8 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_26 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  1098586544)) != true)
        {
                val_27 = null;
            val_27 = null;
            object val_10 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            val_26 = eventSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustEventSuccess).__il2cppRuntimeField_10 = val_26;
        val_28 = null;
        val_28 = null;
        object val_11 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
        val_29 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  1098586544)) != true)
        {
                val_30 = null;
            val_30 = null;
            object val_13 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            val_29 = eventSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustEventSuccess).__il2cppRuntimeField_14 = val_29;
        val_31 = null;
        val_31 = null;
        object val_14 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
        val_32 = 0;
        if((System.String.op_Equality(a:  eventSuccessData, b:  1098586544)) != true)
        {
                val_33 = null;
            val_33 = null;
            object val_16 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            val_32 = eventSuccessData;
        }
        
        typeof(com.adjust.sdk.AdjustEventSuccess).__il2cppRuntimeField_18 = val_32;
        val_34 = null;
        val_34 = null;
        object val_17 = eventSuccessData.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
        val_35 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_35 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_35 == 1)
        {
                val_35 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_35 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_18 = eventSuccessData.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        BuildJsonResponseFromString(jsonResponseString:  eventSuccessData);
        this.callback.Invoke(obj:  471298048);
    }

}
