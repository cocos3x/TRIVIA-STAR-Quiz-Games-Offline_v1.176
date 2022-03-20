using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAndroid
    {
        // Fields
        private const string sdkPrefix = "unity4.28.0";
        private static bool launchDeferredDeeplink;
        private static UnityEngine.AndroidJavaClass ajcAdjust;
        private static UnityEngine.AndroidJavaObject ajoCurrentActivity;
        private static com.adjust.sdk.AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
        private static com.adjust.sdk.AdjustAndroid.AttributionChangeListener onAttributionChangedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
        
        // Methods
        public static void Start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            float val_20;
            var val_21;
            if(adjustConfig != 0)
            {
                    if(adjustConfig.environment == 1)
            {
                    "sandbox" = "production";
            }
            
            }
            else
            {
                    if(2 == 1)
            {
                    "sandbox" = "production";
            }
            
            }
            
            val_20 = 1152921505079601856;
            if("production" != 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                typeof(System.Object[]).__il2cppRuntimeField_14 = adjustConfig.appToken;
                typeof(System.Object[]).__il2cppRuntimeField_18 = "production";
                typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            }
            else
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                typeof(System.Object[]).__il2cppRuntimeField_14 = adjustConfig.appToken;
                typeof(System.Object[]).__il2cppRuntimeField_18 = "production";
            }
            
            UnityEngine.AndroidJavaObject val_1 = new UnityEngine.AndroidJavaObject(className:  1359893616, args:  472754880);
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = adjustConfig.launchDeferredDeeplink;
            com.adjust.sdk.AdjustLogLevel val_2 = adjustConfig.logLevel.Value;
            string val_3 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
            UnityEngine.AndroidJavaClass val_5 = new UnityEngine.AndroidJavaClass(className:  1359894864);
            if((adjustConfig.logLevel.Equals(value:  1359894768)) != false)
            {
                    object val_6 = GetStatic<System.Object>(fieldName:  1359894992);
                val_21 = null;
            }
            else
            {
                    com.adjust.sdk.AdjustLogLevel val_7 = adjustConfig.logLevel.Value;
                string val_8 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
                object val_9 = GetStatic<System.Object>(fieldName:  adjustConfig.logLevel);
                val_21 = null;
            }
            
            val_20 = 1152921505079601856;
            if(val_21 != 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = val_21;
                Call(methodName:  1359895088, args:  472754880);
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = "unity4.28.0";
            Call(methodName:  1359895280, args:  472754880);
            if(null != 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1359895376, args:  472754880);
            }
            
            if(null != 0)
            {
                    bool val_10 = adjustConfig.eventBufferingEnabled.Value;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                UnityEngine.AndroidJavaObject val_11 = new UnityEngine.AndroidJavaObject(className:  1359895472, args:  472754880);
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1359895584, args:  472754880);
            }
            
            if(null != 0)
            {
                    bool val_12 = adjustConfig.sendInBackground.Value;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1359895712, args:  472754880);
            }
            
            if(null != 0)
            {
                    bool val_13 = adjustConfig.needsCost.Value;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1359895824, args:  472754880);
            }
            
            if(null != 0)
            {
                    bool val_14 = adjustConfig.preinstallTrackingEnabled.Value;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1359895920, args:  472754880);
            }
            
            if(adjustConfig.userAgent != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = adjustConfig.userAgent;
                Call(methodName:  1359904240, args:  472754880);
            }
            
            if((System.String.IsNullOrEmpty(value:  adjustConfig.processName)) != true)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = adjustConfig.processName;
                Call(methodName:  1359912528, args:  472754880);
            }
            
            if(adjustConfig.defaultTracker != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = adjustConfig.defaultTracker;
                Call(methodName:  1359920816, args:  472754880);
            }
            
            if(adjustConfig.externalDeviceId != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = adjustConfig.externalDeviceId;
                Call(methodName:  1359929120, args:  472754880);
            }
            
            if(adjustConfig.urlStrategy == null)
            {
                goto label_108;
            }
            
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  1359933328)) == false)
            {
                goto label_109;
            }
            
            UnityEngine.AndroidJavaClass val_17 = new UnityEngine.AndroidJavaClass(className:  1359893616);
            if(null != 0)
            {
                goto label_114;
            }
            
            goto label_114;
            label_109:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  1359933520)) != false)
            {
                    UnityEngine.AndroidJavaClass val_19 = new UnityEngine.AndroidJavaClass(className:  1359893616);
                if(null != 0)
            {
                goto label_114;
            }
            
            }
        
        }
        public static void TrackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            string val_3;
            System.Collections.Generic.List<System.String> val_4;
            float val_5;
            System.Collections.Generic.List<System.String> val_7;
            var val_8;
            val_3 = adjustEvent.eventToken;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
            if((new UnityEngine.AndroidJavaObject(className:  1360115344, args:  472754880)) != 0)
            {
                    val_3 = null;
                double val_2 = adjustEvent.revenue.Value;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                typeof(System.Object[]).__il2cppRuntimeField_14 = adjustEvent.currency;
                Call(methodName:  1360119568, args:  472754880);
            }
            
            val_4 = adjustEvent.callbackList;
            if(val_4 == 0)
            {
                goto label_15;
            }
            
            val_3 = 0;
            goto label_16;
            label_30:
            if(null <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            val_5 = 1;
            if(val_3 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = (0 + 0) + 16;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "setRevenue".__il2cppRuntimeField_14;
            Call(methodName:  1360123760, args:  472754880);
            val_4 = adjustEvent.callbackList;
            val_3 = val_5 + 1;
            label_16:
            if(val_3 < null)
            {
                goto label_30;
            }
            
            label_15:
            val_7 = adjustEvent.partnerList;
            if(val_7 == 0)
            {
                goto label_31;
            }
            
            val_3 = 0;
            val_5 = "addPartnerParameter";
            goto label_32;
            label_46:
            if(null <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(val_4 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = (0 + 0) + 16;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "addCallbackParameter".__il2cppRuntimeField_14;
            Call(methodName:  1360140256, args:  472754880);
            val_7 = adjustEvent.partnerList;
            val_3 = 1 + 1;
            label_32:
            if(val_3 < null)
            {
                goto label_46;
            }
            
            label_31:
            if(adjustEvent.transactionId != null)
            {
                    val_3 = adjustEvent.transactionId;
                typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
                Call(methodName:  1360160848, args:  472754880);
            }
            
            if(adjustEvent.callbackId != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = adjustEvent.callbackId;
                Call(methodName:  1360169136, args:  472754880);
            }
            
            val_8 = null;
            val_8 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1699742640, args:  472754880);
        }
        public static bool IsEnabled()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.Boolean>(methodName:  1360342672, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.Boolean>(methodName:  1360342672, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void SetEnabled(bool enabled)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1360454768, args:  472754880);
        }
        public static void SetOfflineMode(bool enabled)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1360566864, args:  472754880);
        }
        public static void SendFirstPackages()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1360678960, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void SetDeviceToken(string deviceToken)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = deviceToken;
            typeof(System.Object[]).__il2cppRuntimeField_14 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1360795168, args:  472754880);
        }
        public static string GetAdid()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1360911360, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1360911360, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void GdprForgetMe()
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1361023456, args:  472754880);
        }
        public static void DisableThirdPartySharing()
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1361135552, args:  472754880);
        }
        public static com.adjust.sdk.AdjustAttribution GetAttribution()
        {
            var val_37;
            float val_38;
            UnityEngine.AndroidJavaClass val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            UnityEngine.AndroidJavaClass val_44;
            var val_45;
            var val_46;
            UnityEngine.AndroidJavaClass val_47;
            var val_48;
            var val_49;
            UnityEngine.AndroidJavaClass val_50;
            var val_51;
            var val_52;
            UnityEngine.AndroidJavaClass val_53;
            var val_54;
            var val_55;
            UnityEngine.AndroidJavaClass val_56;
            var val_57;
            var val_58;
            UnityEngine.AndroidJavaClass val_59;
            var val_60;
            var val_61;
            UnityEngine.AndroidJavaClass val_62;
            var val_63;
            var val_64;
            UnityEngine.AndroidJavaClass val_65;
            var val_66;
            var val_67;
            UnityEngine.AndroidJavaClass val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            val_37 = null;
            val_37 = null;
            val_38 = 1152921510190316432;
            val_39 = public static T[] System.Array::Empty<System.Object>();
            val_40 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_40 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_40 == 1)
            {
                    val_40 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_40 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1361247680, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                goto label_10;
            }
            
            com.adjust.sdk.AdjustAttribution val_2 = null;
            val_41 = val_2;
            val_2 = new com.adjust.sdk.AdjustAttribution();
            val_42 = null;
            val_42 = null;
            object val_3 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            val_43 = "";
            val_44 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_45 = null;
                val_45 = null;
                object val_5 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
                val_44 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_20 = val_44;
            val_46 = null;
            val_46 = null;
            object val_6 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            val_47 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_48 = null;
                val_48 = null;
                object val_8 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
                val_47 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_24 = val_47;
            val_49 = null;
            val_49 = null;
            object val_9 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            val_50 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_51 = null;
                val_51 = null;
                object val_11 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
                val_50 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_C = val_50;
            val_52 = null;
            val_52 = null;
            object val_12 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            val_53 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_54 = null;
                val_54 = null;
                object val_14 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
                val_53 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_14 = val_53;
            val_55 = null;
            val_55 = null;
            object val_15 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            val_56 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_57 = null;
                val_57 = null;
                object val_17 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
                val_56 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_10 = val_56;
            val_58 = null;
            val_58 = null;
            object val_18 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
            val_59 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_60 = null;
                val_60 = null;
                object val_20 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
                val_59 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_18 = val_59;
            val_61 = null;
            val_61 = null;
            object val_21 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            val_62 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_63 = null;
                val_63 = null;
                object val_23 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
                val_62 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_1C = val_62;
            val_64 = null;
            val_64 = null;
            object val_24 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_65 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_66 = null;
                val_66 = null;
                object val_26 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
                val_65 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_8 = val_65;
            val_67 = null;
            val_67 = null;
            object val_27 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
            val_68 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_69 = null;
                val_69 = null;
                object val_29 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
                val_68 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_28 = val_68;
            val_70 = null;
            val_70 = null;
            object val_30 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                goto label_62;
            }
            
            val_71 = null;
            val_71 = null;
            object val_31 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                goto label_62;
            }
            
            val_38 = public static T[] System.Array::Empty<System.Object>();
            val_72 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_72 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_72 == 1)
            {
                    val_72 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_72 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            System.Nullable<System.Double> val_33 = new System.Nullable<System.Double>(value:  com.adjust.sdk.AdjustAndroid.ajcAdjust.Call<System.Double>(methodName:  1361250848, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92));
            val_43 = "";
            goto label_69;
            label_62:
            label_69:
            val_73 = null;
            val_73 = null;
            object val_34 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
            val_39 = 0;
            if((System.String.op_Equality(a:  com.adjust.sdk.AdjustAndroid.ajcAdjust, b:  1098586544)) != true)
            {
                    val_74 = null;
                val_74 = null;
                object val_36 = com.adjust.sdk.AdjustAndroid.ajcAdjust.Get<System.Object>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
                val_39 = com.adjust.sdk.AdjustAndroid.ajcAdjust;
            }
            
            typeof(com.adjust.sdk.AdjustAttribution).__il2cppRuntimeField_40 = val_39;
            return;
            label_10:
            val_41 = 0;
        }
        public static void AddSessionPartnerParameter(string key, string value)
        {
            var val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = key;
            typeof(System.Object[]).__il2cppRuntimeField_14 = value;
            CallStatic(methodName:  1361371248, args:  472754880);
        }
        public static void AddSessionCallbackParameter(string key, string value)
        {
            var val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = key;
            typeof(System.Object[]).__il2cppRuntimeField_14 = value;
            CallStatic(methodName:  1361499760, args:  472754880);
        }
        public static void RemoveSessionPartnerParameter(string key)
        {
            var val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = key;
            CallStatic(methodName:  1361624176, args:  472754880);
        }
        public static void RemoveSessionCallbackParameter(string key)
        {
            var val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = key;
            CallStatic(methodName:  1361744496, args:  472754880);
        }
        public static void ResetSessionPartnerParameters()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            CallStatic(methodName:  1361860720, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void ResetSessionCallbackParameters()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            CallStatic(methodName:  1361972848, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void AppWillOpenUrl(string url)
        {
            var val_3;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1362089072);
            typeof(System.Object[]).__il2cppRuntimeField_10 = url;
            UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1362089184, args:  472754880);
            val_3 = null;
            val_3 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362089264, args:  472754880);
        }
        public static void TrackAdRevenue(string source, string payload)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == 0)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
                val_4 = null;
                val_4 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = payload;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  1362213648, args:  472754880);
            val_5 = null;
            val_5 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = source;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            CallStatic(methodName:  1362213760, args:  472754880);
        }
        public static void TrackPlayStoreSubscription(com.adjust.sdk.AdjustPlayStoreSubscription subscription)
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<System.String> val_6;
            float val_7;
            System.Collections.Generic.List<System.String> val_8;
            var val_9;
            val_4 = null;
            long val_1 = System.Convert.ToInt64(value:  subscription.price);
            val_5 = 1152921504620052480;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = subscription.currency;
            typeof(System.Object[]).__il2cppRuntimeField_18 = subscription.sku;
            typeof(System.Object[]).__il2cppRuntimeField_1C = subscription.orderId;
            typeof(System.Object[]).__il2cppRuntimeField_20 = subscription.signature;
            typeof(System.Object[]).__il2cppRuntimeField_24 = subscription.purchaseToken;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  1362362720, args:  472754880);
            if(subscription.purchaseTime != null)
            {
                    val_4 = null;
                long val_3 = System.Convert.ToInt64(value:  subscription.purchaseTime);
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                Call(methodName:  1362371072, args:  472754880);
            }
            
            val_6 = subscription.callbackList;
            if(val_6 == 0)
            {
                goto label_31;
            }
            
            val_4 = 0;
            goto label_32;
            label_46:
            if(null <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_7 = 1;
            if(val_4 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = (0 + 0) + 16;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "setPurchaseTime".__il2cppRuntimeField_14;
            Call(methodName:  1360123760, args:  472754880);
            val_6 = subscription.callbackList;
            val_4 = val_7 + 1;
            label_32:
            if(val_4 < null)
            {
                goto label_46;
            }
            
            label_31:
            val_8 = subscription.partnerList;
            if(val_8 == 0)
            {
                goto label_47;
            }
            
            val_4 = 0;
            val_7 = "addPartnerParameter";
            goto label_48;
            label_62:
            if(null <= val_4)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if(val_5 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = (0 + 0) + 16;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "addCallbackParameter".__il2cppRuntimeField_14;
            Call(methodName:  1360140256, args:  472754880);
            val_8 = subscription.partnerList;
            val_4 = 1 + 1;
            label_48:
            if(val_4 < null)
            {
                goto label_62;
            }
            
            label_47:
            val_9 = null;
            val_9 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362403952, args:  472754880);
        }
        public static void TrackThirdPartySharing(com.adjust.sdk.AdjustThirdPartySharing thirdPartySharing)
        {
            UnityEngine.AndroidJavaObject val_7;
            var val_8;
            if(0 != 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  1359895472, args:  472754880);
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                val_7 = null;
                val_7 = new UnityEngine.AndroidJavaObject(className:  1362589808, args:  472754880);
            }
            else
            {
                    val_7 = null;
                val_7 = new UnityEngine.AndroidJavaObject(className:  1362589808, args:  null);
            }
            
            if(thirdPartySharing.granularOptions == 0)
            {
                goto label_12;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = thirdPartySharing.isEnabled.Value.GetEnumerator();
            label_15:
            if(0.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_10 = 0;
            label_29:
            if(val_10 >= 1600075380)
            {
                goto label_15;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = ;
            if(1600075380 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 1397643871;
            val_8 = val_8 + 0;
            typeof(System.Object[]).__il2cppRuntimeField_14 = (1397643871 + 0) + 16;
            var val_7 = val_10 + 1;
            if(1600075380 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 1397643871;
            val_9 = val_9 + 0;
            typeof(System.Object[]).__il2cppRuntimeField_18 = (1397643871 + 0) + 20;
            val_10 = val_7 + 1;
            Call(methodName:  1362596096, args:  472754880);
            goto label_29;
            label_13:
            0.Dispose();
            label_12:
            val_8 = null;
            val_8 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_7;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362597232, args:  472754880);
        }
        public static void TrackMeasurementConsent(bool measurementConsent)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362717536, args:  472754880);
        }
        public static void OnPause()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362829664, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void OnResume()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1362941760, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public static void SetReferrer(string referrer)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = referrer;
            typeof(System.Object[]).__il2cppRuntimeField_14 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1363057952, args:  472754880);
        }
        public static void GetGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            var val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            typeof(System.Object[]).__il2cppRuntimeField_14 = new AdjustAndroid.DeviceIdsReadListener(pCallback:  onDeviceIdsRead);
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  -1861587024, args:  472754880);
        }
        public static string GetAmazonAdId()
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1363294336, args:  472754880);
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1363294336, args:  472754880);
        }
        public static string GetSdkVersion()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1363406432, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return 1363406528 + com.adjust.sdk.AdjustAndroid.ajcAdjust;
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            null = null;
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustUtils.TestOptionsMap2AndroidJavaObject(testOptionsMap:  testOptions, ajoCurrentActivity:  com.adjust.sdk.AdjustAndroid.ajoCurrentActivity);
            typeof(System.Object[]).__il2cppRuntimeField_10 = testOptions;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  1363522720, args:  472754880);
        }
        private static bool IsAppSecretSet(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            if(R1 == 0)
            {
                    return false;
            }
            
            return false;
        }
        public AdjustAndroid()
        {
        
        }
        private static AdjustAndroid()
        {
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = true;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1361371136);
            com.adjust.sdk.AdjustAndroid.ajcAdjust = null;
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_3 = GetStatic<System.Object>(fieldName:  1282231936);
            com.adjust.sdk.AdjustAndroid.ajoCurrentActivity = null;
        }
    
    }

}
