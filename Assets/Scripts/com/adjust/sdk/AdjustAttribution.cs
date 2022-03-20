using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAttribution
    {
        // Fields
        private string <adid>k__BackingField;
        private string <network>k__BackingField;
        private string <adgroup>k__BackingField;
        private string <campaign>k__BackingField;
        private string <creative>k__BackingField;
        private string <clickLabel>k__BackingField;
        private string <trackerName>k__BackingField;
        private string <trackerToken>k__BackingField;
        private string <costType>k__BackingField;
        private System.Nullable<double> <costAmount>k__BackingField;
        private string <costCurrency>k__BackingField;
        
        // Properties
        public string adid { get; set; }
        public string network { get; set; }
        public string adgroup { get; set; }
        public string campaign { get; set; }
        public string creative { get; set; }
        public string clickLabel { get; set; }
        public string trackerName { get; set; }
        public string trackerToken { get; set; }
        public string costType { get; set; }
        public System.Nullable<double> costAmount { get; set; }
        public string costCurrency { get; set; }
        
        // Methods
        public string get_adid()
        {
        
        }
        public void set_adid(string value)
        {
            this.<adid>k__BackingField = value;
        }
        public string get_network()
        {
        
        }
        public void set_network(string value)
        {
            this.<network>k__BackingField = value;
        }
        public string get_adgroup()
        {
        
        }
        public void set_adgroup(string value)
        {
            this.<adgroup>k__BackingField = value;
        }
        public string get_campaign()
        {
        
        }
        public void set_campaign(string value)
        {
            this.<campaign>k__BackingField = value;
        }
        public string get_creative()
        {
        
        }
        public void set_creative(string value)
        {
            this.<creative>k__BackingField = value;
        }
        public string get_clickLabel()
        {
        
        }
        public void set_clickLabel(string value)
        {
            this.<clickLabel>k__BackingField = value;
        }
        public string get_trackerName()
        {
        
        }
        public void set_trackerName(string value)
        {
            this.<trackerName>k__BackingField = value;
        }
        public string get_trackerToken()
        {
        
        }
        public void set_trackerToken(string value)
        {
            this.<trackerToken>k__BackingField = value;
        }
        public string get_costType()
        {
        
        }
        public void set_costType(string value)
        {
            this.<costType>k__BackingField = value;
        }
        public System.Nullable<double> get_costAmount()
        {
            var val_1 = R1 + 48;
            return (System.Nullable<System.Double>)this;
        }
        public void set_costAmount(System.Nullable<double> value)
        {
            this.<costAmount>k__BackingField = new System.Nullable<System.Double>();
            mem[1152921514569997876] = ???;
            mem[1152921514569997880] = ???;
            mem[1152921514569997884] = ???;
        }
        public string get_costCurrency()
        {
        
        }
        public void set_costCurrency(string value)
        {
            this.<costCurrency>k__BackingField = value;
        }
        public AdjustAttribution()
        {
        
        }
        public AdjustAttribution(string jsonString)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_17 = 35639553;
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSONNode.Parse(aJSON:  jsonString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            val_18 = null;
            val_18 = null;
            string val_3 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            this.<trackerName>k__BackingField = jsonString;
            string val_4 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            this.<trackerToken>k__BackingField = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            this.<network>k__BackingField = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            this.<campaign>k__BackingField = jsonString;
            string val_7 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            this.<adgroup>k__BackingField = jsonString;
            string val_8 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCreative);
            this.<creative>k__BackingField = jsonString;
            string val_9 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            this.<clickLabel>k__BackingField = jsonString;
            string val_10 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<adid>k__BackingField = jsonString;
            string val_11 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCostType);
            this.<costType>k__BackingField = jsonString;
            val_19 = null;
            val_19 = null;
            string val_12 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
            System.Globalization.CultureInfo val_13 = System.Globalization.CultureInfo.InvariantCulture;
            System.Nullable<System.Double> val_15 = new System.Nullable<System.Double>(value:  System.Double.Parse(s:  jsonString, provider:  0));
            val_20 = null;
            val_20 = null;
            string val_16 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
            this.<costCurrency>k__BackingField = jsonString;
        }
        public AdjustAttribution(System.Collections.Generic.Dictionary<string, string> dicAttributionData)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = 35639554;
            if(dicAttributionData == 0)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            this.<trackerName>k__BackingField = dicAttributionData;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            this.<trackerToken>k__BackingField = dicAttributionData;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            this.<network>k__BackingField = dicAttributionData;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            this.<campaign>k__BackingField = dicAttributionData;
            string val_5 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            this.<adgroup>k__BackingField = dicAttributionData;
            string val_6 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyCreative);
            this.<creative>k__BackingField = dicAttributionData;
            string val_7 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            this.<clickLabel>k__BackingField = dicAttributionData;
            string val_8 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<adid>k__BackingField = dicAttributionData;
            string val_9 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyCostType);
            this.<costType>k__BackingField = dicAttributionData;
            val_17 = null;
            val_17 = null;
            string val_10 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
            System.Globalization.CultureInfo val_11 = System.Globalization.CultureInfo.InvariantCulture;
            System.Nullable<System.Double> val_13 = new System.Nullable<System.Double>(value:  System.Double.Parse(s:  dicAttributionData, provider:  0));
            val_18 = null;
            val_18 = null;
            string val_14 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
            this.<costCurrency>k__BackingField = dicAttributionData;
        }
    
    }

}
