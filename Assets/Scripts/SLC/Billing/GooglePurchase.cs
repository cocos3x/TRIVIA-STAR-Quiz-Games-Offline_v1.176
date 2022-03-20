using UnityEngine;

namespace SLC.Billing
{
    public class GooglePurchase
    {
        // Fields
        private string <packageName>k__BackingField;
        private string <orderId>k__BackingField;
        private string <sku>k__BackingField;
        private string <developerPayload>k__BackingField;
        private string <type>k__BackingField;
        private long <purchaseTime>k__BackingField;
        private SLC.Billing.GooglePurchase.GooglePurchaseState <purchaseState>k__BackingField;
        private int <state>k__BackingField;
        private bool <isAcknowledged>k__BackingField;
        private string <purchaseToken>k__BackingField;
        private string <signature>k__BackingField;
        private string <originalJson>k__BackingField;
        
        // Properties
        public string packageName { get; set; }
        public string orderId { get; set; }
        public string sku { get; set; }
        public string developerPayload { get; set; }
        public string type { get; set; }
        public long purchaseTime { get; set; }
        public SLC.Billing.GooglePurchase.GooglePurchaseState purchaseState { get; set; }
        public int state { get; set; }
        public bool isAcknowledged { get; set; }
        public string purchaseToken { get; set; }
        public string signature { get; set; }
        public string originalJson { get; set; }
        
        // Methods
        public string get_packageName()
        {
        
        }
        private void set_packageName(string value)
        {
            this.<packageName>k__BackingField = value;
        }
        public string get_orderId()
        {
        
        }
        private void set_orderId(string value)
        {
            this.<orderId>k__BackingField = value;
        }
        public string get_sku()
        {
        
        }
        private void set_sku(string value)
        {
            this.<sku>k__BackingField = value;
        }
        public string get_developerPayload()
        {
        
        }
        private void set_developerPayload(string value)
        {
            this.<developerPayload>k__BackingField = value;
        }
        public string get_type()
        {
        
        }
        private void set_type(string value)
        {
            this.<type>k__BackingField = value;
        }
        public long get_purchaseTime()
        {
            return (long)this.<purchaseTime>k__BackingField;
        }
        private void set_purchaseTime(long value)
        {
            this.<purchaseTime>k__BackingField = ;
            mem[1152921514298025332] = R3;
        }
        public SLC.Billing.GooglePurchase.GooglePurchaseState get_purchaseState()
        {
        
        }
        private void set_purchaseState(SLC.Billing.GooglePurchase.GooglePurchaseState value)
        {
            this.<purchaseState>k__BackingField = value;
        }
        public int get_state()
        {
            return (int)this.<state>k__BackingField;
        }
        private void set_state(int value)
        {
            this.<state>k__BackingField = value;
        }
        public bool get_isAcknowledged()
        {
            return (bool)this.<isAcknowledged>k__BackingField;
        }
        private void set_isAcknowledged(bool value)
        {
            this.<isAcknowledged>k__BackingField = value;
        }
        public string get_purchaseToken()
        {
        
        }
        private void set_purchaseToken(string value)
        {
            this.<purchaseToken>k__BackingField = value;
        }
        public string get_signature()
        {
        
        }
        private void set_signature(string value)
        {
            this.<signature>k__BackingField = value;
        }
        public string get_originalJson()
        {
        
        }
        public void set_originalJson(string value)
        {
            this.<originalJson>k__BackingField = value;
        }
        public static System.Collections.Generic.List<SLC.Billing.GooglePurchase> fromList(System.Collections.Generic.List<object> items)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            SLC.Billing.GooglePurchase val_5 = new SLC.Billing.GooglePurchase(dict:  0);
            Add(item:  457080832);
            goto label_7;
            label_2:
            Dispose();
        }
        public GooglePurchase(System.Collections.Generic.Dictionary<string, object> dict)
        {
            string val_36;
            if((dict.ContainsKey(key:  -269798800)) != false)
            {
                    object val_2 = dict.Item[-269798800];
                string val_3 = dict.ToString();
                this.<packageName>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  1102867600)) != false)
            {
                    object val_5 = dict.Item[1102867600];
                string val_6 = dict.ToString();
                this.<orderId>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  -1792403808)) != false)
            {
                    object val_8 = dict.Item[-1792403808];
                string val_9 = dict.ToString();
                this.<sku>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  1630180784)) != false)
            {
                    object val_11 = dict.Item[1630180784];
                string val_12 = dict.ToString();
                this.<developerPayload>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  1350676976)) != false)
            {
                    object val_14 = dict.Item[1350676976];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_36 = 0;
            }
            
            }
            else
            {
                    val_36 = 0;
            }
            
                this.<type>k__BackingField = val_36;
            }
            
            if((dict.ContainsKey(key:  1612001888)) != false)
            {
                    object val_16 = dict.Item[1612001888];
                string val_17 = dict.ToString();
                this.<purchaseTime>k__BackingField = System.Int64.Parse(s:  dict);
            }
            
            if((dict.ContainsKey(key:  1102867696)) != false)
            {
                    object val_20 = dict.Item[1102867696];
                string val_21 = dict.ToString();
                int val_22 = System.Int32.Parse(s:  dict);
                this.<purchaseState>k__BackingField = val_22;
                this.<state>k__BackingField = val_22;
            }
            
            if((dict.ContainsKey(key:  1102867792)) != false)
            {
                    object val_24 = dict.Item[1102867792];
                string val_25 = dict.ToString();
                this.<isAcknowledged>k__BackingField = System.Boolean.Parse(value:  dict);
            }
            
            if((dict.ContainsKey(key:  1612001696)) != false)
            {
                    object val_28 = dict.Item[1612001696];
                string val_29 = dict.ToString();
                this.<purchaseToken>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  1470913968)) != false)
            {
                    object val_31 = dict.Item[1470913968];
                string val_32 = dict.ToString();
                this.<signature>k__BackingField = dict;
            }
            
            if((dict.ContainsKey(key:  -1876049488)) == false)
            {
                    return;
            }
            
            object val_34 = dict.Item[-1876049488];
            string val_35 = dict.ToString();
            this.<originalJson>k__BackingField = dict;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.<packageName>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.<orderId>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.<sku>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.<developerPayload>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.<purchaseToken>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.<signature>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_2C = this.<type>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.<originalJson>k__BackingField;
            string val_1 = System.String.Format(format:  1103020848, args:  472754880);
        }
    
    }

}
