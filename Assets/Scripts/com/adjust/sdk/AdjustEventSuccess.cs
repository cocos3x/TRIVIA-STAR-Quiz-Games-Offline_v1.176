using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustEventSuccess
    {
        // Fields
        private string <Adid>k__BackingField;
        private string <Message>k__BackingField;
        private string <Timestamp>k__BackingField;
        private string <EventToken>k__BackingField;
        private string <CallbackId>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <JsonResponse>k__BackingField;
        
        // Properties
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public string EventToken { get; set; }
        public string CallbackId { get; set; }
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
        public System.Collections.Generic.Dictionary<string, object> get_JsonResponse()
        {
        
        }
        public void set_JsonResponse(System.Collections.Generic.Dictionary<string, object> value)
        {
            this.<JsonResponse>k__BackingField = value;
        }
        public AdjustEventSuccess()
        {
        
        }
        public AdjustEventSuccess(System.Collections.Generic.Dictionary<string, string> eventSuccessDataMap)
        {
            var val_11;
            if(eventSuccessDataMap == 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyAdid);
            this.<Adid>k__BackingField = eventSuccessDataMap;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyMessage);
            this.<Message>k__BackingField = eventSuccessDataMap;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
            this.<Timestamp>k__BackingField = eventSuccessDataMap;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            this.<EventToken>k__BackingField = eventSuccessDataMap;
            string val_5 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            this.<CallbackId>k__BackingField = eventSuccessDataMap;
            string val_6 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  com.adjust.sdk.AdjustUtils.KeyJsonResponse);
            com.adjust.sdk.JSONNode val_7 = com.adjust.sdk.JSONNode.Parse(aJSON:  eventSuccessDataMap);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  eventSuccessDataMap, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  eventSuccessDataMap, b:  0)) != false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<JsonResponse>k__BackingField = null;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  eventSuccessDataMap, output:  this.<JsonResponse>k__BackingField);
        }
        public AdjustEventSuccess(string jsonString)
        {
            string val_11;
            var val_12;
            val_11 = 35639578;
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
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyEventToken);
            this.<EventToken>k__BackingField = jsonString;
            string val_7 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
            this.<CallbackId>k__BackingField = jsonString;
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
