using UnityEngine;

namespace HSMiniJSON
{
    public static class Json
    {
        // Methods
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    json = 0;
                return;
            }
            
            return Json.Parser.Parse(jsonString:  null);
        }
        public static string Serialize(object obj)
        {
            return Json.Serializer.Serialize(obj:  obj);
        }
    
    }

}
