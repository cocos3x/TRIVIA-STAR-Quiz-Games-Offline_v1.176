using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustSessionFailure
    {
        // Fields
        private string <Adid>k__BackingField;
        private string <Message>k__BackingField;
        private string <Timestamp>k__BackingField;
        private bool <WillRetry>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <JsonResponse>k__BackingField;
        
        // Properties
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
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
        public AdjustSessionFailure()
        {
        
        }
        public AdjustSessionFailure(System.Collections.Generic.Dictionary<string, string> sessionFailureDataMap)
        {
            string val_12;
            var val_13;
            var val_14;
            val_12 = 35639585;
            if(sessionFailureDataMap == 0)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<Adid>k__BackingField = sessionFailureDataMap;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyMessage);
            this.<Message>k__BackingField = sessionFailureDataMap;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            this.<Timestamp>k__BackingField = sessionFailureDataMap;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
            val_12 = sessionFailureDataMap;
            bool val_6 = System.Boolean.TryParse(value:  val_12, result: out  bool val_5 = true);
            if(val_6 == true)
            {
                    val_6 = 0;
                this.<WillRetry>k__BackingField = false;
            }
            
            val_14 = null;
            val_14 = null;
            string val_7 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
            com.adjust.sdk.JSONNode val_8 = com.adjust.sdk.JSONNode.Parse(aJSON:  sessionFailureDataMap);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  sessionFailureDataMap, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  sessionFailureDataMap, b:  0)) == true)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<JsonResponse>k__BackingField = val_12;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  sessionFailureDataMap, output:  this.<JsonResponse>k__BackingField);
        }
        public AdjustSessionFailure(string jsonString)
        {
            string val_11;
            var val_12;
            val_11 = 35639586;
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSONNode.Parse(aJSON:  jsonString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            string val_3 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<Adid>k__BackingField = jsonString;
            string val_4 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyMessage);
            this.<Message>k__BackingField = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            this.<Timestamp>k__BackingField = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
            this.<WillRetry>k__BackingField = System.Convert.ToBoolean(value:  jsonString);
            val_11 = com.adjust.sdk.AdjustUtils.KeyJsonResponse;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) != false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
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
