using UnityEngine;
private class AdjustAndroid.AttributionChangeListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustAttribution> callback;
    
    // Methods
    public AdjustAndroid.AttributionChangeListener(System.Action<com.adjust.sdk.AdjustAttribution> pCallback)
    {
        this.callback = pCallback;
    }
    public void onAttributionChanged(UnityEngine.AndroidJavaObject attribution)
    {
        AdjustAndroid.AttributionChangeListener val_36;
        var val_37;
        UnityEngine.AndroidJavaObject val_38;
        var val_39;
        var val_40;
        UnityEngine.AndroidJavaObject val_41;
        var val_42;
        var val_43;
        UnityEngine.AndroidJavaObject val_44;
        var val_45;
        var val_46;
        UnityEngine.AndroidJavaObject val_47;
        var val_48;
        var val_49;
        UnityEngine.AndroidJavaObject val_50;
        var val_51;
        var val_52;
        UnityEngine.AndroidJavaObject val_53;
        var val_54;
        var val_55;
        UnityEngine.AndroidJavaObject val_56;
        var val_57;
        var val_58;
        UnityEngine.AndroidJavaObject val_59;
        var val_60;
        var val_61;
        UnityEngine.AndroidJavaObject val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        UnityEngine.AndroidJavaObject val_68;
        var val_69;
        val_36 = this;
        if(this.callback == 0)
        {
                return;
        }
        
        object val_1 = new System.Object();
        val_37 = null;
        val_37 = null;
        object val_2 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
        val_38 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_39 = null;
            val_39 = null;
            object val_4 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            val_38 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_20 = val_38;
        val_40 = null;
        val_40 = null;
        object val_5 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
        val_41 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_42 = null;
            val_42 = null;
            object val_7 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            val_41 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_24 = val_41;
        val_43 = null;
        val_43 = null;
        object val_8 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
        val_44 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_45 = null;
            val_45 = null;
            object val_10 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            val_44 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_C = val_44;
        val_46 = null;
        val_46 = null;
        object val_11 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
        val_47 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_48 = null;
            val_48 = null;
            object val_13 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            val_47 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_14 = val_47;
        val_49 = null;
        val_49 = null;
        object val_14 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
        val_50 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_51 = null;
            val_51 = null;
            object val_16 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            val_50 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_10 = val_50;
        val_52 = null;
        val_52 = null;
        object val_17 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
        val_53 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_54 = null;
            val_54 = null;
            object val_19 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
            val_53 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_18 = val_53;
        val_55 = null;
        val_55 = null;
        object val_20 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
        val_56 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_57 = null;
            val_57 = null;
            object val_22 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            val_56 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_1C = val_56;
        val_58 = null;
        val_58 = null;
        object val_23 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        val_59 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_60 = null;
            val_60 = null;
            object val_25 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_59 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_8 = val_59;
        val_61 = null;
        val_61 = null;
        object val_26 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
        val_62 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_63 = null;
            val_63 = null;
            object val_28 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
            val_62 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_28 = val_62;
        val_64 = null;
        val_64 = null;
        object val_29 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
        if(attribution == 0)
        {
            goto label_73;
        }
        
        val_65 = null;
        val_65 = null;
        object val_30 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
        if(attribution == 0)
        {
            goto label_73;
        }
        
        val_66 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_66 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_66 == 1)
        {
                val_66 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_66 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Nullable<System.Double> val_32 = new System.Nullable<System.Double>(value:  attribution.Call<System.Double>(methodName:  1361250848, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92));
        val_36 = val_36;
        goto label_80;
        label_73:
        label_80:
        val_67 = null;
        val_67 = null;
        object val_33 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
        val_68 = 0;
        if((System.String.op_Equality(a:  attribution, b:  1098586544)) != true)
        {
                val_69 = null;
            val_69 = null;
            object val_35 = attribution.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
            val_68 = attribution;
        }
        
        typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_40 = val_68;
        this.callback.Invoke(obj:  470978560);
    }

}
