using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustUtils
    {
        // Fields
        public static string KeyAdid;
        public static string KeyMessage;
        public static string KeyNetwork;
        public static string KeyAdgroup;
        public static string KeyCampaign;
        public static string KeyCreative;
        public static string KeyWillRetry;
        public static string KeyTimestamp;
        public static string KeyCallbackId;
        public static string KeyEventToken;
        public static string KeyClickLabel;
        public static string KeyTrackerName;
        public static string KeyTrackerToken;
        public static string KeyJsonResponse;
        public static string KeyCostType;
        public static string KeyCostAmount;
        public static string KeyCostCurrency;
        public static string KeyTestOptionsBaseUrl;
        public static string KeyTestOptionsGdprUrl;
        public static string KeyTestOptionsSubscriptionUrl;
        public static string KeyTestOptionsExtraPath;
        public static string KeyTestOptionsBasePath;
        public static string KeyTestOptionsGdprPath;
        public static string KeyTestOptionsDeleteState;
        public static string KeyTestOptionsUseTestConnectionOptions;
        public static string KeyTestOptionsTimerIntervalInMilliseconds;
        public static string KeyTestOptionsTimerStartInMilliseconds;
        public static string KeyTestOptionsSessionIntervalInMilliseconds;
        public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
        public static string KeyTestOptionsTeardown;
        public static string KeyTestOptionsNoBackoffWait;
        public static string KeyTestOptionsiAdFrameworkEnabled;
        public static string KeyTestOptionsAdServicesFrameworkEnabled;
        
        // Methods
        public static int ConvertLogLevel(System.Nullable<com.adjust.sdk.AdjustLogLevel> logLevel)
        {
            var val_2;
            if((R1 & 255) == 0)
            {
                    val_2;
                System.Int32Enum val_1 = logLevel.HasValue.Value;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public static int ConvertBool(System.Nullable<bool> value)
        {
            if(((uint)value.HasValue & 65535) >= 256)
            {
                    return (int)value.HasValue.Value;
            }
            
            return 0;
        }
        public static double ConvertDouble(System.Nullable<double> value)
        {
            bool val_2;
            double val_3;
            val_2 = static_value_021FD12D;
            if((R2 & 255) == 0)
            {
                    val_2 = public System.Double System.Nullable<System.Double>::get_Value();
                double val_1 = value.HasValue.Value;
                val_3 = 1388007936;
                return (double)D0;
            }
            
            val_3 = -1;
            return (double)D0;
        }
        public static long ConvertLong(System.Nullable<long> value)
        {
            var val_2;
            if((R2 & 255) == 0)
            {
                    long val_1 = value.HasValue.Value;
                return (long)val_2;
            }
            
            val_2 = 0;
            return (long)val_2;
        }
        public static string ConvertListToJson(System.Collections.Generic.List<string> list)
        {
            var val_4;
            if(list == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            object val_5 = new System.Object();
            typeof(com.adjust.sdk.JSONData).__il2cppRuntimeField_8 = val_4;
            Add(aItem:  470286336);
            goto label_4;
            label_2:
            Dispose();
            if(new com.adjust.sdk.JSONArray() != 0)
            {
                    return;
            }
        
        }
        public static string GetJsonResponseCompact(System.Collections.Generic.Dictionary<string, object> dictionary)
        {
            var val_5;
            var val_15;
            var val_16;
            var val_17;
            if(dictionary == 0)
            {
                    return;
            }
            
            string val_1 = 1098586544 + 1466574400;
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            var val_15 = 0;
            label_50:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_15 = 0;
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(((val_5 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_5 = 0;
            }
            
            val_15 = val_5;
            label_5:
            val_15 = val_15 + 1;
            if(val_15 < 2)
            {
                    val_16 = "";
            }
            else
            {
                    string val_6 = 1098586544 + 1492657312;
                val_16 = "";
            }
            
            string val_7 = 1098586544 + 1377638992 + null + 1198625552;
            string val_8 = 1098586544 + null;
            goto label_50;
            label_4:
            val_15 = val_15 + 1;
            if(val_15 < 2)
            {
                    val_17 = "";
            }
            else
            {
                    string val_9 = 1098586544 + 1492657312;
                val_17 = "";
            }
            
            if(((val_5.StartsWith(value:  1466574400)) == false) || ((val_5.EndsWith(value:  1487337936)) == false))
            {
                goto label_15;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_10 = val_17;
            typeof(System.String[]).__il2cppRuntimeField_14 = "\"";
            typeof(System.String[]).__il2cppRuntimeField_18 = 0;
            typeof(System.String[]).__il2cppRuntimeField_1C = "\":";
            typeof(System.String[]).__il2cppRuntimeField_20 = val_5;
            string val_12 = +477709520;
            goto label_50;
            label_15:
            typeof(System.String[]).__il2cppRuntimeField_10 = val_17;
            typeof(System.String[]).__il2cppRuntimeField_14 = "\"";
            typeof(System.String[]).__il2cppRuntimeField_18 = 0;
            typeof(System.String[]).__il2cppRuntimeField_1C = "\":\"";
            typeof(System.String[]).__il2cppRuntimeField_20 = val_5;
            typeof(System.String[]).__il2cppRuntimeField_24 = "\"";
            string val_13 = +477709520;
            goto label_50;
            label_2:
            0.Dispose();
            string val_14 = 1098586544 + 1487337936;
        }
        public static string GetJsonString(com.adjust.sdk.JSONNode node, string key)
        {
            var val_4;
            var val_5;
            val_4 = 35639601;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  node, b:  0)) == true)
            {
                    return;
            }
            
            val_5 = 0;
            if(node != 0)
            {
                    if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (com.adjust.sdk.JSONData.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    node = 0;
            }
            
                val_5 = node;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  1098586544)) != false)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                
            }
        
        }
        public static void WriteJsonResponseDictionary(com.adjust.sdk.JSONClass jsonObject, System.Collections.Generic.Dictionary<string, object> output)
        {
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Collections.IEnumerator val_1 = jsonObject.GetEnumerator();
            val_11 = 1152921504683417600;
            val_12 = 1152921510535002416;
            label_24:
            val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = jsonObject;
            if(jsonObject == 0)
            {
                goto label_7;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_15 = jsonObject;
            val_16 = 0;
            com.adjust.sdk.JSONClass val_4 = jsonObject.AsObject;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonObject, b:  0)) == false)
            {
                goto label_17;
            }
            
            string val_6 = jsonObject.Value;
            output.Add(key:  470073344, value:  jsonObject);
            goto label_24;
            label_17:
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            output.Add(key:  470073344, value:  78753792);
            goto label_24;
            label_7:
            val_17 = 0;
            val_18 = 1152921504619679744;
            if(jsonObject != 0)
            {
                    val_13 = 0;
                val_18 = 0;
                val_13 = val_13 + 1;
                val_18 = (uint)val_13 & 65535;
                val_19 = jsonObject;
            }
            
            var val_9 = FP - 28;
        }
        public static string TryGetValue(System.Collections.Generic.Dictionary<string, string> dictionary, string key)
        {
            if((dictionary.TryGetValue(key:  key, value: out  string val_1 = 1388737364)) == false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  null, b:  1098586544)) == true)
            {
                    0 = 0;
            }
        
        }
        public static UnityEngine.AndroidJavaObject TestOptionsMap2AndroidJavaObject(System.Collections.Generic.Dictionary<string, string> testOptionsMap, UnityEngine.AndroidJavaObject ajoCurrentActivity)
        {
            if(mem[35639604] != true)
            {
                
            }
        
        }
        public AdjustUtils()
        {
        
        }
        private static AdjustUtils()
        {
            com.adjust.sdk.AdjustUtils.KeyAdid = "adid";
            com.adjust.sdk.AdjustUtils.KeyMessage = "message";
            com.adjust.sdk.AdjustUtils.KeyNetwork = "network";
            com.adjust.sdk.AdjustUtils.KeyAdgroup = "adgroup";
            com.adjust.sdk.AdjustUtils.KeyCampaign = "campaign";
            com.adjust.sdk.AdjustUtils.KeyCreative = "creative";
            com.adjust.sdk.AdjustUtils.KeyWillRetry = "willRetry";
            com.adjust.sdk.AdjustUtils.KeyTimestamp = "timestamp";
            com.adjust.sdk.AdjustUtils.KeyCallbackId = "callbackId";
            com.adjust.sdk.AdjustUtils.KeyEventToken = "eventToken";
            com.adjust.sdk.AdjustUtils.KeyClickLabel = "clickLabel";
            com.adjust.sdk.AdjustUtils.KeyTrackerName = "trackerName";
            com.adjust.sdk.AdjustUtils.KeyTrackerToken = "trackerToken";
            com.adjust.sdk.AdjustUtils.KeyJsonResponse = "jsonResponse";
            com.adjust.sdk.AdjustUtils.KeyCostType = "costType";
            com.adjust.sdk.AdjustUtils.KeyCostAmount = "costAmount";
            com.adjust.sdk.AdjustUtils.KeyCostCurrency = "costCurrency";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsBaseUrl = "baseUrl";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprUrl = "gdprUrl";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsSubscriptionUrl = "subscriptionUrl";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsExtraPath = "extraPath";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsBasePath = "basePath";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprPath = "gdprPath";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsDeleteState = "deleteState";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsUseTestConnectionOptions = "useTestConnectionOptions";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerIntervalInMilliseconds = "timerIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerStartInMilliseconds = "timerStartInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsSessionIntervalInMilliseconds = "sessionIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsSubsessionIntervalInMilliseconds = "subsessionIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTeardown = "teardown";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsNoBackoffWait = "noBackoffWait";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsiAdFrameworkEnabled = "iAdFrameworkEnabled";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsAdServicesFrameworkEnabled = "adServicesFrameworkEnabled";
        }
    
    }

}
