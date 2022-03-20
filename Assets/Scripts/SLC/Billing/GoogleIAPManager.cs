using UnityEngine;

namespace SLC.Billing
{
    public class GoogleIAPManager : MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>
    {
        // Fields
        private static System.Action billingSupportedEvent;
        private static System.Action<string> billingNotSupportedEvent;
        private static System.Action<System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo>> queryInventorySucceededEvent;
        private static System.Action<string> queryInventoryFailedEvent;
        private static System.Action<SLC.Billing.GooglePurchase> purchaseSucceededEvent;
        private static System.Action<string> purchaseFailedEvent;
        private static System.Action<string, string> consumePurchaseSucceededEvent;
        private static System.Action<string, string> acknowledgePurchaseSucceededEvent;
        private static System.Action<string> consumePurchaseFailedEvent;
        private static System.Action<string> AcknowledgePurchaseFailedEvent;
        private static bool <logEnabled>k__BackingField;
        
        // Properties
        public static bool logEnabled { get; set; }
        
        // Methods
        public static void add_billingSupportedEvent(System.Action value)
        {
            var val_2;
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.billingSupportedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.billingSupportedEvent != 0)
            {
                    val_2 = SLC.Billing.GoogleIAPManager.billingSupportedEvent;
                if(null == null)
            {
                    return;
            }
            
            }
            
            val_2 = 0;
        }
        public static void remove_billingSupportedEvent(System.Action value)
        {
            var val_2;
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.billingSupportedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.billingSupportedEvent != 0)
            {
                    val_2 = SLC.Billing.GoogleIAPManager.billingSupportedEvent;
                if(null == null)
            {
                    return;
            }
            
            }
            
