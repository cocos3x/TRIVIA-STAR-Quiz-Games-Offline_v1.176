using UnityEngine;

namespace com.adjust.sdk
{
    public static class JSON
    {
        // Methods
        public static com.adjust.sdk.JSONNode Parse(string aJSON)
        {
            return com.adjust.sdk.JSONNode.Parse(aJSON:  aJSON);
        }
    
    }

}
