using UnityEngine;

namespace SLC.Billing
{
    public class GoogleSkuInfo
    {
        // Fields
        private string <title>k__BackingField;
        private string <price>k__BackingField;
        private string <type>k__BackingField;
        private string <description>k__BackingField;
        private string <sku>k__BackingField;
        private string <priceCurrencyCode>k__BackingField;
        private long <priceAmountMicros>k__BackingField;
        
        // Properties
        public string title { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string sku { get; set; }
        public string priceCurrencyCode { get; set; }
        public long priceAmountMicros { get; set; }
        
        // Methods
        public string get_title()
        {
        
        }
        private void set_title(string value)
        {
            this.<title>k__BackingField = value;
        }
        public string get_price()
        {
        
        }
        private void set_price(string value)
        {
            this.<price>k__BackingField = value;
        }
        public string get_type()
        {
        
        }
        private void set_type(string value)
        {
            this.<type>k__BackingField = value;
        }
        public string get_description()
        {
        
        }
        private void set_description(string value)
        {
            this.<description>k__BackingField = value;
        }
        public string get_sku()
        {
        
        }
        private void set_sku(string value)
        {
            this.<sku>k__BackingField = value;
        }
        public string get_priceCurrencyCode()
        {
        
        }
        private void set_priceCurrencyCode(string value)
        {
            this.<priceCurrencyCode>k__BackingField = value;
        }
        public long get_priceAmountMicros()
        {
            return (long)this.<priceAmountMicros>k__BackingField;
        }
        private void set_priceAmountMicros(long value)
        {
            this.<priceAmountMicros>k__BackingField = ;
            mem[1152921514301530004] = R3;
        }
        public static System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo> fromList(System.Collections.Generic.List<object> items)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            SLC.Billing.GoogleSkuInfo val_5 = new SLC.Billing.GoogleSkuInfo(dict:  0);
            Add(item:  457187328);
            goto label_7;
            label_2:
            Dispose();
        }
        public GoogleSkuInfo(System.Collections.Generic.Dictionary<string, object> dict)
        {
            string val_16;
            string val_17;
            string val_18;
            string val_19;
            string val_20;
            string val_21;
            var val_22;
            if((dict.ContainsKey(key:  1610240272)) != false)
            {
                    object val_2 = dict.Item[1610240272];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_16 = 0;
            }
            
            }
            else
            {
                    val_16 = 0;
            }
            
                this.<title>k__BackingField = val_16;
            }
            
            if((dict.ContainsKey(key:  1610240448)) != false)
            {
                    object val_4 = dict.Item[1610240448];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_17 = 0;
            }
            
            }
            else
            {
                    val_17 = 0;
            }
            
                this.<price>k__BackingField = val_17;
            }
            
            if((dict.ContainsKey(key:  1350676976)) != false)
            {
                    object val_6 = dict.Item[1350676976];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_18 = 0;
            }
            
            }
            else
            {
                    val_18 = 0;
            }
            
                this.<type>k__BackingField = val_18;
            }
            
            if((dict.ContainsKey(key:  1630059280)) != false)
            {
                    object val_8 = dict.Item[1630059280];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_19 = 0;
            }
            
            }
            else
            {
                    val_19 = 0;
            }
            
                this.<description>k__BackingField = val_19;
            }
            
            if((dict.ContainsKey(key:  -1792403808)) != false)
            {
                    object val_10 = dict.Item[-1792403808];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_20 = 0;
            }
            
            }
            else
            {
                    val_20 = 0;
            }
            
                this.<sku>k__BackingField = val_20;
            }
            
            if((dict.ContainsKey(key:  1104962736)) != false)
            {
                    object val_12 = dict.Item[1104962736];
                if(dict != 0)
            {
                    if(null != null)
            {
                    val_21 = 0;
            }
            
            }
            else
            {
                    val_21 = 0;
            }
            
                this.<priceCurrencyCode>k__BackingField = val_21;
            }
            
            if((dict.ContainsKey(key:  1104962848)) == false)
            {
                    return;
            }
            
            object val_14 = dict.Item[1104962848];
            if(dict != 0)
            {
                    if(null != null)
            {
                    val_22 = 0;
            }
            
            }
            else
            {
                    val_22 = 0;
            }
            
            this.<priceAmountMicros>k__BackingField = System.Int64.Parse(s:  null);
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.<title>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.<price>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.<type>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.<description>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.<sku>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_24 = this.<priceCurrencyCode>k__BackingField;
            return System.String.Format(format:  1105103632, args:  472754880);
        }
    
    }

}