            val_2 = 0;
        }
        public static void add_billingNotSupportedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.billingNotSupportedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.billingNotSupportedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.billingNotSupportedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.billingNotSupportedEvent != 1152921505063878660)
            {
                goto label_3;
            }
        
        }
        public static void remove_billingNotSupportedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.billingNotSupportedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.billingNotSupportedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.billingNotSupportedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.billingNotSupportedEvent != 1152921505063878660)
            {
                goto label_3;
            }
        
        }
        public static void add_queryInventorySucceededEvent(System.Action<System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo>> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent != 1152921505063878664)
            {
                goto label_3;
            }
        
        }
        public static void remove_queryInventorySucceededEvent(System.Action<System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo>> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent != 1152921505063878664)
            {
                goto label_3;
            }
        
        }
        public static void add_queryInventoryFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent != 1152921505063878668)
            {
                goto label_3;
            }
        
        }
        public static void remove_queryInventoryFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent != 1152921505063878668)
            {
                goto label_3;
            }
        
        }
        public static void add_purchaseSucceededEvent(System.Action<SLC.Billing.GooglePurchase> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.purchaseSucceededEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.purchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.purchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.purchaseSucceededEvent != 1152921505063878672)
            {
                goto label_3;
            }
        
        }
        public static void remove_purchaseSucceededEvent(System.Action<SLC.Billing.GooglePurchase> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.purchaseSucceededEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.purchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.purchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.purchaseSucceededEvent != 1152921505063878672)
            {
                goto label_3;
            }
        
        }
        public static void add_purchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.purchaseFailedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.purchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.purchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.purchaseFailedEvent != 1152921505063878676)
            {
                goto label_3;
            }
        
        }
        public static void remove_purchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.purchaseFailedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.purchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.purchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.purchaseFailedEvent != 1152921505063878676)
            {
                goto label_3;
            }
        
        }
        public static void add_consumePurchaseSucceededEvent(System.Action<string, string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent != 1152921505063878680)
            {
                goto label_3;
            }
        
        }
        public static void remove_consumePurchaseSucceededEvent(System.Action<string, string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent != 1152921505063878680)
            {
                goto label_3;
            }
        
        }
        public static void add_acknowledgePurchaseSucceededEvent(System.Action<string, string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent != 1152921505063878684)
            {
                goto label_3;
            }
        
        }
        public static void remove_acknowledgePurchaseSucceededEvent(System.Action<string, string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent != 1152921505063878684)
            {
                goto label_3;
            }
        
        }
        public static void add_consumePurchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent != 1152921505063878688)
            {
                goto label_3;
            }
        
        }
        public static void remove_consumePurchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent != 1152921505063878688)
            {
                goto label_3;
            }
        
        }
        public static void add_AcknowledgePurchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent, b:  value);
            if(SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent != 1152921505063878692)
            {
                goto label_3;
            }
        
        }
        public static void remove_AcknowledgePurchaseFailedEvent(System.Action<string> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent, value:  value);
            if(SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent == 0)
            {
                goto label_1;
            }
            
            val_2 = SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent != 1152921505063878692)
            {
                goto label_3;
            }
        
        }
        public static bool get_logEnabled()
        {
            return (bool)SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField;
        }
        public static void set_logEnabled(bool value)
        {
            SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField = value;
        }
        public void BillingSupported(string empty)
        {
            var val_1 = 25671526;
            val_1 = 9961940 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    UnityEngine.Debug.Log(message:  1098712096);
            }
            
            SLC.Billing.GoogleIAPManager.__il2cppRuntimeField_static_fields.Invoke();
        }
        public void QueryInventorySucceeded(string json)
        {
            var val_4;
            var val_3 = 25671270;
            val_3 = 9962196 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    UnityEngine.Debug.Log(message:  1098832432);
            }
            
            if(SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent == 0)
            {
                    return;
            }
            
            val_4 = 0;
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            if(json != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    json = 0;
            }
            
                val_4 = json;
            }
            
            System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo> val_2 = SLC.Billing.GoogleSkuInfo.fromList(items:  0);
            SLC.Billing.GoogleIAPManager.queryInventorySucceededEvent.Invoke(obj:  0);
        }
        public void queryInventoryFailed(string error)
        {
            SLC.Billing.GoogleIAPManager.queryInventoryFailedEvent.Invoke(obj:  error);
        }
        public void PurchaseSucceeded(string json)
        {
            var val_6;
            var val_8;
            var val_9;
            val_8 = 0;
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            if(json != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    json = 0;
            }
            
                val_8 = json;
            }
            
            var val_8 = 25670162;
            val_8 = 9963304 + val_8;
            if(val_8 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    string val_2 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
                string val_3 = 1099074000 + null;
                UnityEngine.Debug.Log(message:  1099074000);
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_10;
            }
            
            val_9 = 0;
            if(val_6 != 0)
            {
                    if(((val_6 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_6 = 0;
            }
            
                val_9 = val_6;
            }
            
            SLC.Billing.GooglePurchase val_7 = new SLC.Billing.GooglePurchase(dict:  0);
            SLC.Billing.GoogleIAPManager.purchaseSucceededEvent.Invoke(obj:  457080832);
            goto label_14;
            label_10:
            Dispose();
        }
        public void PurchaseFailed(string json)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(SLC.Billing.GoogleIAPManager.purchaseFailedEvent == 0)
            {
                    return;
            }
            
            val_7 = 0;
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            if(json != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    json = 0;
            }
            
                val_7 = json;
            }
            
            var val_7 = 25667786;
            val_7 = 9965680 + val_7;
            if(val_7 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    val_8 = "message";
                if((val_7.ContainsKey(key:  1495692992)) != false)
            {
                    string val_3 = val_7.Item[1495692992];
                val_8 = val_7;
                val_9 = val_8;
            }
            else
            {
                    val_9 = "";
            }
            
                string val_4 = 1099195360 + 1098586544;
                UnityEngine.Debug.LogError(message:  1099195360);
            }
            
            if((val_7.ContainsKey(key:  1706004064)) != false)
            {
                    string val_6 = val_7.Item[1706004064];
                val_10 = val_7;
            }
            else
            {
                    val_10 = "";
            }
            
            SLC.Billing.GoogleIAPManager.purchaseFailedEvent.Invoke(obj:  1098586544);
        }
        public void ConsumePurchaseSucceeded(string json)
        {
            if(SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent == 0)
            {
                    return;
            }
            
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            string val_2 = 0.Item[1099315696];
            string val_3 = 0.Item[1612001696];
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    string val_4 = 1099315792 + null;
                UnityEngine.Debug.Log(message:  1099315792);
            }
            
            SLC.Billing.GoogleIAPManager.consumePurchaseSucceededEvent.Invoke(arg1:  null, arg2:  null);
        }
        public void AcknowledgePurchaseSucceeded(string json)
        {
            if(SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent == 0)
            {
                    return;
            }
            
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            string val_2 = 0.Item[1099315696];
            string val_3 = 0.Item[1612001696];
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    string val_4 = 1099436144 + null;
                UnityEngine.Debug.Log(message:  1099436144);
            }
            
            SLC.Billing.GoogleIAPManager.acknowledgePurchaseSucceededEvent.Invoke(arg1:  null, arg2:  null);
        }
        public void ConsumePurchaseFailed(string json)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent == 0)
            {
                    return;
            }
            
            val_7 = 0;
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            if(json != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    json = 0;
            }
            
                val_7 = json;
            }
            
            var val_7 = 25665906;
            val_7 = 9967560 + val_7;
            if(val_7 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    val_8 = "message";
                if((val_7.ContainsKey(key:  1495692992)) != false)
            {
                    string val_3 = val_7.Item[1495692992];
                val_8 = val_7;
                val_9 = val_8;
            }
            else
            {
                    val_9 = "";
            }
            
                string val_4 = 1099195360 + 1098586544;
                UnityEngine.Debug.Log(message:  1099195360);
            }
            
            if((val_7.ContainsKey(key:  1706004064)) != false)
            {
                    string val_6 = val_7.Item[1706004064];
                val_10 = val_7;
            }
            else
            {
                    val_10 = "";
            }
            
            SLC.Billing.GoogleIAPManager.consumePurchaseFailedEvent.Invoke(obj:  1098586544);
        }
        public void AcknowledgePurchaseFailed(string json)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent == 0)
            {
                    return;
            }
            
            val_7 = 0;
            object val_1 = MiniJSON.Json.Deserialize(json:  json);
            if(json != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    json = 0;
            }
            
                val_7 = json;
            }
            
            var val_7 = 25665186;
            val_7 = 9968280 + val_7;
            if(val_7 == 0)
            {
                    mem2[0] = 1;
            }
            
            if((SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField) != false)
            {
                    val_8 = "message";
                if((val_7.ContainsKey(key:  1495692992)) != false)
            {
                    string val_3 = val_7.Item[1495692992];
                val_8 = val_7;
                val_9 = val_8;
            }
            else
            {
                    val_9 = "";
            }
            
                string val_4 = 1099195360 + 1098586544;
                UnityEngine.Debug.Log(message:  1099195360);
            }
            
            if((val_7.ContainsKey(key:  1706004064)) != false)
            {
                    string val_6 = val_7.Item[1706004064];
                val_10 = val_7;
            }
            else
            {
                    val_10 = "";
            }
            
            SLC.Billing.GoogleIAPManager.AcknowledgePurchaseFailedEvent.Invoke(obj:  1098586544);
        }
        public GoogleIAPManager()
        {
        
        }
    
    }

}
