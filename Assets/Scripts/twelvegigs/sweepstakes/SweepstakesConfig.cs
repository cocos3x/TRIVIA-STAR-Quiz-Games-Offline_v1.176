using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public class SweepstakesConfig : ScriptableObject
    {
        // Fields
        public string serverUrl;
        public string stagingServerUrl;
        public string apiKey;
        public string apiSecret;
        public int campaignId;
        
        // Methods
        public SweepstakesConfig()
        {
            this.apiSecret = "";
            this.campaignId = 1;
        }
    
    }

}
