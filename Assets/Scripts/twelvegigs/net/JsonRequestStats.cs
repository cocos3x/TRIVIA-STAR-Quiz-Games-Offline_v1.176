using UnityEngine;

namespace twelvegigs.net
{
    public struct JsonRequestStats
    {
        // Fields
        public string method;
        public string url;
        public double duration;
        public System.Net.HttpStatusCode responseCode;
        public string jsonParams;
        
    
    }

}
