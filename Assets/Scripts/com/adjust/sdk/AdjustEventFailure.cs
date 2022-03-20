using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustEventFailure
    {
        // Fields
        private string <Adid>k__BackingField;
        private string <Message>k__BackingField;
        private string <Timestamp>k__BackingField;
        private string <EventToken>k__BackingField;
        private string <CallbackId>k__BackingField;
        private bool <WillRetry>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <JsonResponse>k__BackingField;
        
        // Properties
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public string EventToken { get; set; }
        public string CallbackId { get; set; }
        public bool WillRetry { get; set; }
        public System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }
        
        // Methods
        public string get_Adid()
        {
        
        }
        public void set_Adid(string value)
        {
            this.<Adid>k__BackingField = value;
        }
        public string get_Message()
        {
        
        }
        public void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        public string get_Timestamp()
        {
        
        }
        public void set_Timestamp(string value)
        {
            this.<Timestamp>k__BackingField = value;
        }
        public string get_EventToken()
        {
        
        }
        public void set_EventToken(string value)
        {
            this.<EventToken>k__BackingField = value;
        }
        public string get_CallbackId()
        {
        
        }
        public void set_CallbackId(string value)
        {
            this.<CallbackId>k__BackingField = value;
        }
        public bool get_WillRetry()
        {
            return (bool)this.<WillRetry>k__BackingField;
        }
        public void set_WillRetry(bool value)
        {
            this.<WillRetry>k__BackingField = value;
        }
        public System.Collections.Generic.Dictionary<string, object> get_JsonResponse()
        {
        
        }
        public void set_JsonResponse(System.Collections.Generic.Dictionary<string, object> value)
        {
            this.<JsonResponse>k__BackingField = value;
        }
        public AdjustEventFailure()
        {
        
        }
        public AdjustEventFailure(System.Collections.Generic.Dictionary<string, string> eventFailureDataMap)
        {
            string val_14;
            var val_15;
            var val_16;
            val_14 = 35639573;
            if(eventFailureDataMap == 0)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<Adid>k__BackingField = eventFailureDataMap;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyMessage);
            this.<Message>k__BackingField = eventFailureDataMap;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            this.<Timestamp>k__BackingField = eventFailureDataMap;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            this.<EventToken>k__BackingField = eventFailureDataMap;
            string val_5 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            this.<CallbackId>k__BackingField = eventFailureDataMap;
            string val_6 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
            val_14 = eventFailureDataMap;
            bool val_8 = System.Boolean.TryParse(value:  val_14, result: out  bool val_7 = true);
            if(val_8 == true)
            {
                    val_8 = 0;
                this.<WillRetry>k__BackingField = false;
            }
            
            val_16 = null;
            val_16 = null;
            string val_9 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
            com.adjust.sdk.JSONNode val_10 = com.adjust.sdk.JSONNode.Parse(aJSON:  eventFailureDataMap);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  eventFailureDataMap, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  eventFailureDataMap, b:  0)) == true)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<JsonResponse>k__BackingField = val_14;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  eventFailureDataMap, output:  this.<JsonResponse>k__BackingField);
        }
        public AdjustEventFailure(string jsonString)
        {
            string val_13;
            var val_14;
            val_13 = 35639574;
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSONNode.Parse(aJSON:  jsonString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            string val_3 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<Adid>k__BackingField = jsonString;
            string val_4 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyMessage);
            this.<Message>k__BackingField = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            this.<Timestamp>k__BackingField = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            this.<EventToken>k__BackingField = jsonString;
            string val_7 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            this.<CallbackId>k__BackingField = jsonString;
            string val_8 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
            this.<WillRetry>k__BackingField = System.Convert.ToBoolean(value:  jsonString);
            val_13 = com.adjust.sdk.AdjustUtils.KeyJsonResponse;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) != false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<JsonResponse>k__BackingField = null;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  jsonString, output:  this.<JsonResponse>k__BackingField);
        }
        public void BuildJsonResponseFromString(string jsonResponseString)
        {
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSONNode.Parse(aJSON:  jsonResponseString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonResponseString, b:  0)) != false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<JsonResponse>k__BackingField = null;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  jsonResponseString, output:  this.<JsonResponse>k__BackingField);
        }
        public string GetJsonResponse()
        {
            return com.adjust.sdk.AdjustUtils.GetJsonResponseCompact(dictionary:  this.<JsonResponse>k__BackingField);
        }
    
    }

}
